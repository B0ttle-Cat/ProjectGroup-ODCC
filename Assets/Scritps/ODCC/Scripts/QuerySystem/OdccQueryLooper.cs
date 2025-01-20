using System;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

using Debug = BC.Base.Debug;

namespace BC.ODCC
{
	/// <summary>
	/// OdccQueryLooper 클래스는 OdccQueryCollector에서 수집된 항목들을 기반으로 루프 작업을 관리합니다.
	/// 이 클래스는 CallForeach 구조를 사용하여 항목들을 처리하며, 루프 작업을 비동기적으로 실행할 수 있습니다.
	/// </summary>
	public sealed partial class OdccQueryLooper : IDisposable
	{
		// 관련된 OdccQueryCollector 객체입니다.
		internal OdccQueryCollector queryCollector;

		// 루퍼의 키입니다.
		internal string looperKey;

		/// CallForeach 로 만든 액션의 개수만큼 들어있습니다.
		internal List<RunForeachStruct> runForeachStructList;

		/// <summary>
		/// RunForeachStruct 구조체는 CallForeach 델리게이트 및 관련 작업을 관리합니다.
		/// </summary>
		public struct RunForeachStruct
		{
			// CallForeach 에서 지정된 델리게이트입니다.
			public Delegate targetDelegate;

			// CallForeach 에서 Enumerator 를 사용하는지 여부입니다.
			public bool isEnumerator;

			// queryCollector 를 만족하는 오브젝트 들 만큼 있는 RunForeachAction 배열입니다.
			public RunForeachAction[] runForeachActionList;

			// queryCollector 를 만족하는 오브젝트가 새로 추가 되면 Foreach에 맞는 Delegate 로 변경하는 함수입니다.
			public Func<ObjectBehaviour, RunForeachAction> createAction;

			// 업데이트 프레임을 반환하는 함수입니다.
			public Func<int> updateFrame;

			/// <summary>
			/// RunForeachStruct의 생성자입니다.
			/// </summary>
			/// <param name="targetDelegate">타겟 델리게이트</param>
			/// <param name="runLoopActionList">루프 액션 리스트</param>
			/// <param name="isEnumerator">Enumerator 사용 여부</param>
			/// <param name="createAction">액션 생성 함수</param>
			public RunForeachStruct(Delegate targetDelegate, List<RunForeachAction> runLoopActionList, bool isEnumerator, Func<ObjectBehaviour, RunForeachAction> createAction)
			{
				this.targetDelegate = targetDelegate;
				this.runForeachActionList = runLoopActionList.ToArray();
				this.isEnumerator = isEnumerator;
				this.createAction = createAction;
				updateFrame = null;
			}

			/// <summary>
			/// ObjectBehaviour 항목을 추가하는 메서드입니다.
			/// </summary>
			/// <param name="item">추가할 ObjectBehaviour 항목</param>
			public void Add(ObjectBehaviour item)
			{
				if(createAction == null) return;
				var list = runForeachActionList.ToList();
				list.Add(createAction(item));
				runForeachActionList = list.ToArray();
			}

			/// <summary>
			/// ObjectBehaviour 항목을 제거하는 메서드입니다.
			/// </summary>
			/// <param name="item">제거할 ObjectBehaviour 항목</param>
			public void Remove(ObjectBehaviour item)
			{
				var list = runForeachActionList.ToList();
				if(list != null && createAction != null && list.Remove(createAction(item)))
				{
					runForeachActionList = list.ToArray();
				}
			}
		}

		/// <summary>
		/// RunForeachAction 추상 클래스는 CallForeach 구조에서 실행될 액션을 정의합니다.
		/// </summary>
		public abstract class RunForeachAction
		{
			// 관련된 ObjectBehaviour 키입니다.
			internal ObjectBehaviour key;
			internal bool callFirstOnly = false;
			internal bool isCallFirst = false;
			internal abstract UnityEngine.Awaitable Run(LoopInfo loopingInfo);
		}

		/// <summary>
		/// AddedForeachAction 클래스는 추가된 CallForeach 액션을 정의합니다.
		/// </summary>
		public class AddedForeachAction : RunForeachAction
		{
			internal Func<UnityEngine.Awaitable> aAction;
			internal override UnityEngine.Awaitable Run(LoopInfo loopingInfo) => aAction();
		}
		public class JoinForeachAction : RunForeachAction
		{
			internal Func<UnityEngine.Awaitable> aAction;
			internal override UnityEngine.Awaitable Run(LoopInfo loopingInfo) => aAction();
		}

		// 루퍼 중단 함수입니다.
		internal Func<bool> onLooperBreakFunction;

		// 이전 업데이트 여부입니다.
		internal int loopOrder;

		// 호출 로그 표시 여부입니다.
		internal bool onShowCallLog;

		// 호출 로그 표시 깊이입니다.
		internal int onShowCallLogDepth;

		/// <summary>
		/// LoopInfo 구조체는 루프 작업에 대한 정보를 저장합니다.
		/// </summary>
		public struct LoopInfo
		{
			public Func<bool> isLooperBreak;
			public double loopStartTime;

			public double actionStartTime;
			public int actionIndex;
			public int actionTotalCount;

			public double itemStartTime;
			public int itemIndex;
			public int itemTotalCount;

			public double TempTimeCount { get; set; }
			public bool HasDeltaTimeElapsed(double deltaTime)
			{
				var _deltaTime = Time.timeAsDouble - TempTimeCount;
				if(_deltaTime < 0)
				{
					TempTimeCount = Time.timeAsDouble;
					_deltaTime = 0;
				}

				if(_deltaTime > deltaTime)
				{
					TempTimeCount = Time.timeAsDouble;
					return true;
				}
				return false;
			}
		}

		/// <summary>
		/// 루퍼 이벤트를 생성하는 메서드입니다.
		/// </summary>
		/// <param name="queryCollector">관련된 OdccQueryCollector 객체</param>
		/// <param name="key">루퍼 키</param>
		/// <param name="loopOrder">업데이트 순서. 0 ~ 1 사이에 메인업데이트가 이루어짐</param>
		/// <returns>OdccQueryLooper 객체</returns>
		internal static OdccQueryLooper CreateLooperEvent(OdccQueryCollector queryCollector, string key, int loopOrder = 0)
		{
			OdccQueryLooper looper = new OdccQueryLooper
			{
				looperKey = key,
				queryCollector = queryCollector,
				loopOrder = loopOrder,
				runForeachStructList = new List<RunForeachStruct>(),
				onShowCallLog = false,
				onShowCallLogDepth = 5
			};
			looper.SetBreakFunction(null);
			if(!OdccForeach.ForeachQueryUpdate.TryGetValue(loopOrder, out var loopDictionary))
			{
				loopDictionary = new Dictionary<OdccQueryLooper, Awaitable>();
				OdccForeach.ForeachQueryUpdate.Add(loopOrder, loopDictionary);
			}
			loopDictionary.Add(looper, looper.RunAwaitable());
			return looper;
		}

		/// <summary>
		/// 액션 이벤트를 생성하는 메서드입니다.
		/// </summary>
		/// <param name="queryCollector">관련된 OdccQueryCollector 객체</param>
		/// <param name="key">액션 키</param>
		/// <returns>OdccQueryLooper 객체</returns>
		internal static OdccQueryLooper CreateActionEvent(OdccQueryCollector queryCollector, string key)
		{
			OdccQueryLooper looper = new OdccQueryLooper
			{
				looperKey = key,
				queryCollector = queryCollector,
				loopOrder = 0,
				runForeachStructList = new List<RunForeachStruct>(),
				onShowCallLog = false,
				onShowCallLogDepth = 5
			};
			looper.SetBreakFunction(null);
			return looper;
		}

		/// <summary>
		/// 루퍼를 실행하는 비동기 메서드입니다.
		/// </summary>
		/// <returns>UnityEngine.Awaitable 객체</returns>
		public async Awaitable RunAwaitable()
		{
			// 쿼리 콜렉터가 null인 경우 중단합니다.
			if(queryCollector is null) return;

			// 중단 함수가 true를 반환하면 중단합니다.
			if(onLooperBreakFunction != null && onLooperBreakFunction.Invoke())
			{
				return;
			}

			// 루프 작업에 대한 정보를 초기화합니다.
			LoopInfo loopingInfo = new LoopInfo()
			{
				isLooperBreak = () => queryCollector is null && onLooperBreakFunction != null && onLooperBreakFunction.Invoke(), // 중단 여부를 확인하는 함수입니다.
				loopStartTime = Time.timeAsDouble, // 루프 시작 시간을 현재 시간으로 설정합니다.

				actionStartTime = 0, // 액션 시작 시간을 0으로 초기화합니다.
				actionIndex = 0, // 액션 인덱스를 0으로 초기화합니다.
				actionTotalCount = 0, // 총 액션 개수를 0으로 초기화합니다.

				itemStartTime = 0, // 항목 시작 시간을 0으로 초기화합니다.
				itemIndex = 0, // 항목 인덱스를 0으로 초기화합니다.
				itemTotalCount = 0, // 총 항목 개수를 0으로 초기화합니다.
			};

			// 루퍼에 등록된 CallForeach 구조체의 총 개수를 설정합니다.
			int actionTotalCount = runForeachStructList.Count;
			loopingInfo.actionTotalCount = actionTotalCount;

			// 각 CallForeach 구조체에 대해 루프를 실행합니다.
			for(loopingInfo.actionIndex = 0 ; loopingInfo.actionIndex < actionTotalCount ; loopingInfo.actionIndex++)
			{
				// 중단 함수가 true를 반환하면 루프를 중단합니다.
				if(loopingInfo.isLooperBreak()) return;

				// 각 CallForeach 구조체의 실행 시작 시간을 설정합니다.
				loopingInfo.actionStartTime = Time.timeAsDouble;
				RunForeachStruct action = runForeachStructList[loopingInfo.actionIndex]; // 현재 실행할 CallForeach 구조체입니다.
				RunForeachAction[] itemList = action.runForeachActionList; // 현재 CallForeach 구조체의 액션 리스트입니다.
				int itemTotalCount = itemList.Length; // 액션 리스트의 총 개수를 설정합니다.

				// 각 CallForeach 액션에 대해 루프를 실행합니다.
				loopingInfo.itemTotalCount = itemTotalCount;
				for(loopingInfo.itemIndex = 0 ; loopingInfo.itemIndex < itemTotalCount ; loopingInfo.itemIndex++)
				{
					// 중단 함수가 true를 반환하면 루프를 중단합니다.
					if(loopingInfo.isLooperBreak()) return;

					// 각 액션의 실행 시작 시간을 설정합니다.
					loopingInfo.itemStartTime = Time.timeAsDouble;
					RunForeachAction item = itemList[loopingInfo.itemIndex]; // 현재 실행할 CallForeach 액션입니다.
					if(item.callFirstOnly && item.isCallFirst)
					{
						continue;
					}
					item.isCallFirst = true;

					// 로그를 표시하는 경우 시작 로그를 출력합니다.
					if(onShowCallLog)
					{
						Debug.Log($"Start: RunLooper {looperKey} : {loopingInfo.actionIndex + 1}/{actionTotalCount} : {loopingInfo.itemIndex + 1}/{itemTotalCount}", onShowCallLogDepth);
					}

					// 각 액션을 비동기적으로 실행합니다.
					try
					{
						await item.Run(loopingInfo);
					}
					catch(Exception ex)
					{
						Debug.LogException(ex);
					}

					// 로그를 표시하는 경우 종료 로그를 출력합니다.
					if(onShowCallLog)
					{
						Debug.Log($"Ended: RunLooper {looperKey}");
					}
				}
			}
		}

		/// <summary>
		/// <code>액션을 수동으로 실행하는 비동기 메서드입니다.
		/// 이 함수는 <see cref="CreateActionEvent"/>로 생성된 <see cref="OdccQueryLooper"/>를 실행시킬때 사용하세요.
		/// </code>
		/// </summary>
		/// <param name="completed">완료 후 호출될 액션</param>
		public async void RunAction(Action completed = null)
		{
			await RunAwaitable();

			try
			{
				completed?.Invoke();
			}
			catch(Exception ex)
			{
				Debug.LogException(ex);
			}
		}

		/// <summary>
		/// CallForeach 매개변수 규칙 상 존재하는 함수이며, 아무런 동작 하지 않음.
		/// CallForeach<T...> 를 사용할 것.
		/// </summary>
		/// <returns>OdccQueryLooper 객체</returns>
		public OdccQueryLooper Foreach()
		{
			return this;
		}

		//==============================================
		/// <summary>
		/// 다음 액션을 호출하는 메서드입니다.
		/// </summary>
		/// <param name="action">호출할 액션</param>
		/// <param name="callFirstOnly"> 루프 안에서 한번만 호출될지 결정</param>
		/// <returns>OdccQueryLooper 객체</returns>
		public OdccQueryLooper CallAction(Action action)
		{
			return CallAction(async () => Call());
			void Call()
			{
				action?.Invoke();
			}
		}
		/// <summary>
		/// 다음 액션을 호출하는 비동기 메서드입니다.
		/// </summary>
		/// <param name="action">호출할 비동기 액션</param>
		/// <returns>OdccQueryLooper 객체</returns>
		public OdccQueryLooper CallAction(Func<UnityEngine.Awaitable> action)
		{
			var list = new List<RunForeachAction>();
			list.Add(new AddedForeachAction() {
				aAction = action,
				callFirstOnly = false,
				isCallFirst = false,
			});
			runForeachStructList.Add(new RunForeachStruct(action, list, true, null));
			return this;
		}
		/// <summary>
		/// 다음 액션을 호출하는 메서드입니다.
		/// </summary>
		/// <param name="action">호출할 액션</param>
		/// <returns>OdccQueryLooper 객체</returns>
		public OdccQueryLooper CallInit(Action action)
		{
			return CallInit(async () => Call());
			void Call()
			{
				action?.Invoke();
			}
		}
		/// <summary>
		/// 다음 액션을 호출하는 비동기 메서드입니다.
		/// </summary>
		/// <param name="action">호출할 비동기 액션</param>
		/// <returns>OdccQueryLooper 객체</returns>
		public OdccQueryLooper CallInit(Func<UnityEngine.Awaitable> action)
		{
			var list = new List<RunForeachAction>();
			list.Add(new AddedForeachAction() {
				aAction = action,
				callFirstOnly = true,
				isCallFirst = false,
			});
			runForeachStructList.Add(new RunForeachStruct(action, list, true, null));
			return this;
		}
		/// <summary>
		/// 다른 Looper 를 실행 할 수 있는 메서드입니다.
		/// </summary>
		/// <param name="join">호출할 Looper</param>
		/// <returns>OdccQueryLooper 객체</returns>
		public OdccQueryLooper CallLooper(OdccQueryLooper join)
		{
			if(join == null) return this;
			Func<Awaitable> action = async () =>
			{
				if(join.queryCollector != null)
				{
					await join.RunAwaitable();
				}
			};

			var list = new List<RunForeachAction>();
			list.Add(new JoinForeachAction() {
				aAction = action,
				callFirstOnly = false,
				isCallFirst = false,
			});
			runForeachStructList.Add(new RunForeachStruct(action, list, true, null));
			return this;
		}
		/// <summary>
		/// 프레임 수를 설정하는 메서드입니다.
		/// </summary>
		/// <param name="func">프레임 수를 반환하는 함수</param>
		/// <returns>OdccQueryLooper 객체</returns>
		public OdccQueryLooper SetFrameCount(Func<int> func)
		{
			if(runForeachStructList.Count > 0)
			{
				var foreachStruct = runForeachStructList[^1];
				foreachStruct.updateFrame = func;
				runForeachStructList[^1] = foreachStruct;
			}
			return this;
		}

		/// <summary>
		/// 프레임 수를 설정하는 메서드입니다.
		/// </summary>
		/// <param name="count">프레임 수</param>
		/// <returns>OdccQueryLooper 객체</returns>
		public OdccQueryLooper SetFrameCount(int count)
		{
			return SetFrameCount(() => count);
		}

		/// <summary>
		/// 관련된 OdccQueryCollector 객체를 반환하는 메서드입니다.
		/// </summary>
		/// <returns>OdccQueryCollector 객체</returns>
		public OdccQueryCollector GetCollector()
		{
			return queryCollector;
		}

		/// <summary>
		/// CallForeach 항목을 설정하는 제네릭 메서드입니다.
		/// </summary>
		/// <typeparam name="T">항목의 타입</typeparam>
		/// <param name="item">설정할 ObjectBehaviour 항목</param>
		/// <returns>설정된 항목</returns>
		internal T SetForeachItem<T>(ObjectBehaviour item) where T : class, IOdccItem
		{
			if(typeof(T).IsSubclassOf(typeof(ComponentBehaviour)) && item.ThisContainer._TryGetComponent<T>(out T t))
			{
				return t;
			}
			else if(typeof(T).IsSubclassOf(typeof(DataObject)) && item.ThisContainer._TryGetData<T>(out T tt))
			{
				return tt;
			}
			else if(typeof(T).IsSubclassOf(typeof(ObjectBehaviour)))
			{
				return item as T;
			}
			else if(item.ThisContainer._TryGetComponent<T>(out T component))
			{
				return component;
			}
			else if(item.ThisContainer._TryGetData<T>(out T data))
			{
				return data;
			}
			else
			{
				return item.GetComponent<T>();
			}
		}

		internal T SetForeachItems<T>(ObjectBehaviour item) where T : class, ICollection<IOdccAttach>, new()
		{
			Type elementType = typeof(T).GetGenericArguments()[0];
			int elementTypeID = OdccManager.GetTypeToIndex(elementType);
			//
			if(typeof(T).IsSubclassOf(typeof(ComponentBehaviour)) && item.ThisContainer._TryGetComponents<T>(elementTypeID, out var t))
			{
				return t;
			}
			else if(typeof(T).IsSubclassOf(typeof(DataObject)) && item.ThisContainer._TryGetDatas<T>(elementTypeID, out var tt))
			{
				return tt;
			}
			////else if(typeof(T).IsSubclassOf(typeof(ObjectBehaviour)))
			////{
			////	return item as T;
			////}
			////else if(item.ThisContainer._TryGetComponent<T>(out T component))
			////{
			////	return component;
			////}
			////else if(item.ThisContainer._TryGetData<T>(out T data))
			////{
			////	return data;
			////}
			//else
			//{
			//	return item.GetComponents<T>();
			//}
			return null;
		}

		/// <summary>
		/// 호출 로그를 표시하는 메서드입니다.
		/// </summary>
		/// <param name="showLog">로그 표시 여부</param>
		/// <param name="depth">로그 표시 깊이</param>
		/// <returns>OdccQueryLooper 객체</returns>
		public OdccQueryLooper ShowCallLog(bool showLog, int depth = 7)
		{
#if !UNITY_EDITOR
            showLog = false;
#endif
			onShowCallLog = showLog;
			onShowCallLogDepth = depth;
			if(onShowCallLogDepth < 0) onShowCallLogDepth = 0;
			return this;
		}

		/// <summary>
		/// ObjectBehaviour 항목을 추가하는 메서드입니다.
		/// </summary>
		/// <param name="item">추가할 ObjectBehaviour 항목</param>
		internal void Add(ObjectBehaviour item)
		{
			int count = runForeachStructList.Count;
			for(int i = 0 ; i < count ; i++)
			{
				RunForeachStruct structItem = runForeachStructList[i];
				structItem.Add(item);
				runForeachStructList[i] = structItem;
			}
		}

		/// <summary>
		/// ObjectBehaviour 항목을 제거하는 메서드입니다.
		/// </summary>
		/// <param name="item">제거할 ObjectBehaviour 항목</param>
		internal void Remove(ObjectBehaviour item)
		{
			int count = runForeachStructList.Count;
			for(int i = 0 ; i < count ; i++)
			{
				RunForeachStruct structItem = runForeachStructList[i];
				structItem.Remove(item);
				runForeachStructList[i] = structItem;
			}
		}

		/// <summary>
		/// 중단 함수 설정 메서드입니다.
		/// </summary>
		/// <param name="breakEvent">중단 함수</param>
		/// <returns>OdccQueryLooper 객체</returns>
		public OdccQueryLooper SetBreakFunction(Func<bool> breakEvent)
		{
			onLooperBreakFunction = breakEvent != null ? Action : Pass;

			return this;

			// 중단 함수가 null일 때 반환할 기본 함수입니다.
			bool Pass() => false;

			// 중단 함수가 실행될 때 호출되는 함수입니다.
			bool Action()
			{
				try
				{
					bool result = breakEvent.Invoke();
					return result;
				}
				catch(Exception ex)
				{
					Debug.LogException(ex);
					return Pass();
				}
			}
		}

		/// <summary>
		/// OdccQueryLooper 객체를 해제하는 메서드입니다.
		/// </summary>
		public void Dispose()
		{
			queryCollector = null;
			runForeachStructList.Clear();
			if(OdccForeach.ForeachQueryUpdate.TryGetValue(loopOrder, out var dic))
			{
				dic.Remove(this);
				if(dic.Count == 0)
				{
					OdccForeach.ForeachQueryUpdate.Remove(loopOrder);
				}
			}
		}
	}
}
