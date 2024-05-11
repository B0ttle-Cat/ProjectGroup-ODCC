using System;

using Object = UnityEngine.Object;

namespace BC.ODCC
{
	[Serializable]
	public class DataObject : IOdccData, IDisposable
	{
#if UNITY_EDITOR
		bool IsMustNotNull(
			Object obj9)
		{
			return
				obj9 != null;
		}
		bool IsMustNotNull(
			Object obj8,
			Object obj9)
		{
			return
				obj8 != null &&
				obj9 != null;
		}
		bool IsMustNotNull(
			Object obj7,
			Object obj8,
			Object obj9)
		{
			return
				obj7 != null &&
				obj8 != null &&
				obj9 != null;
		}
		bool IsMustNotNull(
			Object obj6,
			Object obj7,
			Object obj8,
			Object obj9)
		{
			return
				obj6 != null &&
				obj7 != null &&
				obj8 != null &&
				obj9 != null;
		}
		bool IsMustNotNull(
			Object obj5,
			Object obj6,
			Object obj7,
			Object obj8,
			Object obj9)
		{
			return
				obj5 != null &&
				obj6 != null &&
				obj7 != null &&
				obj8 != null &&
				obj9 != null;
		}
		bool IsMustNotNull(
			Object obj4,
			Object obj5,
			Object obj6,
			Object obj7,
			Object obj8,
			Object obj9)
		{
			return
				obj4 != null &&
				obj5 != null &&
				obj6 != null &&
				obj7 != null &&
				obj8 != null &&
				obj9 != null;
		}
		bool IsMustNotNull(
			Object obj3,
			Object obj4,
			Object obj5,
			Object obj6,
			Object obj7,
			Object obj8,
			Object obj9)
		{
			return
				obj3 != null &&
				obj4 != null &&
				obj5 != null &&
				obj6 != null &&
				obj7 != null &&
				obj8 != null &&
				obj9 != null;
		}
		bool IsMustNotNull(
			Object obj2,
			Object obj3,
			Object obj4,
			Object obj5,
			Object obj6,
			Object obj7,
			Object obj8,
			Object obj9)
		{
			return
				obj2 != null &&
				obj3 != null &&
				obj4 != null &&
				obj5 != null &&
				obj6 != null &&
				obj7 != null &&
				obj8 != null &&
				obj9 != null;
		}
		bool IsMustNotNull(
			Object obj1,
			Object obj2,
			Object obj3,
			Object obj4,
			Object obj5,
			Object obj6,
			Object obj7,
			Object obj8,
			Object obj9)
		{
			return
				obj1 != null &&
				obj2 != null &&
				obj3 != null &&
				obj4 != null &&
				obj5 != null &&
				obj6 != null &&
				obj7 != null &&
				obj8 != null &&
				obj9 != null;
		}
		bool IsMustNotNull(
			Object obj0,
			Object obj1,
			Object obj2,
			Object obj3,
			Object obj4,
			Object obj5,
			Object obj6,
			Object obj7,
			Object obj8,
			Object obj9)
		{
			return
				obj0 != null &&
				obj1 != null &&
				obj2 != null &&
				obj3 != null &&
				obj4 != null &&
				obj5 != null &&
				obj6 != null &&
				obj7 != null &&
				obj8 != null &&
				obj9 != null;
		}
#endif
		private bool disposedValue;

		protected virtual void Dispose(bool disposing)
		{

		}

		public void Dispose()
		{
			if(!disposedValue)
			{
				Dispose(disposing: true);
				disposedValue=true;
			}
			GC.SuppressFinalize(this);
		}
	}
}
