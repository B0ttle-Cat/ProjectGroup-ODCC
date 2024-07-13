#if UNITY_EDITOR
using UnityEngine;

namespace BC.ODCC
{
	public static partial class OdccContainerTree//.EditorFinder
	{
		public static bool TryFindOdccType_InEditor<T>(out T result) where T : IOdccItem
		{
			result = default;
			try
			{
				foreach(var item in ContainerNodeList)
				{
					if(item.Key is T tObj)
					{
						result = tObj;
						return true;
					}
					var node = item.Value;
					try
					{
						foreach(var comp in node.componentList)
						{
							if(comp is T tComp)
							{
								result = tComp;
								return true;
							}
						}
					}
					catch(System.Exception ex)
					{
						Debug.LogException(ex);
					}
					try
					{
						foreach(var data in node.dataList)
						{
							if(data is T tData)
							{
								result = tData;
								return true;
							}
						}
					}
					catch(System.Exception ex)
					{
						Debug.LogException(ex);
					}
				}
			}
			catch(System.Exception ex)
			{
				Debug.LogException(ex);
			}
			return false;
		}
	}
}
#endif