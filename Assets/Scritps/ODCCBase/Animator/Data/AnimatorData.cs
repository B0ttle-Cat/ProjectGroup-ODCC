using BC.ODCC;

using Sirenix.OdinInspector;

namespace BC.OdccBase
{
	public class AnimatorData : DataObject
	{
#if UNITY_EDITOR
		[AssetSelector, ValidateInput("@IsMustNotNull(animatorInfo)", "Is Must Not Null")]
#endif
		public AnimatorInfo animatorInfo;


	}
}
