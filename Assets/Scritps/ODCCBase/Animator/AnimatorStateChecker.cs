using System;

using BC.ODCC;

using Sirenix.OdinInspector;

using UnityEngine;

using static BC.OdccBase.IStateMachineListener;

using Object = UnityEngine.Object;

namespace BC.OdccBase
{
	public interface IStateMachineListener : IOdccComponent
	{
		public enum EventFunctionNameList
		{
			OnActuatorTrigger,
			ActuatorTrigger,
			OnActuator,
			Actuator,
			OnTrigger,
			Trigger,
			OnAction,
			Action,
			OnEvent,
			Event,
		}
		[Serializable]
		public class AnimationEventLabel
		{
			[LabelText("Function")]
			[ValueDropdown("GetFunctionName", AppendNextDrawer = true, IsUniqueList = true)]
			public string functionName;
			[LabelText("String")]
			public string stringParameter = "";
			[LabelText("Float")]
			public float floatParameter = 0;
			[LabelText("Int")]
			public int intParameter = 0;
			[LabelText("Object")]
			public Object objectReferenceParameter = null;

			private ValueDropdownList<string> GetFunctionName()
			{
				ValueDropdownList<string> list = new ValueDropdownList<string>();
				string[] names = Enum.GetNames(typeof(IStateMachineListener.EventFunctionNameList));

				int length = names.Length;
				for(int i = 0 ; i < length ; i++)
				{
					list.Add(names[i], names[i]);
				}

				return list;
			}
			public AnimationEventLabel(AnimationEvent animationEvent)
			{
				functionName = animationEvent.functionName;
				stringParameter = animationEvent.stringParameter;
				floatParameter = animationEvent.floatParameter;
				intParameter = animationEvent.intParameter;
				objectReferenceParameter = animationEvent.objectReferenceParameter;
			}
		}
	}

	public interface IAnimatorStateCheckListener : IStateMachineListener
	{
		void OnAnimatorStateEnter(AnimatorStateInfo stateInfo, AnimationEventLabel eventKey);
		void OnAnimatorStateExit(AnimatorStateInfo stateInfo, AnimationEventLabel eventKey);
	}


	public class AnimatorStateChecker : StateMachineBehaviour
	{
		[TitleGroup("EventKey")]
		[HorizontalGroup("EventKey/H"), SerializeField]
		private AnimationEventLabel[] enterEventKey = new AnimationEventLabel[0];
		[HorizontalGroup("EventKey/H"), SerializeField]
		private AnimationEventLabel[] exitEventKey = new AnimationEventLabel[0];

		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			var _object = animator.GetComponentInParent<ObjectBehaviour>();
			if(_object == null) return;
			int length = enterEventKey == null ? 0 : enterEventKey.Length;
			if(length == 0) return;

			_object.ThisContainer.CallActionAllComponent<IAnimatorStateCheckListener>(call => {
				for(int i = 0 ; i < length ; i++)
				{
					if(enterEventKey[i] == null) continue;
					call.OnAnimatorStateEnter(stateInfo, enterEventKey[i]);
				}
			});
		}

		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			var _object = animator.GetComponentInParent<ObjectBehaviour>();
			if(_object == null) return;
			int length = exitEventKey == null ? 0 : exitEventKey.Length;
			if(length == 0) return;

			_object.ThisContainer.CallActionAllComponent<IAnimatorStateCheckListener>(call => {
				for(int i = 0 ; i < length ; i++)
				{
					if(exitEventKey[i] == null) continue;
					call.OnAnimatorStateExit(stateInfo, exitEventKey[i]);
				}
			});
		}
	}
}
