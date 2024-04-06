using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using BC.Base;

namespace BC.ODCC
{
	public class OdccLooper : IDisposable
	{
		public string key;
		public OdccLooper(string key)
		{
			this.key=key;
		}

		public virtual void Dispose()
		{
			this.key="";
		}

		public virtual IEnumerator RunAction()
		{
			yield return null;
		}
	}
	public class OdccLooper<T> : OdccLooper where T : class
	{
		internal class LooperDelegate
		{
			internal string key;
			internal Func<int> splitCount;
		}
		internal class LooperFunction : LooperDelegate
		{
			internal Func<IEnumerable<T>, IEnumerator> listener;
			public LooperFunction(string key, Func<IEnumerable<T>, IEnumerator> listener, Func<int> splitCount)
			{
				this.key = key;
				this.listener = listener;
				this.splitCount = splitCount;
			}
		}
		internal class LooperAction : LooperDelegate
		{
			internal Action<IEnumerable<T>>  listener;

			public LooperAction(string key, Action<IEnumerable<T>> listener, Func<int> splitCount)
			{
				this.key = key;
				this.listener = listener;
				this.splitCount = splitCount;
			}
		}

		public OdccCollector<T> Collector { get; private set; }
		public Func<T, bool> Condition { get; private set; }

		private List<LooperDelegate> looperDelegate;

		public OdccLooper(OdccCollector<T> collector, string key) : base(key)
		{
			this.Collector = collector;
			this.Condition = null;
			this.looperDelegate = new List<LooperDelegate>();
		}
		public OdccLooper(OdccCollector<T> collector, string key, bool prevUpdate, Func<T, bool> condition = null) : base(key)
		{
			this.Collector = collector;
			this.Condition = condition;
			this.looperDelegate = new List<LooperDelegate>();

			if(prevUpdate)
			{
				OdccForeach.ForeachPrevUpdate.Add(this, RunAction());
			}
			else
			{
				OdccForeach.ForeachNextUpdate.Add(this, RunAction());
			}
		}

		public override void Dispose()
		{
			base.Dispose();
			Collector = null;

			OdccForeach.ForeachPrevUpdate.Remove(this);
			OdccForeach.ForeachNextUpdate.Remove(this);
		}
		public override IEnumerator RunAction()
		{
			if(Collector is null) yield break;

			IEnumerable<T> toList = Collector.Collection;

			if(Condition != null)
			{
				toList = toList.Where(where => Condition(where));
			}

			int looperActionListCount = looperDelegate.Count;
			for(int i = 0 ; i < looperActionListCount ; i++)
			{
				LooperDelegate looperAction = looperDelegate[i];
				int splitCount = looperAction.splitCount?.Invoke() ?? 1;
				if(splitCount == 0)
				{
					while(splitCount <= 0)
					{
						yield return null;

						splitCount = looperAction.splitCount.Invoke();
					}
				}
				if(looperAction is LooperAction action)
				{
					if(splitCount == 0)
					{
						CallActionListener(action, toList);
					}
					else if(splitCount == 1)
					{
						//yield return null;
						CallActionListener(action, toList);
					}
					else if(splitCount >= 2)
					{
						yield return null;
						int listCount = toList.Count();
						int stap = listCount / splitCount;
						int addStap = listCount % splitCount;

						for(int index = 0 ; index < listCount ;)
						{
							int stapCount = stap + addStap-- == 0 ? 0 : stap + 1;

							CallActionListener(action, toList.Skip(index).Take(stapCount));
							yield return null;
							index += stapCount;
						}
					}
				}
				else if(looperAction is LooperFunction function)
				{
					if(splitCount == 0)
					{
						IEnumerator callListener = CallFuncListener(function, toList);
						while(callListener.MoveNext()) { yield return null; }
					}
					else if(splitCount == 1)
					{
						yield return null;
						IEnumerator callListener = CallFuncListener(function, toList);
						while(callListener.MoveNext()) { yield return null; }
					}
					else if(splitCount >= 2)
					{
						yield return null;
						int listCount = toList.Count();
						int stap = listCount / splitCount;
						int addStap = listCount % splitCount;

						for(int index = 0 ; index < listCount ;)
						{
							int stapCount = stap + addStap-- == 0 ? 0 : stap + 1;

							IEnumerator callListener =  CallFuncListener(function, toList.Skip(index).Take(stapCount));
							while(callListener.MoveNext()) { yield return null; }
							yield return null;
							index += stapCount;
						}
					}
				}
			}

			void CallActionListener(LooperAction looperAction, IEnumerable<T> callList)
			{
				try
				{
					looperAction.listener.Invoke(callList);
				}
				catch(Exception ex)
				{
					Debug.LogException(ex);
				}
			}
			IEnumerator CallFuncListener(LooperFunction looperAction, IEnumerable<T> callList)
			{
				IEnumerator funcListener = null;
				try
				{
					funcListener = looperAction.listener.Invoke(callList);
					if(funcListener ==null) yield break;
				}
				catch(Exception ex)
				{
					Debug.LogException(ex);
				}

				while(funcListener.MoveNext()) { yield return null; }
				yield break;
			}
		}
		public OdccLooper<T> SetListener(string key, Func<IEnumerable<T>, IEnumerator> listener, Func<int> splitCount = null)
		{
			looperDelegate.Clear();
			looperDelegate.Add(new LooperFunction(key, listener, splitCount));

			return this;
		}
		public OdccLooper<T> AddListener(string key, Func<IEnumerable<T>, IEnumerator> listener, Func<int> splitCount = null)
		{
			var find = looperDelegate.Find(item => item.key == key);
			if(find != null) looperDelegate.Remove(find);
			looperDelegate.Add(new LooperFunction(key, listener, splitCount));

			return this;
		}
		public OdccLooper<T> SetListener(string key, Action<IEnumerable<T>> listener, Func<int> splitCount = null)
		{
			looperDelegate.Clear();
			looperDelegate.Add(new LooperAction(key, listener, splitCount));

			return this;
		}
		public OdccLooper<T> AddListener(string key, Action<IEnumerable<T>> listener, Func<int> splitCount = null)
		{
			var find = looperDelegate.Find(item => item.key == key);
			if(find != null) looperDelegate.Remove(find);
			looperDelegate.Add(new LooperAction(key, listener, splitCount));

			return this;
		}
		public OdccLooper<T> RemoveListener(string key)
		{
			var find = looperDelegate.Find(item => item.key == key);
			if(find != null) looperDelegate.Remove(find);

			return this;
		}
	}

	public sealed partial class OdccQueryLooper : IDisposable
	{
		internal OdccQueryCollector queryCollector;

		/// Foreach 로 만든 액션의 개수만큼 들어있다.
		internal List<RunForeachStruct> runForeachStructList;
		public struct RunForeachStruct
		{
			// Foreach 에서 지정된 델리게이트
			public Delegate targetDelegate;
			// Foreach 에서 Enumerator 를 사용하는지?
			public bool isEnumerator;
			// queryCollector 를 만족하는 오브젝트 들 만큼 있음;
			public IEnumerable<RunForeachAction> runForeachActionList;
			// queryCollector 를 만족하는 오브젝트가 새로 추가 되면 Foreach에 맞는 Delegate 로 변경함.
			public Func<ObjectBehaviour, RunForeachAction> createAction;

			public Func<int> updateFrame;
			public RunForeachStruct(Delegate targetDelegate, List<RunForeachAction> runLoopActionList, bool isEnumerator, Func<ObjectBehaviour, RunForeachAction> createAction)
			{
				this.targetDelegate=targetDelegate;
				this.runForeachActionList = runLoopActionList;
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
			internal abstract void Run();
			internal abstract IEnumerator IRun();
		}
		public class AddedForeachAction : RunForeachAction
		{
			internal Action action;
			internal Func<IEnumerator> iAction;
			internal override void Run() => action?.Invoke();
			internal override IEnumerator IRun() => iAction();
		}

		internal Func<bool> onLooperBreakFunction;

		internal bool prevUpdate;
		internal bool isUsingLooper;

		internal static OdccQueryLooper CreateLooper(OdccQueryCollector queryCollector, bool prevUpdate)
		{
			OdccQueryLooper Looper = new OdccQueryLooper();
			Looper.queryCollector = queryCollector;
			Looper.prevUpdate = prevUpdate;
			Looper.runForeachStructList = new List<RunForeachStruct>();
			Looper.isUsingLooper = true;
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
		internal static OdccQueryLooper CreateCallEvent(OdccQueryCollector queryCollector)
		{
			OdccQueryLooper Looper = new OdccQueryLooper();
			Looper.queryCollector = queryCollector;
			Looper.prevUpdate = false;
			Looper.runForeachStructList = new List<RunForeachStruct>();
			Looper.isUsingLooper = false;
			Looper.IsBreakFunction(null);
			return Looper;
		}

		internal IEnumerator RunLooper()
		{
			if(!isUsingLooper || queryCollector is null) yield break;
			if(onLooperBreakFunction != null && onLooperBreakFunction.Invoke())
			{
				yield break;
			}

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
		private IEnumerator IRunLooper()
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
						return actionList.Skip(skip).Take(take).Where(act=> act.key == null || act.key.isActiveAndEnabled);
					}).ToArray();
				bool isSplt = ListInList.Count() > 1;
				foreach(var inList in ListInList)
				{
					foreach(var action in inList)
					{

						if(item.isEnumerator)
						{
							IEnumerator enumerator = action.IRun();
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
		public void RunCallEvent()
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

		public OdccQueryLooper Foreach()
		{
			return this;
		}
		public OdccQueryLooper Action(Action action)
		{
			var list = new List<RunForeachAction>();
			list.Add(new AddedForeachAction()
			{
				action = action
			});
			runForeachStructList.Add(new RunForeachStruct(action, list, false, null));
			return this;
		}
		public OdccQueryLooper Action(Func<IEnumerator> action)
		{
			var list = new List<RunForeachAction>();
			list.Add(new AddedForeachAction()
			{
				iAction = action
			});
			runForeachStructList.Add(new RunForeachStruct(action, list, true, null));
			return this;
		}
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

		internal void Add(ObjectBehaviour item)
		{
			int count = runForeachStructList.Count;
			for(int i = 0 ; i < count ; i++)
			{
				RunForeachStruct structItem = runForeachStructList[i];
				structItem.Add(item);
    				runForeachStructList[i]=structItem;
			}

		}

		internal void Remove(ObjectBehaviour item)
		{
			int count = runForeachStructList.Count;
			for(int i = 0 ; i < count ; i++)
			{
				RunForeachStruct structItem = runForeachStructList[i];
				structItem.Remove(item);
    				runForeachStructList[i]=structItem;
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
	}

}
