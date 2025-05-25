using System;
using System.Collections.Generic;
using System.Threading;

using UnityEngine;

namespace BC.Base
{
	public static partial class TimeControl
	{
		public enum ControlSmoothnessType
		{
			None = 0,       // 즉시 변경. 보간 없이 스케일을 즉시 적용			// 초반 | 중반 | 후반
			Linear = 1,     // 선형 보간. 일정한 속도로 목표값까지 진행			// 일정 | 일정 | 일정
			Smooth = 2,     // 부드러운 곡선 보간. 시작과 끝이 완만한 S-커브		// 느림 | 빠름 | 느림
			EaseIn = 3,     // 점점 가속. 시작은 느리게, 끝은 빠르게				// 느림 | 보통 | 빠름
			EaseOut = 4,    // 점점 감속. 시작은 빠르게, 끝은 느리게				// 빠름 | 보통 | 느림
			EaseInOut = 5   // Smooth보다는 급격하게 변하는 곡선 흐름			// 느림 | 빠름 | 느림
		}

		private sealed class TempSmoothnessScope : IDisposable
		{
			private bool disposed = false;

			public TempSmoothnessScope(float lifeTime)
			{
				StartAutoClear(lifeTime);
			}

			private async void StartAutoClear(float delay)
			{
				try
				{
					await Awaitable.NextFrameAsync();
					if (disposed) return;

					Debug.LogWarning("[TimeControl] UsingTempSmoothness가 using 없이 호출 된 것으로 보입니다.");
					Dispose();
				}
				catch { }
			}

			public void Dispose()
			{
				if (disposed) return;
				disposed = true;

				TempSmoothness = null;
				TempSmoothnessTime = null;
			}
		}

		/// <summary>
		/// <code>컨트롤 동작에 일시적으로 부드러움(Smoothness) 타입과 지속 시간을 설정합니다.
		/// 자동으로 Dispose 되도록 using 과 함께 사용하여 제어하는 것을 권장합니다.
		/// 예) using (UsingSmoothness(...,...)) { ... }</code>
		/// </summary>
		/// <param name="smoothness">일시적으로 적용할 부드러움 타입입니다.</param>
		/// <param name="time">설정을 유지할 시간(초)입니다. 0보다 커야 합니다.</param>
		public static IDisposable UsingSmoothness(ControlSmoothnessType smoothness, float time)
		{
			TempSmoothness = smoothness;
			TempSmoothnessTime = time;

			return new TempSmoothnessScope(time);
		}

		private static ControlSmoothnessType? TempSmoothness = null;
		private static float? TempSmoothnessTime = null;
		private static ControlSmoothnessType Smoothness => TempSmoothness ?? ControlSmoothnessType.None;
		private static float SmoothnessTime => TempSmoothnessTime ?? 0;

		private static Dictionary<string, float> typeTimeScales = new Dictionary<string, float>();
		private static Dictionary<string, CancellationTokenSource> smoothnessScaleUpdateList = new Dictionary<string, CancellationTokenSource>();

		public static float GetTypeScale(string timeID)
		{
			if (string.IsNullOrWhiteSpace(timeID)) return 1f;
			return typeTimeScales != null && typeTimeScales.TryGetValue(timeID, out float scale) ? scale : 1f;
		}
		public static void SetTypeScale(float scale, string timeID)
		{
			if (string.IsNullOrWhiteSpace(timeID)) return;
			var smoothness = Smoothness;
			var smoothnessTime = SmoothnessTime;
#if UNITY_EDITOR
			Debug.Log($"TimeControl({smoothness}, {smoothnessTime}): {timeID} = {scale}");
#endif
			AsyncSetTypeScale(smoothness, smoothnessTime, timeID, GetTypeScale(timeID), scale);
		}
		public static void ResetTypeScale(string timeID)
		{
			if (typeTimeScales == null) return;
			if (string.IsNullOrWhiteSpace(timeID)) return;
			SetTypeScale(1f, timeID);
		}
		private static async void AsyncSetTypeScale(ControlSmoothnessType controlSmoothness, float smoothnessTime, string timeID, float currentScale, float targetScale)
		{
			if (string.IsNullOrWhiteSpace(timeID)) return;
			typeTimeScales ??= new Dictionary<string, float>();

			if (controlSmoothness == ControlSmoothnessType.None || smoothnessTime <= Time.unscaledDeltaTime || Mathf.Approximately(currentScale, targetScale))
			{
				if (Mathf.Approximately(targetScale, 1f))
				{
					typeTimeScales.Remove(timeID);
				}
				else
				{
					typeTimeScales[timeID] = targetScale;
				}
				return;
			}

			smoothnessScaleUpdateList ??= new Dictionary<string, CancellationTokenSource>();
			if (smoothnessScaleUpdateList.ContainsKey(timeID))
			{
				smoothnessScaleUpdateList[timeID].Cancel();
				smoothnessScaleUpdateList.Remove(timeID);
			}
			CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
			CancellationToken cancellationToken = cancellationTokenSource.Token;
			smoothnessScaleUpdateList.Add(timeID, cancellationTokenSource);
			try
			{
				Func<float, float> curve = controlSmoothness switch
				{
					ControlSmoothnessType.Linear => t => t,
					ControlSmoothnessType.Smooth => t => t * t * (3f - 2f * t),
					ControlSmoothnessType.EaseIn => t => t * t,
					ControlSmoothnessType.EaseOut => t => 1f - (1f - t) * (1f - t),
					ControlSmoothnessType.EaseInOut => t => t < 0.5f ? 2f * t * t : -1f + (4f - 2f * t) * t,
					_ => t => t,
				};


				float elapsed = 0f;
				while (elapsed < smoothnessTime && !cancellationToken.IsCancellationRequested)
				{
					elapsed += Time.unscaledDeltaTime;
					float t = Mathf.Clamp01(elapsed / smoothnessTime);
					typeTimeScales[timeID] = Mathf.Lerp(currentScale, targetScale, curve(t));
					await Awaitable.NextFrameAsync(cancellationToken);
				}
				if (cancellationToken.IsCancellationRequested)
				{
					return;
				}
			}
			catch (OperationCanceledException)
			{
				// 의도된 취소는 무시
			}
			catch (Exception e)
			{
				Debug.LogException(e); // 최소한의 로그 확보
				typeTimeScales[timeID] = targetScale; // 예외 발생 시에도 최종 목표 스케일을 설정
			}
			finally
			{
				smoothnessScaleUpdateList.Remove(timeID);
				cancellationTokenSource.Dispose();
			}

			if (typeTimeScales.TryGetValue(timeID, out float finalScale) && Mathf.Approximately(finalScale, 1f))
			{
				typeTimeScales.Remove(timeID);
			}
		}
		public static void ApplyTypeScale(string timeID)
		{
			float timeScale = GetTypeScale(timeID);
			Time.timeScale = timeScale < 0 ? 0 : timeScale;
		}

		public static float GetTypeScale<T>() => GetTypeScale(typeof(T).Name);
		public static void SetTypeScale<T>(float scale) => SetTypeScale(scale, typeof(T).Name);
		public static void ResetTypeScale<T>() => ResetTypeScale(typeof(T).Name);
		public static void ApplyTypeScale<T>() => ApplyTypeScale(typeof(T).Name);

		public static void SetTypeScale(float scale, params string[] timeIDs)
		{
			int length = timeIDs == null ? 0 : timeIDs.Length;
			for (int i = 0 ; i<length ; i++)
			{
				SetTypeScale(scale, timeIDs[i]);
			}
		}
		public static void ResetTypeScale(params string[] timeIDs)
		{
			int length = timeIDs == null ? 0 : timeIDs.Length;
			for (int i = 0 ; i<length ; i++)
			{
				ResetTypeScale(timeIDs[i]);
			}
		}
	}
}