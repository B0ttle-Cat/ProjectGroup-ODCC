using System.Diagnostics;

namespace BC.Base
{
	public static class PingAndOpenScript
	{
		public static string LastPingType = "";
		public static double LastPingClickTime = -1; // 마지막 클릭 시간을 기록
		public const double DoubleClickOpenTime = 0.25; // 클릭 간격
		[Conditional("UNITY_EDITOR")]
		public static void PingScript(System.Type type, bool doubleClickOpen = true)
		{
			string scriptName = type.Name;
			string scriptFileName = $"{scriptName}.cs";

			if(doubleClickOpen)
			{
				double currentTime = UnityEditor.EditorApplication.timeSinceStartup;
				if(LastPingClickTime > 0 && currentTime - LastPingClickTime<= DoubleClickOpenTime && LastPingType == scriptName)
				{
					LastPingClickTime = 0;
					LastPingType = "";
					OpenScript(type);
					return;
				}
				LastPingClickTime = currentTime;
				LastPingType = scriptName;
			}

			string[] guids = UnityEditor.AssetDatabase.FindAssets($"{scriptName} t:Script");

			foreach(string guid in guids)
			{
				string path = UnityEditor.AssetDatabase.GUIDToAssetPath(guid);
				if(System.IO.Path.GetFileName(path) == scriptFileName)
				{
					// 에디터에서 해당 스크립트를 강조
					UnityEditor.EditorGUIUtility.PingObject(UnityEditor.AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(path));
					break;
				}
			}
		}
		[Conditional("UNITY_EDITOR")]
		public static void OpenScript(System.Type type)
		{
			string scriptName = type.Name;
			string scriptFileName = $"{scriptName}.cs";

			string[] guids = UnityEditor.AssetDatabase.FindAssets($"{scriptName} t:Script");

			foreach(string guid in guids)
			{
				string path = UnityEditor.AssetDatabase.GUIDToAssetPath(guid);
				if(System.IO.Path.GetFileName(path) == scriptFileName)
				{
					// 에디터에서 해당 파일 열기
					UnityEditor.AssetDatabase.OpenAsset(UnityEditor.AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(path));
					break;
				}
			}
		}
	}
}