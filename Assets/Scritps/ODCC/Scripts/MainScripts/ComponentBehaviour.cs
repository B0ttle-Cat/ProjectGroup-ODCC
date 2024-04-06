using Sirenix.OdinInspector;

using UnityEngine;

namespace BC.ODCC
{
	[DefaultExecutionOrder(1)]
	public class ComponentBehaviour : OCBehaviour, IOdccComponent
	{
		[ReadOnly, ShowInInspector]
		[PropertyOrder(-5)]
		public ObjectBehaviour ThisObject { get; internal set; }
		public ContainerObject ThisContainer => ThisObject.ThisContainer;

#if UNITY_EDITOR
		internal override void Reset()
		{
			if(UnityEditor.EditorApplication.isPlaying) return;
			ThisTransform = transform;
			if(ThisTransform == null) return;
			ThisObject = GetComponentInParent<ObjectBehaviour>();
			BaseReset();
			BaseValidate();
		}
		internal override void OnValidate()
		{
			if(UnityEditor.EditorApplication.isPlaying) return;
			ThisTransform = transform;
			if(ThisTransform == null) return;
			ThisObject = GetComponentInParent<ObjectBehaviour>();
			BaseValidate();
		}
#endif
	}
}
