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

        #region BUTTON METHODS
        private void buttonCalculateStarVelocity_Click(object sender, EventArgs e)
        {
            double observedWavelength = double.Parse(textBoxObservedWavelength.Text);
            double restWavelength = double.Parse(textBoxRestWavelength.Text);
            double starVelocity = astroPipeProxy.StarVelocity(observedWavelength, restWavelength);
            DisplayCalculationResult(starVelocity.ToString(), "", "", "");
        }

        private void buttonCalculateStarDistance_Click(object sender, EventArgs e)
        {
            double parallaxAngle = double.Parse(textBoxParallaxAngle.Text);
            double starDistance = astroPipeProxy.StarDistance(parallaxAngle);
            DisplayCalculationResult("", starDistance.ToString(), "", "");
        }

        private void buttonConvertTemperature_Click(object sender, EventArgs e)
        {
            double temperatureInCelsius = double.Parse(textBoxCelsius.Text);
            if (temperatureInCelsius >= -273)
            {
                double temperatureInKelvin = astroPipeProxy.TemperatureInKelvin(temperatureInCelsius);
                DisplayCalculationResult("", "", temperatureInKelvin.ToString(), "");
            }
            else
            {
                ErrorMessage(0);
            }            
        }

        private void buttonCalculateEventHorizon_Click(object sender, EventArgs e)
        {
            double baseNo = double.Parse(textBoxSchwarzschild.Text);
            double exponentNo = double.Parse(textBoxExponent.Text);
            double schwarzschildRadius = baseNo * (Math.Pow(10, exponentNo));
            double eventHorizon = astroPipeProxy.EventHorizon(schwarzschildRadius);
            DisplayCalculationResult("", "", "", eventHorizon.ToString());
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
            textBoxParallaxAngle.Clear();
            textBoxCelsius.Clear();
            textBoxSchwarzschild.Clear();
        }

        public void ResetToDefault()
        {
            ClearAllTextBoxes();
            DayMode();
            SetLanguageToEnglish();
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
        private void ErrorMessage(int errorCode)
        {
            switch (errorCode)
            {
                case 0: 
                    toolStripStatus.Text = "Please enter a temperature greater than -273 Celsius";
                    break;
                case 1:
                    toolStripStatus.Text = "Temperature converted";
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
            menuStripLanguageEnglish.Enabled = true;
            menuStripLanguageFrench.Enabled = true;
            menuStripLanguageGerman.Enabled = true;
            ActiveForm.Text = "Astro Math Client";
            labelStarVelocity.Text = "       STAR VELOCITY       ";
            labelStarDistance.Text = "STAR DISTANCE";
            labelTemperature.Text = "TEMPERATURE";
            labelEventHorizon.Text = "        EVENT HORIZON        ";
            labelObservedWavelength.Text = "Observed Wavelength (nm)";
            labelRestWavelength.Text = "    Rest Wavelength (nm)    ";
            labelParallaxAngle.Text = "Parallax Angle (arcsec)";
            labelCelsius.Text = "Celsius (degrees)";
            labelSchwarzschild.Text = "Schwarzschild Radius (m)";
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
            listViewOutput.Columns[0].Text = "Velocity (m/s)";
            listViewOutput.Columns[1].Text = "Distance (parsecs)";
            listViewOutput.Columns[2].Text = "Kelvin";
            listViewOutput.Columns[3].Text = "Event Horizon (m)";
        }

        public void SetLanguageToFrench()
        {
            menuStripLanguageEnglish.Enabled = true;
            menuStripLanguageFrench.Enabled = true;
            menuStripLanguageGerman.Enabled = true;
            ActiveForm.Text = "Client Astro Math";
            labelStarVelocity.Text = "    VÉLOCITÉ DES ÉTOILES    ";
            labelStarDistance.Text = "DISTANCE ÉTOILE";
            labelTemperature.Text = "TEMPÉRATURE";
            labelEventHorizon.Text = "HORIZON DES ÉVÉNEMENTS";
            labelObservedWavelength.Text = "Longueur d'onde observée (nm)";
            labelRestWavelength.Text = "Longueur d'onde de repos (nm)";
            labelParallaxAngle.Text = "Angle de parallaxe (arcsec)";
            labelCelsius.Text = "Celsius (degrees)";
            labelSchwarzschild.Text = "Rayon de Schwarzschild (m)";
            buttonCalculateStarVelocity.Text = "CALCULER";
            buttonCalculateStarDistance.Text = "CALCULER";
            buttonConvertTemperature.Text = "CONVERTIR";
            buttonCalculateEventHorizon.Text = "CALCULER";
            menuStripFile.Text = "Fichier";
            menuStripFileClearTextboxes.Text = "Effacer les boites de texte";
            menuStripFileResetToDefault.Text = "Réinitialiser par défaut";
            menuStripFileExit.Text = "Sortir";
            menuStripCustomisation.Text = "Personnalisation";
            menuStripCustomisationDay.Text = "Mode Jour";
            menuStripCustomisationNight.Text = "Mode Nuit";
            menuStripCustomisationCustom.Text = "Thème personnalisé";
            menuStripLanguage.Text = "Langue";
            menuStripLanguageEnglish.Text = "Anglais";
            menuStripLanguageFrench.Text = "Français";
            menuStripLanguageGerman.Text = "Allemand";
            listViewOutput.Columns[0].Text = "Vélocité (m/s)";
            listViewOutput.Columns[1].Text = "Distance (parsecs)";
            listViewOutput.Columns[2].Text = "Kelvin";
            listViewOutput.Columns[3].Text = "Horizon des événements (m)";
        }
        public void SetLanguageToGerman()
        {
            menuStripLanguageEnglish.Enabled = true;
            menuStripLanguageFrench.Enabled = true;
            menuStripLanguageGerman.Enabled = true;
            ActiveForm.Text = "Astro Math - Client";
            labelStarVelocity.Text = "STERNGESCHWINDIGKEIT";
            labelStarDistance.Text = "STERNENABSTAND";
            labelTemperature.Text = "TEMPERATUR";
            labelEventHorizon.Text = "    EREIGNISHORIZONT    ";
            labelObservedWavelength.Text = "Beobachtete Wellenlänge (nm)";
            labelRestWavelength.Text = "    Ruhewellenlänge (nm)    ";
            labelParallaxAngle.Text = "Parallaxenwinkel (arcsec)";
            labelCelsius.Text = "Celsius (degrees)";
            labelSchwarzschild.Text = "Schwarzschild-Radius (m)";
            buttonCalculateStarVelocity.Text = "BERECHNUNG";
            buttonCalculateStarDistance.Text = "BERECHNUNG";
            buttonConvertTemperature.Text = "KONVERTIEREN";
            buttonCalculateEventHorizon.Text = "BERECHNUNG";
            menuStripFile.Text = "Akte";
            menuStripFileClearTextboxes.Text = "Textfelder löschen";
            menuStripFileResetToDefault.Text = "Zurücksetzen";
            menuStripFileExit.Text = "Ausgang";
            menuStripCustomisation.Text = "Anpassung";
            menuStripCustomisationDay.Text = "Tagesmodus";
            menuStripCustomisationNight.Text = "Nacht-Modus";
            menuStripCustomisationCustom.Text = "Benutzerdefiniertes Design";
            menuStripLanguage.Text = "Sprache";
            menuStripLanguageEnglish.Text = "Englisch";
            menuStripLanguageFrench.Text = "Französisch";
            menuStripLanguageGerman.Text = "Deutsch";
            listViewOutput.Columns[0].Text = "Geschwindigkeit (m/s)";
            listViewOutput.Columns[1].Text = "Distanz (parsecs)";
            listViewOutput.Columns[2].Text = "Kelvin";
            listViewOutput.Columns[3].Text = "Ereignishorizont (m)";
        }
        private void menuStripLanguageEnglish_Click(object sender, EventArgs e)
        {
            SetLanguageToEnglish();
            menuStripLanguageEnglish.Enabled = false;
        }
        private void menuStripLanguageFrench_Click(object sender, EventArgs e)
        {
            SetLanguageToFrench();
            menuStripLanguageFrench.Enabled = false;
        }

        private void menuStripLanguageGerman_Click(object sender, EventArgs e)
        {
            SetLanguageToGerman();
            menuStripLanguageGerman.Enabled = false;
        }
        #endregion LANGUAGE MENU
    }
}
