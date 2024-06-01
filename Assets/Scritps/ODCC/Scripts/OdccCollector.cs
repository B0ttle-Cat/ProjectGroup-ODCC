using System;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;
using UnityEngine.SceneManagement;

namespace BC.ODCC
{
	public class OdccQueryCollector : IDisposable
	{
		internal QuerySystem querySystem;
		internal List<object> lifeItems;
		internal bool IsDontDestoryLifeItem { get; private set; }

		internal IEnumerable<ObjectBehaviour> queryItems;
		internal Dictionary<string, OdccQueryLooper> odccLoopers;
		internal Dictionary<string, OdccQueryLooper> odccActions;
		internal Action<ObjectBehaviour, bool> changeItemList;
		internal OdccQueryCollector(QuerySystem querySystem)
		{
			this.querySystem = querySystem;

			lifeItems = new List<object>();
			IsDontDestoryLifeItem = false;

			queryItems = new List<ObjectBehaviour>();
			odccLoopers = new Dictionary<string, OdccQueryLooper>();
			odccActions = new Dictionary<string, OdccQueryLooper>();
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

				var objectList = OdccForeach.OdccObjectList.GetQueryItems();

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

			foreach(var item in odccActions)
			{
				item.Value.Dispose();
			}
			odccActions.Clear();
			odccActions = null;

			lifeItems.Clear();
			lifeItems = null;
			IsDontDestoryLifeItem = false;
		}

		public OdccQueryLooper CreateLooperEvent(string key, bool prevUpdate = true)
		{
			if(odccLoopers.ContainsKey(key))
			{
				return odccLoopers[key];
			}
			else
			{
				var looper = OdccQueryLooper.CreateLooperEvent(this,key, prevUpdate);
				odccLoopers.Add(key, looper);
				return looper;
			}
		}
		public OdccQueryLooper CreateActionEvent(string key)
		{
			if(odccActions.ContainsKey(key))
			{
				return odccActions[key];
			}
			else
			{
				var looper = OdccQueryLooper.CreateActionEvent(this, key);
				odccActions.Add(key, looper);
				return looper;
			}
		}
		public OdccQueryCollector DeleteLooperEvent(string key)
		{
			if(odccLoopers.ContainsKey(key))
			{
				odccLoopers[key].Dispose();
				odccLoopers.Remove(key);
			}
			return this;
		}
		public OdccQueryCollector DeleteActionEvent(string key)
		{
			if(odccActions.ContainsKey(key))
			{
				odccActions[key].Dispose();
				odccActions.Remove(key);
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
				foreach(var looper in odccActions)
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
				foreach(var looper in odccActions)
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







		/////////////////////////// Obsolete //////////////////////////

		[Obsolete("CreateLooperEvent 를 사용할 것 - 오래된 이름 규칙", true)]
		public OdccQueryLooper CreateLooper(string key, bool prevUpdate = true)
		{
			return CreateLooperEvent(key, prevUpdate);
		}
		[Obsolete("DeleteLooperEvent 를 사용할 것 - 오래된 이름 규칙", true)]
		public OdccQueryCollector DeleteLooper(string key)
		{
			return DeleteLooperEvent(key);
		}

		[Obsolete("CreateActionEvent 를 사용할 것 - 오래된 이름 규칙", true)]
		public OdccQueryLooper CreateCallEvent(string key)
		{
			return CreateActionEvent(key);
		}
		[Obsolete("DeleteActionEvent 를 사용할 것 - 오래된 이름 규칙", true)]
		public OdccQueryCollector DeleteCallEvent(string key)
		{
			return DeleteActionEvent(key);
		}
	}
}
