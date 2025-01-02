using Sirenix.OdinInspector;

using UnityEngine;

namespace BC.Base
{
	public class Labeling : MonoBehaviour
	{
		public string function = "Labeling";
		[SerializeField]
		[ValueDropdown("ValueDropdownList",IsUniqueList = true)]
		private string[] labels;

		private ValueDropdownList<string> ValueDropdownList()
		{
			var list = new ValueDropdownList<string>();
			var labels = LabelManager.LabelTable.List;
			int length = labels.Length;
			for(int i = 0 ; i < length ; i++)
			{
				list.Add(labels[i].name, labels[i].guid);
			}
			return list;
		}
		public string[] Labels { get => labels; set => labels=value; }
	}
}
