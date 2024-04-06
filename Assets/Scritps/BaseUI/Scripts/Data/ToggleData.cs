using BC.Base;
using BC.ODCC;

using Sirenix.OdinInspector;

using TMPro;

namespace BC.BaseUI
{
	public class ToggleData : DataObject
	{
		[ReadOnly]
		public UnityEngine.UI.Toggle Toggle;
		public UnityEngine.UI.Image Image;

		public ColorTheme ColorThemeType;
		public AudioTheme AudioThemeType;

		public TMP_Text Text;
	}
}
