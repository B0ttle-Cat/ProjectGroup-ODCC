using System;
using System.Threading;

using UnityEngine;
using UnityEngine.SceneManagement;

namespace BC.ODCC
{

	public abstract class OCBehaviour : MonoBehaviour, IOCBehaviour, IDisposable
	{
		private Transform _ThisTransform;
		public Transform ThisTransform { get => _ThisTransform ??= transform; protected set => _ThisTransform = value; }
		public MonoBehaviour ThisMono { get => this; }
		public Scene ThisScene => gameObject.scene;
		public int ComponentIndex => GetComponentIndex();
		public IOCBehaviour ThisBehaviour => this;
		bool IOCBehaviour.IsAwake { get; set; } = false;
		bool IOCBehaviour.IsEnable { get; set; } = false;
		bool IOCBehaviour.IsCallDestroy { get; set; } = false;
		bool IOCBehaviour.IsCanUpdateDisable { get; set; } = false;
		internal IOdccItem IOdccItem => this;
		int IOdccItem.odccTypeIndex { get; set; }
		int[] IOdccItem.odccTypeInheritanceIndex { get; set; }

		private CancellationTokenSource disableCancellationSource;
		private CancellationToken disableCancellationToken {
			get {
				if(this == null)
				{
					throw new MissingReferenceException("DisableCancelToken token should be called atleast once before destroying the monobehaviour object");
				}

				if(disableCancellationSource == null)
				{
					disableCancellationSource = new CancellationTokenSource();
				}
				var token = disableCancellationSource.Token;
				if(!enabled)
				{
					disableCancellationSource.Cancel();
					disableCancellationSource.Dispose();
					disableCancellationSource = null;
				}
				return disableCancellationSource.Token;
			}
		}
		public CancellationToken DestroyCancelToken => destroyCancellationToken;
		public CancellationToken DisableCancelToken => disableCancellationToken;

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
			if(IOdccItem.odccTypeIndex == 0) IOdccItem.odccTypeIndex = OdccManager.GetTypeToIndex(GetType());
			OdccAwake();
		}
		internal void CallDestroy()
		{
			ThisBehaviour.IsCallDestroy = true;
		}
		protected virtual void OnDestroy()
		{
			ThisBehaviour.IsCallDestroy = true;
			OdccOnDestroy();

			if(disableCancellationSource != null)
			{
				disableCancellationSource.Cancel();
				disableCancellationSource.Dispose();
				disableCancellationSource = null;
			}
		}
		protected virtual void OnEnable()
		{
			if(disableCancellationSource == null)
				disableCancellationSource = new CancellationTokenSource();

			OdccOnEnable();
		}
		protected virtual void OnDisable()
		{
			OdccOnDisable();

			if(disableCancellationSource != null)
			{
				disableCancellationSource.Cancel();
				disableCancellationSource.Dispose();
				disableCancellationSource = null;
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
				ThisBehaviour.IsEnable = false;
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
				ThisBehaviour.IsEnable = true;
				OdccManager.OdccEnable(this);
			}
		}
		internal virtual void OdccOnDisable()
		{
#if UNITY_EDITOR
			if(Application.isPlaying)
#endif
			{
				ThisBehaviour.IsEnable = false;
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
		internal virtual void DoBaseAwake()
		{
			if(ThisBehaviour.IsAwake) return;
			ThisBehaviour.IsAwake = true;
			ThisBehaviour.IsCallDestroy = false;
#if UNITY_EDITOR
			if(!gameObject.name.StartsWith("[O]"))
			{
				name = (this is ObjectBehaviour ? $"[O] {name}" : name);
			}
#endif
			BaseAwake();
		}
		public virtual void BaseReset() { }
		public virtual void BaseValidate() { }
		public virtual void BaseAwake() { }
		public virtual void BaseDestroy() { }
		public virtual void BaseEnable() { }
		public virtual void BaseDisable() { }
		public virtual void BaseStart() { }
		//public virtual void BaseUpdate() { }
		//public virtual void BaseLateUpdate() { }
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
