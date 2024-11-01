using System;
using System.Collections.Generic;

using UnityEngine;
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

		// ODCC 쿼리 컬렉터들을 관리하는 딕셔너리입니다.
		internal static Dictionary<QuerySystem, ObjectBehaviour> OdccQueryFindCashList = new ();

		internal static List<ObjectBehaviour> allObjectBehaviours = new List<ObjectBehaviour>();

		// ObjectBehaviour 의 Update 리스트입니다.
		internal static List<IOdccUpdate> objectUpdateList = new List<IOdccUpdate>();

		// ComponentBehaviour 의 Update리스트입니다.
		internal static List<IOdccUpdate> componentUpdateList = new List<IOdccUpdate>();

		// ObjectBehaviour 의 Update 리스트입니다.
		internal static List<IOdccUpdate.Late> objectLateUpdateList = new List<IOdccUpdate.Late>();

		// ComponentBehaviour 의 Update리스트입니다.
		internal static List<IOdccUpdate.Late> componentLateUpdateList = new List<IOdccUpdate.Late>();

		internal static HashSet<IOCBehaviour> reservationDestroyObject = new HashSet<IOCBehaviour>();

		internal static SortedDictionary<int, Dictionary<OdccQueryLooper, UnityEngine.Awaitable>> ForeachQueryUpdate = new ();

		[Obsolete("Using ForeachQueryUpdate", true)]
		internal static Dictionary<OdccQueryLooper, UnityEngine.Awaitable> ForeachQueryPrevUpdate = new ();
		[Obsolete("Using ForeachQueryUpdate", true)]
		internal static Dictionary<OdccQueryLooper, UnityEngine.Awaitable> ForeachQueryNextUpdate = new ();

		// Foreach 작업을 위한 액션 큐입니다.
		private static readonly Queue<Action> foreachAction = new Queue<Action>();

		/// <summary>
		/// Foreach 시스템을 초기화하는 메서드입니다.
		/// </summary>
		internal static void InitForeach()
		{
			// ObjectBehaviour 목록에 대한 쿼리 시스템을 생성하고 초기화합니다.
			OCBehaviourListQuerySystem = QuerySystemBuilder.CreateQuery().WithAll<ObjectBehaviour>().Build();
			OCBehaviourList = new OdccQueryCollector(OCBehaviourListQuerySystem);
			OdccQueryCollectors.Add(OCBehaviourListQuerySystem, OCBehaviourList);
			OdccQueryFindCashList = new Dictionary<QuerySystem, ObjectBehaviour>();
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
			ForeachQueryUpdate.Clear();

			OdccQueryFindCashList = null;

			// 액션 큐를 초기화합니다.
			foreachAction.Clear();
		}

		/// <summary>
		/// OCBehaviour 객체를 업데이트하는 메서드입니다.
		/// </summary>
		/// <param name="behaviour">업데이트할 OCBehaviour 객체 목록</param>
		private static void OCBehaviourUpdate(IEnumerable<IOdccUpdate> behaviour)
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
				if(item is IOdccUpdate update && update._IsCanEnterUpdate)
				{
					foreachAction.Enqueue(() => {
						update.BaseUpdate();
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
		private static void OCBehaviourLateUpdate(IEnumerable<IOdccUpdate.Late> behaviour)
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
				if(item is IOdccUpdate.Late update && item._IsCanEnterUpdate)
				{
					foreachAction.Enqueue(() => {
						update.BaseLateUpdate();
					});
				}
			}

			// Foreach 액션 큐를 다시 비웁니다.
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
		}

		internal static void UpdateOdccCollectorList(IOdccObject behaviour)
		{
			if(behaviour is not ObjectBehaviour odccObject)
			{
				return;
			}
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
			foreach(var _query in OdccQueryCollectors)
			{
				var queryCollector = _query.Value;
				foreachAction.Enqueue(() => queryCollector.UpdateObjectInQuery(odccObject));
			}
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
		}
		internal static void RemoveOdccCollectorList(IOdccObject behaviour)
		{
			if(behaviour is not ObjectBehaviour odccObject)
			{
				return;
			}
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
			foreach(var _query in OdccQueryCollectors)
			{
				var queryCollector = _query.Value;
				foreachAction.Enqueue(() => {
					queryCollector.RemoveQuerySystemTarget(odccObject);
					queryCollector.RemoveLifeItem(odccObject);
				});
			}
			while(foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
		}

		internal static void AddUpdateBehaviour(IOdccUpdate behaviour)
		{
			if(behaviour is IOdccObject)
			{
				objectUpdateList.Add(behaviour);
			}
			else
			{
				componentUpdateList.Add(behaviour);
			}
		}
		internal static void AddLateUpdateBehaviour(IOdccUpdate.Late behaviour)
		{
			if(behaviour is IOdccObject)
			{
				objectLateUpdateList.Add(behaviour);
			}
			else
			{
				componentLateUpdateList.Add(behaviour);
			}
		}
		internal static void RemoveUpdateBehaviour(IOdccUpdate behaviour)
		{
			if(behaviour is IOdccObject)
			{
				objectUpdateList.Remove(behaviour);
			}
			else
			{
				componentUpdateList.Remove(behaviour);
			}
		}
		internal static void RemoveLateUpdateBehaviour(IOdccUpdate.Late behaviour)
		{
			if(behaviour is IOdccObject)
			{
				objectLateUpdateList.Remove(behaviour);
			}
			else
			{
				componentLateUpdateList.Remove(behaviour);
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
			bool waitMainUpdate = true;
			// 이전 업데이트 리스트를 처리합니다.
			foreach(var orderKey in ForeachQueryUpdate)
			{
				var order = orderKey.Key;
				var dictionary = orderKey.Value;

				if(order>0 && waitMainUpdate)
				{
					waitMainUpdate = false;
					// ObjectBehaviour 리스트를 업데이트합니다.
					OCBehaviourUpdate(objectUpdateList);
					OCBehaviourUpdate(componentUpdateList);
				}
				foreach(var item in dictionary)
				{
					var key = item.Key;
					var value = item.Value;
					if(key is not null)
					{
						if(value is null || value.IsCompleted)
						{
							try
							{
								listToNext += () => dictionary[key] = key.RunLooper();
							}
							catch(Exception ex)
							{
								Debug.LogException(ex);
							}
						}
					}
				}
			}

			if(waitMainUpdate)
			{
				// ObjectBehaviour 리스트를 업데이트합니다.
				OCBehaviourUpdate(objectUpdateList);
				OCBehaviourUpdate(componentUpdateList);
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
			OCBehaviourLateUpdate(objectLateUpdateList);
			OCBehaviourLateUpdate(componentLateUpdateList);
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

		internal static bool TryFindOdccObject(QuerySystem findQuery, bool findInCash, out ObjectBehaviour find)
		{
			if(findInCash && OdccQueryFindCashList.TryGetValue(findQuery, out find) && find != null)
			{
				return true;
			}
			find = allObjectBehaviours.Find(item => findQuery.IsSatisfiesQuery(item));

			if(!OdccQueryFindCashList.ContainsKey(findQuery)) OdccQueryFindCashList.Add(findQuery, null);
			OdccQueryFindCashList[findQuery] = find;

			return find != null;
		}
		internal static bool TryFindOdccObject(QuerySystem findQuery, out ObjectBehaviour find)
		{
			return TryFindOdccObject(findQuery, true, out find);
		}
	}
}
