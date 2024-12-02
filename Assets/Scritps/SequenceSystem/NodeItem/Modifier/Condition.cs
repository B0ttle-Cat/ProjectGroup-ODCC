using System;
using System.Collections.Generic;

namespace BC.Sequence
{
	public static partial class NodeBuilder
	{
		internal static ConditionGraphBuilder _Condition(NodeGraph parent, Func<bool> condition)
		{
			var builder = new ConditionGraphBuilder(new Condition(condition));
			builder.SetParent(parent);
			return builder;
		}
		public static IConditionNodeGraph Condition(Func<bool> condition)
		{
			return _Condition(null, condition);
		}
		public static IConditionNodeGraph Condition(this NodeGraph parent, Func<bool> condition)
		{
			return _Condition(parent, condition);
		}

		public interface IConditionNodeGraph : INodeGraph
		{
			public IConditionNodeGraph True(NodeGraph trueNode);
			public IConditionNodeGraph True(Func<NodeGraph, NodeGraph> trueNode);
			public IConditionNodeGraph False(NodeGraph falseNode);
			public IConditionNodeGraph False(Func<NodeGraph, NodeGraph> falseNode);
			public IConditionNodeGraph ElseIf(Func<bool> condition, NodeGraph falseNode);
			public IConditionNodeGraph ElseIf(Func<bool> condition, Func<NodeGraph, NodeGraph> falseNode);
		}
		public class ConditionGraphBuilder : ModifierGraph, IConditionNodeGraph
		{
			internal NodeGraph trueGraph;
			internal NodeGraph falseGraph;

			internal List<Func<bool>> elifCondition;

			public ConditionGraphBuilder(Condition node) : base(node)
			{
				trueGraph = null;
				falseGraph = null;
				elifCondition = new List<Func<bool>>();
			}
			public IConditionNodeGraph True(NodeGraph trueNode)
			{
				this.trueGraph = trueNode;
				this.trueGraph.SetParent(this);
				return this;
			}
			public IConditionNodeGraph True(Func<NodeGraph, NodeGraph> trueNode)
			{
				this.trueGraph = trueNode(this);
				return this;
			}
			public IConditionNodeGraph False(NodeGraph falseNode)
			{
				this.falseGraph = falseNode;
				this.trueGraph.SetParent(this);
				return this;
			}
			public IConditionNodeGraph False(Func<NodeGraph, NodeGraph> falseNode)
			{
				this.trueGraph = falseNode(this);
				return this;
			}
			public IConditionNodeGraph ElseIf(Func<bool> condition, NodeGraph falseNode)
			{
				elifCondition.Add(condition);
				modifierList.Add(falseNode);
				return this;
			}
			public IConditionNodeGraph ElseIf(Func<bool> condition, Func<NodeGraph, NodeGraph> falseNode)
			{
				this.trueGraph = falseNode(this);
				return this;
			}
		}
	}
	public class Condition : Modifier
	{
		private Func<bool> condition;
		private Node trueNode;
		private Node falseNode;

		internal List<Func<bool>> elifCondition;

		private Node conditionTargetNode;

		public Condition(Func<bool> condition)
		{
			this.condition=condition;
			conditionTargetNode = null;
		}

		protected override void OnBuild(NodeGraph nodeBuilder)
		{
			if(nodeBuilder is NodeBuilder.ConditionGraphBuilder conditionGraphBuilder)
			{
				trueNode = conditionGraphBuilder.trueGraph?.node;
				falseNode = conditionGraphBuilder.falseGraph?.node;
				elifCondition = conditionGraphBuilder.elifCondition;
			}
		}

		protected override State OnStart()
		{
			if(condition == null) return State.Failure;

			bool result = condition.Invoke();
			if(result)
			{
				conditionTargetNode = trueNode;
			}
			else if(ElifCondition(out var elifNode))
			{
				conditionTargetNode = elifNode;
			}
			else
			{
				conditionTargetNode = falseNode;
			}

			if(conditionTargetNode == null) return State.Success;
			return conditionTargetNode.NodeStart();

			bool ElifCondition(out Node elifNode)
			{
				elifNode = null;
				if(elifCondition != null)
				{
					int length = elifCondition.Count;
					for(int i = 0 ; i < length ; i++)
					{
						if(elifCondition[i].Invoke())
						{
							elifNode =  children[i];
							break;
						}
					}
				}
				return elifNode != null;
			}
		}
		protected override void OnStop()
		{
			base.OnStop();
		}

		protected override State OnUpdate()
		{
			return CurrentState;
		}
	}
}
