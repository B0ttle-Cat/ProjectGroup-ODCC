using System.Collections.Generic;
using System.Linq;

using UnityEngine;

namespace BC.Base
{
	public static class LabelManager
	{
		private static LabelTable labelTable;
		public static LabelTable LabelTable {
			get {
				if(labelTable == null)
				{
					labelTable = Resources.Load<LabelTable>("LabelTable");
				}
				return labelTable;
			}
		}
		public static Labeling GetLabel(this GameObject targets) => targets == null ? null : targets.GetComponent<Labeling>();
		public static Labeling GetLabelInChildren(this GameObject targets, bool includeInactive = false) => targets == null ? null : targets.GetComponentInChildren<Labeling>(includeInactive);
		public static Labeling[] GetLabels(this GameObject targets) => targets == null ? null : targets.GetComponents<Labeling>();
		public static Labeling[] GetLabelsInChildren(this GameObject targets, bool includeInactive = false) => targets == null ? null : targets.GetComponentsInChildren<Labeling>(includeInactive);
		public static Labeling GetLabel(this Behaviour targets) => targets == null ? null : targets.GetComponent<Labeling>();
		public static Labeling GetLabelInChildren(this Behaviour targets, bool includeInactive = false) => targets == null ? null : targets.GetComponentInChildren<Labeling>(includeInactive);
		public static Labeling[] GetLabels(this Behaviour targets) => targets == null ? null : targets.GetComponents<Labeling>();
		public static Labeling[] GetLabelsInChildren(this Behaviour targets, bool includeInactive = false) => targets == null ? null : targets.GetComponentsInChildren<Labeling>(includeInactive);
		/// <summary>
		/// 모든 조건을 만족하는 Labeling을 필터링합니다.
		/// </summary>
		public static IEnumerable<Labeling> Filtering(this IEnumerable<Labeling> targets, LabelFilter filter)
		{
			return targets.Where(x => {
				// all 조건: 모든 필터 조건을 만족해야 함
				if(filter.all != null && filter.all.Length > 0)
				{
					if(filter.all.Any(y => !x.Labels.Contains(y)))
						return false;
				}
				// not 조건: 포함되면 안 됨
				if(filter.not != null && filter.not.Length > 0)
				{
					if(filter.not.Any(y => x.Labels.Contains(y)))
						return false;
				}
				// any 조건: 하나라도 포함되어야 함
				if(filter.any != null && filter.any.Length > 0)
				{
					if(!filter.any.Any(y => x.Labels.Contains(y)))
						return false;
				}

				return true;
			});
		}
		/// <summary>
		/// 모든 조건을 만족하는 Labeling 필터링
		/// </summary>
		public static IEnumerable<Labeling> FilterByAll(this IEnumerable<Labeling> targets, string[] all)
		{
			if(all == null || all.Length == 0)
				return targets;

			return targets.Where(x => {
				if(x.Labels == null || x.Labels.Length == 0)
					return false;

				return all.All(y => x.Labels.Contains(y));
			});
		}
		/// <summary>
		/// 하나라도 조건을 만족하는 Labeling 필터링
		/// </summary>
		public static IEnumerable<Labeling> FilterByAny(this IEnumerable<Labeling> targets, string[] any)
		{
			if(any == null || any.Length == 0)
				return targets;

			return targets.Where(x => {
				if(x.Labels == null || x.Labels.Length == 0)
					return false;

				return any.Any(y => x.Labels.Contains(y));
			});
		}
		/// <summary>
		/// 조건을 포함하지 않는 Labeling 필터링
		/// </summary>
		public static IEnumerable<Labeling> FilterByNot(this IEnumerable<Labeling> targets, string[] not)
		{
			if(not == null || not.Length == 0)
				return targets;

			return targets.Where(x => {
				if(x.Labels == null || x.Labels.Length == 0)
					return true; // Label이 없으면 포함되지 않는다고 판단

				return !not.Any(y => x.Labels.Contains(y));
			});
		}
		/// <summary>
		/// 모든 equals 조건을 만족하는 Labeling을 필터링합니다.
		/// </summary>
		/// <param name="targets">대상 Labeling 리스트</param>
		/// <param name="equals">포함되어야 하는 문자열 리스트</param>
		/// <returns>조건을 만족하는 Labeling 리스트</returns>
		public static IEnumerable<Labeling> FilterByEquals(this IEnumerable<Labeling> targets, string[] equals)
		{
			// equals가 비어있거나 null이면 전체 리스트 반환
			if(equals == null || equals.Length == 0)
			{
				return targets;
			}

			// 모든 equals 항목이 Label에 포함된 Labeling만 필터링
			return targets.Where(x => {
				if(x.Labels == null || x.Labels.Length == 0 || x.Labels.Length != equals.Length)
					return false;

				return equals.All(y => x.Labels.Contains(y));
			});
		}
	}
}
