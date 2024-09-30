using System;

using UnityEngine;

using Object = UnityEngine.Object;

namespace BC.Base
{
	public enum eResourcesLoadType
	{
		None = 0,
		//ResourcesLoad = 0,
		//AssetBundle = 1,
	}
	[Serializable]
#pragma warning disable CS0282 // partial 구조체의 여러 선언에서 필드 간 순서가 정의되어 있지 않습니다.
	public partial struct ResourcesKey : IDisposable
#pragma warning restore CS0282 // partial 구조체의 여러 선언에서 필드 간 순서가 정의되어 있지 않습니다.
	{
		public eResourcesLoadType LoadType;
		public Object ObjectAsset;

		public bool IsEmpty => LoadType switch {
			eResourcesLoadType.None => ObjectAsset == null,
			_ => false,
		};
		public override bool Equals(object obj)
		{
			return obj is ResourcesKey key&&Equals(key);
		}
		public bool Equals(ResourcesKey other)
		{
			if(other == null && this == null) return true;
			if(other == null || this == null) return false;

			if(LoadType!=other.LoadType) return false;
			if(LoadType == eResourcesLoadType.None) return ObjectAsset == other.ObjectAsset;
			return true;
		}
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		public override string ToString()
		{
			return base.ToString();
		}
		public static bool operator ==(ResourcesKey left, ResourcesKey right)
		{
			return left.Equals(right);
		}
		public static bool operator !=(ResourcesKey left, ResourcesKey right)
		{
			return !(left==right);
		}


		public void Dispose()
		{
			ObjectAsset = null;
		}
	}

	public static class UtilResourcesKey
	{
		public static void AsyncInstantiate<T>(this ResourcesKey loadKey, MonoBehaviour mono, Action<T> result, Action<float> progress = null) where T : Object
		{
			loadKey.LoadType = eResourcesLoadType.None;
			if(loadKey.IsEmpty)
			{
				Debug.LogError("ResourcesKey Is Empty");
				result?.Invoke(null);
				return;
			}
			ResourcesManager.AsyncInstantiate(loadKey, mono, progress, result);
		}
		public static async Awaitable<T> AsyncInstantiate<T>(this ResourcesKey loadKey, MonoBehaviour mono, Action<float> progress = null) where T : Object
		{
			T obj = null;
			bool wait = true;
			AsyncInstantiate<T>(loadKey, mono, (t) => { obj = t; wait = false; }, progress);
			while(wait)
			{
				await Awaitable.NextFrameAsync();
			}
			return obj;
		}
		public static void Unload(this ResourcesKey loadKey, MonoBehaviour mono)
		{
			if(loadKey.LoadType != eResourcesLoadType.None)
			{
				ResourcesManager.Unload(loadKey, mono);
			}
		}

	}
}
