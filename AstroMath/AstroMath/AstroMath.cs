using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroMath
{
    /// <summary>
    /// A DLL containing four methods to perform various astronomical calculations
    /// </summary>
    public class AstroMath
    {
        /// <summary>
        /// A method to measure the velocity of a star using its Doppler shift
        /// Change in Wavelength = Observed Wavelength - Rest Wavelength
        /// Speed of Light (c) = 299792458 m/s
        /// v = velocity (m/s)
        /// Formula: v = c * (Change in Wavelength / Rest Wavelength)
        /// </summary>
        /// <param name="ObservedWavelength">A double representing the observed wavelength of the star</param>
        /// <param name="RestWavelength">A double representing the rest wavelength of the star</param>
        /// <returns>A double representing the velocity of the star (in metres per second)</returns>
        public static double StarVelocity(double ObservedWavelength, double RestWavelength)
        {
            double ChangeInWavelength = ObservedWavelength - RestWavelength;
            double C = 299792458;
            double V = C * (ChangeInWavelength / RestWavelength);
            return V;
        }

        /// <summary>
        /// A method to measure the distance of a star using the parallax angle from two measuring points in parsecs
        /// Parallax Angle (P) in arcseconds (1/3600 of an arc)
        /// Distance (D) in parsecs (1 parsec = 3.0857 x 10^16m)
        /// Formula: D = 1 / P
        /// </summary>
        /// <param name="P">A double representing the parallax angle (in arcseconds)</param>
        /// <returns>A double representing the distance of the star from the measuring points (in parsecs)</returns>
        public static double StarDistance(double P)
        {
            double D = 1 / P;
            return D;
        }

        /// <summary>
        /// A method to convert a given temperature in degrees Celsius into Kelvin
        /// Temperature in Celsius (C) in degrees
        /// Temperature in Kelvin (K)
        /// Formula: K = C + 273
        /// (Temperatures below -273 are considered invalid and will be set to -273)
        /// </summary>
        /// <param name="C">The temperature to be converted (in degrees Celsius)</param>
        /// <returns>The equivalent temperature in Kelvin</returns>
        public static double TemperatureInKelvin(double C)
        {
            if (C < -273)
            {
                C = 273;
            }
            double K = C + 273;
            return K;
        }

        /// <summary>
        /// A method that will return the Schwarzschild radius of a blackhole, i.e.
        /// the distance from the centre of the blackhole to the event horizon, in meters
        /// Gravity Constant (G) = 6.674 x 10^-11 m^3/kg^-1/s^-2
        /// Speed of Light (C) = 299792458 m/s
        /// Mass of Blackhole (M) (in kg)
        /// Schwarzschild Radius (R) (in m)
        /// Formula: R = (2GM)/C^2
        /// </summary>
        /// <param name="M">The mass of the blackhole (in kg)</param>
        /// <returns>The Schwarzschild radius (in meters)</returns>
        public static double EventHorizon(double M)
        {
            double G = 6.674 * Math.Pow(10, -11);
            double C = 299792458;
            double R = (2 * G * M) / Math.Pow(C, 2);
            return R;
        }
    }
}
