using System;
using System.Collections.Generic;
using System.Linq;
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
		public ContainerNode ContainerNode;
		public IOdccObject ThisObject => ContainerNode.thisObject;
		public IOdccObject ParentObject => ContainerNode.parent;
		public ContainerObject ParentContainer => ParentObject?.ThisContainer;
		public IOdccObject[] ChildObject => ContainerNode.children;
		public IOdccComponent[] ComponentList => ContainerNode.components;
		public IOdccData[] DataList => ContainerNode.datas;
		internal int[] TypeIndex => ContainerNode.typeIndex;

		private Queue<Action> callActionQueue;


		public ContainerObject(ContainerNode containerNode)
		{
			ContainerNode = containerNode;
			callActionQueue = new Queue<Action>();
		}
		public void Dispose()
		{
			ContainerNode = null;
			callActionQueue.Clear();
			callActionQueue = null;
		}

		internal void CallingActionQueue(Action action)
		{
			callActionQueue ??= new Queue<Action>();
			if(action == null) return;

			if(callActionQueue.Count > 0)
			{
				/// action 진행중에 내부적으로 다시 action 이 호출 되는 경우가 있더라 하도러도 먼저 호출된 action 이 먼저 진행되도록 보장한다.
				callActionQueue.Enqueue(action);
			}
			else
			{
				// action 추가 
				callActionQueue.Enqueue(action);

				// Queue 순서에 맞게 실행
				do
				{
					callActionQueue.Peek()?.Invoke();
					callActionQueue.Dequeue();
				}
				while(callActionQueue.Count > 0);
			}
		}
		internal void CallingActionQueue(List<Action> actions)
		{
			callActionQueue ??= new Queue<Action>();
			if(actions.Count == 0) return;

			if(callActionQueue.Count > 0)
			{
				/// action 진행중에 내부적으로 다시 action 이 호출 되는 경우가 있더라 하도러도 먼저 호출된 action 이 먼저 진행되도록 보장한다.
				for(int i = 0 ; i < actions.Count ; i++)
				{
					callActionQueue.Enqueue(actions[i]);
				}
			}
			else
			{
				// action 추가 
				for(int i = 0 ; i < actions.Count ; i++)
				{
					callActionQueue.Enqueue(actions[i]);
				}

				// Queue 순서에 맞게 실행
				do
				{
					callActionQueue.Peek()?.Invoke();
					callActionQueue.Dequeue();
				}
				while(callActionQueue.Count > 0);
			}
		}

		#region GetObject OdccItem
		public bool TryGetObject<T>(out T t, Func<T, bool> condition = null) where T : class, IOdccObject
		{
			t = ThisObject is T v ? v : null;
			if(t is not null)
			{
				if(condition == null || condition.Invoke(t)) return true;
			}
			return false;
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
			return ThisObject is T t ? t : null;
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
			return ChildObject.Get<T, IOdccObject>(condition);
		}
		public T[] GetChildAllObject<T>(Func<T, bool> condition = null) where T : class, IOdccObject
		{
			return ChildObject.GetAll<T, IOdccObject>(condition);
		}
		public async Awaitable<T> AwaitGetObject<T>(Func<T, bool> condition = null, CancellationToken? cancelToken = null) where T : class, IOdccObject
		{
			T t = null;
			cancelToken ??= ThisObject.DestroyCancelToken;
			while(!cancelToken.Value.IsCancellationRequested && !TryGetObject(out t, condition))
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
		public async Awaitable<T> AwaitGetParentObject<T>(Func<T, bool> condition = null, CancellationToken? cancelToken = null) where T : class, IOdccObject
		{
			T t = null;
			cancelToken ??= ThisObject.DestroyCancelToken;
			while(!cancelToken.Value.IsCancellationRequested && !TryGetParentObject(out t, condition))
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
		public async Awaitable<T> AwaitGetChildObject<T>(Func<T, bool> condition = null, CancellationToken? cancelToken = null) where T : class, IOdccObject
		{
			T t = null;
			cancelToken ??= ThisObject.DestroyCancelToken;
			while(!cancelToken.Value.IsCancellationRequested && !TryGetChildObject(out t, condition))
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
		public async Awaitable<T[]> AwaitGetChildObjectList<T>(Func<T, bool> condition = null, CancellationToken? cancelToken = null) where T : class, IOdccObject
		{
			T[] t = null;
			cancelToken ??= ThisObject.DestroyCancelToken;
			while(!cancelToken.Value.IsCancellationRequested && !TryGetChildObjectList(out t, condition))
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
		public async void NextGetObject<T>(Action<T> callback, Func<T, bool> condition = null, CancellationToken? cancelToken = null) where T : class, IOdccObject
		{
			if(callback is null) return;

			var t = await AwaitGetObject<T>(condition, cancelToken);
			if(t is null) return;
			callback.Invoke(t);
		}
		public async void NextGetParentObject<T>(Action<T> callback, Func<T, bool> condition = null, CancellationToken? cancelToken = null) where T : class, IOdccObject
		{
			if(callback is null) return;

			var t = await AwaitGetParentObject<T>(condition, cancelToken);
			if(t is null) return;
			callback.Invoke(t);
		}
		public async void NextGetChildObject<T>(Action<T> callback, Func<T, bool> condition = null, CancellationToken? cancelToken = null) where T : class, IOdccObject
		{
			if(callback is null) return;

			var t = await AwaitGetChildObject<T>(condition, cancelToken);
			if(t is null) return;
			callback.Invoke(t);
		}
		public async void NextGetChildObjectList<T>(Action<T[]> callback, Func<T, bool> condition = null, CancellationToken? cancelToken = null) where T : class, IOdccObject
		{
			if(callback is null) return;

			var t = await AwaitGetChildObjectList<T>(condition, cancelToken);
			if(t is null) return;
			callback.Invoke(t);
		}
		#endregion
		#region GetComponent OdccItem
		public T GetComponent<T>(Func<T, bool> condition = null) where T : class, IOdccComponent
		{
			return ComponentList.Get<T, IOdccComponent>(condition);
		}
		public T GetComponentInChild<T>(Func<T, bool> condition = null) where T : class, IOdccComponent
		{
			T t = ComponentList.Get<T, IOdccComponent>(condition);
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
			return ComponentList.GetAll<T, IOdccComponent>(condition);
		}
		public void GetAllComponentInChild<T>(out List<T> resultArray, Func<T, bool> condition = null) where T : class, IOdccComponent
		{
			resultArray = new List<T>();
			resultArray.AddRange(ComponentList.GetAll<T, IOdccComponent>(condition));

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
		public async void NextGetComponent<T>(Action<T> callback, Func<T, bool> condition = null, CancellationToken? cancelToken = null) where T : class, IOdccComponent
		{
			if(callback is null) return;

			var t = await AwaitGetComponent<T>(condition, cancelToken);
			if(t is null) return;
			callback.Invoke(t);
		}
		public async void NextGetComponentInChild<T>(Action<T> callback, Func<T, bool> condition = null, CancellationToken? cancelToken = null) where T : class, IOdccComponent
		{
			if(callback is null) return;

			var t = await AwaitGetComponentInChild<T>(condition, cancelToken);
			if(t is null) return;
			callback.Invoke(t);
		}
		public async void NextGetComponentList<T>(Action<T[]> callback, Func<T, bool> condition = null, CancellationToken? cancelToken = null) where T : class, IOdccComponent
		{
			if(callback is null) return;

			var t = await AwaitGetComponentList<T>(condition, cancelToken);
			if(t is null) return;
			callback.Invoke(t);
		}
		public async void NextGetAllComponentList<T>(Action<List<T>> callback, Func<T, bool> condition = null, CancellationToken? cancelToken = null) where T : class, IOdccComponent
		{
			if(callback is null) return;

			var t = await AwaitGetAllComponentList<T>(condition, cancelToken);
			if(t is null) return;
			callback.Invoke(t);
		}
		#endregion
		#region GetData OdccItem 
		public T GetData<T>(Func<T, bool> condition = null) where T : class, IOdccData
		{
			T t = DataList.GetData<T, IOdccData>(condition);
			return t;
		}
		public T[] GetAllData<T>(Func<T, bool> condition = null) where T : class, IOdccData
		{
			T[] t = DataList.GetAllData<T, IOdccData>(condition);
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
		public async void NextGetData<T>(Action<T> callback, Func<T, bool> condition = null, CancellationToken? cancelToken = null) where T : class, IOdccData
		{
			if(callback is null) return;

			var t = await AwaitGetData<T>(condition, cancelToken);
			if(t is null) return;
			callback.Invoke(t);
		}
		public async void NextGetDataList<T>(Action<T[]> callback, Func<T, bool> condition = null, CancellationToken? cancelToken = null) where T : class, IOdccData
		{
			if(callback is null) return;

			var t = await AwaitGetDataList<T>(condition, cancelToken);
			if(t is null) return;
			callback.Invoke(t);
		}
		#endregion
		#region GetIOdccItem
		public List<T> FindAllType<T>()
		{
			List<T> t = new List<T>();
			if(ThisObject is T tObj) t.Add(tObj);
			int length = DataList.Length;
			for(int i = 0 ; i < length ; i++)
			{
				if(DataList[i] is T tData) t.Add(tData);
			}
			length = ComponentList.Length;
			for(int i = 0 ; i < length ; i++)
			{
				if(ComponentList[i] is T tData) t.Add(tData);
			}
			return t;
		}
		#endregion
		#region Get OdccItemInList
		internal bool _TryGetComponent<T>(out T t, Func<T, bool> condition = null) where T : class, IOdccItem
		{
			t = _GetComponent<T>(condition);
			return t is not null;
		}
		internal T _GetComponent<T>(Func<T, bool> condition = null) where T : class, IOdccItem
		{
			return ComponentList.Get<T, IOdccItem>(condition);
		}
		internal bool _TryGetData<T>(out T t, Func<T, bool> condition = null) where T : class, IOdccItem
		{
			t = _GetData<T>(condition);
			return t is not null;
		}
		internal T _GetData<T>(Func<T, bool> condition = null) where T : class, IOdccItem
		{
			T t = DataList.GetData<T, IOdccItem>(condition);
			return t;
		}
		internal bool _TryGetComponents<T>(out T[] t, Func<T, bool> condition = null) where T : class, IOdccAttach
		{
			t = _GetComponents<T>(condition);
			return t is not null && t.Length >0;
		}
		internal bool _TryGetComponents<T>(int typeID, out T t, Func<IOdccAttach, bool> condition = null) where T : class, ICollection<IOdccAttach>, new()
		{
			t = _GetComponents<T>(typeID, condition);
			return t is not null;
		}
		internal T[] _GetComponents<T>(Func<T, bool> condition = null) where T : class, IOdccItem
		{
			return ComponentList.GetAll<T, IOdccItem>(condition);
		}
		internal T _GetComponents<T>(int typeID, Func<IOdccAttach, bool> condition = null) where T : class, ICollection<IOdccAttach>, new()
		{
			return ComponentList.GetAll<T, IOdccAttach>(typeID, condition);
		}


		internal bool _TryGetDatas<T>(out T[] t, Func<T, bool> condition = null) where T : class, IOdccItem
		{
			t = _GetDatas<T>(condition);
			return t is not null && t.Length >0;
		}
		internal bool _TryGetDatas<T>(int typeID, out T t, Func<IOdccAttach, bool> condition = null) where T : class, ICollection<IOdccAttach>, new()
		{
			t = _GetDatas<T>(typeID, condition);
			return t is not null;
		}
		internal T[] _GetDatas<T>(Func<T, bool> condition = null) where T : class, IOdccItem
		{
			return DataList.GetAllData<T, IOdccItem>(condition);
		}
		internal T _GetDatas<T>(int typeID, Func<IOdccAttach, bool> condition = null) where T : class, ICollection<IOdccAttach>, new()
		{
			return DataList.GetAllData<T, IOdccAttach>(typeID, condition);
		}
		#endregion
		#region Add OdccItem
		public T AddChildObject<T>(bool onActive, string name = "") where T : ObjectBehaviour
		{
			return AddChildObject<T>(ThisObject.ThisTransform, onActive, name);
		}
		public T AddChildObject<T>(ComponentBehaviour parent, bool onActive, string name = "") where T : ObjectBehaviour
		{
			return AddChildObject<T>(parent.ThisTransform, onActive, name);
		}
		public T AddChildObject<T>(Transform parent, bool onActive, string name = "") where T : ObjectBehaviour
		{
			if(string.IsNullOrWhiteSpace(name))
			{
				name = $"new {typeof(T).Name}";
			}

			GameObject newObject = new GameObject(name);
			newObject.SetActive(false);
			newObject.transform.parent = parent;

			T newTObject = newObject.AddComponent<T>();
			if(onActive) newObject.SetActive(true);
			else OdccManager.OdccAwake(newTObject);
			return newTObject;
		}
		public T AddComponent<T>(GameObject obj = null) where T : ComponentBehaviour
		{
			return (obj ?? ThisObject.GameObject).AddComponent<T>();
		}
		public T AddData<T>(T data = null) where T : DataObject, new()
		{
			if(data == null)
				data = new T();

			data.ThisContainer = this;
			ContainerNode.AddItem(data);
			return data;
		}
		public void AddDatas(params DataObject[] datas)
		{
			int length = datas.Length;
			for(int i = 0 ; i < length ; i++)
			{
				datas[i].ThisContainer = this;
			}
			ContainerNode.AddItems(datas);
		}
		public void AddData(DataObject data = null)
		{
			if(data != null) ContainerNode.AddItem(data);
		}
		#endregion
		#region Remove OdccItem
		[Obsolete("되도록, Object.Destroy 또는 DestroyThis 를 사용해 직접 삭제 할 것.", true)]
		public void RemoveChildObject<T>(T target = null, bool removeThisGameObject = false) where T : ObjectBehaviour
		{
			if(target == null)
				target = GetChildObject<T>();

			if(target != null)
				target.DestroyThis(removeThisGameObject);
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
				target.ThisContainer = null;
				ContainerNode.RemoveItem(target);
				return true;
			}
			else
			{
				return false;
			}
		}
		#endregion

		#region Type
		public DataObject GetData(Type type)
		{
			int length = DataList.Length;
			for(int i = 0 ; i < length ; i++)
			{
				if(DataList[i].GetType().Equals(type))
				{
					if(DataList[i] is DataObject data)
					{
						return data;
					}
				}
			}
			return null;
		}
		public DataObject AddData(Type type)
		{
			DataObject data = Activator.CreateInstance(type) as DataObject;
			AddData(data);
			return data;
		}
		#endregion

		#region CallAction OdccItem
		public void CallActionObject<T>(Action<T> tAction, Func<T, bool> condition = null) where T : class, IOdccObject
		{
			if(tAction is null) return;
			ChildObject.GetAction<T, IOdccObject>(GetAction, condition);
			void GetAction(T t)
			{
				CallingActionQueue(() => tAction.Invoke(t));
			}
		}
		public void CallActionAllObject<T>(Action<T> tAction, Func<bool> isBreak = null, Func<T, bool> condition = null) where T : class, IOdccObject
		{
			if(tAction is null) return;
			ChildObject.GetAllAction<T, IOdccObject>(GetAction, isBreak, condition);
			void GetAction(T t)
			{
				CallingActionQueue(() => tAction.Invoke(t));
			}
		}
		public void CallActionComponent<T>(Action<T> tAction, Func<T, bool> condition = null) where T : class, IOdccComponent
		{
			if(tAction is null) return;
			ComponentList.GetAction<T, IOdccComponent>(GetAction, condition);
			void GetAction(T t)
			{
				CallingActionQueue(() => tAction.Invoke(t));
			}
		}
		public void CallActionAllComponent<T>(Action<T> tAction, Func<bool> isBreak = null, Func<T, bool> condition = null) where T : class, IOdccComponent
		{
			if(tAction is null) return;
			ComponentList.GetAllAction<T, IOdccComponent>(GetAction, isBreak, condition);
			void GetAction(T t)
			{
				CallingActionQueue(() => tAction.Invoke(t));
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
				CallingActionQueue(actions);
			}
		}
		public void CallActionData<T>(Action<T> tAction, Func<T, bool> condition = null) where T : class, IOdccData
		{
			DataList.GetDataAction<T, IOdccData>(tAction, condition);
		}
		public void CallActionAllData<T>(Action<T> tAction, Func<bool> isBreak = null, Func<T, bool> condition = null) where T : class, IOdccData
		{
			DataList.GetAllDataAction<T, IOdccData>(tAction, isBreak, condition);
		}
		#endregion
	}
	internal static class WorkOdccItem
	{
		public static T Get<T, TT>(this TT[] thisList, Func<T, bool> condition = null) where T : class where TT : class, IOdccItem
		{
			int count = thisList.Length;
			for(int i = 0 ; i < count ; i++)
			{
				var item = thisList[i];
				if(item is T tt && (condition is null || condition(tt)))
				{
					return tt;
				}
			}
			return null;
		}
		public static T[] GetAll<T, TT>(this TT[] thisList, Func<T, bool> condition = null) where T : class where TT : class, IOdccItem
		{
			List<T> list = new List<T>();
			int count = thisList.Length;
			for(int i = 0 ; i < count ; i++)
			{
				var item = thisList[i];
				if(item is T tt && (condition is null || condition(tt)))
				{
					list.Add(tt);
				}
			}
			return list.ToArray();
		}
		public static T GetAll<T, TT>(this TT[] thisList, int typeID, Func<IOdccAttach, bool> condition = null) where T : class, ICollection<IOdccAttach>, new() where TT : class, IOdccAttach
		{
			T result = new T();

			// 기본 필터링 조건
			var find = thisList.Where(item =>
				(item.OdccTypeIndex == typeID || item.OdccTypeInheritanceIndex.Contains(typeID)) && (condition is null  || condition(item))
			);

			// 결과를 반환 타입 T에 추가
			foreach(var item in find)
			{
				result.Add(item);
			}

			return result;
		}


		public static T GetData<T, TT>(this TT[] thisList, Func<T, bool> condition = null) where T : class where TT : class, IOdccItem
		{
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
		public static T[] GetAllData<T, TT>(this TT[] thisList, Func<T, bool> condition = null) where T : class where TT : class, IOdccItem
		{
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
		public static T GetAllData<T, TT>(this TT[] thisList, int typeID, Func<IOdccAttach, bool> condition = null) where T : class, ICollection<IOdccAttach>, new() where TT : class, IOdccAttach
		{
			T result = new T();

			// 기본 필터링 조건
			var find = thisList.Where(item =>
				(item.OdccTypeIndex == typeID || item.OdccTypeInheritanceIndex.Contains(typeID)) && (condition is null  || condition(item))
			);

			// 결과를 반환 타입 T에 추가
			foreach(var item in find)
			{
				result.Add(item);
			}

			return result;
		}

		public static void GetAction<T, TT>(this TT[] thisList, Action<T> action, Func<T, bool> condition = null) where T : class where TT : class, IOdccItem
		{
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
