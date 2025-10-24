using DroneManager;
using DroneManager.Aerobatics;

Console.WriteLine("Hello, drone!");

var drone = new Drone();
drone.ChangePosition += (description, position) => { 
	Console.WriteLine($"{description} {position.X} {position.Y} {position.Z}"); 
};

var control = new Control(drone);
control.Aerobatics(EnumAer.TakeOff, new DoublePosition() { Z = 1000 });
control.Aerobatics(EnumAer.GoTo, new DoublePosition() { X = 10, Y = 10, Z = 1000 });
control.Aerobatics(EnumAer.Landing, new DoublePosition() { Z = 0 });

Console.ReadLine();