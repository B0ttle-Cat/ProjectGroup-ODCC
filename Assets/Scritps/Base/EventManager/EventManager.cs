using System;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

namespace BC.Base
{
	/// <summary>
	/// <see href="https://secretpms.atlassian.net/wiki/spaces/SU/pages/22741387"/>
	/// </summary>
	//[DefaultExecutionOrder(ConstInt.ODCC_MAIN_UPDATE)]
	public class EventManager : MonoSingleton<EventManager>
	{
		private static EventManager _Instance;

		public bool showLog = false;
		public bool showCallLog = false;
		private List<object> listenerList;
		private Dictionary<Type, IEnumerable<object>> cashListenerList = new Dictionary<Type, IEnumerable<object>>();
		public List<object> ManagedList {
			get {
				return listenerList;
			}
		}
		/// <summary>
		/// ODCC 매니저를 초기화하는 메서드입니다. 씬이 로드되기 전에 실행됩니다.
		/// </summary>
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		static void InitManager()
		{
			// ODCC 매니저 인스턴스를 초기화하고 로그를 출력합니다.
			EventManager.Instance(ins => {
				_Instance = ins;
			});
		}


		protected override void CreatedSingleton() => New();
		protected override void DestroySingleton() => Clear();

		[System.Diagnostics.Conditional("UNITY_EDITOR")]
		private void ShowLog(string msg)
		{
			if(!showLog) return;
			Debug.Log(msg, 5);
		}
		private void New()
		{
			listenerList ??= new List<object>();
			cashListenerList = new Dictionary<Type, IEnumerable<object>>();
		}
		private void Clear()
		{
			if(listenerList != null)
			{
				listenerList.Clear();
			}
			else
			{
				listenerList = new List<object>();
			}
			if(cashListenerList != null)
			{
				cashListenerList.Clear();
			}
			else
			{
				cashListenerList = new Dictionary<Type, IEnumerable<object>>();
			}
		}

		private void _AddEventActor(object actor)
		{
			if(actor == null || actor is EventManager || Contains(actor)) return;

			ShowLog($"AddListener {actor.GetType().Name}");
			ManagedList.Add(actor);

			var keys = cashListenerList.Keys;
			Action modify = null;
			foreach(var key in keys)
			{
				if(key.IsAssignableFrom(actor.GetType()))
				{
					if(cashListenerList.TryGetValue(key, out IEnumerable<object> actorsOfType))
					{
						var list = actorsOfType.ToList();
						list.Add(actor);
						var modifyKey = key;
						modify += () => cashListenerList[modifyKey] = list;
					}
					else
					{
						actorsOfType = new List<object> { actor };
						var modifyKey = key;
						modify += () => cashListenerList[modifyKey] = actorsOfType;
					}
				}
			}
			modify?.Invoke();
		}
		private void _RemoveEventActor(object actor)
		{
			if(actor == null || actor is EventManager) return;

			if(Contains(actor, out int findIndex))
			{
				ShowLog($"RemoveListener {actor.GetType().Name}");
				ManagedList.RemoveAt(findIndex);

				Action modify = null;
				foreach(var item in cashListenerList)
				{
					var list = item.Value.ToList();
					if(list.Remove(actor))
					{
						modify += () => cashListenerList[item.Key] = list;
					}
				}
				modify?.Invoke();
			}
		}

		private void _CallActionEvent<T>(Func<T, bool> condition, Action<T> action) where T : class
		{
			if(showCallLog)
			{
				Debug.Log($"Call<{typeof(T)}>", 5);
			}

			List<T> getList = _GetAllEventActor<T>();
			List<T> resultList = new List<T>();
			bool passCondition = condition == null;
			int count = getList.Count;
			for(int i = 0 ; i < count ; i++)
			{
				var tValue = getList[i];
				if(passCondition || condition.Invoke(tValue))
				{
					resultList.Add(tValue);
				}
			}
			count = resultList.Count;
			for(int i = 0 ; i < count ; i++)
			{
				action.Invoke(resultList[i]);
			}
		}
		private void _CallActionEvent<T, TR>(IEnumerable<T> enumerable, Action<TR> action) where T : class where TR : class
		{
			if(showCallLog)
			{
				Debug.Log($"Call<IEnumerable {typeof(T)}, {typeof(TR)}>", 5);
			}
			List<TR> resultList = new List<TR>();
			foreach(var tValue in enumerable)
			{
				if(tValue is TR trValue)
				{
					resultList.Add(trValue);
				}
			}
			int count = resultList.Count;
			for(int i = 0 ; i < count ; i++)
			{
				action.Invoke(resultList[i]);
			}
		}
		private bool _CallActionEvent<T, TR>(Func<T, bool> condition, Func<T, TR> action, out TR _result) where T : class
		{
			if(showCallLog)
			{
				Debug.Log($"Call<{typeof(T)}, {typeof(TR)}>", 5);
			}

			_result = default;
			List<T> resultList = _GetAllEventActor<T>();
			int count = resultList.Count;
			for(int i = 0 ; i < count ; i++)
			{
				var tValue = resultList[i];
				if(condition == null || condition.Invoke(tValue))
				{
					_result = action.Invoke(tValue);
					return true;
				}
			}
			return false;
		}

		private async Awaitable _AwaitCallActionEvent<T>(Func<T, bool> condition, Func<T, Awaitable> action) where T : class
		{
			if(showCallLog)
			{
				Debug.Log($"Call<{typeof(T)}>", 5);
			}

			List<T> getList = _GetAllEventActor<T>();
			List<T> resultList = new List<T>();
			bool passCondition = condition == null;
			int count = getList.Count;
			for(int i = 0 ; i < count ; i++)
			{
				var tValue = getList[i];
				if(passCondition || condition.Invoke(tValue))
				{
					resultList.Add(tValue);
				}
			}
			count = resultList.Count;
			for(int i = 0 ; i < count ; i++)
			{
				await action.Invoke(resultList[i]);
			}
		}
		private async Awaitable<(bool, TR)> _AwaitCallActionEvent<T, TR>(Func<T, bool> condition, Func<T, Awaitable<TR>> action) where T : class
		{
			if(showCallLog)
			{
				Debug.Log($"Call<{typeof(T)}, {typeof(TR)}>", 5);
			}

			TR _result = default;
			List<T> resultList = _GetAllEventActor<T>();
			int count = resultList.Count;
			for(int i = 0 ; i < count ; i++)
			{
				var tValue = resultList[i];
				if(condition == null || condition.Invoke(tValue))
				{
					_result = await action.Invoke(tValue);
					return (true, _result);
				}
			}
			return (false, _result);
		}


		private List<T> _GetAllEventActor<T>() where T : class
		{
			List<T> resultList = new List<T>();

			Type type = typeof(T);

			if(cashListenerList.TryGetValue(type, out var cachedValue))
			{
				foreach(var cache in cachedValue)
				{
					if(cache is T t)
					{
						resultList.Add(t);
					}
				}
				return resultList;
			}
			int count = listenerList.Count;
			for(int i = 0 ; i < count ; i++)
			{
				if(listenerList[i] is T find)
				{
					resultList.Add(find);
				}
			}
			cashListenerList[type] = resultList.Cast<object>();
			return resultList;
		}
		private bool _Contains(object actor)
		{
			return Contains(actor, out _);
		}
		private bool _Contains(object actor, out int findIndex)
		{
			findIndex = (actor == null) ? -1 : ManagedList.FindIndex(item => item == actor);
			return findIndex >= 0;
		}
		private bool _Contains<T>() where T : class
		{
			return ManagedList.Exists(item => item is T);
		}
		private bool _Contains<T>(out int findIndex) where T : class
		{
			findIndex = ManagedList.FindIndex(item => item is T);
			return findIndex >= 0;
		}

		public static TR Call<T, TR>(TR defaultValue, Func<T, TR> action) where T : class
		{
			if(action == null) return default;
			TR result = defaultValue;
			if(_Instance._CallActionEvent<T, TR>(null, action, out TR _result))
			{
				result = _result;
			}
			else
			{
				Debug.LogError("Call Result False");
			}
			return result;

		}
		public static TR Call<T, TR>(Func<T, TR> action, TR defaultValue = default) where T : class
		{
			if(action == null) return default;
			return Call<T, TR>(defaultValue, action);
		}
		public static void Call<T>(Action<T> action) where T : class
		{
			if(action == null) return;
			_Instance._CallActionEvent<T>(null, action);
		}
		public static void Call<T>(Func<T, bool> condition, Action<T> action) where T : class
		{
			if(action == null) return;
			_Instance._CallActionEvent<T>(condition, action);
		}
		public static void Call<T, TR>(IEnumerable<T> enumerable, Action<TR> action) where T : class where TR : class
		{
			if(action == null) return;
			_Instance._CallActionEvent<T, TR>(enumerable, action);
		}
		public static void Call<T>(Component order, Action<T> action) where T : Component
		{
			if(action == null) return;
			Call(c => c.gameObject.Equals(order.gameObject), action);
		}
		public static void Call<T>(GameObject order, Action<T> action) where T : Component
		{
			if(action == null) return;
			Call(c => c.gameObject.Equals(order), action);
		}

		public static async Awaitable<TR> Call<T, TR>(TR defaultValue, Func<T, Awaitable<TR>> action) where T : class
		{
			if(action == null) return default;
			TR result = defaultValue;
			(bool isTry, TR result) item = await _Instance._AwaitCallActionEvent<T, TR>(null, action);
			if(item.isTry)
			{
				result = item.result;
			}
			else
			{
				Debug.LogError("Call Result False");
			}
			return result;

		}
		public static async Awaitable<TR> Call<T, TR>(Func<T, Awaitable<TR>> action, TR defaultValue = default) where T : class
		{
			if(action == null) return default;
			return await Call<T, TR>(defaultValue, action);
		}
		public static async Awaitable Call<T>(Func<T, Awaitable> action) where T : class
		{
			if(action == null) return;
			await _Instance._AwaitCallActionEvent<T>(null, action);
		}
		public static async Awaitable Call<T>(Func<T, bool> condition, Func<T, Awaitable> action) where T : class
		{
			if(action == null) return;
			await _Instance._AwaitCallActionEvent<T>(condition, action);
		}
		public static async Awaitable Call<T>(Component order, Func<T, Awaitable> action) where T : Component
		{
			if(action == null) return;
			await Call(c => c.gameObject.Equals(order.gameObject), action);
		}
		public static async Awaitable Call<T>(GameObject order, Func<T, Awaitable> action) where T : Component
		{
			if(action == null) return;
			await Call(c => c.gameObject.Equals(order), action);
		}


		public static void AddListener(GameObject actor)
		{
			Component[] list = actor.GetComponents<Component>();
			Instance(Instance => {
				for(int i = 0 ; i < list.Length ; i++)
				{
					Instance._AddEventActor(list[i]);
				}
			});
		}
		public static void RemoveListener(GameObject actor)
		{
			Component[] list = actor.GetComponents<Component>();
			Instance(Instance => {
				for(int i = 0 ; i < list.Length ; i++)
				{
					Instance._RemoveEventActor(list[i]);
				}
			});
		}
		public static void AddListener(object actor)
		{
			Instance(instance => instance._AddEventActor(actor));
		}
		public static void RemoveListener(object actor)
		{
			Instance(instance => instance._RemoveEventActor(actor));
		}
		public static bool Contains(object actor)
		{
			return Instance(instance => instance._Contains(actor));
		}
		public static bool Contains(object actor, out int findIndex)
		{
			Instance<int>(Instance => {
				Instance._Contains(actor, out int _findIndex);
				return _findIndex;
			}, out findIndex);
			return findIndex >= 0;
		}
		public static bool Contains<T>() where T : class
		{
			return Instance(Instance => Instance._Contains<T>());
		}
		public static bool Contains<T>(out int findIndex) where T : class
		{
			Instance<int>(Instance => {
				Instance._Contains<T>(out int _findIndex);
				return _findIndex;
			}, out findIndex);
			return findIndex >= 0;
		}
	}
}