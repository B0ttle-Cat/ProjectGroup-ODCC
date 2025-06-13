using System;
using System.IO;
using System.Linq;

using Sirenix.OdinInspector;

#if UNITY_EDITOR
using UnityEditor;
#endif

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
			ShowDetail = true;
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
			ShowDetail = resourcesKey.ShowDetail;
			guid = resourcesKey.guid;
			FilterPath = resourcesKey.FilterPath;
			fullPath = resourcesKey.fullPath;
			resourcesPath = resourcesKey.resourcesPath;
			loadAsset = null;
			OnValidate();
		}
#endif

#if UNITY_EDITOR
		public bool ShowDetail { get; set; }
		public bool HideDetail => !ShowDetail;
		[FoldoutGroup("@ResourcesPathGroupName", VisibleIf = "ShowDetail"), PropertyOrder(-50)]
		[ShowInInspector, HideLabel, ReadOnly, EnableGUI, PreviewField(68, ObjectFieldAlignment.Center)]
		[HorizontalGroup("@ResourcesPathGroupName/H1", width: 68)]
		public Object preview => AssetDatabase.LoadAssetAtPath(fullPath, typeof(Object));
		[FoldoutGroup("@ResourcesPathGroupName/H1/V1/Detail"), PropertyOrder(-10), ShowInInspector]
		[LabelWidth(100), LabelText("GUID:"), DisplayAsString(Overflow = false)]
		private string guid;
		[FoldoutGroup("@ResourcesPathGroupName/H1/V1/Detail"), ShowInInspector]
		[LabelWidth(100), LabelText("FullPath:"), DisplayAsString(Overflow = false)]
		private string fullPath; [FoldoutGroup("@ResourcesPathGroupName/H1/V1/Detail"), ShowInInspector]
		[LabelWidth(100), LabelText("FilterPath:"), DisplayAsString(Overflow = false)]
		private string FilterPath;
#endif
		[PropertyOrder(-20), ShowInInspector, HideLabel]
		[ValueDropdown("GetAssetList", IsUniqueList = true)]
		[VerticalGroup(VisibleIf = "HideDetail")]
		[VerticalGroup("@ResourcesPathGroupName/H1/V1")]
		[OnValueChanged("_OnValidate")]
		[InlineButton("Clear")]
		[InlineButton("_OnValidate", "Update")]
		[InlineButton("Select", ShowIf = "HideDetail")]
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

			string filter = string.IsNullOrWhiteSpace(FilterPath) ? "t:Folder Resources" : FilterPath;
			var folders = AssetDatabase.FindAssets(filter)
				.Select(AssetDatabase.GUIDToAssetPath)
				.Where(path => Path.GetFileName(path) == "Resources")
				.Distinct();

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
			for (int i = 0 ; i < length ; i++)
			{
				string resourcesPath = AssetPathConvertResourcesPath(allPaths[i]);
				string fileName = Path.GetFileName(resourcesPath);
				if (fileName.StartsWith("_")) continue;

				var asset = Resources.Load<T>(resourcesPath);
				if (asset == null) continue;
				list.Add(resourcesPath, resourcesPath);
			}
			return list;
		}

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
		private void _OnValidate()
		{
			var asset = Resources.Load<T>(resourcesPath);
			fullPath = AssetDatabase.GetAssetPath(asset);
			guid = AssetDatabase.AssetPathToGUID(fullPath);
		}
		public void OnValidate(bool showPreview)
		{
			ShowDetail = showPreview;
			OnValidate();
		}
		public void OnValidate(string filter)
		{
			FilterPath = filter;
			OnValidate();
		}
		public void OnValidate(bool showPreview, string filter)
		{
			ShowDetail = showPreview;
			FilterPath = filter;
			OnValidate();
		}
		public void OnValidate()
		{
			if (!string.IsNullOrWhiteSpace(fullPath))
			{
				if (AssetDatabase.AssetPathExists(fullPath))
				{
					var asset = AssetDatabase.LoadAssetAtPath<T>(fullPath);
					if (asset != null)
					{
						var tempResourcesPath = AssetPathConvertResourcesPath(fullPath);
						if (!string.IsNullOrWhiteSpace(tempResourcesPath))
						{
							Object tempLoad = Resources.Load(tempResourcesPath);
							if (tempLoad != null)
							{
								resourcesPath = tempResourcesPath;
								guid = AssetDatabase.AssetPathToGUID(fullPath);
								return;
							}
						}
					}
				}
			}

			if (!string.IsNullOrWhiteSpace(guid))
			{
				var tempFullPath = AssetDatabase.GUIDToAssetPath(guid);
				if (AssetDatabase.AssetPathExists(tempFullPath))
				{
					var tempResourcesPath = AssetPathConvertResourcesPath(tempFullPath);
					if (!string.IsNullOrWhiteSpace(tempResourcesPath))
					{
						Object tempLoad = Resources.Load(tempResourcesPath);
						if (tempLoad != null)
						{
							resourcesPath = tempResourcesPath;
							fullPath = tempFullPath;
							return;
						}
					}
				}
			}

			if (!string.IsNullOrWhiteSpace(resourcesPath))
			{
				Object tempLoad = Resources.Load(resourcesPath);
				if (tempLoad != null)
				{
					fullPath = AssetDatabase.GetAssetPath(tempLoad);
					guid = AssetDatabase.AssetPathToGUID(fullPath);
					return;
				}
			}
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
		private void Select()
		{
			EditorGUIUtility.PingObject(preview);
		}

		public object Log() => throw new NotImplementedException();
#endif
	}
}
