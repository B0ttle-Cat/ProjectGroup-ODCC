using BC.Base;

using TMPro;

using UnityEngine;
using UnityEngine.Events;

namespace BC.BaseUI
{
	[RequireComponent(typeof(UnityEngine.UI.Button))]
	public class Button : UIObject<UnityEngine.UI.Button>
	{
		private ButtonData data;
		ButtonData Data {
			get
			{
				if(data == null)
				{
					if(!ThisContainer.TryGetData<ButtonData>(out data))
					{
						data = ThisContainer.AddData<ButtonData>();
					}
					data.Button = UI;
					data.Image = UI.targetGraphic as UnityEngine.UI.Image;
					data.Text = UI.gameObject.GetComponentInChildren<TMP_Text>();
				}
				return data;
			}
		}
		public UnityEngine.UI.Image Image => Data.Image;
		public TMP_Text Text => Data.Text;

		public AudioClip buttonSound;
		public override void BaseReset()
		{
			data = null;
			base.BaseReset();
			Data.Button = UI;
		}
		public override void BaseValidate()
		{
			base.BaseValidate();
			Data.Button = UI;

			if(Theme.GetAsset(Data.ColorThemeType, out Color color))
			{
				Data.Image.color = color;
			}
			if(Theme.GetAsset(Data.AudioThemeType, out AudioClip buttonSound))
			{
				Data.ButtonSound = buttonSound;
			}
		}
		public override void BaseAwake()
		{
			base.BaseAwake();
			Data.Button = UI;
			if(Theme.GetAsset(Data.ColorThemeType, out Color color))
			{
				Data.Image.color = color;
			}
			if(Theme.GetAsset(Data.AudioThemeType, out AudioClip buttonSound))
			{
				Data.ButtonSound = buttonSound;
			}
			UI.onClick.AddListener(BaseEvent);
		}
		protected virtual void BaseEvent()
		{

		}
		public void RemoveAllListeners()
		{
			UI.onClick.RemoveAllListeners();
			UI.onClick.AddListener(BaseEvent);
		}
		public void RemoveListener(UnityAction toggleEvent)
		{
			UI.onClick.RemoveListener(toggleEvent);
		}
		public void AddListener(UnityAction toggleEvent)
		{
			UI.onClick.AddListener(toggleEvent);
		}
	}
}
