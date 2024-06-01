#define USING_AWAITABLE
#undef USING_LEGACY_COLLECTOR

using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine.SceneManagement;

namespace BC.ODCC
{
	internal static class OdccForeach
	{
		//internal static List<ObjectBehaviour> OdccObjectList = new List<ObjectBehaviour>();
		//internal static List<ComponentBehaviour> OdccComponentList = new List<ComponentBehaviour>();
		//internal static List<DataObject> OdccDataList = new List<DataObject>();
#if USING_LEGACY_COLLECTOR
		public static OdccCollector<ObjectBehaviour> OdccObjectList;
		public static OdccCollector<ComponentBehaviour> OdccComponentList;

		public static OdccLooper<ObjectBehaviour> ObjectLooper;
		public static OdccLooper<ComponentBehaviour> ComponentLooper;

		public static OdccLooper<ObjectBehaviour> ObjectLateLooper;
		public static OdccLooper<ComponentBehaviour> ComponentLateLooper;

		public static Dictionary<Type, OdccCollector> OdccCollectorList = new Dictionary<Type, OdccCollector>();

		public static Dictionary<OdccLooper, IEnumerator> ForeachPrevUpdate  = new Dictionary<OdccLooper, IEnumerator>();
		public static Dictionary<OdccLooper, IEnumerator> ForeachNextUpdate  = new Dictionary<OdccLooper, IEnumerator>();
#endif
		internal static OdccQueryCollector OdccObjectList;
		internal static OdccQueryCollector OdccComponentList;
		private static QuerySystem OdccObjectListQuerySystem;
		private static QuerySystem OdccComponentListQuerySystem;

		internal static Dictionary<QuerySystem, OdccQueryCollector> OdccQueryCollectors = new Dictionary<QuerySystem, OdccQueryCollector>();

		internal static Dictionary<OdccQueryLooper, IEnumerator> ForeachQueryPrevUpdate  = new Dictionary<OdccQueryLooper, IEnumerator>();
		internal static Dictionary<OdccQueryLooper, IEnumerator> ForeachQueryNextUpdate  = new Dictionary<OdccQueryLooper, IEnumerator>();
#if USING_AWAITABLE
		internal static List<OdccQueryLooper> ForeachQueryPrevUpdate_V2;
		internal static List<OdccQueryLooper> ForeachQueryNextUpdate_V2;
#endif

		private static readonly Queue<Action> foreachAction = new Queue<Action>();

		internal static void InitForeach()
		{

#if USING_LEGACY_COLLECTOR
			OdccObjectList = OdccCollector<ObjectBehaviour>.CreateCollector();
			OdccComponentList = OdccCollector<ComponentBehaviour>.CreateCollector();

			ObjectLooper = OdccObjectList.CreateLooper();
			ObjectLooper.SetListener(nameof(OCBehaviourUpdate), OCBehaviourUpdate);
			ComponentLooper = OdccComponentList.CreateLooper();
			ComponentLooper.SetListener(nameof(OCBehaviourUpdate), OCBehaviourUpdate);

			ObjectLateLooper = OdccObjectList.CreateLooper();
			ObjectLateLooper.SetListener(nameof(OCBehaviourLateUpdate), OCBehaviourLateUpdate);
			ComponentLateLooper = OdccComponentList.CreateLooper();
			ComponentLateLooper.SetListener(nameof(OCBehaviourLateUpdate), OCBehaviourLateUpdate);
#else
			OdccObjectListQuerySystem = QuerySystemBuilder.CreateQuery().WithAny<ObjectBehaviour>(true).Build();
			OdccComponentListQuerySystem = QuerySystemBuilder.CreateQuery().WithAny<ComponentBehaviour>(true).Build();

			OdccObjectList = OdccQueryCollector.CreateQueryCollector(OdccObjectListQuerySystem);
			OdccComponentList = OdccQueryCollector.CreateQueryCollector(OdccComponentListQuerySystem);

#endif
		}
		internal static void ReleaseForeach()
		{
#if USING_LEGACY_COLLECTOR
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
#else
			OdccQueryCollector.DeleteQueryCollector(OdccObjectListQuerySystem);
			OdccQueryCollector.DeleteQueryCollector(OdccComponentListQuerySystem);
			OdccObjectListQuerySystem = null;
			OdccComponentListQuerySystem = null;
			OdccObjectList = null;
			OdccComponentList = null;
#endif
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

#if USING_LEGACY_COLLECTOR
			var keyList = OdccCollectorList.Keys.ToList();

			int count = keyList.Count;
			for(int i = 0 ; i < count ; i++)
			{
				OdccCollectorList[keyList[i]].AddItem(behaviour);
			}
#endif
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
#if USING_LEGACY_COLLECTOR
			var keyList = OdccCollectorList.Keys.ToList();

			int count = keyList.Count;
			for(int i = 0 ; i < count ; i++)
			{
				OdccCollectorList[keyList[i]].RemoveItem(behaviour);
			}
#endif
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
#if USING_LEGACY_COLLECTOR
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
#endif
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
#if USING_LEGACY_COLLECTOR
			var updateLoop = ObjectLooper?.RunAction();
			if(updateLoop != null) while(updateLoop.MoveNext()) ;
			updateLoop = ComponentLooper?.RunAction();
			if(updateLoop != null) while(updateLoop.MoveNext()) ;
#else
			OCBehaviourUpdate(OdccObjectList.GetQueryItems());
			OCBehaviourUpdate(OdccComponentList.GetQueryItems());
#endif
#if USING_LEGACY_COLLECTOR
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
#endif
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
		internal static void ForeachLateUpdate()
		{
#if USING_LEGACY_COLLECTOR
			var updateLoop = ObjectLateLooper?.RunAction();
			if(updateLoop != null) while(updateLoop.MoveNext()) ;
			updateLoop = ComponentLateLooper?.RunAction();
			if(updateLoop != null) while(updateLoop.MoveNext()) ;
#else
			OCBehaviourLateUpdate(OdccObjectList.GetQueryItems());
			OCBehaviourLateUpdate(OdccComponentList.GetQueryItems());
#endif
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
