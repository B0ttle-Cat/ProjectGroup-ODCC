using System;
using System.Threading;

using UnityEngine;
using UnityEngine.SceneManagement;

namespace BC.ODCC
{

	public abstract class OCBehaviour : MonoBehaviour, IOdccItem, IDisposable
	{
		private Transform _ThisTransform;
		public Transform ThisTransform { get => _ThisTransform ??= transform; protected set => _ThisTransform = value; }
		public Scene ThisScene => gameObject.scene;
		public int ThisComponentIndex => GetComponentIndex();
		internal bool IsEnable { get; private set; } = false;
		internal bool IsCanUpdateDisable { get; private set; } = false;

		private int odccTypeIndex = -1;
		public int OdccTypeIndex {
			get {
				if(odccTypeIndex == -1) odccTypeIndex = OdccManager.GetTypeToIndex(GetType());
				return odccTypeIndex;
			}
		}

		private CancellationTokenSource cancellationEnableSource;
		private CancellationToken cancellationEnableToken;

		public CancellationToken DestroyCancelToken => destroyCancellationToken;
		public CancellationToken DisableCancelToken => cancellationEnableToken;

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
		protected bool IsEditingPrefab() => !gameObject.scene.isLoaded ||
			(UnityEditor.SceneManagement.PrefabStageUtility.GetCurrentPrefabStage() != null &&
			UnityEditor.SceneManagement.PrefabStageUtility.GetCurrentPrefabStage().IsPartOfPrefabContents(gameObject));
		protected bool IsNotEditingPrefab() => !IsEditingPrefab();
#else
		protected bool IsEditingPrefab() => false;
		protected bool IsNotEditingPrefab() => true;
#endif
		protected virtual void Awake()
		{
			ThisTransform = transform;
			if(odccTypeIndex == -1) odccTypeIndex = OdccManager.GetTypeToIndex(GetType());
			OdccAwake();
		}
		protected virtual void OnDestroy()
		{
			OdccOnDestroy();

			if(cancellationEnableSource != null)
			{
				cancellationEnableSource.Cancel();
				cancellationEnableSource.Dispose();
				cancellationEnableSource = null;
			}
		}
		protected virtual void OnEnable()
		{
			cancellationEnableSource = new CancellationTokenSource();
			cancellationEnableToken = cancellationEnableSource.Token;

			OdccOnEnable();
		}
		protected virtual void OnDisable()
		{
			OdccOnDisable();

			if(cancellationEnableSource != null)
			{
				cancellationEnableSource.Cancel();
				cancellationEnableSource.Dispose();
				cancellationEnableSource = null;
			}
		}
		protected virtual void Start()
		{
			OdccOnStart();
		}
		protected void OnTransformParentChanged()
		{
			OdccOnTransformParentChanged();
		}


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
		internal virtual void OdccOnDestroy()
		{
#if UNITY_EDITOR
			if(Application.isPlaying)
#endif
			{
				OdccManager.OdccDestroy(this);
			}
		}
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


		private bool disposedValue;
		protected virtual void Disposing()
		{
			_ThisTransform = null;
		}
		public void Dispose()
		{
			if(!disposedValue)
			{
				Disposing();
				disposedValue=true;
			}
			GC.SuppressFinalize(this);
		}

		public void DestroyThis(bool removeThisGameObject = false)
		{
			if(removeThisGameObject)
			{
				Destroy(gameObject);
			}
			else
			{
				Destroy(this);
			}
		}
	}
}
