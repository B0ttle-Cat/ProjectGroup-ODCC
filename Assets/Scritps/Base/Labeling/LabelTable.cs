using System;

using Sirenix.OdinInspector;

using UnityEngine;

namespace BC.Base
{
	[CreateAssetMenu(fileName = "LabelTable", menuName = "BC/Base/LabelTable")]
	public class LabelTable : ScriptableObject
	{
		[ListDrawerSettings(CustomAddFunction = "CustomAddFunction", ShowFoldout = false, ShowPaging = false)]
		public Value[] List;

		[Serializable]
		[InlineProperty]
		public struct Value
		{
			[HideLabel]
			public string name;
			[HideIf("@true")]
			public string guid;
		}

		Value CustomAddFunction()
		{
			Value value = new Value();
			value.guid = Guid.NewGuid().ToString();
			value.name = "New Label";
			return value;
		}


		private void OnValidate()
		{
			int length = List.Length;
			for(int i = 0 ; i < length ; i++)
			{
				Value item = List[i];
				if(string.IsNullOrWhiteSpace(item.guid)) item.guid = Guid.NewGuid().ToString();
				item.name = item.name.Trim();
				List[i] = item;
			}
		}
	}
}
