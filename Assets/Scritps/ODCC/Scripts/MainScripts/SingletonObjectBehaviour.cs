using System;

using BC.Base;

using UnityEngine;

using Debug = BC.Base.Debug;

namespace BC.ODCC
{
	public abstract class SingletonObjectBehaviour<T> : ObjectBehaviour where T : SingletonObjectBehaviour<T>
	{
		public bool didInit { get; private set; } = false;
		public bool didDestroy { get; private set; } = false;
		private static T instance;
		private static bool _Instance<R>(Action<T> _action)
		{
			if(instance != null && instance.didDestroy)
			{
				Debug.LogError("MonoSingleton Is Destroy");
				return false;
			}

			if(instance == null)
			{
				instance = GameObject.FindFirstObjectByType<T>(FindObjectsInactive.Include);
				if(instance == null)
				{
					instance = SingletonPrefabDataList.This.FindTypePrefab<T>();
					if(instance == null)
					{
						instance = Resources.Load<T>(typeof(T).Name);
						if(instance == null)
						{
							instance = Resources.Load<T>($"[{typeof(T).Name}]");
						}
					}

					if(instance != null)
					{
						instance = GameObject.Instantiate<T>(instance);
					}
					else
					{
						GameObject newObj = new GameObject();
						instance = newObj.AddComponent<T>();
					}
				}
			}

			if(instance != null)
			{
				try
				{
					if(!instance.didInit)
					{

						if(instance.gameObject.activeSelf)
							instance.gameObject.SetActive(true);

						if(Application.isPlaying)
						{
							instance.name = $"[{typeof(T).Name}]";
							DontDestroyOnLoad(instance);
						}
						else
						{
							instance.name = $"[{typeof(T).Name}] EditorOnly";
							instance.tag = "EditorOnly";
						}

						instance.didInit = true;
						instance.didDestroy = false;
						instance.CreatedSingleton();
						instance.OdccAwake();
					}

					try
					{
						_action.Invoke(instance);
					}
					catch(Exception e)
					{
						Debug.LogException(e);
					}
				}
				catch(Exception e)
				{
					Debug.LogException(e);
					return false;
				}
				return true;
			}
			else
			{
				Debug.LogError("MonoSingleton Can't Carate");
				return false;
			}
		}

		public static bool Instance(Action<T> result)
		{
			return _Instance<T>((ins) => result?.Invoke(ins));
		}
		public static bool Instance<R>(out R value, Func<T, R> result) where R : class
		{
			R _value = null;
			bool end = _Instance<T>((ins) => _value = (result == null ? default : result.Invoke(ins)));

			value = _value;
			return _value != null;
		}
		public static bool Instance<R>(Func<T, R> result, out R value) where R : class
		{
			return Instance<R>(out value, result);
		}
		protected abstract void CreatedSingleton();
		protected abstract void DestroySingleton();
		protected override void Awake()
		{
			base.Awake();
			if(instance == null) Instance((_) => { });
		}

		protected override void OnDestroy()
		{
			if(instance == null || instance.didDestroy) return;
			DestroySingleton();
			instance.didInit = false;
			instance.didDestroy = true;
			base.OnDestroy();
		}
	}
}
