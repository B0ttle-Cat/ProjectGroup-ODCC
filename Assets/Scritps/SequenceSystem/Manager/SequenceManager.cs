using System.Collections.Generic;

using Sirenix.OdinInspector;

using UnityEngine;

namespace BC.Sequence
{
	[DefaultExecutionOrder(-1)]
	public class SequenceManager : MonoBehaviour
	{
		public static SequenceManager Instance;
		private List<Node> updateNodes = new List<Node>();
		/// <summary>
		/// ODCC 매니저를 초기화하는 메서드입니다. 씬이 로드되기 전에 실행됩니다.
		/// </summary>
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		static void InitOdccManager()
		{
			Instance = new GameObject().AddComponent<SequenceManager>();
			Instance.gameObject.name = "[Sequence Manager]";
			Instance.updateNodes = new List<Node>();
			DontDestroyOnLoad(Instance.gameObject);
		}

		public void Play(SequencePlayer sequencePlayer, System.Action callback = null)
		{
			if(sequencePlayer == null) return;
			sequencePlayer.Play(callback);
		}


		internal void NodeStart(Node node)
		{
			updateNodes.Add(node);
		}

		public void Update()
		{
			int length  = updateNodes.Count;
			for(int i = length -1 ; i >= 0 ; i--)
			{
				var state = updateNodes[i].NodeUpdate();
				if(state is Node.State.Success or Node.State.Failure)
				{
					updateNodes.RemoveAt(i);
				}
			}
		}




		[Button]
		public void Test()
		{
			var graphBuilder =  SequenceBuilder.Create("Hello Sequence Node")
				.Logger("Hello Action Node1")
				.Random()
					.Item(NodeBuilder.Logger("Random 1"))
					.Item(NodeBuilder.Logger("Random 2"))
					.Item(NodeBuilder.Logger("Random 3"))
					.Item(NodeBuilder.Logger("Random 4"))
					.Item(NodeBuilder.Logger("Random 5"))
					.Break()
				.Logger("Hello Action Node2")
				.Condition(() => true)
					.True(NodeBuilder.Logger("True"))
					.ElseIf(()=>true, NodeBuilder.Logger("ELIF 1"))
					.False(NodeBuilder.Logger("False"))
					.Break()
				.Logger("Hello Action Node3")
				.ParallelAll()
					.Parallel(NodeBuilder.Logger("Parallel 1"))
					.Parallel(NodeBuilder.Logger("Parallel 2"))
					.Parallel(NodeBuilder.Logger("Parallel 3"))
					.Parallel(NodeBuilder.Logger("Parallel 4"))
					.Parallel(NodeBuilder.Logger("Parallel 5"))
					.Break()
				.Break()
			.Return();

			var player = SequenceBuilder.Build(graphBuilder);


			Play(player);
		}
	}
}
