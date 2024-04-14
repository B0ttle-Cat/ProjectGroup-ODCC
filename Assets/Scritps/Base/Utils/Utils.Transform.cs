using UnityEngine;

namespace BC.Base
{
	public partial class Utils//.Transform 
	{
		public static void ResetLcoalPose(this Transform transform)
		{
			transform.localPosition = Vector3.zero;
			transform.localRotation = Quaternion.identity;
			transform.localScale = Vector3.one;
		}
		public static void ResetLcoalPose(this Transform transform, Transform parent)
		{
			transform.parent = parent;
			transform.localPosition = Vector3.zero;
			transform.localRotation = Quaternion.identity;
			transform.localScale = Vector3.one;
		}
	}
}
