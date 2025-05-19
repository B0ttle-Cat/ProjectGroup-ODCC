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
		private AnimationEventLabelStruct[] enterEventKey = new AnimationEventLabelStruct[0];
		[HorizontalGroup("EventKey/H"), SerializeField]
		private AnimationEventLabelStruct[] exitEventKey = new AnimationEventLabelStruct[0];
		public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
		{
			var _object = animator.GetComponentInParent<ObjectBehaviour>();
			if (_object == null) return;
			int length = enterEventKey == null ? 0 : enterEventKey.Length;
			if (length == 0) return;

			for (int i = 0; i < length; i++)
			{
				var delayTime = enterEventKey[i].delayTime;
				var eventLabel = enterEventKey[i].eventLabel;
				if (eventLabel.IsEmpty) continue;
				_object.ThisContainer.CallDelayActionAllComponent<IMachineStateCheckListener>(delayTime, call => {
					call.OnMachineStateEnter(stateMachinePathHash, eventLabel);
				});
			}
		}
		public override void OnStateMachineExit(Animator animator, int stateMachinePathHash)
		{
			var _object = animator.GetComponentInParent<ObjectBehaviour>();
			if (_object == null) return;
			int length = exitEventKey == null ? 0 : exitEventKey.Length;
			if (length == 0) return;
			for (int i = 0; i < length; i++)
			{
				var delayTime = enterEventKey[i].delayTime;
				var eventLabel = enterEventKey[i].eventLabel;
				if (eventLabel.IsEmpty) continue;
				_object.ThisContainer.CallDelayActionAllComponent<IMachineStateCheckListener>(delayTime, call => {
					call.OnMachineStateExit(stateMachinePathHash, eventLabel);
				});
			}
		}
	}

}
