using System;
using System.Collections.Generic;

using Sirenix.OdinInspector;

using UnityEngine;

using Object = UnityEngine.Object;

namespace BC.Base
{
	public partial class ResourcesManager : MonoSingleton<ResourcesManager>
	{
		[ShowInInspector, ReadOnly]
		private static List<Loader> resourcesLoader = new List<Loader>();

		private static Dictionary<string, AssetBundle> bundleLoaderLink = new Dictionary<string, AssetBundle>();
		private static Dictionary<string, int> bundleLoaderLinkStack = new Dictionary<string, int>();
		private List<string> removeList = new List<string>();
		public static void AsyncInstantiate<T>(ResourcesKey loadKey, MonoBehaviour mono, Action<float> progress, Action<T> result) where T : Object
		{
			if(mono == null)
			{
				Debug.LogError("AsyncInstantiate : Mono Is Null");
				return;
			}

			Loader loader = null;
			int index = resourcesLoader.FindIndex(item => item.ResourcesKey.Equals(loadKey));
			if(index < 0)
			{
				loader = CreateLoader(loadKey.LoadType);
				if(loader != null)
				{
					index = resourcesLoader.Count;
					loader.OnInit(loadKey);
					resourcesLoader.Add(loader);
				}
				else
				{
					Debug.LogError("AsyncInstantiate : Can Not Create Loader");
					return;
				}
			}
			loader = resourcesLoader[index];
			loader.AddHandler(mono, progress, (obj) =>
			{
				try
				{
					if(obj != null && obj is T t)
					{
						if(t is GameObject gameObject)
						{
							gameObject.SetActive(false);
						}
						var newObject = Instantiate(t);
						newObject.name = obj.name;

						result.Invoke(newObject);
					}
					else
					{
						Debug.LogError("obj Is Null null || obj is not T");
					}
				}
				catch(Exception ex)
				{
					Debug.LogException(ex);
				}
				loader.RemoveHandler(mono);
			});

			Instance((i) =>
			{
				i.StartCoroutine(loader.OnDownload());
			});
		}
		public static void Unload(ResourcesKey loadKey, MonoBehaviour mono)
		{
			if(mono == null)
			{
				Debug.LogError("AsyncInstantiate : Mono Is Null");
				return;
			}

			Loader loader = null;
			int index = resourcesLoader.FindIndex(item => item.ResourcesKey.Equals(loadKey));
			if(index >= 0)
			{
				loader = resourcesLoader[index];
				loader.RemoveHandler(mono);
			}
		}



		private static Loader CreateLoader(eResourcesLoadType loadType)
		{
			return loadType switch
			{
				eResourcesLoadType.ResourcesLoad => new ResourcesAssetLoader(),
				eResourcesLoadType.AssetBundle => new AssetBundleLoader(),
				eResourcesLoadType.ObjectAsset => new GameObjectAssetLoader(),
				_ => null,
			};
		}



		private void LateUpdate()
		{
			for(int i = 0 ; i < resourcesLoader.Count ; i++)
			{
				var loader = resourcesLoader[i];
				if(loader.GetHandlerCount() == 0)
				{
					resourcesLoader.RemoveAt(i--);
					loader.OnClear();
				}
			}


			bool isRemove = false;
			foreach(var stack in bundleLoaderLinkStack)
			{
				if(stack.Value <= 0)
				{
					if(!isRemove)
					{
						removeList.Clear();
					}
					isRemove = true;
					removeList.Add(stack.Key);
				}
			}
			if(isRemove)
			{
				int count = removeList.Count;
				for(int i = 0 ; i < count ; i++)
				{
					string removeKey = removeList[i];
					bundleLoaderLinkStack.Remove(removeKey);
					bundleLoaderLink.Remove(removeKey);
				}
			}
		}
	}
}
