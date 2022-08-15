// See https://aka.ms/new-console-template for more information
using AstroMath;

Console.WriteLine("Testing AstroMath.dll");
Console.WriteLine("Star Velocity: " + AstroMath.AstroMath.StarVelocity(500.1, 500.0));
Console.WriteLine("Star Distance: " + AstroMath.AstroMath.StarDistance(0.547));
Console.WriteLine("Temperature in Kelvin: " + AstroMath.AstroMath.TemperatureInKelvin(27));
Console.WriteLine("Event Horizon: " + AstroMath.AstroMath.EventHorizon(8.2 * Math.Pow(10,36)));