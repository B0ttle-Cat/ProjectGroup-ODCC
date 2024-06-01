using System;
using System.Collections.Generic;

using UnityEngine.SceneManagement;

namespace BC.ODCC
{
	internal static class OdccForeach
	{
		internal static OdccQueryCollector OdccObjectList;
		internal static OdccQueryCollector OdccComponentList;
		private static QuerySystem OdccObjectListQuerySystem;
		private static QuerySystem OdccComponentListQuerySystem;

		internal static Dictionary<QuerySystem, OdccQueryCollector> OdccQueryCollectors = new ();

#if USING_AWAITABLE_LOOP
		internal static Dictionary<OdccQueryLooper, UnityEngine.Awaitable> ForeachQueryPrevUpdate = new ();
		internal static Dictionary<OdccQueryLooper, UnityEngine.Awaitable> ForeachQueryNextUpdate = new ();
#else
		internal static Dictionary<OdccQueryLooper, System.Collections.IEnumerator> ForeachQueryPrevUpdate  = new ();
		internal static Dictionary<OdccQueryLooper, System.Collections.IEnumerator> ForeachQueryNextUpdate  = new ();
#endif
		private static readonly Queue<Action> foreachAction = new Queue<Action>();

		internal static void InitForeach()
		{
			OdccObjectListQuerySystem = QuerySystemBuilder.CreateQuery().WithAny<ObjectBehaviour>(true).Build();
			OdccComponentListQuerySystem = QuerySystemBuilder.CreateQuery().WithAny<ComponentBehaviour>(true).Build();
			OdccObjectList = new OdccQueryCollector(OdccObjectListQuerySystem);
			OdccComponentList = new OdccQueryCollector(OdccComponentListQuerySystem);
		}
		internal static void ReleaseForeach()
		{
			OdccQueryCollector.DeleteQueryCollector(OdccObjectListQuerySystem);
			OdccQueryCollector.DeleteQueryCollector(OdccComponentListQuerySystem);
			OdccObjectListQuerySystem = null;
			OdccComponentListQuerySystem = null;
			OdccObjectList = null;
			OdccComponentList = null;

			OdccQueryCollectors.Clear();
			ForeachQueryPrevUpdate.Clear();
			ForeachQueryNextUpdate.Clear();

			foreachAction.Clear();
		}
		private static void OCBehaviourUpdate(IEnumerable<OCBehaviour> behaviour)
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
					foreachAction.Enqueue(() => {
						item.BaseUpdate();
					});
				}
			}
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
		}
		private static void OCBehaviourLateUpdate(IEnumerable<OCBehaviour> behaviour)
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
					foreachAction.Enqueue(() => {
						item.BaseLateUpdate();
					});
				}
			}
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
		}
		internal static void AddOdccCollectorList(OCBehaviour behaviour)
		{
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}

			if(behaviour is ObjectBehaviour objectBehaviour)
			{
				foreach(var _query in OdccQueryCollectors)
				{
					var query  = _query;
					foreachAction.Enqueue(() => {
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
					foreachAction.Enqueue(() => {
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
		internal static void RemoveOdccCollectorList(OCBehaviour behaviour)
		{
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}

			if(behaviour is ObjectBehaviour objectBehaviour)
			{
				foreach(var _query in OdccQueryCollectors)
				{
					var query  = _query;
					OdccQueryCollector queryCollector = query.Value;
					foreachAction.Enqueue(() => {
						queryCollector.RemoveObject(objectBehaviour);
					});
				}
			}
			else if(behaviour is ComponentBehaviour componentBehaviour)
			{
				foreach(var _query in OdccQueryCollectors)
				{
					var query  = _query;
					OdccQueryCollector queryCollector = query.Value;
					ObjectBehaviour thisObject = componentBehaviour.ThisObject;
					foreachAction.Enqueue(() => {
						queryCollector.UpdateObjectInQuery(thisObject);
					});
				}
			}

			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}

			RemoveLifeItemOdccCollectorList(behaviour);
		}

		internal static void UpdateObjectInQuery(ObjectBehaviour updateObject)
		{
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
			foreach(var _query in OdccQueryCollectors)
			{
				var query  = _query;
				foreachAction.Enqueue(() => {
					OdccQueryCollector queryCollector = query.Value;
					queryCollector.UpdateObjectInQuery(updateObject);
				});
			}
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
		}

		internal static void ForeachUpdate()
		{
			Action listToNext = null;
			foreach(var item in ForeachQueryPrevUpdate)
			{
				var key= item.Key;
				var value = item.Value;

				if(key is not null)
				{
#if USING_AWAITABLE_LOOP
					if(value is null || value.IsCompleted)
#else
					if(!value.MoveNext())
#endif
					{
						listToNext += () => ForeachQueryPrevUpdate[key] = key.RunLooper();
					}
				}
			}

			OCBehaviourUpdate(OdccObjectList.GetQueryItems());
			OCBehaviourUpdate(OdccComponentList.GetQueryItems());

			foreach(var item in ForeachQueryNextUpdate)
			{
				var key= item.Key;
				var value = item.Value;

				if(key is not null)
				{
#if USING_AWAITABLE_LOOP
					if(value is null || value.IsCompleted)
#else
					if(!value.MoveNext())
#endif
					{
						listToNext += () => ForeachQueryNextUpdate[key] = key.RunLooper();
					}
				}
			}

			listToNext?.Invoke();
		}

		internal static void ForeachLateUpdate()
		{
			OCBehaviourLateUpdate(OdccObjectList.GetQueryItems());
			OCBehaviourLateUpdate(OdccComponentList.GetQueryItems());
		}


		internal static void RemoveLifeItemOdccCollectorList(OCBehaviour ocBehaviour)
		{
			foreach(var _query in OdccQueryCollectors)
			{
				OdccQueryCollector queryCollector = _query.Value;
				foreachAction.Enqueue(() => {
					queryCollector.RemoveLifeItem(ocBehaviour);
				});
			}
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
		}
		internal static void RemoveLifeItemOdccCollectorList(Scene scene)
		{
			foreach(var _query in OdccQueryCollectors)
			{
				OdccQueryCollector queryCollector = _query.Value;
				foreachAction.Enqueue(() => {
					queryCollector.RemoveLifeItem(scene);
				});
			}
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
		}
	}
}
