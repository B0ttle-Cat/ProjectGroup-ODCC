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
		internal HashSet<int> InheritanceOfAny = new HashSet<int>();
		internal HashSet<int> InheritanceOfNone = new HashSet<int>();
		internal HashSet<int> InheritanceOfAll = new HashSet<int>();

		private QuerySystemBuilder(QuerySystem initQuerySystem = null)
		{
			Any = new HashSet<int>();
			None = new HashSet<int>();
			All = new HashSet<int>();
			InheritanceOfAny = new HashSet<int>();
			InheritanceOfNone = new HashSet<int>();
			InheritanceOfAll = new HashSet<int>();
			if(initQuerySystem != null)
			{
				Any = initQuerySystem.Any.ToHashSet();
				None = initQuerySystem.None.ToHashSet();
				All = initQuerySystem.All.ToHashSet();

				InheritanceOfAny = initQuerySystem.InheritanceOfAny.ToHashSet();
				InheritanceOfNone = initQuerySystem.InheritanceOfNone.ToHashSet();
				InheritanceOfAll = initQuerySystem.InheritanceOfAll.ToHashSet();
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
				All.OrderBy(x => x).ToArray(),
				InheritanceOfAny.OrderBy(x => x).ToArray(),
				InheritanceOfNone.OrderBy(x => x).ToArray(),
				InheritanceOfAll.OrderBy(x => x).ToArray());
		}

		public QuerySystemBuilder WithAny(bool checkInheritance, params int[] typeIndexs)
		{
			foreach(var item in typeIndexs)
			{
				if(item<0) continue;
				if(checkInheritance)
				{
					InheritanceOfAny.Add(item);
				}
				else
				{
					Any.Add(item);
				}
			}
			return this;
		}
		public QuerySystemBuilder WithNone(bool checkInheritance, params int[] typeIndexs)
		{
			foreach(var item in typeIndexs)
			{
				if(item<0) continue;
				if(checkInheritance)
				{
					InheritanceOfNone.Add(item);
				}
				else
				{
					None.Add(item);
				}
			}
			return this;
		}
		public QuerySystemBuilder WithAll(bool checkInheritance, params int[] typeIndexs)
		{
			foreach(var item in typeIndexs)
			{
				if(item<0) continue;
				if(checkInheritance)
				{
					InheritanceOfAll.Add(item);
				}
				else
				{
					All.Add(item);
				}
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
		internal readonly int[] Any = Array.Empty<int>();
		internal readonly int[] None = Array.Empty<int>();
		internal readonly int[] All = Array.Empty<int>();

		internal readonly int[] InheritanceOfAny = Array.Empty<int>();
		internal readonly int[] InheritanceOfNone = Array.Empty<int>();
		internal readonly int[] InheritanceOfAll = Array.Empty<int>();


		internal QuerySystem(int[] any, int[] none, int[] all,
			int[] inheritanceOfAny, int[] inheritanceOfNone, int[] inheritanceOfAll
			)
		{
			Any=any;
			None=none;
			All=all;
			InheritanceOfAny = inheritanceOfAny;
			InheritanceOfNone = inheritanceOfNone;
			InheritanceOfAll = inheritanceOfAll;
		}
		public bool IsAny(IEnumerable<int> odccItems)
		{
			bool result
				= (Any.Length == 0 || Any.Any((i) => odccItems.Contains(i)))
				|| (InheritanceOfAny.Length == 0 || InheritanceOfAny.Any((i) => OdccManager.CheckIsInheritanceIndex(i, odccItems)));
			return result;
		}

		public bool IsNone(IEnumerable<int> odccItems)
		{
			bool result
				= (None.Length == 0 || !None.Any((i) => odccItems.Contains(i)))
				|| (InheritanceOfNone.Length == 0 || !InheritanceOfNone.Any((i) => OdccManager.CheckIsInheritanceIndex(i, odccItems)));
			return result;
		}

		public bool IsAll(IEnumerable<int> odccItems)
		{
			bool result =
				(All.Length == 0 || All.All((i) => odccItems.Contains(i)))
				&& (InheritanceOfAll.Length == 0 || InheritanceOfAll.All((i) => OdccManager.CheckIsInheritanceIndex(i, odccItems)));
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
			if(!ArraysEquivalent(InheritanceOfAll, other.InheritanceOfAll))
				return false;
			if(!ArraysEquivalent(InheritanceOfAny, other.InheritanceOfAny))
				return false;
			if(!ArraysEquivalent(InheritanceOfNone, other.InheritanceOfNone))
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
			result = (result * 397) ^ (InheritanceOfAll ?? Array.Empty<int>()).GetHashCode();
			result = (result * 397) ^ (InheritanceOfAny ?? Array.Empty<int>()).GetHashCode();
			result = (result * 397) ^ (InheritanceOfNone ?? Array.Empty<int>()).GetHashCode();
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
