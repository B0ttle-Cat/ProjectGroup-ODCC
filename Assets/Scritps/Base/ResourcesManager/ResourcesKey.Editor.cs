#if UNITY_EDITOR

using System;
using System.Collections.Generic;
using System.IO;

using Sirenix.OdinInspector;
using Sirenix.Utilities;

using UnityEngine;

using Object = UnityEngine.Object;

namespace BC.Base
{
	public partial struct ResourcesKey//Editor
	{
		[ShowInInspector, PropertyOrder(-10), HorizontalGroup("InEdite", width: 0.3f), LabelWidth(80)]
		private bool enableEdit { get; set; }


		[ShowInInspector, PropertyOrder(-10), HorizontalGroup("InEdite"), LabelWidth(40)]
		private Object target { get; set; }

		[ShowInInspector, PropertyOrder(-10), LabelWidth(80)]
		[ShowIf("@!EnableEdit&&ShowBundleName&&target!=null")]
		[ValueDropdown("GetPathInBundle"), HideLabel]
		private string TargetPathInBundle { get; set; }

		private bool UpdateError { get; set; }

		[HorizontalGroup("Button"), PropertyOrder(-9)]
		[Button("Update Target")]
		private void UpdateSetupTarget()
		{
			if(UnityEditor.EditorApplication.isPlaying) return;
			if(LoadType == eResourcesLoadType.None) return;
			if(target == null) return;

			UpdateError = true;
			string _BundleName = "";
			string _FullPath = "";
			Object _ObjectAsset = null;

			try
			{
				if(LoadType == eResourcesLoadType.ObjectAsset)
				{
					_ObjectAsset = target;
				}
				else if(LoadType == eResourcesLoadType.ResourcesLoad)
				{
					string assetPath = UnityEditor.AssetDatabase.GetAssetPath(target);
					string resourcePath = GetResourcePath(assetPath);
					if(string.IsNullOrWhiteSpace(resourcePath))
					{
						return;
					}

					Object loadedObject = Resources.Load(resourcePath);
					if(loadedObject != null)
					{
						_FullPath = resourcePath;
					}
					else
					{
						return;
					}
				}
				else if(LoadType == eResourcesLoadType.AssetBundle)
				{
					var list = GetPathInBundle();
					if(list.Count == 0)
					{
						return;
					}
					if(string.IsNullOrWhiteSpace(TargetPathInBundle))
					{
						return;
					}
					_BundleName = target.name;
					_FullPath = TargetPathInBundle;
				}


				ClearSetupTarget();
				BundleName  = _BundleName;
				FullPath    = _FullPath;
				ObjectAsset = _ObjectAsset;
			}
			catch(Exception ex)
			{
				Debug.LogException(ex);
			}
		}
		[HorizontalGroup("Button"), PropertyOrder(-9)]
		[Button("Clear Target")]
		private void ClearSetupTarget()
		{
			UpdateError = false;
			BundleName = "";
			FullPath = "";
			ObjectAsset = null;
		}


		private bool EnableEdit => enableEdit && LoadType != eResourcesLoadType.None;
		private bool ShowBundleName => EnableEdit || LoadType == eResourcesLoadType.AssetBundle;
		private bool ShowFullPath => EnableEdit || LoadType == eResourcesLoadType.AssetBundle || LoadType == eResourcesLoadType.ResourcesLoad;
		private bool ShowObjectAsset => EnableEdit || LoadType == eResourcesLoadType.ObjectAsset;


		private bool EnableBundleName => EnableEdit;
		private bool EnableFullPath => EnableEdit;
		private bool EnableObjectAsset => EnableEdit;

		string GetResourcePath(string assetPath)
		{
			// 리소스 폴더 내의 상대 경로 가져오기
			int index = assetPath.IndexOf("Resources/");

			if(index != -1)
			{
				string path = assetPath.Substring(index + "Resources/".Length);
				// 확장자 제거
				path = path.Substring(0, path.LastIndexOf('.'));
				return path;
			}
			else
			{
				Debug.LogError("Object is not in the Resources folder.");
				return null;
			}
		}
		private List<string> GetPathInBundle()
		{
			if(target == null || LoadType != eResourcesLoadType.AssetBundle) return new List<string>();
			string assetName = target.name;

			List<string> assetsNames = new List<string>();

			try
			{
				string fullLocalPath = Path.Combine(ConstString.BundleLocalPath, assetName);
				if(!Directory.Exists(ConstString.BundleLocalPath))
				{
					Directory.CreateDirectory(ConstString.BundleLocalPath);
				}
				AssetBundle assetBundle = null;
				var loadedList =  AssetBundle.GetAllLoadedAssetBundles();
				loadedList.ForEach(loaded =>
				{
					if(loaded.name == assetName)
					{
						assetBundle = loaded;
					}
				});
				if(assetBundle == null)
				{
					assetBundle = AssetBundle.LoadFromFile(fullLocalPath);
				}
				if(assetBundle != null)
				{
					assetsNames.AddRange(assetBundle.GetAllAssetNames());
					assetBundle.Unload(true);
				}
			}
			catch(Exception ex)
			{
				Debug.LogException(ex);
			}
			return assetsNames;
		}



		private const string Fail_CheckResourcesKey = "지정된 에셋을 찾을 수 없습니다!";
		private bool ShowErrorCheckResourcesKey()
		{
			if(UpdateError) return true;

			Object load = null;
			try
			{

				if(LoadType == eResourcesLoadType.None)
				{
					load = null;
				}
				else if(LoadType == eResourcesLoadType.ObjectAsset)
				{
					load =  ObjectAsset;
				}
				else if(LoadType == eResourcesLoadType.ResourcesLoad)
				{
					load = Resources.Load(FullPath);
				}
				else if(LoadType == eResourcesLoadType.AssetBundle)
				{
					string BundleName = this.BundleName;
					if(!BundleName.IsNullOrWhiteSpace())
					{
						string fullLocalPath = Path.Combine(ConstString.BundleLocalPath, BundleName);
						AssetBundle assetBundle = null;
						List<string> assetsNames = new List<string>();

						var loadedList =  AssetBundle.GetAllLoadedAssetBundles();
						loadedList.ForEach(loaded =>
						{
							if(loaded.name == BundleName)
							{
								assetBundle = loaded;
							}
						});
						if(assetBundle == null)
						{
							assetBundle = AssetBundle.LoadFromFile(fullLocalPath);
						}
						if(assetBundle != null)
						{
							load = assetBundle.LoadAsset(FullPath);
							assetBundle.Unload(true);
						}
					}
				}
			}
			catch(Exception ex)
			{
				load = null;
				Debug.LogException(ex);
			}

			return load == null;
		}
	}
}

#endif