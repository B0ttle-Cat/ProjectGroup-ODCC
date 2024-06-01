#if UNITY_EDITOR
using UnityEditor;

using UnityEngine;

namespace BC.ODCC
{
	public static class OdccUniversalDelegatesGenerater
	{
		static string generateDelegatesClass =
			$"/// 이 코드는 <see cref=\"BC.ODCC.OdccUniversalDelegatesGenerater\"/>에서 자동완성 됩니다."
			+ "\nnamespace BC.ODCC"
			+ "\n{"
			+ "\n	using System.Collections;"
			+ "\n	using System.Collections.Generic;"
			+ "\n"
			+ "\n	using UnityEngine;"
			+ "\n"
			+ "\n	#region Delegate"
			+ "\n	public delegate void T();"
			+ "\n	{0-0}"
			+ "\n	public delegate IEnumerator I();"
			+ "\n	{0-1}"
			+ "\n	public delegate Awaitable A();"
			+ "\n	{0-2}"
			+ "\n	#endregion"
			+ "\n"
			+ "\n	#region QuerySystemBuilder"
			+ "\n	/// 이 코드는 <see cref=\"BC.ODCC.QuerySystemBuilder\"/>를 확장합니다."
			+ "\n	public partial class QuerySystemBuilder"
			+ "\n	{"
			+ "\n		{1}"
			+ "\n		{2}"
			+ "\n		{3}"
			+ "\n	}"
			+ "\n	#endregion"
			+ "\n"
			+ "\n	#region OdccQueryLooper"
			+ "\n	/// 이 코드는 <see cref=\"BC.ODCC.OdccQueryLooper\"/>를 확장합니다."
			+ "\n	public partial class OdccQueryLooper"
			+ "\n	{"
			+ "\n		{4}"
			+ "\n	}"
			+ "\n	#endregion"
			+ "\n}";


		[MenuItem("Tools/BC Editor/Generate Delegates With Query Code")]
		public static void GenerateDelegates()
		{
			string generate = generateDelegatesClass;
			string generateCode = "";
			int generateCount = 20;

			generateCode = string.Join("\n\t", GenerateDelegate(generateCount));
			Debug.Log(generateCode);
			generate = generate.Replace("{0-0}", generateCode);

			generateCode = string.Join("\n\t", GenerateDelegate_IEnumerator(generateCount));
			Debug.Log(generateCode);
			generate = generate.Replace("{0-1}", generateCode);

			generateCode = string.Join("\n\t", GenerateDelegate_Awatable(generateCount));
			Debug.Log(generateCode);
			generate = generate.Replace("{0-2}", generateCode);


			generateCode = string.Join("\n\t\t", GenerateQueryCode("WithAny", generateCount));
			Debug.Log(generateCode);
			generate = generate.Replace("{1}", generateCode);

			generateCode =  string.Join("\n\t\t", GenerateQueryCode("WithNone", generateCount));
			Debug.Log(generateCode);
			generate = generate.Replace("{2}", generateCode);

			generateCode = string.Join("\n\t\t", GenerateQueryCode("WithAll", generateCount));
			Debug.Log(generateCode);
			generate = generate.Replace("{3}", generateCode);

			generateCode = string.Join("\n\t\t", GenerateForeachCode(generateCount));
			Debug.Log(generateCode);
			generate = generate.Replace("{4}", generateCode);

			GUIUtility.systemCopyBuffer = generate;

			Debug.Log("클립 보드에 복사됨! OdccUniversalDelegates.cs 에 직접 붙여넣기.");
		}

		public static string[] GenerateDelegate(int count)
		{
			string[] generateDelegate = new string[count];
			for(int i = 0 ; i < count ; i++)
			{
				generateDelegate[i] = $"public delegate void T<{GenerateParameters(i)}>({GenerateArguments(i)}) {GenerateWhere(i)};";
			}
			return generateDelegate;

			static string GenerateParameters(int count)
			{
				string[] parameters = new string[++count];
				for(int i = 0 ; i < count ; i++)
				{
					parameters[i] = $"T{i}";
				}
				return string.Join(", ", parameters);
			}

			static string GenerateArguments(int count)
			{
				string[] arguments = new string[++count];
				for(int i = 0 ; i < count ; i++)
				{
					arguments[i] = $"T{i} t{i}";
				}
				return string.Join(", ", arguments);
			}

			static string GenerateWhere(int count)
			{
				string[] parameters = new string[++count];
				for(int i = 0 ; i < count ; i++)
				{
					parameters[i] = $"where T{i} : class, IOdccItem";
				}
				return string.Join(" ", parameters);
			}
		}
		public static string[] GenerateDelegate_IEnumerator(int count)
		{
			string[] generateDelegate = new string[count];
			for(int i = 0 ; i < count ; i++)
			{
				generateDelegate[i] = $"public delegate IEnumerator I<{GenerateParameters(i)}>({GenerateArguments(i)}) {GenerateWhere(i)};";
			}
			return generateDelegate;

			static string GenerateParameters(int count)
			{
				string[] parameters = new string[++count];
				for(int i = 0 ; i < count ; i++)
				{
					parameters[i] = $"T{i}";
				}
				return string.Join(", ", parameters);
			}

			static string GenerateArguments(int count)
			{
				string[] arguments = new string[++count];
				for(int i = 0 ; i < count ; i++)
				{
					arguments[i] = $"T{i} t{i}";
				}
				return string.Join(", ", arguments);
			}

			static string GenerateWhere(int count)
			{
				string[] parameters = new string[++count];
				for(int i = 0 ; i < count ; i++)
				{
					parameters[i] = $"where T{i} : class, IOdccItem";
				}
				return string.Join(" ", parameters);
			}
		}
		public static string[] GenerateDelegate_Awatable(int count)
		{
			string[] generateDelegate = new string[count];
			for(int i = 0 ; i < count ; i++)
			{
				generateDelegate[i] = $"public delegate Awaitable A<{GenerateParameters(i)}>({GenerateArguments(i)}) {GenerateWhere(i)};";
			}
			return generateDelegate;

			static string GenerateParameters(int count)
			{
				string[] parameters = new string[++count];
				for(int i = 0 ; i < count ; i++)
				{
					parameters[i] = $"T{i}";
				}
				return string.Join(", ", parameters);
			}

			static string GenerateArguments(int count)
			{
				string[] arguments = new string[++count];
				for(int i = 0 ; i < count ; i++)
				{
					arguments[i] = $"T{i} t{i}";
				}
				return string.Join(", ", arguments);
			}

			static string GenerateWhere(int count)
			{
				string[] parameters = new string[++count];
				for(int i = 0 ; i < count ; i++)
				{
					parameters[i] = $"where T{i} : class, IOdccItem";
				}
				return string.Join(" ", parameters);
			}
		}
		public static string[] GenerateQueryCode(string key, int count)
		{
			string[] generateMethod = new string[count];
			for(int i = 0 ; i < count ; i++)
			{
				generateMethod[i] = $"public QuerySystemBuilder {key}<{GenerateParameters(i)}>(bool checkInheritance = false) {GenerateWhere(i)} => {key}(checkInheritance, OdccManager.GetTypeToIndex({GenerateTypeof(i)}));";
			}
			return generateMethod;

			static string GenerateParameters(int count)
			{
				string[] parameters = new string[++count];
				for(int i = 0 ; i < count ; i++)
				{
					parameters[i] = $"T{i}";
				}
				return string.Join(", ", parameters);
			}

			static string GenerateTypeof(int count)
			{
				string[] arguments = new string[++count];
				for(int i = 0 ; i < count ; i++)
				{
					arguments[i] = $"typeof(T{i})";
				}
				return string.Join(", ", arguments);
			}
			static string GenerateWhere(int count)
			{
				string[] parameters = new string[++count];
				for(int i = 0 ; i < count ; i++)
				{
					parameters[i] = $"where T{i} : class, IOdccItem";
				}
				return string.Join(" ", parameters);
			}
		}

		public static string[] GenerateForeachCode(int count)
		{
			string[] generateForeach = new string[count];
			for(int i = 0 ; i < count ; i++)
			{
				string T = GenerateParameters(i);
				string Where = GenerateWhere(i);
				string getForeach1 = GenerateGetForeachItem(i, ", looper.");
				string getForeach2 = GenerateGetForeachItem(i, ", ");
				string arguments = GenerateArguments(i ,"; ");
				string parameters = GenerateArguments(i ,", ");
				string setValue = GenerateSetValue(i,"; ");
				string getValue = GenerateGetValue(i,", ");

				string RunForeachStruct = "RunForeachStruct";
				string ForeachStructList = "runForeachStructList";
				string className = "RunForeachAction";
				string createFunction = "CreateRunLoopAction";
				generateForeach[i] = ""
				+ $"\n	public class {className}<{T}> : {className} {Where}"
				+ $"\n	{{"
				+ $"\n		T<{T}> delegateT;"
				+ $"\n		I<{T}> delegateI;"
				+ $"\n		A<{T}> delegateA;"
				+ $"\n		{arguments};"
				+ $"\n		public {className}(T<{T}> delegateT, ObjectBehaviour key,{parameters})"
				+ $"\n		{{"
				+ $"\n			this.key = key;"
				+ $"\n			this.delegateT=delegateT; {setValue};"
				+ $"\n		}}"
				+ $"\n		public {className}(I<{T}> delegateI, ObjectBehaviour key,{parameters})"
				+ $"\n		{{"
				+ $"\n			this.key = key;"
				+ $"\n			this.delegateI=delegateI; {setValue};"
				+ $"\n		}}"
				+ $"\n		public {className}(A<{T}> delegateA, ObjectBehaviour key,{parameters})"
				+ $"\n		{{"
				+ $"\n			this.key = key;"
				+ $"\n			this.delegateA=delegateA; {setValue};"
				+ $"\n		}}"
				+ $"\n		internal override void Run() => delegateT.Invoke({getValue});"
				+ $"\n		internal override IEnumerator IRun() => delegateI.Invoke({getValue});"
				+ $"\n		internal override Awaitable ARun() => delegateA.Invoke({getValue});"
				+ $"\n	}}"
				+ $"\n	public OdccQueryLooper Foreach<{T}>(T<{T}> t = null) {Where}"
				+ $"\n	{{"
				+ $"\n		if(t == null) return this;"
				+ $"\n		int findIndex = {ForeachStructList}.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);"
				+ $"\n		if(findIndex >= 0)"
				+ $"\n		{{"
				+ $"\n			var runForeachStruct = runForeachStructList[findIndex];"
				+ $"\n			runForeachStruct.targetDelegate = t;"
				+ $"\n			runForeachStructList[findIndex] = runForeachStruct;"
				+ $"\n			return this;"
				+ $"\n		}}"
				+ $"\n		List<{className}> actionList = new List<{className}>();"
				+ $"\n		foreach(var item in queryCollector.queryItems)"
				+ $"\n		{{"
				+ $"\n			actionList.Add({createFunction}(item));"
				+ $"\n		}}"
				+ $"\n		{ForeachStructList}.Add(new {RunForeachStruct}(t, actionList, false, {createFunction}));"
				+ $"\n		return this;"
				+ $"\n		{className} {createFunction}(ObjectBehaviour item) => new {className}<{T}>(t, item, {getForeach2});"
				+ $"\n	}}"
				+ $"\n	public OdccQueryLooper Foreach<{T}>(I<{T}> t = null) {Where}"
				+ $"\n	{{"
				+ $"\n		if(t == null) return this;"
				+ $"\n		int findIndex = {ForeachStructList}.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);"
				+ $"\n		if(findIndex >= 0)"
				+ $"\n		{{"
				+ $"\n			var runForeachStruct = runForeachStructList[findIndex];"
				+ $"\n			runForeachStruct.targetDelegate = t;"
				+ $"\n			runForeachStructList[findIndex] = runForeachStruct;"
				+ $"\n			return this;"
				+ $"\n		}}"
				+ $"\n		List<{className}> actionList = new List<{className}>();"
				+ $"\n		foreach(var item in queryCollector.queryItems)"
				+ $"\n		{{"
				+ $"\n			actionList.Add({createFunction}(item));"
				+ $"\n		}}"
				+ $"\n		{ForeachStructList}.Add(new {RunForeachStruct}(t, actionList, true, {createFunction}));"
				+ $"\n		return this;"
				+ $"\n		{className} {createFunction}(ObjectBehaviour item) => new {className}<{T}>(t, item, {getForeach2});"
				+ $"\n	}}"
				+ $"\n	public OdccQueryLooper Foreach<{T}>(A<{T}> t = null) {Where}"
				+ $"\n	{{"
				+ $"\n		if(t == null) return this;"
				+ $"\n		int findIndex = {ForeachStructList}.FindIndex(list => list.targetDelegate.Target == t.Target && list.targetDelegate.Method == t.Method);"
				+ $"\n		if(findIndex >= 0)"
				+ $"\n		{{"
				+ $"\n			var runForeachStruct = runForeachStructList[findIndex];"
				+ $"\n			runForeachStruct.targetDelegate = t;"
				+ $"\n			runForeachStructList[findIndex] = runForeachStruct;"
				+ $"\n			return this;"
				+ $"\n		}}"
				+ $"\n		List<{className}> actionList = new List<{className}>();"
				+ $"\n		foreach(var item in queryCollector.queryItems)"
				+ $"\n		{{"
				+ $"\n			actionList.Add({createFunction}(item));"
				+ $"\n		}}"
				+ $"\n		{ForeachStructList}.Add(new {RunForeachStruct}(t, actionList, true, {createFunction}));"
				+ $"\n		return this;"
				+ $"\n		{className} {createFunction}(ObjectBehaviour item) => new {className}<{T}>(t, item, {getForeach2});"
				+ $"\n	}}"
				;
			}
			return generateForeach;

			static string GenerateParameters(int count)
			{
				string[] parameters = new string[++count];
				for(int i = 0 ; i < count ; i++)
				{
					parameters[i] = $"T{i}";
				}
				return string.Join(", ", parameters);
			}
			static string GenerateWhere(int count)
			{
				string[] parameters = new string[++count];
				for(int i = 0 ; i < count ; i++)
				{
					parameters[i] = $"where T{i} : class, IOdccItem";
				}
				return string.Join(" ", parameters);
			}
			static string GenerateArguments(int count, string split)
			{
				string[] arguments = new string[++count];
				for(int i = 0 ; i < count ; i++)
				{
					arguments[i] = $"T{i} t{i}";
				}
				return string.Join(split, arguments);
			}
			static string GenerateGetValue(int count, string split)
			{
				string[] arguments = new string[++count];
				for(int i = 0 ; i < count ; i++)
				{
					arguments[i] = $"t{i}";
				}
				return string.Join(split, arguments);
			}
			static string GenerateSetValue(int count, string split)
			{
				string[] arguments = new string[++count];
				for(int i = 0 ; i < count ; i++)
				{
					arguments[i] = $"this.t{i} = t{i}";
				}
				return string.Join(split, arguments);
			}
			static string GenerateGetForeachItem(int count, string split)
			{
				string[] code = new string[++count];
				for(int i = 0 ; i < count ; i++)
				{
					code[i] = $"SetForeachItem<T{i}>(item)";
				}
				return string.Join(split, code);
			}
		}
	}
}
#endif