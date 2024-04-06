using System;

using BC.ODCC;

using DG.Tweening;

using Sirenix.OdinInspector;

using UnityEngine;

namespace BC.BaseUI
{
	[RequireComponent(typeof(RectTransform))]
	public class SimpleUIAnimatorList : ComponentBehaviour, IUIAnimator
	{
		[SerializeField]
		private IUIAnimator.PlayKeyType key;
		[SerializeField]
		[ShowIf("@Key == IUIAnimator.PlayKeyType.Custom")]
		private string customKey;
		[SerializeField]
		private bool AutoPlay;
		public IUIAnimator.PlayKeyType Key { get => key; private set => key = value; }
		public string CustomKey { get => customKey; private set => customKey = value; }
		[ReadOnly, ShowInInspector]
		public bool IsPlaying { get; set; }

		private RectTransform rectTransform;
		[Serializable]
		public class AlphaTarget
		{
			[SerializeField]
			private UnityEngine.CanvasGroup canvasGroup;
			[SerializeField]
			private UnityEngine.UI.Graphic targetGraphic;

			public AlphaTarget(SimpleUIAnimatorList simpleUIAnimatorList)
			{
				var thisObject = simpleUIAnimatorList.gameObject;
				canvasGroup = thisObject.GetComponent<UnityEngine.CanvasGroup>();
				targetGraphic = thisObject.GetComponent<UnityEngine.UI.Graphic>();
				if(canvasGroup == null && targetGraphic == null)
				{
					canvasGroup = thisObject.AddComponent<UnityEngine.CanvasGroup>();
				}
			}

			public float alpha
			{
				get
				{
					return GetAlphaTarget();
				}
				set
				{
					SetAlphaTarget(value);
				}
			}
			public bool blackRaycast
			{
				get
				{
					return GetBlackRaycast();
				}
				set
				{
					SetBlackRaycast(value);
				}
			}
			private float GetAlphaTarget()
			{
				if(canvasGroup != null)
					return canvasGroup.alpha;
				else if(targetGraphic != null)
					return targetGraphic.color.a;
				else
					return 1f;
			}
			private void SetAlphaTarget(float _alpha)
			{
				if(canvasGroup != null)
					canvasGroup.alpha = _alpha;
				else if(targetGraphic != null)
				{
					var color = targetGraphic.color;
					color.a =_alpha;
					targetGraphic.color = color;
				}
			}

			private bool GetBlackRaycast()
			{
				if(canvasGroup != null)
					return canvasGroup.blocksRaycasts;
				else if(targetGraphic != null)
					return targetGraphic.raycastTarget;
				else
					return true;
			}
			private void SetBlackRaycast(bool _black)
			{
				if(canvasGroup != null)
					canvasGroup.blocksRaycasts = _black;
				else if(targetGraphic != null)
					targetGraphic.raycastTarget = _black;
			}
			public Tween DOFade(float endValue, float duration)
			{
				if(canvasGroup != null)
					return canvasGroup.DOFade(endValue, duration);
				else if(targetGraphic != null)
					return targetGraphic.DOFade(endValue, duration);
				else
					return null;
			}
		}

		[SerializeField,ReadOnly, InlineProperty, HideLabel]
		[FoldoutGroup("PoseTarget", expanded: false)]
		private AlphaTarget alphaTarget;
		[ReadOnly]
		public RectTransform RectTransform
		{
			get
			{
				if(rectTransform == null)
				{
					rectTransform = this.GetComponent<RectTransform>();
				}
				return rectTransform;
			}
		}

		public AlphaTarget ThisAlphaTarget
		{
			get
			{
				if(alphaTarget == null)
				{
					alphaTarget = new AlphaTarget(this);
				}
				return alphaTarget;
			}
		}


		#region Start End Pose
		[FoldoutGroup("PoseTarget")]
		public TransformPose startPose;
		[ButtonGroup("PoseTarget/CaptureStartButton")]
		public void OnResetStart()
		{
			// 현재 위치, 회전 및 스케일을 StartPose로 저장
			if(startPose != null)
			{
				startPose.ApplyTo(ThisAlphaTarget, RectTransform);
			}
		}
		[ButtonGroup("PoseTarget/CaptureStartButton")]
		public void OnCaptureStartPose()
		{
			// 현재 위치, 회전 및 스케일을 StartPose로 저장
			startPose = new TransformPose(ThisAlphaTarget, RectTransform);
		}

		[FoldoutGroup("PoseTarget")]
		public TransformPose endPose;
		[ButtonGroup("PoseTarget/CaptureEndButton")]
		public void OnResetEnd()
		{
			// 현재 위치, 회전 및 스케일을 StartPose로 저장
			if(endPose != null)
			{
				endPose.ApplyTo(ThisAlphaTarget, RectTransform);
			}
		}
		[ButtonGroup("PoseTarget/CaptureEndButton")]
		public void OnCaptureEndPose()
		{
			// 현재 위치, 회전 및 스케일을 EndPose로 저장
			endPose = new TransformPose(ThisAlphaTarget, RectTransform);
		}
		#endregion

		[Range(0f,10f)]
		public float delyaAnimationDuration = 0.0f;
		[Range(0f,10f)]
		public float playingAnimationDuration = 1.0f;
		public Ease Ease = Ease.Linear;

		private Action OnCompletePlay;
		private Sequence animationSequence;

		#region Control
		[Button(ButtonSizes.Large)]
		[ButtonGroup("Control")]
		public void Play()
		{
			Play(null);
		}
		public void Play(Action callback)
		{
			IsPlaying = true;

			OnCompletePlay = callback;

			if(animationSequence != null)
				animationSequence.Kill();

			animationSequence = DOTween.Sequence();

			// 각 애니메이션을 시퀀스에 추가합니다.
			startPose.ApplyTo(ThisAlphaTarget, RectTransform);
			animationSequence.PrependInterval(delyaAnimationDuration);
			CreateSequence(animationSequence);
			animationSequence.Play().OnComplete(OnAnimationItemComplete);
		}
		public void OnAnimationItemComplete()
		{
			endPose.ApplyTo(ThisAlphaTarget, RectTransform);

			animationSequence = null;
			IsPlaying = false;

			if(OnCompletePlay != null)
			{
				Action temp = OnCompletePlay;
				OnCompletePlay = null;
				temp?.Invoke();
			}
		}
		[Button(ButtonSizes.Large)]
		[ButtonGroup("Control")]
		public void Pause()
		{
			if(animationSequence != null)
			{
				animationSequence.Pause();
			}
		}
		[Button(ButtonSizes.Large)]
		[ButtonGroup("Control")]
		public void Resume()
		{
			if(animationSequence != null)
			{
				animationSequence.Play();
			}
		}
		[Button(ButtonSizes.Large)]
		[ButtonGroup("Control")]
		public void Stop(bool callEndAction = true)
		{
			if(animationSequence != null)
			{
				animationSequence.Kill(); // 애니메이션 중지
				animationSequence = null;

				if(callEndAction)
				{
					// 애니메이션 중지 후 원하는 위치로 요소 이동
					endPose.ApplyTo(ThisAlphaTarget, RectTransform);
				}
			}

			if(OnCompletePlay != null)
			{
				Action temp = OnCompletePlay;
				OnCompletePlay = null;

				if(callEndAction)
				{
					temp?.Invoke();
				}
			}
		}
		#endregion

		public override void BaseReset()
		{
			alphaTarget = new AlphaTarget(this);
			OnCaptureStartPose();
			OnCaptureEndPose();
		}
		public override void BaseAwake()
		{
			IsPlaying = false;
			alphaTarget = new AlphaTarget(this);
			//startPose.ApplyTo(ThisAlphaTarget, RectTransform);
		}
		public override void BaseEnable()
		{
			if(AutoPlay)
			{
				Play();
			}
		}
		public override void BaseDisable()
		{
			Stop();
		}


		private void CreateSequence(Sequence sequence)
		{
			//delyaAnimationDuration
			sequence.Append(RectTransform.DOAnchorPos(endPose.position, playingAnimationDuration).SetEase(Ease));
			sequence.Join(RectTransform.DOLocalRotateQuaternion(endPose.rotation, playingAnimationDuration).SetEase(Ease));
			sequence.Join(RectTransform.DOScale(endPose.scale, playingAnimationDuration).SetEase(Ease));
			sequence.Join(RectTransform.DOSizeDelta(endPose.sizeDelta, playingAnimationDuration).SetEase(Ease));
			sequence.Join(RectTransform.DOPivot(endPose.pivot, playingAnimationDuration).SetEase(Ease));
			sequence.Join(RectTransform.DOAnchorMin(endPose.anchorMin, playingAnimationDuration).SetEase(Ease));
			sequence.Join(RectTransform.DOAnchorMax(endPose.anchorMax, playingAnimationDuration).SetEase(Ease));
			sequence.Join(ThisAlphaTarget.DOFade(endPose.alpha, playingAnimationDuration).SetEase(Ease));
		}


		// TransformPose 클래스 정의
		[System.Serializable]
		public class TransformPose
		{
			public Vector3 position;
			public Quaternion rotation;
			public Vector3 scale;
			public Vector2 sizeDelta;
			public Vector2 pivot;
			public Vector2 anchorMin;
			public Vector2 anchorMax;
			[Range(0f,1f)]
			public float alpha;
			public bool blockRaycast;
			public TransformPose(AlphaTarget alphaTarget, RectTransform transform)
			{
				position = transform.anchoredPosition3D;
				rotation = transform.localRotation;
				scale = transform.localScale;
				sizeDelta = transform.sizeDelta;
				pivot = transform.pivot;
				anchorMin = transform.anchorMin;
				anchorMax = transform.anchorMax;

				alpha = alphaTarget.alpha;
				blockRaycast = alphaTarget.blackRaycast;
			}

			public void ApplyTo(AlphaTarget alphaTarget, RectTransform transform)
			{
				transform.anchoredPosition3D = position;
				transform.localRotation = rotation;
				transform.localScale = scale;
				transform.sizeDelta = sizeDelta;
				transform.pivot = pivot;
				transform.anchorMin = anchorMin;
				transform.anchorMax = anchorMax;

				alphaTarget.alpha = alpha;
				alphaTarget.blackRaycast = blockRaycast;
			}
		}
#if UNITY_EDITOR
		[Range(0,50)]
		public int gizmoCount = 0;

		private void OnDrawGizmos()
		{
			if(gizmoCount <= 0)
			{
				gizmoCount = 0;
				return;
			}
			if(gizmoCount > 50)
			{
				gizmoCount = 50;
			}
			TransformPose tempTransformPose = new TransformPose(ThisAlphaTarget, RectTransform);

			Vector3[] cornersStart = new Vector3[4];
			Vector3[] cornersEnd = new Vector3[4];

			startPose.ApplyTo(ThisAlphaTarget, RectTransform);
			RectTransform.GetWorldCorners(cornersStart);

			endPose.ApplyTo(ThisAlphaTarget, RectTransform);
			RectTransform.GetWorldCorners(cornersEnd);

			Sequence animationSequence = DOTween.Sequence();
			startPose.ApplyTo(ThisAlphaTarget, RectTransform);
			CreateSequence(animationSequence);
			animationSequence.Goto(0f);
			float color1 = 0;
			float color2 = 0;
			Vector3[] cornersLerp1 = new Vector3[4];
			Vector3[] cornersLerp2 = new Vector3[4];

			for(int i = 0 ; i < gizmoCount ; i++)
			{
				float rate = ((float)i / (float)(gizmoCount));
				float lerpTime = playingAnimationDuration * rate;

				animationSequence.Goto(lerpTime);
				RectTransform.GetWorldCorners(cornersLerp1);
				color1 = ThisAlphaTarget.alpha;

				rate = ((float)(i + 1) / (float)(gizmoCount));
				lerpTime = playingAnimationDuration * rate;

				animationSequence.Goto(lerpTime);
				RectTransform.GetWorldCorners(cornersLerp2);
				color2 = ThisAlphaTarget.alpha;

				Color colorA = Color.gray;
				colorA.a = 0.3f;
				Color color = Color.Lerp(Color.yellow, Color.green, rate);
				Gizmos.color = Color.Lerp(colorA, color, color1);
				Gizmos.DrawLine(cornersLerp1[0], cornersLerp1[1]);
				Gizmos.DrawLine(cornersLerp1[1], cornersLerp1[2]);
				Gizmos.DrawLine(cornersLerp1[2], cornersLerp1[3]);
				Gizmos.DrawLine(cornersLerp1[3], cornersLerp1[0]);
				Gizmos.color = Color.Lerp(colorA, color, (color1 + color2) * 0.5f);
				Gizmos.DrawLine(cornersLerp1[0], cornersLerp2[0]);
				Gizmos.DrawLine(cornersLerp1[1], cornersLerp2[1]);
				Gizmos.DrawLine(cornersLerp1[2], cornersLerp2[2]);
				Gizmos.DrawLine(cornersLerp1[3], cornersLerp2[3]);
				Gizmos.color = Color.Lerp(colorA, color, color2);
				Gizmos.DrawLine(cornersLerp2[0], cornersLerp2[1]);
				Gizmos.DrawLine(cornersLerp2[1], cornersLerp2[2]);
				Gizmos.DrawLine(cornersLerp2[2], cornersLerp2[3]);
				Gizmos.DrawLine(cornersLerp2[3], cornersLerp2[0]);

			}
			animationSequence.Kill();
			tempTransformPose.ApplyTo(ThisAlphaTarget, RectTransform);
		}
#endif
	}
}
