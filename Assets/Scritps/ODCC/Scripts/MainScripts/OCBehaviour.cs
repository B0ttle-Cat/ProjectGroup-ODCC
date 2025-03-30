using System;
using System.Threading;

using UnityEngine;
using UnityEngine.SceneManagement;

namespace BC.ODCC
{
	public abstract class OCBehaviour : MonoBehaviour, IOCBehaviour, IDisposable
	{
		public Transform ThisTransform => transform;
		public GameObject GameObject => gameObject;
		public MonoBehaviour ThisMono { get => this; }
		public Scene ThisScene => gameObject.scene;
		public int ComponentIndex => GetComponentIndex();
		public IOCBehaviour ThisBehaviour => this;
		private bool callDestroy;

		IOCBehaviour.StateFlag IOCBehaviour.AwakeState { get; set; }
		IOCBehaviour.StateFlag IOCBehaviour.EnableState { get; set; }
		IOCBehaviour.StateFlag IOCBehaviour.StartState { get; set; }
		IOCBehaviour.StateFlag IOCBehaviour.DestroyState { get; set; }

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
			if(ThisTransform == null) return;
			BaseReset();
			BaseValidate();
		}
		internal virtual void OnValidate()
		{
			if(UnityEditor.EditorApplication.isPlaying) return;
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
		internal void Awake()
		{
			callDestroy = false;
			if(ThisScene.buildIndex == -1) return;

			//Debug.Log($"Awake|{ThisScene}| {gameObject.name}({GetType()})");//

			if(IOdccItem.odccTypeIndex == 0) IOdccItem.odccTypeIndex = OdccManager.GetTypeToIndex(GetType());

			try
			{
				OdccManager.OdccAwake(this);
			}
			catch(Exception ex)
			{
				Debug.LogError($"AwakeError| {gameObject.name}({GetType()})");
				Debug.LogException(ex);
			}
		}
		protected void OnDestroy()
		{
			if(callDestroy) return;
			callDestroy = true;
			Debug.Log($"Destroy| {gameObject.name}({GetType()})");
			try
			{
				OdccManager.OdccDestroy(this);
			}
			catch(Exception ex)
			{
				Debug.LogException(ex);
			}

			if(disableCancellationSource != null)
			{
				disableCancellationSource.Cancel();
				disableCancellationSource.Dispose();
				disableCancellationSource = null;
			}
		}
		protected void OnEnable()
		{
			//Debug.Log($"OnEnable| {gameObject.name}({GetType()})");
			if(disableCancellationSource == null)
				disableCancellationSource = new CancellationTokenSource();

			try
			{
				OdccManager.OdccEnable(this);
			}
			catch(Exception ex)
			{
				Debug.LogException(ex);
			}
		}
		protected void OnDisable()
		{
			try
			{
				OdccManager.OdccDisable(this);
			}
			catch(Exception ex)
			{
				Debug.LogException(ex);
			}

			if(disableCancellationSource != null)
			{
				disableCancellationSource.Cancel();
				disableCancellationSource.Dispose();
				disableCancellationSource = null;
			}
		}
		protected void Start()
		{
			try
			{
				OdccManager.OdccStart(this);
			}
			catch(Exception ex)
			{
				Debug.LogException(ex);
			}
		}
		protected virtual void OnTransformParentChanged()
		{
			//Debug.Log($"{gameObject.name} : OnTransformParentChanged");
		}
		protected virtual void OnTransformChildrenChanged()
		{
			//Debug.Log($"{gameObject.name} : OnTransformChildrenChanged");
		}
		protected virtual void OnBeforeTransformParentChanged()
		{
			//Debug.Log($"{gameObject.name} : OnBeforeTransformParentChanged");
		}

		void IOCBehaviour.OdccAwake()
		{
#if UNITY_EDITOR
			//if(!gameObject.name.StartsWith("[O]"))
			//{
			//	name = (this is ObjectBehaviour ? $"[O] {name}" : name);
			//}
#endif

			//Debug.Log($"BaseAwake| {gameObject.name}({GetType()})");
			BaseAwake();
		}
		void IOCBehaviour.OdccDestroy()
		{
			BaseDestroy();
		}
		void IOCBehaviour.OdcnEnable()
		{
			//Debug.Log($"BaseEnable| {gameObject.name}({GetType()})");
			BaseEnable();
		}
		void IOCBehaviour.OdccDisable()
		{
			BaseDisable();
		}
		void IOCBehaviour.OdccStart()
		{
			BaseStart();
		}

		protected virtual void BaseReset(in bool isPrefab = false) { }
		protected virtual void BaseValidate(in bool isPrefab = false) { }
		protected virtual void BaseAwake() { }
		protected virtual void BaseDestroy() { }
		protected virtual void BaseEnable() { }
		protected virtual void BaseDisable() { }
		protected virtual void BaseStart() { }

#if UNITY_EDITOR
		[Obsolete("Use IOdccUpdate.BaseUpdate", true)]
		protected virtual void BaseUpdate() { }
		[Obsolete("Use IOdccUpdate.Late.BaseUpdate", true)]
		protected virtual void BaseLateUpdate() { }
#endif

		private bool disposedValue;
		protected virtual void Disposing()
		{

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
		public virtual void DestroyThis(bool removeThisGameObject = false)
		{
			if(callDestroy) return;

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
