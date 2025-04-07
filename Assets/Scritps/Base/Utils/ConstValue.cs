using System;
using System.Collections.Generic;
using System.Reflection;

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

#if UNITY_EDITOR
		public static Sirenix.OdinInspector.ValueDropdownList<string> Editor_StringDropdownList()
		{
			var list = new Sirenix.OdinInspector.ValueDropdownList<string>();
			var stringList = Editor_GetAllStringList(typeof(ConstString));
			int length = stringList.Count;
			for(int i = 0 ; i < length ; i++)
			{
				list.Add(stringList[i].path, stringList[i].value);
			}

			return list;
		}
		private static List<(string path, string value)> Editor_GetAllStringList(Type rootType)
		{
			var result = new List<(string path, string value)>();
			CollectStringFieldsRecursive(rootType, rootType.Name, result);
			return result;
		}

		private static void CollectStringFieldsRecursive(Type type, string path, List<(string path, string value)> result)
		{
			var fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);

			foreach(var field in fields)
			{
				if(field.FieldType != typeof(string)) continue;

				bool isConst = field.IsLiteral && !field.IsInitOnly;
				bool isStatic = field.IsStatic && !field.IsLiteral;

				if(isConst)
				{
					string value = (string)field.GetRawConstantValue();
					result.Add(($"{path}/{field.Name}", value));
				}
				else if(isStatic)
				{
					string value = field.GetValue(null) as string;
					if(value != null)
					{
						result.Add(($"{path}/{field.Name}", value));
					}
				}
			}

			foreach(var nested in type.GetNestedTypes(BindingFlags.Public | BindingFlags.NonPublic))
			{
				string nestedPath = $"{path}_{nested.Name}";
				CollectStringFieldsRecursive(nested, nestedPath, result);
			}
		}

#endif
	}
}
