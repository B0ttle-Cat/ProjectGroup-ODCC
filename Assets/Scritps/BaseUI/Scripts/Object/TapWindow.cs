using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

namespace BC.BaseUI
{
	public class TapWindow : UIObject<ScrollRect>
	{
		private TapWindowData data;
		public TapWindowData Data {
			get
			{
				if(!ThisContainer.TryGetData<TapWindowData>(out data))
				{
					data = ThisContainer.AddData<TapWindowData>();
				}
				return data;
			}
		}

		public override void BaseReset()
		{
			base.BaseReset();
			SetupTabWindowUI();
		}

		//protected override void VirtualOnTransformParentChanged()
		//{
		//	base.VirtualOnTransformParentChanged();
		//	SetupTabWindowUI();
		//}

		private void SetupTabWindowUI()
		{
			var data = Data;

			data.ScrollRect = UI;
			data.ToggleGroup = GetComponentInChildren<ToggleGroup>(true);
			data.ContentList = new List<TapWindowData.Content>();

			Toggle[] toggles = data.ToggleGroup.GetComponentsInChildren<Toggle>(true);
			var viewport = data.ScrollRect.viewport;
			RectUIObject[] rectTransforms = new RectUIObject[viewport.childCount];
			for(int i = 0 ; i < viewport.childCount ; i++)
			{
				rectTransforms[i] = viewport.GetChild(i).GetComponent<RectUIObject>();
			}

			int count = Mathf.Max(toggles.Length ,rectTransforms.Length);
			for(int i = 0 ; i < count ; i++)
			{
				TapWindowData.Content content = new TapWindowData.Content();
				if(i < toggles.Length)
				{
					content.tabToggle = toggles[i];
				}
				if(i < rectTransforms.Length)
				{
					content.tabItem = rectTransforms[i];
				}
				data.ContentList.Add(content);
			}
#if UNITY_EDITOR
			for(int i = 0 ; i < count ; i++)
			{
				int index = i;
				if(data.ContentList[index].tabToggle == null)
				{
					Debug.LogError($"Missing Toggle: {index} Index");
					data.ContentList.RemoveAt(index);
				}
				else if(data.ContentList[index].tabItem == null)
				{
					Debug.LogError($"Missing Item: {index} Index");
					data.ContentList.RemoveAt(index);
				}
				else
				{
					index = -1;
				}

				if(index >= 0)
				{
					data.ContentList.RemoveAt(i--);
				}
			}
#endif
		}

		public override void BaseAwake()
		{
			InitUIObject(Data);
		}


		private void InitUIObject(TapWindowData data)
		{
			for(int i = 0 ; i < data.ContentList.Count ; i++)
			{
				int index = i;
				data.ContentList[index].tabToggle.UI.onValueChanged.RemoveAllListeners();
				data.ContentList[index].tabToggle.UI.onValueChanged.AddListener((bool isOn) =>
				{
					if(isOn)
					{
						int prevIndex = data.currentIndex;
						data.currentIndex = index;
						OnTabChangeListener(data, index, prevIndex);
					}
				});
			}
		}

		private void OnTabChangeListener(TapWindowData data, int next, int prev)
		{
			if(next != prev && next < data.ContentList.Count && prev < data.ContentList.Count)
			{
				var prevContent = data.ContentList[prev];
				if(prevContent != null && prevContent.tabItem != null)
				{
					data.ScrollRect.content = null;
					prevContent.tabItem.OnUnactiveAndPlayHide();
				}

				var nextContent = data.ContentList[next];
				if(nextContent != null && nextContent.tabItem != null)
				{
					data.ScrollRect.content = nextContent.tabItem.UI;
					data.ScrollRect.content.anchoredPosition = Vector3.zero;
					nextContent.tabItem.OnActiveAndPlayShow();
				}
			}

		}
	}
}
