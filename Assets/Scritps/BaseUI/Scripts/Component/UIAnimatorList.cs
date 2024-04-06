using System;
using System.Collections.Generic;
using System.Linq;

using BC.ODCC;

using DG.Tweening;

using Sirenix.OdinInspector;

using UnityEngine;

namespace BC.BaseUI
{
	[Obsolete("되도록 SimpleUIAnimatorList 사용")]
	public class UIAnimatorList : ComponentBehaviour, IUIAnimator
	{
		[SerializeField]
		private IUIAnimator.PlayKeyType key;
		[SerializeField]
		[ShowIf("@Key == IUIAnimator.PlayKeyType.Custom")]
		private string customKey;

		public IUIAnimator.PlayKeyType Key { get => key; private set => key = value; }
		public string CustomKey { get => customKey; private set => customKey = value; }
		[ReadOnly, ShowInInspector]
		public bool IsPlaying { get; set; }

		#region Base
		public override void BaseAwake()
		{
			IsPlaying = false;
		}
		public override void BaseDestroy()
		{

		}
		public override void BaseEnable()
		{

		}
		public override void BaseDisable()
		{

		}

		#endregion

		public List<AnimationItem> animationItems;

		private int currentItemIndex = 0;

		private Sequence animationSequence;
		private Action OnCompletePlay;



		[ButtonGroup("Control")]
		public void Play()
		{
			Play(null);
		}

		public void Play(Action onCompletePlay)
		{
			OnCompletePlay = onCompletePlay;

			currentItemIndex = 0;
			PlayNextAnimationItem();
		}
		// 애니메이션 일시 중지
		[ButtonGroup("Control")]
		public void Pause()
		{
			if(animationSequence != null)
			{
				animationSequence.Pause();
			}
		}
		// 애니메이션 재개
		[ButtonGroup("Control")]
		public void Resume()
		{
			if(animationSequence != null)
			{
				animationSequence.Play();
			}
		}
		// 애니메이션 중지
		[ButtonGroup("Control")]
		public void Stop(bool applyEndPos = true)
		{
			currentItemIndex = 0;
			if(animationSequence != null)
			{
				animationSequence.Kill();

				Action temp = OnCompletePlay;
				OnCompletePlay = null;
				temp?.Invoke();
			}
			IsPlaying = false;
		}


		private void PlayNextAnimationItem()
		{
			if(currentItemIndex < animationItems.Count)
			{
				IsPlaying = true;
				AnimationItem currentItem = animationItems[currentItemIndex];
				List<ClipItem> animationPropertieList = currentItem.ClipList.OrderBy(item=>item.StartTime).ToList();
				int count = animationPropertieList.Count;

				animationSequence = DOTween.Sequence();

				for(int i = 0 ; i < count ; i++)
				{
					if(animationPropertieList[i] != null)
					{
						try
						{
							animationPropertieList[i].InitVale(ThisObject.gameObject);
						}
						catch(Exception ex)
						{
							Debug.LogException(ex);
						}
					}
				}

				float startTime = 0f;
				for(int i = 0 ; i < count ; i++)
				{
					if(animationPropertieList[i] != null)
					{
						try
						{
							Tween tween = animationPropertieList[i].Join(ref startTime);
							if(tween != null)
							{
								animationSequence.Join(tween);
							}
						}
						catch(Exception ex)
						{
							Debug.LogException(ex);
						}
					}
				}

				animationSequence.Play().OnComplete(OnAnimationItemComplete);
			}
			else
			{
				IsPlaying = false;
				OnAnimationItemComplete();
			}
		}

		private void OnAnimationItemComplete()
		{
			currentItemIndex++;

			if(currentItemIndex < animationItems.Count)
			{
				PlayNextAnimationItem();
			}
			else
			{
				IsPlaying = false;
				Action temp = OnCompletePlay;
				OnCompletePlay = null;
				temp?.Invoke();
			}
		}
	}

	[System.Serializable]
	public class AnimationItem
	{
		[SerializeReference]
		public List<ClipItem> ClipList;
	}

	[System.Serializable]
	public class ClipItem
	{
		public enum AnimationEnum
		{
			None,
			Position, Rotation, Scale,
			ImageColor, ImageAlpha, CanvasAlpha
		}

		public Vector2 StartEndTime;
		public float StartTime => Mathf.Max(0f, StartEndTime.x);
		public float EndTime => Mathf.Max(StartTime, StartEndTime.y);

		[HorizontalGroup("LoopCount")]
		[Min(1), LabelText("Loop")]
		public int LoopCount;   // 반복 횟수
		[EnableIf("@LoopCount > 1")]
		[HorizontalGroup("LoopCount")]
		[HideLabel]
		public LoopType LoopType = LoopType.Restart; // 루프 타입

		[Space]
		public AnimationEnum Animation;
#if UNITY_EDITOR
		private bool IsNotNone => Animation != AnimationEnum.None;
		private bool ShowTransform => Animation == AnimationEnum.Position || Animation == AnimationEnum.Rotation || Animation == AnimationEnum.Scale;
		private bool ShowRotation => Animation == AnimationEnum.Rotation;
		private bool ShowImage => Animation == AnimationEnum.ImageAlpha || Animation == AnimationEnum.ImageColor;
		private bool ShowCanvas => Animation == AnimationEnum.CanvasAlpha;
		private bool ShowColor => Animation == AnimationEnum.ImageColor;
		private bool ShowAlpha => Animation == AnimationEnum.ImageAlpha || Animation == AnimationEnum.CanvasAlpha;
#endif
		[ShowIf("IsNotNone")]
		[Space]
		public bool Init = true;

		[ShowIf("IsNotNone")]
		public Ease Ease = Ease.Linear;

		[ShowIf("ShowTransform")]
		public RectTransform Rect;

		[ShowIf("ShowTransform")]
		public Vector3 StartTransform;
		[ShowIf("ShowTransform")]
		public Vector3 EndTransform;
		[ShowIf("ShowRotation")]
		public RotateMode RotateMode = RotateMode.FastBeyond360;

		[ShowIf("ShowImage")]
		public UnityEngine.UI.Image Image;

		[ShowIf("ShowCanvas")]
		public UnityEngine.CanvasGroup CanvasGroup;

		[ShowIf("ShowColor")]
		public Color StartColor;
		[ShowIf("ShowColor")]
		public Color EndColor;

		[ShowIf("ShowAlpha")]
		public float StartAlpha;
		[ShowIf("ShowAlpha")]
		public float EndAlpha;


		public float CalculateDuration()
		{
			return EndTime - StartTime;
		}
		public void InitVale(GameObject gameObject)
		{
			switch(Animation)
			{
				case AnimationEnum.None:
				break;
				case AnimationEnum.Position:
				if(Rect == null) Rect = gameObject.GetComponent<RectTransform>();
				if(Init)
				{
					Rect.anchoredPosition3D = StartTransform;
				}
				break;
				case AnimationEnum.Rotation:
				if(Rect == null) Rect = gameObject.GetComponent<RectTransform>();
				if(Init)
				{
					Rect.localRotation = Quaternion.Euler(StartTransform);
				}
				break;
				case AnimationEnum.Scale:
				if(Rect == null) Rect = gameObject.GetComponent<RectTransform>();
				if(Init)
				{
					Rect.localScale = StartTransform;
				}
				break;
				case AnimationEnum.ImageColor:
				if(Image == null) Image = gameObject.GetComponent<UnityEngine.UI.Image>();
				if(Init)
				{
					Image.color = StartColor;
				}
				break;
				case AnimationEnum.ImageAlpha:
				if(Image == null) Image = gameObject.GetComponent<UnityEngine.UI.Image>();
				if(Init)
				{
					Color initColor = Image.color;
					initColor.a = StartAlpha;
					Image.color = initColor;
				}
				break;
				case AnimationEnum.CanvasAlpha:
				if(CanvasGroup == null) CanvasGroup = gameObject.GetComponent<UnityEngine.CanvasGroup>();
				if(Init)
				{
					CanvasGroup.alpha = StartAlpha;
				}
				break;
			}
		}
		public Tween Join(ref float prevStartTime)
		{
			float delay = StartTime - prevStartTime;
			prevStartTime = StartTime;

			return Animation switch
			{
				AnimationEnum.None => DOVirtual.DelayedCall(EndTime, () => { }),
				AnimationEnum.Position => Rect == null ? null : Rect.DOAnchorPos(EndTransform, CalculateDuration())
					.SetEase(Ease)
					.SetDelay(delay)
					.SetLoops(LoopCount, LoopType),
				AnimationEnum.Rotation => Rect == null ? null : Rect.DOLocalRotate(EndTransform, CalculateDuration(), RotateMode)
					.SetEase(Ease)
					.SetDelay(delay)
					.SetLoops(LoopCount, LoopType),
				AnimationEnum.Scale => Rect == null ? null : Rect.DOScale(EndTransform, CalculateDuration())
					.SetEase(Ease)
					.SetDelay(delay)
					.SetLoops(LoopCount, LoopType),
				AnimationEnum.ImageColor => Image == null ? null : Image.DOColor(EndColor, CalculateDuration())
					.SetEase(Ease)
					.SetDelay(delay)
					.SetLoops(LoopCount, LoopType),
				AnimationEnum.ImageAlpha => Image == null ? null : Image.DOFade(EndAlpha, CalculateDuration())
					.SetEase(Ease)
					.SetDelay(delay)
					.SetLoops(LoopCount, LoopType),
				AnimationEnum.CanvasAlpha => CanvasGroup == null ? null : CanvasGroup.DOFade(EndAlpha, CalculateDuration())
					.SetEase(Ease)
					.SetDelay(delay)
					.SetLoops(LoopCount, LoopType),
				_ => DOVirtual.DelayedCall(delay: EndTime, () => { }),
			};
			Tween None() { return null; }
		}
	}
}