using System;

using Sirenix.OdinInspector;

using UnityEngine;

using Object = UnityEngine.Object;

namespace BC.Base
{
	public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
	{
		public static bool didInit { get; private set; } = false;
		public static bool didDestroy { get; private set; } = false;
		private static T instance;
		public static bool Instance(Action<T> result)
		{
			if(instance is not null)
			{
				result?.Invoke(instance);
				return true;
			}
			else
			{
				return Instance(out bool value, (t) =>
				{
					result?.Invoke(t);
					return true;
				});
			}
		}
		public static R Instance<R>(Func<T, R> result)
		{
			return Instance(out R value, result) ? value : default;
		}
		public static bool Instance<R>(out R value, Func<T, R> result)
		{
			value = default;
			if(!Application.isPlaying) return false;
			if(Application.exitCancellationToken.IsCancellationRequested) return false;
			if(didDestroy)
			{
				//Debug.LogError("MonoSingleton Is Destroy");
				return false;
			}

			if(instance is null)
			{
				instance = GameObject.FindFirstObjectByType<T>(FindObjectsInactive.Include);
				if(instance is null)
				{
					instance = SingletonPrefabDataList.This?.FindTypePrefab<T>();
					if(instance is null)
					{
						instance = Resources.Load<T>(typeof(T).Name);
						if(instance != null)
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

			if(instance is not null)
			{
				try
				{
					if(!didInit)
					{
						didInit = true;
						didDestroy = false;

						if(Application.isPlaying)
						{
							instance.name = $"[{typeof(T).Name}] Bace";
							Object.DontDestroyOnLoad(instance.gameObject);
						}
						else
						{
							instance.name = $"[{typeof(T).Name}] EditorOnly";
							instance.tag = "EditorOnly";
						}

						if(!instance.gameObject.activeSelf)
							instance.gameObject.SetActive(true);

						instance.CreatedSingleton();
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

		}
		private void OnDestroy()
		{
			if(Application.isPlaying)
			{
				Debug.Log($"Singleton OnDestroy {gameObject.name}");
				DestroySingleton();
				didInit = true;
				didDestroy = true;
				instance = null;
			}
		}
	}

}