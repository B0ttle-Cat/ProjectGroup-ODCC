using System;

using UnityEngine;

namespace BC.ODCC
{
	public interface IOdccItem
	{
	}

	public interface IOdccObject : IOdccItem
	{
		public ContainerObject ThisContainer { get; }
		public MonoBehaviour ThisMono { get; }
		public Transform ThisTransform { get; }
		public int GetHashCode();
		public void DestroyThis(bool removeThisGameObject = false);
	}

	public interface IOdccComponent : IOdccItem
	{
		public ObjectBehaviour ThisObject { get; }
		public MonoBehaviour ThisMono { get; }
		public ContainerObject ThisContainer { get; }
		public Transform ThisTransform { get; }
		public int GetHashCode();
		public void DestroyThis(bool removeThisGameObject = false);
	}

	public interface IOdccData : IOdccItem, IDisposable
	{
	}
}