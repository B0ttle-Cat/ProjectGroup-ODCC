using System.Collections.Generic;

using UnityEngine;

namespace BC.Base
{
	public static partial class TimeControl
	{
		static Dictionary<string, float> typeTimeScales = new Dictionary<string, float>();
		public static float GetTypeScale(string timeID)
		{
			if (string.IsNullOrWhiteSpace(timeID)) return 1f;
			return typeTimeScales != null && typeTimeScales.TryGetValue(timeID, out float scale) ? scale : 1f;
		}
		public static void SetTypeScale(string timeID, float scale)
		{
			typeTimeScales ??= new Dictionary<string, float>();
			if (Mathf.Abs(scale - 1f) <= 1E-06f)
			{
				typeTimeScales.Remove(timeID);
			}
			else
			{
				typeTimeScales[timeID] = scale;
			}
		}
		public static void ApplyTypeScale(string timeID)
		{
			float timeScale = GetTypeScale(timeID);
			Time.timeScale = timeScale < 0 ? 0 : timeScale;
		}

		public static float GetTypeScale<T>() => GetTypeScale(typeof(T).Name);
		public static void SetTypeScale<T>(float scale) => SetTypeScale(typeof(T).Name, scale);
		public static void ApplyTypeScale<T>() => ApplyTypeScale(typeof(T).Name);
	}
}