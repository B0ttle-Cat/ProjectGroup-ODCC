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
		public ResourcesKey(T asset)
		{
#if UNITY_EDITOR
			rootPath = new string[0];
			guid = "";
			this.asset = asset;
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
#endif
			resourcesPath = "";
			loadAsset = null;
		}
#if UNITY_EDITOR
		[TabGroup("Tab", "Resources"), PropertyOrder(-50)]
		[ShowInInspector, HideLabel, ReadOnly, EnableGUI, PreviewField(75, ObjectFieldAlignment.Center)]
		[HorizontalGroup("Tab/Resources/H1", width: 80)]
		private T preview => asset;
		[TabGroup("Tab", "Resources"), PropertyOrder(-50)]
		[ShowInInspector, HideLabel, ValueDropdown("GetCharacterPrefabs")]
		[HorizontalGroup("Tab/Resources/H1"), VerticalGroup("Tab/Resources/H1/V1")]
		private T asset { get; set; }

		[TabGroup("Tab", "Option"), PropertyOrder(50)]
		[ShowInInspector, LabelWidth(40), DisplayAsString]
		private string guid;
		[TabGroup("Tab", "Option"), PropertyOrder(50)]
		[ShowInInspector, FolderPath]
		private string[] rootPath;
#endif
		[TabGroup("Tab", "Resources")]
		[HorizontalGroup("Tab/Resources/H1"), VerticalGroup("Tab/Resources/H1/V1")]
		[HideLabel, Multiline(3), ReadOnly,EnableGUI]
		public string resourcesPath;

		private T loadAsset { get; set; }

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

#if UNITY_EDITOR
		private ValueDropdownList<T> GetCharacterPrefabs()
		{
			ValueDropdownList<T> list = new ValueDropdownList<T>();
			HashSet<(string,T)> tList = new HashSet<(string,T)>();
			int length = rootPath.Length;
			for(int i = 0 ; i < length ; i++)
			{

				string folderPath = AssetPathConvertResourcesPath(rootPath[i]);

				if(string.IsNullOrWhiteSpace(folderPath)) continue;

				var allTAssets = Resources.LoadAll<T>(folderPath);
				foreach(var tAsset in allTAssets)
				{
					string assetPath = UnityEditor.AssetDatabase.GetAssetPath(tAsset);
					assetPath = assetPath.Replace($"{rootPath[i]}/", "");
					assetPath = Path.ChangeExtension(assetPath, null);
					tList.Add((assetPath, tAsset));
				}
			}
			foreach(var item in tList)
			{
				list.Add(item.Item1, item.Item2);
			}
			return list;
		}

		string AssetPathConvertResourcesPath(string assetPath)
		{
			string keyword = "Resources";
			assetPath = assetPath.Contains(keyword, StringComparison.OrdinalIgnoreCase)
				? assetPath[(assetPath.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) + keyword.Length)..].TrimStart('\\', '/')
				: assetPath;
			assetPath = Path.ChangeExtension(assetPath, null);
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
				}
				if(resourcesPath.IsNotNullOrWhiteSpace())
				{
					asset = Resources.Load<T>(resourcesPath);
				}
				else
				{
					return;
				}
			}
			else
			{
				string assetPath = UnityEditor.AssetDatabase.GetAssetPath(asset);
				guid = UnityEditor.AssetDatabase.AssetPathToGUID(assetPath);
				resourcesPath = AssetPathConvertResourcesPath(assetPath);
			}
		}
#endif

	}

	public static class UtilResourcesKey
	{

	}
}
