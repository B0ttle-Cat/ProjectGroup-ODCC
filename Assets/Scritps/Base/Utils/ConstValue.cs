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
			if (value) @true?.Invoke();
			else @false?.Invoke();
			return value;
		}
		public static bool IsFalse(this bool value, Action @false, Action @true = null)
		{
			if (value) @true?.Invoke();
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
			if (editorPlatform == RuntimePlatform.WindowsEditor)
			{
				editorPlatform = RuntimePlatform.WindowsPlayer;
			}
			else if (editorPlatform == RuntimePlatform.OSXEditor)
			{
				editorPlatform = RuntimePlatform.OSXPlayer;
			}
			else if (editorPlatform == RuntimePlatform.LinuxEditor)
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
			for (int i = 0 ; i < length ; i++)
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

			foreach (var field in fields)
			{
				if (field.FieldType != typeof(string)) continue;

				bool isConst = field.IsLiteral && !field.IsInitOnly;
				bool isStatic = field.IsStatic && !field.IsLiteral;

				if (isConst)
				{
					string value = (string)field.GetRawConstantValue();
					result.Add(($"{path}/{field.Name}", value));
				}
				else if (isStatic)
				{
					string value = field.GetValue(null) as string;
					if (value != null)
					{
						result.Add(($"{path}/{field.Name}", value));
					}
				}
			}

			foreach (var nested in type.GetNestedTypes(BindingFlags.Public | BindingFlags.NonPublic))
			{
				string nestedPath = $"{path}_{nested.Name}";
				CollectStringFieldsRecursive(nested, nestedPath, result);
			}
		}

#endif
	}

	public static partial class ConstFloat
	{
		public const float Epsilon_E03 = 1E-03f;       // 0.001f
		public const float Epsilon_E06 = 1E-06f;           // 0.000001f
		public const float Epsilon_E45 = float.Epsilon;    // 1.401298E-45f, 가장 작은 양수

		public const float Sqrt2 = 1.4142135f;        // √2, 피타고라스 정리
		public const float Sqrt3 = 1.7320508f;        // √3, 정삼각형 높이 비율
		public const float Sqrt5 = 2.2360679f;        // √5, φ 계산에 필요
		public const float InvSqrt2 = 0.7071068f;     // 1 / √2
		public const float InvSqrt3 = 0.5773503f;     // 1 / √3
		public const float InvSqrt5 = 0.4472136f;     // 1 / √5

		public const float Log2 = 0.3010300f;       // log₁₀(2)
		public const float Log10 = 1.0f;            // log₁₀(10)
		public const float Log2E = 1.442695f;       // log₂(e)
		public const float Log10E = 0.4342945f;     // log₁₀(e)
		public const float Ln2 = 0.6931472f;        // ln(2)
		public const float Ln10 = 2.3025851f;       // ln(10)

		public const float Sin30 = 0.5f;
		public const float Cos30 = 0.8660254f;
		public const float Tan30 = 0.5773503f;

		public const float Sin45 = 0.7071068f;
		public const float Cos45 = 0.7071068f;
		public const float Tan45 = 1f;

		public const float Sin60 = 0.8660254f;
		public const float Cos60 = 0.5f;
		public const float Tan60 = 1.7320508f;

		public const float PlasticNumber = 1.3247179f;  // Pisot 수, 일부 재귀수열 수렴값
		public const float FeigenbaumAlpha = 2.5029079f; // 혼돈이론 bifurcation 계수
		public const float FeigenbaumDelta = 4.6692016f; // 대칭성 붕괴 간격 비율
		public const float EulerMascheroni = 0.5772157f; // 오일러-마스케로니 상수 γ, 해석학에서 자주 등장
		public const float GoldenRatio = 1.618034f;      // 황금비 φ
		public const float SilverRatio = 2.414213f;      // 은비 ψ = 1 + √2
		public const float ApérysConstant = 1.202057f;   // 아페리 상수 ζ(3), 리만 제타함수 관련

		public const float Catalan = 0.9159656f;         // 조합론, 적분계산 등장
		public const float Khinchin = 2.6854520f;        // 연분수의 평균계수
		public const float Glaisher = 1.2824271f;        // 감마 함수 및 무한곱/합 등장

		public const float E = 2.7182818f;               // 자연로그 밑 e
		public const float Pi = 3.1415927f;              // π
		public const float TwoPi = 6.2831853f;           // 2π
		public const float HalfPi = 1.5707963f;          // π / 2
		public const float QuarterPi = 0.7853981f;       // π / 4

		public const float SecondsPerMinute = 60f;      // 1분당 초
		public const float SecondsPerHour = 3600f;      // 1시간당 초
		public const float SecondsPerDay = 86400f;      // 1일당 초

		public const float StandardGravity = 9.80665f;              // 지구 중력 (m/s²)
		public const float AirDensitySeaLevel = 1.225f;             // 공기 밀도 (kg/m³ at 15°C, 1atm)
		public const float SpeedOfLight = 299792458f;               // 빛의 속도 (m/s)
		public const float PlanckConstant = 6.62607015e-34f;        // 플랑크 상수 (J·s)
		public const float Avogadro = 6.02214076e23f;               // 아보가드로 수 (1/mol)
		public const float Boltzmann = 1.380649e-23f;               // 볼츠만 상수 (J/K)
		public const float GasConstant = 8.3144626f;                // 기체 상수 R (J/(mol·K))
		public const float ElementaryCharge = 1.602176634e-19f;     // 기본 전하 (C)
		public const float VacuumPermittivity = 8.8541878128e-12f;  // 진공 유전율 (F/m)
		public const float VacuumPermeability = 1.25663706212e-6f;  // 진공 투자율 (N/A²)
	}
}
