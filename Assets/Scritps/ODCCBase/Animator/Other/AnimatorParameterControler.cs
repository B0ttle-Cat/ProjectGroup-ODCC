using System;

using Sirenix.OdinInspector;

using UnityEngine;

namespace BC.OdccBase
{
	[Serializable]
	public class AnimatorParameterControler
	{
		[ShowInInspector]
		public Animator ThisAnimator { get; set; }
	}
}
