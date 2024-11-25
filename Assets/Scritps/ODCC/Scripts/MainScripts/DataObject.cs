using System;

using Sirenix.OdinInspector;

namespace BC.ODCC
{
	[Serializable]
	[HideReferenceObjectPicker]
	public class DataObject : IOdccData
	{
#if UNITY_EDITOR
		[ShowInInspector, Title(""), PropertyOrder(float.MinValue), PropertySpace(-4, -20)]
		[HideLabel, DisplayAsString, EnableGUI]
		private string ShowInInspector_DataLabel => "";
		[ShowInInspector, PropertyOrder(float.MinValue), PropertySpace(-26, 6)]
		[InlineButton("PingThisDataScript", " This Script ")]
		[HideLabel, DisplayAsString(EnableRichText = true), EnableGUI]
		private string ShowInInspector_DataLabel2 => $"<b><size=15>{GetType().Name}</size></b> <size=10>({GetType().Namespace})<size>";
		private void PingThisDataScript()
		{
			// 현재 컴포넌트의 이름을 기준으로 스크립트 검색
			string scriptName = GetType().Name;
			string scriptFileName = $"{GetType().Name}.cs";

			string[] guids = UnityEditor.AssetDatabase.FindAssets($"{scriptName} t:Script");

			foreach(string guid in guids)
			{
				// 첫 번째 검색 결과를 기준으로 Asset 경로 가져오기
				string path = UnityEditor.AssetDatabase.GUIDToAssetPath(guid);
				if(System.IO.Path.GetFileName(path) == scriptFileName)
				{
					UnityEngine.Object scriptAsset = UnityEditor.AssetDatabase.LoadAssetAtPath<UnityEngine.Object>(path);

					// 에디터에서 해당 스크립트를 강조
					UnityEditor.EditorGUIUtility.PingObject(scriptAsset);
				}
			}
		}
#endif
		bool IOdccData.IsData => true;
		public DataObject()
		{
		}
		internal IOdccItem IOdccItem => this;
		int IOdccItem.odccTypeIndex { get; set; }
		int[] IOdccItem.odccTypeInheritanceIndex { get; set; }
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
