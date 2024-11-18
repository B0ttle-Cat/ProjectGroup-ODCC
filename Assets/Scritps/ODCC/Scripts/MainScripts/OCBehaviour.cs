﻿using System;
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
			Debug.Log($"Awake| {gameObject.name}({GetType()})");

			if(IOdccItem.odccTypeIndex == 0) IOdccItem.odccTypeIndex = OdccManager.GetTypeToIndex(GetType());

			OdccManager.OdccAwake(this);
		}
		protected void OnDestroy()
		{
			Debug.Log($"Destroy| {gameObject.name}({GetType()})");
			OdccManager.OdccDestroy(this);

			if(disableCancellationSource != null)
			{
				disableCancellationSource.Cancel();
				disableCancellationSource.Dispose();
				disableCancellationSource = null;
			}
		}
		protected void OnEnable()
		{
			if(disableCancellationSource == null)
				disableCancellationSource = new CancellationTokenSource();

			OdccManager.OdccEnable(this);
		}
		protected void OnDisable()
		{
			OdccManager.OdccDisable(this);

			if(disableCancellationSource != null)
			{
				disableCancellationSource.Cancel();
				disableCancellationSource.Dispose();
				disableCancellationSource = null;
			}
		}
		protected void Start()
		{
			OdccManager.OdccStart(this);
		}
		protected virtual void OnTransformParentChanged()
		{
			Debug.Log($"{gameObject.name} : OnTransformParentChanged");
		}
		protected virtual void OnTransformChildrenChanged()
		{
			Debug.Log($"{gameObject.name} : OnTransformChildrenChanged");
		}
		protected virtual void OnBeforeTransformParentChanged()
		{
			Debug.Log($"{gameObject.name} : OnBeforeTransformParentChanged");
		}

		void IOCBehaviour.OdccAwake()
		{
#if UNITY_EDITOR
			if(!gameObject.name.StartsWith("[O]"))
			{
				name = (this is ObjectBehaviour ? $"[O] {name}" : name);
			}
#endif
			BaseAwake();
		}
		void IOCBehaviour.OdccDestroy()
		{
			BaseDestroy();
		}
		void IOCBehaviour.OdcnEnable()
		{
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

		protected virtual void BaseReset() { }
		protected virtual void BaseValidate() { }
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
