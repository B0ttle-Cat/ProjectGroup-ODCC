using System;
using System.Collections.Generic;
using System.Threading;

using Sirenix.OdinInspector;

using UnityEngine;

namespace BC.ODCC
{
	[Serializable]
	public class ContainerObject : IDisposable
	{
		[ShowInInspector, InlineProperty, HideLabel, HideReferenceObjectPicker]
		[PropertyOrder(-5)]
		public OdccContainerTree.ContainerNode ContainerNode;
		public ObjectBehaviour ThisObject => ContainerNode.thisObject;
		public ObjectBehaviour ParentObject => ContainerNode.parent;
		public ContainerObject ParentContainer => ParentObject?.ThisContainer;
		public ObjectBehaviour[] ChildObject => ContainerNode.childs;
		public ComponentBehaviour[] ComponentList => ContainerNode.componentList;
		public DataObject[] DataList => ContainerNode.dataList;
		internal int[] TypeIndex => ContainerNode.typeIndex;

		private Queue<Action> callActionQueue;


		public ContainerObject(ObjectBehaviour objectBehaviour)
		{
			ContainerNode = new OdccContainerTree.ContainerNode(objectBehaviour);
			callActionQueue = new Queue<Action>();
		}
		public void Dispose()
		{
			ContainerNode = null;
			callActionQueue.Clear();
			callActionQueue = null;
		}

		internal void AddInCallActionQueue(Action action)
		{
			if(callActionQueue == null)
				callActionQueue = new Queue<Action>();

			if(callActionQueue is not null)
			{
				while(callActionQueue.Count > 0)
				{
					callActionQueue.Dequeue().Invoke();
				}
				callActionQueue.Enqueue(action);
				while(callActionQueue.Count > 0)
				{
					callActionQueue.Dequeue().Invoke();
				}
			}
		}
		internal void CallInActionQueue(List<Action> actions)
		{
			if(callActionQueue == null)
				callActionQueue = new Queue<Action>();

			if(callActionQueue is not null)
			{
				while(callActionQueue.Count > 0)
				{
					callActionQueue.Dequeue().Invoke();
				}
				for(int i = 0 ; i < actions.Count ; i++)
				{
					callActionQueue.Enqueue(actions[i]);
				}
				while(callActionQueue.Count > 0)
				{
					callActionQueue.Dequeue().Invoke();
				}
			}
		}
		public bool TryGetObject<T>(out T t) where T : class, IOdccObject
		{
			t = ThisObject is T v ? v : null;
			return t is not null;
		}
		public bool TryGetParentObject<T>(out T t, Func<T, bool> condition = null) where T : class, IOdccObject
		{
			t = GetParentObject(condition);
			return t is not null;
		}
		public bool TryGetChildObject<T>(out T t, Func<T, bool> condition = null) where T : class, IOdccObject
		{
			t = GetChildObject<T>(condition);
			return t is not null;
		}
		public bool TryGetChildObjectList<T>(out T[] t, Func<T, bool> condition = null) where T : class, IOdccObject
		{
			t = GetChildAllObject<T>(condition);
			return t is not null || t.Length > 0;
		}
		public T GetObject<T>() where T : class, IOdccObject
		{
			return ThisObject as T;
		}
		public T GetParentObject<T>(Func<T, bool> condition = null) where T : class, IOdccObject
		{
			if(ParentObject is null) return null;
			else if(ParentObject is T t && (condition == null || condition.Invoke(t)))
			{
				return t;
			}
			else
			{
				return ParentObject.ThisContainer.GetParentObject(condition);
			}
		}
		public T GetChildObject<T>(Func<T, bool> condition = null) where T : class, IOdccObject
		{
			return ChildObject.Get<T, ObjectBehaviour>(condition);
		}
		public T[] GetChildAllObject<T>(Func<T, bool> condition = null) where T : class, IOdccObject
		{
			return ChildObject.GetAll<T, ObjectBehaviour>(condition);
		}

		public T GetComponent<T>(Func<T, bool> condition = null) where T : class, IOdccComponent
		{
			return ComponentList.Get<T, ComponentBehaviour>(condition);
		}
		public T GetComponentInChild<T>(Func<T, bool> condition = null) where T : class, IOdccComponent
		{
			T t = ComponentList.Get<T, ComponentBehaviour>(condition);
			if(t is not null) return t;

			int length = ChildObject.Length;
			for(int i = 0 ; i < length ; i++)
			{
				t = ChildObject[i].ThisContainer.GetComponentInChild<T>(condition);
				if(t is not null) return t;
			}
			return null;
		}
		public T[] GetAllComponent<T>(Func<T, bool> condition = null) where T : class, IOdccComponent
		{
			return ComponentList.GetAll<T, ComponentBehaviour>(condition);
		}
		public void GetAllComponentInChild<T>(out List<T> resultArray, Func<T, bool> condition = null) where T : class, IOdccComponent
		{
			resultArray = new List<T>();
			resultArray.AddRange(ComponentList.GetAll<T, ComponentBehaviour>(condition));

			int length = ChildObject.Length;
			for(int i = 0 ; i < length ; i++)
			{
				var childList = new List<T>();
				ChildObject[i].ThisContainer.GetAllComponentInChild(out childList, condition);
				resultArray.AddRange(childList);
			}
		}
		public bool TryGetComponent<T>(out T t, Func<T, bool> condition = null) where T : class, IOdccComponent
		{
			t = GetComponent<T>(condition);
			return t is not null;
		}
		public bool TryGetComponentInChild<T>(out T t, Func<T, bool> condition = null) where T : class, IOdccComponent
		{
			t = GetComponentInChild<T>(condition);
			return t is not null;
		}
		public bool TryGetComponentList<T>(out T[] t, Func<T, bool> condition = null) where T : class, IOdccComponent
		{
			t = GetAllComponent<T>(condition);
			return t is not null && t.Length > 0;
		}
		public bool TryGetAllComponentInChild<T>(out List<T> t, Func<T, bool> condition = null) where T : class, IOdccComponent
		{
			GetAllComponentInChild<T>(out t, condition);
			return t is not null && t.Count > 0;
		}
#if USING_AWAITABLE_LOOP
		public async Awaitable<T> AwaitGetComponent<T>(Func<T, bool> condition = null, CancellationToken? cancelToken = null) where T : class, IOdccComponent
		{
			T t = null;
			cancelToken ??= ThisObject.DestroyCancelToken;
			while(!cancelToken.Value.IsCancellationRequested && !TryGetComponent(out t, condition))
			{
				try
				{
					await Awaitable.NextFrameAsync(cancelToken.Value);
				}
				catch
				{
					t= null;
					break;
				}
			}
			return t;
		}
		public async Awaitable<T> AwaitGetComponentInChild<T>(Func<T, bool> condition = null, CancellationToken? cancelToken = null) where T : class, IOdccComponent
		{
			T t = null;
			cancelToken ??= ThisObject.DestroyCancelToken;
			while(!cancelToken.Value.IsCancellationRequested && !TryGetComponentInChild(out t, condition))
			{
				try
				{
					await Awaitable.NextFrameAsync(cancelToken.Value);
				}
				catch
				{
					t= null;
					break;
				}
			}
			return t;
		}
		public async Awaitable<T[]> AwaitGetComponentList<T>(Func<T, bool> condition = null, CancellationToken? cancelToken = null) where T : class, IOdccComponent
		{
			T[] t = null;
			cancelToken ??= ThisObject.DestroyCancelToken;
			while(!cancelToken.Value.IsCancellationRequested && !TryGetComponentList(out t, condition))
			{
				try
				{
					await Awaitable.NextFrameAsync(cancelToken.Value);
				}
				catch
				{
					t= null;
					break;
				}
			}
			return t;
		}
		public async Awaitable<List<T>> AwaitGetAllComponentList<T>(Func<T, bool> condition = null, CancellationToken? cancelToken = null) where T : class, IOdccComponent
		{
			List<T> t = null;
			cancelToken ??= ThisObject.DestroyCancelToken;
			while(!cancelToken.Value.IsCancellationRequested && !TryGetAllComponentInChild(out t, condition))
			{
				try
				{
					await Awaitable.NextFrameAsync(cancelToken.Value);
				}
				catch
				{
					t= null;
					break;
				}
			}
			return t;
		}
		public async void AwaitGetComponent<T>(Action<T> callback, Func<T, bool> condition = null, CancellationToken? cancelToken = null) where T : class, IOdccComponent
		{
			if(callback is null) return;

			var t = await AwaitGetComponent<T>(condition, cancelToken);
			if(t is null) return;
			callback.Invoke(t);
		}
		public async void AwaitGetComponentInChild<T>(Action<T> callback, Func<T, bool> condition = null, CancellationToken? cancelToken = null) where T : class, IOdccComponent
		{
			if(callback is null) return;

			var t = await AwaitGetComponentInChild<T>(condition, cancelToken);
			if(t is null) return;
			callback.Invoke(t);
		}
		public async void AwaitGetComponentList<T>(Action<T[]> callback, Func<T, bool> condition = null, CancellationToken? cancelToken = null) where T : class, IOdccComponent
		{
			if(callback is null) return;

			var t = await AwaitGetComponentList<T>(condition, cancelToken);
			if(t is null) return;
			callback.Invoke(t);
		}
		public async void AwaitGetAllComponentList<T>(Action<List<T>> callback, Func<T, bool> condition = null, CancellationToken? cancelToken = null) where T : class, IOdccComponent
		{
			if(callback is null) return;

			var t = await AwaitGetAllComponentList<T>(condition, cancelToken);
			if(t is null) return;
			callback.Invoke(t);
		}
#endif
		public T GetData<T>(Func<T, bool> condition = null) where T : class, IOdccData
		{
			T t = DataList.GetData<T, DataObject>(condition);
			return t;
		}
		public T[] GetAllData<T>(Func<T, bool> condition = null) where T : class, IOdccData
		{
			T[] t = DataList.GetAllData<T, DataObject>(condition);
			return t;
		}
		public bool TryGetData<T>(out T t, Func<T, bool> condition = null) where T : class, IOdccData
		{
			t = GetData<T>(condition);
			return t is not null;
		}
		public bool TryGetDataList<T>(out T[] t, Func<T, bool> condition = null) where T : class, IOdccData
		{
			t = GetAllData<T>(condition);
			return t is not null && t.Length > 0;
		}
#if USING_AWAITABLE_LOOP
		public async Awaitable<T> AwaitGetData<T>(Func<T, bool> condition = null, CancellationToken? cancelToken = null) where T : class, IOdccData
		{
			T t = null;
			cancelToken ??= ThisObject.DestroyCancelToken;
			while(!cancelToken.Value.IsCancellationRequested && !TryGetData(out t, condition))
			{
				try
				{
					await Awaitable.NextFrameAsync(cancelToken.Value);
				}
				catch
				{
					t= null;
					break;
				}
			}
			return t;
		}
		public async Awaitable<T[]> AwaitGetDataList<T>(Func<T, bool> condition = null, CancellationToken? cancelToken = null) where T : class, IOdccData
		{
			T[] t = null;
			cancelToken ??= ThisObject.DestroyCancelToken;
			while(!cancelToken.Value.IsCancellationRequested && !TryGetDataList(out t, condition))
			{
				try
				{
					await Awaitable.NextFrameAsync(cancelToken.Value);
				}
				catch
				{
					t= null;
					break;
				}
			}
			return t;
		}
		public async void AwaitGetData<T>(Action<T> callback, Func<T, bool> condition = null, CancellationToken? cancelToken = null) where T : class, IOdccData
		{
			if(callback is null) return;

			var t = await AwaitGetData<T>(condition, cancelToken);
			if(t is null) return;
			callback.Invoke(t);
		}
		public async void AwaitGetDataList<T>(Action<T[]> callback, Func<T, bool> condition = null, CancellationToken? cancelToken = null) where T : class, IOdccData
		{
			if(callback is null) return;

			var t = await AwaitGetDataList<T>(condition, cancelToken);
			if(t is null) return;
			callback.Invoke(t);
		}
#endif
		public void CallActionObject<T>(Action<T> tAction, Func<T, bool> condition = null) where T : class, IOdccObject
		{
			if(tAction is null) return;
			ChildObject.GetAction<T, ObjectBehaviour>(GetAction, condition);
			void GetAction(T t)
			{
				AddInCallActionQueue(() => tAction.Invoke(t));
			}
		}
		public void CallActionAllObject<T>(Action<T> tAction, Func<bool> isBreak = null, Func<T, bool> condition = null) where T : class, IOdccObject
		{
			if(tAction is null) return;
			ChildObject.GetAllAction<T, ObjectBehaviour>(GetAction, isBreak, condition);
			void GetAction(T t)
			{
				AddInCallActionQueue(() => tAction.Invoke(t));
			}
		}
		public void CallActionComponent<T>(Action<T> tAction, Func<T, bool> condition = null) where T : class, IOdccComponent
		{
			if(tAction is null) return;
			ComponentList.GetAction<T, ComponentBehaviour>(GetAction, condition);
			void GetAction(T t)
			{
				AddInCallActionQueue(() => tAction.Invoke(t));
			}
		}
		public void CallActionAllComponent<T>(Action<T> tAction, Func<bool> isBreak = null, Func<T, bool> condition = null) where T : class, IOdccComponent
		{
			if(tAction is null) return;
			ComponentList.GetAllAction<T, ComponentBehaviour>(GetAction, isBreak, condition);
			void GetAction(T t)
			{
				AddInCallActionQueue(() => tAction.Invoke(t));
			}
		}
		public void CallActionAllComponentInChildObject<T>(Action<T> tAction, Func<T, bool> condition = null) where T : class, IOdccComponent
		{
			if(tAction is not null && TryGetAllComponentInChild<T>(out List<T> tList, condition))
			{
				List<Action> actions = new List<Action>();
				int Count = tList.Count;
				for(int i = 0 ; i < Count ; i++)
				{
					if(tList[i] is not null)
					{
						int index = i;
						actions.Add(() => {
							tAction.Invoke(tList[index]);
						});
					}
				}
				CallInActionQueue(actions);
			}
		}

		public void GetDataAction<T>(Action<T> tAction, Func<T, bool> condition = null) where T : class, IOdccData
		{
			DataList.GetDataAction<T, DataObject>(tAction, condition);
		}
		public void GetAllDataAction<T>(Action<T> tAction, Func<bool> isBreak = null, Func<T, bool> condition = null) where T : class, IOdccData
		{
			DataList.GetAllDataAction<T, DataObject>(tAction, isBreak, condition);
		}

		public T AddChildObject<T>(bool onActive, string name = "") where T : ObjectBehaviour
		{
			if(string.IsNullOrWhiteSpace(name))
			{
				name = $"new {typeof(T).Name}";
			}

			GameObject newObject = new GameObject(name);
			newObject.SetActive(false);
			newObject.transform.parent = ThisObject.ThisTransform;

			T child = newObject.AddComponent<T>();
			if(onActive)
			{
				newObject.SetActive(onActive);
			}
			return child;
		}
		public T AddComponent<T>(GameObject obj = null) where T : ComponentBehaviour
		{
			return (obj ?? ThisObject.gameObject).AddComponent<T>();
		}
		public T AddData<T>(T data = null) where T : DataObject, new()
		{
			if(data == null)
				data = new T();

			ContainerNode.DataObjectListAdd(data);
			return data;
		}

		[Obsolete("되도록 Destroy 사용해 직접 삭제하는걸로...", true)]
		public void RemoveChildObject<T>(T target = null) where T : ObjectBehaviour
		{
			if(target == null)
				target = GetChildObject<T>();

			if(target != null)
				GameObject.Destroy(target);
		}
		public bool RemoveComponent<T>(T target = null) where T : ComponentBehaviour
		{
			if(target == null)
				target = GetComponent<T>();

			if(target != null)
			{
				GameObject.Destroy(target);
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool RemoveData<T>(T target = null) where T : DataObject
		{
			if(target == null)
				target = GetData<T>();

			if(target != null)
			{
				ContainerNode.DataObjectListRemove(target);
				return true;
			}
			else
			{
				return false;
			}
		}


		#region Using In Odcc Manager
		internal bool _TryGetComponent<T>(out T t, Func<T, bool> condition = null) where T : class, IOdccItem
		{
			t = _GetComponent<T>(condition);
			return t is not null;
		}
		internal T _GetComponent<T>(Func<T, bool> condition = null) where T : class, IOdccItem
		{
			return ComponentList.Get<T, ComponentBehaviour>(condition);
		}
		internal bool _TryGetData<T>(out T t, Func<T, bool> condition = null) where T : class, IOdccItem
		{
			t = _GetData<T>(condition);
			return t is not null;
		}
		internal T _GetData<T>(Func<T, bool> condition = null) where T : class, IOdccItem
		{
			T t = DataList.GetData<T, DataObject>(condition);
			return t;
		}
		internal bool _TryGetComponents<T>(out T[] t, Func<T, bool> condition = null) where T : class, IOdccItem
		{
			t = _GetComponents<T>(condition);
			return t is not null && t.Length >0;
		}
		internal T[] _GetComponents<T>(Func<T, bool> condition = null) where T : class, IOdccItem
		{
			return ComponentList.GetAll<T, ComponentBehaviour>(condition);
		}
		internal bool _TryGetDatas<T>(out T[] t, Func<T, bool> condition = null) where T : class, IOdccItem
		{
			t = _GetDatas<T>(condition);
			return t is not null && t.Length >0; ;
		}
		internal T[] _GetDatas<T>(Func<T, bool> condition = null) where T : class, IOdccItem
		{
			return DataList.GetAllData<T, DataObject>(condition);
		}
		#endregion
	}
	internal static class OdccItemList
	{
		public static T Get<T, TT>(this TT[] thisList, Func<T, bool> condition = null) where T : class where TT : class, IOdccItem
		{
#if UNITY_EDITOR
			if(typeof(T).IsSubclassOf(typeof(DataObject)))
				throw new Exception($"ODCC.GetComponent 에서 {typeof(T)}에 대한 잘못된 ODCC 변환입니다.");
#endif
			int count = thisList.Length;
			for(int i = 0 ; i < count ; i++)
			{
				var item = thisList[i];
				if(item is T tt && (condition is null || condition.Invoke(tt)))
				{
					return tt;
				}
			}
			return null;
		}
		public static T[] GetAll<T, TT>(this TT[] thisList, Func<T, bool> condition = null) where T : class where TT : class, IOdccItem
		{
#if UNITY_EDITOR
			if(typeof(T).IsSubclassOf(typeof(DataObject)))
				throw new Exception($"ODCC.GetComponent 에서 {typeof(T)}에 대한 잘못된 ODCC 변환입니다.");
#endif
			List<T> list = new List<T>();
			int count = thisList.Length;
			for(int i = 0 ; i < count ; i++)
			{
				var item = thisList[i];
				if(item is T tt && (condition is null || condition.Invoke(tt)))
				{
					list.Add(tt);
				}
			}
			return list.ToArray();
		}
		public static T GetData<T, TT>(this TT[] thisList, Func<T, bool> condition = null) where T : class, IOdccItem
		{
#if UNITY_EDITOR
			if(typeof(T).IsSubclassOf(typeof(ComponentBehaviour)))
				throw new Exception($"ODCC.GetData 에서 {typeof(T)}에 대한 잘못된 ODCC 변환입니다.");
#endif
			int count = thisList.Length;
			for(int i = 0 ; i < count ; i++)
			{
				var item = thisList[i];
				if(item is T tt && (condition is null || condition.Invoke(tt)))
				{
					return tt;
				}
			}
			return default;
		}
		public static T[] GetAllData<T, TT>(this TT[] thisList, Func<T, bool> condition = null) where T : class, IOdccItem
		{
#if UNITY_EDITOR
			if(typeof(T).IsSubclassOf(typeof(ComponentBehaviour)))
				throw new Exception($"ODCC.GetData 에서 {typeof(T)}에 대한 잘못된 ODCC 변환입니다.");
#endif
			List<T> list = new List<T>();
			int count = thisList.Length;
			for(int i = 0 ; i < count ; i++)
			{
				var item = thisList[i];
				if(item is T tt && (condition is null || condition.Invoke(tt)))
				{
					list.Add(tt);
				}
			}
			return list.ToArray();
		}


		public static void GetAction<T, TT>(this TT[] thisList, Action<T> action, Func<T, bool> condition = null) where T : class where TT : class, IOdccItem
		{
#if UNITY_EDITOR
			if(typeof(T).IsSubclassOf(typeof(DataObject)))
				throw new Exception($"ODCC.GetComponent 에서 {typeof(T)}에 대한 잘못된 ODCC 변환입니다.");
#endif
			int count = thisList.Length;
			for(int i = 0 ; i < count ; i++)
			{
				var item = thisList[i];
				if(item is T tt && (condition is null || condition.Invoke(tt)))
				{
					action(tt);
					return;
				}
			}
		}
		public static void GetAllAction<T, TT>(this TT[] thisList, Action<T> action, Func<bool> isBreak = null, Func<T, bool> condition = null) where T : class where TT : class, IOdccItem
		{
#if UNITY_EDITOR
			if(typeof(T).IsSubclassOf(typeof(DataObject)))
				throw new Exception($"ODCC.GetComponent 에서 {typeof(T)}에 대한 잘못된 ODCC 변환입니다.");
#endif
			//List<T> list = new List<T>();
			int count = thisList.Length;
			for(int i = 0 ; i < count ; i++)
			{
				var item = thisList[i];
				if(item is T tt && (condition is null || condition.Invoke(tt)))
				{
					action(tt);
				}

				if(isBreak is not null && isBreak())
				{
					break;
				}
			}
		}

		public static void GetDataAction<T, TT>(this TT[] thisList, Action<T> action, Func<T, bool> condition = null) where T : class, IOdccItem
		{
#if UNITY_EDITOR
			if(!OdccManager.isProfilerEnabled && typeof(T).IsSubclassOf(typeof(ComponentBehaviour)))
				throw new Exception($"ODCC.GetData 에서 {typeof(T)}에 대한 잘못된 ODCC 변환입니다.");
#endif
			int count = thisList.Length;
			for(int i = 0 ; i < count ; i++)
			{
				var item = thisList[i];
				if(item is T tt && (condition is null || condition.Invoke(tt)))
				{
					action(tt);
					return;
				}
			}
		}
		public static void GetAllDataAction<T, TT>(this TT[] thisList, Action<T> action, Func<bool> isBreak = null, Func<T, bool> condition = null) where T : class, IOdccItem
		{
#if UNITY_EDITOR
			if(!OdccManager.isProfilerEnabled && typeof(T).IsSubclassOf(typeof(ComponentBehaviour)))
				throw new Exception($"ODCC.GetData 에서 {typeof(T)}에 대한 잘못된 ODCC 변환입니다.");
#endif
			int count = thisList.Length;
			for(int i = 0 ; i < count ; i++)
			{
				var item = thisList[i];
				if(item is T tt && (condition is null || condition.Invoke(tt)))
				{
					action(tt);
				}

				if(isBreak is not null && isBreak())
				{
					break;
				}
			}
		}
	}
}
