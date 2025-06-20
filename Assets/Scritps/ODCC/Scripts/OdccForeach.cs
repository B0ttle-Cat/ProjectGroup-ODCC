using System;
using System.Collections.Generic;

using BC.Base;

using UnityEngine.SceneManagement;

using Debug = UnityEngine.Debug;

namespace BC.ODCC
{
	/// <summary>
	/// OdccForeach 클래스는 ODCC 시스템의 CallForeach 기능을 관리하는 정적 클래스입니다.
	/// </summary>
	internal static class OdccForeach
	{
		// ObjectBehaviour 목록을 관리하는 OdccQueryCollector입니다.
		internal static OdccQueryCollector OCBehaviourList;

		// ObjectBehaviour 목록에 대한 쿼리 시스템입니다.
		internal static OdccQuerySystem OCBehaviourListQuerySystem;

		// ODCC 쿼리 컬렉터들을 관리하는 딕셔너리입니다.
		internal static Dictionary<OdccQuerySystem, OdccQueryCollector> OdccQueryCollectors = new ();

		// ODCC 쿼리 컬렉터들을 관리하는 딕셔너리입니다.
		internal static Dictionary<OdccQuerySystem, ObjectBehaviour> OdccQueryFindCashList = new ();

		internal static List<ObjectBehaviour> allObjectBehaviours = new List<ObjectBehaviour>();

		// ObjectBehaviour 의 Update 리스트입니다.
		internal static List<IOdccUpdate> objectUpdateList = new List<IOdccUpdate>();

		// ComponentBehaviour 의 Update리스트입니다.
		internal static List<IOdccUpdate> componentUpdateList = new List<IOdccUpdate>();

		// ObjectBehaviour 의 Fast Update 리스트입니다.
		internal static List<IOdccUpdate.Fast> objectFastUpdateList = new List<IOdccUpdate.Fast>();

		// ComponentBehaviour 의 Fast Update리스트입니다.
		internal static List<IOdccUpdate.Fast> componentFastUpdateList = new List<IOdccUpdate.Fast>();

		// ObjectBehaviour 의 Late Update 리스트입니다.
		internal static List<IOdccUpdate.Late> objectLateUpdateList = new List<IOdccUpdate.Late>();

		// ComponentBehaviour 의 Late Update리스트입니다.
		internal static List<IOdccUpdate.Late> componentLateUpdateList = new List<IOdccUpdate.Late>();

		// ObjectBehaviour 의 FixedUpdate 리스트입니다.
		internal static List<IOdccUpdate.Fixed> objectFixedUpdateList = new List<IOdccUpdate.Fixed>();

		// ComponentBehaviour 의 FixedUpdate 리스트입니다.
		internal static List<IOdccUpdate.Fixed> componentFixedUpdateList = new List<IOdccUpdate.Fixed>();

		internal static HashSet<IOCBehaviour> reservationDestroyObject = new HashSet<IOCBehaviour>();

		internal static SortedDictionary<int, Dictionary<OdccQueryLooper, UnityEngine.Awaitable>> ForeachQueryUpdate = new ();
		internal static SortedDictionary<int, Dictionary<OdccQueryLooper, UnityEngine.Awaitable>> ForeachQueryFixedUpdate = new ();

		[Obsolete("Using ForeachQueryUpdate", true)]
		internal static Dictionary<OdccQueryLooper, UnityEngine.Awaitable> ForeachQueryPrevUpdate = new ();
		[Obsolete("Using ForeachQueryUpdate", true)]
		internal static Dictionary<OdccQueryLooper, UnityEngine.Awaitable> ForeachQueryNextUpdate = new ();

		// CallForeach 작업을 위한 액션 큐입니다.
		private static readonly Queue<Action> foreachAction = new Queue<Action>();

		/// <summary>
		/// CallForeach 시스템을 초기화하는 메서드입니다.
		/// </summary>
		internal static void InitForeach()
		{
			// ObjectBehaviour 목록에 대한 쿼리 시스템을 생성하고 초기화합니다.
			OCBehaviourListQuerySystem = OdccQueryBuilder.CreateQuery().WithAll<ObjectBehaviour>().Build();
			OCBehaviourList = new OdccQueryCollector(OCBehaviourListQuerySystem);
			OdccQueryCollectors.Add(OCBehaviourListQuerySystem, OCBehaviourList);
			OdccQueryFindCashList = new Dictionary<OdccQuerySystem, ObjectBehaviour>();
			OCBehaviourList.IsDontDestoryLifeItem = true;
			OCBehaviourList.ClearLifeItem();
		}

		/// <summary>
		/// CallForeach 시스템을 해제하는 메서드입니다.
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
			ForeachQueryFixedUpdate.Clear();

			OdccQueryFindCashList = null;

			// 액션 큐를 초기화합니다.
			foreachAction.Clear();
		}

		/// <summary>
		/// OCBehaviour 객체를 업데이트하는 메서드입니다.
		/// </summary>
		private static void OCBehaviourUpdate(IEnumerable<IOdccUpdate> behaviour)
		{
			if (behaviour == null) return;

			// CallForeach 액션 큐를 비웁니다.
			while (foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}

			// 각 OCBehaviour 객체에 대해 업데이트 작업을 수행합니다.
			foreach (var _item in behaviour)
			{
				var item = _item;
				if (item is IOdccUpdate update && update._IsCanEnterUpdate)
				{
					foreachAction.Enqueue(() => {
						if (update.PassUpdate) return;
						TimeControl.ApplyTypeScale(update.TimeID);
						update.BaseUpdate();
					});
				}
			}

			// CallForeach 액션 큐를 다시 비웁니다.
			while (foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
		}
		private static void OCBehaviourLateUpdate(IEnumerable<IOdccUpdate.Late> behaviour)
		{
			if (behaviour == null) return;

			// CallForeach 액션 큐를 비웁니다.
			while (foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}

			// 각 OCBehaviour 객체에 대해 LateUpdate 작업을 수행합니다.
			foreach (var _item in behaviour)
			{
				var item = _item;
				if (item is IOdccUpdate.Late update && item._IsCanEnterUpdate)
				{
					foreachAction.Enqueue(() => {
						if (update.PassUpdate) return;
						TimeControl.ApplyTypeScale(update.TimeID);
						update.BaseLateUpdate();
					});
				}
			}

			// CallForeach 액션 큐를 다시 비웁니다.
			while (foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
		}
		private static void OCBehaviourFastUpdate(IEnumerable<IOdccUpdate.Fast> behaviour)
		{
			if (behaviour == null) return;

			// CallForeach 액션 큐를 비웁니다.
			while (foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}

			// 각 OCBehaviour 객체에 대해 FastUpdate 작업을 수행합니다.
			foreach (var _item in behaviour)
			{
				var item = _item;
				if (item is IOdccUpdate.Fast update && item._IsCanEnterUpdate)
				{
					foreachAction.Enqueue(() => {
						if (update.PassUpdate) return;
						TimeControl.ApplyTypeScale(update.TimeID);
						update.BaseFastUpdate();
					});
				}
			}

			// CallForeach 액션 큐를 다시 비웁니다.
			while (foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
		}
		private static void OCBehaviourFixedUpdate(IEnumerable<IOdccUpdate.Fixed> behaviour)
		{
			if (behaviour == null) return;

			// CallForeach 액션 큐를 비웁니다.
			while (foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}

			// 각 OCBehaviour 객체에 대해 FastUpdate 작업을 수행합니다.
			foreach (var _item in behaviour)
			{
				var item = _item;
				if (item is IOdccUpdate.Fixed update && item._IsCanEnterUpdate)
				{
					foreachAction.Enqueue(() => {
						if (update.PassUpdate) return;
						TimeControl.ApplyTypeScale(update.TimeID);
						update.BaseFixedUpdate();
					});
				}
			}

			// CallForeach 액션 큐를 다시 비웁니다.
			while (foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
		}

		internal static void UpdateOdccCollectorList(IOdccObject behaviour)
		{
			if (behaviour is not ObjectBehaviour odccObject)
			{
				return;
			}
			while (foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
			foreach (var _query in OdccQueryCollectors)
			{
				var queryCollector = _query.Value;
				foreachAction.Enqueue(() => queryCollector.UpdateObjectInQuery(odccObject));
			}
			while (foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
		}
		internal static void RemoveOdccCollectorList(IOdccObject behaviour)
		{
			if (behaviour is not ObjectBehaviour odccObject)
			{
				return;
			}
			while (foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
			foreach (var _query in OdccQueryCollectors)
			{
				var queryCollector = _query.Value;
				foreachAction.Enqueue(() => {
					queryCollector.RemoveQuerySystemTarget(odccObject);
					queryCollector.RemoveLifeItem(odccObject);
				});
			}
			while (foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
		}

		internal static void AddUpdateBehaviour(IOdccUpdate behaviour)
		{
			if (behaviour is IOdccObject)
			{
				TryInsert(ref objectUpdateList, behaviour);
			}
			else
			{
				TryInsert(ref componentUpdateList, behaviour);
			}
			void TryInsert(ref List<IOdccUpdate> list, IOdccUpdate behaviour)
			{
				int length = list.Count;
				for (int i = 0 ; i < length ; i++)
				{
					if (list[i].UpdatePriority > behaviour.UpdatePriority)
					{
						list.Insert(i, behaviour);
						return;
					}
				}
				list.Add(behaviour);
			}
		}

		internal static void AddLateUpdateBehaviour(IOdccUpdate.Late behaviour)
		{
			if (behaviour is IOdccObject)
			{
				TryInsert(ref objectLateUpdateList, behaviour);
			}
			else
			{
				TryInsert(ref componentLateUpdateList, behaviour);
			}
			void TryInsert(ref List<IOdccUpdate.Late> list, IOdccUpdate.Late behaviour)
			{
				int length = list.Count;
				for (int i = 0 ; i < length ; i++)
				{
					if (list[i].UpdatePriority > behaviour.UpdatePriority)
					{
						list.Insert(i, behaviour);
						return;
					}
				}
				list.Add(behaviour);
			}
		}
		internal static void AddFastUpdateBehaviour(IOdccUpdate.Fast behaviour)
		{
			if (behaviour is IOdccObject)
			{
				TryInsert(ref objectFastUpdateList, behaviour);
			}
			else
			{
				TryInsert(ref componentFastUpdateList, behaviour);
			}
			void TryInsert(ref List<IOdccUpdate.Fast> list, IOdccUpdate.Fast behaviour)
			{
				int length = list.Count;
				for (int i = 0 ; i < length ; i++)
				{
					if (list[i].UpdatePriority > behaviour.UpdatePriority)
					{
						list.Insert(i, behaviour);
						return;
					}
				}
				list.Add(behaviour);
			}
		}
		internal static void AddFixedUpdateBehaviour(IOdccUpdate.Fixed behaviour)
		{
			if (behaviour is IOdccObject)
			{
				TryInsert(ref objectFixedUpdateList, behaviour);
			}
			else
			{
				TryInsert(ref componentFixedUpdateList, behaviour);
			}
			void TryInsert(ref List<IOdccUpdate.Fixed> list, IOdccUpdate.Fixed behaviour)
			{
				int length = list.Count;
				for (int i = 0 ; i < length ; i++)
				{
					if (list[i].UpdatePriority > behaviour.UpdatePriority)
					{
						list.Insert(i, behaviour);
						return;
					}
				}
				list.Add(behaviour);
			}
		}
		internal static void RemoveUpdateBehaviour(IOdccUpdate behaviour)
		{
			if (behaviour is IOdccObject)
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
			if (behaviour is IOdccObject)
			{
				objectLateUpdateList.Remove(behaviour);
			}
			else
			{
				componentLateUpdateList.Remove(behaviour);
			}
		}
		internal static void RemoveFastUpdateBehaviour(IOdccUpdate.Fast behaviour)
		{
			if (behaviour is IOdccObject)
			{
				objectFastUpdateList.Remove(behaviour);
			}
			else
			{
				componentFastUpdateList.Remove(behaviour);
			}
		}
		internal static void RemoveFixedUpdateBehaviour(IOdccUpdate.Fixed behaviour)
		{
			if (behaviour is IOdccObject)
			{
				objectFixedUpdateList.Remove(behaviour);
			}
			else
			{
				componentFixedUpdateList.Remove(behaviour);
			}
		}
		/// <summary>
		/// 쿼리에 있는 ObjectBehaviour 객체를 업데이트하는 메서드입니다.
		/// </summary>
		/// <param name="updateObject">업데이트할 ObjectBehaviour 객체</param>
		internal static void UpdateObjectInQuery(ObjectBehaviour updateObject)
		{
			if (updateObject is null) return;

			// CallForeach 액션 큐를 비웁니다.
			while (foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}

			// 각 쿼리 컬렉터에 대해 객체를 업데이트합니다.
			foreach (var _query in OdccQueryCollectors)
			{
				var query = _query;
				foreachAction.Enqueue(() => {
					OdccQueryCollector queryCollector = query.Value;
					queryCollector.UpdateObjectInQuery(updateObject);
				});
			}

			// CallForeach 액션 큐를 다시 비웁니다.
			while (foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
		}

		/// <summary>
		/// CallForeach 시스템의 업데이트를 수행하는 메서드입니다.
		/// </summary>
		internal static void ForeachUpdate()
		{
			//Action listToNext = null;
			Action beforeMainUpdate = null;
			Action afterMainUpdate = null;

			foreach (var orderKey in ForeachQueryUpdate)
			{
				var order = orderKey.Key;
				var dictionary = orderKey.Value;

				foreach (var item in dictionary)
				{
					var key = item.Key;
					var value = item.Value;
					if (key is not null)
					{
						if (value is null || value.IsCompleted)
						{
							try
							{
								if (order<=0)
								{
									beforeMainUpdate += () => dictionary[key] = key.RunAwaitable();
								}
								else
								{
									afterMainUpdate += () => dictionary[key] = key.RunAwaitable();
								}
							}
							catch (Exception ex)
							{
								Debug.LogException(ex);
							}
						}
					}
				}
			}

			beforeMainUpdate?.Invoke();
			OCBehaviourUpdate(objectUpdateList);
			OCBehaviourUpdate(componentUpdateList);
			TimeControl.ApplyTypeScale(null);
			afterMainUpdate?.Invoke();

		}

		/// <summary>
		/// CallForeach 시스템의 LateUpdate를 수행하는 메서드입니다.
		/// </summary>
		internal static void ForeachLateUpdate()
		{
			// ObjectBehaviour 리스트의 LateUpdate를 수행합니다.
			OCBehaviourLateUpdate(objectLateUpdateList);
			OCBehaviourLateUpdate(componentLateUpdateList);
			TimeControl.ApplyTypeScale(null);
		}
		/// <summary>
		/// CallForeach 시스템의 FastUpdate를 수행하는 메서드입니다.
		/// </summary>
		internal static void ForeachFastUpdate()
		{
			// ObjectBehaviour 리스트의 LateUpdate를 수행합니다.
			OCBehaviourFastUpdate(objectFastUpdateList);
			OCBehaviourFastUpdate(componentFastUpdateList);
			TimeControl.ApplyTypeScale(null);
		}
		/// <summary>
		/// CallForeach 시스템의 FixedUpdate를 수행하는 메서드입니다.
		/// </summary>
		internal static void ForeachFixedUpdate()
		{
			//Action listToNext = null;
			Action beforeMainUpdate = null;
			Action afterMainUpdate = null;

			foreach (var orderKey in ForeachQueryFixedUpdate)
			{
				var order = orderKey.Key;
				var dictionary = orderKey.Value;

				foreach (var item in dictionary)
				{
					var key = item.Key;
					var value = item.Value;
					if (key is not null)
					{
						if (value is null || value.IsCompleted)
						{
							try
							{
								if (order<=0)
								{
									beforeMainUpdate += () => dictionary[key] = key.RunAwaitable();
								}
								else
								{
									afterMainUpdate += () => dictionary[key] = key.RunAwaitable();
								}
							}
							catch (Exception ex)
							{
								Debug.LogException(ex);
							}
						}
					}
				}
			}

			beforeMainUpdate?.Invoke();
			OCBehaviourFixedUpdate(objectFixedUpdateList);
			OCBehaviourFixedUpdate(componentFixedUpdateList);
			TimeControl.ApplyTypeScale(null);
			afterMainUpdate?.Invoke();

		}
		/// <summary>
		/// LifeItem에서 씬을 기준으로 OCBehaviour를 제거하는 메서드입니다.
		/// </summary>
		/// <param name="scene">제거할 씬</param>
		internal static void RemoveLifeItemOdccCollectorList(Scene scene)
		{
			// CallForeach 액션 큐를 비웁니다.
			while (foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}

			// 각 쿼리 컬렉터에서 씬을 기준으로 OCBehaviour를 제거합니다.
			foreach (var _query in OdccQueryCollectors)
			{
				OdccQueryCollector queryCollector = _query.Value;
				foreachAction.Enqueue(() => {
					queryCollector.RemoveLifeItem(scene);
					queryCollector.RemoveQuerySystemTarget(scene);
				});
			}

			// CallForeach 액션 큐를 비웁니다.
			while (foreachAction.Count > 0)
			{
				foreachAction.Dequeue().Invoke();
			}
		}

		internal static bool TryFindOdccObject(OdccQuerySystem findQuery, bool findInCash, out ObjectBehaviour find)
		{
			if (findInCash && OdccQueryFindCashList.TryGetValue(findQuery, out find) && find != null)
			{
				return true;
			}
			find = allObjectBehaviours.Find(item => findQuery.IsSatisfiesQuery(item));

			if (!OdccQueryFindCashList.ContainsKey(findQuery)) OdccQueryFindCashList.Add(findQuery, null);
			OdccQueryFindCashList[findQuery] = find;

			return find != null;
		}
		internal static bool TryFindOdccObject(OdccQuerySystem findQuery, out ObjectBehaviour find)
		{
			return TryFindOdccObject(findQuery, true, out find);
		}
	}
}
