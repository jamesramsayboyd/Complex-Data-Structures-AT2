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
        }
        // Global variables for pipe proxy, language and theme
        IAstroContract astroPipeProxy;
        string systemLanguage = "English";
        string systemTheme = "Day";
        Color customBackColour = Color.White;
        Color customForeColour = Color.Black;

        #region BUTTON METHODS
        /// <summary>
        /// A method to measure the velocity of a star using its Doppler shift
        /// Change in Wavelength = Observed Wavelength - Rest Wavelength
        /// Speed of Light (C) = 299792458 m/s
        /// V = velocity (m/s)
        /// Formula: V = C * (Change in Wavelength / Rest Wavelength)
        /// </summary>
        /// <param name="ObservedWavelength">A double representing the observed wavelength of the star</param>
        /// <param name="RestWavelength">A double representing the rest wavelength of the star</param>
        /// <returns>A double representing the velocity of the star (in metres per second)</returns>
        private void buttonCalculateStarVelocity_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxObservedWavelength.Text) &&
                !string.IsNullOrEmpty(textBoxRestWavelength.Text))
            {
                double observedWavelength = double.Parse(textBoxObservedWavelength.Text);
                double restWavelength = double.Parse(textBoxRestWavelength.Text);
                double starVelocity = astroPipeProxy.StarVelocity(observedWavelength, restWavelength);
                DisplayCalculationResult(starVelocity.ToString("f4"), "", "", "");
                UserMessage(0);
            }
            else
            {
                UserMessage(1);
            }
        }

        /// <summary>
        /// A method to measure the distance of a star using the parallax angle from two measuring points in parsecs
        /// Parallax Angle (P) in arcseconds (1/3600 of an arc)
        /// Distance (D) in parsecs (1 parsec = 3.0857 x 10^16m, or 3.26 lightyears)
        /// Formula: D = 1 / P
        /// </summary>
        /// <param name="P">A double representing the parallax angle (in arcseconds)</param>
        /// <returns>A double representing the distance of the star from the measuring points (in parsecs)</returns>
        private void buttonCalculateStarDistance_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxParallaxAngle.Text))
            {
                double parallaxAngle = double.Parse(textBoxParallaxAngle.Text);
                double starDistance = astroPipeProxy.StarDistance(parallaxAngle);
                DisplayCalculationResult("", starDistance.ToString("f4"), "", "");
                UserMessage(0);
            }
            else
            {
                UserMessage(2);
            }
        }

        /// <summary>
        /// A method to convert a given temperature in degrees Celsius into Kelvin
        /// Temperature in Celsius (C) in degrees
        /// Temperature in Kelvin (K)
        /// Formula: K = C + 273
        /// (Temperatures below -273 are considered invalid for the Kelvin scale and should be filtered out)
        /// </summary>
        /// <param name="C">The temperature to be converted (in degrees Celsius)</param>
        /// <returns>The equivalent temperature in Kelvin</returns>
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

        /// <summary>
        /// A method that will return the Schwarzschild radius of a blackhole, i.e.
        /// the distance from the centre of the blackhole to the event horizon, in meters
        /// Gravity Constant (G) = 6.674 x 10^-11 m^3 kg^-1 s^-2
        /// Speed of Light (C) = 299792458 m/s
        /// Mass of Blackhole (M) (in kg)
        /// Schwarzschild Radius (R) (in m)
        /// Formula: R = (2GM)/C^2
        /// </summary>
        /// <param name="M">The mass of the blackhole (in kg)</param>
        /// <returns>The Schwarzschild radius (in meters)</returns>
        private void buttonCalculateEventHorizon_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSchwarzschild.Text) &&
                !string.IsNullOrEmpty(textBoxExponent.Text))
            {
                double baseNo = double.Parse(textBoxSchwarzschild.Text);
                double exponentNo = double.Parse(textBoxExponent.Text);
                double schwarzschildRadius = baseNo * Math.Pow(10, exponentNo);
                double eventHorizon = astroPipeProxy.EventHorizon(schwarzschildRadius);
                DisplayCalculationResult("", "", "", eventHorizon.ToString("G4"));
                UserMessage(0);
            }
            else
            {
                UserMessage(5);
            }
        }
        #endregion BUTTON METHODS

        #region UTILITIES

        /// <summary>
        /// Connects to the AstroMath server
        /// </summary>
        public void ConnectToServer()
        {
            ChannelFactory<IAstroContract> pipeFactory =
              new ChannelFactory<IAstroContract>(
                new NetNamedPipeBinding(),
                  new EndpointAddress("net.pipe://localhost/PipeReverse"));

            astroPipeProxy = pipeFactory.CreateChannel();
        }

        /// <summary>
        /// Clears all TextBoxes and all items in the ListView
        /// </summary>
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

        /// <summary>
        /// Resets to default settings (textboxes cleared, Day Mode, English language)
        /// </summary>
        public void ResetToDefault()
        {
            ClearAllTextBoxes();
            ChangeTheme("Day");
            SetLanguage("English");
        }

        /// <summary>
        /// A method to display the result of a calculation in the appropriate column of
        /// the Listview. Creates a ListViewItem with four sub-items, which are left as 
        /// blank strings for the other three columns
        /// </summary>
        /// <param name="a">The result to be displayed in the Star Velocity column</param>
        /// <param name="b">The result to be displayed in the Star Distance column</param>
        /// <param name="c">The result to be displayed in the Kelvin column</param>
        /// <param name="d">The result to be displayed in the Event Horizon column</param>
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
        /// <summary>
        /// Displays user messages in the Tool Strip at the bottom of the window
        /// </summary>
        /// <param name="errorCode">The error code that determines which user message is shown</param>
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
        /// <summary>
        /// Clears all TextBoxes and all items in the ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuStripFileClearTextboxes_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes();
        }
        /// <summary>
        /// Resets the app to default settings (TextBoxes cleared, Day Mode, English language)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetToDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetToDefault();
        }
        /// <summary>
        /// Closes the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuStripFileExit_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
        #endregion FILE MENU

        #region CUSTOMISATION MENU
        /// <summary>
        /// Changes the BackColor property of all controls
        /// </summary>
        /// <param name="colour">The Color to which all controls will be changed</param>
        private void ChangeBackColours(Color colour)
        {
            menuStripThemesDay.Enabled = true;
            menuStripThemesNight.Enabled = true;
            menuStripCustomisationCustom.Enabled = true;
            ActiveForm.BackColor = colour;
            buttonCalculateStarVelocity.BackColor = colour;
            buttonCalculateStarDistance.BackColor = colour;
            buttonConvertTemperature.BackColor = colour;
            buttonCalculateEventHorizon.BackColor = colour;
            mainMenuStrip.BackColor = colour;
            menuStripFile.DropDown.BackColor = colour;
            menuStripThemes.BackColor = colour;
            menuStripThemes.DropDown.BackColor = colour;
            menuStripCustomisation.BackColor = colour;
            menuStripCustomisation.DropDown.BackColor = colour;
            menuStripLanguage.BackColor = colour;
            menuStripLanguage.DropDown.BackColor = colour;
            statusStrip.BackColor = colour;
            listViewOutput.BackColor = colour;
        }
        /// <summary>
        /// Changes the ForeColor property of all controls
        /// </summary>
        /// <param name="colour">The Color to which all controls will be changed</param>
        private void ChangeForeColours(Color colour)
        {
            ActiveForm.ForeColor = colour;
            buttonCalculateStarVelocity.ForeColor = colour;
            buttonCalculateStarDistance.ForeColor = colour;
            buttonConvertTemperature.ForeColor = colour;
            buttonCalculateEventHorizon.ForeColor = colour;
            mainMenuStrip.ForeColor = colour;
            menuStripFile.DropDown.ForeColor = colour;
            menuStripThemes.DropDown.ForeColor = colour;
            menuStripCustomisation.DropDown.ForeColor = colour;
            menuStripLanguage.DropDown.ForeColor = colour;
            statusStrip.ForeColor = colour;
            listViewOutput.ForeColor = colour;
        }

        /// <summary>
        /// Changes the colour theme of the entire app, using two presets:
        /// Day Mode (white background, black text) and Night Mode (black background,
        /// white text), or a Custom Theme that the user defines
        /// </summary>
        /// <param name="theme">The theme that the app will be set to, Day, Night or Custom</param>
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

        /// <summary>
        /// Allows the user to choose a BackColor for all controls, which is stored
        /// as the global variable 'customBackColour' so the Custom Theme can be saved
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuStripCustomisationBack_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog(Owner);
            customBackColour = colorDialog.Color;
            ChangeBackColours(customBackColour);
            ChangeTheme("Custom");
        }

        /// <summary>
        /// Allows the user to choose a ForeColor for all controls, which is stored
        /// as the global variable 'customForeColour' so the Custom Theme can be saved
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuStripCustomisationFore_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog(Owner);
            customForeColour = colorDialog.Color;
            ChangeForeColours(customForeColour);
            ChangeTheme("Custom");
        }
        /// <summary>
        /// Changes the app to Day Mode (white background, black background)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dayModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTheme("Day");
            menuStripThemesDay.Enabled = false;
        }

        /// <summary>
        /// Changes the app to Night Mode (black background, white background)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTheme("Night");
            menuStripThemesNight.Enabled = false;
        }

        /// <summary>
        /// Changes the app to Custom Theme, defined by the user in the Customisation menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuStripCustomisationCustom_Click(object sender, EventArgs e)
        {
            ChangeTheme("Custom");
            menuStripCustomisationCustom.Enabled = false;
        }
        #endregion CUSTOMISATION MENU

        #region LANGUAGE MENU
        /// <summary>
        /// Sets the language of the app, English, French or German. Text is contained within .resx files.
        /// </summary>
        /// <param name="language">The language to which the app will be changed</param>
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
        /// <summary>
        /// Sets the app to English language (this is considered the default for the app)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuStripLanguageEnglish_Click(object sender, EventArgs e)
        {
            systemLanguage = "English";
            SetLanguage("English");
            ChangeTheme(systemTheme);
            menuStripLanguageEnglish.Enabled = false;
        }
        /// <summary>
        /// Sets the app to French language
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuStripLanguageFrench_Click(object sender, EventArgs e)
        {
            systemLanguage = "French";
            SetLanguage("French");
            ChangeTheme(systemTheme);
            menuStripLanguageFrench.Enabled = false;
        }
        /// <summary>
        /// Sets the app to German language
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
