using System;
using System.Collections.Generic;

using BC.ODCC;

using Sirenix.OdinInspector;

using UnityEngine;

namespace BC.OdccBase
{
	[RequireComponent(typeof(Animator))]
	public partial class AnimatorComponent : ComponentBehaviour
	{
		[Serializable]
		public partial class State
		{
			[ValueDropdown("StateInfoDropdown"),LabelText("@StateName")]
			public AnimatorInfo.StateInfo StateInfo;
			public string StateName => StateInfo.Name;
			public string StateTag => StateInfo.Tag;
			[ReadOnly]
			public AnimatorComponent Component;
			public bool IsEnter { get; private set; }

			internal State(AnimatorComponent component, AnimatorInfo.StateInfo stateInfo)
			{
				Component=component;
				StateInfo = stateInfo;
			}
			internal void OnStateEnter()
			{
				IsEnter = true;
			}
			internal void OnStateExit()
			{
				IsEnter = false;
			}
		}
		[ReadOnly,InlineProperty, HideLabel, Title("CurrentState")]
		public State CurrentState;
		public List<State> allStateList;
		private AnimatorData animatorData;

		protected Animator ThisAnimator { get; set; }
		internal AnimatorStateChangeListener StateChangeListener { get; set; }
		internal List<AnimatorStateInfo> AnimatorStateStack { get; set; }
		private List<IAnimatorStateChangeListener> StateChangeListeners { get; set; }
		public override void BaseAwake()
		{
			ThisAnimator = GetComponent<Animator>();
			if(ThisAnimator != null && animatorData != null)
			{
				ThisAnimator.runtimeAnimatorController = animatorData.animatorInfo.Controller;
			}

			if(!ThisContainer.TryGetData<AnimatorData>(out animatorData))
			{
				animatorData = ThisContainer.AddData<AnimatorData>();
			}

			CurrentState = null;
			for(int i = 0 ; i < allStateList.Count ; i++)
			{
				allStateList[i].Component = this;
			}
		}
		public override void BaseDestroy()
		{
			ThisAnimator = null;
			StateChangeListener = null;
			AnimatorStateStack = null;
			StateChangeListeners = null;
		}
		internal void OnLinkStateChange(Animator animator, AnimatorStateChangeListener changeListener, AnimatorStateInfo? stateInfo)
		{
			if(ThisAnimator != animator) return;

			StateChangeListener = changeListener;
			AnimatorStateStack ??= new List<AnimatorStateInfo>();
			AnimatorStateStack.Clear();

			if(stateInfo.HasValue && !AnimatorStateStack.Contains(stateInfo.Value))
			{
				AnimatorStateStack.Add(stateInfo.Value);
				_OnStateChange();
			}
		}
		internal void UnLinkStateChange()
		{
			StateChangeListener = null;
			AnimatorStateStack ??= new List<AnimatorStateInfo>();
			AnimatorStateStack.Clear();
		}
		internal void _OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			if(ThisAnimator != animator) return;
			AnimatorStateStack.Remove(stateInfo);
			AnimatorStateStack.Add(stateInfo);
			_OnStateChange();
		}
		internal void _OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			if(ThisAnimator != animator) return;
			if(AnimatorStateStack.Remove(stateInfo))
			{
				_OnStateChange();
			}
		}
		private void _OnStateChange()
		{
			if(AnimatorStateStack.Count == 0)
			{
				return;
			}
			AnimatorStateInfo isLastEnter = AnimatorStateStack[^1];
			if(CurrentState != null && isLastEnter.IsName(CurrentState.StateName) && isLastEnter.IsTag(CurrentState.StateTag)) return;

			if(CurrentState != null)
			{
				CurrentState.OnStateExit();
				OnStateExit(CurrentState);
			}

			int count = allStateList.Count;
			for(int i = 0 ; i < count ; i++)
			{
				var state = allStateList[i];
				if(isLastEnter.IsName(state.StateName) && isLastEnter.IsTag(state.StateTag))
				{
					CurrentState = state;
					CurrentState.OnStateEnter();
					OnStateEnter(CurrentState);
					break;
				}
			}
		}

		protected override void OnUpdateComponents(ComponentBehaviour[] update)
		{
			int length = update.Length;

			if(StateChangeListeners == null)
				StateChangeListeners = new List<IAnimatorStateChangeListener>();

			var newList = new List<IAnimatorStateChangeListener>();
			for(int i = 0 ; i < length ; i++)
			{
				var component = update[i];
				if(component != this && component is IAnimatorStateChangeListener changeListener)
				{
					if(!StateChangeListeners.Contains(changeListener))
					{
						changeListener.CurrentAnimatorState = CurrentState;
					}
					newList.Add(changeListener);
				}
			}

			StateChangeListeners = newList;
		}

		protected virtual void OnStateEnter(State state)
		{
			if(StateChangeListeners == null) return;
			var list = StateChangeListeners;
			int count = list.Count;
			for(int i = 0 ; i < count ; i++)
			{
				list[i].CurrentAnimatorState = state;
				list[i].OnAnimatorStateEnter(state);
			}
		}
		protected virtual void OnStateExit(State state)
		{
			if(StateChangeListeners == null) return;
			var list = StateChangeListeners;
			int count = list.Count;
			for(int i = 0 ; i < count ; i++)
			{
				list[i].OnAnimatorStateExit(state);
			}
		}
	}
}
