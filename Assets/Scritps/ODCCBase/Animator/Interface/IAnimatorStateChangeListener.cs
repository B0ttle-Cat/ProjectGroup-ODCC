using BC.ODCC;

using static BC.OdccBase.AnimatorComponent;

namespace BC.OdccBase
{
	public interface IAnimatorStateChangeListener : IOdccComponent
	{
		public State CurrentAnimatorState { get; set; }
		public void OnAnimatorStateEnter(State state);
		public void OnAnimatorStateExit(State state);
	}
}
