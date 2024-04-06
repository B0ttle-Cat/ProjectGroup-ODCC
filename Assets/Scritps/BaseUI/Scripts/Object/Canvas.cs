using Sirenix.OdinInspector;

using UnityEngine;
using UnityEngine.UI;

namespace BC.BaseUI
{
	[RequireComponent(typeof(UnityEngine.Canvas))]
	public class Canvas : UIObject<UnityEngine.Canvas>
	{
		private readonly static Vector2 DefaultReferenceResolution = new Vector2(1920f,1080f);
		private readonly static CanvasScaler.ScaleMode DefaultScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
		private readonly static CanvasScaler.ScreenMatchMode DefaultScreenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
		private readonly static float DefaultRreferencePixelsPerUnit = 40f;

		private CanvasData data = null;
		private CanvasData Data {
			get
			{
				if(data == null && !ThisContainer.TryGetData<CanvasData>(out data))
				{
					data = ThisContainer.AddData<CanvasData>();
				}
				return data;
			}
		}

		[SerializeField,Space, ToggleLeft]
		private bool isShowOverOtherCanvas = false;
		public override void BaseReset()
		{
			base.BaseReset();
			CanvasResetOrAwake();
		}
		public override void BaseAwake()
		{
			base.BaseAwake();
			CanvasResetOrAwake();
		}
		private void CanvasResetOrAwake()
		{
			var _data = Data;
			var _ui = UI;
			if(_data != null && _ui != null)
			{
				_data.Canvas = _ui;
				_data.CanvasScaler = _ui.GetComponent<CanvasScaler>();
				if(_data.CanvasScaler)
				{
					_data.CanvasScaler.uiScaleMode = DefaultScaleMode;
					_data.CanvasScaler.referenceResolution = DefaultReferenceResolution;
					_data.CanvasScaler.screenMatchMode = DefaultScreenMatchMode;
					_data.CanvasScaler.referencePixelsPerUnit = DefaultRreferencePixelsPerUnit;
				}
				_data.GraphicRaycaster = _ui.GetComponent<GraphicRaycaster>();
				_data.CanvasGroup = GetComponent<UnityEngine.CanvasGroup>() ?? _ui.gameObject.AddComponent<UnityEngine.CanvasGroup>();
			}
		}

		public override void BaseEnable()
		{
			ShowOverOtherCanvas();
			base.BaseEnable();
		}

		private void ShowOverOtherCanvas()
		{
			var _ui = UI;
			if(isShowOverOtherCanvas && _ui != null)
			{
				UnityEngine.Canvas[] canvas = null;
				if(_ui.isRootCanvas)
				{
					// 존재하는 모든 켄버스를 가져오기 - 이 캔버스들 보다 앞에 그려져야 함
					canvas =  GameObject.FindObjectsByType<UnityEngine.Canvas>(FindObjectsInactive.Exclude, FindObjectsSortMode.None);
				}
				else
				{
					// 부모에 있는 모든 켄버스를 가져오기 - 이 캔버스들 보다 앞에 그려져야 함
					canvas =  gameObject.GetComponentsInParent<UnityEngine.Canvas>();
				}

				int maxSort = _ui.sortingOrder;
				for(int i = 0 ; i < canvas.Length ; i++)
				{
					// 자신을 제외한 다른 캔버스들 중에서 && sortingOrder 같거나 높은 레이어가있으면
					if(canvas[i] != _ui && maxSort <= canvas[i].sortingOrder)
					{
						// sortingOrder를 그보다 한단계 높게 잡는다.
						maxSort = canvas[i].sortingOrder + 1;
					}
				}
				_ui.sortingOrder = maxSort;
			}
		}
	}
}
