namespace BC.Sequence
{
	public static partial class NodeBuilder
	{
		internal static SequenceGraph _Sequence(NodeGraph parent, string sequenceName)
		{
			var newBuilder = new SequenceGraph(new Sequence(sequenceName));
			newBuilder.SetParent(parent);
			return newBuilder;
		}
		public static SequenceGraph Sequence(string sequenceName)
		{
			return _Sequence(null, sequenceName);
		}
		public static SequenceGraph Sequence(this NodeGraph parent, string sequenceName)
		{
			return _Sequence(parent, sequenceName);
		}
		public class SequenceGraph : ModifierGraph
		{
			public SequenceGraph(Sequence node) : base(node)
			{
			}
			public SequenceGraph Next(NodeGraph nodeBuilder)
			{
				modifierList.Add(nodeBuilder);
				nodeBuilder.SetParent(this);
				return this;
			}
		}
	}
	public class Sequence : Modifier
	{
		private string sequenceName;

		public Sequence(string sequenceName)
		{
			this.sequenceName=sequenceName;
		}

		protected override void OnBuild(NodeGraph nodeBuilder)
		{
			base.OnBuild(nodeBuilder);
		}

		protected override State OnStart()
		{
			int length = children.Length;
			if(length == 0) return State.Success;

			for(int i = 0 ; i < length ; i++)
			{
				var nextState = children[i].NodeStart();
				if(nextState is State.Failure)
				{
					return nextState;
				}
				else if(nextState is not State.Success)
				{
					return State.Waiting;
				}
			}

			return State.Success;
		}

		protected override void OnStop()
		{
			base.OnStop();
		}

		protected override State OnUpdate()
		{
			int length = children.Length;
			if(length == 0) return State.Success;

			for(int i = 0 ; i < length ; i++)
			{
				var nextState = children[i].CurrentState;
				if(nextState is State.Initialized)
				{
					nextState = children[i].NodeStart();
				}

				if(nextState is State.Failure)
				{
					return nextState;
				}
				else if(nextState is not State.Success)
				{
					return State.Waiting;
				}
			}

			return State.Success;
		}
	}
}
