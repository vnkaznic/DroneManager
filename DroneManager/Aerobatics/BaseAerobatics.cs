namespace DroneManager.Aerobatics;

public abstract class BaseAerobatics
{
	public delegate string AerobaticsStatus();

	public string Name {get; set;} = string.Empty;

	public abstract void Execute(DoublePosition position);
}