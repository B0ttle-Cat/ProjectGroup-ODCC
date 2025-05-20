using System;
using System.IO;
using System.Linq;

using Sirenix.OdinInspector;

using UnityEditor;

using UnityEngine;

using Object = UnityEngine.Object;

namespace BC.Base
{
	[Serializable]
	[InlineProperty]
	[HideLabel]
	public partial struct ResourcesKey<T> : IDisposable where T : Object
	{
		public ResourcesKey(T asset)
		{
#if UNITY_EDITOR
			ShowPreview = true;
			guid = "";
			fullPath = "";
			FilterPath = "";
#endif
			resourcesPath = "";
			loadAsset = null;
#if UNITY_EDITOR
			OnValidate();
#endif
		}
#if UNITY_EDITOR
		public ResourcesKey(ResourcesKey<T> resourcesKey)
		{
			ShowPreview = resourcesKey.ShowPreview;
			guid = resourcesKey.guid;
			FilterPath = resourcesKey.FilterPath;
			fullPath = "";
			resourcesPath = "";
			loadAsset = null;
			OnValidate();
		}
#endif

#if UNITY_EDITOR
		public bool ShowPreview { get; set; }
		public bool HidePreview => !ShowPreview;
		[FoldoutGroup("@ResourcesPathGroupName", VisibleIf = "ShowPreview"), PropertyOrder(-50)]
		[ShowInInspector, HideLabel, ReadOnly, EnableGUI, PreviewField(68, ObjectFieldAlignment.Center)]
		[HorizontalGroup("@ResourcesPathGroupName/H1", width: 68)]
		public Object preview => AssetDatabase.LoadAssetAtPath(fullPath, typeof(Object));

		//[PropertyOrder(-50), ShowInInspector, HideLabel]
		////[AssetList(CustomFilterMethod = "GetAssetList")]
		//[ValueDropdown("GetAssetList", IsUniqueList = true)]
		//[VerticalGroup(VisibleIf = "HidePreview")]
		//[VerticalGroup("@ResourcesPathGroupName/H1/V1")]
		//[OnValueChanged("_OnValidate")]
		//[InlineButton("Clear")]
		//[InlineButton("_OnValidate", "Update")]
		//private T asset {
		//	get;
		//	set;
		//}

		[FoldoutGroup("@ResourcesPathGroupName/H1/V1/Detail"), PropertyOrder(-10), ShowInInspector]
		[LabelWidth(100), LabelText("GUID:"), DisplayAsString(Overflow = false)]
		private string guid;
		[FoldoutGroup("@ResourcesPathGroupName/H1/V1/Detail"), ShowInInspector]
		[LabelWidth(100), LabelText("FullPath:"), DisplayAsString(Overflow = false)]
		private string fullPath; [FoldoutGroup("@ResourcesPathGroupName/H1/V1/Detail"), ShowInInspector]
		[LabelWidth(100), LabelText("FilterPath:"), DisplayAsString(Overflow = false)]
		private string FilterPath;
#endif
		//[FoldoutGroup("@ResourcesPathGroupName/H1/V1/Detail")]
		//[LabelWidth(100), LabelText("ResourcesPath:"), DisplayAsString(Overflow = false)]
		[PropertyOrder(-20), ShowInInspector, HideLabel]
		//[AssetList(CustomFilterMethod = "GetAssetList")]
		[ValueDropdown("GetAssetList", IsUniqueList = true)]
		[VerticalGroup(VisibleIf = "HidePreview")]
		[VerticalGroup("@ResourcesPathGroupName/H1/V1")]
		[OnValueChanged("_OnValidate")]
		[InlineButton("Clear")]
		[InlineButton("_OnValidate", "Update")]
		public string resourcesPath;

		private T loadAsset { get; set; }

		public string resourcesName => ResourcesToName();
		public bool IsEmpty => string.IsNullOrWhiteSpace(resourcesPath);
		public T LoadAsset()
		{
			if (loadAsset == null)
				loadAsset = Resources.Load<T>(resourcesPath);
			return loadAsset;
		}
		public void UnloadAsset()
		{
			loadAsset = null;
		}
		public void Dispose()
		{
			try
			{
				Resources.UnloadAsset(loadAsset);
			}
			catch (Exception ex) { }
			loadAsset = null;
		}
		private string ResourcesToName()
		{
			if (resourcesPath == null) return $"Null ({typeof(T).FullName})";
			int lastSlashIndex = resourcesPath.LastIndexOf('/');
			string path = lastSlashIndex >= 0 ? resourcesPath.Substring(lastSlashIndex + 1) : resourcesPath;
			return string.IsNullOrWhiteSpace(path) ? $"Null ({typeof(T).FullName})" : path;
		}
#if UNITY_EDITOR
		private string ResourcesPathGroupName => string.IsNullOrWhiteSpace(resourcesPath) ? $"Null ({typeof(T).FullName})" : resourcesPath;
		private bool IsPrefabs => IsComponent || IsGameObject;

		private bool IsScriptable => typeof(T).IsSubclassOf(typeof(ScriptableObject));
		private bool IsComponent => typeof(T).IsSubclassOf(typeof(Component));
		private bool IsGameObject => typeof(T).IsSubclassOf(typeof(GameObject));
		private ValueDropdownList<string> GetAssetList()
		{
			ValueDropdownList<string> list = new ValueDropdownList<string>();

			var folders = string.IsNullOrWhiteSpace(FilterPath) ? AssetDatabase.FindAssets("t:Folder Resources")
				.Select(AssetDatabase.GUIDToAssetPath)
				.Where(path => Path.GetFileName(path) == "Resources")
				.Distinct()
				: new string[1] { FilterPath };

			string[] allPaths = null;
			if (IsPrefabs)
			{
				allPaths = AssetDatabase.FindAssets("t: Prefab", folders.ToArray()).Select(AssetDatabase.GUIDToAssetPath).ToArray();
			}
			else
			{
				allPaths = AssetDatabase.FindAssets($"t: {typeof(T).Name}", folders.ToArray()).Select(AssetDatabase.GUIDToAssetPath).ToArray();
			}
			int length = allPaths.Length;
			for (int i = 0; i < length; i++)
			{
				string resourcesPath = AssetPathConvertResourcesPath(allPaths[i]);
				string fileName = Path.GetFileName(resourcesPath);
				if (fileName.StartsWith("_")) continue;

				var asset = Resources.Load<T>(resourcesPath);
				if (asset == null) continue;
				list.Add(resourcesPath, resourcesPath);
			}


			//var finds = Resources.FindObjectsOfTypeAll<T>();
			//int length = finds.Length;
			//for (int i = 0; i < length; i++)
			//{
			//	var asset = finds[i];
			//	if (asset.name.StartsWith("_")) continue;

			//	string path = AssetDatabase.GetAssetPath(asset);
			//	if (string.IsNullOrWhiteSpace(path)) continue;
			//	path = AssetPathConvertResourcesPath(path);

			//	list.Add(path, asset);
			//}

			return list;
		}
		//private bool GetAssetList(T asset)
		//{
		//	if (asset == null) return false;
		//	if (asset.name.StartsWith("_")) return false;

		//	string path = AssetDatabase.GetAssetPath(asset);
		//	if (string.IsNullOrWhiteSpace(path)) return false;
		//	path = path.Replace('\\', '/');

		//	if (path.StartsWith("Resources/")) return true;
		//	else if (path.Contains("/Resources/")) return true;

		//	return false;
		//}
		string AssetPathConvertResourcesPath(string assetPath)
		{
			string keyword = "Resources";
			int stopIndex = assetPath.IndexOf(keyword) + keyword.Length;

			if (stopIndex != -1) // 문자열이 존재하는 경우
			{
				assetPath = assetPath.Substring(stopIndex).TrimStart('\\', '/');
				assetPath = Path.ChangeExtension(assetPath, null);
			}
			return assetPath;
		}
		//[HorizontalGroup("@ResourcesPathGroupName/H1/V1/H2", width: 50)]
		//[VerticalGroup("@ResourcesPathGroupName/H1/V1/H2/V2")]
		//[Button("Update")]
		private void _OnValidate()
		{
			var asset = Resources.Load<T>(resourcesPath);
			fullPath = UnityEditor.AssetDatabase.GetAssetPath(asset);
			guid = UnityEditor.AssetDatabase.AssetPathToGUID(fullPath);
		}
		public void OnValidate(bool showPreview)
		{
			ShowPreview = showPreview;
			OnValidate();
		}
		public void OnValidate(string filter)
		{
			FilterPath = filter;
			OnValidate();
		}
		public void OnValidate(bool showPreview, string filter)
		{
			ShowPreview = showPreview;
			FilterPath = filter;
			OnValidate();
		}
		public void OnValidate()
		{
			//if (asset == null)
			{
				if (guid.IsNotNullOrWhiteSpace())
				{
					fullPath = UnityEditor.AssetDatabase.GUIDToAssetPath(guid);
					resourcesPath = AssetPathConvertResourcesPath(fullPath);
					if (resourcesPath.IsNotNullOrWhiteSpace())
					{
						//		asset = Resources.Load<T>(resourcesPath);
					}
				}
				else if (resourcesPath.IsNotNullOrWhiteSpace())
				{
					var asset = Resources.Load<T>(resourcesPath);
					fullPath = UnityEditor.AssetDatabase.GetAssetPath(asset);
					guid = UnityEditor.AssetDatabase.AssetPathToGUID(fullPath);
				}
			}
			//else
			//{
			//	fullPath = UnityEditor.AssetDatabase.GetAssetPath(asset);
			//	guid = UnityEditor.AssetDatabase.AssetPathToGUID(fullPath);
			//	resourcesPath = AssetPathConvertResourcesPath(fullPath);
			//}
		}

		//[VerticalGroup("@ResourcesPathGroupName/H1/V1/H2/V2")]
		//[Button("Clear")]
		private void Clear()
		{
			guid = "";
			FilterPath = "";
			resourcesPath = "";
			fullPath = "";
			loadAsset = null;
		}
#endif
	}
}
