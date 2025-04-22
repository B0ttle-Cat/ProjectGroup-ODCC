using System;

using Sirenix.OdinInspector;

namespace BC.ODCC
{
	[Serializable]
	[HideReferenceObjectPicker]
	public class DataObject : IOdccData
	{
		//[HideInEditorMode]
		//public string guid;
#if UNITY_EDITOR
		[ShowInInspector, Title(""), PropertyOrder(float.MinValue), PropertySpace(-4, -20)]
		[HideLabel, DisplayAsString, EnableGUI]
		private string ShowInInspector_DataLabel => "";
		[ShowInInspector, PropertyOrder(float.MinValue), PropertySpace(-26, 6)]
		[InlineButton("PingThisDataScript", " This Script ")]
		[HideLabel, DisplayAsString(EnableRichText = true), EnableGUI]
		private string ShowInInspector_DataLabel2 => $"<b><size=15>{GetType().Name}</size></b> <size=10>({GetType().Namespace})<size>";
		private double Editor_LastClickTime = -1; // 마지막 클릭 시간을 기록
		private const double Editor_ClickInterval = 0.25; // 클릭 간격

		private void PingThisDataScript()
		{
			BC.Base.PingAndOpenScript.PingScript(GetType(), true);
		}
#endif
		bool IOdccData.IsData => true;
		public DataObject()
		{
			//	guid = System.Guid.NewGuid().ToString();
		}
		internal IOdccItem IOdccItem => this;
		int IOdccItem.odccTypeIndex { get; set; }
		int[] IOdccItem.odccTypeInheritanceIndex { get; set; }
		public ContainerObject ThisContainer { get; internal set; }
		ContainerObject IOdccItem.OdccItemContainer { get => ThisContainer; set => ThisContainer = value; }
#if UNITY_EDITOR
		protected bool IsMustNotNull(params object[] objects) => Array.TrueForAll(objects, obj => obj != null);
#endif
		private bool disposedValue;
		protected virtual void Disposing()
		{

		}
		public void Dispose()
		{
			if(!disposedValue)
			{
				Disposing();
				disposedValue=true;
			}
			GC.SuppressFinalize(this);
		}
	}
}
