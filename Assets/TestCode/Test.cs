#if UNITY_EDITOR
using BC.ODCC;

using Sirenix.OdinInspector;

using UnityEngine;

public class Test : MonoBehaviour
{
	[Button]
	internal void Main()
	{
		OdccQueryCollector odccQueryCollector = OdccQueryCollector.CreateQueryCollector(QuerySystemBuilder.SimpleQueryBuild<ObjectBehaviour>());


		odccQueryCollector.CreateLooperEvent("Test")
			.CallAction(() => {
				Debug.Log("Test");
			});

	}



}
#endif