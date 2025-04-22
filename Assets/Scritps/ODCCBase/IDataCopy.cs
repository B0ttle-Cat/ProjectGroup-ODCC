using System;

using BC.ODCC;

using UnityEngine;
namespace BC.OdccBase
{
	public interface IDataCopy : IOdccData
	{
		DataObject DataCopy()
		{
			try
			{
				string json = JsonUtility.ToJson(this);
				return (DataObject)JsonUtility.FromJson(json, GetType());
			}
			catch(Exception ex)
			{
				Debug.LogException(ex);
				return null;
			}
		}
		T DataCopy<T>() where T : DataObject
		{
			return DataCopy() is T tCopy ? tCopy : null;
		}
	}
}