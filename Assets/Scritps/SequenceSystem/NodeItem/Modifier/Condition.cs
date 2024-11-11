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
		public static ConditionGraphBuilder Condition(Func<bool> condition)
		{
			return _Condition(null, condition);
		}
		public static ConditionGraphBuilder Condition(this NodeGraph parent, Func<bool> condition)
		{
			return _Condition(parent, condition);
		}

		public class ConditionGraphBuilder : ModifierGraph
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
			public ConditionGraphBuilder True(NodeGraph trueNode)
			{
				this.trueGraph = trueNode;
				trueNode.SetParent(this);
				return this;
			}
			public ConditionGraphBuilder False(NodeGraph falseNode)
			{
				this.falseGraph = falseNode;
				trueGraph.SetParent(this);
				return this;
			}
			public ConditionGraphBuilder ElseIf(Func<bool> condition, NodeGraph falseNode)
			{
				elifCondition.Add(condition);
				modifierList.Add(falseNode);
				falseNode.SetParent(this);
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
				trueNode = conditionGraphBuilder.trueGraph.node;
				falseNode = conditionGraphBuilder.falseGraph.node;
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
