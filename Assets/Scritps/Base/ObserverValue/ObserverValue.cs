using System;

namespace BC.Base
{
	public class ObserverValue<T>
	{
		Action<T> callback;
		private T value;

		private bool pause;
		private T pauseValue;
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
