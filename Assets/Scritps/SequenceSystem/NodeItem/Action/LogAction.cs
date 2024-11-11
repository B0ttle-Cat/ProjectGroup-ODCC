using UnityEngine;

namespace BC.Sequence
{
	public static partial class NodeBuilder
	{
		internal static NodeGraph _Logger(NodeGraph parent, string log)
		{
			var newBuilder = new NodeGraph(new LogAction(log));
			newBuilder.SetParent(parent);
			return newBuilder;
		}
		public static NodeGraph Logger(string log)
		{
			return _Logger(null, log);
		}
		public static NodeGraph Logger(this NodeGraph parent, string log)
		{
			_Logger(parent, log);
			return parent;
		}
	}
	public class LogAction : Action
	{
		public string log;

		public LogAction(string log)
		{
			this.log=log;
		}

		protected override State OnStart()
		{
			if(string.IsNullOrWhiteSpace(Tag))
				Debug.Log($"{log}");
			else
				Debug.Log($"[{Tag}] {log}");

			return State.Success;
		}
	}
}
