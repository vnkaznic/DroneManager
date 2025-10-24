using DroneManager.Aerobatics;

namespace DroneManager;

public class Control
{
	public void Aerobatics(BaseAerobatics aerobatics)
	{
		aerobatics.Execute();
	}
}
