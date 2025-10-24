using DroneManager;
using DroneManager.Aerobatics;

Console.WriteLine("Hello, drone!");

var drone = new Drone();
drone.ChangePosition += (description, position) => { 
	Console.WriteLine($"{description} {position.X} {position.Y} {position.Z}"); 
};

var control = new Control();
control.Aerobatics(new TakeOffAer(drone, 1000));
control.Aerobatics(new GoToAer(drone, new DoublePosition() { X = 10, Y = 10, Z = 1000 }));
control.Aerobatics(new LandingAer(drone));

Console.ReadLine();