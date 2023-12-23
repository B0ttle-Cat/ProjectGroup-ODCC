using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Sirenix.OdinInspector;
using Sirenix.Utilities;

using UnityEngine;

using Object = UnityEngine.Object;

namespace BC.Base
{
	public enum eLoadType
	{
		Resources,
		AssetBundle,
		Asset,
	}
	[Serializable, InlineProperty, BoxGroup()]
	public struct ResourcesKey
	{
		[LabelWidth(80)]
		public eLoadType LoadType;

		[LabelWidth(80)]
		[ShowIf("@LoadType == eLoadType.AssetBundle")]
		[ValueDropdown("GetAssetBundleNames")]
		public string BundleName;

		[ShowIf("@LoadType == eLoadType.Resources||LoadType == eLoadType.AssetBundle")]
		[LabelWidth(80),ReadOnly]
		public string FullPath;

		[ShowIf("@LoadType == eLoadType.Asset")]
		[LabelWidth(80),ReadOnly]
		public GameObject AssetObject;


		public bool onDisableLoad;

		public static ResourcesKey Empty => new ResourcesKey() { LoadType = eLoadType.Resources, FullPath = "", BundleName = "" };
		public bool IsEmpty => LoadType switch
		{
			eLoadType.Resources => string.IsNullOrWhiteSpace(FullPath),
			eLoadType.AssetBundle => string.IsNullOrWhiteSpace(FullPath) || string.IsNullOrWhiteSpace(BundleName),
			eLoadType.Asset => AssetObject == null,
			_ => false,
		};


#if UNITY_EDITOR
		private void ClearInEditor()
		{
			FullPath = "";
			BundleName = "";
			AssetObject = null;
		}

		[ShowInInspector]
		[ShowIf("@LoadType == eLoadType.AssetBundle")]
		[ValueDropdown("GetAllFullPath"), HideLabel]
		[InfoBox(message: "지정된 번들에서 에셋을 찾을 수 없습니다!", visibleIfMemberName: "@CheckAssetExistence(FullPath)", infoMessageType: InfoMessageType.Error)]
		private string ShowAssetObjectPath {
			get { return FullPath; }
			set { ClearInEditor(); FullPath = value; }
		}

		private GameObject _ShowResourcesObject;
		[ShowInInspector]
		[ShowIf("@LoadType == eLoadType.Resources")]
		[HideLabel]
		[AssetSelector()]
		[InfoBox(message: "Resources 에서 해당 Object를 찾을 수 없습니다!", visibleIfMemberName: "@CheckAssetExistence(FullPath)", infoMessageType: InfoMessageType.Error)]
		private GameObject ShowResourcesObject {
			get => _ShowResourcesObject;
			set
			{
				ClearInEditor();
				_ShowResourcesObject = value;
				FullPath = ConvertToResourcesPath(FullPath, _ShowResourcesObject);
			}
		}

		[ShowInInspector]
		[ShowIf("@LoadType == eLoadType.Asset")]
		[HideLabel]
		[AssetsOnly]
		[InfoBox(message: "Null 이거나 해당 Object를 찾을 수 없습니다!", visibleIfMemberName: "@CheckAssetExistence(AssetObject)", infoMessageType: InfoMessageType.Error)]
		private GameObject ShowAssetObject {
			get => AssetObject;
			set
			{
				ClearInEditor();
				AssetObject = value;
			}
		}

		private List<string> GetAssetBundleNames()
		{
			if(UnityEditor.EditorApplication.isPlaying) return new List<string>();

			string assetBundleFolder = ConstString.BundleLocalPath;

			if(!Directory.Exists(assetBundleFolder))
			{
				Directory.CreateDirectory(assetBundleFolder);
			}


			List<string> assetBundleNames = new List<string>();

			string[] assetBundleFiles = Directory.GetFiles(assetBundleFolder, "*", SearchOption.AllDirectories)
				.Where(file => string.IsNullOrEmpty(Path.GetExtension(file)))
				.ToArray();

			foreach(string filePath in assetBundleFiles)
			{
				string fileName = Path.GetFileNameWithoutExtension(filePath);
				assetBundleNames.Add(fileName);
			}

			return assetBundleNames;
		}
		private List<string> GetAllFullPath()
		{
			if(UnityEditor.EditorApplication.isPlaying) return new List<string>();

			if(LoadType == eLoadType.Resources)
			{
				return new List<string>();
			}
			else
			{
				List<string> assetsNames = GetAllAssetObjectName(BundleName);

				if(assetsNames.Contains(FullPath))
				{

				}

				return assetsNames;
			}
		}

		List<string> GetAllAssetObjectName(string bundleName)
		{
			if(UnityEditor.EditorApplication.isPlaying) return new List<string>();
			if(string.IsNullOrWhiteSpace(bundleName)) return new List<string>();

			string fullLocalPath = Path.Combine(ConstString.BundleLocalPath, bundleName);
			if(!Directory.Exists(ConstString.BundleLocalPath))
			{
				Directory.CreateDirectory(ConstString.BundleLocalPath);
			}
			AssetBundle assetBundle = null;
			var loadedList =  AssetBundle.GetAllLoadedAssetBundles();
			loadedList.ForEach(loaded =>
			{
				if(loaded.name == bundleName)
				{
					Debug.Log($"Is Already Loaded AssetBundle");
					assetBundle = loaded;
				}
			});
			if(assetBundle == null)
			{
				assetBundle = AssetBundle.LoadFromFile(fullLocalPath);
			}
			List<string> assetsNames = new List<string>();

			if(assetBundle != null)
			{
				assetsNames.AddRange(assetBundle.GetAllAssetNames());
				assetBundle.Unload(true);
			}
			return assetsNames;
		}

		private bool CheckAssetExistence(string path)
		{
			if(UnityEditor.EditorApplication.isPlaying) return false;

			if(LoadType == eLoadType.AssetBundle && !string.IsNullOrWhiteSpace(path))
			{
				List<string> assetNames = GetAllAssetObjectName(BundleName);
				if(!assetNames.Contains(path))
				{
					return true;
				}

			}
			else if(LoadType == eLoadType.Resources && !string.IsNullOrWhiteSpace(path))
			{
				if(!Resources.Load(path))
				{
					return true;
				}
			}
			return false;
		}

		private bool CheckAssetExistence(GameObject picker)
		{
			if(UnityEditor.EditorApplication.isPlaying) return false;

			if(LoadType == eLoadType.Asset && picker == null)
			{
				return true;
			}
			return false;
		}

		private string ConvertToResourcesPath(string fullPath)
		{
			if(UnityEditor.EditorApplication.isPlaying) return fullPath;

			if(!string.IsNullOrWhiteSpace(fullPath))
			{
				string resourcesPath = "Resources/";
				int index = fullPath.IndexOf(resourcesPath);

				if(index >= 0)
				{
					string resourceNameWithExtension = fullPath.Substring(index + resourcesPath.Length);
					string resourceNameWithoutExtension = Path.GetFileNameWithoutExtension(resourceNameWithExtension);
					return resourceNameWithoutExtension;
				}
			}

			return fullPath;
		}
		private string ConvertToResourcesPath(string fullPath, GameObject pickObject)
		{
			if(UnityEditor.EditorApplication.isPlaying) return fullPath;

			if(pickObject != null)
			{
				fullPath = UnityEditor.AssetDatabase.GetAssetPath(pickObject);

				if(!string.IsNullOrWhiteSpace(fullPath))
				{
					string resourcesPath = "Resources/";
					int startIndex = fullPath.IndexOf(resourcesPath) + resourcesPath.Length;
					int lastIndex = fullPath.LastIndexOf('.');
					if(startIndex >= 0 && lastIndex < fullPath.Length && startIndex <= lastIndex)
					{
						string resourceNameWithExtension = fullPath.Substring(startIndex,lastIndex - startIndex);
						fullPath = resourceNameWithExtension;
					}
				}
			}
			else
			{
				fullPath ="";
			}

			return fullPath;
		}
#endif
	}

	public static class UtilResourcesKey
	{
		public static void AsyncInstantiate<T>(this ResourcesKey loadKey, MonoBehaviour mono, Action<float> progress, Action<T> result) where T : Object
		{
			if(loadKey.IsEmpty)
			{
				result?.Invoke(null);
				return;
			}
			if(loadKey.LoadType == eLoadType.Asset)
			{
				GameObject newObject = null;
				try
				{
					loadKey.AssetObject.SetActive(!loadKey.onDisableLoad);
					newObject = GameObject.Instantiate(loadKey.AssetObject);
				}
				catch(Exception ex)
				{
					Debug.LogException(ex);
				}
				if(newObject != null)
				{
					result?.Invoke(newObject as T);
				}
			}
			else
			{
				ResourcesManager.AsyncInstantiate(loadKey, mono, progress, result);
			}
		}
		public static void AsyncInstantiate<T>(this ResourcesKey loadKey, Action<T> result) where T : Object
		{
			AsyncInstantiate(loadKey, null, null, result);
		}
		public static void AsyncInstantiate<T>(this ResourcesKey loadKey, MonoBehaviour mono, Action<T> result) where T : Object
		{
			AsyncInstantiate(loadKey, mono, null, result);
		}
		public static void Unload(this ResourcesKey loadKey)
		{
			if(loadKey.LoadType != eLoadType.Asset)
			{
				ResourcesManager.Unload(loadKey);
			}
		}

	}
}
