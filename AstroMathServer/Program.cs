using System;
using System.ServiceModel;

namespace AstroMath
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(AstroServer),
                new Uri[]{
                    new Uri("net.pipe://localhost")
                }))
            {     
                host.AddServiceEndpoint(typeof(IAstroContract), new NetNamedPipeBinding(), "PipeReverse");
                host.Open();
                Console.WriteLine("Service is available. " + "Press <ENTER> to exit.");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
