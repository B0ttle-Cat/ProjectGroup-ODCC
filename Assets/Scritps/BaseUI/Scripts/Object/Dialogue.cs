using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace BC.BaseUI
{
	public class Dialogue : Text
	{
		private DialogueData dialogueData = null;
		public DialogueData DialogueData {
			get
			{
				if(!ThisContainer.TryGetData<DialogueData>(out dialogueData))
				{
					dialogueData = ThisContainer.AddData<DialogueData>();
				}
				return dialogueData;
			}
		}

		private Coroutine playDialogue;
		float waitNextTime;
		float waitShowTime;
		WaitWhile waitNext;
		WaitWhile waitShow;

		private bool GetSkipShowKey => waitShowTime == 0f || Input.GetKey(KeyCode.LeftControl);
		private bool GetSkipNextKey => Input.GetKey(KeyCode.LeftControl);

		public override void BaseReset()
		{
			base.BaseReset();
			if(dialogueData == null)
			{
				dialogueData = DialogueData;
			}
		}
		public override void BaseAwake()
		{
			base.BaseAwake();
			if(dialogueData == null)
			{
				dialogueData = DialogueData;
			}
			waitNext = null;
			waitShow = null;
		}

		public void SetChangeConfig(
			bool isAutoNextDialogue = false,
			float speedOfNextDialogue = 0.3f,
			float speedOfShowDialogue = 0.1f
		)
		{
			DialogueData.IsAutoNextDialogue = isAutoNextDialogue;
			DialogueData.SpeedOfNextDialogue = speedOfNextDialogue;
			DialogueData.SpeedOfShowDialogue = speedOfShowDialogue;

			waitNextTime = DialogueData.SpeedOfNextDialogue;
			waitShowTime = DialogueData.SpeedOfShowDialogue;
			waitNext = new WaitWhile(() => {
				waitNextTime -= Time.deltaTime;

				if(waitNextTime < 0f)
				{
					waitNextTime = DialogueData.SpeedOfNextDialogue;
					return false;
				}
				else
				{
					return true;
				}
			});
			waitShow = new WaitWhile(() => {
				waitShowTime -= Time.deltaTime;

				if(waitShowTime < 0f || GetSkipShowKey || GetSkipNextKey)
				{
					waitShowTime = DialogueData.SpeedOfShowDialogue;
					return false;
				}
				else
				{
					return true;
				}
			});
		}

		public void SetDialogueList(List<string> dialogueList, int index, Action callbackEndDialogue)
		{
			DialogueData.DialogueList = dialogueList;

			if(index >= dialogueList.Count)
				index = dialogueList.Count - 1;

			DialogueData.CurrentIndex = index;
			DialogueData.CallbackEndDialogue = callbackEndDialogue;

			if(isActiveAndEnabled)
			{
				if(playDialogue != null)
				{
					StopCoroutine(playDialogue);
				}
				playDialogue = StartCoroutine(PlayDialogue());
			}
		}

		public override void BaseEnable()
		{
			base.BaseEnable();

			if(playDialogue != null)
			{
				StopCoroutine(playDialogue);
			}
			playDialogue = StartCoroutine(PlayDialogue());
		}
		public override void BaseDisable()
		{
			base.BaseDisable();
			if(playDialogue != null)
			{
				StopCoroutine(playDialogue);
				playDialogue = null;
			}
		}

		public override void BaseUpdate()
		{

		}

		private IEnumerator PlayDialogue()
		{
			int index = DialogueData.CurrentIndex;
			List<string> dialogueList = DialogueData.DialogueList;

			if(waitShow != null && waitNext != null)
			{
				while(index < dialogueList.Count)
				{
					string currentText = dialogueList[index];
					int currentTextLength = currentText.Length;
					string shoeText = UI.text;
					int shoeTextLength = shoeText.Length;
					if(GetSkipNextKey)
					{
						UI.text = currentText;
					}
					else
					{
						for(int i = shoeTextLength ; i < currentTextLength ; i++)
						{
							if(GetSkipShowKey)
							{
								UI.text = currentText;
								break;
							}
							else
							{
								char currentChar = currentText[i];
								shoeText += currentChar;
								UI.text = shoeText;
								if(!char.IsWhiteSpace(currentChar))
								{
									yield return waitShow;
								}
							}
						}
					}
					yield return waitNext;
					index++;
					DialogueData.CurrentIndex = index;
					UI.text = "";
				}
			}

			Action action = DialogueData.CallbackEndDialogue;
			DialogueData.CallbackEndDialogue = null;
			action?.Invoke();
			yield break;
		}
	}
}
