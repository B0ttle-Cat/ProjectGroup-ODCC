using BC.ODCC;

using UnityEngine;
namespace BC.OdccBase
{
	public class MachineStateChecker : StateMachineBehaviour
	{
		[SerializeField]
		private string enterEventKey;
		[SerializeField]
		private string exitEventKey;
		// 서브스테이트 머신에 진입할 때 호출
		public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
		{
			if(!animator.TryGetComponent<ComponentBehaviour>(out var component)) return;
			if(!component.ThisContainer.TryGetComponent<AnimatorComponent>(out var animatorComponent)) return;
			if(animatorComponent.Animator != animator) return;
			animatorComponent.OnMachineStateEnter(stateMachinePathHash, enterEventKey);
		}

		// 서브스테이트 머신에서 빠져나올 때 호출
		public override void OnStateMachineExit(Animator animator, int stateMachinePathHash)
		{
			if(!animator.TryGetComponent<ComponentBehaviour>(out var component)) return;
			if(!component.ThisContainer.TryGetComponent<AnimatorComponent>(out var animatorComponent)) return;
			if(animatorComponent.Animator != animator) return;
			animatorComponent.OnMachineStateExit(stateMachinePathHash, exitEventKey);
		}
	}

}
