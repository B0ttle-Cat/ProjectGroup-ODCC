using System;
using System.Collections.Generic;
using System.Threading;

using BC.ODCC;

using UnityEngine;

using ReadOnlyAttribute = Sirenix.OdinInspector.ReadOnlyAttribute;
namespace BC.OdccBase
{
	public partial class AnimatorComponent : ComponentBehaviour//, IOdccUpdate
		, IAnimatorStateCheckListener
		, IMachineStateCheckListener
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

		public Action<IStateMachineListener.AnimationEventLabel> onActionAnimatorStateEnter;
		public Action<IStateMachineListener.AnimationEventLabel> onActionAnimatorStateExit;
		public Action<IStateMachineListener.AnimationEventLabel> onActionMachineStateEnter;
		public Action<IStateMachineListener.AnimationEventLabel> onActionMachineStateExit;
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
			if(animator != null && overrideController == null)
			{
				overrideController = animator.runtimeAnimatorController is AnimatorOverrideController animOverride
					? new AnimatorOverrideController(animOverride.runtimeAnimatorController)
					: new AnimatorOverrideController(animator.runtimeAnimatorController);
				animator.runtimeAnimatorController = overrideController;

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

			onActionAnimatorStateEnter = null;
			onActionAnimatorStateExit = null;
			onActionMachineStateEnter = null;
			onActionMachineStateExit = null;
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

		public void SetTrigger(string name, bool value)
		{
			if(value) { Animator.SetTrigger(name); }
			else { Animator.ResetTrigger(name); }
		}
		public void SetTrigger(int id, bool value)
		{
			if(value) { Animator.SetTrigger(id); }
			else { Animator.ResetTrigger(id); }
		}
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
		public virtual void OnAnimatorStateEnter(AnimatorStateInfo stateInfo, IStateMachineListener.AnimationEventLabel eventKey)
		{
			if(animatorStatePlayList == null) return;
			if(animatorStatePlayList.Add(stateInfo.fullPathHash))
			{
				statePlayListToInfo.Add(stateInfo.fullPathHash, stateInfo);

				if(eventKey != null) onActionAnimatorStateEnter?.Invoke(eventKey);
			}
		}
		public virtual void OnAnimatorStateExit(AnimatorStateInfo stateInfo, IStateMachineListener.AnimationEventLabel eventKey)
		{
			if(animatorStatePlayList == null) return;

			if(animatorStatePlayList.Remove(stateInfo.fullPathHash))
			{
				statePlayListToInfo.Remove(stateInfo.fullPathHash);

				if(eventKey != null) onActionAnimatorStateExit?.Invoke(eventKey);
			}
		}
		public virtual void OnMachineStateEnter(int stateMachinePathHash, IStateMachineListener.AnimationEventLabel eventKey)
		{
			if(machineStatePlayList == null) return;
			if(machineStatePlayList.Add(stateMachinePathHash))
			{
				if(eventKey != null) onActionMachineStateEnter?.Invoke(eventKey);
			}
		}
		public virtual void OnMachineStateExit(int stateMachinePathHash, IStateMachineListener.AnimationEventLabel eventKey)
		{
			if(machineStatePlayList == null) return;
			if(machineStatePlayList.Remove(stateMachinePathHash))
			{
				if(eventKey != null) onActionMachineStateExit?.Invoke(eventKey);
			}
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
		public async Awaitable<bool> WaitAnimatorStateExit(CancellationToken cancellationToken, string fullPathStateName, int layerIndex = 0, float waitEnterTime = 1f)
		{
			return await WaitAnimatorStateExit(cancellationToken, Animator.StringToHash(fullPathStateName), layerIndex, waitEnterTime);
		}
		public async Awaitable<bool> WaitMachineStateExit(CancellationToken cancellationToken, string stateMachinePathName, float waitEnterTime = 1f)
		{
			return await WaitMachineStateExit(cancellationToken, Animator.StringToHash(stateMachinePathName), waitEnterTime);
		}
		public async Awaitable<bool> WaitAnimatorStateExit(CancellationToken cancellationToken, int waitStateID, int layerIndex = 0, float waitEnterTime = 1f, float waitClipTime = 1f)
		{
			if(animator == null || animator.runtimeAnimatorController == null) return false;
			float timeout = waitEnterTime;

			while(!IsValid())
			{
				timeout -= Time.deltaTime;
				if(timeout <= 0f)
				{
					return false;
				}
				await Awaitable.NextFrameAsync(cancellationToken);
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
				await Awaitable.NextFrameAsync(cancellationToken);
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
				await Awaitable.NextFrameAsync(cancellationToken);
			}

			return IsValid();
			bool IsValid()
			{
				if(Animator == null) return false;
				if(animatorStatePlayList == null) return false;
				if(DestroyCancelToken.IsCancellationRequested) return false;
				if(!cancellationToken.CanBeCanceled) return false;
				return true;
			}
			bool IsHasState(out AnimatorStateInfo animatorStateInfo)
			{
				animatorStateInfo = default;
				if(statePlayListToInfo == null) return false;
				return statePlayListToInfo.TryGetValue(waitStateID, out animatorStateInfo);
			}
		}
		public async Awaitable<bool> WaitMachineStateExit(CancellationToken cancellationToken, int waitStateID, float waitEnterTime = 1f)
		{
			float timeout = waitEnterTime;

			while(!IsValid())
			{
				timeout -= Time.deltaTime;
				if(timeout <= 0f)
				{
					return false;
				}
				await Awaitable.NextFrameAsync(cancellationToken);
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
				await Awaitable.NextFrameAsync(cancellationToken);
			}

			while(IsValid())
			{
				if(!IsHasState())
				{
					break;
				}
				await Awaitable.NextFrameAsync(cancellationToken);
			}

			return IsValid();
			bool IsValid()
			{
				if(Animator == null) return false;
				if(machineStatePlayList == null) return false;
				if(DestroyCancelToken.IsCancellationRequested) return false;
				if(!cancellationToken.CanBeCanceled) return false;
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
			if(originalClip == null || overrideController == null) return;
			try { overrideController[originalClip] = overrideClip; }
			catch(Exception ex) { Debug.LogException(ex); }
		}
		public void OverrideAnimationClear(AnimationClip originalClip)
		{
			OverrideAnimationClip(originalClip, null);
		}
		public void OverrideAnimationClipList(List<KeyValuePair<AnimationClip, AnimationClip>> animationKeyValue)
		{
			if(animationKeyValue == null || animationKeyValue.Count == 0 || overrideController == null) return;
			try { overrideController.ApplyOverrides(animationKeyValue); }
			catch(Exception ex) { Debug.LogException(ex); }
		}
		public void OverrideAnimationClearList()
		{
			OverrideAnimationClipList(originalClipSetup);
		}
		#endregion
	}
	public partial class AnimatorComponent // SaveLoad Animator
	{
		[Serializable]
		public class AnimatorLayerState
		{
			public int layerIndex;
			public int stateHash;
			public float normalizedTime;
			public bool isInTransition;
		}

		[Serializable]
		public class AnimatorSaveData
		{
			public List<AnimatorLayerState> layers = new();
			public List<Params<float>> floatParams = new();
			public List<Params<int>> intParams = new();
			public List<Params<bool>> boolParams = new();
			public List<string> activeTriggers = new();

			[Serializable]
			public struct Params<T>
			{
				public string Key;
				public T Value;

				public Params(string key, T value) : this()
				{
					Key=key;
					Value =value;
				}
			}

			// 수정 가능한 Animator 속성
			public float speed;
			public float playbackTime;
			public bool applyRootMotion;
			public AnimatorUpdateMode updateMode;
			public AnimatorCullingMode cullingMode;
			public bool animatePhysics;
			public bool keepAnimatorStateOnDisable;
			public bool writeDefaultValuesOnDisable;
		}

		public AnimatorSaveData SaveAnimatorState()
		{
			if(animator == null)
			{
				animator = GetComponentInChildren<Animator>(true);
				if(animator == null)
				{
					animator = gameObject.AddComponent<Animator>();
				}
			}

			AnimatorSaveData data = new AnimatorSaveData();

			// 상태 저장 (Layer별)
			for(int i = 0 ; i < animator.layerCount ; i++)
			{
				var stateInfo = animator.GetCurrentAnimatorStateInfo(i);
				bool isInTransition = animator.IsInTransition(i);

				AnimatorLayerState layerState = new AnimatorLayerState
				{
					layerIndex = i,
					stateHash = stateInfo.shortNameHash,
					normalizedTime = stateInfo.normalizedTime,
					isInTransition = isInTransition
				};

				data.layers.Add(layerState);
			}

			// 파라미터 저장
			foreach(var param in animator.parameters)
			{
				switch(param.type)
				{
					case AnimatorControllerParameterType.Float:
						data.floatParams.Add(new AnimatorSaveData.Params<float>(param.name, animator.GetFloat(param.name)));
						break;
					case AnimatorControllerParameterType.Int:
						data.intParams.Add(new AnimatorSaveData.Params<int>(param.name, animator.GetInteger(param.name)));
						break;
					case AnimatorControllerParameterType.Bool:
						data.boolParams.Add(new AnimatorSaveData.Params<bool>(param.name, animator.GetBool(param.name)));
						break;
					case AnimatorControllerParameterType.Trigger:
						if(animator.GetBool(param.name)) data.activeTriggers.Add(param.name);
						break;
				}
			}

			// Animator 속성 저장
			data.speed = animator.speed;
			data.playbackTime = animator.playbackTime;
			data.applyRootMotion = animator.applyRootMotion;
			data.updateMode = animator.updateMode;
			data.cullingMode = animator.cullingMode;
			data.animatePhysics = animator.animatePhysics;
			data.keepAnimatorStateOnDisable = animator.keepAnimatorStateOnDisable;
			data.writeDefaultValuesOnDisable = animator.writeDefaultValuesOnDisable;

			return data;
		}

		public void LoadAnimatorState(AnimatorSaveData data)
		{
			if(animator == null)
			{
				animator = GetComponentInChildren<Animator>(true);
				if(animator == null)
				{
					animator = gameObject.AddComponent<Animator>();
				}
			}
			if(data == null) return;

			// 파라미터 복원
			foreach(var kv in data.floatParams)
				animator.SetFloat(kv.Key, kv.Value);

			foreach(var kv in data.intParams)
				animator.SetInteger(kv.Key, kv.Value);

			foreach(var kv in data.boolParams)
				animator.SetBool(kv.Key, kv.Value);

			foreach(var trigger in data.activeTriggers)
				animator.SetTrigger(trigger);

			// 상태 복원
			foreach(var layer in data.layers)
			{
				animator.Play(layer.stateHash, layer.layerIndex, layer.normalizedTime);
			}

			// Animator 속성 복원
			animator.speed = data.speed;
			animator.playbackTime = data.playbackTime;
			animator.applyRootMotion = data.applyRootMotion;
			animator.updateMode = data.updateMode;
			animator.cullingMode = data.cullingMode;
			animator.animatePhysics = data.animatePhysics;
			animator.keepAnimatorStateOnDisable = data.keepAnimatorStateOnDisable;
			animator.writeDefaultValuesOnDisable = data.writeDefaultValuesOnDisable;

			// 강제 업데이트 (즉시 반영)
			animator.Update(0);
		}
	}
}