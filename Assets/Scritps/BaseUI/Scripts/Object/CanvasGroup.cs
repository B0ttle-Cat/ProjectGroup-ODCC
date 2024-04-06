using UnityEngine;

namespace BC.BaseUI
{
	[RequireComponent(typeof(UnityEngine.CanvasGroup))]
	public class CanvasGroup : UIObject<UnityEngine.CanvasGroup>
	{
		public override void BaseReset()
		{
			base.BaseReset();

			CanvasGroupData data = null;
			if(!ThisContainer.TryGetData<CanvasGroupData>(out data))
			{
				data = ThisContainer.AddData<CanvasGroupData>();
			}
			data.CanvasGroup = UI;
		}
	}
}
