namespace BC.ODCC
{
	public interface IOdccItem
	{
	}

	public interface IOdccObject : IOdccItem
	{
		public ContainerObject ThisContainer { get; }
	}

	public interface IOdccComponent : IOdccItem
	{
		public ContainerObject ThisContainer { get; }
	}

	public interface IOdccData : IOdccItem
	{
	}
}