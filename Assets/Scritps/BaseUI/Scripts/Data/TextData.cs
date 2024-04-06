using BC.Base;
using BC.ODCC;

using Sirenix.OdinInspector;

using TMPro;

namespace BC.BaseUI
{
	public class TextData : DataObject
	{
		[ReadOnly]
		public TMP_Text Text;
		public TextTheme TextTheme;

		public string onChangeValueFormat;
	}
}
