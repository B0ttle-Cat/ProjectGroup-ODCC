#undef USING_LEGACY_COLLECTOR


using System;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;
using UnityEngine.SceneManagement;

namespace BC.ODCC
{
#if USING_LEGACY_COLLECTOR
	public class OdccCollector : IDisposable
	{
		internal List<OdccLooper> odccLoopers;

		public OdccCollector()
		{
			this.odccLoopers = new List<OdccLooper>();
		}

		internal List<OdccLooper> GetOrgineLooper()
		{
			return odccLoopers;
		}
		internal virtual bool AddItem(object item)
		{
			return true;
		}
		internal virtual bool RemoveItem(object item)
		{
			return true;
		}
		internal virtual bool AddRangeItem(params object[] item)
		{
			return true;
		}
		internal virtual bool RemoveRangeItem(params object[] item)
		{
			return true;
		}

		public virtual void Dispose()
		{
			for(int i = 0 ; i < odccLoopers.Count ; i++)
			{
				OdccForeach.ForeachPrevUpdate.Remove(odccLoopers[i]);
				OdccForeach.ForeachNextUpdate.Remove(odccLoopers[i]);
			}
			odccLoopers.Clear();
		}
	}
	public class OdccCollector<T> : OdccCollector where T : class
	{
		private IEnumerable<T> collection;

		//public TT this[int I] => collection[I];
		public int Count => collection.Count();

		public OdccCollector() : base()
		{
			collection = new List<T>();
		}

		public IEnumerable<T> Collection => collection;

		public T[] ToArray()
		{
			return collection.ToArray();
		}
		public List<T> ToList()
		{
			return collection.ToList();
		}

		public override void Dispose()
		{
			base.Dispose();
			collection = null;
		}

		internal override bool AddItem(object item)
		{
			if(item is T t)
			{
				var list = collection.ToList();
				list.Add(t);
				collection = list;
				return true;
			}
			return false;
		}
		internal override bool RemoveItem(object item)
		{
			if(item is T t)
			{
				var list = collection.ToList();
				bool isRemove = list.Remove(t);
				collection = list;
				return isRemove;
			}
			return false;
		}
		internal override bool AddRangeItem(params object[] item)
		{
			var addList = item.Select(item => item as T).Where(item => item is not null);
			var list = collection.ToList();
			list.AddRange(addList);
			collection = list;
			return addList.Count() > 0;
		}
		internal override bool RemoveRangeItem(params object[] item)
		{
			var removeList = item.Select(item => item as T).Where(item => item is not null);

			bool result = false;
			var list = collection.ToList();
			foreach(var revmoe in removeList)
			{
				result = list.Remove(revmoe) || result;
			}
			collection = list;
			return result;
		}

		public static OdccCollector<T> CreateCollector()
		{

			var collectorList = OdccForeach.OdccCollectorList;

			Type type = typeof(T);

			if(collectorList.ContainsKey(type) && collectorList[type] is OdccCollector<T> tCollectorList)
			{
				return tCollectorList;
			}
			else
			{
				OdccCollector<T> newCollector = new OdccCollector<T>();
				if(type.IsSubclassOf(typeof(ObjectBehaviour)))
				{
					newCollector.AddRangeItem(OdccForeach.OdccObjectList.Collection.ToArray());
				}
				else if(type.IsSubclassOf(typeof(ComponentBehaviour)))
				{
					newCollector.AddRangeItem(OdccForeach.OdccComponentList.Collection.ToArray());
				}
				collectorList.Add(type, newCollector);

				return newCollector;
			}
		}

		public static bool TryGetCollector(out OdccCollector<T> odccCollector)
		{
			var collectorList = OdccForeach.OdccCollectorList;

			Type type = typeof(T);

			odccCollector = collectorList.TryGetValue(type, out var collector) ? collector as OdccCollector<T> : null;
			return odccCollector != null;
		}

		public static void DeleteCollector()
		{
			var collectorList = OdccForeach.OdccCollectorList;

			Type type = typeof(T);

			if(collectorList.TryGetValue(type, out var collector))
			{
				collector.Dispose();
				collectorList.Remove(type);
			}
		}

		internal OdccLooper<T> CreateLooper()
		{
			var looper = new OdccLooper<T>(this, "");
			int index = odccLoopers.FindIndex(item=>string.IsNullOrWhiteSpace(item.key));

			if(index >= 0)
			{
				odccLoopers.RemoveAt(index);
				odccLoopers.Add(looper);
			}
			else
			{
				odccLoopers.Add(looper);
			}
			return looper;
		}
		public OdccLooper<T> CreateLooper(string key, bool prevUpdate, Func<T, bool> condition = null)
		{
			if(string.IsNullOrWhiteSpace(key)) return null;

			OdccLooper<T> looper = new OdccLooper<T>(this, key, prevUpdate, condition);
			int index = odccLoopers.FindIndex(item=>item.key == key);
			if(index >= 0)
			{
				odccLoopers.RemoveAt(index);
				odccLoopers.Add(looper);
			}
			else
			{
				odccLoopers.Add(looper);
			}
			return looper;
		}

		public bool TryGetLooper(string key, out OdccLooper<T> looper)
		{
			looper = null;
			int index = odccLoopers.FindIndex(item=>item.key == key);
			looper = index < 0 ? null : odccLoopers[index] as OdccLooper<T>;
			return looper != null;
		}
		public void DeleteLooper(string key)
		{
			if(string.IsNullOrWhiteSpace(key)) return;

			int index = odccLoopers.FindIndex(item=>item.key == key);
			if(index >= 0)
			{
				odccLoopers[index].Dispose();
				odccLoopers.RemoveAt(index);
			}
		}

	}
#endif
	public class OdccQueryCollector : IDisposable
	{
		internal QuerySystem querySystem;
		internal List<object> lifeItems;
		internal bool IsDontDestoryLifeItem { get; private set; }

		internal IEnumerable<ObjectBehaviour> queryItems;
		internal Dictionary<string, OdccQueryLooper> odccLoopers;
		internal Dictionary<string, OdccQueryLooper> odccEventCalls;
		internal Action<ObjectBehaviour, bool> changeItemList;
		internal OdccQueryCollector(QuerySystem querySystem)
		{
			this.querySystem = querySystem;

			lifeItems = new List<object>();
			IsDontDestoryLifeItem = false;

			queryItems = new List<ObjectBehaviour>();
			odccLoopers = new Dictionary<string, OdccQueryLooper>();
			odccEventCalls = new Dictionary<string, OdccQueryLooper>();
			changeItemList = null;
		}
		private void AddLifeItem(object lifeItem)
		{
			if(lifeItem == null || IsDontDestoryLifeItem) return;
			if(!lifeItems.Contains(lifeItem))
			{
				lifeItems.Add(lifeItem);
			}
		}
		internal void RemoveLifeItem(object lifeItem)
		{
			if(lifeItem == null || IsDontDestoryLifeItem) return;
			lifeItems.Remove(lifeItem);
			if(lifeItems.Count == 0)
			{
				DeleteQueryCollector(this);
			}
		}
		internal void ClearLifeItem()
		{
			lifeItems.Clear();
		}
		public static OdccQueryCollector CreateQueryCollector(QuerySystem querySystem, Scene lifeItem)
		{
			var collector = _CreateQueryCollector(querySystem);
			collector.AddLifeItem(lifeItem);
			return collector;
		}
		public static OdccQueryCollector CreateQueryCollector(QuerySystem querySystem, OCBehaviour lifeItem)
		{
			if(lifeItem == null) throw new NullReferenceException();

			var collector = _CreateQueryCollector(querySystem);
			collector.AddLifeItem(lifeItem);
			return collector;
		}
		public static OdccQueryCollector CreateQueryCollector(QuerySystem querySystem, string lifeItem)
		{
			if(lifeItem == null) throw new NullReferenceException();

			var collector = _CreateQueryCollector(querySystem);
			collector.AddLifeItem(lifeItem);
			return collector;
		}
		public static OdccQueryCollector CreateQueryCollector(QuerySystem querySystem)
		{
			var collector = _CreateQueryCollector(querySystem);
			collector.IsDontDestoryLifeItem = true;
			collector.ClearLifeItem();
			return collector;
		}
		private static OdccQueryCollector _CreateQueryCollector(QuerySystem querySystem)
		{
			var odccQueryCollectors =  OdccForeach.OdccQueryCollectors;

			if(odccQueryCollectors.ContainsKey(querySystem))
			{
				return odccQueryCollectors[querySystem];
			}
			else
			{
				OdccQueryCollector newCollector = new OdccQueryCollector(querySystem);
#if USING_LEGACY_COLLECTOR
				var objectList = OdccForeach.OdccObjectList.Collection;
#else
				var objectList = OdccForeach.OdccObjectList.GetQueryItems();
#endif
				foreach(var item in objectList)
				{
					newCollector.AddObject(item);
				}

				odccQueryCollectors.Add(querySystem, newCollector);

				return newCollector;
			}
		}
		public static void DeleteQueryCollector(QuerySystem querySystem, string lifeItem)
		{
			if(querySystem != null && OdccForeach.OdccQueryCollectors.ContainsKey(querySystem))
			{
				OdccForeach.OdccQueryCollectors[querySystem].RemoveLifeItem(lifeItem);
			}
		}
		public static void DeleteQueryCollector(QuerySystem querySystem)
		{
			if(querySystem != null && OdccForeach.OdccQueryCollectors.ContainsKey(querySystem))
			{
				DeleteQueryCollector(OdccForeach.OdccQueryCollectors[querySystem]);
			}
		}
		private static void DeleteQueryCollector(OdccQueryCollector collector)
		{
			if(collector == null) return;
			OdccForeach.OdccQueryCollectors?.Remove(collector.querySystem);
#pragma warning disable CS0618
			collector.Dispose();
#pragma warning restore CS0618
		}
		[Obsolete("절데로 수동으로 호출하지 마세요.")]
		public void Dispose()
		{
			querySystem = null;
			queryItems = null;
			foreach(var item in odccLoopers)
			{
				item.Value.Dispose();
			}
			odccLoopers.Clear();
			odccLoopers = null;

			foreach(var item in odccEventCalls)
			{
				item.Value.Dispose();
			}
			odccEventCalls.Clear();
			odccEventCalls = null;

			lifeItems.Clear();
			lifeItems = null;
			IsDontDestoryLifeItem = false;
		}
		public OdccQueryLooper CreateLooper(string key, bool prevUpdate = true)
		{
			if(odccLoopers.ContainsKey(key))
			{
				return odccLoopers[key];
			}
			else
			{
				var looper = OdccQueryLooper.CreateLooper(this, prevUpdate);
				odccLoopers.Add(key, looper);
				return looper;
			}
		}
		public OdccQueryLooper CreateCallEvent(string key)
		{
			if(odccEventCalls.ContainsKey(key))
			{
				return odccEventCalls[key];
			}
			else
			{
				var looper = OdccQueryLooper.CreateCallEvent(this);
				odccEventCalls.Add(key, looper);
				return looper;
			}
		}
		public OdccQueryCollector DeleteLooper(string key)
		{
			if(odccLoopers.ContainsKey(key))
			{
				odccLoopers[key].Dispose();
				odccLoopers.Remove(key);
			}
			return this;
		}
		public OdccQueryCollector DeleteCallEvent(string key)
		{
			if(odccEventCalls.ContainsKey(key))
			{
				odccEventCalls[key].Dispose();
				odccEventCalls.Remove(key);
			}
			return this;
		}

		public OdccQueryCollector CreateChangeListEvent(Action<IEnumerable<ObjectBehaviour>> setInitList, Action<ObjectBehaviour, bool> changeListEvent)
		{
			if(setInitList != null)
				setInitList.Invoke(GetQueryItems());

			if(changeListEvent != null)
				changeItemList += changeListEvent;

			return this;
		}
		public OdccQueryCollector DeleteChangeListEvent(Action<ObjectBehaviour, bool> changeListEvent)
		{
			if(changeListEvent != null)
				changeItemList -= changeListEvent;

			return this;
		}

		internal void AddObject(ObjectBehaviour item, bool passDoubleCheck = false)
		{
			if(queryItems.Contains(item)) return;

			if(passDoubleCheck || IsSatisfiesQuery(item))
			{
				var list = queryItems.ToList();
				list.Add(item);
				queryItems = list;
				changeItemList?.Invoke(item, true);

				foreach(var looper in odccLoopers)
				{
					looper.Value.Add(item);
				}
				foreach(var looper in odccEventCalls)
				{
					looper.Value.Add(item);
				}
			}
		}
		internal void RemoveObject(ObjectBehaviour item)
		{
			if(!queryItems.Contains(item)) return;

			var list = queryItems.ToList();
			if(list.Remove(item))
			{
				queryItems = list;
				changeItemList?.Invoke(item, false);

				foreach(var looper in odccLoopers)
				{
					looper.Value.Remove(item);
				}
				foreach(var looper in odccEventCalls)
				{
					looper.Value.Remove(item);
				}
			}
		}
		internal bool IsSatisfiesQuery(ObjectBehaviour item)
		{
#if UNITY_EDITOR
			if(!Application.isPlaying) return false;
#endif

			List<int> indexs = new List<int>();
			indexs.AddRange(OdccManager.GetTypeToIndex(item));

			return querySystem.IsAll(indexs) && querySystem.IsAny(indexs) && querySystem.IsNone(indexs);
		}
		internal void UpdateObjectInQuery(ObjectBehaviour item)
		{
			if(IsSatisfiesQuery(item))
			{
				AddObject(item, true);
			}
			else
			{
				RemoveObject(item);
			}
		}

		public IEnumerable<ObjectBehaviour> GetQueryItems()
		{
			return queryItems;
		}
	}
}
