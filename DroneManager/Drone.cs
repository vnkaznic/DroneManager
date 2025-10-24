namespace DroneManager;

public class Drone
{
	public DoublePosition CurrentPosition { get; private set; }

	public delegate void OnChangePosition(string description, DoublePosition position);

	public event OnChangePosition ChangePosition;

	public Drone()
	{
		CurrentPosition = new DoublePosition();
		ChangePosition += (description, position) => { };
	}

	public void GoTo(string description, double x, double y, double z)
	{
		CurrentPosition.X = x; CurrentPosition.Y = y; CurrentPosition.Z = z;

		ChangePosition(description, CurrentPosition);
	}
}