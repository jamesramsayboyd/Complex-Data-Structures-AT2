using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace AstroMathClient
{
    public partial class AstroMathClient : Form
    {
        // Creating the pipe proxy for the interface as a global variable
        IAstroContract astroPipeProxy;
        public AstroMathClient()
        {
            InitializeComponent();
            ConnectToServer();
        }

        #region BUTTON METHODS
        private void buttonCalculateStarVelocity_Click(object sender, EventArgs e)
        {
            double observedWavelength = Double.Parse(textBoxObservedWavelength.Text);
            double restWavelength = Double.Parse(textBoxRestWavelength.Text);
            textBoxStarVelocity.Text = astroPipeProxy.StarVelocity(observedWavelength, restWavelength).ToString();
        }
        #endregion BUTTON METHODS

        #region UTILITIES
        public void ConnectToServer()
        {
            ChannelFactory<IAstroContract> pipeFactory =
              new ChannelFactory<IAstroContract>(
                new NetNamedPipeBinding(),
                  new EndpointAddress("net.pipe://localhost/PipeReverse"));

            astroPipeProxy = pipeFactory.CreateChannel();
        }
        #endregion UTILITIES
    }
}
