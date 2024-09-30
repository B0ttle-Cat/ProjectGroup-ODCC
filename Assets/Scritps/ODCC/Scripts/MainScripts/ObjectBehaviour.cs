using System;

using Sirenix.OdinInspector;
using Sirenix.Utilities;

using UnityEngine;

namespace BC.ODCC
{
	[DefaultExecutionOrder(0)]
	public class ObjectBehaviour : OCBehaviour, IOdccObject
	{
		[HideLabel, InlineProperty, SerializeField, PropertyOrder(-5)]
		private ContainerObject _container;
		public ContainerObject ThisContainer {
			get {
				if(_container is null)
				{
					_container = new ContainerObject(this);
				}
				return _container;
			}
			private set {
				_container = value;
			}
		}

#if UNITY_EDITOR
		[Obsolete("'ThisContainer'를 대신 사용하세요.", true)]
		public ContainerObject Container => ThisContainer;
		internal override void Reset()
		{
			try
			{
				if(UnityEditor.EditorApplication.isPlaying) return;
				if(!gameObject.scene.isLoaded) return;
				ThisTransform = transform;
				if(ThisTransform == null) return;

				_container = new ContainerObject(this);
				_container.ContainerNode.AllRefresh();

				BaseReset();
				BaseValidate();


				_container.ComponentList?.ForEach(item => item.Reset());
				_container.ChildObject?.ForEach(item => item.Reset());
			}
			catch(Exception ex)
			{
				Debug.LogError("Exception Reset : " + gameObject.name);
				Debug.LogException(ex);
			}
		}
		internal override void OnValidate()
		{
			OnVHierarchy();
			try
			{
				if(UnityEditor.EditorApplication.isPlaying) return;
				if(!gameObject.scene.isLoaded) return;
				ThisTransform = transform;
				if(ThisTransform == null) return;

				if(_container == null || _container.ContainerNode == null || _container.ThisObject == null) _container = new ContainerObject(this);
				_container.ContainerNode.AllRefresh();

				BaseValidate();

				_container.ComponentList?.ForEach(item => item.OnValidate());
				_container.ChildObject?.ForEach(item => item.OnValidate());
			}
			catch(Exception ex)
			{
				Debug.LogError("Exception OnValidate : " + gameObject.name);
				Debug.LogException(ex);
			}
		}
		private void OnVHierarchy()
		{
			try
			{
				if(this is ObjectBehaviour)
				{
					VHierarchy.VHierarchy.OnSetIcon(this.gameObject, "d_PreMatCube");
				}
			}
			catch(Exception ex)
			{
				//	Debug.LogException(ex);
			}
		}
		[ContextMenu("ContainerUpdateInEditor")]
		public void ContainerUpdateInEditor()
		{
			if(_container != null && _container.ContainerNode != null)
			{
				_container.ContainerNode.thisObject = this;
				_container.ContainerNode.AllRefresh();
			}
		}
#endif
		protected override void Disposing()
		{
			base.Disposing();
			_container = null;
		}

		internal bool OnAddValidation(ComponentBehaviour behaviour)
		{
			return BaseAddValidation(behaviour);
		}
		internal bool OnAddValidation(DataObject data)
		{
			return BaseAddValidation(data);
		}

		protected virtual bool BaseAddValidation(ComponentBehaviour behaviour)
		{
			return true;
		}
		protected virtual bool BaseAddValidation(DataObject data)
		{
			return true;
		}
	}
}
