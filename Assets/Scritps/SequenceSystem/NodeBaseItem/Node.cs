using System.Linq;

using UnityEngine;

namespace BC.Sequence
{
	public abstract class Node
	{
		private string tag;
		public string Tag { get => tag; internal set => tag = value; }

		public Node()
		{
			parent = null;

		}

		SequencePlayer player;
		protected Node parent;
		protected Node next;

		internal virtual void SetParent(Node parent)
		{
			this.parent = parent;
		}
		internal virtual void SetNext(Node next)
		{
			this.next = next;
		}
		internal abstract void SetChildren(Node[] children);

		public enum State
		{
			Uninitialized = 0,  // ��尡 �ʱ� ȭ���� �ʾҽ��ϴ�.
			Initialized = 0,    // ��尡 ���۵��� �ʾҽ��ϴ�.
			Running = 2,        // ���� ��尡 ���� ���Դϴ�.
			Waiting = 1,        // ���� ���� ���� ��尡 �Ϸ�� ������ ��ٸ��� �ֽ��ϴ�
			Success = 3,        // ��尡 �����߽��ϴ�.
			Failure = 4,        // ��忡 �����߽��ϴ�.
		}
		public State CurrentState { get; set; }
		private bool isNext;
		internal void NodeInit(SequencePlayer player, NodeGraph nodeGraph, NodeGraph nextGraph)
		{
			this.player = player;
			if(CurrentState is State.Uninitialized)
			{
				try
				{
					OnBuild(nodeGraph);
					SetParent(nodeGraph.node);
					SetNext(nextGraph is null ? null : nextGraph.node);
					SetChildren(nodeGraph.children.Select(n => n.node).ToArray());
					CurrentState = State.Initialized;
				}
				catch(System.Exception ex)
				{
					Debug.LogException(ex);
					CurrentState = State.Uninitialized;
					return;
				}
			}
		}
		internal void NodeRestart()
		{
			if(CurrentState is State.Uninitialized) return;

			CurrentState = State.Initialized;
		}
		internal State NodeStart()
		{
			if(CurrentState is State.Initialized)
			{
				isNext = true;
				try
				{
					CurrentState = State.Running;
					CurrentState = OnStart();
				}
				catch(System.Exception ex)
				{
					Debug.LogException(ex);
					CurrentState = State.Failure;
				}

				if(CurrentState is not (State.Success or State.Failure))
				{
					player.AddUpdateNode(this);
				}
			}
			NodeNext();
			return CurrentState;
		}
		internal State NodeUpdate()
		{
			if(CurrentState is State.Uninitialized or State.Initialized) return CurrentState;
			if(CurrentState is State.Success or State.Failure) return CurrentState;

			try
			{
				CurrentState = OnUpdate();
			}
			catch(System.Exception ex)
			{
				Debug.LogException(ex);
				CurrentState = State.Failure;
			}
			NodeNext();
			return CurrentState;
		}
		internal void NodeStop()
		{
			if(CurrentState is State.Uninitialized or State.Initialized) return;
			OnStop();
			isNext = false;
			CurrentState = State.Success;
		}
		protected void NodeNext()
		{
			if(isNext && CurrentState is State.Success)
			{
				isNext = false;
				if(next is not null) OnNext();
			}
		}

		protected virtual void OnBuild(NodeGraph nodeBuilder)
		{

		}
		protected virtual State OnStart()
		{
			return CurrentState;
		}
		protected virtual State OnUpdate()
		{
			return CurrentState;
		}
		protected virtual void OnStop()
		{

		}
		protected virtual void OnNext()
		{
			next.NodeStart();
		}
	}
}
