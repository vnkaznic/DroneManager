namespace DroneManager.Aerobatics;

public class TakeOffAer(Drone drone) : BaseAerobatics
{
	public override void Execute(DoublePosition position)
	{
		drone.GoTo("Взлет", drone.CurrentPosition.X, drone.CurrentPosition.Y, position.Z);
	}
}
