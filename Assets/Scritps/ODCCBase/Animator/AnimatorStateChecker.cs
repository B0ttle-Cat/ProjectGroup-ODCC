using UnityEngine;

namespace BC.OdccBase
{
	public class AnimatorStateChecker : StateMachineBehaviour
	{
		private AnimatorComponent animatorComponent;

		private bool TryGetAnimatorComponent(Animator animator, out AnimatorComponent comp)
		{
			if(this.animatorComponent != null)
			{
				comp = this.animatorComponent;
				return true;
			}
			this.animatorComponent = comp = animator.GetComponentInParent<AnimatorComponent>();
			return comp != null;
		}

		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			if(!TryGetAnimatorComponent(animator, out var comp)) return;
			if(comp.Animator != animator) return;
			comp.OnAnimatorStateEnter(stateInfo);
		}
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			if(!TryGetAnimatorComponent(animator, out var comp)) return;
			if(comp.Animator != animator) return;
			if(stateInfo.normalizedTime >= 1f)
			{
				comp.OnAnimatorStateEnd(stateInfo);
			}
		}
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			if(!TryGetAnimatorComponent(animator, out var comp)) return;
			if(comp.Animator != animator) return;
			comp.OnAnimatorStateExit(stateInfo);
		}
	}
}
