using System;
using System.ServiceModel;

namespace AstroMath
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("### AstroMath Client Started ###");

            ChannelFactory<IAstroContract> pipeFactory =
              new ChannelFactory<IAstroContract>(
                new NetNamedPipeBinding(),
                  new EndpointAddress("net.pipe://localhost/PipeReverse"));

            IAstroContract astroPipeProxy = pipeFactory.CreateChannel();

            while (true)
            {
                Console.WriteLine("### Star Velocity ###");
                Console.WriteLine("Observed Wavelength: ");
                double ObservedWavelength = Double.Parse(Console.ReadLine());
                Console.WriteLine("Rest Wavelength: ");
                double RestWavelength = Double.Parse(Console.ReadLine());
                Console.WriteLine("Star Velocity = " + astroPipeProxy.StarVelocity(ObservedWavelength, RestWavelength) + " m/s");
                Console.WriteLine();
                Console.WriteLine("### Star Distance ###");
                Console.WriteLine("Parallax Angle: ");
                double P = Double.Parse(Console.ReadLine());
                Console.WriteLine("Star Distance = " + astroPipeProxy.StarDistance(P) + " parsecs");
                Console.WriteLine();
                Console.WriteLine("### Celsius/Kelvin Conversion ###");
                Console.WriteLine("Temperature in Celsius: ");
                double C = Double.Parse(Console.ReadLine());
                Console.WriteLine("Temperature in Kelvin = " + astroPipeProxy.TemperatureInKelvin(C) + "K");
                Console.WriteLine();
                Console.WriteLine("### Event Horizon ###");
                Console.WriteLine("Schwarzschild Radius: ");
                double R = Double.Parse(Console.ReadLine());
                Console.WriteLine("Event Horizon = " + astroPipeProxy.EventHorizon(R) + "m");
                Console.WriteLine();
            }
        }
    }
}