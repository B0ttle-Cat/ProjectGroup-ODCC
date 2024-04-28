using System;
using System.Collections;
using System.Collections.Generic;

using Sirenix.OdinInspector;


#if UNITY_EDITOR

#endif
using UnityEngine;

using static BC.OdccBase.AnimatorInfo;

namespace BC.OdccBase
{
	[CreateAssetMenu(fileName = "AnimatorInfo", menuName = "BC/Animator/AnimatorInfo")]
	public partial class AnimatorInfo : SerializedScriptableObject, IEnumerable<LayerInfo>
	{
		[InlineButton("ClearAsset", "Clear Info")]
		[InlineButton("UpdateAsset", "Update Info")]
		[HideLabel, PropertyOrder(-99)]
		public RuntimeAnimatorController Controller;
		[ReadOnly,Space(20), PropertyOrder(0)]
		public List<LayerInfo> AniamtorStateInfo;


		public LayerInfo this[int indexer] {
			get
			{
				return AniamtorStateInfo.Count > indexer ? AniamtorStateInfo[indexer] : default;
			}
			internal set { AniamtorStateInfo[indexer] = value; }
		}
		public int Count => AniamtorStateInfo.Count;
		public IEnumerator<LayerInfo> GetEnumerator()
		{
			return ((IEnumerable<LayerInfo>)AniamtorStateInfo).GetEnumerator();
		}
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable)AniamtorStateInfo).GetEnumerator();
		}

		[Serializable]
		public struct LayerInfo : IEnumerable<MachineInfo>
		{
			[ShowIf("showName")]
			public string LayerName;
			[LabelText("@filed")]
			public List<MachineInfo> Infos;
#if UNITY_EDITOR
			private bool showName => false;
			private string filed => $"LayerInfo: {LayerName}";
#endif
			public readonly MachineInfo this[int indexer] {
				get { return Infos.Count > indexer ? Infos[indexer] : default; }
				internal set { Infos[indexer] = value; }
			}
			public int Count => Infos.Count;
			public LayerInfo(string name)
			{
				LayerName=name;
				Infos=new List<MachineInfo>();
			}
			internal void Add(MachineInfo info)
			{
				Infos.Add(info);
			}

			public IEnumerator<MachineInfo> GetEnumerator()
			{
				return ((IEnumerable<MachineInfo>)Infos).GetEnumerator();
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return ((IEnumerable)Infos).GetEnumerator();
			}
		}

		[Serializable]
		public struct MachineInfo : IEnumerable<StateInfo>
		{
			[ShowIf("showName")]
			public string MachineName;
			[LabelText("@filed"), TableList]
			public List<StateInfo> Infos;
#if UNITY_EDITOR
			private bool showName => false;
			private string filed => $"MachineInfo: {MachineName}";
#endif
			public StateInfo this[int indexer] {
				get { return Infos.Count > indexer ? Infos[indexer] : default; }
				internal set { Infos[indexer] = value; }
			}
			public int Count => Infos.Count;
			public MachineInfo(string name)
			{
				MachineName=name;
				Infos=new List<StateInfo>();
			}
			internal void Add(StateInfo info)
			{
				Infos.Add(info);
			}

			public IEnumerator<StateInfo> GetEnumerator()
			{
				return ((IEnumerable<StateInfo>)Infos).GetEnumerator();
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return ((IEnumerable)Infos).GetEnumerator();
			}
		}
		[Serializable]
		public struct StateInfo
		{
			[HideInTables, ShowIf("@false")]
			public string layerName;
			[HideInTables, ShowIf("@false")]
			public string machineName;
			[ReadOnly]
			public string Name;
			[ReadOnly]
			public string Tag;
			[ReadOnly]
			public Motion Motion;

			public StateInfo(string layerName, string machineName, string name, string tag, Motion motion)
			{
				this.layerName = layerName;
				this.machineName = machineName;
				Name=name;
				Tag = tag;
				Motion = motion;
			}
			public bool TryGetAnimationClip(out AnimationClip clip)
			{
				clip = null;
				if(Motion != null && Motion is AnimationClip _clip)
				{
					clip = _clip;
					return true;
				}
				return false;
			}
		}

	}
}
