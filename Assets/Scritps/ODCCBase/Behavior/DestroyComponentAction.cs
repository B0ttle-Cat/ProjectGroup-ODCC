using System;

using Unity.Behavior;
using Unity.Properties;

using UnityEngine;

using Action = Unity.Behavior.Action;

namespace BC.OdccBase
{

	[Serializable, GeneratePropertyBag]
	[NodeDescription(name: "Destroy Component", story: "Destroy [Target]", category: "Action", id: "ddd57a2b8466486ad3330215802b25c8")]
	public partial class DestroyComponentAction : Action
	{
		[SerializeReference] public BlackboardVariable<MonoBehaviour> Target;

		protected override Status OnStart()
		{
			var value =  Target.Value;
			if(value != null) GameObject.Destroy(value);
			return Status.Success;
		}


		protected override void OnEnd()
		{
		}
	}

}