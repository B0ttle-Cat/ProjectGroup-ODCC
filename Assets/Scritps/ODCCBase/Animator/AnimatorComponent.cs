using System;
using System.Collections.Generic;

using BC.ODCC;

using UnityEngine;

using ReadOnlyAttribute = Sirenix.OdinInspector.ReadOnlyAttribute;
namespace BC.OdccBase
{
	public partial class AnimatorComponent : ComponentBehaviour//, IOdccUpdate
	{
		[SerializeField, ReadOnly]
		private Animator animator;
		public Animator Animator {
			get {
				if(animator == null)
				{
					animator = GetComponentInChildren<Animator>(true);
					if(animator == null)
					{
						animator = gameObject.AddComponent<Animator>();
					}
				}
				return animator;
			}
			private set => animator = value;
		}

		//[SerializeField, ReadOnly]
		private AnimatorOverrideController overrideController;
		private List<KeyValuePair<AnimationClip, AnimationClip>> originalClipSetup;

		private Dictionary<int, AnimatorStateInfo> statePlayListToInfo = new Dictionary<int, AnimatorStateInfo>();
		private HashSet<int> animatorStatePlayList = new HashSet<int>();
		private HashSet<int> machineStatePlayList = new HashSet<int>();

		protected override void BaseValidate(in bool isPrefab = false)
		{
			animator = GetComponentInChildren<Animator>(true);
			overrideController = null;
		}
		protected override void BaseAwake()
		{
			if(animator == null)
			{
				animator = GetComponentInChildren<Animator>(true);
			}
			if(animator != null && this.overrideController == null)
			{
				this.overrideController = animator.runtimeAnimatorController is AnimatorOverrideController animOverride
					? new AnimatorOverrideController(animOverride.runtimeAnimatorController)
					: new AnimatorOverrideController(animator.runtimeAnimatorController);
				animator.runtimeAnimatorController = this.overrideController;

				originalClipSetup = new List<KeyValuePair<AnimationClip, AnimationClip>>();
				overrideController.GetOverrides(originalClipSetup);
			}
			statePlayListToInfo = new Dictionary<int, AnimatorStateInfo>();
			animatorStatePlayList = new HashSet<int>();
			machineStatePlayList = new HashSet<int>();
		}
		protected override void BaseDestroy()
		{
			if(animatorStatePlayList != null) animatorStatePlayList.Clear();
			if(machineStatePlayList != null) machineStatePlayList.Clear();
		}

		#region Parameter
		public int StringToHash(string name) => Animator.StringToHash(name);
		public float GetFloat(string name) => Animator.GetFloat(name);
		public float GetFloat(int id) => Animator.GetFloat(id);
		public void SetFloat(string name, float value) => Animator.SetFloat(name, value);
		public void SetFloat(string name, float value, float dampTime, float deltaTime) => Animator.SetFloat(name, value, dampTime, deltaTime);
		public void SetFloat(int id, float value) => Animator.SetFloat(id, value);
		public void SetFloat(int id, float value, float dampTime, float deltaTime) => Animator.SetFloat(id, value, dampTime, deltaTime);
		public bool GetBool(string name) => Animator.GetBool(name);
		public bool GetBool(int id) => Animator.GetBool(id);
		public void SetBool(string name, bool value) => Animator.SetBool(name, value);
		public void SetBool(int id, bool value) => Animator.SetBool(id, value);
		public int GetInteger(string name) => Animator.GetInteger(name);
		public int GetInteger(int id) => Animator.GetInteger(id);
		public void SetInteger(string name, int value) => Animator.SetInteger(name, value);
		public void SetInteger(int id, int value) => Animator.SetInteger(id, value);
		public void SetTrigger(string name) => Animator.SetTrigger(name);
		public void SetTrigger(int id) => Animator.SetTrigger(id);
		public void ResetTrigger(string name) => Animator.ResetTrigger(name);
		public void ResetTrigger(int id) => Animator.ResetTrigger(id);
		#endregion
		#region Layer
		public string GetLayerName(int layerIndex) => Animator.GetLayerName(layerIndex);
		public int GetLayerIndex(string layerName) => string.IsNullOrWhiteSpace(layerName) ? -1 : Animator.GetLayerIndex(layerName);
		public float GetLayerWeight(int layerIndex) => Animator.GetLayerWeight(layerIndex);
		public float GetLayerWeight(string layerName) => Animator.GetLayerWeight(GetLayerIndex(layerName));
		public void SetLayerWeight(int layerIndex, float weight) => Animator.SetLayerWeight(layerIndex, weight);
		public void SetLayerWeight(string layerName, float weight) => Animator.SetLayerWeight(GetLayerIndex(layerName), weight);
		#endregion
		#region PlayImmediately
		public void PlayImmediately(string stateName)
		{
			Animator.Play(stateName);
		}
		public void PlayImmediately(string stateName, int layerIndex)
		{
			Animator.Play(stateName, layerIndex);
		}
		public void PlayImmediately(string stateName, string layerName)
		{
			Animator.Play(stateName, GetLayerIndex(layerName));
		}

		#endregion
		#region StateMachine
		public virtual void OnAnimatorStateEnter(AnimatorStateInfo stateInfo)
		{
			if(animatorStatePlayList == null) return;
			if(animatorStatePlayList.Add(stateInfo.fullPathHash))
			{
				statePlayListToInfo.Add(stateInfo.fullPathHash, stateInfo);
			}
		}
		public virtual void OnAnimatorStateExit(AnimatorStateInfo stateInfo)
		{
			if(animatorStatePlayList == null) return;

			if(animatorStatePlayList.Remove(stateInfo.fullPathHash))
			{
				statePlayListToInfo.Remove(stateInfo.fullPathHash);
			}
		}
		public virtual void OnAnimatorStateEnd(AnimatorStateInfo stateInfo)
		{
			if(animatorStatePlayList == null) return;

			if(animatorStatePlayList.Remove(stateInfo.fullPathHash))
			{
				statePlayListToInfo.Remove(stateInfo.fullPathHash);
			}
		}
		public virtual void OnMachineStateEnter(int stateMachinePathHash)
		{
			if(machineStatePlayList == null) return;
			machineStatePlayList.Add(stateMachinePathHash);
		}
		public virtual void OnMachineStateExit(int stateMachinePathHash)
		{
			if(machineStatePlayList == null) return;
			machineStatePlayList.Remove(stateMachinePathHash);
		}
		public bool IsAnimatorStatePlay(string fullPathStateName)
		{
			return IsAnimatorStatePlay(StringToHash(fullPathStateName));
		}
		public bool IsAnimatorStatePlay(int fullPathStateHash)
		{
			if(animatorStatePlayList == null) return false;
			return animatorStatePlayList.Contains(fullPathStateHash);
		}
		public bool IsMachineStatePlay(string stateMachinePathName)
		{
			return IsMachineStatePlay(StringToHash(stateMachinePathName));
		}
		public bool IsMachineStatePlay(int stateMachinePathHash)
		{
			if(machineStatePlayList == null) return false;
			return machineStatePlayList.Contains(stateMachinePathHash);
		}
		#endregion
		#region WaitStateExit
		public async Awaitable<bool> WaitAnimatorStateExit(string fullPathStateName, int layerIndex = 0, float waitEnterTime = 1f)
		{
			return await WaitAnimatorStateExit(Animator.StringToHash(fullPathStateName), layerIndex, waitEnterTime);
		}
		public async Awaitable<bool> WaitMachineStateExit(string stateMachinePathName, float waitEnterTime = 1f)
		{
			return await WaitMachineStateExit(Animator.StringToHash(stateMachinePathName), waitEnterTime);
		}
		public async Awaitable<bool> WaitAnimatorStateExit(int waitStateID, int layerIndex = 0, float waitEnterTime = 1f, float waitClipTime = 1f)
		{
			float timeout = waitEnterTime;

			while(!IsValid())
			{
				timeout -= Time.deltaTime;
				if(timeout <= 0f)
				{
					return false;
				}
				await Awaitable.NextFrameAsync(DestroyCancelToken);
			}


			while(IsValid())
			{
				if(IsHasState(out _))
				{
					break;
				}
				timeout -= Time.deltaTime;
				if(timeout <= 0f)
				{
					return false;
				}
				await Awaitable.NextFrameAsync(DestroyCancelToken);
			}

			timeout = waitClipTime;
			while(IsValid())
			{
				if(!IsHasState(out var animatorStateInfo))
				{
					break;
				}

				timeout -= animatorStateInfo.speed * Time.deltaTime;
				if(timeout <= 0f)
				{
					return false;
				}
				await Awaitable.NextFrameAsync(DestroyCancelToken);
			}

			return IsValid();
			bool IsValid()
			{
				if(Animator == null) return false;
				if(animatorStatePlayList == null) return false;
				if(DestroyCancelToken.IsCancellationRequested) return false;
				return true;
			}
			bool IsHasState(out AnimatorStateInfo animatorStateInfo)
			{
				animatorStateInfo = default;
				if(statePlayListToInfo == null) return false;
				return statePlayListToInfo.TryGetValue(waitStateID, out animatorStateInfo);
			}
		}
		public async Awaitable<bool> WaitMachineStateExit(int waitStateID, float waitEnterTime = 1f)
		{
			float timeout = waitEnterTime;

			while(!IsValid())
			{
				timeout -= Time.deltaTime;
				if(timeout <= 0f)
				{
					return false;
				}
				await Awaitable.NextFrameAsync(DestroyCancelToken);
			}

			while(IsValid())
			{
				if(IsHasState())
				{
					break;
				}

				timeout -= Time.deltaTime;
				if(timeout <= 0f)
				{
					return false;
				}
				await Awaitable.NextFrameAsync(DestroyCancelToken);
			}

			while(IsValid())
			{
				if(!IsHasState())
				{
					break;
				}
				await Awaitable.NextFrameAsync(DestroyCancelToken);
			}

			return IsValid();
			bool IsValid()
			{
				if(Animator == null) return false;
				if(machineStatePlayList == null) return false;
				if(DestroyCancelToken.IsCancellationRequested) return false;
				return true;
			}
			bool IsHasState()
			{
				return machineStatePlayList.Contains(waitStateID);
			}
		}
		#endregion
		#region OverrideClip
		public void OverrideAnimationClip(AnimationClip originalClip, AnimationClip overrideClip)
		{
			if(originalClip == null) return;
			try { overrideController[originalClip] = overrideClip; }
			catch(Exception ex) { Debug.LogException(ex); }
		}
		public void OverrideAnimationClear(AnimationClip originalClip)
		{
			OverrideAnimationClip(originalClip, null);
		}
		public void OverrideAnimationClipList(List<KeyValuePair<AnimationClip, AnimationClip>> animationKeyValue)
		{
			if(animationKeyValue == null || animationKeyValue.Count == 0) return;
			try { overrideController.ApplyOverrides(animationKeyValue); }
			catch(Exception ex) { Debug.LogException(ex); }
		}
		public void OverrideAnimationClearList()
		{
			OverrideAnimationClipList(originalClipSetup);
		}
		#endregion
	}
}