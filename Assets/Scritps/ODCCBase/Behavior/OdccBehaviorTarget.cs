using BC.ODCC;

using Unity.Behavior;

using UnityEngine;

namespace BC.OdccBase
{
	public abstract class OdccBehaviorTarget : ComponentBehaviour
	{
		internal async Awaitable<Node.Status> _onActionUpdate()
		{
			try
			{
				if(OnActionValid())
				{
					await OnActionUpdate();
					return Node.Status.Success;
				}
				else
				{
					return Node.Status.Failure;
				}
			}
			catch(System.Exception ex)
			{
				Debug.LogException(ex);
				return Node.Status.Interrupted;
			}
		}
		internal void _onEndBehavior()
		{
			try
			{
				OnActionEnd();
			}
			catch(System.Exception ex)
			{
				Debug.LogException(ex);
			}
		}

		protected abstract bool OnActionValid();
		protected abstract Awaitable OnActionUpdate();
		protected abstract void OnActionEnd();
	}
}
