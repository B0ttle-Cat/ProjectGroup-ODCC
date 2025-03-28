﻿using System;
using System.Collections.Generic;

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
		[ShowInInspector, ReadOnly, InlineProperty, HideLabel]
		// OdccQuerySystem 객체입니다.
		internal OdccQuerySystem querySystem;
#if UNITY_EDITOR
		[ShowInInspector, ReadOnly]
		private List<ObjectBehaviour> onShowQueryItems;
#endif

		// 라이프 아이템 목록입니다.
		internal List<object> lifeItems;

		// 라이프 아이템을 파괴하지 않을지 여부를 나타냅니다.
		internal bool IsDontDestoryLifeItem { get; set; }

		// 쿼리된 ObjectBehaviour 항목들입니다.
		internal List<ObjectBehaviour> queryItems;

		// ODCC 루퍼 딕셔너리입니다.
		internal Dictionary<string, OdccQueryLooper> odccLoopers;

		// ODCC 액션 딕셔너리입니다.
		internal Dictionary<string, OdccQueryLooper> odccActions;

		// 항목 목록 변경 시 호출되는 액션입니다.
		internal Action<ObjectBehaviour, bool> changeItemList;

		/// <summary>
		/// OdccQueryCollector의 생성자입니다.
		/// </summary>
		/// <param name="querySystem">OdccQuerySystem 객체</param>
		internal OdccQueryCollector(OdccQuerySystem querySystem)
		{
#if UNITY_EDITOR
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
			if(lifeItems.Remove(lifeItem) && lifeItems.Count == 0)
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
		/// OdccQuerySystem을 기반으로 OdccQueryCollector를 생성하는 메서드입니다.
		/// </summary>
		/// <param name="querySystem">OdccQuerySystem 객체</param>
		/// <param name="lifeItem">라이프 아이템</param>
		/// <returns>OdccQueryCollector 객체</returns>
		public static OdccQueryCollector CreateQueryCollector(OdccQuerySystem querySystem, Scene lifeItem)
		{
			var collector = _CreateQueryCollector(querySystem);
			collector.AddLifeItem(lifeItem);
			return collector;
		}

		/// <summary>
		/// OdccQuerySystem을 기반으로 OdccQueryCollector를 생성하는 메서드입니다.
		/// </summary>
		/// <param name="querySystem">OdccQuerySystem 객체</param>
		/// <param name="lifeItem">라이프 아이템</param>
		/// <returns>OdccQueryCollector 객체</returns>
		public static OdccQueryCollector CreateQueryCollector(OdccQuerySystem querySystem, OCBehaviour lifeItem)
		{
			if(lifeItem == null) throw new NullReferenceException();

			var collector = _CreateQueryCollector(querySystem);
			collector.AddLifeItem(lifeItem);
			return collector;
		}

		/// <summary>
		/// OdccQuerySystem을 기반으로 OdccQueryCollector를 생성하는 메서드입니다.
		/// </summary>
		/// <param name="querySystem">OdccQuerySystem 객체</param>
		/// <param name="lifeItem">라이프 아이템</param>
		/// <returns>OdccQueryCollector 객체</returns>
		public static OdccQueryCollector CreateQueryCollector(OdccQuerySystem querySystem, string lifeItem)
		{
			if(lifeItem == null) throw new NullReferenceException();

			var collector = _CreateQueryCollector(querySystem);
			collector.AddLifeItem(lifeItem);
			return collector;
		}

		/// <summary>
		/// OdccQuerySystem을 기반으로 OdccQueryCollector를 생성하는 메서드입니다.
		/// </summary>
		/// <param name="querySystem">OdccQuerySystem 객체</param>
		/// <returns>OdccQueryCollector 객체</returns>
		public static OdccQueryCollector CreateQueryCollector(OdccQuerySystem querySystem)
		{
			var collector = _CreateQueryCollector(querySystem);
			collector.IsDontDestoryLifeItem = true;
			collector.ClearLifeItem();
			return collector;
		}

		/// <summary>
		/// OdccQuerySystem을 기반으로 OdccQueryCollector를 생성하는 내부 메서드입니다.
		/// </summary>
		/// <param name="querySystem">OdccQuerySystem 객체</param>
		/// <returns>OdccQueryCollector 객체</returns>
		private static OdccQueryCollector _CreateQueryCollector(OdccQuerySystem querySystem)
		{
			var odccQueryCollectors = OdccForeach.OdccQueryCollectors;
			if(odccQueryCollectors.ContainsKey(querySystem))
			{
				return odccQueryCollectors[querySystem];
			}
			else
			{
				OdccQueryCollector newCollector = new OdccQueryCollector(querySystem);

				var objectList = OdccForeach.OCBehaviourList.GetQueryItemList();
				if(objectList != null)
				{
					foreach(var item in objectList)
					{
						if(!newCollector.HasObject(item)) newCollector.AddObject(item);
					}
				}

				odccQueryCollectors.Add(querySystem, newCollector);
				return newCollector;
			}
		}

		/// <summary>
		/// OdccQuerySystem을 기반으로 OdccQueryCollector를 삭제하는 메서드입니다.
		/// </summary>
		/// <param name="querySystem">OdccQuerySystem 객체</param>
		/// <param name="lifeItem">라이프 아이템 (string 외 다른 항목은 자동으로 체크함)</param>
		public static void DeleteQueryCollector(OdccQuerySystem querySystem, string lifeItem)
		{
			if(querySystem != null && OdccForeach.OdccQueryCollectors.ContainsKey(querySystem))
			{
				OdccForeach.OdccQueryCollectors[querySystem].RemoveLifeItem(lifeItem);
			}
		}

		/// <summary>
		/// OdccQuerySystem을 기반으로 OdccQueryCollector를 삭제하는 메서드입니다.
		/// </summary>
		/// <param name="querySystem">OdccQuerySystem 객체</param>
		public static void DeleteQueryCollector(OdccQuerySystem querySystem)
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
		public OdccQueryLooper CreateFixedLooperEvent(string key, int loopOrder = 0)
		{
			return CreateFixedLooperEvent(key, out _, loopOrder);
		}
		public OdccQueryLooper CreateFixedLooperEvent(string key, out OdccQueryLooper looper, int loopOrder = 0)
		{
			if(odccLoopers.ContainsKey(key))
			{
				looper = odccLoopers[key];
				return looper;
			}
			else
			{
				looper = OdccQueryLooper.CreateFixedLooperEvent(this, key, loopOrder);
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
		public OdccQueryCollector CreateChangedListEvent(Action<IEnumerable<ObjectBehaviour>> setInitList, Action<ObjectBehaviour, bool> changeListEvent)
		{
			if(setInitList != null)
				setInitList.Invoke(GetQueryItemList());

			if(changeListEvent != null)
				changeItemList += changeListEvent;

			return this;
		}
		/// <summary>
		/// 변경된 목록 이벤트를 생성하는 메서드입니다.
		/// 초기화 목록을 따로 등록하지 않는 대신 최초에 한번 changeListEvent를 여러번 호출합니다.
		/// </summary>
		/// <param name="changeListEvent">목록 변경 이벤트 액션</param>
		/// <returns>OdccQueryCollector 객체</returns>
		public OdccQueryCollector CreateChangedListEvent(Action<ObjectBehaviour, bool> changeListEvent)
		{
			if(changeListEvent != null)
			{
				var list = GetQueryItemList();
				if(list != null)
				{
					foreach(var item in list)
					{
						changeListEvent.Invoke(item, true);
					}
				}
			}

			if(changeListEvent != null)
				changeItemList += changeListEvent;

			return this;
		}

		/// <summary>
		/// 변경된 목록 이벤트를 삭제하는 메서드입니다.
		/// </summary>
		/// <param name="changeListEvent">목록 변경 이벤트 액션</param>
		/// <returns>OdccQueryCollector 객체</returns>
		public OdccQueryCollector DeleteChangedListEvent(Action<ObjectBehaviour, bool> changeListEvent)
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
		internal bool HasObject(ObjectBehaviour item)
		{
			return queryItems.Contains(item);
		}
		/// <summary>
		/// ObjectBehaviour 객체를 추가하는 메서드입니다.
		/// </summary>
		/// <param name="item">추가할 ObjectBehaviour 객체</param>
		/// <param name="passDoubleCheck">중복 확인 여부</param>
		internal bool AddObject(ObjectBehaviour item)
		{
			if(IsSatisfiesQuery(item))
			{
				queryItems.Add(item);
				changeItemList?.Invoke(item, true);

				foreach(var looper in odccLoopers)
				{
					looper.Value.Add(item);
				}

				foreach(var looper in odccActions)
				{
					looper.Value.Add(item);
				}
#if UNITY_EDITOR
				onShowQueryItems = new List<ObjectBehaviour>();
				onShowQueryItems.AddRange(queryItems);
#endif
				return true;
			}
			return false;
		}

		/// <summary>
		/// ObjectBehaviour 객체를 제거하는 메서드입니다.
		/// </summary>
		/// <param name="item">제거할 ObjectBehaviour 객체</param>
		internal bool RemoveObject(ObjectBehaviour item)
		{
			if(!IsSatisfiesQuery(item) && queryItems.Remove(item))
			{
				changeItemList?.Invoke(item, false);

				foreach(var looper in odccLoopers)
				{
					looper.Value.Remove(item);
				}

				foreach(var looper in odccActions)
				{
					looper.Value.Remove(item);
				}
#if UNITY_EDITOR
				onShowQueryItems = new List<ObjectBehaviour>();
				onShowQueryItems.AddRange(queryItems);
#endif
				return true;
			}
			return false;
		}
		/// <summary>
		/// 수집기의 타겟이 유효할수 있는지 검사하는 메서드입니다.
		/// </summary>
		/// <param name="item">제거할 ObjectBehaviour 객체</param>
		internal void RemoveQuerySystemTarget(ObjectBehaviour item)
		{
			if(querySystem.TargetObject == item)
			{
				querySystem.TargetObject = null;
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
		[Button]
		private void TestIsSatisfiesQuery(ObjectBehaviour item)
		{
			if(item == null) return;
			Debug.Log(IsSatisfiesQuery(item));
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
			if(item.ThisBehaviour.IsDestroy) return false;
			if(querySystem == null) return false;
			return querySystem.IsSatisfiesQuery(item);
		}

		/// <summary>
		/// 쿼리에 있는 ObjectBehaviour 객체를 업데이트하는 메서드입니다.
		/// </summary>
		/// <param name="item">업데이트할 ObjectBehaviour 객체</param>
		internal void UpdateObjectInQuery(ObjectBehaviour item)
		{
			bool hasObject = HasObject(item);

			if(!hasObject && AddObject(item))
			{
				// Added
			}
			else if(hasObject && RemoveObject(item))
			{
				// Removed
			}
			// Not Work
		}

		/// <summary>
		/// 쿼리된 ObjectBehaviour 항목들을 반환하는 메서드입니다.
		/// </summary>
		/// <returns>쿼리된 ObjectBehaviour 항목들</returns>
		public List<ObjectBehaviour> GetQueryItemList(bool newList = false)
		{
			return newList ? new List<ObjectBehaviour>(queryItems) : queryItems;
		}
		public int GetQueryItemCount()
		{
			return queryItems.Count;
		}
		/// <summary>
		/// OdccQuerySystem 객체를 반환하는 메서드입니다.
		/// </summary>
		/// <returns>OdccQuerySystem 객체</returns>
		public OdccQuerySystem GetQuerySystem()
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

		public object CreateLooperEvent(object moveTowardsUpdate)
		{
			throw new NotImplementedException();
		}
	}
}
