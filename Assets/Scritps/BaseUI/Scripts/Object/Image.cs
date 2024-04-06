using BC.Base;

using UnityEngine;

namespace BC.BaseUI
{
	[RequireComponent(typeof(UnityEngine.UI.Image))]
	public class Image : UIObject<UnityEngine.UI.Image>
	{
		ImageData data;
		public ImageData Data {
			get
			{
				if(data == null && !ThisContainer.TryGetData<ImageData>(out data))
				{
					data = ThisContainer.AddData<ImageData>();
				}
				return data;
			}
		}
		public override void BaseReset()
		{
			data = null;
			base.BaseReset();
			Data.Image = UI;
		}
		public override void BaseValidate()
		{
			base.BaseValidate();
			Data.Image = UI;

			if(Theme.GetAsset(Data.ColorThemeType, out Color color))
			{
				Data.Image.color = color;
			}
		}
		public override void BaseAwake()
		{
			base.BaseAwake();
			Data.Image = UI;
		}

		public void OnToggleToDisable(bool isOn)
		{
			UI.enabled = !isOn;
		}
		public void OnToggleToEnable(bool isOn)
		{
			UI.enabled = isOn;
		}

		public void OnDropdownValueIs_0(int index) => UI.enabled = index == 0;
		public void OnDropdownValueIs_1(int index) => UI.enabled = index == 1;
		public void OnDropdownValueIs_2(int index) => UI.enabled = index == 2;
		public void OnDropdownValueIs_3(int index) => UI.enabled = index == 3;
		public void OnDropdownValueIs_4(int index) => UI.enabled = index == 4;
		public void OnDropdownValueIs_5(int index) => UI.enabled = index == 5;
		public void OnDropdownValueIs_6(int index) => UI.enabled = index == 6;
		public void OnDropdownValueIs_7(int index) => UI.enabled = index == 7;
		public void OnDropdownValueIs_8(int index) => UI.enabled = index == 8;
		public void OnDropdownValueIs_9(int index) => UI.enabled = index == 9;
		public void OnDropdownValueIsNot_0(int index) => UI.enabled = index != 0;
		public void OnDropdownValueIsNot_1(int index) => UI.enabled = index != 1;
		public void OnDropdownValueIsNot_2(int index) => UI.enabled = index != 2;
		public void OnDropdownValueIsNot_3(int index) => UI.enabled = index != 3;
		public void OnDropdownValueIsNot_4(int index) => UI.enabled = index != 4;
		public void OnDropdownValueIsNot_5(int index) => UI.enabled = index != 5;
		public void OnDropdownValueIsNot_6(int index) => UI.enabled = index != 6;
		public void OnDropdownValueIsNot_7(int index) => UI.enabled = index != 7;
		public void OnDropdownValueIsNot_8(int index) => UI.enabled = index != 8;
		public void OnDropdownValueIsNot_9(int index) => UI.enabled = index != 9;
	}
}
