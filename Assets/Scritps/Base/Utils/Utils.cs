using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

using UnityEngine;

namespace BC.Base
{
	public static partial class Utils
	{
		#region String Util
		public static bool IsNullOrWhiteSpace(this string value)
		{
			return string.IsNullOrWhiteSpace(value);
		}
		public static bool IsNotNullOrWhiteSpace(this string value)
		{
			return !string.IsNullOrWhiteSpace(value);
		}


		public static int StringKeywordMatching(IEnumerable<string> names, string keyword, int thresholdScore = 10)
		{
			if (string.IsNullOrWhiteSpace(keyword) || names == null || names.Count()==0)
				return -1;

			var nameList = names.ToList();
			string Normalize(string input) =>
				new string(input.Where(char.IsLetterOrDigit).ToArray()).ToLower();

			string[] Tokenize(string input) =>
				Regex.Split(input.ToLower(), @"[^가-힣a-zA-Z0-9]+")
					 .Where(x => !string.IsNullOrWhiteSpace(x))
					 .ToArray();

			string normalizedKey = Normalize(keyword);
			string[] keyTokens = Tokenize(keyword);

			int BestScore(string[] keyTokens, string[] nameTokens, string normalizedName)
			{
				int score = 0;
				foreach (var token in keyTokens)
				{
					if (nameTokens.Contains(token))
						score += 10;
					else if (normalizedName.Contains(token))
						score += 5;
				}
				return score;
			}

			int bestScore = -1;
			int bestIndex = -1;

			for (int i = 0 ; i < nameList.Count ; i++)
			{
				var name = nameList[i];
				var normalizedName = Normalize(name);
				var nameTokens = Tokenize(name);

				int score = BestScore(keyTokens, nameTokens, normalizedName);

				if (score > bestScore)
				{
					bestScore = score;
					bestIndex = i;
				}
			}

			return bestScore >= thresholdScore ? bestIndex : -1;
		}


		#endregion

		public static bool IsDefault<T>(this T value) where T : struct
		{
			return value.Equals(default(T));
		}
		public static bool IsLarger<T>(this T value, T greaterThan) where T : IComparable<T>
		{
			return value.CompareTo(greaterThan) > 0;
		}
		public static bool IsLargerOrEqual<T>(this T value, T greaterThanOrEqual) where T : IComparable<T>
		{
			return value.CompareTo(greaterThanOrEqual) >= 0;
		}
		public static bool IsSmaller<T>(this T value, T lessThan) where T : IComparable<T>
		{
			return value.CompareTo(lessThan) < 0;
		}
		public static bool IsSmallerOrEqual<T>(this T value, T lessThanOrEqual) where T : IComparable<T>
		{
			return value.CompareTo(lessThanOrEqual) <= 0;
		}

		public static bool InRange<T>(this T value, T min, T max) where T : IComparable<T>
		{
			return min.CompareTo(max) < 0 && min.CompareTo(value) < 0 && value.CompareTo(max) < 0;
		}
		public static bool InRangeOrEqual<T>(this T value, T min, T max) where T : IComparable<T>
		{
			return min.CompareTo(max) <= 0 && min.CompareTo(value) <= 0 && value.CompareTo(max) <= 0;
		}
		public static bool OutRange<T>(this T value, T min, T max) where T : IComparable<T>
		{
			return !InRangeOrEqual(value, min, max);
		}
		public static bool OutRangeOrEqual<T>(this T value, T min, T max) where T : IComparable<T>
		{
			return !InRange(value, min, max);
		}

		public static bool NotEquals<T>(this T value, T notEquals) where T : IEquatable<T>
		{
			return !value.Equals(notEquals);
		}

		public static T ClampMin<T>(this T value, T min) where T : IComparable<T>
		{
			return value.CompareTo(min) < 0 ? min : value;
		}
		public static T ClampMax<T>(this T value, T max) where T : IComparable<T>
		{
			return value.CompareTo(max) > 0 ? max : value;
		}
		public static T ClampMinMax<T>(this T value, T min, T max) where T : IComparable<T>
		{
			if (min.CompareTo(max) > 0)
				return value;
			else if (value.CompareTo(min) < 0)
				return min;
			else if (value.CompareTo(max) > 0)
				return max;
			else
				return value;
		}

		public static float DeltaTime(this float value, float scale = 1f) => value * Time.deltaTime * scale;

		/// <summary>
		/// 반올림.
		/// </summary>
		public static float RoundTo(this float value, int placesNumber = 0)
		{
			float multiplier = Mathf.Pow(10, -placesNumber);
			return Mathf.Round(value * multiplier) / multiplier;
		}
		/// <summary>
		/// 올림.
		/// </summary>
		public static float CeilTo(this float value, int placesNumber = 0)
		{
			float multiplier = Mathf.Pow(10, -placesNumber);
			return Mathf.Ceil(value * multiplier) / multiplier;
		}
		/// <summary>
		/// 내림.
		/// </summary>
		public static float FloorTo(this float value, int placesNumber = 0)
		{
			float multiplier = Mathf.Pow(10, -placesNumber);
			return Mathf.Floor(value * multiplier) / multiplier;

		}

		#region List
		public static bool IsNullOrEmpty<T>(this List<T> list)
		{
			if (list == null || list.Count == 0) return true;
			return false;
		}
		public static List<T> ClearAndNull<T>(this List<T> list)
		{
			if (list == null) return null;
			else list.Clear();
			return null;
		}
		public static List<T> NullToNew<T>(this List<T> list)
		{
			return list ?? new List<T>();
		}
		public static List<T> AddRangeNext<T>(this List<T> list, IEnumerable<T> collection)
		{
			if (list == null || collection == null) return list;
			list.AddRange(collection);
			return list;
		}
		public static List<T> ForEachNext<T>(this List<T> list, Action<T> action)
		{
			if (list == null || action == null) return list;
			list.ForEach(action);
			return list;
		}
		public static void ForeachIndex<T>(this List<T> list, Action<T, int> action)
		{
			if (list == null || action == null) return;

			for (int i = 0 ; i < list.Count ; i++)
			{
				action?.Invoke(list[i], i);
			}
		}
		public static List<T> ForeachIndexNext<T>(this List<T> list, Action<T, int> action)
		{
			ForeachIndex(list, action);
			return list;
		}

		public static List<TSource> OrderByList<TSource, TKey>(this List<TSource> list, Func<TSource, TKey> keySelector)
		{
			if (list == null || keySelector == null) return list;

			return list.OrderBy(keySelector).ToList();
		}
		public static List<TSource> OrderByDescendingList<TSource, TKey>(this List<TSource> list, Func<TSource, TKey> keySelector)
		{
			if (list == null || keySelector == null) return list;

			return list.OrderByDescending(keySelector).ToList();
		}
		public static List<TSource> AddAndOrderByList<TSource, TKey>(this List<TSource> list, TSource source, Func<TSource, TKey> keySelector)
			where TKey : IComparable<TKey>
		{
			if (list == null || source == null || keySelector == null) return list;

			int index = list.FindIndex(item => keySelector(item).CompareTo(keySelector(source)) > 0);

			if (index < 0)
				index = ~index;

			list.Insert(index, source);
			return list;
		}
		public static List<TSource> AddAndOrderByDescendingList<TSource, TKey>(this List<TSource> list, TSource source, Func<TSource, TKey> keySelector)
			where TKey : IComparable<TKey>
		{
			if (list == null || source == null || keySelector == null)
				return list;

			int index = list.FindIndex(item => keySelector(item).CompareTo(keySelector(source)) < 0);

			if (index < 0)
				index = list.Count;

			list.Insert(index, source);
			return list;
		}
		public static List<T> RemoveTo<T>(this List<T> list, Func<T, bool> action)
		{
			if (list == null || action == null) return list;

			for (int i = 0 ; i < list.Count ; i++)
			{
				bool remove = action.Invoke(list[i]);
				if (remove)
				{
					list.RemoveAt(i);
					i--;
				}
			}
			return list;
		}
		public static void Shuffle<T>(this List<T> list)
		{
			int n = list.Count;
			while (n > 1)
			{
				n--;
				int k = UnityEngine.Random.Range(0, n + 1);
				T value = list[k];
				list[k] = list[n];
				list[n] = value;
			}
		}
		#endregion


		public static int ToLayer(this LayerMask layerMask)
		{
			return ToLayer(layerMask.value);
		}

		public static int ToLayer(int bitmask)
		{
			int result = bitmask>0 ? 0 : 31;
			while (bitmask>1)
			{
				bitmask = bitmask>>1;
				result++;
			}
			return result;
		}
		public static List<int> ToLayers(this LayerMask layerMask)
		{
			return ToLayers(layerMask.value);
		}
		public static LayerMask GetHitLayerMask(this LayerMask layerMask, bool andMask = true)
		{
			int resultMask = 0;

			// 기준 레이어들을 추출
			var baseLayers = layerMask.ToLayers();

			// 모든 레이어(0~31)를 확인
			for (int targetLayer = 0 ; targetLayer < 32 ; targetLayer++)
			{
				// 타겟 레이어가 존재하지 않으면 건너뜀
				if (string.IsNullOrEmpty(LayerMask.LayerToName(targetLayer)))
					continue;

				bool hitConditionMet = andMask; // 초기 조건 설정

				// 기준 레이어와의 충돌 여부를 확인
				foreach (int baseLayer in baseLayers)
				{
					bool canCollide = !Physics.GetIgnoreLayerCollision(baseLayer, targetLayer);

					if (andMask && !canCollide)
					{
						hitConditionMet = false;  // 모두 충돌이어야 하는데 하나라도 충돌이 안 되면 실패
						break;
					}
					else if (!andMask && canCollide)
					{
						hitConditionMet = true;  // 하나라도 충돌하면 성공
						break;
					}
				}

				// 조건에 맞으면 결과에 추가
				if (hitConditionMet)
				{
					resultMask |= (1 << targetLayer);
				}
			}

			return resultMask;
		}
		public static List<int> ToLayers(int bitmask)
		{
			List<int> layers = new List<int>();
			for (int i = 0 ; i < 32 ; i++)
			{
				if ((bitmask & 1<<i) > 0)
				{
					layers.Add(i);
				}
			}
			return layers;
		}
		public static bool HasLayer(this LayerMask layerMask, int layerIndex)
		{
			return (layerMask.value & (1 << layerIndex)) > 0;
		}
	}
}
