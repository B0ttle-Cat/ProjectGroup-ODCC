using System;

using Sirenix.OdinInspector;
using Sirenix.Utilities;

using UnityEngine;

namespace BC.ODCC
{
	public class ObjectBehaviour : OCBehaviour, IOdccObject
	{
		[HideLabel, InlineProperty, SerializeField, PropertyOrder(-5), PropertySpace(0, 10)]
		private ContainerObject _container;
		public ContainerObject ThisContainer {
			get {
				if(_container is null)
				{
					_container = new ContainerObject(new ContainerNode(this));
				}
				if(_container.ThisObject == null)
				{
					_container.ContainerNode.thisObject = this;
					_container.ContainerNode.CurrentInit();
					_container.ContainerNode.UpdateInit();
				}
				return _container;
			}
			private set {
				_container = value;
			}
		}
		void IOdccObject.CreateThisContainer(ContainerNode target)
		{
			if(_container == null)
			{
				_container = new ContainerObject(target);
			}
			else
			{
				_container.ContainerNode = target;
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
				if(ThisTransform == null) return;

				_container = new ContainerObject(new ContainerNode(this));
				_container.ContainerNode.CurrentInit();
				_container.ContainerNode.UpdateInit();

				BaseReset();
				BaseValidate();


				_container.ComponentList?.ForEach(item => {
					if(item is ComponentBehaviour behaviour) behaviour.Reset();
				});
				_container.ChildObject?.ForEach(item => {
					if(item is ObjectBehaviour behaviour) behaviour.Reset();
				});
			}
			catch(Exception ex)
			{
				Debug.LogError("Exception Reset : " + gameObject.name);
				Debug.LogException(ex);
			}
		}
		internal override void OnValidate()
		{
			try
			{
				if(UnityEditor.EditorApplication.isPlaying) return;
				if(!gameObject.scene.isLoaded) return;
				if(ThisTransform == null) return;

				if(_container == null || _container.ContainerNode == null)
				{
					_container = new ContainerObject(new ContainerNode(this));
				}
				if(_container.ThisObject == null)
				{
					_container.ContainerNode.thisObject = this;
					_container.ContainerNode.CurrentInit();
					_container.ContainerNode.UpdateInit();
				}

				BaseValidate();

				_container.ComponentList?.ForEach(item => {
					if(item is ComponentBehaviour behaviour) behaviour.OnValidate();
				});
				_container.ChildObject?.ForEach(item => {
					if(item is ObjectBehaviour behaviour) behaviour.OnValidate();
				});
			}
			catch(Exception ex)
			{
				Debug.LogError("Exception OnValidate : " + gameObject.name);
				Debug.LogException(ex);
			}
		}

		[ContextMenu("ContainerUpdateInEditor")]
		public void ContainerUpdateInEditor()
		{
			if(_container != null && _container.ContainerNode != null)
			{
				_container.ContainerNode.thisObject = this;
				_container.ContainerNode.CurrentInit();
				_container.ContainerNode.UpdateInit();
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

		public override void DestroyThis(bool removeThisGameObject = false)
		{
			base.DestroyThis(true);
		}
	}
}
