using System;

namespace BC.ODCC
{
	[Serializable]
	public class DataObject : IOdccData
	{
		bool IOdccData.IsData => true;
		public DataObject()
		{
		}
		internal IOdccItem IOdccItem => this;
		int IOdccItem.odccTypeIndex { get; set; }
		int[] IOdccItem.odccTypeInheritanceIndex { get; set; }
#if UNITY_EDITOR
		protected bool IsMustNotNull(params object[] objects) => Array.TrueForAll(objects, obj => obj != null);
#endif
		private bool disposedValue;

		protected virtual void Disposing()
		{

		}

		public void Dispose()
		{
			if(!disposedValue)
			{
				Disposing();
				disposedValue=true;
			}
			GC.SuppressFinalize(this);
		}
	}
}
