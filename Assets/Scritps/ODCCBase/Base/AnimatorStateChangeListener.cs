using Sirenix.OdinInspector;

using UnityEngine;
namespace BC.OdccBase
{
	public class AnimatorStateChangeListener : StateMachineBehaviour
	{
		[SerializeField, ReadOnly]
		private Animator thisAnimator;
		[SerializeField, ReadOnly]
		private AnimatorComponent animatorComponent;

		// OnStateEnter is called before OnStateEnter is called on any state inside this state machine
		override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{

		}

		// OnStateUpdate is called before OnStateUpdate is called on any state inside this state machine
		override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{

		}

		// OnStateExit is called before OnStateExit is called on any state inside this state machine
		override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{

		}

		// OnStateMove is called before OnStateMove is called on any state inside this state machine
		//override public void OnStateMove(Animator thisAnimator, AnimatorStateInfo stateInfo, int layerIndex)
		//{
		//    
		//}

		// OnStateIK is called before OnStateIK is called on any state inside this state machine
		//override public void OnStateIK(Animator thisAnimator, AnimatorStateInfo stateInfo, int layerIndex)
		//{
		//    
		//}

		// OnStateMachineEnter is called when entering a state machine via its Entry Node
		public override void OnStateMachineEnter(UnityEngine.Animator animator, int stateMachinePathHash)
		{
			thisAnimator = animator;
			thisAnimator.gameObject.SetActive(true);
			animatorComponent = thisAnimator.gameObject.GetComponentInChildren<AnimatorComponent>(true);
			if(animatorComponent != null)
			{
				animatorComponent.SetStateChangeListener(this);
			}
		}

		// OnStateMachineExit is called when exiting a state machine via its Exit Node
		override public void OnStateMachineExit(Animator animator, int stateMachinePathHash)
		{

		}
	}
}