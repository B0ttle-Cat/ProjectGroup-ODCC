using TMPro;

using UnityEngine;
using UnityEngine.Events;

namespace BC.BaseUI
{
	[RequireComponent(typeof(UnityEngine.UI.Toggle))]
	public class Toggle : UIObject<UnityEngine.UI.Toggle>
	{
		private ToggleData data;
		ToggleData Data {
			get
			{
				if(data == null)
				{
					if(!ThisContainer.TryGetData<ToggleData>(out data))
					{
						data = ThisContainer.AddData<ToggleData>();
					}
					data.Toggle = UI;
					data.Image = UI.targetGraphic as UnityEngine.UI.Image;
					data.Text = UI.gameObject.GetComponentInChildren<TMP_Text>();
				}
				return data;
			}
		}
		public UnityEngine.UI.Image Image => Data.Image;
		public bool IsOn { get => UI.isOn; set => UI.isOn = value; }

		public override void BaseReset()
		{
			data = null;
			base.BaseReset();
			Data.Toggle = UI;
		}
		public override void BaseValidate()
		{
			base.BaseReset();
			Data.Toggle = UI;
		}
		public override void BaseAwake()
		{
			base.BaseAwake();
			Data.Toggle = UI;
		}
		protected virtual void BaseEvent(bool isOn)
		{

		}
		public void SetIsOnWithoutNotify(bool setIsOn)
		{
			UI.SetIsOnWithoutNotify(setIsOn);
		}
		public void RemoveAllListeners()
		{
			UI.onValueChanged.RemoveAllListeners();
			UI.onValueChanged.AddListener(BaseEvent);
		}
		public void RemoveListener(UnityAction<bool> toggleEvent)
		{
			UI.onValueChanged.RemoveListener(toggleEvent);
		}
		public void AddListener(UnityAction<bool> toggleEvent)
		{
			UI.onValueChanged.AddListener(toggleEvent);
		}
	}
}
