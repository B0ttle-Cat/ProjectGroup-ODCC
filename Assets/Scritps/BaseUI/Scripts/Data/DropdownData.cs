using BC.ODCC;

using Sirenix.OdinInspector;

using UnityEngine;

namespace BC.BaseUI
{
	public class DropdownData : DataObject
	{
		[ReadOnly]
		public TMPro.TMP_Dropdown Dropdown;
		public Vector2 ScrollPosition = Vector2.up;
	}
}
