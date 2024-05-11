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
		public ContainerObject ThisContainer {
			get
			{
#if UNITY_EDITOR
				if(ThisObject == null) Reset();
#endif
				return ThisObject.ThisContainer;
			}
		}
#if UNITY_EDITOR
		internal override void Reset()
		{
			if(UnityEditor.EditorApplication.isPlaying) return;
			if(!gameObject.scene.isLoaded) return;

			ThisTransform = transform;
			if(ThisTransform == null) return;
			ThisObject = GetComponentInParent<ObjectBehaviour>(true);
			BaseReset();
			BaseValidate();
		}
		internal override void OnValidate()
		{
			if(UnityEditor.EditorApplication.isPlaying) return;
			if(!gameObject.scene.isLoaded) return;

			ThisTransform = transform;
			if(ThisTransform == null) return;
			ThisObject = GetComponentInParent<ObjectBehaviour>(true);
			BaseValidate();
		}
#endif

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			ThisObject = null;
		}
	}
}
