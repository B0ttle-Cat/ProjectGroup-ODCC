using System;
using System.Collections.Generic;
using System.Linq;

namespace BC.ODCC
{
	public sealed partial class QuerySystemBuilder
	{
		internal HashSet<int> Any = new HashSet<int>();
		internal HashSet<int> None = new HashSet<int>();
		internal HashSet<int> All = new HashSet<int>();

		private QuerySystemBuilder(QuerySystem initQuerySystem = null)
		{
			Any = new HashSet<int>();
			None = new HashSet<int>();
			All = new HashSet<int>();

			if(initQuerySystem != null)
			{
				Any = initQuerySystem.Any.ToHashSet();
				None = initQuerySystem.None.ToHashSet();
				All = initQuerySystem.All.ToHashSet();
			}
		}
		public static QuerySystemBuilder CreateQuery(QuerySystem initQuerySystem = null)
		{
			return new QuerySystemBuilder(initQuerySystem);
		}
		public QuerySystem Build()
		{
			return new QuerySystem(
				Any.OrderBy(x => x).ToArray(),
				None.OrderBy(x => x).ToArray(),
				All.OrderBy(x => x).ToArray());
		}

		public QuerySystemBuilder WithAny(params int[] typeIndexs)
		{
			foreach(var item in typeIndexs)
			{
				if(item>=0) Any.Add(item);
			}
			return this;
		}
		public QuerySystemBuilder WithNone(params int[] typeIndexs)
		{
			foreach(var item in typeIndexs)
			{
				if(item>=0) None.Add(item);
			}
			return this;
		}
		public QuerySystemBuilder WithAll(params int[] typeIndexs)
		{
			foreach(var item in typeIndexs)
			{
				if(item>=0) All.Add(item);
			}
			return this;
		}

		public QuerySystemBuilder ClearWithAny()
		{
			Any.Clear();
			return this;
		}
		public QuerySystemBuilder ClearWithNone()
		{
			None.Clear();
			return this;
		}
		public QuerySystemBuilder ClearWithAll()
		{
			All.Clear();
			return this;
		}
	}

	public class QuerySystem : IEquatable<QuerySystem>
	{
		/// <summary>
		/// Any 리스트에 있는 하나 이상의 컴포넌트 유형을 포함하는 아키타입을 포함합니다.
		/// </summary>
		internal readonly int[] Any = Array.Empty<int>();
		/// <summary>
		/// 이 컴포넌트 유형을 포함하지 않는 아키타입을 포함합니다.
		/// </summary>
		internal readonly int[] None = Array.Empty<int>();
		/// <summary>
		/// All 리스트에 있는 모든 컴포넌트 유형을 포함하는 아키타입을 포함합니다.
		/// </summary>
		internal readonly int[] All = Array.Empty<int>();

		internal QuerySystem(int[] any, int[] none, int[] all)
		{
			Any=any;
			None=none;
			All=all;
		}
		public bool IsAny(IEnumerable<int> odccItems)
		{
			bool result = Any.Length == 0 || Any.Any((i) => odccItems.Contains(i));
			return result;
		}

		public bool IsNone(IEnumerable<int> odccItems)
		{
			bool result = None.Length == 0 || !None.Any((i) => odccItems.Contains(i));
			return result;
		}

		public bool IsAll(IEnumerable<int> odccItems)
		{
			bool result = All.Length == 0 || All.All((i) => odccItems.Contains(i));
			return result;
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as QuerySystem);
		}
		public bool Equals(QuerySystem other)
		{
			if(ReferenceEquals(this, other))
				return true;
			if(ReferenceEquals(null, other))
				return false;
			if(!ArraysEquivalent(All, other.All))
				return false;
			if(!ArraysEquivalent(Any, other.Any))
				return false;
			if(!ArraysEquivalent(None, other.None))
				return false;
			return true;
		}
		public static bool operator ==(QuerySystem lhs, QuerySystem rhs)
		{
			if(ReferenceEquals(lhs, null))
				return ReferenceEquals(rhs, null);

			return lhs.Equals(rhs);
		}
		public static bool operator !=(QuerySystem lhs, QuerySystem rhs)
		{
			return !(lhs == rhs);
		}
		public override int GetHashCode()
		{
			int result = 17;
			result = (result * 397) ^ (All ?? Array.Empty<int>()).GetHashCode();
			result = (result * 397) ^ (Any ?? Array.Empty<int>()).GetHashCode();
			result = (result * 397) ^ (None ?? Array.Empty<int>()).GetHashCode();
			return result;
		}

		static bool ArraysEquivalent(int[] a1, int[] a2)
		{
			if(ReferenceEquals(a1, a2))
				return true;

			if(a1 == null || a2 == null)
				return false;

			if(a1.Length != a2.Length)
				return false;

			return a1.SequenceEqual(a2);
		}
	}
}
