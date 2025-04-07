using System;
using System.Collections.Generic;
using System.IO;

using Sirenix.OdinInspector;

using UnityEngine;

using Object = UnityEngine.Object;

namespace BC.Base
{
	[Serializable]
	[InlineProperty]
	[HideLabel]
	public partial struct ResourcesKey<T> : IDisposable where T : Object
	{
		public ResourcesKey(Object asset)
		{
#if UNITY_EDITOR
			rootPath = new string[0];
			guid = "";
			this.asset = asset;
			EditOption = false;
#endif
			resourcesPath = "";
			loadAsset = null;
			OnValidate();
		}
		public ResourcesKey(string[] path)
		{
#if UNITY_EDITOR
			rootPath = path;
			guid = "";
			asset = null;
			EditOption = false;
#endif
			resourcesPath = "";
			loadAsset = null;
		}

		public ResourcesKey(string path)
		{
#if UNITY_EDITOR
			rootPath = new string[1] { path };
			guid = "";
			asset = null;
			EditOption = false;
#endif
			resourcesPath = "";
			loadAsset = null;
		}
#if UNITY_EDITOR
		[FoldoutGroup("@resourcesName"), PropertyOrder(-50)]
		[ShowInInspector, HideLabel, ReadOnly, EnableGUI, PreviewField(55, ObjectFieldAlignment.Center)]
		[HorizontalGroup("@resourcesName/H1", width: 55)]
		public Object preview => asset;

		[FoldoutGroup("@resourcesName"), PropertyOrder(-50)]
		[ShowInInspector, HideLabel, ValueDropdown("GetResourcesPrefabs")]
		[HorizontalGroup("@resourcesName/H1"), VerticalGroup("@resourcesName/H1/V1")]
		[OnValueChanged("_OnValidate")]
		[InlineButton("Clear")]
		[InlineButton("_OnValidate", "Update")]
		private Object asset {
			get;
			set;
		}
		[FoldoutGroup("@resourcesName"), ToggleGroup("@resourcesName/EditOption"), PropertyOrder(-10), ShowInInspector]
		private bool EditOption { get; set; }
		[FoldoutGroup("@resourcesName"), ToggleGroup("@resourcesName/EditOption")]
		[ShowInInspector, LabelWidth(45), DisplayAsString]
		private string guid;
		[FoldoutGroup("@resourcesName"), ToggleGroup("@resourcesName/EditOption")]
		[ShowInInspector, FolderPath]
		private string[] rootPath;
#endif
		[FoldoutGroup("@resourcesName")]
		[HorizontalGroup("@resourcesName/H1"), VerticalGroup("@resourcesName/H1/V1")]
		[HideLabel, Multiline(2), ReadOnly, EnableGUI, DisplayAsString]
		public string resourcesPath;

		private T loadAsset { get; set; }

		public string resourcesName => ResourcesPathToName();
		public bool IsEmpty => string.IsNullOrWhiteSpace(resourcesPath);
		public T LoadAsset()
		{
			if(loadAsset == null)
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
			catch(Exception ex) { }
			loadAsset = null;
		}

		private string ResourcesPathToName()
		{
			if(resourcesPath == null) return "";
			int lastSlashIndex = resourcesPath.LastIndexOf('/');
			return lastSlashIndex >= 0 ? resourcesPath.Substring(lastSlashIndex + 1) : resourcesPath;

		}
#if UNITY_EDITOR
		private void Clear()
		{
			rootPath = new string[1] { "" };
			guid = "";
			asset = null;
			EditOption = false;
			resourcesPath = "";
			loadAsset = null;
		}
		private ValueDropdownList<Object> GetResourcesPrefabs()
		{
			bool isPrefabs = typeof(T).IsSubclassOf(typeof(Component)) || typeof(T).Equals(typeof(GameObject));

			ValueDropdownList<Object> list = new ValueDropdownList<Object>();
			HashSet<(string,Object)> tList = new HashSet<(string,Object)>();
			int length = rootPath == null ? 0 : rootPath.Length;
			for(int i = 0 ; i < length ; i++)
			{
				string _rootPath = rootPath[i].Replace('\\','/');

				string folderPath = AssetPathConvertResourcesPath(_rootPath);

				if(isPrefabs)
				{
					var allTAssets = Resources.LoadAll<GameObject>(folderPath);
					foreach(var tAsset in allTAssets)
					{
						string assetPath = UnityEditor.AssetDatabase.GetAssetPath(tAsset);
						assetPath = assetPath.Replace($"{_rootPath}/", "");
						assetPath = Path.ChangeExtension(assetPath, null);
						tList.Add((assetPath, tAsset));
					}
				}
				else
				{
					var allTAssets = Resources.LoadAll<T>(folderPath);
					foreach(var tAsset in allTAssets)
					{
						string assetPath = UnityEditor.AssetDatabase.GetAssetPath(tAsset);
						assetPath = assetPath.Replace($"{rootPath[i]}/", "");
						assetPath = Path.ChangeExtension(assetPath, null);
						tList.Add((assetPath, tAsset));
					}
				}
			}
			foreach(var item in tList)
			{
				if(item.Item2 is GameObject prefab)
				{
					if(typeof(T).Equals(typeof(GameObject)))
					{
						list.Add(item.Item1, item.Item2);
					}
					else if(prefab.TryGetComponent<T>(out var tComponent))
					{
						list.Add(item.Item1, item.Item2);
					}
				}
				else if(item.Item2 is T tAsset)
				{
					list.Add(item.Item1, item.Item2);
				}
			}
			return list;
		}
		string AssetPathConvertResourcesPath(string assetPath)
		{
			string keyword = "Resources";
			int stopIndex = assetPath.IndexOf(keyword) + keyword.Length;

			if(stopIndex != -1) // 문자열이 존재하는 경우
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

			if(stopIndex != -1) // 문자열이 존재하는 경우
			{
				return assetPath.Substring(0, stopIndex + keyword.Length);
			}
			return assetPath;
		}
		private void _OnValidate() => OnValidate();
		private void OnValidate()
		{
			OnValidate(null);
		}
		public void OnValidate(params string[] rootPath)
		{
			if(rootPath != null && rootPath.Length > 0)
			{
				this.rootPath = rootPath;
			}
			if(asset == null)
			{
				if(guid.IsNotNullOrWhiteSpace())
				{
					string path = UnityEditor.AssetDatabase.GUIDToAssetPath(guid);
					resourcesPath = AssetPathConvertResourcesPath(path);
					if(resourcesPath.IsNotNullOrWhiteSpace())
					{
						asset = Resources.Load<Object>(resourcesPath);
					}
				}
				else if(resourcesPath.IsNotNullOrWhiteSpace())
				{
					asset = Resources.Load<Object>(resourcesPath);
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
			if(asset != null && (rootPath == null || rootPath.Length == 0))
			{
				if(!string.IsNullOrWhiteSpace(resourcesPath))
				{
					string addPath = resourcesPath.Substring(0,resourcesPath.IndexOf("/"));
					string assetPath = UnityEditor.AssetDatabase.GetAssetPath(asset);
					rootPath = new string[1] {
						$"{AssetPathCutoutResourcesPath(assetPath)}/{addPath}"
					};
				}
			}
		}
#endif
	}

	public static class UtilResourcesKey
	{

	}
}
