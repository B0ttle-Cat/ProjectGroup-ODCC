#if UNITY_EDITOR
using System.Collections.Generic;

using Sirenix.OdinInspector;

using UnityEditor;
using UnityEditor.Animations;

using UnityEngine;

namespace BC.OdccBase
{
	public partial class AnimatorInfo : SerializedScriptableObject// StateEditor
	{
		private void UpdateAsset()
		{
			AnimatorController animatorController;
			if(Controller is AnimatorOverrideController isOverride)
			{
				animatorController = isOverride.runtimeAnimatorController as AnimatorController;
			}
			else
			{
				animatorController = Controller as AnimatorController;
			}
			if(animatorController == null) return;

			UpdateName(animatorController);
			UpdateState(animatorController);
			UpdateScript(animatorController);
		}
		private void UpdateName(AnimatorController animatorController)
		{
			name = animatorController.name + "_StateList";

			string assetPath = AssetDatabase.GetAssetPath(this);
			AssetDatabase.RenameAsset(assetPath, name);
			AssetDatabase.SaveAssets(); // ScriptableObject 저장
			AssetDatabase.Refresh(); // 에셋 데이터베이스 갱신
		}
		private void UpdateState(AnimatorController animatorController)
		{
			name = animatorController.name + "_StateList";

			List<(AnimatorControllerLayer, AnimatorStateMachine, AnimatorState)> states = new List<(AnimatorControllerLayer, AnimatorStateMachine, AnimatorState)>();

			// 모든 레이어에 대해 State를 검색
			foreach(AnimatorControllerLayer layer in animatorController.layers)
			{
				foreach(ChildAnimatorState state in layer.stateMachine.states)
				{
					states.Add((layer, layer.stateMachine, state.state));
				}

				// 하위 StateMachine의 State 검색 (재귀 호출)
				foreach(ChildAnimatorStateMachine subStateMachine in layer.stateMachine.stateMachines)
				{
					RecursiveSearchStates(layer, subStateMachine.stateMachine, ref states);

				}
			}

			/// AniamtorStateInfo 값을 채워넣기
			if(AniamtorStateInfo != null) AniamtorStateInfo.Clear();

			AniamtorStateInfo = GenerateLayerInfos(states);

			AssetDatabase.SaveAssets(); // ScriptableObject 저장
			AssetDatabase.Refresh(); // 에셋 데이터베이스 갱신


			static void RecursiveSearchStates(AnimatorControllerLayer layer, AnimatorStateMachine stateMachine, ref List<(AnimatorControllerLayer, AnimatorStateMachine, AnimatorState)> states)
			{
				foreach(ChildAnimatorState state in stateMachine.states)
				{
					states.Add((layer, stateMachine, state.state));
				}

				foreach(ChildAnimatorStateMachine subStateMachine in stateMachine.stateMachines)
				{
					RecursiveSearchStates(layer, subStateMachine.stateMachine, ref states);
				}
			}
		}

		private void ClearAsset()
		{
			DeleteScript();
			AniamtorStateInfo = new List<LayerInfo>();
		}

		private List<LayerInfo> GenerateLayerInfos(List<(AnimatorControllerLayer, AnimatorStateMachine, AnimatorState)> states)
		{
			var aniamtorStateInfo = new List<LayerInfo>();
			int count = states.Count;
			for(int i = 0 ; i < count ; i++)
			{
				var item = states[i];
				var layer = item.Item1;
				var machine = item.Item2;
				var state = item.Item3;

				int layerIndex = aniamtorStateInfo.FindIndex(_layer => _layer.LayerName == layer.name);
				if(layerIndex<0)
				{
					layerIndex = aniamtorStateInfo.Count;
					aniamtorStateInfo.Add(new LayerInfo(layer.name));
				}
				var layerInfo = aniamtorStateInfo[layerIndex];

				int machineindex = layerInfo.Infos.FindIndex(_machine => _machine.MachineName == machine.name);
				if(machineindex<0)
				{
					machineindex = layerInfo.Infos.Count;
					layerInfo.Add(new MachineInfo(machine.name));
				}
				var machineInfo = layerInfo[machineindex];

				int stateindex = machineInfo.Infos.FindIndex(_state => _state.Name == state.name);
				if(stateindex<0)
				{
					stateindex = machineInfo.Infos.Count;
					machineInfo.Add(new StateInfo(layerInfo.LayerName, machineInfo.MachineName, state.name, state.tag, state.motion));
				}
				var stateInfo = machineInfo[stateindex];
			}

			return aniamtorStateInfo;
		}


	}
}
#endif