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
		public struct AnimationEventLabelStruct
		{
			[LabelText("Delay")]
			public float delayTime;
			[HideLabel, InlineProperty, Title("EventLabel")]
			public AnimationEventLabel eventLabel;
			public bool IsEmpty => eventLabel.IsEmpty;
		}
		[Serializable]
		public struct AnimationEventLabel
		{
			[LabelText("Function")]
			[ValueDropdown("GetFunctionName", AppendNextDrawer = true, IsUniqueList = true)]
			public string functionName;
			[LabelText("String"), DisableIf("IsEmpty")]
			public string stringParameter;
			[LabelText("Float"), DisableIf("IsEmpty")]
			public float floatParameter;
			[LabelText("Int"), DisableIf("IsEmpty")]
			public int intParameter;
			[LabelText("Object"), DisableIf("IsEmpty")]
			public Object objectReferenceParameter;

			public bool IsEmpty => string.IsNullOrWhiteSpace(functionName);
			public bool IsNotEmpty => !string.IsNullOrWhiteSpace(functionName);
			public AnimationEventLabel(string function = null) : this()
			{
				functionName = string.IsNullOrWhiteSpace(function) ? "OnTrigger" : function;
				stringParameter = string.Empty;
				floatParameter = 0f;
				intParameter = 0;
				objectReferenceParameter = null;
			}
			private ValueDropdownList<string> GetFunctionName()
			{
				ValueDropdownList<string> list = new ValueDropdownList<string>();
				string[] names = Enum.GetNames(typeof(IStateMachineListener.EventFunctionNameList));

				int length = names.Length;
				for (int i = 0; i < length; i++)
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
		private AnimationEventLabelStruct[] enterEventKey = new AnimationEventLabelStruct[0];
		[HorizontalGroup("EventKey/H"), SerializeField]
		private AnimationEventLabelStruct[] exitEventKey = new AnimationEventLabelStruct[0];

		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
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
				_object.ThisContainer.CallDelayActionAllComponent<IAnimatorStateCheckListener>(delayTime, call => {
					call.OnAnimatorStateEnter(stateInfo, eventLabel);
				});
			}
		}

		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
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
				_object.ThisContainer.CallDelayActionAllComponent<IAnimatorStateCheckListener>(delayTime, call => {
					call.OnAnimatorStateExit(stateInfo, eventLabel);
				});
			}
		}
	}
}
