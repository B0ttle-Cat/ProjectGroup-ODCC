using BC.ODCC;

using Sirenix.OdinInspector;

using UnityEngine;

namespace BC.OdccBase
{
	public abstract class OdccStateComponent : ComponentBehaviour
	{
		[SerializeField]
		private int _StateGroupKey;
		public int StateGroupKey { get => _StateGroupKey; internal set => _StateGroupKey = value; }

		[SerializeField]
		internal bool destroyWhenDisable = false;

		[SerializeField, ReadOnly]
		protected OdccFiniteStateMachine ThisStateMachine;
		protected OdccStateData ThisStateData => ThisStateMachine.ThisStateData;

		[SerializeField, ReadOnly]
		protected bool IsEnableinState { get; set; } = false;

		/// <summary>
		/// Enable 에서는 이전 State / Disable 에서는 다음 State
		/// </summary>
		public OdccStateComponent ChangeState { get; set; }

		protected override void BaseValidate(in bool isPrefab = false)
		{
			if(isPrefab) return;
			ThisStateMachine = ThisContainer.GetComponent<OdccFiniteStateMachine>();
		}
		protected override void Disposing()
		{
			base.Disposing();
			ThisStateMachine = null;
			ChangeState = null;
		}

		sealed protected override void BaseAwake()
		{
			ThisStateMachine = ThisContainer.GetComponent<OdccFiniteStateMachine>();
			if(ThisStateMachine != null && ThisStateMachine.OnDebugLog)
			{
				Debug.Log($"OdccState:{gameObject.name}:{GetType().Name}:StateAwake");
			}
			StateAwake();
		}
		sealed protected override void BaseDestroy()
		{
			if(ThisStateMachine != null && ThisStateMachine.OnDebugLog)
			{
				Debug.Log($"OdccState:{gameObject.name}:{GetType().Name}:StateDestroy");
			}
			StateDestroy();
		}
		sealed protected override void BaseEnable() { }
		sealed protected override void BaseDisable() { }
		sealed protected override void BaseStart()
		{
			if(ThisStateMachine != null && ThisStateMachine.OnDebugLog)
			{
				Debug.Log($"OdccState:{gameObject.name}:{GetType().Name}:StateStart");
			}
			StateStart();
		}

		internal void MachineEnable()
		{
			if(ThisStateMachine != null && ThisStateMachine.OnDebugLog)
			{
				Debug.Log($"OdccState:{gameObject.name}:{GetType().Name}:StateEnable");
			}
			IsEnableinState = true;
			StateEnable();
		}
		internal void MachineDisable()
		{
			if(ThisStateMachine != null && ThisStateMachine.OnDebugLog)
			{
				Debug.Log($"OdccState:{gameObject.name}:{GetType().Name}:StateDisable");
			}
			IsEnableinState = false;
			StateDisable();
		}
		internal void MachineChangeBeforeUpdate()
		{
			StateChangeInHere();
		}
		internal void MachineUpdate()
		{
			StateUpdate();
		}
		internal void MachineLateUpdate()
		{
			StateLateUpdate();
		}

		protected virtual void StateAwake() { }
		protected virtual void StateDestroy() { }
		protected virtual void StateStart() { }
		protected abstract void StateEnable();
		protected abstract void StateDisable();
		protected abstract void StateChangeInHere();
		protected abstract void StateUpdate();
		protected virtual void StateLateUpdate() { }


		protected T CurrentState<T>(int stateGroupKey = 0) where T : OdccStateComponent
		{
			if(ThisStateMachine == null)
				ThisStateMachine = ThisContainer.GetComponent<OdccFiniteStateMachine>();

			return ThisStateMachine.CurrentState<T>(stateGroupKey);
		}
		protected void OnTransitionState<T>() where T : OdccStateComponent
		{
			if(ThisStateMachine == null)
				ThisStateMachine = ThisContainer.GetComponent<OdccFiniteStateMachine>();

			ThisStateMachine.OnTransitionState<T>();
		}
		protected void OnTransitionState(OdccStateComponent enableState)
		{
			if(ThisStateMachine == null)
				ThisStateMachine = ThisContainer.GetComponent<OdccFiniteStateMachine>();

			ThisStateMachine.OnTransitionState(enableState);
		}
		protected T GetState<T>() where T : OdccStateComponent
		{
			if(ThisStateMachine == null)
				ThisStateMachine = ThisContainer.GetComponent<OdccFiniteStateMachine>();

			return ThisStateMachine.GetState<T>();
		}
		protected bool TryGetState<T>(out T t) where T : OdccStateComponent
		{
			if(ThisStateMachine == null)
				ThisStateMachine = ThisContainer.GetComponent<OdccFiniteStateMachine>();

			return ThisStateMachine.TryGetState<T>(out t);
		}
	}
}
