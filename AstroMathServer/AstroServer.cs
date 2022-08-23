using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AstroMath;

namespace AstroMath
{
    public class AstroServer : IAstroContract
    {
        AstroMath astro = new AstroMath();

        double IAstroContract.StarVelocity(double a, double b)
        {
            return astro.StarVelocity(a, b);
        }

        double IAstroContract.StarDistance(double a)
        {
            return astro.StarDistance(a);
        }

        double IAstroContract.TemperatureInKelvin(double a)
        {
            return astro.TemperatureInKelvin(a);
        }

        double IAstroContract.EventHorizon(double a)
        {
            return astro.EventHorizon(a);
        }
    }
}
