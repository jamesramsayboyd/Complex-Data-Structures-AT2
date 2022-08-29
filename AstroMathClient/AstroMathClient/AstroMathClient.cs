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
        public AstroMathClient()
        {
            InitializeComponent();
            ConnectToServer();
            //ResetToDefault();
        }
        // Creating the pipe proxy for the interface as a global variable
        IAstroContract astroPipeProxy;
        //ListViewItem lvi = new ListViewItem();

        #region BUTTON METHODS
        public void DisplayResult(int column)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.SubItems.Add("");
            lvi.SubItems.Add("");
        }
        private void buttonCalculateStarVelocity_Click(object sender, EventArgs e)
        {
            double observedWavelength = double.Parse(textBoxObservedWavelength.Text);
            double restWavelength = double.Parse(textBoxRestWavelength.Text);
            double starVelocity = astroPipeProxy.StarVelocity(observedWavelength, restWavelength);
            textBoxStarVelocity.Text = starVelocity.ToString();
            ListViewItem lvi = new ListViewItem(starVelocity.ToString());
            listViewOutput.Items.Insert(0, lvi);
        }

        private void buttonCalculateStarDistance_Click(object sender, EventArgs e)
        {
            double parallaxAngle = double.Parse(textBoxParallaxAngle.Text);
            double starDistance = astroPipeProxy.StarDistance(parallaxAngle);
            textBoxStarDistance.Text = starDistance.ToString();
            ListViewItem lvi = new ListViewItem();
            lvi.SubItems.Add(starDistance.ToString());
            listViewOutput.Items.Insert(0, lvi);
        }

        private void buttonConvertTemperature_Click(object sender, EventArgs e)
        {
            double temperatureInCelsius = double.Parse(textBoxCelsius.Text);
            if (temperatureInCelsius >= -273)
            {
                double temperatureInKelvin = astroPipeProxy.TemperatureInKelvin(temperatureInCelsius);
                textBoxKelvin.Text = temperatureInKelvin.ToString();
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add("");
                lvi.SubItems.Add(temperatureInKelvin.ToString());
                listViewOutput.Items.Insert(0, lvi);
            }
            else
            {
                //TODO: Error message "Enter a temp above -273"
                textBoxKelvin.Text = "Error";
            }            
        }

        private void buttonCalculateEventHorizon_Click(object sender, EventArgs e)
        {
            double baseNo = double.Parse(textBoxSchwarzschild.Text);
            double exponentNo = double.Parse(textBoxExponent.Text);
            double schwarzschildRadius = Math.Pow(baseNo, exponentNo);
            double eventHorizon = astroPipeProxy.EventHorizon(schwarzschildRadius);
            textBoxEventHorizon.Text = eventHorizon.ToString();
            ListViewItem lvi = new ListViewItem();
            lvi.SubItems.Add("");
            lvi.SubItems.Add("");
            lvi.SubItems.Add(eventHorizon.ToString());
            listViewOutput.Items.Insert(0, lvi);
            // TODO: Format result to display as exponent
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

        public void ClearAllTextBoxes()
        {
            textBoxObservedWavelength.Clear();
            textBoxRestWavelength.Clear();
            textBoxStarVelocity.Clear();
            textBoxParallaxAngle.Clear();
            textBoxStarDistance.Clear();
            textBoxCelsius.Clear();
            textBoxKelvin.Clear();
            textBoxSchwarzschild.Clear();
            textBoxEventHorizon.Clear();
        }

        public void ResetToDefault()
        {
            ClearAllTextBoxes();
            DayMode();
            SetLanguageToEnglish();
        }
        #endregion UTILITIES

        #region USER MESSAGING
        private void ErrorMessage(int errorCode)
        {
            switch (errorCode)
            {
                case 0: 
                    toolStripStatus.Text = "test";
                    break;
                default:
                    break;
            }
        }

        private void ToolTips()
        {

        }
        #endregion USER MESSAGING

        #region FILE MENU
        private void menuStripFileClearTextboxes_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes();
        }
        private void resetToDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetToDefault();
        }
        private void menuStripFileExit_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
        #endregion FILE MENU

        #region CUSTOMISATION MENU
        private void ChangeBackColours(Color colour)
        {
            menuStripCustomisationDay.Enabled = true;
            menuStripCustomisationNight.Enabled = true;
            menuStripCustomisationCustom.Enabled = true;
            ActiveForm.BackColor = colour;
            buttonCalculateStarVelocity.BackColor = colour;
            buttonCalculateStarDistance.BackColor = colour;
            buttonConvertTemperature.BackColor = colour;
            buttonCalculateEventHorizon.BackColor = colour;
            mainMenuStrip.BackColor = colour;
            menuStripFile.DropDown.BackColor = colour;
            menuStripCustomisation.BackColor = colour;
            menuStripCustomisation.DropDown.BackColor = colour;
            menuStripLanguage.BackColor = colour;
            menuStripLanguage.DropDown.BackColor = colour;
            statusStrip.BackColor = colour;
            listViewOutput.BackColor = colour;
            //toolStripStatus.BackColor = colour;
        }

        private void ChangeForeColours(Color colour)
        {
            ActiveForm.ForeColor = colour;
            buttonCalculateStarVelocity.ForeColor = colour;
            buttonCalculateStarDistance.ForeColor = colour;
            buttonConvertTemperature.ForeColor = colour;
            buttonCalculateEventHorizon.ForeColor = colour;
            mainMenuStrip.ForeColor = colour;
            menuStripFile.DropDown.ForeColor = colour;
            menuStripCustomisation.DropDown.ForeColor = colour;
            menuStripLanguage.DropDown.ForeColor = colour;
            statusStrip.ForeColor = colour;
            listViewOutput.ForeColor = colour;
            //toolStripStatus.ForeColor = colour;
        }
        private void DayMode()
        {
            ChangeBackColours(Color.White);
            ChangeForeColours(Color.Black);
        }

        private void NightMode()
        {
            ChangeBackColours(Color.Black);
            ChangeForeColours(Color.White);
        }

        private void CustomTheme()
        {
            // TODO: Implement colour picker menu
            Color customBackColour = Color.White;
            Color customForeColour = Color.Black;
            ChangeBackColours(customBackColour);
            ChangeForeColours(customForeColour);
        }

        private void menuStripCustomisationDay_Click(object sender, EventArgs e)
        {
            DayMode();
            menuStripCustomisationDay.Enabled = false;
        }

        private void menuStripCustomisationNight_Click(object sender, EventArgs e)
        {
            NightMode();
            menuStripCustomisationNight.Enabled = false;
        }

        private void menuStripCustomisationCustom_Click(object sender, EventArgs e)
        {
            CustomTheme();
            menuStripCustomisationCustom.Enabled = false;
        }
        #endregion CUSTOMISATION MENU

        #region LANGUAGE MENU
        public void SetLanguageToEnglish()
        {
            labelStarVelocity.Text = "STAR VELOCITY";
            labelStarDistance.Text = "STAR DISTANCE";
            labelTemperature.Text = "TEMPERATURE IN KELVIN";
            labelEventHorizon.Text = "EVENT HORIZON";
            buttonCalculateStarVelocity.Text = "CALCULATE";
            buttonCalculateStarDistance.Text = "CALCULATE";
            buttonConvertTemperature.Text = "CONVERT";
            buttonCalculateEventHorizon.Text = "CALCULATE";
            menuStripFile.Text = "File";
            menuStripFileClearTextboxes.Text = "Clear Textboxes";
            menuStripFileResetToDefault.Text = "Reset to Default";
            menuStripFileExit.Text = "Exit";
            menuStripCustomisation.Text = "Customisation";
            menuStripCustomisationDay.Text = "Day Mode";
            menuStripCustomisationNight.Text = "Night Mode";
            menuStripCustomisationCustom.Text = "Custom Theme";
            menuStripLanguage.Text = "Language";
            menuStripLanguageEnglish.Text = "English";
            menuStripLanguageFrench.Text = "French";
            menuStripLanguageGerman.Text = "German";
        }

        public void SetLanguageToFrench()
        {

        }
        public void SetLanguageToGerman()
        {

        }
        #endregion LANGUAGE MENU
    }
}
