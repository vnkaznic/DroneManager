namespace DroneManager.Aerobatics;

public class LandingAer(Drone drone) : BaseAerobatics
{
	public override void Execute(DoublePosition position)
	{
		drone.GoTo("Посадка", drone.CurrentPosition.X, drone.CurrentPosition.Y, position.Z);
	}
}
