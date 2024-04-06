using BC.Base;

using TMPro;

using UnityEngine;

namespace BC.BaseUI
{
	[RequireComponent(typeof(TMPro.TMP_Text))]
	public class Text : UIObject<TMPro.TMP_Text>
	{
		TextData data = null;
		public TextData Data {
			get
			{
				if(!ThisContainer.TryGetData<TextData>(out data))
				{
					data = ThisContainer.AddData<TextData>();
				}
				return data;
			}
		}
		public string text { get => UI.text; set => UI.text = value; }

		public override void BaseReset()
		{
			data = null;
			base.BaseReset();
			Data.Text = UI;
		}
		public override void BaseValidate()
		{
			base.BaseValidate();
			Data.Text = UI;

			if(Theme.GetAsset(Data.TextTheme, out string themeName))
			{
				if(Data.Text.styleSheet != null)
				{
					Data.Text.textStyle = Data.Text.styleSheet.GetStyle(themeName);
				}
				else if(TMP_Settings.defaultStyleSheet != null)
				{
					Data.Text.textStyle = TMP_Settings.defaultStyleSheet.GetStyle(themeName);
				}
			}
		}
		public override void BaseAwake()
		{
			base.BaseAwake();
			Data.Text = UI;
		}

		public void OnChangeValue(string value)
		{
			UI.text = string.Format(Data.onChangeValueFormat, value);
		}
		public void OnChangeValue(float value)
		{
			UI.text = string.Format(Data.onChangeValueFormat, value);
		}
		public void OnChangeValue(int value)
		{
			UI.text = string.Format(Data.onChangeValueFormat, value);
		}
	}
}
