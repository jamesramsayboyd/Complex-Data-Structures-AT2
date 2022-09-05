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
using System.Threading;

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
        // Global variables for pipe proxy, language and theme
        IAstroContract astroPipeProxy;
        string systemLanguage = "English";
        string systemTheme = "Day";
        Color customBackColour = Color.White;
        Color customForeColour = Color.Black;

        #region BUTTON METHODS
        private void buttonCalculateStarVelocity_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxObservedWavelength.Text) &&
                !string.IsNullOrEmpty(textBoxRestWavelength.Text))
            {
                double observedWavelength = double.Parse(textBoxObservedWavelength.Text);
                double restWavelength = double.Parse(textBoxRestWavelength.Text);
                double starVelocity = astroPipeProxy.StarVelocity(observedWavelength, restWavelength);
                DisplayCalculationResult(starVelocity.ToString(), "", "", "");
                UserMessage(0);
            }
            else
            {
                UserMessage(1);
            }
        }

        private void buttonCalculateStarDistance_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxParallaxAngle.Text))
            {
                double parallaxAngle = double.Parse(textBoxParallaxAngle.Text);
                double starDistance = astroPipeProxy.StarDistance(parallaxAngle);
                DisplayCalculationResult("", starDistance.ToString(), "", "");
                UserMessage(0);
            }
            else
            {
                UserMessage(2);
            }
        }

        private void buttonConvertTemperature_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxCelsius.Text))
            {
                double temperatureInCelsius = double.Parse(textBoxCelsius.Text);
                if (temperatureInCelsius >= -273)
                {
                    double temperatureInKelvin = astroPipeProxy.TemperatureInKelvin(temperatureInCelsius);
                    DisplayCalculationResult("", "", temperatureInKelvin.ToString(), "");
                    UserMessage(0);
                }
                else
                {
                    UserMessage(3);
                }
            }
            else
            {
                UserMessage(4);
            }
        }

        private void buttonCalculateEventHorizon_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSchwarzschild.Text) &&
                !string.IsNullOrEmpty(textBoxExponent.Text))
            {
                double baseNo = double.Parse(textBoxSchwarzschild.Text);
                double exponentNo = double.Parse(textBoxExponent.Text);
                double schwarzschildRadius = baseNo * Math.Pow(10, exponentNo);
                double eventHorizon = astroPipeProxy.EventHorizon(schwarzschildRadius);
                DisplayCalculationResult("", "", "", eventHorizon.ToString());
                UserMessage(0);
            }
            else
            {
                UserMessage(5);
            }
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
            textBoxParallaxAngle.Clear();
            textBoxCelsius.Clear();
            textBoxSchwarzschild.Clear();
            textBoxExponent.Clear();
            listViewOutput.Items.Clear();
        }

        public void ResetToDefault()
        {
            ClearAllTextBoxes();
            ChangeTheme("Day");
            SetLanguage("English");
        }

        public void DisplayCalculationResult(string a, string b, string c, string d)
        {
            ListViewItem lvi = new ListViewItem(a);
            lvi.SubItems.Add(b);
            lvi.SubItems.Add(c);
            lvi.SubItems.Add(d);
            listViewOutput.Items.Insert(0, lvi);
        }
        #endregion UTILITIES

        #region USER MESSAGING
        private void UserMessage(int errorCode)
        {
            switch (systemLanguage)
            {
                case "English":
                    switch (errorCode)
                    {
                        case 0:
                            toolStripStatus.Text = "";
                            break;
                        case 1:
                            toolStripStatus.Text = "Please enter wavelength values";
                            break;
                        case 2:
                            toolStripStatus.Text = "Please enter parallax angle";
                            break;
                        case 3:
                            toolStripStatus.Text = "Please enter a temperature above -273 degrees";
                            break;
                        case 4:
                            toolStripStatus.Text = "Please enter temperature";
                            break;
                        case 5:
                            toolStripStatus.Text = "Please enter Schwarzschild radius";
                            break;
                        default:
                            break;
                    }
                    break;
                case "French":
                    switch (errorCode)
                    {
                        case 0:
                            toolStripStatus.Text = "";
                            break;
                        case 1:
                            toolStripStatus.Text = "Veuillez entrer les valeurs de longueur d'onde";
                            break;
                        case 2:
                            toolStripStatus.Text = "Veuillez entrer l'angle de parallaxe";
                            break;
                        case 3:
                            toolStripStatus.Text = "Veuillez saisir une température supérieure à -273 degrés";
                            break;
                        case 4:
                            toolStripStatus.Text = "Veuillez saisir une température";
                            break;
                        case 5:
                            toolStripStatus.Text = "Veuillez entrer le rayon de Schwarzschild";
                            break;
                        default:
                            break;
                    }
                    break;
                case "German":
                    switch (errorCode)
                    {
                        case 0:
                            toolStripStatus.Text = "";
                            break;
                        case 1:
                            toolStripStatus.Text = "Bitte geben Sie Wellenlängenwerte ein";
                            break;
                        case 2:
                            toolStripStatus.Text = "Bitte geben Sie den Parallaxenwinkel ein";
                            break;
                        case 3:
                            toolStripStatus.Text = "Bitte geben Sie eine Temperatur über -273 Grad ein";
                            break;
                        case 4:
                            toolStripStatus.Text = "Bitte geben Sie die Temperatur ein";
                            break;
                        case 5:
                            toolStripStatus.Text = "Bitte geben Sie den Schwarzschild-Radius ein";
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
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
        }

        private void CustomTheme()
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog(Owner);
            customBackColour = colorDialog.Color;
            //customForeColour = colorDialog.Color;
        }

        private void ChangeTheme(string theme)
        {
            switch (theme)
            {
                case "Day":
                    systemTheme = "Day";
                    ChangeBackColours(Color.White);
                    ChangeForeColours(Color.Black);
                    break;
                case "Night":
                    systemTheme = "Night";
                    ChangeBackColours(Color.Black);
                    ChangeForeColours(Color.White);
                    break;
                case "Custom":
                    systemTheme = "Custom";
                    ChangeBackColours(customBackColour);
                    ChangeForeColours(customForeColour);
                    break;
                default:
                    break;
            }
        }

        private void menuStripCustomisationDay_Click(object sender, EventArgs e)
        {
            ChangeTheme("Day");
            menuStripCustomisationDay.Enabled = false;
        }

        private void menuStripCustomisationNight_Click(object sender, EventArgs e)
        {
            ChangeTheme("Night");
            menuStripCustomisationNight.Enabled = false;
        }

        private void menuStripCustomisationCustom_Click(object sender, EventArgs e)
        {
            ChangeTheme("Custom");
            menuStripCustomisationCustom.Enabled = false;
        }
        #endregion CUSTOMISATION MENU

        #region LANGUAGE MENU
        public void SetLanguage(string language)
        {
            menuStripLanguageEnglish.Enabled = true;
            menuStripLanguageFrench.Enabled = true;
            menuStripLanguageGerman.Enabled = true;
            UserMessage(0);

            switch (language)
            {
                case "English":
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-AU");
                    break;
                case "French":
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr-FR");
                    break;
                case "German":
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de-DE");
                    break;
                default:
                    break;
            }
            Controls.Clear();
            InitializeComponent();
        }
        private void menuStripLanguageEnglish_Click(object sender, EventArgs e)
        {
            systemLanguage = "English";
            SetLanguage("English");
            ChangeTheme(systemTheme);
            menuStripLanguageEnglish.Enabled = false;
        }
        private void menuStripLanguageFrench_Click(object sender, EventArgs e)
        {
            systemLanguage = "French";
            SetLanguage("French");
            ChangeTheme(systemTheme);
            menuStripLanguageFrench.Enabled = false;
        }

        private void menuStripLanguageGerman_Click(object sender, EventArgs e)
        {
            systemLanguage = "German";
            SetLanguage("German");
            ChangeTheme(systemTheme);
            menuStripLanguageGerman.Enabled = false;
        }
        #endregion LANGUAGE MENU
    }
}
