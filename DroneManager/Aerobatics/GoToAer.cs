namespace DroneManager.Aerobatics;

public class GoToAer(Drone drone) : BaseAerobatics
{
	public override void Execute(DoublePosition position)
	{
		drone.GoTo("Перемещение", position.X, position.Y, position.Z);
	}
}