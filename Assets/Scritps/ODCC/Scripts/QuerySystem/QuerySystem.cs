using System;
using System.Collections.Generic;
using System.Linq;

using Sirenix.OdinInspector;
using Sirenix.Utilities;

using UnityEngine;
using UnityEngine.SceneManagement;

using Object = UnityEngine.Object;

namespace BC.ODCC
{
	public sealed partial class QuerySystemBuilder
	{
		internal Scene TargetScene;
		internal ObjectBehaviour TargetObject;
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
			TargetObject = null;
			Range = QuerySystem.RangeType.Scene;
			return _Build();
		}
		public QuerySystem Build(ObjectBehaviour target, QuerySystem.RangeType range)
		{
			TargetScene = default;
			TargetObject = null;

			range &= ~QuerySystem.RangeType.Scene;
			if(range != QuerySystem.RangeType.World && target != null)
			{
				TargetObject = target;
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
			TargetObject = null;
			Range = QuerySystem.RangeType.World;
			return _Build();
		}
		private QuerySystem _Build()
		{
			return new QuerySystem(TargetScene, TargetObject, Range,
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
				if(checkInheritance || OdccManager.CheckIsInterface(item))
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
				if(checkInheritance || OdccManager.CheckIsInterface(item))
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
				if(checkInheritance || OdccManager.CheckIsInterface(item))
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


		/// <summary>
		/// <code>WithAny() - where T : ObjectBehaviour
		/// return Build()</code>
		/// </summary>
		public static QuerySystem SimpleQueryBuild<T>(bool checkInheritance = false) where T : ObjectBehaviour
		{
			return CreateQuery().WithAny<T>(checkInheritance).Build();
		}
	}

	[Serializable]
	public class QuerySystem : IEquatable<QuerySystem>
	{
		internal Scene TargetScene;
		internal ObjectBehaviour TargetObject;
		internal RangeType Range;
		[Flags]
		public enum RangeType : int
		{
			World  = 0,         // 전역 범위 검색
			Scene  = 0b_0001,   // 이 씬에서만 검색
			Object = 0b_0010,   // 이 오브젝트에서 검색
			Parent = 0b_0100,   // 이 부모에세 검색
			Child  = 0b_1000,   // 이 자식객체에서 검색

			CheckInFamilyTree = 0b_0001_0000,

			ObjectAndChild = Object | Child,
			ObjectAndParent = Object | Parent,
		}


		internal readonly int[] Any = Array.Empty<int>();
		internal readonly int[] None = Array.Empty<int>();
		internal readonly int[] All = Array.Empty<int>();

		internal readonly int[] InheritanceOfAny = Array.Empty<int>();
		internal readonly int[] InheritanceOfNone = Array.Empty<int>();
		internal readonly int[] InheritanceOfAll = Array.Empty<int>();

		internal bool UsingInheritance = false;
#if UNITY_EDITOR
		[ShowInInspector, ReadOnly, TextArea(0, 50), HideLabel]
		string onShowQuerySystem;
#endif

		internal QuerySystem(Scene targetScene, ObjectBehaviour targetObject, RangeType range,
			int[] any, int[] none, int[] all,
			int[] inheritanceOfAny, int[] inheritanceOfNone, int[] inheritanceOfAll)
		{
			TargetScene = targetScene;
			TargetObject = targetObject;
			Range = range;

			Any=any;
			None=none;
			All=all;
			InheritanceOfAny = inheritanceOfAny;
			InheritanceOfNone = inheritanceOfNone;
			InheritanceOfAll = inheritanceOfAll;

			UsingInheritance = InheritanceOfAny.Length > 0 || InheritanceOfNone.Length > 0 || InheritanceOfAll.Length > 0;
#if UNITY_EDITOR
			SetEditorQueryInfo();
			void SetEditorQueryInfo()
			{
				onShowQuerySystem = "QuerySystem Info";
				Object targetObject = TargetObject;

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

			var opc = RangeType.Object | RangeType.Parent | RangeType.Child;
			if((Range & opc) > 0 && item is not null)
			{
				if(Range.HasFlag(RangeType.Object))
				{
					return TargetObject == item;
				}
				if(Range.HasFlag(RangeType.Child))
				{
					if(Range.HasFlag(RangeType.CheckInFamilyTree))
					{
						var list = item.GetComponentsInParent<ObjectBehaviour>(true);
						if(list != null)
						{
							int length = list.Length;
							for(int i = 1 ; i < length ; i++)
							{
								if(TargetObject == list[i])
								{
									return true;
								}
							}
						}
					}
					else
					{
						var parent = item.ThisContainer.ParentObject;
						if(parent != null && TargetObject == parent)
						{
							return true;
						}
					}
				}
				if(Range.HasFlag(RangeType.Parent))
				{
					if(Range.HasFlag(RangeType.CheckInFamilyTree))
					{
						var list = item.GetComponentsInChildren<ObjectBehaviour>(true);
						if(list != null)
						{
							int length = list.Length;
							for(int i = 1 ; i < length ; i++)
							{
								if(TargetObject == list[i])
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
								if(TargetObject == list[i])
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
		public bool IsCheck(IEnumerable<int> odccItems, IEnumerable<int> odccInheritanceItems)
		{
			bool result = IsAll(odccItems, odccInheritanceItems) && IsAny(odccItems, odccInheritanceItems) && IsNone(odccItems, odccInheritanceItems);
			return result;
		}
		private bool IsAny(IEnumerable<int> odccItems, IEnumerable<int> odccInheritanceItems)
		{
			bool isEmpty = Any.Length + InheritanceOfAny.Length == 0;
			if(isEmpty) return true;
			bool result
				= Any.Any((i) => odccItems.Contains(i))
				|| InheritanceOfAny.Any((i) => odccInheritanceItems.Contains(i));
			return result;
		}
		private bool IsNone(IEnumerable<int> odccItems, IEnumerable<int> odccInheritanceItems)
		{
			bool isEmpty = None.Length + InheritanceOfNone.Length == 0;
			if(isEmpty) return true;
			bool result
				= !None.Any((i) => odccItems.Contains(i))
				|| !InheritanceOfNone.Any((i)  => odccInheritanceItems.Contains(i));
			return result;
		}
		private bool IsAll(IEnumerable<int> odccItems, IEnumerable<int> odccInheritanceItems)
		{
			bool isEmpty = All.Length + InheritanceOfAll.Length == 0;
			if(isEmpty) return true;
			bool result
				= All.All((i) => odccItems.Contains(i))
				&& InheritanceOfAll.All((i)  => odccInheritanceItems.Contains(i));
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
				if(TargetObject != other.TargetObject) return false;
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

		internal bool IsSatisfiesQuery(ObjectBehaviour item)
		{
			Debug.Log($"item:{item}{item.name}");

			HashSet<int> indexs = new HashSet<int>();
			HashSet<int> indexInheritances = new HashSet<int>();
			try
			{
				indexs.AddRange(OdccManager.GetTypeToIndex(item));
				if(UsingInheritance)
				{
					indexInheritances.AddRange(indexs);
					indexInheritances.AddRange(OdccManager.GetTypeInheritanceTable(item));
				}
			}
			catch(Exception ex)
			{
				Debug.LogError($"item:{item}{item.name}");
				Debug.LogException(ex);
			}

			if(UsingInheritance)
			{
				try
				{

				}
				catch(Exception ex)
				{
					Debug.LogError($"item:{item}{item.name}");
					Debug.LogException(ex);
				}
			}

			bool result = IsRange(item) && IsCheck(indexs, indexInheritances);
			return result;
		}
	}
}
