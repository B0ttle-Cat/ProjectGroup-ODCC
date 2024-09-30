using System;

namespace BC.ODCC
{
	[Serializable]
	public class DataObject : IOdccData
	{
		public DataObject()
		{
		}
		private int odccTypeIndex = -1;
		private int[] odccTypeInheritanceIndex = null;
		public int OdccTypeIndex => odccTypeIndex == -1 ? odccTypeIndex = OdccManager.GetTypeToIndex(GetType()) : odccTypeIndex;
		public int[] OdccTypeInheritanceIndex => (odccTypeInheritanceIndex == null || odccTypeInheritanceIndex.Length == 0) ? OdccManager.GetTypeInheritanceTable(OdccTypeIndex) : odccTypeInheritanceIndex;
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
