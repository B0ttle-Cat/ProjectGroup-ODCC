using BC.ODCC;

using Sirenix.OdinInspector;

using UnityEngine;

using static BC.OdccBase.IStateMachineListener;
namespace BC.OdccBase
{
	public interface IMachineStateCheckListener : IStateMachineListener
	{
		void OnMachineStateEnter(int stateMachinePathHash, AnimationEventLabel eventKey);
		void OnMachineStateExit(int stateMachinePathHash, AnimationEventLabel eventKey);
	}
	public class MachineStateChecker : StateMachineBehaviour
	{
		[TitleGroup("EventKey")]
		[HorizontalGroup("EventKey/H"), SerializeField]
		private AnimationEventLabel[] enterEventKey = new AnimationEventLabel[0];
		[HorizontalGroup("EventKey/H"), SerializeField]
		private AnimationEventLabel[] exitEventKey = new AnimationEventLabel[0];
		public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
		{
			var _object = animator.GetComponentInParent<ObjectBehaviour>();
			if(_object == null) return;
			int length = enterEventKey == null ? 0 : enterEventKey.Length;
			if(length == 0) return;

			_object.ThisContainer.CallActionAllComponent<IMachineStateCheckListener>(call => {
				for(int i = 0 ; i < length ; i++)
				{
					if(enterEventKey[i] == null) continue;
					call.OnMachineStateEnter(stateMachinePathHash, enterEventKey[i]);
				}
			});
		}
		public override void OnStateMachineExit(Animator animator, int stateMachinePathHash)
		{
			var _object = animator.GetComponentInParent<ObjectBehaviour>();
			if(_object == null) return;
			int length = exitEventKey == null ? 0 : exitEventKey.Length;
			if(length == 0) return;

			_object.ThisContainer.CallActionAllComponent<IMachineStateCheckListener>(call => {
				for(int i = 0 ; i < length ; i++)
				{
					if(exitEventKey[i] == null) continue;
					call.OnMachineStateExit(stateMachinePathHash, exitEventKey[i]);
				}
			});
		}
	}

}
