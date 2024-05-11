using BC.ODCC;

using Sirenix.OdinInspector;

using UnityEngine.UI;

namespace BC.BaseUI
{
	public class CanvasData : DataObject
	{
		[ReadOnly] public UnityEngine.Canvas Canvas;
		[ReadOnly] public CanvasScaler CanvasScaler;
		[ReadOnly] public GraphicRaycaster GraphicRaycaster;
		[ReadOnly] public UnityEngine.CanvasGroup CanvasGroup;

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			Canvas = null;
			CanvasScaler = null;
			GraphicRaycaster = null;
			CanvasGroup = null;
		}
	}
}
