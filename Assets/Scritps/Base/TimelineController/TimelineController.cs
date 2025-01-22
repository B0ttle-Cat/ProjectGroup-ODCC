using System;
using System.Collections.Generic;
using System.Linq;

using Sirenix.OdinInspector;

#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.Animations;
#endif

using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace BC.Base
{
	public class TimelineController : MonoBehaviour
	{
		[SerializeField]
		[LabelText("Root Animator")]
		private Animator animator;
		private PlayableGraph graph;
		private AnimatorControllerPlayable animatorControllerPlayable;
		private AnimationPlayableOutput animationOutput;

		[SerializeField]
		public StatePlayableMapping[] stateMappings;

		[Serializable]
		public class StatePlayableMapping
		{
			[ValueDropdown("GetAnimatorStateNames")]
			public string stateName;
			public PlayableDirector playableDirector;
			[ReadOnly] public PlayableAsset playableAsset => playableDirector == null ? null : playableDirector.playableAsset;
			[ReadOnly] public SignalReceiver signalReceiver;
			[ReadOnly] public SignalAsset stopSignalAsset;
			public PlayableGraph playableGraph;
#if UNITY_EDITOR
			private IEnumerable<string> GetAnimatorStateNames()
			{
				List<string> stateNames = new List<string>();

				GameObject activeGameObject = Selection.activeGameObject;
				var _this = activeGameObject.GetComponent<TimelineController>();
				Animator animator = _this.animator;

				AnimatorController controller = animator.runtimeAnimatorController as AnimatorController;
				if(controller != null)
				{
					foreach(var layer in controller.layers)
					{
						foreach(var state in layer.stateMachine.states)
						{
							stateNames.Add(state.state.name);
						}
					}
				}
				return stateNames;
			}
#endif
		}

#if UNITY_EDITOR
		private void OnValidate()
		{
			int length = stateMappings.Length;
			for(int i = 0 ; i < length ; i++)
			{
				var playableDirector = stateMappings[i].playableDirector;
				if(playableDirector == null) continue;
				var SignalReceiver = playableDirector.GetComponent<SignalReceiver>() ?? playableDirector.gameObject.AddComponent<SignalReceiver>();
				stateMappings[i].signalReceiver = SignalReceiver;
				SignalAsset signalAsset = FindLastSignalAssetInPlayableAsset(playableDirector.playableAsset);
				stateMappings[i].stopSignalAsset = signalAsset;
			}

			SignalAsset FindLastSignalAssetInPlayableAsset(PlayableAsset playableAsset)
			{
				var timelineAsset = playableAsset as TimelineAsset;
				if(timelineAsset == null)
				{
					Debug.LogWarning("PlayableAsset이 TimelineAsset이 아닙니다.");
					return null;
				}

				SignalAsset lastSignal = null;
				double lastSignalTime = double.MinValue;

				foreach(var track in timelineAsset.GetOutputTracks())
				{
					if(track is SignalTrack signalTrack)
					{
						foreach(var maker in signalTrack.GetMarkers())
						{
							var signalEmitter = maker as SignalEmitter;
							if(signalEmitter != null && signalEmitter.asset != null)
							{
								if(maker.time > lastSignalTime)
								{
									lastSignal = signalEmitter.asset;
									lastSignalTime = maker.time;
								}
							}
						}
					}
				}

				if(lastSignal != null)
				{
					Debug.Log($"가장 마지막 SignalAsset: {lastSignal.name} (시간: {lastSignalTime})");
				}
				else
				{
					Debug.LogWarning("SignalAsset을 찾을 수 없습니다.");
				}

				return lastSignal;
			}
		}
#endif
		private void Start()
		{
			// 1. AnimatorControllerPlayable 생성
			var runtimeController = animator.runtimeAnimatorController as RuntimeAnimatorController;
			graph = PlayableGraph.Create("AnimatorPlayableGraph");
			var controllerPlayable = AnimatorControllerPlayable.Create(graph, runtimeController);

			animatorControllerPlayable = controllerPlayable;

			// 2. AnimationPlayableOutput 생성 및 Animator 연결
			animationOutput = AnimationPlayableOutput.Create(graph, "AnimatorOutput", animator);
			animationOutput.SetSourcePlayable(animatorControllerPlayable);

			graph.Play();

			int length = stateMappings.Length;
			for(int i = 0 ; i < length ; i++)
			{
				PlayableDirector playableDirector = stateMappings[i].playableDirector;
				playableDirector.RebuildGraph();
				stateMappings[i].playableGraph = PlayableGraph.Create($"PlayableGraph_{i}");

				var playableOutput = ScriptPlayableOutput.Create(stateMappings[i].playableGraph, $"Output_{i}");
				playableOutput.SetSourcePlayable(playableDirector.playableGraph.GetRootPlayable(0));
			}
		}

		void OnDestroy()
		{
			if(graph.IsValid())
			{
				graph.Destroy();
			}
		}
		private void OnEnable()
		{
			int length = stateMappings.Length;
			for(int i = 0 ; i < length ; i++)
			{
				PlayableDirector playableDirector = stateMappings[i].playableDirector;
				SignalReceiver signalReceiver = stateMappings[i].signalReceiver;
				PlayableAsset playableAsset = stateMappings[i].playableAsset;
				SignalAsset signalAsset = stateMappings[i].stopSignalAsset;
				if(playableAsset == null || signalAsset == null) continue;

				var signalAssets = signalReceiver.GetRegisteredSignals();
				if(signalAssets.Contains(signalAsset))
				{
					signalReceiver.Remove(signalAsset);
				}
				UnityEvent unityEvent = new UnityEvent();
				unityEvent.AddListener(() => OnStopSignalReceivers(playableDirector));
				signalReceiver.AddReaction(signalAsset, unityEvent);
			}
		}
		private void OnDisable()
		{
			int length = stateMappings.Length;
			for(int i = 0 ; i < length ; i++)
			{
				PlayableDirector playableDirector = stateMappings[i].playableDirector;
				SignalReceiver signalReceiver = stateMappings[i].signalReceiver;
				PlayableAsset playableAsset = stateMappings[i].playableAsset;
				SignalAsset signalAsset = stateMappings[i].stopSignalAsset;
				if(playableAsset == null || signalAsset == null) continue;
				var signalAssets = signalReceiver.GetRegisteredSignals();
				if(signalAssets.Contains(signalAsset))
				{
					signalReceiver.Remove(signalAsset);
				}
			}
		}

		void OnStopSignalReceivers(PlayableDirector playableDirector)
		{
			playableDirector.Stop();
		}

		void Update()
		{
			AnimatorStateInfo currentStateInfo = animator.GetCurrentAnimatorStateInfo(0);
			//string currentStateName = GetCurrentStateName();

			bool stateHandledByPlayableDirector = false;

			for(int i = 0 ; i < stateMappings.Length ; i++)
			{
				string stateName = stateMappings[i].stateName;
				PlayableDirector playableDirector = stateMappings[i].playableDirector;
				SignalReceiver signalReceiver = stateMappings[i].signalReceiver;
				PlayableAsset playableAsset = stateMappings[i].playableAsset;
				SignalAsset signalAsset = stateMappings[i].stopSignalAsset;

				if(IsStateMappingName(stateName))
				{
					stateHandledByPlayableDirector = true;

					if(playableDirector.state != PlayState.Playing)
					{
						playableDirector.time = 0;
					}
					playableDirector.Play();
					float maxTime = (float)playableAsset.duration;
					animator.speed = 1f/maxTime;
				}
			}
			if(!stateHandledByPlayableDirector)
			{
				animator.speed = 1f;
			}
		}

		private bool IsStateMappingName(string stateMappingName)
		{
			for(int i = 0 ; i < animator.layerCount ; i++)
			{
				AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(i);
				if(stateInfo.normalizedTime < 1f)
				{
					return stateInfo.IsName(stateMappingName);
				}
			}
			return false;
		}
	}
}
