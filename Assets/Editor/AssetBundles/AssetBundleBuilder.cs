#if UNITY_EDITOR
using System;
using System.Collections.Generic;
using System.IO;

using UnityEditor;

using UnityEngine;

[Serializable]
public class AssetBundleBuilder
{
	public string assetBundleName = "mybundle";

	public static void BuildAssetBundlesInFolder(string[] folderPath, string[] bundleName, string outputPath, BuildAssetBundleOptions buildOptions, BuildTarget targetPlatform) // 수정된 매개변수
	{
		List<AssetBundleBuild> buildMap = new List<AssetBundleBuild>();
		for(int i = 0 ; i < folderPath.Length ; i++)
		{
			if(string.IsNullOrWhiteSpace(folderPath[i])) continue;

			string[] assetGuids = AssetDatabase.FindAssets("", new[] { folderPath[i] });
			string[] assetPaths = new string[assetGuids.Length];
			for(int ii = 0 ; ii < assetGuids.Length ; ii++)
			{
				assetPaths[ii] = AssetDatabase.GUIDToAssetPath(assetGuids[ii]);
			}

			buildMap.Add(new AssetBundleBuild()
			{
				assetBundleName = bundleName[i],
				assetNames = assetPaths,
			});
		}

		if(targetPlatform == BuildTarget.NoTarget)
		{
			targetPlatform = EditorUserBuildSettings.activeBuildTarget;
		}

		RuntimePlatform runtimePlatform = targetPlatform switch
		{
			BuildTarget.StandaloneWindows or BuildTarget.StandaloneWindows64 => RuntimePlatform.WindowsPlayer,
			BuildTarget.StandaloneOSX => RuntimePlatform.OSXPlayer,
			BuildTarget.StandaloneLinux64 => RuntimePlatform.LinuxPlayer,
			BuildTarget.Android => RuntimePlatform.Android,
			BuildTarget.iOS => RuntimePlatform.IPhonePlayer,
			BuildTarget.tvOS => RuntimePlatform.tvOS,
			BuildTarget.PS4 => RuntimePlatform.PS4,
			BuildTarget.XboxOne => RuntimePlatform.XboxOne,
			BuildTarget.WebGL => RuntimePlatform.WebGLPlayer,
			BuildTarget.WSAPlayer => RuntimePlatform.WSAPlayerX86, // WSAPlayerARM, WSAPlayerX64 등과 같은 다른 WSA 플랫폼을 사용할 수 있습니다.
			BuildTarget.Switch => RuntimePlatform.Switch,
			BuildTarget.Stadia => RuntimePlatform.Stadia,
			_ => throw new NotImplementedException(),
		};

		if(string.IsNullOrWhiteSpace(outputPath))
		{
			outputPath = $"Assets/AssetBundles/{runtimePlatform}";
		}
		if(!Directory.Exists(outputPath))
		{
			Directory.CreateDirectory(outputPath);
		}

		AssetBundleManifest manifest = BuildPipeline.BuildAssetBundles(outputPath, buildMap.ToArray(), buildOptions, targetPlatform);

		if(manifest != null)
		{
			string[] allAssetBundles = manifest.GetAllAssetBundles();
			foreach(string assetBundleName in allAssetBundles)
			{
				string[] dependencies = manifest.GetAllDependencies(assetBundleName);
				Debug.Log("Built None Bundle: " + bundleName);
				Debug.Log("Dependencies: " + string.Join(", ", dependencies));
			}
		}
	}
}
#endif