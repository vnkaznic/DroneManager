using DroneManager.Aerobatics;

namespace DroneManager;

public class Control
{
	private Dictionary<EnumAer, BaseAerobatics> dictAer = new();

	public Control(Drone drone)
	{
		RegistrationAer(EnumAer.GoTo, new GoToAer(drone));
		RegistrationAer(EnumAer.TakeOff, new TakeOffAer(drone));
		RegistrationAer(EnumAer.Landing, new LandingAer(drone));
	}

	private void RegistrationAer(EnumAer typeAer, BaseAerobatics aerobatics)
	{
		dictAer.TryAdd(typeAer, aerobatics);
	}

	public void Aerobatics(EnumAer typeAer, DoublePosition position)
	{
		if (dictAer.TryGetValue(typeAer, out var aer))
			aer.Execute(position);
	}
}
