using System;

using Sirenix.OdinInspector;

using UnityEngine;

namespace BC.Base
{
	public abstract class MonoSingleton<T> : SerializedMonoBehaviour where T : MonoSingleton<T>
	{
		public bool didInit { get; private set; } = false;
		public bool didDestroy { get; private set; } = false;
		private static T instance;
		public static bool Instance(Action<T> result)
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

						instance.CreatedSingleton();
						instance.didInit = true;
						instance.didDestroy = false;
					}

					result?.Invoke(instance);
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
		public static R Instance<R>(Func<T, R> result)
		{
			R value = default;
			if(instance != null && instance.didDestroy)
			{
				Debug.LogError("MonoSingleton Is Destroy");
				return value;
			}

			if(instance == null)
			{
				instance = GameObject.FindFirstObjectByType<T>(FindObjectsInactive.Include);
				if(instance == null)
				{
					instance = SingletonPrefabDataList.This.FindTypePrefab<T>();
					if(instance == null)
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
							instance.name = $"[{typeof(T).Name}] Bace";
							DontDestroyOnLoad(instance);

						}
						else
						{
							instance.name = $"[{typeof(T).Name}] EditorOnly";
							instance.tag = "EditorOnly";
						}

						instance.CreatedSingleton();
						instance.didInit = true;
						instance.didDestroy = false;
					}

					value = result.Invoke(instance);
					return value;
				}
				catch(Exception e)
				{
					Debug.LogException(e);
					return value;
				}
			}
			else
			{
				Debug.LogError("MonoSingleton Can't Carate");
				return value;
			}
		}
		public static bool Instance<R>(out R value, Func<T, R> result)
		{
			value = default;
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
							instance.name = $"[{typeof(T).Name}] Bace";
							DontDestroyOnLoad(instance);

						}
						else
						{
							instance.name = $"[{typeof(T).Name}] EditorOnly";
							instance.tag = "EditorOnly";
						}

						instance.CreatedSingleton();
						instance.didInit = true;
						instance.didDestroy = false;
					}

					value = result.Invoke(instance);
					return true;
				}
				catch(Exception e)
				{
					Debug.LogException(e);
					return false;
				}
			}
			else
			{
				Debug.LogError("MonoSingleton Can't Carate");
				return false;
			}
		}
		public static bool Instance<R>(Func<T, R> result, out R value)
		{
			return Instance<R>(out value, result);
		}
		protected abstract void CreatedSingleton();
		protected abstract void DestroySingleton();
		private void Awake()
		{
			if(didInit) return;
			Instance(null);
		}
		private void OnDestroy()
		{
			if(instance == null || instance.didDestroy) return;
			DestroySingleton();
			instance.didInit = false;
			instance.didDestroy = true;
		}
	}

}