namespace BC.Sequence
{
	public abstract class Modifier : Node
	{
		public Modifier() : base()
		{
			children = new Node[0];
		}
		internal Node[] children;
		internal sealed override void SetChildren(Node[] children)
		{
			this.children = children;
		}

		protected override void OnStop()
		{
			int length = children.Length;
			if(length == 0) return;

			for(int i = 0 ; i < length ; i++)
			{
				children[i].NodeStop();
			}
		}


		protected sealed override void OnNext()
		{
		}
	}
}
