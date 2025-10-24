namespace DroneManager.Aerobatics;

public class TakeOffAer(Drone drone, double maxZ) : BaseAerobatics
{
	public override void Execute()
	{
		drone.GoTo("Взлет", drone.CurrentPosition.X, drone.CurrentPosition.Y, maxZ);
	}
}
