using UnityEngine;
using UnityEngine.Events;

namespace BC.BaseUI
{
	[RequireComponent(typeof(UnityEngine.UI.Slider))]
	public class Slider : UIObject<UnityEngine.UI.Slider>
	{
		SliderData data;
		public SliderData Data {
			get
			{
				if(data == null && !ThisContainer.TryGetData<SliderData>(out data))
				{
					data = ThisContainer.AddData<SliderData>();
				}
				return data;
			}
		}
		public float Value { get => UI.value; set => UI.value = value; }

		public override void BaseReset()
		{
			data = null;
			base.BaseReset();
			Data.Slider = UI;
			//VirtualAwake();

			GetComponentInChildren<DropdownList>(true)?.BaseReset();
		}
		public override void BaseValidate()
		{
			base.BaseValidate();
			Data.Slider = UI;
			//VirtualAwake();

			GetComponentInChildren<DropdownList>(true)?.BaseReset();
		}
		public override void BaseAwake()
		{
			base.BaseAwake();
			Data.Slider = UI;

			UI.onValueChanged.AddListener(BaseEvent);
		}
		protected virtual void BaseEvent(float value)
		{

		}
		public void SetValueWithoutNotify(float value)
		{
			UI.SetValueWithoutNotify(value);
		}
		public void RemoveAllListeners()
		{
			UI.onValueChanged.RemoveAllListeners();
			UI.onValueChanged.AddListener(BaseEvent);
		}
		public void RemoveListener(UnityAction<float> toggleEvent)
		{
			UI.onValueChanged.RemoveListener(toggleEvent);
		}
		public void AddListener(UnityAction<float> toggleEvent)
		{
			UI.onValueChanged.AddListener(toggleEvent);
		}
	}
}
