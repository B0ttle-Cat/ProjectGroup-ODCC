using System;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

using Debug = BC.Base.Debug;

namespace BC.ODCC
{
	public sealed partial class OdccQueryLooper : IDisposable
	{
		internal OdccQueryCollector queryCollector;
		internal string looperKey;
		/// Foreach 로 만든 액션의 개수만큼 들어있다.
		internal List<RunForeachStruct> runForeachStructList;
		public struct RunForeachStruct
		{
			// Foreach 에서 지정된 델리게이트
			public Delegate targetDelegate;
			// Foreach 에서 Enumerator 를 사용하는지?
			public bool isEnumerator;
			// queryCollector 를 만족하는 오브젝트 들 만큼 있음;
			public RunForeachAction[] runForeachActionList;
			// queryCollector 를 만족하는 오브젝트가 새로 추가 되면 Foreach에 맞는 Delegate 로 변경함.
			public Func<ObjectBehaviour, RunForeachAction> createAction;

			public Func<int> updateFrame;
			public RunForeachStruct(Delegate targetDelegate, List<RunForeachAction> runLoopActionList, bool isEnumerator, Func<ObjectBehaviour, RunForeachAction> createAction)
			{
				this.targetDelegate = targetDelegate;
				this.runForeachActionList = runLoopActionList.ToArray();
				this.isEnumerator = isEnumerator;
				this.createAction = createAction;
				updateFrame = null;
			}

			public void Add(ObjectBehaviour item)
			{
				if(createAction == null) return;
				var list = runForeachActionList.ToList();
				list.Add(createAction(item));
				runForeachActionList = list.ToArray();
			}
			public void Remove(ObjectBehaviour item)
			{
				var list = runForeachActionList.ToList();
				if(list != null && createAction != null && list.Remove(createAction(item)))
				{
					runForeachActionList = list.ToArray();
				}
			}
		}
		public abstract class RunForeachAction
		{
			internal ObjectBehaviour key;
#if !USING_AWAITABLE_LOOP
			internal abstract void Run();
			internal abstract System.Collections.IEnumerator IRun();
#else
			internal abstract UnityEngine.Awaitable ARun(LoopInfo loopingInfo);
#endif
		}
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

		internal Func<bool> onLooperBreakFunction;

		internal bool prevUpdate;
#if !USING_AWAITABLE_LOOP
		internal bool isUsingLooper;
#endif
		internal bool onShowCallLog;
		internal int onShowCallLogDepth;
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
		internal static OdccQueryLooper CreateLooperEvent(OdccQueryCollector queryCollector, string key, bool prevUpdate)
		{
			OdccQueryLooper Looper = new OdccQueryLooper();
			Looper.looperKey = key;
			Looper.queryCollector = queryCollector;
			Looper.prevUpdate = prevUpdate;
			Looper.runForeachStructList = new List<RunForeachStruct>();
#if !USING_AWAITABLE_LOOP
			Looper.isUsingLooper = true;
#endif
			Looper.onShowCallLog = false;
			Looper.onShowCallLogDepth = 5;
			Looper.IsBreakFunction(null);
			if(prevUpdate)
			{
				OdccForeach.ForeachQueryPrevUpdate.Add(Looper, Looper.RunLooper());
			}
			else
			{
				OdccForeach.ForeachQueryNextUpdate.Add(Looper, Looper.RunLooper());
			}
			return Looper;
		}

		internal static OdccQueryLooper CreateActionEvent(OdccQueryCollector queryCollector, string key)
		{
			OdccQueryLooper Looper = new OdccQueryLooper();
			Looper.looperKey = key;
			Looper.queryCollector = queryCollector;
			Looper.prevUpdate = false;
			Looper.runForeachStructList = new List<RunForeachStruct>();
#if !USING_AWAITABLE_LOOP
			Looper.isUsingLooper = false;
#endif
			Looper.onShowCallLog = false;
			Looper.onShowCallLogDepth = 5;
			Looper.IsBreakFunction(null);
			return Looper;
		}

#if USING_AWAITABLE_LOOP
		internal async UnityEngine.Awaitable RunLooper()
		{
			if(queryCollector is null) return;
			if(onLooperBreakFunction != null && onLooperBreakFunction.Invoke())
			{
				return;
			}

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

			int actionTotalCount = runForeachStructList.Count;
			loopingInfo.actionTotalCount = actionTotalCount;
			for(loopingInfo.actionIndex = 0 ; loopingInfo.actionIndex < actionTotalCount ; loopingInfo.actionIndex++)
			{
				if(loopingInfo.isLooperBreak()) return;

				loopingInfo.actionStartTime = Time.timeAsDouble;
				RunForeachStruct action = runForeachStructList[loopingInfo.actionIndex];
				RunForeachAction[] itemList = action.runForeachActionList;
				int itemTotalCount = itemList.Length;

				loopingInfo.itemTotalCount = itemTotalCount;
				for(loopingInfo.itemIndex = 0 ; loopingInfo.itemIndex < itemTotalCount ; loopingInfo.itemIndex++)
				{
					if(loopingInfo.isLooperBreak()) return;

					loopingInfo.itemStartTime = Time.timeAsDouble;
					RunForeachAction item = itemList[loopingInfo.itemIndex];
					if(onShowCallLog)
					{
						Debug.Log($"Start: RunLooper {looperKey} : {loopingInfo.actionIndex+1}/{actionTotalCount} : {loopingInfo.itemIndex+1}/{itemTotalCount}", onShowCallLogDepth);
					}
					try
					{
						await item.ARun(loopingInfo);
					}
					catch(Exception ex)
					{
						Debug.LogException(ex);
					}
					if(onShowCallLog)
					{
						Debug.Log($"Ended: RunLooper {looperKey}");
					}

				}
			}
		}
		public async void RunAction(Action completed = null)
		{
			if(onShowCallLog)
			{
				Debug.Log($"Start: RunCallEvent : {looperKey}", onShowCallLogDepth);
			}
			await RunLooper();
			if(onShowCallLog)
			{
				Debug.Log($"Ended: RunCallEvent : {looperKey}");
			}
			try
			{
				completed?.Invoke();
			}
			catch(Exception ex)
			{
				Debug.LogException(ex);
			}
		}
#else
		internal System.Collections.IEnumerator RunLooper()
		{
			if(!isUsingLooper || queryCollector is null) yield break;
			if(onLooperBreakFunction != null && onLooperBreakFunction.Invoke())
			{
				yield break;
			}

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

			var enumerator = IRunLooper();
			while(true)
			{
				try
				{
					if(onLooperBreakFunction != null && onLooperBreakFunction.Invoke())
					{
						yield break;
					}
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

		private System.Collections.IEnumerator IRunLooper()
		{
			foreach(var item in runForeachStructList)
			{
				IEnumerable<RunForeachAction> actionList = item.runForeachActionList;
				if(actionList == null) break;

				int updateFrame = item.updateFrame?.Invoke() ?? 1;
				if(updateFrame < 1)
				{
					while(updateFrame >= 1)
					{
						yield return null;
						if(onLooperBreakFunction != null && onLooperBreakFunction.Invoke())
						{
							yield break;
						}
						updateFrame = item.updateFrame?.Invoke() ?? 1;
					}
				}

				int totalCount = actionList.Count();

				int quotient = totalCount / updateFrame;
				int remainder = totalCount % updateFrame;
				int count = 0;
				var ListInList = Enumerable.Range(0, updateFrame)
					.Select(i =>
					{
						int skip = count;
						int take = remainder > i ? quotient + 1 : quotient;
						count += take;
						return actionList.Skip(skip).Take(take).Where(act => act.key == null || act.key.isActiveAndEnabled);
					}).ToArray();
				bool isSplt = ListInList.Count() > 1;
				foreach(var inList in ListInList)
				{
					foreach(var action in inList)
					{

						if(item.isEnumerator)
						{
							System.Collections.IEnumerator enumerator = action.IRun();
							while(true)
							{
								try
								{
									if(onLooperBreakFunction != null && onLooperBreakFunction.Invoke())
									{
										yield break;
									}
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
						else
						{
							try
							{
								if(onLooperBreakFunction != null && onLooperBreakFunction.Invoke())
								{
									yield break;
								}
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
						if(onLooperBreakFunction != null && onLooperBreakFunction.Invoke())
						{
							yield break;
						}
					}
				}
			}
		}
		public void RunAction()
		{
			if(isUsingLooper || queryCollector is null) return;
			if(onLooperBreakFunction != null && onLooperBreakFunction.Invoke())
			{
				return;
			}

			var action = IRunLooper();
			bool moveNext = true;
			while(moveNext)
			{
				try
				{
					if(onLooperBreakFunction != null && onLooperBreakFunction.Invoke())
					{
						return;
					}
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
		public OdccQueryLooper Foreach()
		{
			return this;
		}

		//==============================================
#if USING_AWAITABLE_LOOP
		public OdccQueryLooper CallNext(Action action)
		{
			return CallNext(async () => Call());
			void Call()
			{
				action?.Invoke();
			}
		}
		public OdccQueryLooper CallNext(Func<UnityEngine.Awaitable> action)
		{
			var list = new List<RunForeachAction>();
			list.Add(new AddedForeachAction() {
				aAction = action
			});
			runForeachStructList.Add(new RunForeachStruct(action, list, true, null));
			return this;
		}
#else
		public OdccQueryLooper CallNext(Action action)
		{
			var list = new List<RunForeachAction>();
			list.Add(new AddedForeachAction() {
				action = action
			});
			runForeachStructList.Add(new RunForeachStruct(action, list, false, null));
			return this;
		}
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
		public OdccQueryLooper SetFrameCount(int count)
		{
			return SetFrameCount(() => count);
		}
		public OdccQueryCollector GetCollector()
		{
			return queryCollector;
		}
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
		public OdccQueryLooper ShowCallLog(bool showLog, int depth = 7)
		{
#if !UNITY_EDITOR
			showLog = false;
#endif
			onShowCallLog = showLog;
			onShowCallLogDepth = depth;
			if(onShowCallLogDepth<0) onShowCallLogDepth = 0;
			return this;
		}

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

		public OdccQueryLooper IsBreakFunction(Func<bool> breakEvent)
		{
			onLooperBreakFunction = breakEvent != null ? Action : Pass;

			return this;
			bool Pass() => false;
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
