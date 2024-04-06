using System.Collections.Generic;

using UnityEngine;

namespace BC.Base
{
	[CreateAssetMenu(fileName = "SingletonPrefabDataList", menuName = "BC/Base/SingletonPrefabDataList")]
	public class SingletonPrefabDataList : ScriptableObject
	{
		public List<GameObject> PrefabList;

		private static SingletonPrefabDataList _this = null;
		public static SingletonPrefabDataList This => _this =_this != null ? _this : Resources.Load<SingletonPrefabDataList>(nameof(SingletonPrefabDataList));

		public T FindTypePrefab<T>() where T : MonoBehaviour
		{
			if(PrefabList != null)
			{
				for(int i = 0 ; i < PrefabList.Count ; i++)
				{
					if(PrefabList[i] != null && PrefabList[i].TryGetComponent(out T component))
					{
						return component;
					}
				}
			}
			return null;
		}
	}
}