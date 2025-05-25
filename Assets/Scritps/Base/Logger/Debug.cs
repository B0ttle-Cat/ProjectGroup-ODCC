namespace BC.Base
{
	public static class Debug
	{
#if UNITY_EDITOR
		public const int maxDeepCount = 20;
		public static string GetCallingMethodName(int deepCount)
		{
			System.Collections.Generic.List<string> callStack = new System.Collections.Generic.List<string>();
			System.Diagnostics.StackTrace stackTrace = new System.Diagnostics.StackTrace();
			System.Diagnostics.StackFrame[] stackFrames = stackTrace.GetFrames();

			if (deepCount > maxDeepCount)
				deepCount = maxDeepCount;

			// 호출자의 메소드 이름 가져오기 (3번째 스택 프레임)
			for (int i = deepCount - 1 ; i >= 2 ; i--)
			{
				if (i < stackFrames.Length)
				{
					System.Reflection.MethodBase callingMethod = stackFrames[i].GetMethod();
					callStack.Add($"{i-1}) <b>{callingMethod.Name}</b>");
				}
			}
			return "Tracking: " + string.Join("<color=red> :: </color>", callStack);
		}
#endif
		[System.Diagnostics.Conditional("UNITY_EDITOR")]
		public static void Log(object log = null, int deepCount = 7)
		{
#if UNITY_EDITOR
			if (log == null)
			{
				UnityEngine.Debug.Log(GetCallingMethodName(deepCount));
			}
			else
			{
				UnityEngine.Debug.Log($"<b>{log}</b>\n{GetCallingMethodName(deepCount)}");
			}
#endif
		}

		[System.Diagnostics.Conditional("UNITY_EDITOR")]
		public static void LogWarning(object log = null, int deepCount = 7)
		{
#if UNITY_EDITOR
			if (log == null)
			{
				UnityEngine.Debug.LogWarning(GetCallingMethodName(deepCount));
			}
			else
			{
				UnityEngine.Debug.LogWarning($"<b>{log}</b>\n{GetCallingMethodName(deepCount)}");
			}
#endif
		}
		[System.Diagnostics.Conditional("UNITY_EDITOR")]
		public static void LogError(object log = null, int deepCount = 7)
		{
#if UNITY_EDITOR
			if (log == null)
			{
				UnityEngine.Debug.LogError(GetCallingMethodName(deepCount));
			}
			else
			{
				UnityEngine.Debug.LogError($"<b>{log}</b>\n{GetCallingMethodName(deepCount)}");
			}
#endif
		}
		[System.Diagnostics.Conditional("UNITY_EDITOR")]
		public static void LogException(System.Exception ex)
		{
			UnityEngine.Debug.LogError(ex.Message);
			UnityEngine.Debug.LogException(ex);
		}
	}
}
