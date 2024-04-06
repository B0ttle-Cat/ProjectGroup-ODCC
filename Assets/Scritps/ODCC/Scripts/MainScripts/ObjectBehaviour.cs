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
			get
			{
				if(_container is null)
				{
					_container = new ContainerObject(this);
				}
				return _container;
			}
			private set
			{
				_container = value;
			}
		}


#if UNITY_EDITOR
		internal override void Reset()
		{
			if(UnityEditor.EditorApplication.isPlaying) return;
			ThisTransform = transform;
			if(ThisTransform == null) return;

			_container = new ContainerObject(this);
			_container.ContainerNode.AllUpdate();

			BaseReset();
			BaseValidate();


			_container.ComponentList?.ForEach(item => item.Reset());
			_container.ChildObject?.ForEach(item => item.Reset());
		}
		internal override void OnValidate()
		{
			if(UnityEditor.EditorApplication.isPlaying) return;
			ThisTransform = transform;
			if(ThisTransform == null) return;

			if(_container == null || _container.ContainerNode == null) _container = new ContainerObject(this);
			_container.ContainerNode.AllUpdate();

			BaseValidate();

			_container.ComponentList?.ForEach(item => item.OnValidate());
			_container.ChildObject?.ForEach(item => item.OnValidate());
		}
#endif
	}
}
