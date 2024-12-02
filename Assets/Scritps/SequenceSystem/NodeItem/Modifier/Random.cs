namespace BC.Sequence
{
	public static partial class NodeBuilder
	{
		internal static RandomGraphBuilder _Random(NodeGraph parent)
		{
			var newBuilder = new RandomGraphBuilder(new Random());
			newBuilder.SetParent(parent);
			return newBuilder;
		}
		public static IRandomNodeGraph Random()
		{
			return _Random(null);
		}
		public static IRandomNodeGraph Random(this NodeGraph parent)
		{
			return _Random(parent);
		}
		public interface IRandomNodeGraph : INodeGraph
		{
			public IRandomNodeGraph Item(NodeGraph itemNode);
		}
		public class RandomGraphBuilder : ModifierGraph, IRandomNodeGraph
		{
			public RandomGraphBuilder(Random node) : base(node)
			{
			}

			public IRandomNodeGraph Item(NodeGraph itemNode)
			{
				modifierList.Add(itemNode);
				itemNode.SetParent(this);
				return this;
			}
		}
	}
	public class Random : Modifier
	{
		Node nextNode;

		protected override State OnStart()
		{
			int count = children.Length;
			if(count == 0) return State.Success;

			nextNode = children[UnityEngine.Random.Range(0, count)];
			nextNode.NodeStart();

			return NextState();
		}
		protected override State OnUpdate()
		{
			return NextState();
		}
		protected override void OnStop()
		{
			nextNode = null;
		}

		private State NextState()
		{
			if(nextNode == null) return State.Failure;

			var nextState = nextNode.CurrentState;

			if(nextState == State.Success || nextState == State.Failure)
				return nextState;

			if(nextState == State.Running || nextState == State.Waiting)
				return State.Waiting;

			return CurrentState;
		}
	}
}
