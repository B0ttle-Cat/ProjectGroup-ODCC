using System;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

using Debug = BC.Base.Debug;

namespace BC.ODCC
{
	/// <summary>
	/// OdccQueryLooper 클래스는 OdccQueryCollector에서 수집된 항목들을 기반으로 루프 작업을 관리합니다.
	/// 이 클래스는 Foreach 구조를 사용하여 항목들을 처리하며, 루프 작업을 비동기적으로 실행할 수 있습니다.
	/// </summary>
	public sealed partial class OdccQueryLooper : IDisposable
	{
		// 관련된 OdccQueryCollector 객체입니다.
		internal OdccQueryCollector queryCollector;

		// 루퍼의 키입니다.
		internal string looperKey;

		/// Foreach 로 만든 액션의 개수만큼 들어있습니다.
		internal List<RunForeachStruct> runForeachStructList;

		/// <summary>
		/// RunForeachStruct 구조체는 Foreach 델리게이트 및 관련 작업을 관리합니다.
		/// </summary>
		public struct RunForeachStruct
		{
			// Foreach 에서 지정된 델리게이트입니다.
			public Delegate targetDelegate;

			// Foreach 에서 Enumerator 를 사용하는지 여부입니다.
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
		/// RunForeachAction 추상 클래스는 Foreach 구조에서 실행될 액션을 정의합니다.
		/// </summary>
		public abstract class RunForeachAction
		{
			// 관련된 ObjectBehaviour 키입니다.
			internal ObjectBehaviour key;
#if !USING_AWAITABLE_LOOP
			internal abstract void Run();
			internal abstract System.Collections.IEnumerator IRun();
#else
            internal abstract UnityEngine.Awaitable ARun(LoopInfo loopingInfo);
#endif
		}

		/// <summary>
		/// AddedForeachAction 클래스는 추가된 Foreach 액션을 정의합니다.
		/// </summary>
		public class AddedForeachAction : RunForeachAction
		{
#if !USING_AWAITABLE_LOOP
			internal Action action;
			internal override void Run() => action();
			internal Func<System.Collections.IEnumerator> iAction;
			internal override System.Collections.IEnumerator IRun() => iAction();
#else
            internal Func<UnityEngine.Awaitable> aAction;
            internal override UnityEngine.Awaitable ARun(LoopInfo loopingInfo) => aAction();
#endif
		}

		// 루퍼 중단 함수입니다.
		internal Func<bool> onLooperBreakFunction;

		// 이전 업데이트 여부입니다.
		internal bool prevUpdate;

#if !USING_AWAITABLE_LOOP
		// 루퍼 사용 여부입니다.
		internal bool isUsingLooper;
#endif

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
		}

		/// <summary>
		/// 루퍼 이벤트를 생성하는 메서드입니다.
		/// </summary>
		/// <param name="queryCollector">관련된 OdccQueryCollector 객체</param>
		/// <param name="key">루퍼 키</param>
		/// <param name="prevUpdate">이전 업데이트 여부</param>
		/// <returns>OdccQueryLooper 객체</returns>
		internal static OdccQueryLooper CreateLooperEvent(OdccQueryCollector queryCollector, string key, bool prevUpdate)
		{
			OdccQueryLooper looper = new OdccQueryLooper
			{
				looperKey = key,
				queryCollector = queryCollector,
				prevUpdate = prevUpdate,
				runForeachStructList = new List<RunForeachStruct>(),
#if !USING_AWAITABLE_LOOP
                isUsingLooper = true,
#endif
                onShowCallLog = false,
				onShowCallLogDepth = 5
			};
			looper.IsBreakFunction(null);
			if(prevUpdate)
			{
				OdccForeach.ForeachQueryPrevUpdate.Add(looper, looper.RunLooper());
			}
			else
			{
				OdccForeach.ForeachQueryNextUpdate.Add(looper, looper.RunLooper());
			}
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
				prevUpdate = false,
				runForeachStructList = new List<RunForeachStruct>(),
#if !USING_AWAITABLE_LOOP
                isUsingLooper = false,
#endif
                onShowCallLog = false,
				onShowCallLogDepth = 5
			};
			looper.IsBreakFunction(null);
			return looper;
		}

#if USING_AWAITABLE_LOOP
/// <summary>
/// 루퍼를 실행하는 비동기 메서드입니다.
/// </summary>
/// <returns>UnityEngine.Awaitable 객체</returns>
internal async UnityEngine.Awaitable RunLooper()
{
    // 쿼리 콜렉터가 null인 경우 중단합니다.
    if (queryCollector is null) return;

    // 중단 함수가 true를 반환하면 중단합니다.
    if (onLooperBreakFunction != null && onLooperBreakFunction.Invoke())
    {
        return;
    }

    // 루프 작업에 대한 정보를 초기화합니다.
    LoopInfo loopingInfo = new LoopInfo()
    {
        isLooperBreak = () => onLooperBreakFunction != null && onLooperBreakFunction.Invoke(), // 중단 여부를 확인하는 함수입니다.
        loopStartTime = Time.timeAsDouble, // 루프 시작 시간을 현재 시간으로 설정합니다.

        actionStartTime = 0, // 액션 시작 시간을 0으로 초기화합니다.
        actionIndex = 0, // 액션 인덱스를 0으로 초기화합니다.
        actionTotalCount = 0, // 총 액션 개수를 0으로 초기화합니다.

        itemStartTime = 0, // 항목 시작 시간을 0으로 초기화합니다.
        itemIndex = 0, // 항목 인덱스를 0으로 초기화합니다.
        itemTotalCount = 0, // 총 항목 개수를 0으로 초기화합니다.
    };

    // 루퍼에 등록된 Foreach 구조체의 총 개수를 설정합니다.
    int actionTotalCount = runForeachStructList.Count;
    loopingInfo.actionTotalCount = actionTotalCount;

    // 각 Foreach 구조체에 대해 루프를 실행합니다.
    for (loopingInfo.actionIndex = 0; loopingInfo.actionIndex < actionTotalCount; loopingInfo.actionIndex++)
    {
        // 중단 함수가 true를 반환하면 루프를 중단합니다.
        if (loopingInfo.isLooperBreak()) return;

        // 각 Foreach 구조체의 실행 시작 시간을 설정합니다.
        loopingInfo.actionStartTime = Time.timeAsDouble;
        RunForeachStruct action = runForeachStructList[loopingInfo.actionIndex]; // 현재 실행할 Foreach 구조체입니다.
        RunForeachAction[] itemList = action.runForeachActionList; // 현재 Foreach 구조체의 액션 리스트입니다.
        int itemTotalCount = itemList.Length; // 액션 리스트의 총 개수를 설정합니다.

        // 각 Foreach 액션에 대해 루프를 실행합니다.
        loopingInfo.itemTotalCount = itemTotalCount;
        for (loopingInfo.itemIndex = 0; loopingInfo.itemIndex < itemTotalCount; loopingInfo.itemIndex++)
        {
            // 중단 함수가 true를 반환하면 루프를 중단합니다.
            if (loopingInfo.isLooperBreak()) return;

            // 각 액션의 실행 시작 시간을 설정합니다.
            loopingInfo.itemStartTime = Time.timeAsDouble;
            RunForeachAction item = itemList[loopingInfo.itemIndex]; // 현재 실행할 Foreach 액션입니다.

            // 로그를 표시하는 경우 시작 로그를 출력합니다.
            if (onShowCallLog)
            {
                Debug.Log($"Start: RunLooper {looperKey} : {loopingInfo.actionIndex + 1}/{actionTotalCount} : {loopingInfo.itemIndex + 1}/{itemTotalCount}", onShowCallLogDepth);
            }

            // 각 액션을 비동기적으로 실행합니다.
            try
            {
                await item.ARun(loopingInfo);
            }
            catch (Exception ex)
            {
                Debug.LogException(ex);
            }

            // 로그를 표시하는 경우 종료 로그를 출력합니다.
            if (onShowCallLog)
            {
                Debug.Log($"Ended: RunLooper {looperKey}");
            }
        }
    }
}

        /// <summary>
        /// 액션을 실행하는 비동기 메서드입니다.
        /// </summary>
        /// <param name="completed">완료 후 호출될 액션</param>
        public async void RunAction(Action completed = null)
        {
            // 로그를 표시하는 경우 시작 로그를 출력합니다.
            if (onShowCallLog)
            {
                Debug.Log($"Start: RunCallEvent : {looperKey}", onShowCallLogDepth);
            }

            // 루퍼를 실행합니다.
            await RunLooper();

            // 로그를 표시하는 경우 종료 로그를 출력합니다.
            if (onShowCallLog)
            {
                Debug.Log($"Ended: RunCallEvent : {looperKey}");
            }

            // 완료 후 호출될 액션을 실행합니다.
            try
            {
                completed?.Invoke();
            }
            catch (Exception ex)
            {
                Debug.LogException(ex);
            }
        }
#else
		/// <summary>
		/// 루퍼를 실행하는 IEnumerator 메서드입니다.
		/// </summary>
		/// <returns>IEnumerator 객체</returns>
		internal System.Collections.IEnumerator RunLooper()
		{
			// 루퍼를 사용하지 않거나 쿼리 콜렉터가 null인 경우 중단합니다.
			if(!isUsingLooper || queryCollector is null) yield break;

			// 중단 함수가 true를 반환하면 중단합니다.
			if(onLooperBreakFunction != null && onLooperBreakFunction.Invoke())
			{
				yield break;
			}

			// 루프 작업에 대한 정보를 초기화합니다.
			LoopInfo loopingInfo = new LoopInfo()
			{
				isLooperBreak = () => onLooperBreakFunction != null && onLooperBreakFunction.Invoke(),
				loopStartTime = Time.timeAsDouble,

				actionStartTime = 0,
				actionIndex = 0,
				actionTotalCount = 0,

				itemStartTime = 0,
				itemIndex = 0,
				itemTotalCount = 0,
			};

			// 내부 루퍼를 실행하는 IEnumerator를 생성합니다.
			var enumerator = IRunLooper();
			while(true)
			{
				try
				{
					// 중단 함수가 true를 반환하면 중단합니다.
					if(onLooperBreakFunction != null && onLooperBreakFunction.Invoke())
					{
						yield break;
					}

					// 다음 요소로 이동합니다.
					bool next = enumerator.MoveNext();
					if(!next) break;
				}
				catch(Exception ex)
				{
					Debug.LogException(ex);
					break;
				}

				// 다음 프레임을 대기합니다.
				yield return null;
			}
		}

		/// <summary>
		/// 루퍼를 실행하는 내부 IEnumerator 메서드입니다.
		/// </summary>
		/// <returns>IEnumerator 객체</returns>
		private System.Collections.IEnumerator IRunLooper()
		{
			// 루퍼에 등록된 Foreach 구조체에 대해 루프를 실행합니다.
			foreach(var item in runForeachStructList)
			{
				// 현재 Foreach 구조체의 액션 리스트입니다.
				IEnumerable<RunForeachAction> actionList = item.runForeachActionList;
				if(actionList == null) break;

				// 각 Foreach 구조체의 업데이트 프레임을 설정합니다.
				int updateFrame = item.updateFrame?.Invoke() ?? 1;
				if(updateFrame < 1)
				{
					// 업데이트 프레임이 1보다 작은 경우, 프레임 단위로 대기합니다.
					while(updateFrame >= 1)
					{
						yield return null;
						// 중단 함수가 true를 반환하면 루프를 중단합니다.
						if(onLooperBreakFunction != null && onLooperBreakFunction.Invoke())
						{
							yield break;
						}
						updateFrame = item.updateFrame?.Invoke() ?? 1;
					}
				}

				// 각 액션 리스트를 나누어 처리합니다.
				int totalCount = actionList.Count();

				int quotient = totalCount / updateFrame; // 각 프레임에 처리할 액션 수입니다.
				int remainder = totalCount % updateFrame; // 나머지 액션 수입니다.
				int count = 0;
				// 액션 리스트를 나누어 처리하기 위한 리스트입니다.
				var ListInList = Enumerable.Range(0, updateFrame)
			.Select(i =>
			{
				int skip = count;
				int take = remainder > i ? quotient + 1 : quotient;
				count += take;
				return actionList.Skip(skip).Take(take).Where(act => act.key == null || act.key.isActiveAndEnabled);
			}).ToArray();
				bool isSplt = ListInList.Count() > 1;

				// 각 나누어진 액션 리스트에 대해 루프를 실행합니다.
				foreach(var inList in ListInList)
				{
					foreach(var action in inList)
					{
						// Foreach 구조체가 Enumerator를 사용하는 경우
						if(item.isEnumerator)
						{
							System.Collections.IEnumerator enumerator = action.IRun();
							while(true)
							{
								try
								{
									// 중단 함수가 true를 반환하면 루프를 중단합니다.
									if(onLooperBreakFunction != null && onLooperBreakFunction.Invoke())
									{
										yield break;
									}
									// 다음 요소로 이동합니다.
									bool next = enumerator.MoveNext();
									if(!next) break;
								}
								catch(Exception ex)
								{
									Debug.LogException(ex);
									break;
								}
								yield return null;
							}
						}
						// Foreach 구조체가 Enumerator를 사용하지 않는 경우
						else
						{
							try
							{
								// 중단 함수가 true를 반환하면 루프를 중단합니다.
								if(onLooperBreakFunction != null && onLooperBreakFunction.Invoke())
								{
									yield break;
								}
								// 액션을 실행합니다.
								action.Run();
							}
							catch(Exception ex)
							{
								Debug.LogException(ex);
							}
						}
					}
					if(isSplt)
					{
						yield return null;
						// 중단 함수가 true를 반환하면 루프를 중단합니다.
						if(onLooperBreakFunction != null && onLooperBreakFunction.Invoke())
						{
							yield break;
						}
					}
				}
			}
		}

		/// <summary>
		/// 액션을 실행하는 메서드입니다.
		/// </summary>
		public void RunAction()
		{
			// 루퍼를 사용하지 않거나 쿼리 콜렉터가 null인 경우 중단합니다.
			if(isUsingLooper || queryCollector is null) return;

			// 중단 함수가 true를 반환하면 중단합니다.
			if(onLooperBreakFunction != null && onLooperBreakFunction.Invoke())
			{
				return;
			}

			// 내부 루퍼를 실행합니다.
			var action = IRunLooper();
			bool moveNext = true;
			while(moveNext)
			{
				try
				{
					// 중단 함수가 true를 반환하면 중단합니다.
					if(onLooperBreakFunction != null && onLooperBreakFunction.Invoke())
					{
						return;
					}

					// 다음 요소로 이동합니다.
					moveNext = action.MoveNext();
				}
				catch(Exception ex)
				{
					Debug.LogException(ex);
					break;
				}
			}
		}
#endif

		/// <summary>
		/// Foreach 매개변수 규칙 상 존재하는 함수이며, 아무런 동작 하지 않음.
		/// </summary>
		/// <returns>OdccQueryLooper 객체</returns>
		public OdccQueryLooper Foreach()
		{
			return this;
		}

		//==============================================
#if USING_AWAITABLE_LOOP
        /// <summary>
        /// 다음 액션을 호출하는 메서드입니다.
        /// </summary>
        /// <param name="action">호출할 액션</param>
        /// <returns>OdccQueryLooper 객체</returns>
        public OdccQueryLooper CallNext(Action action)
        {
            return CallNext(async () => Call());
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
        public OdccQueryLooper CallNext(Func<UnityEngine.Awaitable> action)
        {
            var list = new List<RunForeachAction>();
            list.Add(new AddedForeachAction()
            {
                aAction = action
            });
            runForeachStructList.Add(new RunForeachStruct(action, list, true, null));
            return this;
        }
#else
		/// <summary>
		/// 다음 액션을 호출하는 메서드입니다.
		/// </summary>
		/// <param name="action">호출할 액션</param>
		/// <returns>OdccQueryLooper 객체</returns>
		public OdccQueryLooper CallNext(Action action)
		{
			var list = new List<RunForeachAction>();
			list.Add(new AddedForeachAction() {
				action = action
			});
			runForeachStructList.Add(new RunForeachStruct(action, list, false, null));
			return this;
		}

		/// <summary>
		/// 다음 액션을 호출하는 메서드입니다.
		/// </summary>
		/// <param name="action">호출할 IEnumerator 액션</param>
		/// <returns>OdccQueryLooper 객체</returns>
		public OdccQueryLooper CallNext(Func<System.Collections.IEnumerator> action)
		{
			var list = new List<RunForeachAction>();
			list.Add(new AddedForeachAction() {
				iAction = action
			});
			runForeachStructList.Add(new RunForeachStruct(action, list, true, null));
			return this;
		}
#endif

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
		/// Foreach 항목을 설정하는 제네릭 메서드입니다.
		/// </summary>
		/// <typeparam name="T">항목의 타입</typeparam>
		/// <param name="item">설정할 ObjectBehaviour 항목</param>
		/// <returns>설정된 항목</returns>
		internal T SetForeachItem<T>(ObjectBehaviour item) where T : class, IOdccItem
		{
			if(typeof(T).IsSubclassOf(typeof(ComponentBehaviour)))
			{
				if(item.ThisContainer._TryGetComponent<T>(out T t))
				{
					return t;
				}
			}
			else if(typeof(T).IsSubclassOf(typeof(DataObject)))
			{
				if(item.ThisContainer._TryGetData<T>(out T t))
				{
					return t;
				}
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
			else if(item.TryGetComponent<T>(out T tObject) && tObject is ObjectBehaviour)
			{
				return tObject;
			}
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
		public OdccQueryLooper IsBreakFunction(Func<bool> breakEvent)
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
			OdccForeach.ForeachQueryPrevUpdate.Remove(this);
			OdccForeach.ForeachQueryNextUpdate.Remove(this);
		}

		/////////////////////////// Obsolete //////////////////////////

		[Obsolete("CallNext 사용 할 것 - 오래된 이름 규칙", true)]
		public OdccQueryLooper Action(Action action)
		{
			return CallNext(action);
		}

#if USING_AWAITABLE_LOOP
        [Obsolete("CallNext 사용 할 것 - 오래된 이름 규칙", true)]
        public OdccQueryLooper Action(Func<UnityEngine.Awaitable> action)
        {
            return CallNext(action);
        }

        [Obsolete("RunAction 사용 할 것 - 오래된 이름 규칙", true)]
        public void RunCallEvent(Action completed = null)
        {
            RunAction(completed);
        }
#else
		[Obsolete("CallNext 사용 할 것 - 오래된 이름 규칙", true)]
		public OdccQueryLooper Action(Func<System.Collections.IEnumerator> action)
		{
			return CallNext(action);
		}

		[Obsolete("RunAction 사용 할 것 - 오래된 이름 규칙", true)]
		public void RunCallEvent()
		{
			RunAction();
		}
#endif
	}
}
