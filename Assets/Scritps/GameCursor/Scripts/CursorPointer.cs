using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

using static BC.BCInput.BCInputSystem;

namespace BC.Base
{
	public interface ICursorPointerEvent
	{
		void OnDrag(Vector2 value);
		void OnPosition(Vector2 value);
		void OnAction(bool value);
		void OnSelect(bool value);
	}

	public class CursorPointer : MonoBehaviour, ICursorPointerActions
	{
		[Header("Objects")]
		public Image image;
		private RectTransform imageTransform;
		private RectTransform rootTransform;
		private CanvasGroup canvasGroup;
		[Header("Option")]
		public bool showLog = false;
		public bool lockUpdate = false;

		[Header("InputValue")]
		public bool newInputSelect;
		public bool newInputAction;
		public Vector2 newInputPostion;
		public Vector2 newInputDelta;

		internal void Init()
		{
			if(rootTransform == null)
			{
				rootTransform = GetComponent<RectTransform>();
			}
			if(image == null)
			{
				image = GetComponentInChildren<Image>(true);
				imageTransform = image.rectTransform;
			}
		}
		internal void SetCanvasGroup(CanvasGroup _canvasGroup)
		{
			canvasGroup = _canvasGroup;
			CahvasVisibleUpdate();
		}
		private void CahvasVisibleUpdate()
		{
			if(canvasGroup != null && image != null)
			{
				bool isNull = image.sprite == null;
				canvasGroup.alpha = isNull ? 0f : 1f;
				canvasGroup.blocksRaycasts = !isNull;
			}
		}

		internal void ChangeCursorSprite(GameCursor.SpriteGroup spriteGroup)
		{
			if(image != null)
			{
				image.sprite = spriteGroup.sprite;
				CahvasVisibleUpdate();
			}
		}

		public void OnSelect(InputAction.CallbackContext context)
		{
			if(lockUpdate) return;
			ShowLog("OnSelect");

			newInputSelect = context.ReadValueAsButton();

			EventManager.Call<ICursorPointerEvent>((action) =>
			{
				action.OnSelect(newInputSelect);
			});
		}
		public void OnAction(InputAction.CallbackContext context)
		{
			if(lockUpdate) return;
			ShowLog("OnResult");

			newInputAction = context.ReadValueAsButton();

			EventManager.Call<ICursorPointerEvent>((action) =>
			{
				action.OnAction(newInputAction);
			});
		}
		public void OnPosition(InputAction.CallbackContext context)
		{
			if(lockUpdate) return;
			ShowLog("OnPosition");

			newInputPostion = context.ReadValue<Vector2>();
			if(imageTransform != null)
			{
				imageTransform.anchoredPosition = newInputPostion;
			}

			EventManager.Call<ICursorPointerEvent>((action) =>
			{
				action.OnPosition(newInputPostion);
			});
		}
		public void OnDrag(InputAction.CallbackContext context)
		{
			if(lockUpdate) return;
			ShowLog("OnDrag");

			newInputDelta = context.ReadValue<Vector2>();

			EventManager.Call<ICursorPointerEvent>((action) =>
			{
				action.OnDrag(newInputDelta);
			});
		}


		[System.Diagnostics.Conditional("UNITY_EDITOR")]
		private void ShowLog(string msg)
		{
			if(!showLog) return;
			Debug.Log(msg);
		}
	}
}
