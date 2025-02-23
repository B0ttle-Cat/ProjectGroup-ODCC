using System;
using System.Linq;

using BC.ODCC;

using Sirenix.OdinInspector;

using UnityEngine;

namespace BC.OdccBase
{
	public class TransformMapping : ComponentBehaviour
	{
		[SerializeField]
		private TransformMap[] transformMap = new TransformMap[0];

		[Serializable]
		private struct TransformMap
		{
			[HideLabel]
			public string mapKey;
			[HideLabel]
			public Transform transform;
		}
		public bool TryFindTransform(string key, out Transform transform, bool ignoreCase = false, bool ignoreWhitespace = false)
		{
			transform = null;
			if(string.IsNullOrWhiteSpace(key)) return false;

			if(ignoreWhitespace)
			{
				key = new string(key.Where(c => !char.IsWhiteSpace(c)).ToArray());
			}

			for(int i = 0, length = transformMap?.Length ?? 0 ; i < length ; i++)
			{
				var map = transformMap[i];
				var mapKey = ignoreWhitespace
					? new string(map.mapKey.Where(c => !char.IsWhiteSpace(c)).ToArray())
					: map.mapKey;

				bool isEquals = ignoreCase
					? string.Equals(key, mapKey, StringComparison.OrdinalIgnoreCase)
					: string.Equals(key, mapKey, StringComparison.Ordinal);

				if(isEquals)
				{
					transform = map.transform;
					break;
				}
			}
			return transform != null;
		}
	}
}
