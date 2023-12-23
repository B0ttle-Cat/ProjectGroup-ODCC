using System;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

namespace BC.Base
{
	[DefaultExecutionOrder(ConstInt.FirstExecutionOrder)]
	public class EventManager : MonoSingleton<EventManager>
	{
		public bool showLog;
		private List<Component> listenerList;
		private Dictionary<Type, List<object>> cashListenerList;
		public List<Component> Managedlist
		{
			get
			{
				return listenerList;
			}
		}

		protected override void CreatedSingleton() => New();
		protected override void DestroySingleton() => Clear();

		[System.Diagnostics.Conditional("UNITY_EDITOR")]
		private void ShowLog(string msg)
		{
			if (!showLog) return;
			Debug.Log(msg);
		}
		private void New()
		{
			listenerList ??= new List<Component>();
			cashListenerList = new Dictionary<Type, List<object>>();
		}
		private void Clear()
		{
			if (listenerList != null)
			{
				listenerList.Clear();
			}
			else
			{
				listenerList = new List<Component>();
			}
			if (cashListenerList != null)
			{
				cashListenerList.Clear();
			}
			else
			{
				cashListenerList = new Dictionary<Type, List<object>>();
			}
		}

		private void _AddEventActor(Component actor)
		{
			if (actor == null || Contains(actor)) return;
			if (actor == this) return;

			ShowLog($"AddListener {actor.GetType().Name}");
			Managedlist.Add(actor);

			var keys = cashListenerList.Keys;
			foreach (var key in keys)
			{
				if (key.IsAssignableFrom(actor.GetType()))
				{
					if (cashListenerList.TryGetValue(key, out List<object> actorsOfType))
					{
						actorsOfType.Add(actor);
					}
					else
					{
						actorsOfType = new List<object> { actor };
						cashListenerList[key] = actorsOfType;
					}
				}
			}
		}
		private void _RemoveEventActor(Component actor)
		{
			if (actor == null) return;
			if (actor == this) return;

			if (Contains(actor, out int findIndex))
			{
				ShowLog($"RemoveListener {actor.GetType().Name}");
				Managedlist.RemoveAt(findIndex);

				foreach (var item in cashListenerList)
				{
					var list = item.Value;
					list.Remove(actor);
				}
			}
		}
		private void _CallActionEvent<T>(Func<T, bool> condition, Action<T> action) where T : class
		{
			if (action == null) return;

			List<T> getList = _GetAllEventActor<T>();
			List<T> resultList = new List<T>();
			for (int i = 0; i < getList.Count; i++)
			{
				var tValue = getList[i];
				if (condition == null || condition.Invoke(tValue))
				{
					resultList.Add(tValue);
				}
			}
			for (int i = 0; i < resultList.Count; i++)
			{
				action.Invoke(resultList[i]);
			}
		}
		private void _CallActionEvent<T, TR>(IEnumerable<T> enumerable, Action<TR> action) where T : class where TR : class
		{
			if (action == null) return;

			List<TR> resultList = new List<TR>();
			foreach (var tValue in enumerable)
			{
				if (tValue is TR trValue)
				{
					resultList.Add(trValue);
				}
			}
			for (int i = 0; i < resultList.Count; i++)
			{
				action.Invoke(resultList[i]);
			}
		}

		private T _GetEventActor<T>() where T : class
		{
			Type type = typeof(T);
			cashListenerList ??= new Dictionary<Type, List<object>>();
			if (cashListenerList.TryGetValue(type, out var cachedValue))
			{
				List<object> actorsOfType = cachedValue as List<object>;
				if (actorsOfType.Count > 0)
				{
					return actorsOfType[0] as T;
				}
			}
			for (int i = 0; i < listenerList.Count; i++)
			{
				if (listenerList[i].TryGetComponent<T>(out var find))
				{
					if (!cashListenerList.TryGetValue(type, out var newCache))
					{
						newCache = new List<object>();
						cashListenerList[type] = newCache;
					}

					newCache.Add(find);
					return find;
				}
			}
			return null;
		}
		private List<T> _GetAllEventActor<T>() where T : class
		{
			Type type = typeof(T);
			cashListenerList ??= new Dictionary<Type, List<object>>();
			if (cashListenerList.TryGetValue(type, out var cachedValue))
			{
				return cachedValue.Cast<T>().ToList();
			}
			List<T> resultList = new List<T>();
			for (int i = 0; i < listenerList.Count; i++)
			{
				if (listenerList[i].TryGetComponent<T>(out var find))
				{
					resultList.Add(find);
				}
			}
			cashListenerList[type] = resultList.Cast<object>().ToList();
			return resultList;
		}

		private bool _CallActionEvent<T, TR>(Func<T, bool> condition, Func<T, TR> action, out TR _result) where T : class
		{
			_result = default;
			if (action == null) return false;

			List<T> resultList = _GetAllEventActor<T>();
			for (int i = 0; i < resultList.Count; i++)
			{
				var tValue = resultList[i];
				if (condition == null || condition.Invoke(tValue))
				{
					_result = action.Invoke(tValue);
					return true;
				}
			}
			return false;
		}

		private bool _Contains(Component actor)
		{
			return Contains(actor, out _);
		}
		private bool _Contains(Component actor, out int findIndex)
		{
			findIndex = (actor == null) ? -1 : Managedlist.FindIndex(item => item == actor);
			return findIndex >= 0;
		}
		private bool _Contains<T>() where T : class
		{
			return Managedlist.Exists(item => item is T);
		}
		private bool _Contains<T>(out int findIndex) where T : class
		{
			findIndex = Managedlist.FindIndex(item => item is T);
			return findIndex >= 0;
		}

		public static TR Call<T, TR>(TR defaultValue, Func<T, TR> action) where T : class
		{
			TR result = defaultValue;
			Instance(Instance =>
			{
				if (Instance._CallActionEvent<T, TR>(null, action, out TR _result))
				{
					result = _result;
				}
				else
				{
					Debug.LogError("Call Result False");
				}
			});
			return result;

		}
		public static TR Call<T, TR>(Func<T, TR> action, TR defaultValue = default) where T : class
		{
			return Call<T, TR>(defaultValue, action);
		}
		public static void Call<T>(Action<T> action) where T : class
		{
			Instance(Instance => Instance._CallActionEvent<T>(null, action));
		}
		public static void Call<T>(Func<T, bool> condition, Action<T> action) where T : class
		{
			Instance(Instance => Instance._CallActionEvent<T>(condition, action));
		}
		public static void Call<T, TR>(IEnumerable<T> enumerable, Action<TR> action) where T : class where TR : class
		{
			Instance(Instance => Instance._CallActionEvent<T, TR>(enumerable, action));
		}
		public static void Call<T>(Component order, Action<T> action) where T : Component
		{
			Call(c => c.gameObject.Equals(order.gameObject), action);
		}
		public static void Call<T>(GameObject order, Action<T> action) where T : Component
		{
			Call(c => c.gameObject.Equals(order), action);
		}
		public static void AddListener(GameObject actor)
		{
			Component[] list = actor.GetComponents<Component>();
			for (int i = 0; i < list.Length; i++)
			{
				Instance(Instance => Instance._AddEventActor(list[i]));
			}
		}
		public static void RemoveListener(GameObject actor)
		{
			Component[] list = actor.GetComponents<Component>();
			for (int i = 0; i < list.Length; i++)
			{
				Instance(Instance => Instance._RemoveEventActor(list[i]));
			}
		}
		public static void AddListener(Component actor)
		{
			Instance(instance => instance._AddEventActor(actor));
		}
		public static void RemoveListener(Component actor)
		{
			Instance(instance => instance._RemoveEventActor(actor));
		}
		public static bool Contains(Component actor)
		{
			return Instance(instance => instance._Contains(actor));
		}
		public static bool Contains(Component actor, out int findIndex)
		{
			Instance<int>(Instance =>
			{
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
			Instance<int>(Instance =>
			{
				Instance._Contains<T>(out int _findIndex);
				return _findIndex;
			}, out findIndex);
			return findIndex >= 0;
		}
	}
}