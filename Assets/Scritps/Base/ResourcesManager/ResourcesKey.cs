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
		[BoxGroup("Resources", LabelText = "@resourcesName"), PropertyOrder(-50)]
		[ShowInInspector, HideLabel, ReadOnly, EnableGUI, PreviewField(55, ObjectFieldAlignment.Center)]
		[HorizontalGroup("Resources/H1", width: 55)]
		private Object preview => asset;

		[BoxGroup("Resources"), PropertyOrder(-50)]
		[ShowInInspector, HideLabel, ValueDropdown("GetCharacterPrefabs")]
		[HorizontalGroup("Resources/H1"), VerticalGroup("Resources/H1/V1")]
		[InlineButton("Clear")]
		[InlineButton("OnValidate", "Update")]
		private Object asset { get; set; }
		[BoxGroup("Resources"), ToggleGroup("Resources/EditOption"), PropertyOrder(-10), ShowInInspector]
		private bool EditOption { get; set; }
		[BoxGroup("Resources"), ToggleGroup("Resources/EditOption")]
		[ShowInInspector, LabelWidth(45), DisplayAsString]
		private string guid;
		[BoxGroup("Resources"), ToggleGroup("Resources/EditOption")]
		[ShowInInspector, FolderPath]
		private string[] rootPath;
#endif
		[BoxGroup("Resources")]
		[HorizontalGroup("Resources/H1"), VerticalGroup("Resources/H1/V1")]
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
			int lastSlashIndex = resourcesPath.LastIndexOf('/');
			return lastSlashIndex >= 0 ? resourcesPath.Substring(lastSlashIndex + 1) : resourcesPath;

		}
#if UNITY_EDITOR
		private void Clear()
		{
			asset = null;
			guid = null;
			resourcesPath = null;
			loadAsset = null;
		}
		private ValueDropdownList<Object> GetCharacterPrefabs()
		{
			bool isPrefabs = typeof(T).IsSubclassOf(typeof(MonoBehaviour));

			ValueDropdownList<Object> list = new ValueDropdownList<Object>();
			HashSet<(string,Object)> tList = new HashSet<(string,Object)>();
			int length = rootPath == null ? 0 : rootPath.Length;
			for(int i = 0 ; i < length ; i++)
			{

				string folderPath = AssetPathConvertResourcesPath(rootPath[i]);

				if(isPrefabs)
				{
					var allTAssets = Resources.LoadAll<GameObject>(folderPath);
					foreach(var tAsset in allTAssets)
					{
						string assetPath = UnityEditor.AssetDatabase.GetAssetPath(tAsset);
						assetPath = assetPath.Replace($"{rootPath[i]}/", "");
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
					if(prefab.TryGetComponent<T>(out var tComponent))
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

		public void OnValidate()
		{
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
