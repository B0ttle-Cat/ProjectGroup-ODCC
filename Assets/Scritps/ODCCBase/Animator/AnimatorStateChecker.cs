using UnityEngine;

namespace BC.OdccBase
{
	public class AnimatorStateChecker : StateMachineBehaviour
	{
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			if(!animator.TryGetComponent<AnimatorComponent>(out var comp)) return;
			if(comp.Animator != animator) return;
			comp.OnAnimatorStateEnter(stateInfo, layerIndex);
		}

		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			if(!animator.TryGetComponent<AnimatorComponent>(out var comp)) return;
			if(comp.Animator != animator) return;
			comp.OnAnimatorStateExit(stateInfo, layerIndex);
		}
	}
}
