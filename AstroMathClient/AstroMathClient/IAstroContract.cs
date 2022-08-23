using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace AstroMathClient
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
