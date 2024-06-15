using BC.Base;
using BC.ODCC;

using Sirenix.OdinInspector;

using TMPro;

using UnityEngine;

namespace BC.BaseUI
{
	public class ButtonData : DataObject
	{
		[ReadOnly]
		public UnityEngine.UI.Button Button;
		public UnityEngine.UI.Image Image;
		public AudioClip ButtonSound;

		public ColorTheme ColorThemeType;
		public AudioTheme AudioThemeType;

		public TMP_Text Text;

		protected override void Disposing()
		{
			base.Disposing();
			Button = null;
			Image = null;
			ButtonSound = null;
			Text = null;
		}
	}
}
