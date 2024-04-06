using BC.Base;
using BC.ODCC;

using Sirenix.OdinInspector;

namespace BC.BaseUI
{
	public class ImageData : DataObject
	{
		[ReadOnly]
		public UnityEngine.UI.Image Image;
		public ColorTheme ColorThemeType;
	}
}
