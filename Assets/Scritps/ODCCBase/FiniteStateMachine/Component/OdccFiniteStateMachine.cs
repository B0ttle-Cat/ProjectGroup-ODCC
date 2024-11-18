using System.Collections.Generic;

using BC.ODCC;

using UnityEngine;

namespace BC.OdccBase
{
	public abstract class OdccFiniteStateMachine : ComponentBehaviour, IOdccUpdate, IOdccUpdate.Late
	{
		[SerializeField]
		internal bool OnDebugLog;

		[SerializeField]
		internal List<OdccStateComponent> enableStateList = new List<OdccStateComponent>();

		public abstract OdccStateData ThisStateData { get; }

		private bool warningStateChange;
		protected override void BaseValidate()
		{
			base.BaseValidate();
			if(enableStateList == null)
			{
				enableStateList = new List<OdccStateComponent>();
			}

			var allStates = GetComponentsInChildren<OdccStateComponent>(true);
			int length = allStates.Length;
			for(int i = 0 ; i < length ; i++)
			{
				allStates[i].enabled = false;
			}

			if(enableStateList.Count == 0)
			{
				var defaultState = GetComponentInChildren<OdccStateComponent>();
				if(defaultState != null)
				{
					enableStateList.Add(defaultState);
				}
			}
			length = enableStateList.Count;
			for(int i = 0 ; i < length ; i++)
			{
				enableStateList[i].enabled = true;
			}
		}
		sealed protected override void BaseAwake()
		{
			FSMAwake();

			warningStateChange = false;
			List<OdccStateComponent> initList = new List<OdccStateComponent>();
			initList.AddRange(enableStateList);

			enableStateList.Clear();
			foreach(var defaultState in initList)
			{
				OnTransitionState(defaultState);
			}
			initList.Clear();
			initList = null;
		}
		sealed protected override void BaseDestroy()
		{
			base.BaseDestroy();
			FSMDestroy();
			enableStateList = null;
		}
		sealed protected override void BaseEnable() { FSMEnable(); }
		sealed protected override void BaseDisable() { FSMDisable(); }
		sealed protected override void BaseStart() { FSMStart(); }
		public void BaseUpdate() { FSMChangeBeforeUpdate(); FSMUpdate(); }
		public void BaseLateUpdate() { FSMLateUpdate(); }

		protected abstract void FSMAwake();
		protected abstract void FSMDestroy();
		protected virtual void FSMEnable() { }
		protected virtual void FSMDisable() { }
		protected virtual void FSMStart() { }
		protected virtual void FSMChangeBeforeUpdate()
		{
			warningStateChange = false;
			for(int i = 0 ; i < enableStateList.Count ; i++)
			{
				OdccStateComponent item = enableStateList[i];
				item.MachineChangeBeforeUpdate();
			}
		}
		protected virtual void FSMUpdate()
		{
			warningStateChange = true;
			for(int i = 0 ; i < enableStateList.Count ; i++)
			{
				OdccStateComponent item = enableStateList[i];
				item.MachineUpdate();
			}

		}
		protected virtual void FSMLateUpdate()
		{
			for(int i = 0 ; i < enableStateList.Count ; i++)
			{
				OdccStateComponent item = enableStateList[i];
				item.MachineLateUpdate();
			}
			warningStateChange = false;
		}

		public T CurrentState<T>(int stateGroupKey = 0) where T : OdccStateComponent
		{
			int findIndex = enableStateList.FindIndex(item=>item.StateGroupKey == stateGroupKey);
			if(findIndex >= 0 && enableStateList[findIndex] is T t)
			{
				return t;
			}
			return null;
		}

		/// <summary>
		/// <code>������ ������, �ܺο��� �� �Լ��� ����ϴ°� ���� ������ �ƴմϴ�.
		/// ���, ������� <see cref="OdccStateData"/>�� ���� �����Ͽ� <see cref="OdccStateComponent.StateChangeInHere"/>���� ������ ���¸� ���� �� �� �ֵ��� ���ּ���.</code>
		/// </summary>
		public void OnTransitionState<T>(int? canNewStateinThisGroup = null) where T : OdccStateComponent
		{
			if(TryGetState<T>(out T t))
			{
				OnTransitionState(t);
			}
			else if(canNewStateinThisGroup.HasValue)
			{
				OnTransitionState(AddState<T>(canNewStateinThisGroup.Value));
			}
		}
		/// <summary>
		/// <code>������ ������, �ܺο��� �� �Լ��� ����ϴ°� ���� ������ �ƴմϴ�.
		/// ���, ������� <see cref="OdccStateData"/>�� ���� �����Ͽ� <see cref="OdccStateComponent.StateChangeInHere"/>���� ������ ���¸� ���� �� �� �ֵ��� ���ּ���.</code>
		/// </summary>
		public void OnTransitionState(OdccStateComponent enableState)
		{
			enableState = OverrideTransitionState(enableState);

			if(enableState != null)
			{
				if(warningStateChange && Application.isEditor)
				{
					Debug.LogWarning("\"Update()\" �Ǵ� \"LateUpdate()\" ���� �߿� State �� ���� �Ǿ����ϴ�.\n" +
						"�̷��� ������ ������ ������, ������ \"ChangeBeforeUpdate()\" ���� ���� �ǵ��� ���ּ���.\n" +
						"(�� �α״� Editor ������ ���ɴϴ�.)");
				}

				if(OnDebugLog)
				{
					Debug.Log($"OdccState:{enableState.gameObject.name}:{enableState.GetType().Name}:OnTransitionState");
				}

				OdccStateComponent disableState = null;
				int stateGroupKey = enableState.StateGroupKey;
				int findIndex = enableStateList.FindIndex(item=>item.StateGroupKey == stateGroupKey);
				if(findIndex >= 0)
				{
					disableState = enableStateList[findIndex];

					disableState.ChangeState = enableState;
					disableState.enabled = false;
					disableState.MachineDisable();
					enableStateList.RemoveAt(findIndex);
				}

				enableStateList.Add(enableState);
				enableState.ChangeState = disableState;
				enableState.enabled = true;
				enableState.MachineEnable();

				if(disableState != null && disableState.destroyWhenDisable)
				{
					Destroy(disableState);
				}
			}
		}
		protected virtual OdccStateComponent OverrideTransitionState(OdccStateComponent enableState)
		{
			return enableState;
		}
		public virtual T GetState<T>() where T : OdccStateComponent
		{
			return ThisContainer.GetComponent<T>();
		}
		public virtual bool TryGetState<T>(out T t) where T : OdccStateComponent
		{
			return ThisContainer.TryGetComponent<T>(out t);
		}
		public virtual T AddState<T>(int stateGroup, bool destroyWhenDisable = false) where T : OdccStateComponent
		{
			T state = ThisContainer.AddComponent<T>();
			state.StateGroupKey = stateGroup;
			state.destroyWhenDisable = false;
			state.enabled = false;
			state.destroyWhenDisable = destroyWhenDisable;
			return state;
		}
	}
}
