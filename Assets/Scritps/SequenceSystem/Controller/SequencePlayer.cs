using System.Collections.Generic;

using UnityEngine;

namespace BC.Sequence
{
	public class SequencePlayer
	{
		public Node root;
		private System.Action endCallback;

		private List<Node> updateNodes = new List<Node>();
		private bool isStart;

		public bool IsStart => isStart;

		public SequencePlayer(Node rootNode)
		{
			root = rootNode;
			endCallback = null;
			updateNodes = new List<Node>();
			isStart = false;
		}

		internal void Play(System.Action endCallback = null)
		{
			isStart = true;
			this.endCallback = endCallback;
			root.NodeStart();

			Update();
		}

		internal void Stop(bool ignoreEndCallback = true)
		{
			isStart = false;
			if(ignoreEndCallback)
				endCallback = null;

			int length = updateNodes.Count;
			for(int i = length -1 ; i >= 0 ; i--)
			{
				updateNodes[i].NodeStop();
			}
		}

		internal async void Update()
		{
			do
			{
				int length = updateNodes.Count;
				if(length == 0) break;

				for(int i = length -1 ; i >= 0 ; i--)
				{
					var state = updateNodes[i].NodeUpdate();
					if(state is Node.State.Success or Node.State.Failure)
					{
						updateNodes.RemoveAt(i);
					}
				}
				if(updateNodes.Count == 0) break;
				await Awaitable.NextFrameAsync();
			}
			while(isStart);

			endCallback?.Invoke();
		}

		internal void AddUpdateNode(Node node)
		{
			updateNodes.Add(node);
		}
	}
}
