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
		protected AnimatorStateChangeListener stateChangeListener;

		public override void BaseAwake()
		{
			animator  = GetComponent<Animator>();
		}

		internal virtual void SetStateChangeListener(AnimatorStateChangeListener stateChangeListener)
		{
			this.stateChangeListener = stateChangeListener;
		}

	}
}
