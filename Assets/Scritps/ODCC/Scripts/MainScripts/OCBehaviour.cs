using Sirenix.OdinInspector;

using UnityEngine;

namespace BC.ODCC
{

	public abstract class OCBehaviour : SerializedMonoBehaviour, IOdccItem
	{
		private Transform _ThisTransform;
		public Transform ThisTransform { get => _ThisTransform ??= transform; protected set => _ThisTransform = value; }
		internal bool IsEnable { get; private set; } = false;
		internal bool IsCanUpdateDisable { get; private set; } = false;
#if UNITY_EDITOR
		internal virtual void Reset()
		{
			if(UnityEditor.EditorApplication.isPlaying) return;
			ThisTransform = transform;
			if(ThisTransform == null) return;
			BaseReset();
			BaseValidate();
		}
		internal virtual void OnValidate()
		{
			if(UnityEditor.EditorApplication.isPlaying) return;
			ThisTransform = transform;
			if(ThisTransform == null) return;
			BaseValidate();
		}
#endif
		protected virtual void Awake()
		{
			ThisTransform = transform;
			OdccAwake();
		}
		protected virtual void OnDestroy()
		{
			OdccOnDestroy();
		}
		protected virtual void OnEnable()
		{
			OdccOnEnable();
		}
		protected virtual void OnDisable()
		{
			OdccOnDisable();
		}
		protected virtual void Start()
		{
			OdccOnStart();
		}
		protected void OnTransformParentChanged()
		{
			OdccOnTransformParentChanged();
		}


		//[ButtonGroup("OdccItem"), Button("Awake")]
		internal virtual void OdccAwake()
		{
#if UNITY_EDITOR
			if(Application.isPlaying)
#endif
			{
				IsEnable = false;
				OdccManager.OdccAwake(this);
			}
		}
		//[ButtonGroup("OdccItem"), Button("Destroy")]
		internal virtual void OdccOnDestroy()
		{
#if UNITY_EDITOR
			if(Application.isPlaying)
#endif
			{
				OdccManager.OdccDestroy(this);
			}
		}
		//[ButtonGroup("OdccItem"), Button("Enable")]
		internal virtual void OdccOnEnable()
		{
#if UNITY_EDITOR
			if(Application.isPlaying)
#endif
			{
				IsEnable = true;
				OdccManager.OdccEnable(this);
			}
		}
		//[ButtonGroup("OdccItem"), Button("Disable")]
		internal virtual void OdccOnDisable()
		{
#if UNITY_EDITOR
			if(Application.isPlaying)
#endif
			{
				IsEnable = false;
				OdccManager.OdccDisable(this);
			}
		}
		internal virtual void OdccOnStart()
		{
#if UNITY_EDITOR
			if(Application.isPlaying)
#endif
				OdccManager.OdccStart(this);
		}
		internal virtual void OdccOnTransformParentChanged()
		{
#if UNITY_EDITOR
			if(Application.isPlaying)
#endif
				OdccManager.OdccChangeParent(this);
		}

		public virtual void BaseReset() { }
		public virtual void BaseValidate() { }
		public virtual void BaseAwake() { }
		public virtual void BaseDestroy() { }
		public virtual void BaseEnable() { }
		public virtual void BaseDisable() { }
		public virtual void BaseStart() { }
		public virtual void BaseUpdate() { }
		public virtual void BaseLateUpdate() { }
		public virtual void BaseTransformParentChanged() { }


		internal void OdccUpdateParent(ObjectBehaviour update) { if(isActiveAndEnabled) OnUpdateParent(update); }
		internal void OdccUpdateChilds(ObjectBehaviour[] update) { if(isActiveAndEnabled) OnUpdateChilds(update); }
		internal void OdccUpdateComponents(ComponentBehaviour[] update) { if(isActiveAndEnabled) OnUpdateComponents(update); }
		internal void OdccUpdateDatas(DataObject[] update) { if(isActiveAndEnabled) OnUpdateDatas(update); }
		protected virtual void OnUpdateParent(ObjectBehaviour update) { }
		protected virtual void OnUpdateChilds(ObjectBehaviour[] update) { }
		protected virtual void OnUpdateComponents(ComponentBehaviour[] update) { }
		protected virtual void OnUpdateDatas(DataObject[] update) { }
	}
}
