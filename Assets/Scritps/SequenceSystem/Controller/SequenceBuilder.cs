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
			return newBuilder;
		}

		public static SequencePlayer Build(NodeGraph nodeGraph)
		{
			if(nodeGraph == null) return new SequencePlayer(null);
			var root = nodeGraph.Return();

			Init(root, null);
			void Init(NodeGraph initNode, NodeGraph nextNode)
			{
				initNode.Build(nextNode);
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


			var player =  new SequencePlayer(root.node);
			return player;
		}
	}

	public class NodeGraph
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

		internal void SetParent(NodeGraph _parent)
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
			if(parent == null)
			{
				return this;
			}
			else
			{
				return parent.Return();
			}
		}


		internal void Build(NodeGraph nextGraph)
		{
			node?.NodeInit(this, nextGraph);
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
