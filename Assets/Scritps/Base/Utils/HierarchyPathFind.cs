using UnityEngine;

namespace BC.Base
{
	public static class HierarchyPathFind
	{
		public static GameObject FindObject(string path, Transform root = null)
		{
			if(root == null)
			{
				return FindObjectInRoot(path);
			}
			else
			{
				return FindChildObject(root, path);
			}
		}
		public static GameObject FindChildObject(Transform transform, string path)
		{
			if(string.IsNullOrWhiteSpace(path)) return transform.gameObject;
			Transform findTr = transform.Find(path);
			return findTr == null ? null : findTr.gameObject;
		}
		public static GameObject FindObjectInRoot(string path)
		{
			if(string.IsNullOrWhiteSpace(path)) return null;
			var paths = path.Split("/");
			string rootName = paths[0];
			GameObject rootObj =  GameObject.Find($"/{rootName}");
			if(paths.Length == 1) return rootObj;
			int rootNameLength = rootName.Length + 1;
			int childPathLength = path.Length - rootNameLength;

			Transform findTr = rootObj.transform.Find(path.Substring(rootNameLength, childPathLength));
			return findTr == null ? rootObj : findTr.gameObject;
		}
	}
}
