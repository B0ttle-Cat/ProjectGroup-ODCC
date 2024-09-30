using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

using Sirenix.OdinInspector;
using Sirenix.Utilities;

using UnityEngine;
using UnityEngine.Networking;

using Object = UnityEngine.Object;

namespace BC.Base
{
	public partial class ResourcesManager
	{
		// �ε� ���� ����
		public enum LoadState
		{
			None = 0,
			Loading = 1,
			Success = 2,
			Error = 3,
		}

		[Serializable]
		public abstract class Loader
		{
			[UnityEngine.SerializeField, ReadOnly]
			LoadState loadState;
			[UnityEngine.SerializeField, ReadOnly]
			public Object LoadObject { get; internal set; }
			[UnityEngine.SerializeField, ReadOnly]
			private ResourcesKey resourcesKey;
			[UnityEngine.SerializeField, ReadOnly]
			private List<(object, Action<float>, Action<Object>)> connectHandler;

			public LoadState LoadState => loadState;
			public ResourcesKey ResourcesKey => resourcesKey;

			public void OnInit(ResourcesKey _resourcesKey)
			{
				connectHandler ??= new List<(object, Action<float>, Action<Object>)>();

				loadState = LoadState.None;
				LoadObject = null;
				resourcesKey = _resourcesKey;
				Init();
			}

			public IEnumerator OnDownload()
			{
				if(loadState == LoadState.Loading)
				{
					yield break;
				}

				if(loadState != LoadState.Success)
				{
					loadState = LoadState.Loading;
					LoadObject = null;
					yield return Download();
					loadState = LoadObject == null ? LoadState.Error : LoadState.Success;
				}

				while(connectHandler.Count > 0)
				{
					var handler = connectHandler[0];
					connectHandler.RemoveAt(0);
					try
					{
						handler.Item3?.Invoke(LoadObject);
					}
					catch(Exception ex)
					{
						Debug.LogException(ex);
					}
				}
			}
			public void OnClear()
			{
				Clear();
				if(connectHandler != null) connectHandler.Clear();
				loadState = LoadState.None;
				LoadObject = null;
			}

			public void AddHandler(object handler, Action<float> progress, Action<Object> result)
			{
				connectHandler ??= new List<(object, Action<float>, Action<Object>)>();
				int index = connectHandler.FindIndex(item=>item.Item1 == handler);
				if(index < 0)
				{
					connectHandler.Add((handler, progress, result));
				}
			}
			public void RemoveHandler(object handler)
			{
				if(connectHandler == null || connectHandler.Count == 0) return;

				int index = connectHandler.FindIndex(item=>item.Item1 == handler);
				if(index >= 0)
				{
					connectHandler.RemoveAt(index);
					if(connectHandler.Count == 0)
					{
						OnClear();
					}
				}
			}
			public int GetHandlerCount()
			{
				if(connectHandler == null) return -1;
				return connectHandler.Count;
			}
			protected abstract void Init();
			protected abstract IEnumerator Download();
			protected abstract void Clear();
		}

		[Serializable]
		public class AssetBundleLoader : Loader
		{
			AssetBundle LoadAssetBundle;
			protected override void Init()
			{
			}

			protected override IEnumerator Download()
			{
				string bundleName = "";// ResourcesKey.BundleName;
				string assetName = "";// ResourcesKey.FullPath;
				if(bundleLoaderLinkStack.ContainsKey(bundleName))
				{
					bundleLoaderLinkStack[bundleName]++;
				}
				else
				{
					bundleLoaderLinkStack.Add(bundleName, 1);
				}
				yield return _Download();
				if(bundleLoaderLinkStack.ContainsKey(bundleName))
				{
					bundleLoaderLinkStack[bundleName]--;
				}

				IEnumerator _Download()
				{
					if(LoadAssetBundle == null)
					{
						if(bundleLoaderLink.ContainsKey(bundleName))
						{
							while(LoadAssetBundle != null && bundleLoaderLink.ContainsKey(bundleName))
							{
								LoadAssetBundle = bundleLoaderLink[bundleName];
								yield return null;
							}
						}
						else
						{
							bundleLoaderLink.Add(bundleName, null);
							if(LoadAssetBundle == null)
							{
								Debug.Log($"Already Loaded Check");
								var loadedList =  AssetBundle.GetAllLoadedAssetBundles();
								loadedList.ForEach(loaded => {
									if(loaded.name == bundleName)
									{
										Debug.Log($"Is Already Loaded LoadAssetBundle");
										LoadAssetBundle = loaded;
									}
								});
							}
							if(LoadAssetBundle == null)
							{
								// ���� ���� ��ο� URL ��θ� �����մϴ�.
								string fullLocalPath = Path.Combine(ConstString.BundleLocalPath, bundleName);
								string fullUrlPath = Path.Combine(ConstString.BundleURLPath, bundleName);

								// ���� ������ �������� ������ ������ �ٿ�ε��մϴ�.
								if(!File.Exists(fullLocalPath))
								{
									Debug.Log($"Down LoadAssetBundle URL: {fullUrlPath}");
									// UnityWebRequest�� �����ϰ� �ش� URL�κ��� ���� �����͸� �ٿ�ε��մϴ�.
									using(UnityWebRequest www = UnityWebRequest.Get(fullUrlPath))
									{
										try
										{
											www.SendWebRequest();
										}
										catch(Exception ex)
										{
											Debug.LogException(ex);
											yield break;
										}

										// �ٿ�ε尡 �Ϸ�� ������ ���� ��Ȳ�� �����մϴ�.
										while(!www.isDone)
										{
											yield return null;
										}

										// �ٿ�ε尡 ������ ��� ���� �޽����� ����ϰ� ����� ��ȯ�մϴ�.
										if(www.result != UnityWebRequest.Result.Success)
										{
											Debug.LogError($"Failed to download LoadAssetBundle: {www.error}");
											yield break;
										}

										// �ٿ�ε��� ���� �����͸� ���� ���Ͽ� �����մϴ�.
										try
										{
											File.WriteAllBytes(fullLocalPath, www.downloadHandler.data);
											Debug.Log("LoadAssetBundle downloaded and saved.");
										}
										catch(Exception ex)
										{
											Debug.LogException(ex);
											yield break;
										}
									}
								}

								// ���� ���Ͽ��� ������ �ε��մϴ�.
								AssetBundleCreateRequest asyncBundle = null;
								try
								{
									Debug.Log($"ResourcesInstantiate LoadAssetBundle from Path: {fullLocalPath}");
									asyncBundle = AssetBundle.LoadFromFileAsync(fullLocalPath);
								}
								catch(Exception ex)
								{
									asyncBundle = null;
									Debug.LogException(ex);
								}

								// �ε��� �Ϸ�� ������ ���� ��Ȳ�� �����մϴ�.
								if(asyncBundle != null)
								{
									while(!asyncBundle.isDone)
									{
										yield return null;
									}
									LoadAssetBundle = asyncBundle.assetBundle;
									Debug.Log("LoadAssetBundle loaded successfully.");
								}
							}

							if(LoadAssetBundle == null)
							{
								bundleLoaderLink.Remove(bundleName);
							}
							else
							{
								bundleLoaderLink[bundleName] = LoadAssetBundle;
							}
						}
					}

					if(LoadAssetBundle == null || !bundleLoaderLink.ContainsKey(bundleName)) yield break;


					var asyncObject = LoadAssetBundle.LoadAssetAsync<Object>(assetName);
					yield return asyncObject;
					if(asyncObject.isDone)
					{
						LoadObject = asyncObject.asset;
						Debug.Log("Loaded Success.");
					}
					else
					{
						LoadObject = null;
						Debug.LogError("Loaded Fail.");
					}
				}
			}

			protected override void Clear()
			{
			}
		}


		[Serializable]
		public class GameObjectAssetLoader : Loader
		{
			protected override void Init()
			{
			}

			protected override IEnumerator Download()
			{
				LoadObject = ResourcesKey.ObjectAsset;
				if(LoadObject != null)
				{
					Debug.Log("Loaded Success.");
				}
				else
				{
					Debug.LogError("Loaded Fail.");
				}
				yield break;
			}

			protected override void Clear()
			{
			}
		}


		[Serializable]
		public class ResourcesAssetLoader : Loader
		{
			protected override void Init()
			{
			}

			protected override IEnumerator Download()
			{
				string assetName = "";// ResourcesKey.FullPath;

				ResourceRequest asyncObject = Resources.LoadAsync(assetName);
				yield return asyncObject;

				if(asyncObject.isDone)
				{
					LoadObject = asyncObject.asset;
					Debug.Log("Loaded Success.");
				}
				else
				{
					LoadObject = null;
					Debug.LogError("Loaded Fail.");
				}
			}

			protected override void Clear()
			{
			}
		}
	}
}
