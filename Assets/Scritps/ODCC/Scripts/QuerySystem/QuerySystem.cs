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
	public class QuerySystemBuilder { }
	public sealed partial class OdccQueryBuilder : QuerySystemBuilder
	{
		internal Scene TargetScene;
		internal ObjectBehaviour TargetObject;
		internal OdccQuerySystem.RangeType Range;

		internal HashSet<int> Any = new HashSet<int>();
		internal HashSet<int> None = new HashSet<int>();
		internal HashSet<int> All = new HashSet<int>();
		private OdccQueryBuilder(OdccQuerySystem initQuerySystem = null)
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
		public static OdccQueryBuilder CreateQuery(OdccQuerySystem initQuerySystem = null)
		{
			return new OdccQueryBuilder(initQuerySystem);
		}
		public OdccQuerySystem Build(Scene scene)
		{
			TargetScene = scene;
			TargetObject = null;
			Range = OdccQuerySystem.RangeType.Scene;
			return _Build();
		}
		public OdccQuerySystem Build(ObjectBehaviour target, OdccQuerySystem.RangeType range)
		{
			TargetScene = default;
			TargetObject = null;

			range &= ~OdccQuerySystem.RangeType.Scene;
			if(range != OdccQuerySystem.RangeType.World && target != null)
			{
				TargetObject = target;
			}
			else
			{
				Range = OdccQuerySystem.RangeType.World;
			}
			Range = range;
			return _Build();
		}
		public OdccQuerySystem Build()
		{
			TargetScene = default;
			TargetObject = null;
			Range = OdccQuerySystem.RangeType.World;
			return _Build();
		}
		private OdccQuerySystem _Build()
		{
			return new OdccQuerySystem(TargetScene, TargetObject, Range,
				Any.OrderBy(x => x).ToArray(),
				None.OrderBy(x => x).ToArray(),
				All.OrderBy(x => x).ToArray());
		}
		public OdccQueryBuilder WithAny(params int[] typeIndexs)
		{
			foreach(var item in typeIndexs)
			{
				if(item<0) continue;
				Any.Add(item);
			}
			return this;
		}
		public OdccQueryBuilder WithNone(params int[] typeIndexs)
		{
			foreach(var item in typeIndexs)
			{
				if(item<0) continue;
				None.Add(item);
			}
			return this;
		}
		public OdccQueryBuilder WithAll(params int[] typeIndexs)
		{
			foreach(var item in typeIndexs)
			{
				if(item<0) continue;
				All.Add(item);
			}
			return this;
		}
		public OdccQueryBuilder ClearWithAny()
		{
			Any.Clear();
			return this;
		}
		public OdccQueryBuilder ClearWithNone()
		{
			None.Clear();
			return this;
		}
		public OdccQueryBuilder ClearWithAll()
		{
			All.Clear();
			return this;
		}
		public OdccQueryBuilder Clear()
		{
			Any.Clear();
			All.Clear();
			None.Clear();
			return this;
		}

		/// <summary>
		/// <code>WithAny() - where T : ObjectBehaviour
		/// return Build()</code>
		/// </summary>
		public static OdccQuerySystem SimpleQueryBuild<T>() where T : ObjectBehaviour
		{
			return CreateQuery().WithAny<T>().Build();
		}
	}

	[Serializable]
	public class OdccQuerySystem : IEquatable<OdccQuerySystem>
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
#if UNITY_EDITOR
		[ShowInInspector, ReadOnly, TextArea(0, 50), HideLabel]
		string onShowQuerySystem;
#endif

		internal OdccQuerySystem(Scene targetScene, ObjectBehaviour targetObject, RangeType range,
			int[] any, int[] none, int[] all)
		{
			TargetScene = targetScene;
			TargetObject = targetObject;
			Range = range;

			Any=any;
			None=none;
			All=all;

#if UNITY_EDITOR
			SetEditorQueryInfo();
			void SetEditorQueryInfo()
			{
				onShowQuerySystem = "OdccQuerySystem Info";
				Object targetObject = TargetObject;

				string rangeString = Enum.GetValues(typeof(OdccQuerySystem.RangeType))
					.Cast<OdccQuerySystem.RangeType>()
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
							int length = list.Count;
							for(int i = 0 ; i < length ; i++)
							{
								if(TargetObject == list[i] as ObjectBehaviour)
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
		public bool IsCheck(IEnumerable<int> odccItems)
		{
			bool result = IsAll(odccItems) && IsAny(odccItems) && IsNone(odccItems);
			return result;
		}
		private bool IsAny(IEnumerable<int> odccItems)
		{
			bool isEmpty = Any.Length == 0;
			if(isEmpty) return true;
			bool result = Any.Any((i) => odccItems.Contains(i));
			return result;
		}
		private bool IsNone(IEnumerable<int> odccItems)
		{
			bool isEmpty = None.Length == 0;
			if(isEmpty) return true;
			bool result = !None.Any((i) => odccItems.Contains(i));
			return result;
		}
		private bool IsAll(IEnumerable<int> odccItems)
		{
			bool isEmpty = All.Length == 0;
			if(isEmpty) return true;
			bool result = All.All((i) => odccItems.Contains(i));
			return result;
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as OdccQuerySystem);
		}
		public bool Equals(OdccQuerySystem other)
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
			return true;
		}
		public static bool operator ==(OdccQuerySystem lhs, OdccQuerySystem rhs)
		{
			if(ReferenceEquals(lhs, null))
				return ReferenceEquals(rhs, null);

			return lhs.Equals(rhs);
		}
		public static bool operator !=(OdccQuerySystem lhs, OdccQuerySystem rhs)
		{
			return !(lhs == rhs);
		}
		public override int GetHashCode()
		{
			int Length = All.Length + Any.Length + None.Length;
			int added = 0;
			for(int i = 0 ; i < All.Length ; i++) added += All[i];
			for(int i = 0 ; i < Any.Length ; i++) added += Any[i];
			for(int i = 0 ; i < None.Length ; i++) added += None[i];

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
			//Debug.Log($"item:{item}{item.name}");

			HashSet<int> indexs = new HashSet<int>();
			try
			{
				indexs.AddRange(OdccManager.GetObjectBehaviourUsingTypeArray(item));
			}
			catch(Exception ex)
			{
				Debug.LogError($"item:{item}{item.name}");
				Debug.LogException(ex);
			}

			bool result = IsRange(item) && IsCheck(indexs);
			return result;
		}
	}
}
