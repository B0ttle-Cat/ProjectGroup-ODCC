using System;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

namespace BC.Base
{
	public static partial class Utils
	{
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
			if(min.CompareTo(max) > 0)
				return value;
			else if(value.CompareTo(min) < 0)
				return min;
			else if(value.CompareTo(max) > 0)
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
			if(list == null || list.Count == 0) return true;
			return false;
		}
		public static List<T> ClearAndNull<T>(this List<T> list)
		{
			if(list == null) return null;
			else list.Clear();
			return null;
		}
		public static List<T> NullToNew<T>(this List<T> list)
		{
			return list ?? new List<T>();
		}
		public static List<T> AddRangeNext<T>(this List<T> list, IEnumerable<T> collection)
		{
			if(list == null || collection == null) return list;
			list.AddRange(collection);
			return list;
		}
		public static List<T> ForEachNext<T>(this List<T> list, Action<T> action)
		{
			if(list == null || action == null) return list;
			list.ForEach(action);
			return list;
		}
		public static void ForeachIndex<T>(this List<T> list, Action<T, int> action)
		{
			if(list == null || action == null) return;

			for(int i = 0 ; i < list.Count ; i++)
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
			if(list == null || keySelector == null) return list;

			return list.OrderBy(keySelector).ToList();
		}
		public static List<TSource> OrderByDescendingList<TSource, TKey>(this List<TSource> list, Func<TSource, TKey> keySelector)
		{
			if(list == null || keySelector == null) return list;

			return list.OrderByDescending(keySelector).ToList();
		}
		public static List<TSource> AddAndOrderByList<TSource, TKey>(this List<TSource> list, TSource source, Func<TSource, TKey> keySelector)
			where TKey : IComparable<TKey>
		{
			if(list == null || source == null || keySelector == null) return list;

			int index = list.FindIndex(item => keySelector(item).CompareTo(keySelector(source)) > 0);

			if(index < 0)
				index = ~index;

			list.Insert(index, source);
			return list;
		}
		public static List<TSource> AddAndOrderByDescendingList<TSource, TKey>(this List<TSource> list, TSource source, Func<TSource, TKey> keySelector)
			where TKey : IComparable<TKey>
		{
			if(list == null || source == null || keySelector == null)
				return list;

			int index = list.FindIndex(item => keySelector(item).CompareTo(keySelector(source)) < 0);

			if(index < 0)
				index = list.Count;

			list.Insert(index, source);
			return list;
		}
		public static List<T> RemoveTo<T>(this List<T> list, Func<T, bool> action)
		{
			if(list == null || action == null) return list;

			for(int i = 0 ; i < list.Count ; i++)
			{
				bool remove = action.Invoke(list[i]);
				if(remove)
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
			while(n > 1)
			{
				n--;
				int k = UnityEngine.Random.Range(0, n + 1);
				T value = list[k];
				list[k] = list[n];
				list[n] = value;
			}
		}


		#endregion
	}
}
