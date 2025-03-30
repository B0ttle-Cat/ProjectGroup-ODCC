using System.Diagnostics;

namespace BC.Base
{
	public static class PingAndOpenScript
	{
		public static string LastPingType = "";
		public static double LastPingClickTime = -1; // ������ Ŭ�� �ð��� ���
		public const double DoubleClickOpenTime = 0.25; // Ŭ�� ����
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
					// �����Ϳ��� �ش� ��ũ��Ʈ�� ����
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
					// �����Ϳ��� �ش� ���� ����
					UnityEditor.AssetDatabase.OpenAsset(UnityEditor.AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(path));
					break;
				}
			}
		}
	}
}