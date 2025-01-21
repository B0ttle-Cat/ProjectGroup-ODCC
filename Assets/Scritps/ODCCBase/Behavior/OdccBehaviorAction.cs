using System;

using Unity.Behavior;
using Unity.Properties;

using UnityEngine;

using Action = Unity.Behavior.Action;

namespace BC.OdccBase
{
	[Serializable, GeneratePropertyBag]
	[NodeDescription(
		name: "OdccBehaviorAction",
		story: "[actionTarget] : OdccBehaviorAction",
		description: "",
		icon: "",
		category: "Odcc",
		id: "cdc544dd625da2a2fa2af9d5e66b1fda")]
	public partial class OdccComponentAction : Action
	{
		[SerializeReference] public BlackboardVariable<OdccBehaviorTarget> actionTarget;
		public bool TargetIsNull => actionTarget != null && actionTarget.Value != null;

		Status status;

		protected override Status OnStart()
		{
			if(TargetIsNull) return Status.Failure;
			status = Status.Running;
			Await();
			return status;
		}
		async void Await()
		{
			var target = actionTarget.Value;
			status = await target._onActionUpdate();
		}
		protected override Status OnUpdate()
		{
			if(TargetIsNull)
			{
				status = Status.Failure;
			}
			else if(actionTarget.Value.DestroyCancelToken.IsCancellationRequested)
			{
				status = Status.Interrupted;
			}

			return status;
		}
		protected override void OnEnd()
		{
			if(TargetIsNull) return;
			actionTarget.Value._onEndBehavior();
		}

		protected override void ResetStatus()
		{
			base.ResetStatus();
		}
	}
}
