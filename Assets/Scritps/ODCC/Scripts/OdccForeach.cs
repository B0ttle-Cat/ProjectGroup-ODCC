using System;
using System.Collections.Generic;

using UnityEngine.SceneManagement;

namespace BC.ODCC
{
	/// <summary>
	/// OdccForeach 클래스는 ODCC 시스템의 Foreach 기능을 관리하는 정적 클래스입니다.
	/// </summary>
	internal static class OdccForeach
	{
		// ObjectBehaviour 목록을 관리하는 OdccQueryCollector입니다.
		internal static OdccQueryCollector OCBehaviourList;

		// ObjectBehaviour 목록에 대한 쿼리 시스템입니다.
		internal static QuerySystem OCBehaviourListQuerySystem;

		// ODCC 쿼리 컬렉터들을 관리하는 딕셔너리입니다.
		internal static Dictionary<QuerySystem, OdccQueryCollector> OdccQueryCollectors = new ();

		// ObjectBehaviour 리스트입니다.
		internal static List<ObjectBehaviour> objectBehaviourList = new List<ObjectBehaviour>();

		// ComponentBehaviour 리스트입니다.
		internal static List<ComponentBehaviour> componentBehaviourList = new List<ComponentBehaviour>();

#if USING_AWAITABLE_LOOP
        internal static Dictionary<OdccQueryLooper, UnityEngine.Awaitable> ForeachQueryPrevUpdate = new ();
        internal static Dictionary<OdccQueryLooper, UnityEngine.Awaitable> ForeachQueryNextUpdate = new ();
#else
		internal static Dictionary<OdccQueryLooper, System.Collections.IEnumerator> ForeachQueryPrevUpdate  = new ();
		internal static Dictionary<OdccQueryLooper, System.Collections.IEnumerator> ForeachQueryNextUpdate  = new ();
#endif

		// Foreach 작업을 위한 액션 큐입니다.
		private static readonly Queue<Action> foreachAction = new Queue<Action>();

		/// <summary>
		/// Foreach 시스템을 초기화하는 메서드입니다.
		/// </summary>
		internal static void InitForeach()
		{
			// ObjectBehaviour 목록에 대한 쿼리 시스템을 생성하고 초기화합니다.
			OCBehaviourListQuerySystem = QuerySystemBuilder.CreateQuery().WithAll<ObjectBehaviour>(true).Build();
			OCBehaviourList = new OdccQueryCollector(OCBehaviourListQuerySystem);
			OdccQueryCollectors.Add(OCBehaviourListQuerySystem, OCBehaviourList);
			OCBehaviourList.IsDontDestoryLifeItem = true;
			OCBehaviourList.ClearLifeItem();
		}

		/// <summary>
		/// Foreach 시스템을 해제하는 메서드입니다.
		/// </summary>
		internal static void ReleaseForeach()
		{
			// 쿼리 컬렉터를 삭제하고 초기화합니다.
			OdccQueryCollector.DeleteQueryCollector(OCBehaviourListQuerySystem);
			OCBehaviourListQuerySystem = null;
			OCBehaviourList = null;

			// 컬렉터와 업데이트 목록을 초기화합니다.
			OdccQueryCollectors.Clear();
			ForeachQueryPrevUpdate.Clear();
			ForeachQueryNextUpdate.Clear();

			// 액션 큐를 초기화합니다.
			foreachAction.Clear();
		}

		/// <summary>
		/// OCBehaviour 객체를 업데이트하는 메서드입니다.
		/// </summary>
		/// <param name="behaviour">업데이트할 OCBehaviour 객체 목록</param>
		private static void OCBehaviourUpdate(IEnumerable<OCBehaviour> behaviour)
		{
			if(behaviour == null) return;

			// Foreach 액션 큐를 비웁니다.
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}

			// 각 OCBehaviour 객체에 대해 업데이트 작업을 수행합니다.
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

			// Foreach 액션 큐를 다시 비웁니다.
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
		}

		/// <summary>
		/// OCBehaviour 객체의 LateUpdate를 수행하는 메서드입니다.
		/// </summary>
		/// <param name="behaviour">LateUpdate를 수행할 OCBehaviour 객체 목록</param>
		private static void OCBehaviourLateUpdate(IEnumerable<OCBehaviour> behaviour)
		{
			if(behaviour == null) return;

			// Foreach 액션 큐를 비웁니다.
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}

			// 각 OCBehaviour 객체에 대해 LateUpdate 작업을 수행합니다.
			foreach(var _item in behaviour)
			{
				var item = _item;
				if(item.IsEnable || item.IsCanUpdateDisable)
				{
					foreachAction.Enqueue(() => {
						item.BaseLateUpdate();
					});
				}
			}

			// Foreach 액션 큐를 다시 비웁니다.
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
		}

		/// <summary>
		/// ODCC 컬렉터 목록에 OCBehaviour를 추가하는 메서드입니다.
		/// </summary>
		/// <param name="behaviour">추가할 OCBehaviour 객체</param>
		internal static void AddOdccCollectorList(OCBehaviour behaviour)
		{
			// Foreach 액션 큐를 비웁니다.
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}

			// ObjectBehaviour인 경우 처리합니다.
			if(behaviour is ObjectBehaviour objectBehaviour)
			{
				foreach(var _query in OdccQueryCollectors)
				{
					var query = _query;
					foreachAction.Enqueue(() => {
						if(!objectBehaviourList.Contains(objectBehaviour)) objectBehaviourList.Add(objectBehaviour);
						OdccQueryCollector queryCollector = query.Value;
						queryCollector.AddObject(objectBehaviour);
					});
				}
			}
			// ComponentBehaviour인 경우 처리합니다.
			else if(behaviour is ComponentBehaviour componentBehaviour)
			{
				foreach(var _query in OdccQueryCollectors)
				{
					var query = _query;
					foreachAction.Enqueue(() => {
						if(!componentBehaviourList.Contains(componentBehaviour)) componentBehaviourList.Add(componentBehaviour);
						OdccQueryCollector queryCollector = query.Value;
						ObjectBehaviour thisObject = componentBehaviour.ThisObject;
						queryCollector.UpdateObjectInQuery(thisObject);
					});
				}
			}

			// Foreach 액션 큐를 다시 비웁니다.
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
		}

		/// <summary>
		/// ODCC 컬렉터 목록에서 OCBehaviour를 제거하는 메서드입니다.
		/// </summary>
		/// <param name="behaviour">제거할 OCBehaviour 객체</param>
		internal static void RemoveOdccCollectorList(OCBehaviour behaviour)
		{
			// Foreach 액션 큐를 비웁니다.
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}

			// ObjectBehaviour인 경우 처리합니다.
			if(behaviour is ObjectBehaviour objectBehaviour)
			{
				foreach(var _query in OdccQueryCollectors)
				{
					var query = _query;
					OdccQueryCollector queryCollector = query.Value;
					foreachAction.Enqueue(() => {
						objectBehaviourList.Remove(objectBehaviour);
						queryCollector.RemoveObject(objectBehaviour);
						queryCollector.RemoveQuerySystemTarget(objectBehaviour);
					});
				}
			}
			// ComponentBehaviour인 경우 처리합니다.
			else if(behaviour is ComponentBehaviour componentBehaviour)
			{
				foreach(var _query in OdccQueryCollectors)
				{
					var query = _query;
					OdccQueryCollector queryCollector = query.Value;
					ObjectBehaviour thisObject = componentBehaviour.ThisObject;
					foreachAction.Enqueue(() => {
						componentBehaviourList.Remove(componentBehaviour);
						queryCollector.UpdateObjectInQuery(thisObject);
					});
				}
			}
			// LifeItem에서 OCBehaviour를 제거합니다.
			foreach(var _query in OdccQueryCollectors)
			{
				OdccQueryCollector queryCollector = _query.Value;
				foreachAction.Enqueue(() => {
					queryCollector.RemoveLifeItem(behaviour);
				});
			}

			// Foreach 액션 큐를 다시 비웁니다.
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}

		}

		/// <summary>
		/// 쿼리에 있는 ObjectBehaviour 객체를 업데이트하는 메서드입니다.
		/// </summary>
		/// <param name="updateObject">업데이트할 ObjectBehaviour 객체</param>
		internal static void UpdateObjectInQuery(ObjectBehaviour updateObject)
		{
			if(updateObject is null) return;

			// Foreach 액션 큐를 비웁니다.
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}

			// 각 쿼리 컬렉터에 대해 객체를 업데이트합니다.
			foreach(var _query in OdccQueryCollectors)
			{
				var query = _query;
				foreachAction.Enqueue(() => {
					OdccQueryCollector queryCollector = query.Value;
					queryCollector.UpdateObjectInQuery(updateObject);
				});
			}

			// Foreach 액션 큐를 다시 비웁니다.
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
		}

		/// <summary>
		/// Foreach 시스템의 업데이트를 수행하는 메서드입니다.
		/// </summary>
		internal static void ForeachUpdate()
		{
			Action listToNext = null;

			// 이전 업데이트 리스트를 처리합니다.
			foreach(var item in ForeachQueryPrevUpdate)
			{
				var key = item.Key;
				var value = item.Value;

				if(key is not null)
				{
#if USING_AWAITABLE_LOOP
                    if (value is null || value.IsCompleted)
#else
					if(!value.MoveNext())
#endif
					{
						listToNext += () => ForeachQueryPrevUpdate[key] = key.RunLooper();
					}
				}
			}

			// ObjectBehaviour 리스트를 업데이트합니다.
			OCBehaviourUpdate(objectBehaviourList);
			OCBehaviourUpdate(componentBehaviourList);

			// 다음 업데이트 리스트를 처리합니다.
			foreach(var item in ForeachQueryNextUpdate)
			{
				var key = item.Key;
				var value = item.Value;

				if(key is not null)
				{
#if USING_AWAITABLE_LOOP
                    if (value is null || value.IsCompleted)
#else
					if(!value.MoveNext())
#endif
					{
						listToNext += () => ForeachQueryNextUpdate[key] = key.RunLooper();
					}
				}
			}

			// 리스트를 다음으로 넘깁니다.
			listToNext?.Invoke();
		}

		/// <summary>
		/// Foreach 시스템의 LateUpdate를 수행하는 메서드입니다.
		/// </summary>
		internal static void ForeachLateUpdate()
		{
			// ObjectBehaviour 리스트의 LateUpdate를 수행합니다.
			OCBehaviourLateUpdate(objectBehaviourList);
			OCBehaviourLateUpdate(componentBehaviourList);
		}

		/// <summary>
		/// LifeItem에서 씬을 기준으로 OCBehaviour를 제거하는 메서드입니다.
		/// </summary>
		/// <param name="scene">제거할 씬</param>
		internal static void RemoveLifeItemOdccCollectorList(Scene scene)
		{
			// Foreach 액션 큐를 비웁니다.
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}

			// 각 쿼리 컬렉터에서 씬을 기준으로 OCBehaviour를 제거합니다.
			foreach(var _query in OdccQueryCollectors)
			{
				OdccQueryCollector queryCollector = _query.Value;
				foreachAction.Enqueue(() => {
					queryCollector.RemoveLifeItem(scene);
					queryCollector.RemoveQuerySystemTarget(scene);
				});
			}

			// Foreach 액션 큐를 비웁니다.
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
		}
	}
}
