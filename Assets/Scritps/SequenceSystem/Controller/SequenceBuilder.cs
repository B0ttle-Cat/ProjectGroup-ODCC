using System.Collections.Generic;

using UnityEngine;

namespace BC.Sequence
{
	public class SequenceBuilder
	{
		public static NodeGraph Create(string sequenceName)
		{
			var newBuilder = NodeBuilder.Sequence(null, sequenceName);
			if(newBuilder == null)
			{
				Debug.LogError("newBuilder Is Null");
			}
			return newBuilder as NodeGraph;
		}

		public static SequencePlayer Build(NodeGraph nodeGraph)
		{
			if(nodeGraph == null) return new SequencePlayer(null);
			var root = nodeGraph.Return();

			var player =  new SequencePlayer(root.node);

			Init(root, null);
			void Init(NodeGraph initNode, NodeGraph nextNode)
			{
				initNode.Build(player, nextNode);
				int length = initNode.children.Count;
				for(int i = 0 ; i < length ; i++)
				{
					if(initNode is ModifierGraph)
					{
						var node = initNode.children[i];
						Init(node, null);
					}
					else
					{
						var node = initNode.children[i];
						var next = i + 1 < length ? initNode.children[i + 1] : null;
						Init(node, next);
					}
				}
			}

			return player;
		}
	}

	public interface INodeGraph
	{
		public void SetParent(NodeGraph _parent);
		public NodeGraph Break();
		public NodeGraph Return();
	}
	public class NodeGraph : INodeGraph
	{
		internal Node node;
		internal NodeGraph parent;
		internal List<NodeGraph> children;
		public NodeGraph(Node node)
		{
			parent = null;
			children = new List<NodeGraph>();
			this.node = node;
		}

		public void SetParent(NodeGraph _parent)
		{
			if(parent != null)
			{
				parent.children.Remove(this);
			}

			parent=_parent;

			if(parent != null)
			{
				parent.children.Add(this);
			}
		}

		public NodeGraph Break()
		{
			return parent ?? this;
		}
		public NodeGraph Return()
		{
			if(parent == null || parent == this)
			{
				return this;
			}
			else
			{
				return parent.Return();
			}
		}


		internal void Build(SequencePlayer player, NodeGraph nextGraph)
		{
			node?.NodeInit(player, this, nextGraph);
		}
	}
	public class ModifierGraph : NodeGraph
	{
		protected List<NodeGraph> modifierList = new List<NodeGraph>();

		public ModifierGraph(Node node) : base(node)
		{
			modifierList = new List<NodeGraph>();
		}
	}
}
