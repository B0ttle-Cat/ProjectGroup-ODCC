using System;

using BC.ODCC;

using UnityEngine;

namespace BC.OdccBase
{
	[RequireComponent(typeof(Animator))]
	public class AnimatorComponent : ComponentBehaviour
	{
		[Serializable]
		public class State
		{

		}

		protected Animator animator;


		public override void BaseAwake()
		{
			animator  = GetComponent<Animator>();
		}
	}
}
