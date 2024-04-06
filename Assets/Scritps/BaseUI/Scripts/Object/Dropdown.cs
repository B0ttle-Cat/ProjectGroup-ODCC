using UnityEngine;
using UnityEngine.Events;

namespace BC.BaseUI
{
	[RequireComponent(typeof(TMPro.TMP_Dropdown))]
	public class Dropdown : UIObject<TMPro.TMP_Dropdown>
	{
		DropdownData data;
		public DropdownData Data {
			get
			{
				if(data == null && !ThisContainer.TryGetData<DropdownData>(out data))
				{
					data = ThisContainer.AddData<DropdownData>();
				}
				return data;
			}
		}
		public int Value { get => UI.value; set => UI.value = value; }

		public override void BaseReset()
		{
			data = null;
			base.BaseReset();
			Data.Dropdown = UI;
			//VirtualAwake();

			GetComponentInChildren<DropdownList>(true)?.BaseReset();
		}
		public override void BaseValidate()
		{
			base.BaseValidate();
			Data.Dropdown = UI;
			//VirtualAwake();

			GetComponentInChildren<DropdownList>(true)?.BaseReset();
		}
		public override void BaseAwake()
		{
			base.BaseAwake();
			Data.Dropdown = UI;

			UI.onValueChanged.AddListener(BaseEvent);
		}
		protected virtual void BaseEvent(int value)
		{

		}
		public void SetValueWithoutNotify(int value)
		{
			UI.SetValueWithoutNotify(value);
		}
		public void RemoveAllListeners()
		{
			UI.onValueChanged.RemoveAllListeners();
			UI.onValueChanged.AddListener(BaseEvent);
		}
		public void RemoveListener(UnityAction<int> toggleEvent)
		{
			UI.onValueChanged.RemoveListener(toggleEvent);
		}
		public void AddListener(UnityAction<int> toggleEvent)
		{
			UI.onValueChanged.AddListener(toggleEvent);
		}

		public void OpenDropdownList(DropdownList dropdownList, bool isOn)
		{
			if(Data.Dropdown.template.gameObject == dropdownList.gameObject) return;


			if(isOn)
			{
				// Open
				UnityEngine.Canvas ListCanvas = dropdownList.GetComponent<UnityEngine.Canvas>();
				if(ListCanvas != null)
				{
					UnityEngine.Canvas[] canvas = null;
					canvas =  gameObject.GetComponentsInParent<UnityEngine.Canvas>();

					int maxSort = ListCanvas.sortingOrder;
					for(int i = 0 ; i < canvas.Length ; i++)
					{
						// 자신을 제외한 다른 캔버스들 중에서 && sortingOrder 같거나 높은 레이어가있으면
						if(canvas[i] != ListCanvas && maxSort <= canvas[i].sortingOrder)
						{
							// sortingOrder를 그보다 한단계 높게 잡는다.
							maxSort = canvas[i].sortingOrder + 1;
						}
					}
					ListCanvas.sortingOrder = maxSort;
				}


				dropdownList.SetScrollPosition(Data.ScrollPosition, (position) => Data.ScrollPosition = position);
			}
			else
			{
				// Close
			}
		}
	}
}
