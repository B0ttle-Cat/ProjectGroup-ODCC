using System;

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
	public interface IOCBehaviour : IOdccItem
	{
		public MonoBehaviour ThisMono { get; }
		public Transform ThisTransform { get; }
		internal bool IsAwake { get; set; }
		internal bool IsEnable { get; set; }
		internal bool IsCallDestroy { get; set; }
		internal bool IsCanUpdateDisable { get; set; }
		public void DestroyThis(bool removeThisGameObject = false);
	}
	public interface IOdccObject : IOCBehaviour
	{
		public ContainerObject ThisContainer { get; }
	}
	public interface IOdccComponent : IOCBehaviour
	{
		public ObjectBehaviour ThisObject { get; }
		public ContainerObject ThisContainer { get; }
	}

	public interface IOdccData : IOdccItem, IDisposable
	{
	}

	public interface IOdccUpdate : IOCBehaviour
	{
		public void BaseUpdate();
		public interface Late : IOCBehaviour
		{
			public void BaseLateUpdate();
		}
		//public interface Fixed : IOCBehaviour
		//{
		//	public void FixedUpdate();
		//}
	}
}