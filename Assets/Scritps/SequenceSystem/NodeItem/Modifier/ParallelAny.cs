namespace BC.Sequence
{
	public static partial class NodeBuilder
	{
		internal static ParallelAnyGraph _ParallelAny(NodeGraph parent, bool stopAnySuccess)
		{
			var newBuilder = new ParallelAnyGraph(new ParallelAny(stopAnySuccess));
			newBuilder.SetParent(parent);
			return newBuilder;
		}
		public static ParallelAnyGraph ParallelAny(bool stopAnySuccess)
		{
			return _ParallelAny(null, stopAnySuccess);
		}
		public static ParallelAnyGraph ParallelAny(this NodeGraph parent, bool stopAnySuccess)
		{
			return _ParallelAny(parent, stopAnySuccess);
		}
		public class ParallelAnyGraph : ModifierGraph
		{
			public ParallelAnyGraph(ParallelAny node) : base(node)
			{
			}
			public ParallelAnyGraph Parallel(NodeGraph nodeBuilder)
			{
				modifierList.Add(nodeBuilder);
				nodeBuilder.SetParent(this);

				return this;
			}
		}
	}
	public class ParallelAny : Modifier
	{
		public bool stopAnySuccess;

		public ParallelAny(bool stopAnySuccess)
		{
			this.stopAnySuccess = stopAnySuccess;
		}

		protected override State OnStart()
		{
			int length = children.Length;
			if(length == 0) return State.Success;

			int failCount = 0;
			for(int i = 0 ; i < length ; i++)
			{
				var nextState = children[i].NodeStart();
				if(nextState == State.Success)
				{
					CurrentState = nextState;
					if(stopAnySuccess)
					{
						break;
					}
				}
				else if(nextState == State.Failure)
				{
					failCount++;
				}
			}

			if(stopAnySuccess)
			{
				for(int i = 0 ; i < length ; i++)
				{
					children[i].NodeStop();
				}
			}
			else if(failCount == length)
			{
				CurrentState = State.Failure;
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

			int failCount = 0;
			for(int i = 0 ; i < length ; i++)
			{
				var nextState = children[i].CurrentState;
				if(nextState == State.Success)
				{
					CurrentState = nextState;
					if(stopAnySuccess)
					{
						break;
					}
				}
				else if(nextState == State.Failure)
				{
					failCount++;
				}
			}

			if(stopAnySuccess)
			{
				for(int i = 0 ; i < length ; i++)
				{
					children[i].NodeStop();
				}
			}
			else if(failCount == length)
			{
				CurrentState = State.Failure;
			}
			return CurrentState;
		}
	}
}
