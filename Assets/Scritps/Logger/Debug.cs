namespace BC.Base
{
	public static class Debug
	{
#if UNITY_EDITOR
		private static string GetCallingMethodName()
		{
			System.Collections.Generic.List<string> callStack = new System.Collections.Generic.List<string>();
			System.Diagnostics.StackTrace stackTrace = new System.Diagnostics.StackTrace();
			System.Diagnostics.StackFrame[] stackFrames = stackTrace.GetFrames();

			// 호출자의 메소드 이름 가져오기 (3번째 스택 프레임)
			for(int i = 7 - 1 ; i >= 2 ; i--)
			{
				if(i < stackFrames.Length)
				{
					System.Reflection.MethodBase callingMethod = stackFrames[i].GetMethod();
					callStack.Add($"{i-1}) <b>{callingMethod.Name}</b>");
				}
			}
			return "Tracking: " + string.Join("<color=red> :: </color>", callStack);
		}
#endif
		[System.Diagnostics.Conditional("UNITY_EDITOR")]
		public static void Log(object log = null)
		{
#if UNITY_EDITOR
			if(log == null)
			{
				UnityEngine.Debug.Log(GetCallingMethodName());
			}
			else
			{
				UnityEngine.Debug.Log($"<b>{log}</b>\n{GetCallingMethodName()}");
			}
#endif
		}

		[System.Diagnostics.Conditional("UNITY_EDITOR")]
		public static void LogWarning(object log)
		{
#if UNITY_EDITOR
			if(log == null)
			{
				UnityEngine.Debug.LogWarning(GetCallingMethodName());
			}
			else
			{
				UnityEngine.Debug.LogWarning($"<b>{log}</b>\n{GetCallingMethodName()}");
			}
#endif
		}
		[System.Diagnostics.Conditional("UNITY_EDITOR")]
		public static void LogError(object log)
		{
#if UNITY_EDITOR
			if(log == null)
			{
				UnityEngine.Debug.LogError(GetCallingMethodName());
			}
			else
			{
				UnityEngine.Debug.LogError($"<b>{log}</b>\n{GetCallingMethodName()}");
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
