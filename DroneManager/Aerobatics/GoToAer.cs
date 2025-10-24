namespace DroneManager.Aerobatics;

public class GoToAer(Drone drone, DoublePosition position) : BaseAerobatics
{
	public override void Execute()
	{
		drone.GoTo("Перемещение", position.X, position.Y, position.Z);
	}
}