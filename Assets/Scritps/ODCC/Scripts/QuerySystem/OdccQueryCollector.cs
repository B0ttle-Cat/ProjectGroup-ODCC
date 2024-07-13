using System;
using System.Collections.Generic;
using System.Linq;

using Sirenix.OdinInspector;

using UnityEngine;
using UnityEngine.SceneManagement;

namespace BC.ODCC
{
	/// <summary>
	/// OdccQueryCollector 클래스는 ODCC 시스템에서 쿼리된 항목들을 수집하고 관리하는 역할을 합니다.
	/// 이 클래스는 다양한 조건에 맞는 ObjectBehaviour 객체를 수집하고, 이를 기반으로 루퍼 및 액션 이벤트를 처리합니다.
	/// </summary>
	[Serializable]
	public class OdccQueryCollector : IDisposable
	{
#if UNITY_EDITOR
		[ShowInInspector, ReadOnly, InlineProperty, HideLabel]
		private QuerySystem onShowQuerySystem;
		[ShowInInspector, ReadOnly]
		private List<ObjectBehaviour> onShowQueryItems;
#endif
		// QuerySystem 객체입니다.
		internal QuerySystem querySystem;

		// 라이프 아이템 목록입니다.
		internal List<object> lifeItems;

		// 라이프 아이템을 파괴하지 않을지 여부를 나타냅니다.
		internal bool IsDontDestoryLifeItem { get; set; }

		// 쿼리된 ObjectBehaviour 항목들입니다.
		internal IEnumerable<ObjectBehaviour> queryItems;

		// ODCC 루퍼 딕셔너리입니다.
		internal Dictionary<string, OdccQueryLooper> odccLoopers;

		// ODCC 액션 딕셔너리입니다.
		internal Dictionary<string, OdccQueryLooper> odccActions;

		// 항목 목록 변경 시 호출되는 액션입니다.
		internal Action<ObjectBehaviour, bool> changeItemList;

		/// <summary>
		/// OdccQueryCollector의 생성자입니다.
		/// </summary>
		/// <param name="querySystem">QuerySystem 객체</param>
		internal OdccQueryCollector(QuerySystem querySystem)
		{
#if UNITY_EDITOR
			onShowQuerySystem = querySystem;
			onShowQueryItems = new List<ObjectBehaviour>();
#endif
			this.querySystem = querySystem;
			lifeItems = new List<object>();
			IsDontDestoryLifeItem = false;

			queryItems = new List<ObjectBehaviour>();
			odccLoopers = new Dictionary<string, OdccQueryLooper>();
			odccActions = new Dictionary<string, OdccQueryLooper>();
			changeItemList = null;
		}

		/// <summary>
		/// 라이프 아이템을 추가하는 메서드입니다.
		/// </summary>
		/// <param name="lifeItem">추가할 라이프 아이템</param>
		public void AddLifeItem(object lifeItem)
		{
			if(lifeItem == null || IsDontDestoryLifeItem) return;
			if(!lifeItems.Contains(lifeItem))
			{
				lifeItems.Add(lifeItem);
			}
		}

		/// <summary>
		/// 라이프 아이템을 제거하는 메서드입니다.
		/// </summary>
		/// <param name="lifeItem">제거할 라이프 아이템</param>
		public void RemoveLifeItem(object lifeItem)
		{
			if(lifeItem == null || IsDontDestoryLifeItem) return;
			lifeItems.Remove(lifeItem);
			if(lifeItems.Count == 0)
			{
				DeleteQueryCollector(this);
			}
		}

		/// <summary>
		/// 라이프 아이템을 초기화하는 메서드입니다.
		/// </summary>
		internal void ClearLifeItem()
		{
			lifeItems.Clear();
		}

		/// <summary>
		/// QuerySystem을 기반으로 OdccQueryCollector를 생성하는 메서드입니다.
		/// </summary>
		/// <param name="querySystem">QuerySystem 객체</param>
		/// <param name="lifeItem">라이프 아이템</param>
		/// <returns>OdccQueryCollector 객체</returns>
		public static OdccQueryCollector CreateQueryCollector(QuerySystem querySystem, Scene lifeItem)
		{
			var collector = _CreateQueryCollector(querySystem);
			collector.AddLifeItem(lifeItem);
			return collector;
		}

		/// <summary>
		/// QuerySystem을 기반으로 OdccQueryCollector를 생성하는 메서드입니다.
		/// </summary>
		/// <param name="querySystem">QuerySystem 객체</param>
		/// <param name="lifeItem">라이프 아이템</param>
		/// <returns>OdccQueryCollector 객체</returns>
		public static OdccQueryCollector CreateQueryCollector(QuerySystem querySystem, OCBehaviour lifeItem)
		{
			if(lifeItem == null) throw new NullReferenceException();

			var collector = _CreateQueryCollector(querySystem);
			collector.AddLifeItem(lifeItem);
			return collector;
		}

		/// <summary>
		/// QuerySystem을 기반으로 OdccQueryCollector를 생성하는 메서드입니다.
		/// </summary>
		/// <param name="querySystem">QuerySystem 객체</param>
		/// <param name="lifeItem">라이프 아이템</param>
		/// <returns>OdccQueryCollector 객체</returns>
		public static OdccQueryCollector CreateQueryCollector(QuerySystem querySystem, string lifeItem)
		{
			if(lifeItem == null) throw new NullReferenceException();

			var collector = _CreateQueryCollector(querySystem);
			collector.AddLifeItem(lifeItem);
			return collector;
		}

		/// <summary>
		/// QuerySystem을 기반으로 OdccQueryCollector를 생성하는 메서드입니다.
		/// </summary>
		/// <param name="querySystem">QuerySystem 객체</param>
		/// <returns>OdccQueryCollector 객체</returns>
		public static OdccQueryCollector CreateQueryCollector(QuerySystem querySystem)
		{
			var collector = _CreateQueryCollector(querySystem);
			collector.IsDontDestoryLifeItem = true;
			collector.ClearLifeItem();
			return collector;
		}

		/// <summary>
		/// QuerySystem을 기반으로 OdccQueryCollector를 생성하는 내부 메서드입니다.
		/// </summary>
		/// <param name="querySystem">QuerySystem 객체</param>
		/// <returns>OdccQueryCollector 객체</returns>
		private static OdccQueryCollector _CreateQueryCollector(QuerySystem querySystem)
		{
			var odccQueryCollectors = OdccForeach.OdccQueryCollectors;
			if(odccQueryCollectors.ContainsKey(querySystem))
			{
				return odccQueryCollectors[querySystem];
			}
			else
			{
				OdccQueryCollector newCollector = new OdccQueryCollector(querySystem);

				var objectList = OdccForeach.objectBehaviourList;
				if(objectList != null)
				{
					foreach(var item in objectList)
					{
						newCollector.AddObject(item);
					}
				}

				odccQueryCollectors.Add(querySystem, newCollector);
				return newCollector;
			}
		}

		/// <summary>
		/// QuerySystem을 기반으로 OdccQueryCollector를 삭제하는 메서드입니다.
		/// </summary>
		/// <param name="querySystem">QuerySystem 객체</param>
		/// <param name="lifeItem">라이프 아이템</param>
		public static void DeleteQueryCollector(QuerySystem querySystem, string lifeItem)
		{
			if(querySystem != null && OdccForeach.OdccQueryCollectors.ContainsKey(querySystem))
			{
				OdccForeach.OdccQueryCollectors[querySystem].RemoveLifeItem(lifeItem);
			}
		}

		/// <summary>
		/// QuerySystem을 기반으로 OdccQueryCollector를 삭제하는 메서드입니다.
		/// </summary>
		/// <param name="querySystem">QuerySystem 객체</param>
		public static void DeleteQueryCollector(QuerySystem querySystem)
		{
			if(querySystem != null && OdccForeach.OdccQueryCollectors.ContainsKey(querySystem))
			{
				DeleteQueryCollector(OdccForeach.OdccQueryCollectors[querySystem]);
			}
		}

		/// <summary>
		/// OdccQueryCollector를 삭제하는 내부 메서드입니다.
		/// </summary>
		/// <param name="collector">OdccQueryCollector 객체</param>
		private static void DeleteQueryCollector(OdccQueryCollector collector)
		{
			if(collector == null) return;
			OdccForeach.OdccQueryCollectors?.Remove(collector.querySystem);
#pragma warning disable CS0618
			collector.Dispose();
#pragma warning restore CS0618
		}

		/// <summary>
		/// OdccQueryCollector를 해제하는 메서드입니다.
		/// </summary>
		[Obsolete("절대 수동으로 호출하지 마세요.")]
		public void Dispose()
		{
#if UNITY_EDITOR
			onShowQuerySystem = null;
			onShowQueryItems = null;
#endif
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

		/// <summary>
		/// 루퍼 이벤트를 생성하는 메서드입니다.
		/// </summary>
		/// <param name="key">루퍼 키</param>
		/// <param name="loopOrder">업데이트 순서. 0 ~ 1 사이에 메인업데이트가 이루어짐</param>
		/// <returns>OdccQueryLooper 객체</returns>
		public OdccQueryLooper CreateLooperEvent(string key, int loopOrder = 0)
		{
			return CreateLooperEvent(key, out _, loopOrder);
		}
		public OdccQueryLooper CreateLooperEvent(string key, out OdccQueryLooper looper, int loopOrder = 0)
		{
			if(odccLoopers.ContainsKey(key))
			{
				looper = odccLoopers[key];
				return looper;
			}
			else
			{
				looper = OdccQueryLooper.CreateLooperEvent(this, key, loopOrder);
				odccLoopers.Add(key, looper);
				return looper;
			}
		}
		/// <summary>
		/// 액션 이벤트를 생성하는 메서드입니다.
		/// </summary>
		/// <param name="key">액션 키</param>
		/// <returns>OdccQueryLooper 객체</returns>
		public OdccQueryLooper CreateActionEvent(string key)
		{
			return CreateActionEvent(key, out _);
		}
		public OdccQueryLooper CreateActionEvent(string key, out OdccQueryLooper looper)
		{
			if(odccActions.ContainsKey(key))
			{
				looper = odccActions[key];
				return looper;
			}
			else
			{
				looper = OdccQueryLooper.CreateActionEvent(this, key);
				odccActions.Add(key, looper);
				return looper;
			}
		}

		/// <summary>
		/// 루퍼 이벤트를 삭제하는 메서드입니다.
		/// </summary>
		/// <param name="key">루퍼 키</param>
		/// <returns>OdccQueryCollector 객체</returns>
		public OdccQueryCollector DeleteLooperEvent(string key)
		{
			if(odccLoopers is not null && odccLoopers.ContainsKey(key))
			{
				odccLoopers[key].Dispose();
				odccLoopers.Remove(key);
			}
			return this;
		}

		/// <summary>
		/// 액션 이벤트를 삭제하는 메서드입니다.
		/// </summary>
		/// <param name="key">액션 키</param>
		/// <returns>OdccQueryCollector 객체</returns>
		public OdccQueryCollector DeleteActionEvent(string key)
		{
			if(odccActions is not null && odccActions.ContainsKey(key))
			{
				odccActions[key].Dispose();
				odccActions.Remove(key);
			}
			return this;
		}

		/// <summary>
		/// 루퍼 이벤트를 반환 메서드입니다.
		/// </summary>
		/// <param name="key">루퍼 키</param>
		/// <returns>OdccQueryLooper 객체</returns>
		public OdccQueryLooper GetLooperEvent(string key)
		{
			if(odccLoopers.ContainsKey(key))
			{
				return odccLoopers[key];
			}
			return null;
		}

		/// <summary>
		/// 액션 이벤트를 반환 메서드입니다.
		/// </summary>
		/// <param name="key">액션 키</param>
		/// <returns>OdccQueryLooper 객체</returns>
		public OdccQueryLooper GetActionEvent(string key)
		{
			if(odccActions.ContainsKey(key))
			{
				return odccActions[key];
			}
			return null;
		}

		/// <summary>
		/// 변경된 목록 이벤트를 생성하는 메서드입니다.
		/// </summary>
		/// <param name="setInitList">초기 목록 설정 액션</param>
		/// <param name="changeListEvent">목록 변경 이벤트 액션</param>
		/// <returns>OdccQueryCollector 객체</returns>
		public OdccQueryCollector CreateChangeListEvent(Action<IEnumerable<ObjectBehaviour>> setInitList, Action<ObjectBehaviour, bool> changeListEvent)
		{
			if(setInitList != null)
				setInitList.Invoke(GetQueryItems());

			if(changeListEvent != null)
				changeItemList += changeListEvent;

			return this;
		}

		/// <summary>
		/// 변경된 목록 이벤트를 삭제하는 메서드입니다.
		/// </summary>
		/// <param name="changeListEvent">목록 변경 이벤트 액션</param>
		/// <returns>OdccQueryCollector 객체</returns>
		public OdccQueryCollector DeleteChangeListEvent(Action<ObjectBehaviour, bool> changeListEvent)
		{
			if(changeListEvent != null)
				changeItemList -= changeListEvent;

			return this;
		}

		/// <summary>
		/// ObjectBehaviour 객체를 추가하는 메서드입니다.
		/// </summary>
		/// <param name="item">추가할 ObjectBehaviour 객체</param>
		/// <param name="passDoubleCheck">중복 확인 여부</param>
		internal void AddObject(ObjectBehaviour item, bool passDoubleCheck = false)
		{
			if(queryItems.Contains(item)) return;

			if(passDoubleCheck || IsSatisfiesQuery(item))
			{
				var list = queryItems.ToList();
				list.Add(item);
				queryItems = list;
#if UNITY_EDITOR
				onShowQueryItems = new List<ObjectBehaviour>();
				onShowQueryItems.AddRange(list);
#endif
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

		/// <summary>
		/// ObjectBehaviour 객체를 제거하는 메서드입니다.
		/// </summary>
		/// <param name="item">제거할 ObjectBehaviour 객체</param>
		internal void RemoveObject(ObjectBehaviour item)
		{
			if(!queryItems.Contains(item)) return;

			var list = queryItems.ToList();
			if(list.Remove(item))
			{
				queryItems = list;
#if UNITY_EDITOR
				onShowQueryItems = new List<ObjectBehaviour>();
				onShowQueryItems.AddRange(list);
#endif
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
		/// <summary>
		/// 수집기의 타겟이 유효할수 있는지 검사하는 메서드입니다.
		/// </summary>
		/// <param name="item">제거할 ObjectBehaviour 객체</param>
		internal void RemoveQuerySystemTarget(ObjectBehaviour item)
		{
			if(querySystem.TargetInstanceID == item.GetInstanceID())
			{
				querySystem.TargetInstanceID = 0;
			}
		}
		/// <summary>
		/// 수집기의 타겟이 유효할수 있는지 검사하는 메서드입니다.
		/// </summary>
		/// <param name="item">제거할 ObjectBehaviour 객체</param>
		internal void RemoveQuerySystemTarget(Scene item)
		{
			if(querySystem.TargetScene == item)
			{
				querySystem.TargetScene = default;
			}
		}

		/// <summary>
		/// ObjectBehaviour 객체가 쿼리 조건을 만족하는지 확인하는 메서드입니다.
		/// </summary>
		/// <param name="item">확인할 ObjectBehaviour 객체</param>
		/// <returns>조건을 만족하면 true, 아니면 false</returns>
		internal bool IsSatisfiesQuery(ObjectBehaviour item)
		{
#if UNITY_EDITOR
			if(!Application.isPlaying) return false;
#endif
			if(item == null) return false;

			List<int> indexs = new List<int>();
			try
			{
				indexs.AddRange(OdccManager.GetTypeToIndex(item));
			}
			catch(Exception ex)
			{
				Debug.LogError($"item:{item}{item.name}");
				Debug.LogException(ex);
			}

			return querySystem.IsAll(indexs) && querySystem.IsAny(indexs) && querySystem.IsNone(indexs);
		}

		/// <summary>
		/// 쿼리에 있는 ObjectBehaviour 객체를 업데이트하는 메서드입니다.
		/// </summary>
		/// <param name="item">업데이트할 ObjectBehaviour 객체</param>
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

		/// <summary>
		/// 쿼리된 ObjectBehaviour 항목들을 반환하는 메서드입니다.
		/// </summary>
		/// <returns>쿼리된 ObjectBehaviour 항목들</returns>
		public IEnumerable<ObjectBehaviour> GetQueryItems()
		{
			return queryItems;
		}

		/// <summary>
		/// QuerySystem 객체를 반환하는 메서드입니다.
		/// </summary>
		/// <returns>QuerySystem 객체</returns>
		public QuerySystem GetQuerySystem()
		{
			return querySystem;
		}

		/// <summary>
		/// 이 OdccQueryCollector 객체를 반환하는 메서드입니다.
		/// OdccQueryLooper와 혼용할 경우의 작성 규칙 통일을 위해 존재합니다.
		/// </summary>
		public OdccQueryCollector GetCollector()
		{
			return this;
		}

		/////////////////////////// Obsolete //////////////////////////

		[Obsolete("CreateLooperEvent 를 사용할 것 - 오래된 이름 규칙", true)]
		private OdccQueryLooper CreateLooper(string key, bool prevUpdate = true)
		{
			return CreateLooperEvent(key, prevUpdate ? 0 : 1);
		}

		[Obsolete("DeleteLooperEvent 를 사용할 것 - 오래된 이름 규칙", true)]
		private OdccQueryCollector DeleteLooper(string key)
		{
			return DeleteLooperEvent(key);
		}

		[Obsolete("CreateActionEvent 를 사용할 것 - 오래된 이름 규칙", true)]
		private OdccQueryLooper CreateCallEvent(string key)
		{
			return CreateActionEvent(key);
		}

		[Obsolete("DeleteActionEvent 를 사용할 것 - 오래된 이름 규칙", true)]
		private OdccQueryCollector DeleteCallEvent(string key)
		{
			return DeleteActionEvent(key);
		}

		public OdccQueryCollector CreateLooperEvent(object onUnitTargetCollectorUpdate)
		{
			throw new NotImplementedException();
		}
	}
}
