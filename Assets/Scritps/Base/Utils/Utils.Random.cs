using System.Collections.Generic;

using UnityEngine;

namespace BC.Base
{
	public partial class Utils//.Random
	{
		public static T RandomInList<T>(this List<T> list)
		{
			int count = list.Count;
			if(count == 0) return default;

			int index = UnityEngine.Random.Range(0, count);
			return list[index];
		}
		public static int RandomIndex<T>(this List<T> list)
		{
			int count = list.Count;
			if(count == 0) return -1;

			return UnityEngine.Random.Range(0, count);
		}

		/// <summary>
		/// 지정된 probability 확률로 수치로 true 를 반환하는 함수
		/// offset의 기본 0 이다. + 값은 확률을 올리며, - 는 확률을 낮춘다. 
		/// probability + offset 가 1보다 크면 무조건 참이다.
		/// probability + offset 가 1보다 작으면 무조건 거짓이다.
		/// </summary>
		public static bool BernoulliTrial(float probability, float offset = 0f)
		{
			return probability + offset > Random.value;
		}

		/// <summary>
		/// A를 B로 나눈 값을 반환합니다.
		/// 무한대가 포함된 경우 적절하게 처리합니다.
		/// A / B가 0보다 작으면 0으로 반환합니다.
		/// </summary>
		public static float Probability_A_in_B(float A, float B)
		{
			if(A<0f) A = 0f;
			if(B<0f) B = 0f;
			if(Mathf.Approximately(A, 0f)) A = 0f;
			if(Mathf.Approximately(B, 0f)) B = 0f;
			bool isPositiveInfinity_A = float.IsPositiveInfinity(A);
			bool isPositiveInfinity_B = float.IsPositiveInfinity(B);

			//무한대 처리
			if(isPositiveInfinity_A)
			{
				return 1f;
			}
			if(isPositiveInfinity_B)
			{
				return 0f;
			}

			// 0인 경우 처리
			return B == 0f
				? (A == 0f) ? 0.5f : 1f
				: (A == 0f) ? 0f : A / B;
		}

		/// <summary>
		/// A와 B의 총 합에서 A가 차지하는 비율을 반환합니다.
		/// </summary>
		public static float Probability_A_in_sumAB(float A, float B)
		{
			if(A<0f) A = 0f;
			if(B<0f) B = 0f;
			bool isPositiveInfinity_A = float.IsPositiveInfinity(A);
			bool isPositiveInfinity_B = float.IsPositiveInfinity(B);

			if(isPositiveInfinity_A && isPositiveInfinity_B)
			{
				// 둘 다 무한대인 경우 정의되지 않으므로 예외를 던지거나 기본값 반환
				return 0.5f; // 또는 throw new ArgumentException("Both A and other are infinite.");
			}
			if(isPositiveInfinity_A)
			{
				// A가 무한대이고 B는 유한한 경우 A의 비율은 1
				return 1f;
			}
			if(isPositiveInfinity_B)
			{
				// B가 무한대이고 A는 유한한 경우 A의 비율은 0
				return 0f;
			}

			// A와 B가 유한한 경우
			float total = A + B;

			if(Mathf.Approximately(total, 0f))
			{
				// A와 B의 합이 0에 가까운 경우 비율을 0.5로 반환
				return 0.5f;
			}
			if(Mathf.Approximately(A, B))
			{
				// A와 Other가 값이 같을 때
				return 0.5f;
			}
			return A / total;
		}
		/// <summary>
		/// A와 other 배열의 총 합에서 A가 차지하는 비율을 반환합니다.
		/// </summary>
		public static float Probability_A_in_Total(float A, params float[] other)
		{
			int length = other.Length;
			if(length == 1)
			{
				return Probability_A_in_sumAB(A, other[0]);
			}
			if(A<0f) A = 0f;

			// 무한대 여부 검사
			bool isPositiveInfinity_A = float.IsPositiveInfinity(A);
			bool isPositiveInfinity_Other = false;

			// other 배열 내 무한대 여부 검사
			for(int o = 0 ; o < length ; o++)
			{
				if(float.IsPositiveInfinity(other[o]))
				{
					isPositiveInfinity_Other = true;
					break;
				}
			}

			if(isPositiveInfinity_A && isPositiveInfinity_Other)
			{
				// 둘 다 무한대인 경우 정의되지 않으므로 예외를 던지거나 기본값 반환
				return 0.5f; // 또는 throw new ArgumentException("Both A and other are infinite.");
			}
			if(isPositiveInfinity_A)
			{
				// A가 무한대이고 B는 유한한 경우 A의 비율은 1
				return 1f;
			}
			if(isPositiveInfinity_Other)
			{
				// other가 무한대이고 A는 유한한 경우 A의 비율은 0
				return 0f;
			}

			// 모든 other가 유한한 경우
			float sumOther = 0f;
			foreach(var v in other)
			{
				sumOther += v;
			}
			if(sumOther<0f) sumOther = 0f;
			float total = A + sumOther;

			// A와 Other의 총합이 0인 경우 0.5 반환
			if(Mathf.Approximately(total, 0f))
			{
				return 0.5f;
			}

			// A와 Other의 총합과 같을 때
			if(Mathf.Approximately(A, sumOther))
			{
				return 0.5f;
			}

			// 일반적인 경우 A / (A + sumOther)
			return A / total;
		}


		public static class RandomDistribution
		{
			/// <summary><code>
			/// 원형 랜덤 좌표의 X 값 사용 (-1~1)(고르게 0 으로 뭉침)
			/// </code></summary>
			public static float NextSemicircular()
			{
				return Random.insideUnitCircle.x;
			}
			/// <summary>
			/// 가우시한 분포중 정규분포를 가리키는 함수입니다.
			/// NextGaussian(0f, 1f); 와 동일합니다.
			/// </summary>
			public static float NextGaussianNormal()
			{
				return NextGaussian(0f, 1f);
			}
			/// <summary>
			/// 가우시한 분포 함수입니다.
			/// 중앙에 밀도가 높고, 양쪽으로 갈수록 낮아집니다.
			/// 양쪽은 이론상 무한대로 분산됩니다.
			/// </summary>
			public static float NextGaussian(float mean = 0f, float stdDev = 1f)
			{
				// Box-Muller 변환을 사용하여 표준 정규 분포 값 생성
				float u1 = 1.0f - UnityEngine.Random.value; // (0,1] 범위의 균등 분포
				float u2 = 1.0f - UnityEngine.Random.value;
				float randStdNormal = Mathf.Sqrt(-2.0f * Mathf.Log(u1)) * Mathf.Sin(2.0f * Mathf.PI * u2); // 표준 정규 분포 값

				// 평균과 표준편차를 적용하여 원하는 정규 분포 값 생성
				return mean + stdDev * randStdNormal;
			}
			/// <summary>
			/// -1 ~ 1 사이의 값이 나오도록 제한&조정된 가우시한 분포 함수입니다.
			/// 중앙에 밀도가 높고, 양쪽으로 갈수록 낮아집니다.
			/// NextGaussian(0f, 0.25f); 와 동일합니다.
			/// </summary>
			public static float NextGaussianSize1()
			{
				return Mathf.Clamp(NextGaussian(0f, 0.25f), -1f, 1f);
			}
			/// <summary>
			/// 0 ~ 1 사이의 값이 나오도록 제한&조정된 가우시한 분포 함수입니다.
			/// 중앙에 밀도가 높고, 양쪽으로 갈수록 낮아집니다.
			/// NextGaussian(0f, 0.25f); 와 동일합니다.
			/// </summary>
			public static float NextGaussianClamp1()
			{
				return (Mathf.Clamp(NextGaussian(0f, 0.25f), -1f, 1f) + 1f) * 0.5f;
			}
			/// <summary>
			/// 지수 분포 입니다.
			/// 값이 클수록 빈도가 낮아집니다.
			/// </summary>
			/// <param name="lambda"></param>
			/// <returns></returns>
			public static float NextExponential(float lambda)
			{
				float u = Random.Range(0f, 1f);
				return -Mathf.Log(1f - u) / lambda;
			}

			/// <summary>
			/// 삼각 분포를 따르는 랜덤한 float 값을 생성합니다.
			/// </summary>
			/// <param name="min">최소값</param>
			/// <param name="mode">최빈값</param>
			/// <param name="max">최대값</param>
			/// <returns>삼각 분포를 따르는 랜덤한 float 값</returns>
			public static float NextTriangular(float mode = 0f, float min = -1f, float max = 1f)
			{
				float u = Random.Range(0f, 1f);
				float c = (mode - min) / (max - min);

				if(u < c)
				{
					return min + Mathf.Sqrt(u * (max - min) * (mode - min));
				}
				else
				{
					return max - Mathf.Sqrt((1f - u) * (max - min) * (max - mode));
				}
			}
			/// <summary>
			/// 베타 분포를 따르는 랜덤 값을 생성합니다.
			/// </summary>
			/// <param name="alpha">감마 분포의 모수 α (α > 0)(1 보다 크면 값을 1 쪽으로 밀어내려고 함 1보다 작으면 값을 0 으로 가져오려고 함)</param>
			/// <param name="beta">감마 분포의 모수 β (β > 0)(1 보다 크면 값을 0 쪽으로 밀어내려고 함 1보다 작으면 값을 1 으로 가져오려고 함)</param>
			/// alpha / beta 가 둘다 1 이면 Random.value 과 동일함.
			/// <returns>베타 분포를 따르는 랜덤 값 (0 ~ 1)</returns>
			public static float NextBeta(float alpha, float beta)
			{
				// 약 0.03 보다 작으면 균형이 꺠짐
				if(alpha <= 0.03f) alpha = 0.03f;
				if(beta <= 0.03f) beta = 0.03f;

				float gamma1 = NextGamma(alpha, 1f);
				float gamma2 = NextGamma(beta, 1f);
				return gamma1 / (gamma1 + gamma2);
			}

			/// <summary>
			/// 감마 분포를 따르는 랜덤 값을 생성합니다.
			/// </summary>
			/// <param name="alpha">감마 분포의 모수 α (α > 0)</param>
			/// <param name="beta">감마 분포의 모수 β (β > 0)</param>
			/// <returns>감마 분포를 따르는 랜덤 값</returns>
			public static float NextGamma(float alpha, float beta)
			{
				if(alpha <= 0.00000001f) alpha = 0.00000001f;
				if(beta <= 0.00000001f) beta = 0.00000001f;

				if(alpha < 1)
				{
					// α < 1인 경우, α + 1로 조정하고 결과를 보정
					float u = Random.value;
					return NextGamma(alpha + 1, beta) * Mathf.Pow(u, 1f / alpha);
				}

				float d = alpha - 1f / 3f;
				float c = 1f / Mathf.Sqrt(9f * d);
				while(true)
				{
					float x = NextGaussianNormal();
					float v = 1f + c * x;
					if(v <= 0)
						continue;
					v = v * v * v;
					float u = Random.value;
					float y = x * x;
					if(u < 1f - 0.0331f * y * y)
						return d * v / beta;
					if(Mathf.Log(u) < 0.5f * y + d * (1f - v + Mathf.Log(v)))
						return d * v / beta;
				}
			}
		}

	}
}
