using System;
using System.Collections.Generic;
using System.Linq;

using BC.ODCC;

using Sirenix.OdinInspector;

using UnityEngine;

using Debug = BC.Base.Debug;

namespace BC.BaseUI
{
	public interface IUIAnimator : IOdccComponent
	{
		public enum PlayKeyType
		{
			PlayNone, PlayShow, PlayIdle, PlayHide,
			Custom
		}

		public PlayKeyType Key { get; }
		public string CustomKey { get; }
		bool IsPlaying { get; }
		void Play(Action onCompletePlay);
		void Pause();
		void Resume();
		void Stop(bool callEndAction = true);
	}

	public abstract class UIObject : ObjectBehaviour
	{
		[ListDrawerSettings(DefaultExpandedState = false)]
		public List<UIObject> chainAnimationObjectList;
		[ToggleLeft]
		public bool IsChainingChildUIAnimator = false;
		[ContextMenu("GetAllUIObjectinChild")]
		public void GetAllUIObjectinChild()
		{
			var IAnimator = GetComponentsInChildren<RectTransform>(true).ToList();
			chainAnimationObjectList.Clear();
			for(int i = 1 ; i < IAnimator.Count ; i++)
			{
				if(IAnimator[i].TryGetComponent<UIObject>(out var _object))
				{
					chainAnimationObjectList.Add(_object);
				}
			}
		}
		protected void PlayAnim(IUIAnimator.PlayKeyType key, Action callback, Action next)
		{
			if(!Application.isPlaying) return;

			List<IUIAnimator> componentList = (IsChainingChildUIAnimator ? GetComponentsInChildren<IUIAnimator>() : GetComponents<IUIAnimator>()).ToList();
			componentList.ForEach((component => component.Stop(false)));

			componentList = componentList.Where(item => item.Key == key).ToList();
			int callbackCount = componentList.Count;
			if(callbackCount == 0)
			{
				Next();
			}
			else
			{
				componentList.ForEach((component => component.Play(Next)));
			}

			void Next()
			{
				if(--callbackCount <= 0)
				{
					if(callback != null)
					{
						callback.Invoke();
					}
					if(next != null)
					{
						next.Invoke();
					}
				}
			}
		}
		protected void PlayAnim(string customKey, Action callback, Action next)
		{
			List<IUIAnimator> componentList =
				(IsChainingChildUIAnimator ? GetComponentsInChildren<IUIAnimator>() : GetComponents<IUIAnimator>())
				.Where(item => item.CustomKey == customKey)
				.ToList();

			componentList.ForEach((component => component.Stop()));

			int callbackCount = componentList.Count;
			if(callbackCount == 0)
			{
				Next();
			}
			else
			{
				componentList.ForEach((component => component.Play(Next)));
			}

			void Next()
			{
				if(--callbackCount <= 0)
				{
					if(callback != null)
					{
						callback.Invoke();
					}
					if(next != null)
					{
						next.Invoke();
					}
				}
			}
		}
	}


	public abstract class UIObject<T_UI> : UIObject where T_UI : Component
	{
		private RectTransform rect;
		private T_UI ui;

		public RectTransform Rect => GetRect(ref rect);
		public T_UI UI => GetUI(ref ui);

		public RectTransform GetRect(ref RectTransform _rect)
		{
			if(_rect == null)
			{
				_rect = GetComponent<RectTransform>();
			}
			return _rect;
		}
		public T_UI GetUI(ref T_UI ui)
		{
			if(ui == null)
			{
				ui = GetComponentInChildren<T_UI>(true);
			}
			return ui;
		}
		public override void BaseReset()
		{
			base.BaseReset();
			GetRect(ref rect);
			GetUI(ref ui);
		}

		public override void BaseAwake()
		{
			GetRect(ref rect);
			GetUI(ref ui);
			base.BaseAwake();
		}
		public override void BaseDestroy()
		{

		}
		public override void BaseEnable()
		{
			OnPlayShow();
		}
		public override void BaseDisable()
		{
			OnStop();
		}

		public void OnPlayNone(Action callback = null)
		{
			PlayAnim(IUIAnimator.PlayKeyType.PlayNone, callback, null);
		}
		public void OnPlayShow(Action callback = null)
		{
			PlayAnim(IUIAnimator.PlayKeyType.PlayShow, callback, () => OnPlayIdle(null));
		}
		public void OnPlayIdle(Action callback = null)
		{
			PlayAnim(IUIAnimator.PlayKeyType.PlayIdle, callback, null);
		}
		public void OnPlayHide(Action callback = null)
		{
			PlayAnim(IUIAnimator.PlayKeyType.PlayHide, callback, () => OnPlayNone(null));
		}
		public void OnActiveAndPlayShow(Action callback = null)
		{
			if(!gameObject.activeSelf)
			{
				gameObject.SetActive(true);
			}
			if(!enabled)
			{
				enabled = true;
			}
			PlayAnim(IUIAnimator.PlayKeyType.PlayShow, callback, () => OnPlayIdle(null));
		}
		public void OnUnactiveAndPlayHide(Action callback = null)
		{
			PlayAnim(IUIAnimator.PlayKeyType.PlayHide, () =>
			{
				gameObject.SetActive(false);
				callback?.Invoke();
			}, () => OnPlayIdle(null));
		}
		public void OnDisableAndPlayHide(Action callback = null)
		{
			PlayAnim(IUIAnimator.PlayKeyType.PlayHide, () =>
			{
				enabled = false;
				callback?.Invoke();
			}, () => OnPlayIdle(null));
		}
		public void OnPlay(IUIAnimator.PlayKeyType key, Action callback = null)
		{
			switch(key)
			{
				case IUIAnimator.PlayKeyType.PlayNone:
				OnPlayNone(callback);
				break;
				case IUIAnimator.PlayKeyType.PlayShow:
				OnPlayShow(callback);
				break;
				case IUIAnimator.PlayKeyType.PlayIdle:
				OnPlayIdle(callback);
				break;
				case IUIAnimator.PlayKeyType.PlayHide:
				OnPlayHide(callback);
				break;
				case IUIAnimator.PlayKeyType.Custom:
				OnPlay("", callback);
				break;
			}
		}
		public void OnPlay(string customKey, Action callback = null)
		{
			PlayAnim(customKey, callback, null);
		}
		public void OnStop(Action callback = null)
		{
			if(ThisContainer.TryGetComponentList<IUIAnimator>(out var componentList))
			{
				Array.ForEach(componentList, (component => component.Stop()));
			}
			callback?.Invoke();
		}
		public void OnPause(Action callback = null)
		{
			if(ThisContainer.TryGetComponentList<IUIAnimator>(out var componentList))
			{
				Array.ForEach(componentList, (component => component.Pause()));
			}
			callback?.Invoke();
		}
		public void OnResume(Action callback = null)
		{
			if(ThisContainer.TryGetComponentList<IUIAnimator>(out var componentList))
			{
				Array.ForEach(componentList, (component => component.Resume()));
			}
			callback?.Invoke();
		}
#if UNITY_EDITOR
		[ButtonGroup("EditorButton")]
		private void _OnShow()
		{
			if(!Application.isPlaying) return;
			OnPlayShow(() => Debug.Log("End: OnPlayShow"));
		}
		[ButtonGroup("EditorButton")]
		private void _OnHide()
		{
			if(!Application.isPlaying) return;
			OnPlayHide(() => Debug.Log("End: OnPlayHide"));
		}
		[ButtonGroup("EditorButton")]
		private void _OnStop()
		{
			if(!Application.isPlaying) return;
			OnStop(() => Debug.Log("End: OnStop"));
		}
		[ButtonGroup("EditorButton")]
		private void _OnPause()
		{
			if(!Application.isPlaying) return;
			OnPause(() => Debug.Log("End: OnPause"));
		}
		[ButtonGroup("EditorButton")]
		private void _OnResume()
		{
			if(!Application.isPlaying) return;
			OnResume(() => Debug.Log("End: OnResume"));
		}
#endif
	}
}
