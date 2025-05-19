using System;
using System.IO;

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
			guid = "";
			this.asset = asset;
#endif
			resourcesPath = "";
			loadAsset = null;
#if UNITY_EDITOR
			OnValidate();
#endif
		}

#if UNITY_EDITOR
		[FoldoutGroup("@ResourcesPathGroupName"), PropertyOrder(-50)]
		[ShowInInspector, HideLabel, ReadOnly, EnableGUI, PreviewField(68, ObjectFieldAlignment.Center)]
		[HorizontalGroup("@ResourcesPathGroupName/H1", width: 68)]
		public Object preview => IsPrefabs ? AssetDatabase.LoadAssetAtPath(AssetDatabase.GetAssetPath(asset), typeof(Object)) : asset;

		[PropertyOrder(-50), ShowInInspector, HideLabel]
		[AssetList(CustomFilterMethod = "GetAssetList")]
		[VerticalGroup("@ResourcesPathGroupName/H1/V1")]
		[HorizontalGroup("@ResourcesPathGroupName/H1/V1/H2")]
		[OnValueChanged("_OnValidate")]
		private T asset {
			get;
			set;
		}


		[FoldoutGroup("@ResourcesPathGroupName/H1/V1/Detail"), PropertyOrder(-10), ShowInInspector]
		[LabelWidth(45), LabelText("GUID:"), DisplayAsString]
		private string guid;
#endif
		[FoldoutGroup("@ResourcesPathGroupName/H1/V1/Detail")]
		[LabelWidth(45), LabelText("Path:"), Multiline(2), ReadOnly, EnableGUI, DisplayAsString]
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
		private bool IsPrefabs => typeof(T).IsSubclassOf(typeof(Component)) || typeof(T).Equals(typeof(GameObject));
		private bool GetAssetList(T asset)
		{
			if (asset == null) return false;
			if (asset.name.StartsWith("_")) return false;

			string path = AssetDatabase.GetAssetPath(asset);
			if (string.IsNullOrWhiteSpace(path)) return false;
			path = path.Replace('\\', '/');

			if (path.StartsWith("Resources/")) return true;
			else if (path.Contains("/Resources/")) return true;

			return false;
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
		string AssetPathCutoutResourcesPath(string assetPath)
		{
			string keyword = "Resources";
			int stopIndex = assetPath.IndexOf(keyword);

			if (stopIndex != -1) // 문자열이 존재하는 경우
			{
				return assetPath.Substring(0, stopIndex + keyword.Length);
			}
			return assetPath;
		}
		[HorizontalGroup("@ResourcesPathGroupName/H1/V1/H2", width: 50)]
		[VerticalGroup("@ResourcesPathGroupName/H1/V1/H2/V2")]
		[Button("Update")]
		private void _OnValidate() => OnValidate();
		public void OnValidate()
		{
			if (asset == null)
			{
				if (guid.IsNotNullOrWhiteSpace())
				{
					string path = UnityEditor.AssetDatabase.GUIDToAssetPath(guid);
					resourcesPath = AssetPathConvertResourcesPath(path);
					if (resourcesPath.IsNotNullOrWhiteSpace())
					{
						asset = Resources.Load<T>(resourcesPath);
					}
				}
				else if (resourcesPath.IsNotNullOrWhiteSpace())
				{
					asset = Resources.Load<T>(resourcesPath);
					string assetPath = UnityEditor.AssetDatabase.GetAssetPath(asset);
					guid = UnityEditor.AssetDatabase.AssetPathToGUID(assetPath);
				}
			}
			else
			{
				string assetPath = UnityEditor.AssetDatabase.GetAssetPath(asset);
				guid = UnityEditor.AssetDatabase.AssetPathToGUID(assetPath);
				resourcesPath = AssetPathConvertResourcesPath(assetPath);
			}
		}

		[VerticalGroup("@ResourcesPathGroupName/H1/V1/H2/V2")]
		[Button("Clear")]
		private void Clear()
		{
			guid = "";
			asset = null;
			resourcesPath = "";
			loadAsset = null;
		}
#endif
	}
}
