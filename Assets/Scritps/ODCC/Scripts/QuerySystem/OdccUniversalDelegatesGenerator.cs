#if UNITY_EDITOR

using System.Collections.Generic;

using UnityEditor;

using UnityEngine;

namespace BC.ODCC
{
	/// 이 코드는 <see cref="BC.ODCC.OdccUniversalDelegates"/>에 코드를 작성합니다."
	public static class OdccUniversalDelegatesGenerator
	{
		static string generateDelegatesClass =
@$"/// 이 코드는 <see cref=\""BC.ODCC.OdccUniversalDelegatesGenerator\""/>에서 자동완성 됩니다.
namespace BC.ODCC
{{
	using System.Collections.Generic;

#if UNITY_EDITOR
	public class OdccUniversalDelegates {{ }}
#endif

	#region Delegate
	public delegate void D();
	{{0}}
	public delegate UnityEngine.Awaitable A();
	{{1}}
	#endregion

	#region OdccQueryBuilder
	/// 이 코드는 <see cref=\""BC.ODCC.OdccQueryBuilder\""/>를 확장합니다.
	public partial class OdccQueryBuilder
	{{
		{{2}}
		{{3}}
		{{4}}
	}}
	#endregion

	#region OdccQueryLooper
	/// 이 코드는 <see cref=\""BC.ODCC.OdccQueryLooper\""/>를 확장합니다.
	public partial class OdccQueryLooper
	{{
		{{5}}
	}}
	#endregion
}}";


		[MenuItem("Tools/BC Editor/Generate Delegates With Query Code")]
		public static void GenerateDelegates()
		{
			string generate = generateDelegatesClass;
			string generateCode = "";
			int generateCount = 16; //Action에 가능한 인자수가 최대 16 개임

			generateCode = string.Join("\n\t", GenerateDelegate(generateCount));
			Debug.Log(generateCode);
			generate = generate.Replace("{0}", generateCode);

			generateCode = string.Join("\n\t", GenerateDelegate_Awatable(generateCount));
			Debug.Log(generateCode);
			generate = generate.Replace("{1}", generateCode);


			generateCode = string.Join("\n\t\t", GenerateQueryCode("WithAny", generateCount));
			Debug.Log(generateCode);
			generate = generate.Replace("{2}", generateCode);

			generateCode = string.Join("\n\t\t", GenerateQueryCode("WithNone", generateCount));
			Debug.Log(generateCode);
			generate = generate.Replace("{3}", generateCode);

			generateCode = string.Join("\n\t\t", GenerateQueryCode("WithAll", generateCount));
			Debug.Log(generateCode);
			generate = generate.Replace("{4}", generateCode);

			generateCode = string.Join("\n\t\t", GenerateForeachCode(generateCount));
			Debug.Log(generateCode);
			generate = generate.Replace("{5}", generateCode);

			GUIUtility.systemCopyBuffer = generate;
			Debug.Log("클립 보드에 복사됨! OdccUniversalDelegates.cs 에 직접 붙여넣기.");
		}

		public static string[] GenerateDelegate(int count)
		{
			List<string> generateDelegate = new List<string>();
			for(int i = 0 ; i < count ; i++)
			{
				for(int ii = 0 ; ii <= i+1 ; ii++)
				{
					generateDelegate.Add($"public delegate void {GenerateType(i, ii)}<{GenerateParameters(i, ii)}>(OdccQueryLooper.LoopInfo loopInfo, {GenerateArguments(i, ii)}) {GenerateWhere(i, ii)};");
				}
			}
			return generateDelegate.ToArray();

			static string GenerateType(int count, int lCount)
			{
				int vCount = (count + 1) - lCount;
				return $"D{count:00}_{new string('L', lCount)}{new string('V', vCount)}";
			}
			static string GenerateParameters(int count, int iCount)
			{
				string[] parameters = new string[++count];
				for(int i = 0 ; i < count ; i++)
				{
					parameters[i] = $"T{i}";
				}
				return string.Join(", ", parameters);
			}
			static string GenerateArguments(int count, int lCount)
			{
				string[] arguments = new string[++count];
				for(int i = 0 ; i < count ; i++)
				{
					if(i >= lCount)
					{
						arguments[i] = $"T{i} t{i}";
					}
					else
					{
						arguments[i] = $"List<T{i}> t{i}";
					}
				}
				return string.Join(", ", arguments);
			}
			static string GenerateWhere(int count, int iCount)
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
			List<string> generateDelegate = new List<string>();
			for(int i = 0 ; i < count ; i++)
			{
				for(int ii = 0 ; ii <= i+1 ; ii++)
				{
					generateDelegate.Add($"public delegate UnityEngine.Awaitable {GenerateType(i, ii)}<{GenerateParameters(i, ii)}>(OdccQueryLooper.LoopInfo loopInfo, {GenerateArguments(i, ii)}) {GenerateWhere(i, ii)};");
				}
			}
			return generateDelegate.ToArray();

			static string GenerateType(int count, int lCount)
			{
				int vCount = (count + 1) - lCount;
				return $"A{count:00}_{new string('L', lCount)}{new string('V', vCount)}";
			}
			static string GenerateParameters(int count, int iCount)
			{
				string[] parameters = new string[++count];
				for(int i = 0 ; i < count ; i++)
				{
					parameters[i] = $"T{i}";
				}
				return string.Join(", ", parameters);
			}

			static string GenerateArguments(int count, int lCount)
			{
				string[] arguments = new string[++count];
				for(int i = 0 ; i < count ; i++)
				{
					if(i >= lCount)
					{
						arguments[i] = $"T{i} t{i}";
					}
					else
					{
						arguments[i] = $"List<T{i}> t{i}";
					}
				}
				return string.Join(", ", arguments);
			}

			static string GenerateWhere(int count, int iCount)
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
				generateMethod[i] = $"public OdccQueryBuilder {key}<{GenerateParameters(i)}>() {GenerateWhere(i)} => {key}(OdccManager.GetTypeToIndex({GenerateTypeof(i)}));";
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
			List<string> generateForeach = new List<string>();
			for(int i = 0 ; i < count ; i++)
			{
				for(int ii = 0 ; ii <= i+1 ; ii++)
				{
					string D = GenerateType_D(i, ii);
					string A = GenerateType_A(i, ii);
					string T = GenerateParameters(i);
					//string P = GenerateParameters(i,ii);
					string Where = GenerateWhere(i, ii);
					string getForeach1 = GenerateGetForeachItem(i, ii, ", looper.");
					string getForeach2 = GenerateGetForeachItem(i, ii, ", ");
					string arguments = GenerateArguments(i,ii, "; ");
					string parameters = GenerateArguments(i, ii, ", ");
					string setValue = GenerateSetValue(i, "; ");
					string getValue = GenerateGetValue(i, ", ");

					string RunForeachStruct = "RunForeachStruct";
					string ForeachStructList = "runForeachStructList";
					string rootClassName = $"RunForeachAction";
					string className = $"RunForeachAction_{A}";
					string createFunction = "CreateRunLoopAction";

					string result = ""
					+ $"\n	public class {className}<{T}> : {rootClassName} {Where}"
					+ $"\n	{{"
					+ $"\n		{arguments};"
					+ $"\n		{A}<{T}> delegateA;"
					+ $"\n		public {className}({A}<{T}> delegateA, ObjectBehaviour key,{parameters})"
					+ $"\n		{{"
					+ $"\n			this.key = key;"
					+ $"\n			this.delegateA=delegateA; {setValue};"
					+ $"\n		}}"
					+ $"\n		internal override UnityEngine.Awaitable Run(OdccQueryLooper.LoopInfo loopInfo) => delegateA.Invoke(loopInfo, {getValue});"
					+ $"\n	}}"
					+ $"\n	public OdccQueryLooper CallForeach<{T}>({D}<{T}> t = null) {Where}"
					+ $"\n	{{"
					+ $"\n		 return CallForeach<{T}>(async (info, {getValue}) => t(info, {getValue}));"
					+ $"\n	}}"
					+ $"\n	public OdccQueryLooper CallForeach<{T}>({A}<{T}> t = null) {Where}"
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
					+ $"\n		List<{rootClassName}> actionList = new List<{rootClassName}>();"
					+ $"\n		foreach(var item in queryCollector.queryItems)"
					+ $"\n		{{"
					+ $"\n			actionList.Add({createFunction}(item));"
					+ $"\n		}}"
					+ $"\n		{ForeachStructList}.Add(new {RunForeachStruct}(t, actionList, true, {createFunction}));"
					+ $"\n		return this;"
					+ $"\n		{rootClassName} {createFunction}(ObjectBehaviour item) => new {className}<{T}>(t, item, {getForeach2});"
					+ $"\n	}}"
					;
					generateForeach.Add(result);
				}
			}
			return generateForeach.ToArray();

			static string GenerateType_D(int count, int lCount)
			{
				int vCount = (count + 1) - lCount;
				return $"D{count:00}_{new string('L', lCount)}{new string('V', vCount)}";
			}
			static string GenerateType_A(int count, int lCount)
			{
				int vCount = (count + 1) - lCount;
				return $"A{count:00}_{new string('L', lCount)}{new string('V', vCount)}";
			}
			static string GenerateParameters(int count, int lCount = -1)
			{
				string[] parameters = new string[++count];
				for(int i = 0 ; i < count ; i++)
				{
					if(lCount <0 || i >= lCount)
					{
						parameters[i] = $"T{i}";
					}
					else
					{
						parameters[i] = $"List<T{i}>";
					}
				}
				return string.Join(", ", parameters);
			}
			static string GenerateWhere(int count, int lCount)
			{
				string[] parameters = new string[++count];
				for(int i = 0 ; i < count ; i++)
				{
					parameters[i] = $"where T{i} : class, IOdccItem";
				}
				return string.Join(" ", parameters);
			}
			static string GenerateArguments(int count, int lCount, string split)
			{
				string[] arguments = new string[++count];
				for(int i = 0 ; i < count ; i++)
				{
					if(i >= lCount)
					{
						arguments[i] = $"T{i} t{i}";
					}
					else
					{
						arguments[i] = $"List<T{i}> t{i}";
					}
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
			static string GenerateGetForeachItem(int count, int iCount, string split)
			{
				string[] code = new string[++count];
				for(int i = 0 ; i < count ; i++)
				{
					if(i >= iCount)
					{
						code[i] = $"SetForeachItem<T{i}>(item)";
					}
					else
					{
						code[i] = $"SetForeachItems<T{i}>(item)";
					}

				}
				return string.Join(split, code);
			}
		}
	}
}
#endif