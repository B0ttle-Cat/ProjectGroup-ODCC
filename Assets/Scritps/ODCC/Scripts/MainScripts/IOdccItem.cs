using System;
using System.ComponentModel;
using System.Threading;

using UnityEngine;

namespace BC.ODCC
{
	public interface IOdccItem
	{
		internal int odccTypeIndex { get; set; }
		internal int[] odccTypeInheritanceIndex { get; set; }
		public int OdccTypeIndex => odccTypeIndex == 0 ? odccTypeIndex = OdccManager.GetTypeToIndex(GetType()) : odccTypeIndex;
		public int[] OdccTypeInheritanceIndex => (odccTypeInheritanceIndex == null || odccTypeInheritanceIndex.Length == 0) ? OdccManager.GetTypeInheritanceTable(OdccTypeIndex) : odccTypeInheritanceIndex;
	}
	public interface IOCBehaviour : IOdccItem, IDisposable
	{
		public GameObject GameObject { get; }
		public MonoBehaviour ThisMono { get; }
		public Transform ThisTransform { get; }

		[Flags, DefaultValue(StateFlag.Off)]
		internal enum StateFlag
		{
			Off, // 비활성
			On,  // 활성
		}
		internal StateFlag AwakeState { get; set; }
		internal StateFlag EnableState { get; set; }
		internal StateFlag StartState { get; set; }
		internal StateFlag DestroyState { get; set; }
		internal bool _IsCanEnterAwake => AwakeState == StateFlag.Off && DestroyState == StateFlag.Off;
		internal bool _IsCanEnterUpdate => AwakeState == StateFlag.On && EnableState == StateFlag.On && StartState == StateFlag.On && DestroyState == StateFlag.Off;
		internal bool _IsCanEnterDestroy => DestroyState == StateFlag.Off;
		public bool IsAwake => AwakeState == StateFlag.On && DestroyState == StateFlag.Off;
		public bool IsEnable => IsAwake && EnableState == StateFlag.On;
		public bool IsDestroy => DestroyState == StateFlag.On;
		public CancellationToken DestroyCancelToken { get; }
		public CancellationToken DisableCancelToken { get; }
		public void DestroyThis(bool removeThisGameObject = false);

		internal void OdccAwake();
		internal void OdccDestroy();
		internal void OdcnEnable();
		internal void OdccDisable();
		internal void OdccStart();
	}
	public interface IOdccObject : IOCBehaviour
	{
		public ContainerObject ThisContainer { get; }
		string DetailLog()
		{
			string log
= @$"IOdccObject : {GameObject.name}
Type : {GetType().Name}
Is IOCBehaviour : {this is IOCBehaviour}
Is IOdccObject : {this is IOdccObject}
Is IOdccComponent : {this is IOdccComponent}
AwakeState : {AwakeState}
EnableState : {EnableState}
StartState : {StartState}
DestroyState : {DestroyState}
";
			return log;
		}
		internal void CreateThisContainer(ContainerNode target);
	}
	public interface IOdccComponent : IOCBehaviour, IOdccItem
	{
		public ObjectBehaviour ThisObject { get; }
		public ContainerObject ThisContainer { get; }

		internal void ConnectThisObject(ContainerNode target);
	}

	public interface IOdccData : IOdccItem, IDisposable
	{
		internal bool IsData { get; }
		public ContainerObject ThisContainer { get; }
	}
	public interface IOdccUpdate : IOCBehaviour
	{
		public void BaseUpdate();
		public interface Fast : IOCBehaviour
		{
			public void BaseFastUpdate();
		}
		public interface Late : IOCBehaviour
		{
			public void BaseLateUpdate();
		}
		public interface Fixed : IOCBehaviour
		{
			public void BaseFixedUpdate();
		}
	}
}