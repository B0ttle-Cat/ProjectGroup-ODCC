namespace BC.Sequence
{
	public static partial class NodeBuilder
	{
		internal static ParallelAllGraphBuilder _ParallelAny(NodeGraph parent)
		{
			var newBuilder = new ParallelAllGraphBuilder(new ParallelAll());
			newBuilder.SetParent(parent);
			return newBuilder;
		}
		public static ParallelAllGraphBuilder ParallelAny()
		{
			return _ParallelAny(null);
		}
		public static ParallelAllGraphBuilder ParallelAny(this NodeGraph parent)
		{
			return _ParallelAny(parent);
		}
		public class ParallelAllGraphBuilder : ModifierGraph
		{
			public ParallelAllGraphBuilder(ParallelAll node) : base(node)
			{
			}
			public ParallelAllGraphBuilder Parallel(NodeGraph nodeBuilder)
			{
				modifierList.Add(nodeBuilder);
				nodeBuilder.SetParent(this);

				return this;
			}
		}
	}
	public class ParallelAll : Modifier
	{
		protected override State OnStart()
		{
			int length = children.Length;
			if(length == 0) return State.Success;


			CurrentState = State.Success;
			for(int i = 0 ; i < length ; i++)
			{
				var nextState = children[i].NodeStart();
				if(nextState == State.Waiting || nextState == State.Running)
				{
					CurrentState = State.Waiting;
				}
				else if(nextState == State.Failure)
				{
					CurrentState = State.Failure;
					break;
				}
			}

			return CurrentState;
		}

		protected override void OnStop()
		{
			int length = children.Length;
			for(int i = 0 ; i < length ; i++)
			{
				children[i].NodeStop();
			}
		}

		protected override State OnUpdate()
		{
			int length = children.Length;
			if(length == 0) return State.Success;

			CurrentState = State.Success;
			for(int i = 0 ; i < length ; i++)
			{
				var nextState = children[i].CurrentState;
				if(nextState == State.Waiting || nextState == State.Running)
				{
					CurrentState = State.Waiting;
				}
				else if(nextState == State.Failure)
				{
					CurrentState = State.Failure;
					break;
				}
			}

			return CurrentState;
		}
	}
}
