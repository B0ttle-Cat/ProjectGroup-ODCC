using System;
using System.Collections.Generic;

using BC.Base;
using BC.ODCC;

using DG.Tweening;

using Sirenix.OdinInspector;

using UnityEngine;

using Random = UnityEngine.Random;

namespace BC.BaseUI
{
	public class ImageTransitions : ComponentBehaviour, IOdccUpdate
	{
		[Serializable]
		public class TransitionsItem
		{
			public RectTransform RectTransform;
			public Image Image;
		}
		public TransitionsItem TransitionsNext;
		public TransitionsItem TransitionsPrev;

		[Serializable]
		public class TransitionsImage
		{
			private Vector2 halfOne = Vector2.one * 0.5f;
			private Vector2 zero = Vector2.zero;
			private Vector2 one_ = Vector2.one;
			private Vector2 upAnchorMin => zero + Vector2.up;
			private Vector2 upAnchorMax => one_ + Vector2.up;
			private Vector2 downAnchorMin => zero + Vector2.down;
			private Vector2 downAnchorMax => one_ + Vector2.down;
			private Vector2 leftAnchorMin => zero + Vector2.left;
			private Vector2 leftAnchorMax => one_ + Vector2.left;
			private Vector2 rightAnchorMin => zero + Vector2.right;
			private Vector2 rightAnchorMax => one_ + Vector2.right;

			public enum Sort
			{
				Index,
				Random
			}
			public enum Transitions : int
			{
				Random = -1,
				None = 0,
				Fade,
				MoveUp,
				MoveDown,
				MoveLeft,
				MoveRight,
				OverUp,
				OverDown,
				OverLeft,
				OverRight,
				ZoomIn,
				ZoomOut,
				End,
			}

			[PreviewField]
			[HorizontalGroup("Image"),HideLabel]
			public Sprite Sprite;
			[VerticalGroup("Image/Option"),HideLabel]
			public Color baseColor = Color.white;
			[VerticalGroup("Image/Option"),HideLabel]
			public Sort SortType = Sort.Index;

			[VerticalGroup("Time"), Range(0f,10f)]
			public float ShowTime = 2f;
			[VerticalGroup("Time"), Range(0f,10f)]
			public float ChangeTime = 1f;

			[VerticalGroup("Anim")]
			public Transitions ShowType = Transitions.None;
			[VerticalGroup("Anim")]
			public Ease EaseType = Ease.Linear;

			private Transitions runTimeShowType;
			private bool startUpdate;
			internal void StartUpdate(TransitionsItem TransitionsPrev, TransitionsItem TransitionsNext)
			{
				startUpdate = true;

				RectTransform PrevRect = TransitionsPrev.RectTransform;
				RectTransform NextRect = TransitionsNext.RectTransform;
				Image PrevImage = TransitionsPrev.Image;
				Image NextImage = TransitionsNext.Image;

				PrevRect.gameObject.SetActive(true);
				NextRect.gameObject.SetActive(true);

				if(NextRect.parent == null || NextRect.gameObject.activeInHierarchy)
				{
					NextRect.transform.SetSiblingIndex(1);
					PrevRect.transform.SetSiblingIndex(0);
				}

				runTimeShowType = ShowType == Transitions.Random ? (Transitions)Random.Range((int)Transitions.None, (int)Transitions.End) : ShowType;

				NextImage.UI.sprite = Sprite;
				NextImage.UI.color = baseColor;

				PrevRect.anchoredPosition3D = Vector3.zero;
				PrevRect.rotation   = Quaternion.identity;
				PrevRect.localScale = one_;
				PrevRect.anchorMin  = zero;
				PrevRect.anchorMax  = one_;
				PrevRect.sizeDelta  = zero;
				PrevRect.pivot      = halfOne;

				NextRect.anchoredPosition3D = Vector3.zero;
				NextRect.rotation   = Quaternion.identity;
				NextRect.localScale = one_;
				NextRect.anchorMin  = zero;
				NextRect.anchorMax  = one_;
				NextRect.sizeDelta  = zero;
				NextRect.pivot      = halfOne;

				switch(runTimeShowType)
				{
					case Transitions.None:
						break;
					case Transitions.Fade:
						Color nextColot = baseColor;
						nextColot.a = 0;
						NextImage.UI.color = nextColot;
						break;
					case Transitions.MoveUp:
					case Transitions.OverUp:
						NextRect.anchorMin = downAnchorMin;
						NextRect.anchorMax = downAnchorMax;
						break;
					case Transitions.MoveDown:
					case Transitions.OverDown:
						NextRect.anchorMin = upAnchorMin;
						NextRect.anchorMax = upAnchorMax;
						break;
					case Transitions.MoveLeft:
					case Transitions.OverLeft:
						NextRect.anchorMin = rightAnchorMin;
						NextRect.anchorMax = rightAnchorMax;
						break;
					case Transitions.MoveRight:
					case Transitions.OverRight:
						NextRect.anchorMin = leftAnchorMin;
						NextRect.anchorMax = leftAnchorMax;
						break;
					case Transitions.ZoomIn:
						NextRect.localScale = Vector3.zero;
						break;
					case Transitions.ZoomOut:
						if(NextRect.parent == null || NextRect.gameObject.activeInHierarchy)
						{
							NextRect.transform.SetSiblingIndex(0);
							PrevRect.transform.SetSiblingIndex(1);
						}
						break;
				}
			}
			public void Update(TransitionsItem TransitionsPrev, TransitionsItem TransitionsNext)
			{
				if(!startUpdate) return;
				startUpdate = false;

				if(ChangeTime <= 0) return;
				float _ChangeTime = ChangeTime - Time.deltaTime;

				RectTransform PrevRect = TransitionsPrev.RectTransform;
				RectTransform NextRect = TransitionsNext.RectTransform;
				Image PrevImage = TransitionsPrev.Image;
				Image NextImage = TransitionsNext.Image;

				switch(runTimeShowType)
				{
					case Transitions.None:
						break;
					case Transitions.Fade:
						NextImage.UI.DOFade(1f, _ChangeTime).OnStart(() => { });
						break;
					case Transitions.MoveUp:
						NextRect.DOAnchorMin(zero, _ChangeTime).SetEase(EaseType).OnStart(() => { });
						NextRect.DOAnchorMax(one_, _ChangeTime).SetEase(EaseType).OnStart(() => { });
						PrevRect.DOAnchorMin(upAnchorMin, _ChangeTime).SetEase(EaseType).OnStart(() => { });
						PrevRect.DOAnchorMax(upAnchorMax, _ChangeTime).SetEase(EaseType).OnStart(() => { });
						break;
					case Transitions.MoveDown:
						NextRect.DOAnchorMin(zero, _ChangeTime).SetEase(EaseType).OnStart(() => { });
						NextRect.DOAnchorMax(one_, _ChangeTime).SetEase(EaseType).OnStart(() => { });
						PrevRect.DOAnchorMin(downAnchorMin, _ChangeTime).SetEase(EaseType).OnStart(() => { });
						PrevRect.DOAnchorMax(downAnchorMax, _ChangeTime).SetEase(EaseType).OnStart(() => { });
						break;
					case Transitions.MoveLeft:
						NextRect.DOAnchorMin(zero, _ChangeTime).SetEase(EaseType).OnStart(() => { });
						NextRect.DOAnchorMax(one_, _ChangeTime).SetEase(EaseType).OnStart(() => { });
						PrevRect.DOAnchorMin(leftAnchorMin, _ChangeTime).SetEase(EaseType).OnStart(() => { });
						PrevRect.DOAnchorMax(leftAnchorMax, _ChangeTime).SetEase(EaseType).OnStart(() => { });
						break;
					case Transitions.MoveRight:
						NextRect.DOAnchorMin(zero, _ChangeTime).SetEase(EaseType).OnStart(() => { });
						NextRect.DOAnchorMax(one_, _ChangeTime).SetEase(EaseType).OnStart(() => { });
						PrevRect.DOAnchorMin(rightAnchorMin, _ChangeTime).SetEase(EaseType).OnStart(() => { });
						PrevRect.DOAnchorMax(rightAnchorMax, _ChangeTime).SetEase(EaseType).OnStart(() => { });
						break;
					case Transitions.OverUp:
						NextRect.DOAnchorMin(zero, _ChangeTime).SetEase(EaseType).OnStart(() => { });
						NextRect.DOAnchorMax(one_, _ChangeTime).SetEase(EaseType).OnStart(() => { });
						break;
					case Transitions.OverDown:
						NextRect.DOAnchorMin(zero, _ChangeTime).SetEase(EaseType).OnStart(() => { });
						NextRect.DOAnchorMax(one_, _ChangeTime).SetEase(EaseType).OnStart(() => { });
						break;
					case Transitions.OverLeft:
						NextRect.DOAnchorMin(zero, _ChangeTime).SetEase(EaseType).OnStart(() => { });
						NextRect.DOAnchorMax(one_, _ChangeTime).SetEase(EaseType).OnStart(() => { });
						break;
					case Transitions.OverRight:
						NextRect.DOAnchorMin(zero, _ChangeTime).SetEase(EaseType).OnStart(() => { });
						NextRect.DOAnchorMax(one_, _ChangeTime).SetEase(EaseType).OnStart(() => { });
						break;
					case Transitions.ZoomIn:
						NextRect.DOScale(Vector3.one, _ChangeTime).SetEase(EaseType).OnStart(() => { });
						break;
					case Transitions.ZoomOut:
						PrevRect.DOScale(Vector3.zero, _ChangeTime).SetEase(EaseType).OnStart(() => { });
						break;
				}
			}

			internal void EndUpdate(TransitionsItem TransitionsPrev, TransitionsItem TransitionsNext)
			{
				RectTransform PrevRect = TransitionsPrev.RectTransform;
				RectTransform NextRect = TransitionsNext.RectTransform;
				Image PrevImage = TransitionsPrev.Image;
				Image NextImage = TransitionsNext.Image;

				PrevImage.UI.sprite = Sprite;
				PrevImage.UI.color = baseColor;

				if(NextRect.parent == null || NextRect.gameObject.activeInHierarchy)
				{
					NextRect.transform.SetSiblingIndex(0);
					PrevRect.transform.SetSiblingIndex(1);
				}

				PrevRect.anchoredPosition3D = Vector3.zero;
				PrevRect.rotation   = Quaternion.identity;
				PrevRect.localScale = one_;
				PrevRect.anchorMin  = zero;
				PrevRect.anchorMax  = one_;
				PrevRect.sizeDelta  = zero;
				PrevRect.pivot      = halfOne;

				PrevImage.DOKill();
				NextImage.DOKill();
				PrevRect.DOKill();
				NextRect.DOKill();

				PrevRect.gameObject.SetActive(true);
				NextRect.gameObject.SetActive(false);

			}
		}
		[TableList]
		public List<TransitionsImage> EditTransitionsImageList;

		[TableList]
		[ShowInInspector,ReadOnly]
		private TransitionsImage[] RuntimeTransitionsImageList;
		private TransitionsImage CurrentTransitionsImage;
		public int currentIndex;
		public bool onChange;
		public bool onEnd;
		public bool onNext;

		public float waitTime;
		public float updateTime;

		public override void BaseAwake()
		{

		}
		public override void BaseDestroy()
		{

		}
		public override void BaseEnable()
		{
			currentIndex = -1;
			if(EditTransitionsImageList == null || EditTransitionsImageList.Count == 0) return;
		}
		public override void BaseDisable()
		{
			EndUpdate();
		}
		public void BaseUpdate()
		{
			if(EditTransitionsImageList == null || EditTransitionsImageList.Count == 0) return;
			if(currentIndex < 0)
			{
				currentIndex = 0;
				InitOrder();
				StartUpdate();
				if(CurrentTransitionsImage == null) return;
				EndUpdate();
			}
			else
			{
				float detaTime = Time.deltaTime;
				if(onNext || CurrentTransitionsImage == null)
				{
					ToNext();
					StartUpdate();
				}

				if(onChange)
				{
					if(waitTime > updateTime)
					{
						ImageUpdate();
						updateTime += detaTime;
					}
					else
					{
						EndUpdate();
					}
				}

				if(onEnd)
				{
					if(waitTime > updateTime)
					{
						updateTime += detaTime;
					}
					else
					{
						waitTime = 0;
						updateTime = 0;

						onNext = true;
						onChange = false;
						onEnd = false;
					}
				}
			}
		}

		private void ToNext()
		{
			onNext = true;
			currentIndex++;
			currentIndex %= EditTransitionsImageList.Count;
			if(currentIndex == 0)
			{
				InitOrder();
			}
		}
		private void InitOrder()
		{
			RuntimeTransitionsImageList = new TransitionsImage[EditTransitionsImageList.Count];
			List<int> sortIndex = new List<int>();
			List<int> randomIndex = new List<int>();

			for(int i = 0 ; i < EditTransitionsImageList.Count ; i++)
			{
				sortIndex.Add(i);
				randomIndex.Add(i);
			}

			for(int i = 0 ; i < sortIndex.Count ; i++)
			{
				int index = sortIndex[i];
				if(EditTransitionsImageList[index].SortType == TransitionsImage.Sort.Index)
				{
					RuntimeTransitionsImageList[index] = EditTransitionsImageList[index];
					sortIndex.RemoveAt(i);
					randomIndex.RemoveAt(i);
					i--;
				}
			}

			randomIndex.Shuffle();

			for(int i = 0 ; i < sortIndex.Count ; i++)
			{
				int index = sortIndex[i];
				int random = randomIndex[i];
				RuntimeTransitionsImageList[index] = EditTransitionsImageList[random];
			}
		}
		private void StartUpdate()
		{
			if(RuntimeTransitionsImageList.Length == 0)
			{
				CurrentTransitionsImage = null;
				return;
			}

			CurrentTransitionsImage = RuntimeTransitionsImageList[currentIndex];
			CurrentTransitionsImage.StartUpdate(TransitionsPrev, TransitionsNext);

			waitTime = CurrentTransitionsImage.ChangeTime;
			updateTime = 0;
			onNext = false;
			onChange = true;
			onEnd = false;
		}
		private void ImageUpdate()
		{
			CurrentTransitionsImage.Update(TransitionsPrev, TransitionsNext);
		}
		private void EndUpdate()
		{
			waitTime = CurrentTransitionsImage.ShowTime;
			updateTime = 0;
			onNext = false;
			onChange = false;
			onEnd = true;

			CurrentTransitionsImage.EndUpdate(TransitionsPrev, TransitionsNext);
		}

	}
}
