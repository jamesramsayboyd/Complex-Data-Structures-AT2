using System;
using System.ServiceModel;

namespace AstroMath
{
    [ServiceContract]
    public interface IAstroContract
    {
        [OperationContract]
        double StarVelocity(double a, double b);

        [OperationContract]
        double StarDistance(double a);

        [OperationContract]
        double TemperatureInKelvin(double a);

        [OperationContract]
        double EventHorizon(double a);
    }
}