#if UNITY_EDITOR
using System;
using System.Collections.Generic;

using UnityEditor;

using UnityEngine;

public class AssetBundleBuilderWindow : EditorWindow
{
	private List<DefaultAsset> foldersToBuild;
	//private DefaultAsset outputFolder;
	private BuildAssetBundleOptions buildOptions = BuildAssetBundleOptions.None;
	private BuildTarget targetPlatform = BuildTarget.StandaloneWindows;

	[MenuItem("Tools/BC Editor/AssetBundle Builder Window")]
	static void OpenWindow()
	{
		AssetBundleBuilderWindow window = GetWindow<AssetBundleBuilderWindow>();
		window.titleContent = new GUIContent("AssetBundle Builder");
		window.Show();
	}

	private void OnGUI()
	{
		GUILayout.Label("AssetBundle Builder", EditorStyles.boldLabel);

		// (UnityEngine.Object obj, Type objType, bool allowSceneObjects, params GUILayoutOption[] options)
		if(foldersToBuild == null) foldersToBuild = new List<DefaultAsset>();
		for(int i = 0 ; i < foldersToBuild.Count ; i++)
		{
			if(foldersToBuild[i] == null)
			{
				foldersToBuild.RemoveAt(i);
				i--;
			}
		}
		for(int i = 0 ; i < foldersToBuild.Count ; i++)
		{
			foldersToBuild[i] = EditorGUILayout.ObjectField($"Folders To Build {i}", foldersToBuild[i], typeof(DefaultAsset), true) as DefaultAsset;
		}
		EditorGUI.indentLevel += 2;
		var addDefaultAsset = EditorGUILayout.ObjectField($"Folders To Build {foldersToBuild.Count}", null, typeof(DefaultAsset), true) as DefaultAsset;
		foldersToBuild.Add(addDefaultAsset);
		EditorGUI.indentLevel -= 2;

		EditorGUILayout.Space(10);

		//outputFolder = EditorGUILayout.ObjectField("Output Folder", outputFolder, typeof(DefaultAsset), false) as DefaultAsset;

		EditorGUILayout.Space(10);

		buildOptions = (BuildAssetBundleOptions)EditorGUILayout.EnumPopup("Build Options", buildOptions);
		targetPlatform = (BuildTarget)EditorGUILayout.EnumPopup("TargetPath Platform", targetPlatform);

		EditorGUILayout.Space(10);
		if(GUILayout.Button("Build Asset Bundles") && foldersToBuild != null)
		{
			bool proceed = EditorUtility.DisplayDialog("Build Asset Bundles", "정말로 Asset Bundles를 빌드하시겠습니까?", "확인", "취소");

			if(proceed)
			{
				string[] folderPaths = Array.ConvertAll(foldersToBuild.ToArray(), item=>item ==null ? "" : AssetDatabase.GetAssetPath(item));
				string[] bundleName = Array.ConvertAll(foldersToBuild.ToArray(), item=>item ==null ? "" : item.name);
				//string outputPath = outputFolder == null ? "" : AssetDatabase.GetAssetPath(outputFolder);
				AssetBundleBuilder.BuildAssetBundlesInFolder(folderPaths, bundleName, null, buildOptions, targetPlatform);
			}
		}
	}
}

#endif