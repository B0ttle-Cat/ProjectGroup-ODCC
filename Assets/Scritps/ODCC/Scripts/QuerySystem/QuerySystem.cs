using System;
using System.Collections.Generic;
using System.Linq;

using Sirenix.OdinInspector;

using UnityEngine;
using UnityEngine.SceneManagement;

using Object = UnityEngine.Object;

namespace BC.ODCC
{
	public sealed partial class QuerySystemBuilder
	{
		internal Scene TargetScene;
		internal int TargetInstanceID;
		internal QuerySystem.RangeType Range;

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
		public QuerySystem Build(Scene scene)
		{
			TargetScene = scene;
			TargetInstanceID = 0;
			Range = QuerySystem.RangeType.Scene;
			return _Build();
		}
		public QuerySystem Build(ObjectBehaviour target, QuerySystem.RangeType range)
		{
			TargetScene = default;
			TargetInstanceID = 0;

			range &= ~QuerySystem.RangeType.Scene;
			if(range != QuerySystem.RangeType.World && target != null)
			{
				TargetInstanceID = target.GetInstanceID();
			}
			else
			{
				Range = QuerySystem.RangeType.World;
			}
			Range = range;
			return _Build();
		}
		public QuerySystem Build()
		{
			TargetScene = default;
			TargetInstanceID = 0;
			Range = QuerySystem.RangeType.World;
			return _Build();
		}
		private QuerySystem _Build()
		{
			return new QuerySystem(TargetScene, TargetInstanceID, Range,
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

	[Serializable]
	public class QuerySystem : IEquatable<QuerySystem>
	{
		internal Scene TargetScene;
		internal int TargetInstanceID;
		internal RangeType Range;
		[Flags]
		public enum RangeType : int
		{
			World  = 0,         // 전역 범위 검색
			Scene  = 0b_0001,   // 이 씬에서만 검색
			Object = 0b_0010,   // 이 오브젝트에서 검색
			Parent = 0b_0100,   // 이 부모에세 검색
			Child  = 0b_1000,   // 이 자식객체에서 검색

			AllObjectRoot = 0b_0001_0000,

			ObjectAndChild = Object | Child,
			ObjectAndParent = Object | Parent,
		}


		internal readonly int[] Any = Array.Empty<int>();
		internal readonly int[] None = Array.Empty<int>();
		internal readonly int[] All = Array.Empty<int>();

		internal readonly int[] InheritanceOfAny = Array.Empty<int>();
		internal readonly int[] InheritanceOfNone = Array.Empty<int>();
		internal readonly int[] InheritanceOfAll = Array.Empty<int>();


#if UNITY_EDITOR
		[ShowInInspector, ReadOnly, TextArea(0, 50), HideLabel]
		string onShowQuerySystem;
#endif

		internal QuerySystem(Scene targetScene, int targetInstanceID, RangeType range,
			int[] any, int[] none, int[] all,
			int[] inheritanceOfAny, int[] inheritanceOfNone, int[] inheritanceOfAll)
		{
			TargetScene = targetScene;
			TargetInstanceID = targetInstanceID;
			Range = range;

			Any=any;
			None=none;
			All=all;
			InheritanceOfAny = inheritanceOfAny;
			InheritanceOfNone = inheritanceOfNone;
			InheritanceOfAll = inheritanceOfAll;

#if UNITY_EDITOR
			SetEditorQueryInfo();
			void SetEditorQueryInfo()
			{
				onShowQuerySystem = "QuerySystem Info";
				Object targetObject = TargetInstanceID == 0 ? null : UnityEditor.EditorUtility.InstanceIDToObject(TargetInstanceID);

				string rangeString = Enum.GetValues(typeof(QuerySystem.RangeType))
					.Cast<QuerySystem.RangeType>()
					.Where(r => Range.HasFlag(r))
					.Select(r => r.ToString())
					.Aggregate((current, next) => current + " | " + next);
				onShowQuerySystem += $"\nTargetRange : {rangeString}";
				onShowQuerySystem += $"\nTargetScene : {TargetScene.name}";
				if(!Range.HasFlag(RangeType.World) && Range.HasFlag(RangeType.Scene) && TargetScene != default)
					onShowQuerySystem += $"\nTargetScene : {TargetScene.name}";
				if(!Range.HasFlag(RangeType.World) && Range.HasFlag(RangeType.Object | RangeType.Child | RangeType.Parent) &&  targetObject != null)
					onShowQuerySystem += $"\nTargetObject : {targetObject.name}";
				onShowQuerySystem += $"\nAny : {string.Join(" | ", Any.Select(index => $"{index}:{OdccManager.GetIndexToType(index)?.Name}"))}";
				onShowQuerySystem += $"\nNone : {string.Join(" | ", None.Select(index => $"{index}:{OdccManager.GetIndexToType(index)?.Name}"))}";
				onShowQuerySystem += $"\nAll : {string.Join(" | ", All.Select(index => $"{index}:{OdccManager.GetIndexToType(index)?.Name}"))}";
				onShowQuerySystem += $"\nInheritanceOfAny : {string.Join(" | ", InheritanceOfAny.Select(index => $"{index}:{OdccManager.GetIndexToType(index)?.Name}"))}";
				onShowQuerySystem += $"\nInheritanceOfNone : {string.Join(" | ", InheritanceOfNone.Select(index => $"{index}:{OdccManager.GetIndexToType(index)?.Name}"))}";
				onShowQuerySystem += $"\nInheritanceOfAll : {string.Join(" | ", InheritanceOfAll.Select(index => $"{index}:{OdccManager.GetIndexToType(index)?.Name}"))}";
			}
#endif
		}

		public bool IsRange(ObjectBehaviour item)
		{
			if(Range == RangeType.World) return true;
			if(Range == RangeType.Scene) return item.gameObject.scene == TargetScene;

			if(Range.HasFlag(RangeType.Object | RangeType.Parent | RangeType.Child) && item is not null)
			{
				if(Range.HasFlag(RangeType.Object))
				{
					int instanceID = item.GetInstanceID();
					return TargetInstanceID == instanceID;
				}
				if(Range.HasFlag(RangeType.Parent))
				{
					if(Range.HasFlag(RangeType.AllObjectRoot))
					{
						var list = item.GetComponentsInParent<ObjectBehaviour>(true);
						if(list != null)
						{
							int length = list.Length;
							for(int i = 1 ; i < length ; i++)
							{
								if(TargetInstanceID == list[i].GetInstanceID())
								{
									return true;
								}
							}
						}
					}
					else
					{
						var parent = item.ThisContainer.ParentObject;
						if(parent != null && TargetInstanceID == parent.GetInstanceID())
						{
							return true;
						}
					}
				}
				if(Range.HasFlag(RangeType.Child))
				{
					if(Range.HasFlag(RangeType.AllObjectRoot))
					{
						var list = item.GetComponentsInChildren<ObjectBehaviour>(true);
						if(list != null)
						{
							int length = list.Length;
							for(int i = 1 ; i < length ; i++)
							{
								if(TargetInstanceID == list[i].GetInstanceID())
								{
									return true;
								}
							}
						}
					}
					else
					{
						var list = item.ThisContainer.ChildObject;
						if(list != null)
						{
							int length = list.Length;
							for(int i = 0 ; i < length ; i++)
							{
								if(TargetInstanceID == list[i].GetInstanceID())
								{
									return true;
								}
							}
						}

					}
				}
			}

			return false;
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
			bool result
				= (All.Length == 0 || All.All((i) => odccItems.Contains(i)))
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
			if(Range == other.Range)
			{
				if(TargetScene.name != other.TargetScene.name) return false;
				if(TargetInstanceID != other.TargetInstanceID) return false;
			}
			else
			{
				return false;
			}
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
			int Length = All.Length + Any.Length + None.Length + InheritanceOfAll.Length + InheritanceOfAny.Length + InheritanceOfNone.Length;
			int added = 0;
			for(int i = 0 ; i < All.Length ; i++) added += All[i];
			for(int i = 0 ; i < Any.Length ; i++) added += Any[i];
			for(int i = 0 ; i < None.Length ; i++) added += None[i];
			for(int i = 0 ; i < InheritanceOfAll.Length ; i++) added += InheritanceOfAll[i];
			for(int i = 0 ; i < InheritanceOfAny.Length ; i++) added += InheritanceOfAny[i];
			for(int i = 0 ; i < InheritanceOfNone.Length ; i++) added += InheritanceOfNone[i];

			int intRange = (int)Range;

			return Length + added + intRange;
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
