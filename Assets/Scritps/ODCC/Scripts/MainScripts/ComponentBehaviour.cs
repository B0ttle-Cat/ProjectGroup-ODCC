using System;

using Sirenix.OdinInspector;

using UnityEngine;

namespace BC.ODCC
{
	public class ComponentBehaviour : OCBehaviour, IOdccComponent
	{
		[ReadOnly, ShowInInspector]
		[PropertyOrder(-5), PropertySpace(SpaceBefore = 0, SpaceAfter = 10)]
		public ObjectBehaviour ThisObject { get; internal set; }
		public ContainerObject ThisContainer {
			get {
#if UNITY_EDITOR
				if(ThisObject == null) Reset();
				if(ThisObject == null) return null;
#endif
				return ThisObject.ThisContainer;
			}
		}

		void IOdccComponent.ConnectThisObject(ContainerNode target)
		{
			ThisObject = target.thisObject as ObjectBehaviour;
		}

#if UNITY_EDITOR
		internal override void Reset()
		{
			try
			{
				if(UnityEditor.EditorApplication.isPlaying) return;
				if(IsEditingPrefab()) return;

				if(ThisTransform == null) return;
				ThisObject = GetComponentInParent<ObjectBehaviour>(true);
				BaseReset();
				BaseValidate();
			}
			catch(Exception ex)
			{
				Debug.LogException(ex);
			}
		}
		internal override void OnValidate()
		{
			if(UnityEditor.EditorApplication.isPlaying) return;
			if(IsEditingPrefab()) return;

			if(ThisTransform == null) return;
			ThisObject = GetComponentInParent<ObjectBehaviour>(true);
			BaseValidate();
		}
#endif

		protected override void Disposing()
		{
			base.Disposing();
			ThisObject = null;
		}
	}
}
