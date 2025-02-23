using UnityEngine;
namespace BC.OdccBase
{
	public class MachineStateChecker : StateMachineBehaviour
	{
		// 서브스테이트 머신에 진입할 때 호출
		public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
		{
			if(!animator.TryGetComponent<AnimatorComponent>(out var comp)) return;
			if(comp.Animator != animator) return;
			comp.OnMachineStateEnter(stateMachinePathHash);
		}

		// 서브스테이트 머신에서 빠져나올 때 호출
		public override void OnStateMachineExit(Animator animator, int stateMachinePathHash)
		{
			if(!animator.TryGetComponent<AnimatorComponent>(out var comp)) return;
			if(comp.Animator != animator) return;
			comp.OnMachineStateExit(stateMachinePathHash);
		}
	}

}
