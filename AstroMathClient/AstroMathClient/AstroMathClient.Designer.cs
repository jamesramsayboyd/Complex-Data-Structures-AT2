namespace AstroMathClient
{
    partial class AstroMathClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AstroMathClient));
            this.textBoxObservedWavelength = new System.Windows.Forms.TextBox();
            this.textBoxRestWavelength = new System.Windows.Forms.TextBox();
            this.buttonCalculateStarVelocity = new System.Windows.Forms.Button();
            this.labelStarVelocity = new System.Windows.Forms.Label();
            this.labelStarDistance = new System.Windows.Forms.Label();
            this.textBoxParallaxAngle = new System.Windows.Forms.TextBox();
            this.buttonCalculateStarDistance = new System.Windows.Forms.Button();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.textBoxCelsius = new System.Windows.Forms.TextBox();
            this.buttonConvertTemperature = new System.Windows.Forms.Button();
            this.labelEventHorizon = new System.Windows.Forms.Label();
            this.textBoxSchwarzschild = new System.Windows.Forms.TextBox();
            this.buttonCalculateEventHorizon = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFileClearTextboxes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFileResetToDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripThemes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripThemesDay = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripThemesNight = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripCustomisation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripCustomisationCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripCustomisationBack = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripCustomisationFore = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripLanguageEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripLanguageFrench = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripLanguageGerman = new System.Windows.Forms.ToolStripMenuItem();
            this.labelObservedWavelength = new System.Windows.Forms.Label();
            this.labelRestWavelength = new System.Windows.Forms.Label();
            this.labelParallaxAngle = new System.Windows.Forms.Label();
            this.labelCelsius = new System.Windows.Forms.Label();
            this.labelSchwarzschild = new System.Windows.Forms.Label();
            this.textBoxExponent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewOutput = new System.Windows.Forms.ListView();
            this.columnVelocity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDistance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTemperature = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEventHorizon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxObservedWavelength
            // 
            resources.ApplyResources(this.textBoxObservedWavelength, "textBoxObservedWavelength");
            this.textBoxObservedWavelength.Name = "textBoxObservedWavelength";
            this.toolTip.SetToolTip(this.textBoxObservedWavelength, resources.GetString("textBoxObservedWavelength.ToolTip"));
            // 
            // textBoxRestWavelength
            // 
            resources.ApplyResources(this.textBoxRestWavelength, "textBoxRestWavelength");
            this.textBoxRestWavelength.Name = "textBoxRestWavelength";
            this.toolTip.SetToolTip(this.textBoxRestWavelength, resources.GetString("textBoxRestWavelength.ToolTip"));
            // 
            // buttonCalculateStarVelocity
            // 
            resources.ApplyResources(this.buttonCalculateStarVelocity, "buttonCalculateStarVelocity");
            this.buttonCalculateStarVelocity.BackColor = System.Drawing.Color.White;
            this.buttonCalculateStarVelocity.Name = "buttonCalculateStarVelocity";
            this.toolTip.SetToolTip(this.buttonCalculateStarVelocity, resources.GetString("buttonCalculateStarVelocity.ToolTip"));
            this.buttonCalculateStarVelocity.UseVisualStyleBackColor = false;
            this.buttonCalculateStarVelocity.Click += new System.EventHandler(this.buttonCalculateStarVelocity_Click);
            // 
            // labelStarVelocity
            // 
            resources.ApplyResources(this.labelStarVelocity, "labelStarVelocity");
            this.labelStarVelocity.Name = "labelStarVelocity";
            this.toolTip.SetToolTip(this.labelStarVelocity, resources.GetString("labelStarVelocity.ToolTip"));
            // 
            // labelStarDistance
            // 
            resources.ApplyResources(this.labelStarDistance, "labelStarDistance");
            this.labelStarDistance.Name = "labelStarDistance";
            this.toolTip.SetToolTip(this.labelStarDistance, resources.GetString("labelStarDistance.ToolTip"));
            // 
            // textBoxParallaxAngle
            // 
            resources.ApplyResources(this.textBoxParallaxAngle, "textBoxParallaxAngle");
            this.textBoxParallaxAngle.Name = "textBoxParallaxAngle";
            this.toolTip.SetToolTip(this.textBoxParallaxAngle, resources.GetString("textBoxParallaxAngle.ToolTip"));
            // 
            // buttonCalculateStarDistance
            // 
            resources.ApplyResources(this.buttonCalculateStarDistance, "buttonCalculateStarDistance");
            this.buttonCalculateStarDistance.BackColor = System.Drawing.Color.White;
            this.buttonCalculateStarDistance.Name = "buttonCalculateStarDistance";
            this.toolTip.SetToolTip(this.buttonCalculateStarDistance, resources.GetString("buttonCalculateStarDistance.ToolTip"));
            this.buttonCalculateStarDistance.UseVisualStyleBackColor = false;
            this.buttonCalculateStarDistance.Click += new System.EventHandler(this.buttonCalculateStarDistance_Click);
            // 
            // labelTemperature
            // 
            resources.ApplyResources(this.labelTemperature, "labelTemperature");
            this.labelTemperature.Name = "labelTemperature";
            this.toolTip.SetToolTip(this.labelTemperature, resources.GetString("labelTemperature.ToolTip"));
            // 
            // textBoxCelsius
            // 
            resources.ApplyResources(this.textBoxCelsius, "textBoxCelsius");
            this.textBoxCelsius.Name = "textBoxCelsius";
            this.toolTip.SetToolTip(this.textBoxCelsius, resources.GetString("textBoxCelsius.ToolTip"));
            // 
            // buttonConvertTemperature
            // 
            resources.ApplyResources(this.buttonConvertTemperature, "buttonConvertTemperature");
            this.buttonConvertTemperature.BackColor = System.Drawing.Color.White;
            this.buttonConvertTemperature.Name = "buttonConvertTemperature";
            this.toolTip.SetToolTip(this.buttonConvertTemperature, resources.GetString("buttonConvertTemperature.ToolTip"));
            this.buttonConvertTemperature.UseVisualStyleBackColor = false;
            this.buttonConvertTemperature.Click += new System.EventHandler(this.buttonConvertTemperature_Click);
            // 
            // labelEventHorizon
            // 
            resources.ApplyResources(this.labelEventHorizon, "labelEventHorizon");
            this.labelEventHorizon.Name = "labelEventHorizon";
            this.toolTip.SetToolTip(this.labelEventHorizon, resources.GetString("labelEventHorizon.ToolTip"));
            // 
            // textBoxSchwarzschild
            // 
            resources.ApplyResources(this.textBoxSchwarzschild, "textBoxSchwarzschild");
            this.textBoxSchwarzschild.Name = "textBoxSchwarzschild";
            this.toolTip.SetToolTip(this.textBoxSchwarzschild, resources.GetString("textBoxSchwarzschild.ToolTip"));
            // 
            // buttonCalculateEventHorizon
            // 
            resources.ApplyResources(this.buttonCalculateEventHorizon, "buttonCalculateEventHorizon");
            this.buttonCalculateEventHorizon.BackColor = System.Drawing.Color.White;
            this.buttonCalculateEventHorizon.Name = "buttonCalculateEventHorizon";
            this.toolTip.SetToolTip(this.buttonCalculateEventHorizon, resources.GetString("buttonCalculateEventHorizon.ToolTip"));
            this.buttonCalculateEventHorizon.UseVisualStyleBackColor = false;
            this.buttonCalculateEventHorizon.Click += new System.EventHandler(this.buttonCalculateEventHorizon_Click);
            // 
            // statusStrip
            // 
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.BackColor = System.Drawing.Color.White;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
            this.statusStrip.Name = "statusStrip";
            this.toolTip.SetToolTip(this.statusStrip, resources.GetString("statusStrip.ToolTip"));
            // 
            // toolStripStatus
            // 
            resources.ApplyResources(this.toolStripStatus, "toolStripStatus");
            this.toolStripStatus.Name = "toolStripStatus";
            // 
            // mainMenuStrip
            // 
            resources.ApplyResources(this.mainMenuStrip, "mainMenuStrip");
            this.mainMenuStrip.BackColor = System.Drawing.Color.White;
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripFile,
            this.menuStripThemes,
            this.menuStripCustomisation,
            this.menuStripLanguage});
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.toolTip.SetToolTip(this.mainMenuStrip, resources.GetString("mainMenuStrip.ToolTip"));
            // 
            // menuStripFile
            // 
            resources.ApplyResources(this.menuStripFile, "menuStripFile");
            this.menuStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripFileClearTextboxes,
            this.menuStripFileResetToDefault,
            this.menuStripFileExit});
            this.menuStripFile.Name = "menuStripFile";
            // 
            // menuStripFileClearTextboxes
            // 
            resources.ApplyResources(this.menuStripFileClearTextboxes, "menuStripFileClearTextboxes");
            this.menuStripFileClearTextboxes.Name = "menuStripFileClearTextboxes";
            this.menuStripFileClearTextboxes.Click += new System.EventHandler(this.menuStripFileClearTextboxes_Click);
            // 
            // menuStripFileResetToDefault
            // 
            resources.ApplyResources(this.menuStripFileResetToDefault, "menuStripFileResetToDefault");
            this.menuStripFileResetToDefault.Name = "menuStripFileResetToDefault";
            this.menuStripFileResetToDefault.Click += new System.EventHandler(this.resetToDefaultToolStripMenuItem_Click);
            // 
            // menuStripFileExit
            // 
            resources.ApplyResources(this.menuStripFileExit, "menuStripFileExit");
            this.menuStripFileExit.Name = "menuStripFileExit";
            this.menuStripFileExit.Click += new System.EventHandler(this.menuStripFileExit_Click);
            // 
            // menuStripThemes
            // 
            resources.ApplyResources(this.menuStripThemes, "menuStripThemes");
            this.menuStripThemes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripThemesDay,
            this.menuStripThemesNight});
            this.menuStripThemes.Name = "menuStripThemes";
            // 
            // menuStripThemesDay
            // 
            resources.ApplyResources(this.menuStripThemesDay, "menuStripThemesDay");
            this.menuStripThemesDay.Name = "menuStripThemesDay";
            this.menuStripThemesDay.Click += new System.EventHandler(this.dayModeToolStripMenuItem_Click);
            // 
            // menuStripThemesNight
            // 
            resources.ApplyResources(this.menuStripThemesNight, "menuStripThemesNight");
            this.menuStripThemesNight.Name = "menuStripThemesNight";
            this.menuStripThemesNight.Click += new System.EventHandler(this.nightModeToolStripMenuItem_Click);
            // 
            // menuStripCustomisation
            // 
            resources.ApplyResources(this.menuStripCustomisation, "menuStripCustomisation");
            this.menuStripCustomisation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripCustomisationCustom,
            this.menuStripCustomisationBack,
            this.menuStripCustomisationFore});
            this.menuStripCustomisation.Name = "menuStripCustomisation";
            // 
            // menuStripCustomisationCustom
            // 
            resources.ApplyResources(this.menuStripCustomisationCustom, "menuStripCustomisationCustom");
            this.menuStripCustomisationCustom.Name = "menuStripCustomisationCustom";
            this.menuStripCustomisationCustom.Click += new System.EventHandler(this.menuStripCustomisationCustom_Click);
            // 
            // menuStripCustomisationBack
            // 
            resources.ApplyResources(this.menuStripCustomisationBack, "menuStripCustomisationBack");
            this.menuStripCustomisationBack.Name = "menuStripCustomisationBack";
            this.menuStripCustomisationBack.Click += new System.EventHandler(this.menuStripCustomisationBack_Click);
            // 
            // menuStripCustomisationFore
            // 
            resources.ApplyResources(this.menuStripCustomisationFore, "menuStripCustomisationFore");
            this.menuStripCustomisationFore.Name = "menuStripCustomisationFore";
            this.menuStripCustomisationFore.Click += new System.EventHandler(this.menuStripCustomisationFore_Click);
            // 
            // menuStripLanguage
            // 
            resources.ApplyResources(this.menuStripLanguage, "menuStripLanguage");
            this.menuStripLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripLanguageEnglish,
            this.menuStripLanguageFrench,
            this.menuStripLanguageGerman});
            this.menuStripLanguage.Name = "menuStripLanguage";
            // 
            // menuStripLanguageEnglish
            // 
            resources.ApplyResources(this.menuStripLanguageEnglish, "menuStripLanguageEnglish");
            this.menuStripLanguageEnglish.Name = "menuStripLanguageEnglish";
            this.menuStripLanguageEnglish.Click += new System.EventHandler(this.menuStripLanguageEnglish_Click);
            // 
            // menuStripLanguageFrench
            // 
            resources.ApplyResources(this.menuStripLanguageFrench, "menuStripLanguageFrench");
            this.menuStripLanguageFrench.Name = "menuStripLanguageFrench";
            this.menuStripLanguageFrench.Click += new System.EventHandler(this.menuStripLanguageFrench_Click);
            // 
            // menuStripLanguageGerman
            // 
            resources.ApplyResources(this.menuStripLanguageGerman, "menuStripLanguageGerman");
            this.menuStripLanguageGerman.Name = "menuStripLanguageGerman";
            this.menuStripLanguageGerman.Click += new System.EventHandler(this.menuStripLanguageGerman_Click);
            // 
            // labelObservedWavelength
            // 
            resources.ApplyResources(this.labelObservedWavelength, "labelObservedWavelength");
            this.labelObservedWavelength.Name = "labelObservedWavelength";
            this.toolTip.SetToolTip(this.labelObservedWavelength, resources.GetString("labelObservedWavelength.ToolTip"));
            // 
            // labelRestWavelength
            // 
            resources.ApplyResources(this.labelRestWavelength, "labelRestWavelength");
            this.labelRestWavelength.Name = "labelRestWavelength";
            this.toolTip.SetToolTip(this.labelRestWavelength, resources.GetString("labelRestWavelength.ToolTip"));
            // 
            // labelParallaxAngle
            // 
            resources.ApplyResources(this.labelParallaxAngle, "labelParallaxAngle");
            this.labelParallaxAngle.Name = "labelParallaxAngle";
            this.toolTip.SetToolTip(this.labelParallaxAngle, resources.GetString("labelParallaxAngle.ToolTip"));
            // 
            // labelCelsius
            // 
            resources.ApplyResources(this.labelCelsius, "labelCelsius");
            this.labelCelsius.Name = "labelCelsius";
            this.toolTip.SetToolTip(this.labelCelsius, resources.GetString("labelCelsius.ToolTip"));
            // 
            // labelSchwarzschild
            // 
            resources.ApplyResources(this.labelSchwarzschild, "labelSchwarzschild");
            this.labelSchwarzschild.Name = "labelSchwarzschild";
            this.toolTip.SetToolTip(this.labelSchwarzschild, resources.GetString("labelSchwarzschild.ToolTip"));
            // 
            // textBoxExponent
            // 
            resources.ApplyResources(this.textBoxExponent, "textBoxExponent");
            this.textBoxExponent.Name = "textBoxExponent";
            this.toolTip.SetToolTip(this.textBoxExponent, resources.GetString("textBoxExponent.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // listViewOutput
            // 
            resources.ApplyResources(this.listViewOutput, "listViewOutput");
            this.listViewOutput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnVelocity,
            this.columnDistance,
            this.columnTemperature,
            this.columnEventHorizon});
            this.listViewOutput.HideSelection = false;
            this.listViewOutput.Name = "listViewOutput";
            this.toolTip.SetToolTip(this.listViewOutput, resources.GetString("listViewOutput.ToolTip"));
            this.listViewOutput.UseCompatibleStateImageBehavior = false;
            this.listViewOutput.View = System.Windows.Forms.View.Details;
            // 
            // columnVelocity
            // 
            resources.ApplyResources(this.columnVelocity, "columnVelocity");
            // 
            // columnDistance
            // 
            resources.ApplyResources(this.columnDistance, "columnDistance");
            // 
            // columnTemperature
            // 
            resources.ApplyResources(this.columnTemperature, "columnTemperature");
            // 
            // columnEventHorizon
            // 
            resources.ApplyResources(this.columnEventHorizon, "columnEventHorizon");
            // 
            // AstroMathClient
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.listViewOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxExponent);
            this.Controls.Add(this.labelSchwarzschild);
            this.Controls.Add(this.labelCelsius);
            this.Controls.Add(this.labelParallaxAngle);
            this.Controls.Add(this.labelRestWavelength);
            this.Controls.Add(this.labelObservedWavelength);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.buttonCalculateEventHorizon);
            this.Controls.Add(this.textBoxSchwarzschild);
            this.Controls.Add(this.labelEventHorizon);
            this.Controls.Add(this.buttonConvertTemperature);
            this.Controls.Add(this.textBoxCelsius);
            this.Controls.Add(this.labelTemperature);
            this.Controls.Add(this.buttonCalculateStarDistance);
            this.Controls.Add(this.textBoxParallaxAngle);
            this.Controls.Add(this.labelStarDistance);
            this.Controls.Add(this.labelStarVelocity);
            this.Controls.Add(this.buttonCalculateStarVelocity);
            this.Controls.Add(this.textBoxRestWavelength);
            this.Controls.Add(this.textBoxObservedWavelength);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "AstroMathClient";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxObservedWavelength;
        private System.Windows.Forms.TextBox textBoxRestWavelength;
        private System.Windows.Forms.Button buttonCalculateStarVelocity;
        private System.Windows.Forms.Label labelStarVelocity;
        private System.Windows.Forms.Label labelStarDistance;
        private System.Windows.Forms.TextBox textBoxParallaxAngle;
        private System.Windows.Forms.Button buttonCalculateStarDistance;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.TextBox textBoxCelsius;
        private System.Windows.Forms.Button buttonConvertTemperature;
        private System.Windows.Forms.Label labelEventHorizon;
        private System.Windows.Forms.TextBox textBoxSchwarzschild;
        private System.Windows.Forms.Button buttonCalculateEventHorizon;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuStripFile;
        private System.Windows.Forms.ToolStripMenuItem menuStripCustomisation;
        private System.Windows.Forms.ToolStripMenuItem menuStripLanguage;
        private System.Windows.Forms.ToolStripMenuItem menuStripFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuStripCustomisationCustom;
        private System.Windows.Forms.ToolStripMenuItem menuStripLanguageEnglish;
        private System.Windows.Forms.ToolStripMenuItem menuStripLanguageFrench;
        private System.Windows.Forms.ToolStripMenuItem menuStripLanguageGerman;
        private System.Windows.Forms.ToolStripMenuItem menuStripFileClearTextboxes;
        private System.Windows.Forms.ToolStripMenuItem menuStripFileResetToDefault;
        private System.Windows.Forms.Label labelObservedWavelength;
        private System.Windows.Forms.Label labelRestWavelength;
        private System.Windows.Forms.Label labelParallaxAngle;
        private System.Windows.Forms.Label labelCelsius;
        private System.Windows.Forms.Label labelSchwarzschild;
        private System.Windows.Forms.TextBox textBoxExponent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewOutput;
        private System.Windows.Forms.ColumnHeader columnVelocity;
        private System.Windows.Forms.ColumnHeader columnDistance;
        private System.Windows.Forms.ColumnHeader columnTemperature;
        private System.Windows.Forms.ColumnHeader columnEventHorizon;
        private System.Windows.Forms.ToolStripMenuItem menuStripCustomisationBack;
        private System.Windows.Forms.ToolStripMenuItem menuStripThemes;
        private System.Windows.Forms.ToolStripMenuItem menuStripThemesDay;
        private System.Windows.Forms.ToolStripMenuItem menuStripThemesNight;
        private System.Windows.Forms.ToolStripMenuItem menuStripCustomisationFore;
    }
}

