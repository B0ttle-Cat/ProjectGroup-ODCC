using System;
using System.Collections.Generic;
using System.Linq;

using Sirenix.OdinInspector;

#if UNITY_EDITOR
using UnityEditor;
#endif


namespace BC.Base
{
	public class ClassTypeDropdownList<T> : ValueDropdownList<string> where T : class
	{
		public ClassTypeDropdownList()
		{
			var list = GetDerivedClassNames();
			for(int i = 0 ; i < list.Length ; i++)
			{
				Add(list[i], list[i]);
			}
		}

		public static string[] GetDerivedClassNames()
		{
			List<string> classNames = new List<string>();

			Type ParentType = typeof(T);
			// ParentType을 상속받는 클래스들을 가져옵니다.
			Type[] derivedTypes = AppDomain.CurrentDomain.GetAssemblies()
				.SelectMany(assembly => assembly.GetTypes())
				.Where(type => ParentType.IsAssignableFrom(type) && type != ParentType && !type.IsAbstract)
				.ToArray();

			foreach(var derivedType in derivedTypes)
			{
				classNames.Add(derivedType.Name);
			}

			return classNames.ToArray();
		}
	}

#if UNITY_EDITOR
	public class MonoScriptDropdownList<T> : ValueDropdownList<MonoScript> where T : class
	{
		public MonoScriptDropdownList()
		{
			var list = GetDerivedClassNames();
			for(int i = 0 ; i < list.Count ; i++)
			{
				Add(list[i].GetClass().Name, list[i]);
			}
		}

		public static List<MonoScript> GetDerivedClassNames()
		{
			List<MonoScript> monoScripts = new List<MonoScript>();

			// 에셋 폴더에서 모든 스크립트 에셋을 검색합니다.
			string[] scriptGUIDs = AssetDatabase.FindAssets("t:MonoScript");
			foreach(string scriptGUID in scriptGUIDs)
			{
				string scriptPath = AssetDatabase.GUIDToAssetPath(scriptGUID);
				MonoScript monoScript = AssetDatabase.LoadAssetAtPath<MonoScript>(scriptPath);

				// 스크립트가 T를 상속하고 클래스인지 확인합니다.
				Type scriptType = monoScript.GetClass();
				if(!typeof(T).Equals(scriptType) && typeof(T).IsAssignableFrom(scriptType) && scriptType.IsClass)
				{
					monoScripts.Add(monoScript);
				}
			}

			return monoScripts;
		}
	}
#endif
}
