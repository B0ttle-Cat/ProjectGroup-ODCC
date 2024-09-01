using UnityEngine;

namespace BC.Base
{
	public partial class Utils//.Transform 
	{
		public static Pose GetWorldPose(this Transform transform)
		{
			transform.GetPositionAndRotation(out var pos, out var rot);
			return new Pose(pos, rot);
		}
		public static Pose GetLocalPose(this Transform transform)
		{
			transform.GetLocalPositionAndRotation(out var pos, out var rot);
			return new Pose(pos, rot);
		}
		public static void SetWorldPose(this Transform transform, Pose pose)
		{
			transform.SetPositionAndRotation(pose.position, pose.rotation);
		}
		public static void SetLocalPose(this Transform transform, Pose pose)
		{
			transform.SetLocalPositionAndRotation(pose.position, pose.rotation);
		}
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
