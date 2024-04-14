using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BC.ODCC
{
	public static class OdccForeach
	{
		public static OdccCollector<ObjectBehaviour> OdccObjectList;
		public static OdccCollector<ComponentBehaviour> OdccComponentList;

		public static OdccLooper<ObjectBehaviour> ObjectLooper;
		public static OdccLooper<ComponentBehaviour> ComponentLooper;

		public static OdccLooper<ObjectBehaviour> ObjectLateLooper;
		public static OdccLooper<ComponentBehaviour> ComponentLateLooper;

		public static Dictionary<Type, OdccCollector> OdccCollectorList = new Dictionary<Type, OdccCollector>();
		public static Dictionary<QuerySystem, OdccQueryCollector> OdccQueryCollectors = new Dictionary<QuerySystem, OdccQueryCollector>();

		public static Dictionary<OdccLooper, IEnumerator> ForeachPrevUpdate  = new Dictionary<OdccLooper, IEnumerator>();
		public static Dictionary<OdccLooper, IEnumerator> ForeachNextUpdate  = new Dictionary<OdccLooper, IEnumerator>();

		public static Dictionary<OdccQueryLooper, IEnumerator> ForeachQueryPrevUpdate  = new Dictionary<OdccQueryLooper, IEnumerator>();
		public static Dictionary<OdccQueryLooper, IEnumerator> ForeachQueryNextUpdate  = new Dictionary<OdccQueryLooper, IEnumerator>();

		private static readonly Queue<Action> foreachAction = new Queue<Action>();
		public static void InitForeach()
		{
			OdccObjectList = OdccCollector<ObjectBehaviour>.CreateCollector();
			OdccComponentList = OdccCollector<ComponentBehaviour>.CreateCollector();

			ObjectLooper = OdccObjectList.CreateLooper();
			ObjectLooper.SetListener(nameof(BCComponentUpdate), BCComponentUpdate);
			ComponentLooper = OdccComponentList.CreateLooper();
			ComponentLooper.SetListener(nameof(BCComponentUpdate), BCComponentUpdate);

			ObjectLateLooper = OdccObjectList.CreateLooper();
			ObjectLateLooper.SetListener(nameof(BCComponentLateUpdate), BCComponentLateUpdate);
			ComponentLateLooper = OdccComponentList.CreateLooper();
			ComponentLateLooper.SetListener(nameof(BCComponentLateUpdate), BCComponentLateUpdate);
		}
		public static void ReleaseForeach()
		{
			OdccCollector<ObjectBehaviour>.DeleteCollector();
			OdccCollector<ComponentBehaviour>.DeleteCollector();

			OdccObjectList = null;
			OdccComponentList = null;

			ObjectLooper = null;
			ComponentLooper = null;

			ObjectLateLooper = null;
			ComponentLateLooper = null;

			OdccCollectorList.Clear();
			ForeachPrevUpdate.Clear();
			ForeachNextUpdate.Clear();

			ForeachQueryPrevUpdate.Clear();
			ForeachQueryNextUpdate.Clear();

			foreachAction.Clear();
		}
		private static void BCComponentUpdate(IEnumerable<OCBehaviour> behaviour)
		{
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
			foreach(var _item in behaviour)
			{
				var item = _item;
				if(item.IsEnable || item.IsCanUpdateDisable)
				{
					foreachAction.Enqueue(() =>
					{
						item.BaseUpdate();
					});
				}
			}
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
		}
		private static void BCComponentLateUpdate(IEnumerable<OCBehaviour> behaviour)
		{
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
			foreach(var _item in behaviour)
			{
				var item = _item;
				if(item.IsEnable  || item.IsCanUpdateDisable)
				{
					foreachAction.Enqueue(() =>
					{
						item.BaseLateUpdate();
					});
				}
			}
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
		}
		public static void AddOdccCollectorList(OCBehaviour behaviour)
		{
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}

			var keyList = OdccCollectorList.Keys.ToList();

			int count = keyList.Count;
			for(int i = 0 ; i < count ; i++)
			{
				OdccCollectorList[keyList[i]].AddItem(behaviour);
			}

			if(behaviour is ObjectBehaviour objectBehaviour)
			{
				foreach(var _query in OdccQueryCollectors)
				{
					var query  = _query;
					foreachAction.Enqueue(() =>
					{
						OdccQueryCollector queryCollector = query.Value;
						queryCollector.AddObject(objectBehaviour);
					});
				}
			}
			else if(behaviour is ComponentBehaviour componentBehaviour)
			{
				foreach(var _query in OdccQueryCollectors)
				{
					var query  = _query;
					foreachAction.Enqueue(() =>
					{
						OdccQueryCollector queryCollector = query.Value;
						ObjectBehaviour thisObject = componentBehaviour.ThisObject;
						queryCollector.UpdateObjectInQuery(thisObject);
					});
				}
			}

			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
		}
		public static void RemoveOdccCollectorList(OCBehaviour behaviour)
		{
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
			var keyList = OdccCollectorList.Keys.ToList();

			int count = keyList.Count;
			for(int i = 0 ; i < count ; i++)
			{
				OdccCollectorList[keyList[i]].RemoveItem(behaviour);
			}

			if(behaviour is ObjectBehaviour objectBehaviour)
			{
				foreach(var _query in OdccQueryCollectors)
				{
					var query  = _query;
					foreachAction.Enqueue(() =>
					{
						OdccQueryCollector queryCollector = query.Value;
						queryCollector.RemoveObject(objectBehaviour);
					});
				}
			}
			else if(behaviour is ComponentBehaviour componentBehaviour)
			{
				foreach(var _query in OdccQueryCollectors)
				{
					var query  = _query;
					foreachAction.Enqueue(() =>
					{
						OdccQueryCollector queryCollector = query.Value;
						ObjectBehaviour thisObject = componentBehaviour.ThisObject;
						queryCollector.UpdateObjectInQuery(thisObject);
					});
				}
			}

			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
		}
		public static void UpdateObjectInQuery(ObjectBehaviour updateObject)
		{
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
			foreach(var _query in OdccQueryCollectors)
			{
				var query  = _query;
				foreachAction.Enqueue(() =>
				{
					OdccQueryCollector queryCollector = query.Value;
					queryCollector.UpdateObjectInQuery(updateObject);
				});
			}
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
		}

		public static void ForeachUpdate()
		{
			Action listToNext = null;
			foreach(var item in ForeachPrevUpdate)
			{
				var key= item.Key;
				var value = item.Value;

				if(key is not null)
				{
					if(!value.MoveNext())
					{
						listToNext += () => ForeachPrevUpdate[key] = key.RunAction();
					}
				}
			}
			foreach(var item in ForeachQueryPrevUpdate)
			{
				var key= item.Key;
				var value = item.Value;

				if(key is not null)
				{
					if(!value.MoveNext())
					{
						listToNext += () => ForeachQueryPrevUpdate[key] = key.RunLooper();
					}
				}
			}

			var updateLoop = ObjectLooper?.RunAction();
			if(updateLoop != null) while(updateLoop.MoveNext()) ;
			updateLoop = ComponentLooper?.RunAction();
			if(updateLoop != null) while(updateLoop.MoveNext()) ;

			foreach(var item in ForeachNextUpdate)
			{
				OdccLooper key= item.Key;
				IEnumerator value = item.Value;

				if(key is not null)
				{
					if(!value.MoveNext())
					{
						listToNext += () => ForeachPrevUpdate[key] = key.RunAction();
					}
				}
			}
			foreach(var item in ForeachQueryNextUpdate)
			{
				var key= item.Key;
				var value = item.Value;

				if(key is not null)
				{
					if(!value.MoveNext())
					{
						listToNext += () => ForeachQueryNextUpdate[key] = key.RunLooper();
					}
				}
			}


			listToNext?.Invoke();
		}
		public static void ForeachLateUpdate()
		{
			var updateLoop = ObjectLateLooper?.RunAction();
			if(updateLoop != null) while(updateLoop.MoveNext()) ;
			updateLoop = ComponentLateLooper?.RunAction();
			if(updateLoop != null) while(updateLoop.MoveNext()) ;
		}
	}
}
