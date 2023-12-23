using BC.Base;

using UnityEngine;

using static BC.BCInput.BCInputSystem;

namespace BC.BCInput
{
	public class BCInputListener : MonoBehaviour
	{
		public bool showLog = false;
		BCInputSystem inputActions;

		public GameObject iCameraListener;

		public void Awake()
		{
			inputActions = new BCInputSystem();

			var pointer = GameCursor.Pointer;
			if(pointer != null && pointer.TryGetComponent<ICursorPointerActions>(out var iCursorPointerActions))
			{
				inputActions.CursorPointer.AddCallbacks(iCursorPointerActions);
			}
			if(iCameraListener != null && iCameraListener.TryGetComponent<ICameraActions>(out var iCameraActions))
			{

				inputActions.Camera.AddCallbacks(iCameraActions);
			}
		}

		public void OnEnable()
		{
			inputActions.Enable();
		}

		public void OnDisable()
		{
			inputActions.Disable();
		}
	}
}
