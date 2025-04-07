using System;

using Sirenix.OdinInspector;

using UnityEngine;

namespace BC.Base
{
	[Serializable, InlineProperty]
	public class ObserverValue<T>
	{
		Action<T> callback;
		[SerializeField,HideLabel]
		private T value;

		private bool pause;
		private T pauseValue;
		public ObserverValue()
		{
			this.callback = null;
			this.value = default;
		}
		public ObserverValue(T value)
		{
			this.callback = null;
			this.value = value;
		}
		public ObserverValue(Action<T> callback)
		{
			this.callback = callback;
			this.value = default;
		}
		public ObserverValue(Action<T> callback, T value)
		{
			this.callback = callback;
			this.value = value;
		}
		public void InitValue(T value)
		{
			this.value = value;
			pauseValue = value;
		}
		public T Value {
			get { return value; }
			set {
				this.value = value;
				Callback();
			}
		}
		public Action<T> Event { get => callback; set => callback = value; }
		public void Pause()
		{
			pause = true;
			pauseValue = value;
		}
		public void Pause(T value)
		{
			pause = true;
			this.value = value;
			pauseValue = value;
		}
		public void Resume()
		{
			pause = false;
			if(value.Equals(pauseValue)) return;
			Callback();
		}
		public void Resume(T value)
		{
			pause = false;
			this.value = value;
			if(value.Equals(pauseValue)) return;
			Callback();
		}
		public void Callback()
		{
			if(pause) return;
			try
			{
				callback?.Invoke(value);
			}
			catch(Exception ex)
			{
				Debug.LogException(ex);
			}
		}
	}
}
