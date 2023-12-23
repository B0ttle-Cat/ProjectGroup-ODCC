using System;

using UnityEngine;

namespace BC.Base
{
	public static partial class ConstInt
	{
		public const int FirstExecutionOrder = -9999;
		public const int LastExecutionOrder = 9999;

		public const int FirstInspectorOrder = -999;
		public const int LastInspectorOrder = 999;

		public const int UICursorOrder = 32767;
		public const int UIPopupOrder = 100;
	}
	public static partial class ConstBool
	{
		public static bool IsTrue(this bool value, Action @true, Action @false = null)
		{
			if(value) @true?.Invoke();
			else @false?.Invoke();
			return value;
		}
		public static bool IsFalse(this bool value, Action @false, Action @true = null)
		{
			if(value) @true?.Invoke();
			else @false?.Invoke();
			return value;
		}


		public static T? IsTrueSet<T>(this bool value, T? trueValue) where T : struct
		{
			return value ? trueValue : null;
		}
		public static T? IsFalseSet<T>(this bool value, T? falseValue) where T : struct
		{
			return value ? null : falseValue;
		}

	}

	public static partial class ConstString
	{
		public const string AUTOSAVE = nameof(AUTOSAVE);

#if UNITY_EDITOR
		public static string BundleLocalPath = $"{Application.dataPath}/AssetBundles/{Application.platform.EditorToRuntimePlatform()}";
#else
		public static string BundleLocalPath = $"{Application.persistentDataPath}/{nameof(BundleLocalPath)}";
#endif
		public static string BundleURLPath = $"http://your-website.com/path/to/your/assetbundle/{Application.platform.EditorToRuntimePlatform()}";

		public static RuntimePlatform EditorToRuntimePlatform(this RuntimePlatform editorPlatform)
		{
			if(editorPlatform == RuntimePlatform.WindowsEditor)
			{
				editorPlatform = RuntimePlatform.WindowsPlayer;
			}
			else if(editorPlatform == RuntimePlatform.OSXEditor)
			{
				editorPlatform = RuntimePlatform.OSXPlayer;
			}
			else if(editorPlatform == RuntimePlatform.LinuxEditor)
			{
				editorPlatform = RuntimePlatform.LinuxPlayer;
			}
			return editorPlatform;
		}
	}
}
