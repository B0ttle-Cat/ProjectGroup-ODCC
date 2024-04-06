using System;
using System.Collections.Generic;

using Sirenix.OdinInspector;

using UnityEngine;

using Debug = BC.Base.Debug;

namespace BC.BaseUI
{
	public class UIPopupMetadata
	{
		public UIPopup FrameUIObject = null;

		public string TitleText = "";
		public string BodyText = "";

		public string CancleText = "";
		public Action CancleCallback;

		public string ConfirmText = "";
		public Action ConfirmCallback;

		public List<string> OptionTextList = null;
		public Action<int> OptionCallback = null;

		public Action<UIPopup> OnPopupCustomUpdate;

		public UIPopupMetadata(UIPopup frameUIObject, (string titleText, string bodyText) popupText = default, (string text, Action callback) cancleButton = default, (string text, Action callback) confirmButton = default, (List<string> textList, Action<int> callback) optionButton = default, Action<UIPopup> onPopupCustomUpdate = null)
		{
			FrameUIObject=frameUIObject;
			TitleText=popupText.titleText;
			BodyText=popupText.bodyText;
			CancleText=cancleButton.text;
			CancleCallback=cancleButton.callback;
			ConfirmText= confirmButton.text;
			ConfirmCallback=confirmButton.callback;
			OptionTextList=optionButton.textList;
			OptionCallback=optionButton.callback;
			this.OnPopupCustomUpdate = onPopupCustomUpdate;
		}
	}


	public class UIPopup : Canvas
	{
		public static void OpenPopup(UIPopupMetadata uiPopupMetadata)
		{
			OpenPopup(uiPopupMetadata, out var _);
		}
		public static bool OpenPopup(UIPopupMetadata uiPopupMetadata, out UIPopup openPopup)
		{
			openPopup = null;
			if(uiPopupMetadata == null) return false;

			UIPopup popup = uiPopupMetadata.FrameUIObject;
			if(popup == null)
			{
				try
				{
					popup = Resources.Load<UIPopup>("BaseUI/BaseUIPopup");
				}
				catch(Exception ex)
				{
					Debug.LogException(ex);
				}
				if(popup == null)
				{
					CancleOpen();
					return false;
				}
			}

			if(!popup.didAwake)
			{
				try
				{
					popup = GameObject.Instantiate(popup);
				}
				catch(Exception ex)
				{
					Debug.LogException(ex);
					CancleOpen();
					return false;
				}
				popup.isTempPopupObject = true;
			}

			try
			{
				popup.gameObject.SetActive(false);
				popup.alreadyUsedCallback = false;
				popup.metaTitleText = uiPopupMetadata.TitleText;
				popup.metaBodyText = uiPopupMetadata.BodyText;
				popup.metaCancleText = uiPopupMetadata.CancleText;
				popup.metaConfirmText = uiPopupMetadata.ConfirmText;
				popup.metaOptionTextList = uiPopupMetadata.OptionTextList;
				popup.OnPopupCustomUpdate = uiPopupMetadata.OnPopupCustomUpdate;
				popup.OnActiveAndPlayShow(() => {
					popup.metaCancleCallback = () => {
						if(popup.alreadyUsedCallback) return;
						popup.alreadyUsedCallback = true;
						ClosePopup(popup, () => uiPopupMetadata.CancleCallback?.Invoke(), false);
					};
					popup.metaConfirmCallback = () => {
						if(popup.alreadyUsedCallback) return;
						popup.alreadyUsedCallback = true;
						ClosePopup(popup, () => uiPopupMetadata.ConfirmCallback?.Invoke(), false);
					};
					popup.metaOptionCallback = (int index) => {
						if(popup.alreadyUsedCallback) return;
						popup.alreadyUsedCallback = true;
						ClosePopup(popup, () => uiPopupMetadata.OptionCallback?.Invoke(index), false);
					};
				});

				openPopup = popup;
				return true;
			}
			catch(Exception ex)
			{
				Debug.LogException(ex);
				CancleOpen();
				return false;
			}

			void CancleOpen()
			{
				try
				{
					uiPopupMetadata.CancleCallback?.Invoke();
				}
				catch(Exception ex)
				{
					Debug.LogException(ex);
				}
			}
		}
		public static void ClosePopup(UIPopup popup, Action closded, bool usingCancleCallback = false)
		{
			if(popup == null) return;

			if(!popup.alreadyUsedCallback && usingCancleCallback)
			{
				try
				{
					popup.metaCancleCallback?.Invoke();
				}
				catch(Exception ex)
				{
					Debug.LogException(ex);
				}
			}
			else
			{
				popup.OnUnactiveAndPlayHide(() => {
					try
					{
						closded?.Invoke();
					}
					catch(Exception ex)
					{
						Debug.LogException(ex);
					}

					if(popup.isTempPopupObject)
					{
						Destroy(popup.gameObject);
					}
				});
			}
		}

		private bool isTempPopupObject;
		private bool alreadyUsedCallback;

		[BoxGroup("UIObject")] public Text titleText;
		[BoxGroup("UIObject")] public Text bodyText;
		[BoxGroup("UIObject")] public Button cancleCallback;
		[BoxGroup("UIObject")] public Button confirmCallback;
		[BoxGroup("UIObject")] public Button optionCallback;
		[ReadOnly, BoxGroup("UIObject")] public List<Button> optionCallbackList;


		[ReadOnly, BoxGroup("UIPopupMetadata")] public string metaTitleText = "";
		[ReadOnly, BoxGroup("UIPopupMetadata")] public string metaBodyText = "";
		[ReadOnly, BoxGroup("UIPopupMetadata")] public string metaConfirmText = "";
		[ReadOnly, BoxGroup("UIPopupMetadata")] public Action metaConfirmCallback = null;
		[ReadOnly, BoxGroup("UIPopupMetadata")] public List<string> metaOptionTextList = null;
		[ReadOnly, BoxGroup("UIPopupMetadata")] public Action<int> metaOptionCallback = null;
		[ReadOnly, BoxGroup("UIPopupMetadata")] public string metaCancleText = "";
		[ReadOnly, BoxGroup("UIPopupMetadata")] public Action metaCancleCallback = null;

		public Action<UIPopup> OnPopupCustomUpdate;

		public override void BaseEnable()
		{
			InitUIObject();
			base.BaseEnable();
		}
		public override void BaseDisable()
		{
			base.BaseDisable();
			ReleaseUIObject();
		}

		private void InitUIObject()
		{
			if(optionCallback != null && metaOptionTextList != null)
			{
				optionCallback.gameObject.SetActive(false);
				optionCallbackList = new List<Button>();
				for(int i = 0 ; i < metaOptionTextList.Count ; i++)
				{
					optionCallbackList.Add(GameObject.Instantiate(optionCallback, optionCallback.transform.parent));
				}
			}
			else
			{
				optionCallbackList = null;
			}

			if(titleText != null)
			{
				bool active = !string.IsNullOrWhiteSpace(metaTitleText);
				titleText.gameObject.transform.parent.gameObject.SetActive(active);
				titleText.UI.text = metaTitleText;
			}
			if(bodyText != null)
			{
				titleText.gameObject.SetActive(!string.IsNullOrWhiteSpace(metaBodyText));
				bodyText.UI.text = metaBodyText;
			}
			if(cancleCallback != null && cancleCallback.Text != null)
			{
				cancleCallback.gameObject.SetActive(!string.IsNullOrWhiteSpace(metaCancleText));
				cancleCallback.Text.text = metaCancleText;
			}
			if(confirmCallback != null && confirmCallback.Text != null)
			{
				confirmCallback.gameObject.SetActive(!string.IsNullOrWhiteSpace(metaConfirmText));
				confirmCallback.Text.text = metaConfirmText;
			}
			if(optionCallbackList != null)
			{
				for(int i = 0 ; i < optionCallbackList.Count ; i++)
				{
					var optionBtn = optionCallbackList[i];
					if(optionBtn != null && optionBtn.Text != null)
					{
						optionBtn.gameObject.SetActive(!string.IsNullOrWhiteSpace(metaOptionTextList[i]));
						optionBtn.Text.text = metaOptionTextList[i];
					}
				}
			}

			if(cancleCallback != null)
			{
				cancleCallback.UI.onClick.RemoveAllListeners();
				cancleCallback.UI.onClick.AddListener(() => metaCancleCallback?.Invoke());
			}
			if(confirmCallback != null)
			{
				confirmCallback.UI.onClick.RemoveAllListeners();
				confirmCallback.UI.onClick.AddListener(() => metaConfirmCallback?.Invoke());
			}
			if(optionCallbackList != null)
			{
				for(int i = 0 ; i < optionCallbackList.Count ; i++)
				{
					int index = i;
					var optionBtn = optionCallbackList[index];
					optionBtn.UI.onClick.RemoveAllListeners();
					optionBtn.UI.onClick.AddListener(() => metaOptionCallback?.Invoke(index));
				}
			}
		}
		private void ReleaseUIObject()
		{
			if(cancleCallback != null)
			{
				cancleCallback.UI.onClick.RemoveAllListeners();
			}
			if(confirmCallback != null)
			{
				confirmCallback.UI.onClick.RemoveAllListeners();
			}
			if(optionCallbackList != null)
			{
				for(int i = 0 ; i < optionCallbackList.Count ; i++)
				{
					int index = i;
					var optionBtn = optionCallbackList[index];
					optionBtn.UI.onClick.RemoveAllListeners();
					GameObject.Destroy(optionBtn.gameObject);
				}
				optionCallbackList.Clear();
				optionCallbackList = null;
			}
		}

		public override void BaseUpdate()
		{
			base.BaseUpdate();
			OnPopupCustomUpdate?.Invoke(this);
		}
	}
}
