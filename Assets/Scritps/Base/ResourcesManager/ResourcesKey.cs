using System;
using System.Collections.Generic;

using Sirenix.OdinInspector;

using UnityEngine;

using Object = UnityEngine.Object;

namespace BC.Base
{
	public enum eResourcesLoadType
	{
		None = -1,
		ObjectAsset = 2,
		ResourcesLoad = 0,
		AssetBundle = 1,
	}
	[Serializable]
#pragma warning disable CS0282 // partial 구조체의 여러 선언에서 필드 간 순서가 정의되어 있지 않습니다.
	public partial struct ResourcesKey : IEquatable<ResourcesKey>, IDisposable
#pragma warning restore CS0282 // partial 구조체의 여러 선언에서 필드 간 순서가 정의되어 있지 않습니다.
	{
#if UNITY_EDITOR
		[InfoBox(Success_CheckResourcesKey,InfoMessageType.Info,"ShowSuccessCheckResourcesKey")]
		[InfoBox(Fail_CheckResourcesKey,InfoMessageType.Warning,"ShowErrorCheckResourcesKey")]
		[LabelWidth(80),PropertyOrder(-11), HideLabel]
#endif
		public eResourcesLoadType LoadType;
#if UNITY_EDITOR
		[LabelWidth(80)]
		[ShowIf("@ShowBundleName"), EnableIf("@EnableBundleName")]
#endif
		public string BundleName;
#if UNITY_EDITOR
		[ShowIf("@ShowFullPath"), EnableIf("@EnableFullPath")]
		[LabelWidth(80)]
		[Multiline(2)]
#endif
		public string FullPath;
#if UNITY_EDITOR
		[ShowIf("@ShowObjectAsset"), EnableIf("@EnableObjectAsset")]
		[LabelWidth(80)]
#endif
		public Object ObjectAsset;

		public static ResourcesKey Empty => new ResourcesKey() { LoadType = eResourcesLoadType.None, FullPath = "", BundleName = "", ObjectAsset  = null };
		public bool IsEmpty => LoadType switch {
			eResourcesLoadType.None => true,
			eResourcesLoadType.ResourcesLoad => string.IsNullOrWhiteSpace(FullPath),
			eResourcesLoadType.AssetBundle => string.IsNullOrWhiteSpace(FullPath) || string.IsNullOrWhiteSpace(BundleName),
			eResourcesLoadType.ObjectAsset => ObjectAsset == null,
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
			if(LoadType == eResourcesLoadType.None) return true;
			if(LoadType == eResourcesLoadType.AssetBundle && BundleName != other.BundleName) return false;
			if((LoadType == eResourcesLoadType.ResourcesLoad||LoadType == eResourcesLoadType.AssetBundle) && FullPath != other.FullPath) return false;
			if(LoadType == eResourcesLoadType.ObjectAsset && !EqualityComparer<Object>.Default.Equals(ObjectAsset, other.ObjectAsset)) return false;
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
		public static void AsyncInstantiate<T>(this ResourcesKey loadKey, MonoBehaviour mono, Action<float> progress, Action<T> result) where T : Object
		{
			if(loadKey.IsEmpty)
			{
				result?.Invoke(null);
				return;
			}
			ResourcesManager.AsyncInstantiate(loadKey, mono, progress, result);
		}
		public static void AsyncInstantiate<T>(this ResourcesKey loadKey, MonoBehaviour mono, Action<T> result) where T : Object
		{
			AsyncInstantiate(loadKey, mono, null, result);
		}
		public static void Unload(this ResourcesKey loadKey, MonoBehaviour mono)
		{
			if(loadKey.LoadType != eResourcesLoadType.ObjectAsset)
			{
				ResourcesManager.Unload(loadKey, mono);
			}
		}

	}
}
