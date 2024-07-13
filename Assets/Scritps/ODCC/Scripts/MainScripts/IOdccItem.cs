using UnityEngine;

namespace BC.ODCC
{
	public interface IOdccItem
	{
	}

	public interface IOdccObject : IOdccItem
	{
		public ContainerObject ThisContainer { get; }
		public Transform ThisTransform { get; }
		public int GetHashCode();
	}

	public interface IOdccComponent : IOdccItem
	{
		public ObjectBehaviour ThisObject { get; }
		public ContainerObject ThisContainer { get; }
		public Transform ThisTransform { get; }
		public int GetHashCode();
	}

	public interface IOdccData : IOdccItem
	{
	}
}