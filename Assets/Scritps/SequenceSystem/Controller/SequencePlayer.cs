namespace BC.Sequence
{
	public class SequencePlayer
	{
		public Node root;
		private System.Action endCallback;

		public SequencePlayer(Node rootNode)
		{
			root = rootNode;

			if(root != null)
			{
				//root.AwakeParents();
			}
		}

		internal async void Play(System.Action endCallback = null)
		{
			this.endCallback = endCallback;

			root.NodeStart();
		}

		internal async void Stop(bool ignoreEndCallback = true)
		{
			if(ignoreEndCallback)
				endCallback = null;
		}

		internal async void Update()
		{

		}
	}
}
