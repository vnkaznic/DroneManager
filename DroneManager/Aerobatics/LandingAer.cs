namespace DroneManager.Aerobatics;

public class LandingAer(Drone drone) : BaseAerobatics
{
	public override void Execute()
	{
		drone.GoTo("Посадка", drone.CurrentPosition.X, drone.CurrentPosition.Y, 0);
	}
}
