using Sirenix.OdinInspector;

using UnityEngine;
namespace BC.OdccBase
{
	public class AnimatorStateChangeListener : StateMachineBehaviour
	{
		[SerializeField, ReadOnly]
		private AnimatorComponent AnimatorComponent { get; set; }
		private AnimatorStateInfo? lastStateInfo;
		// OnAnimatorStateEnter is called before OnAnimatorStateEnter is called on any StateInfo inside this StateInfo machine
		override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			if(AnimatorComponent != null)
			{
				lastStateInfo = stateInfo;
				AnimatorComponent._OnStateEnter(animator, stateInfo, layerIndex);
			}
		}

		// OnAnimatorStateExit is called before OnAnimatorStateExit is called on any StateInfo inside this StateInfo machine
		override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			if(AnimatorComponent != null)
			{
				AnimatorComponent._OnStateExit(animator, stateInfo, layerIndex);
			}
		}

		public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
		{
			AnimatorComponent = null;
			lastStateInfo = null;

			OnLinkComponent(animator, this, animator.GetComponent<AnimatorComponent>());
		}
		public override void OnStateMachineExit(Animator animator, int stateMachinePathHash)
		{
			if(AnimatorComponent != null)
				AnimatorComponent.UnLinkStateChange();

			AnimatorComponent = null;
			lastStateInfo = null;
		}

		private void OnLinkComponent(Animator animator, AnimatorStateChangeListener changeListener, AnimatorComponent animatorComponent)
		{
			if(animatorComponent == null && changeListener == null) return;
			else if(animatorComponent == null)
			{
				changeListener.AnimatorComponent = null;
			}
			else if(changeListener == null)
			{
				animatorComponent.StateChangeListener = null;
			}
			else if(changeListener.AnimatorComponent == animatorComponent && animatorComponent.StateChangeListener == changeListener)
			{
				return;
			}
			else
			{
				if(changeListener.AnimatorComponent != animatorComponent)
				{
					changeListener.AnimatorComponent.UnLinkStateChange();
					changeListener.AnimatorComponent = animatorComponent;
				}

				if(animatorComponent.StateChangeListener != changeListener)
				{
					if(animatorComponent.StateChangeListener != null)
					{
						animatorComponent.UnLinkStateChange();
					}
					animatorComponent.OnLinkStateChange(animator, changeListener, changeListener.lastStateInfo);
				}
			}
		}
	}
}