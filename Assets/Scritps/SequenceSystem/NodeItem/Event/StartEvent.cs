namespace BC.Sequence
{
	public static partial class NodeBuilder
	{
		public static NodeGraph StartEvent(NodeGraph parent, string eventName)
		{
			var newBuilder = new NodeGraph(new StartEvent(eventName));
			newBuilder.SetParent(parent);
			return newBuilder;
		}
		public static NodeGraph StartEvent(string log)
		{
			return StartEvent(null, log);
		}
		public static NodeGraph Event_StartEvent(this NodeGraph parent, string log)
		{
			return StartEvent(parent, log);
		}
	}

	public class StartEvent : Event
	{
		public StartEvent(string eventName)
		{
			this.eventName=eventName;
		}

		protected override State OnStart()
		{
			return State.Success;
		}
	}
}
