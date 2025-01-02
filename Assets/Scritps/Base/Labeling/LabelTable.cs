using System;

using Sirenix.OdinInspector;

using UnityEngine;

namespace BC.Base
{
	[CreateAssetMenu(fileName = "LabelTable", menuName = "BC/Base/LabelTable")]
	public class LabelTable : ScriptableObject
	{
		[ListDrawerSettings(CustomAddFunction = "CustomAddLabel", ShowPaging = false)]
		public Label[] List;

		[Serializable]
		[InlineProperty]
		public struct Label
		{
			[HideLabel]
			public string name;
			[HideIf("@true")]
			public string guid;
		}

#if UNITY_EDITOR
		Label CustomAddLabel()
		{
			Label value = new Label();
			value.guid = Guid.NewGuid().ToString();
			value.name = "New Label";
			return value;
		}
		internal Label EditorAddLabel(string label)
		{
			Label value = new Label();
			value.guid = Guid.NewGuid().ToString();
			value.name = label;
			return value;
		}

		private void OnValidate()
		{
			int length = List.Length;
			for(int i = 0 ; i < length ; i++)
			{
				Label item = List[i];
				if(string.IsNullOrWhiteSpace(item.guid)) item.guid = Guid.NewGuid().ToString();
				item.name = item.name.Trim();
				List[i] = item;
			}

			if(keywordExtractor == null) keywordExtractor = new KeywordExtractor();
		}

		[SerializeField, FoldoutGroup("키워드 추출기"), InlineProperty, HideLabel]
		[HideReferenceObjectPicker]
		private KeywordExtractor keywordExtractor;
#endif
	}
}
