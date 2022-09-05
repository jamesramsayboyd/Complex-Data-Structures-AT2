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
            this.menuStripCustomisation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripCustomisationDay = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripCustomisationNight = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripCustomisationCustom = new System.Windows.Forms.ToolStripMenuItem();
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
            this.textBoxObservedWavelength.Location = new System.Drawing.Point(55, 75);
            this.textBoxObservedWavelength.Name = "textBoxObservedWavelength";
            this.textBoxObservedWavelength.Size = new System.Drawing.Size(100, 20);
            this.textBoxObservedWavelength.TabIndex = 0;
            // 
            // textBoxRestWavelength
            // 
            this.textBoxRestWavelength.Location = new System.Drawing.Point(55, 116);
            this.textBoxRestWavelength.Name = "textBoxRestWavelength";
            this.textBoxRestWavelength.Size = new System.Drawing.Size(100, 20);
            this.textBoxRestWavelength.TabIndex = 1;
            // 
            // buttonCalculateStarVelocity
            // 
            this.buttonCalculateStarVelocity.BackColor = System.Drawing.Color.White;
            this.buttonCalculateStarVelocity.Location = new System.Drawing.Point(60, 149);
            this.buttonCalculateStarVelocity.Name = "buttonCalculateStarVelocity";
            this.buttonCalculateStarVelocity.Size = new System.Drawing.Size(91, 23);
            this.buttonCalculateStarVelocity.TabIndex = 2;
            this.buttonCalculateStarVelocity.Text = "CALCULATE";
            this.buttonCalculateStarVelocity.UseVisualStyleBackColor = false;
            this.buttonCalculateStarVelocity.Click += new System.EventHandler(this.buttonCalculateStarVelocity_Click);
            // 
            // labelStarVelocity
            // 
            this.labelStarVelocity.AutoSize = true;
            this.labelStarVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStarVelocity.Location = new System.Drawing.Point(12, 36);
            this.labelStarVelocity.Name = "labelStarVelocity";
            this.labelStarVelocity.Size = new System.Drawing.Size(181, 16);
            this.labelStarVelocity.TabIndex = 4;
            this.labelStarVelocity.Text = "       STAR VELOCITY       ";
            this.labelStarVelocity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStarDistance
            // 
            this.labelStarDistance.AutoSize = true;
            this.labelStarDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStarDistance.Location = new System.Drawing.Point(234, 36);
            this.labelStarDistance.Name = "labelStarDistance";
            this.labelStarDistance.Size = new System.Drawing.Size(128, 16);
            this.labelStarDistance.TabIndex = 5;
            this.labelStarDistance.Text = "STAR DISTANCE";
            this.labelStarDistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxParallaxAngle
            // 
            this.textBoxParallaxAngle.Location = new System.Drawing.Point(248, 75);
            this.textBoxParallaxAngle.Name = "textBoxParallaxAngle";
            this.textBoxParallaxAngle.Size = new System.Drawing.Size(100, 20);
            this.textBoxParallaxAngle.TabIndex = 6;
            // 
            // buttonCalculateStarDistance
            // 
            this.buttonCalculateStarDistance.BackColor = System.Drawing.Color.White;
            this.buttonCalculateStarDistance.Location = new System.Drawing.Point(253, 149);
            this.buttonCalculateStarDistance.Name = "buttonCalculateStarDistance";
            this.buttonCalculateStarDistance.Size = new System.Drawing.Size(91, 23);
            this.buttonCalculateStarDistance.TabIndex = 8;
            this.buttonCalculateStarDistance.Text = "CALCULATE";
            this.buttonCalculateStarDistance.UseVisualStyleBackColor = false;
            this.buttonCalculateStarDistance.Click += new System.EventHandler(this.buttonCalculateStarDistance_Click);
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperature.Location = new System.Drawing.Point(438, 36);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(122, 16);
            this.labelTemperature.TabIndex = 9;
            this.labelTemperature.Text = "TEMPERATURE";
            this.labelTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCelsius
            // 
            this.textBoxCelsius.Location = new System.Drawing.Point(449, 75);
            this.textBoxCelsius.Name = "textBoxCelsius";
            this.textBoxCelsius.Size = new System.Drawing.Size(100, 20);
            this.textBoxCelsius.TabIndex = 10;
            // 
            // buttonConvertTemperature
            // 
            this.buttonConvertTemperature.BackColor = System.Drawing.Color.White;
            this.buttonConvertTemperature.Location = new System.Drawing.Point(454, 149);
            this.buttonConvertTemperature.Name = "buttonConvertTemperature";
            this.buttonConvertTemperature.Size = new System.Drawing.Size(91, 23);
            this.buttonConvertTemperature.TabIndex = 11;
            this.buttonConvertTemperature.Text = "CONVERT";
            this.buttonConvertTemperature.UseVisualStyleBackColor = false;
            this.buttonConvertTemperature.Click += new System.EventHandler(this.buttonConvertTemperature_Click);
            // 
            // labelEventHorizon
            // 
            this.labelEventHorizon.AutoSize = true;
            this.labelEventHorizon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEventHorizon.Location = new System.Drawing.Point(576, 36);
            this.labelEventHorizon.Name = "labelEventHorizon";
            this.labelEventHorizon.Size = new System.Drawing.Size(194, 16);
            this.labelEventHorizon.TabIndex = 13;
            this.labelEventHorizon.Text = "        EVENT HORIZON        ";
            this.labelEventHorizon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSchwarzschild
            // 
            this.textBoxSchwarzschild.Location = new System.Drawing.Point(597, 75);
            this.textBoxSchwarzschild.Name = "textBoxSchwarzschild";
            this.textBoxSchwarzschild.Size = new System.Drawing.Size(100, 20);
            this.textBoxSchwarzschild.TabIndex = 14;
            // 
            // buttonCalculateEventHorizon
            // 
            this.buttonCalculateEventHorizon.BackColor = System.Drawing.Color.White;
            this.buttonCalculateEventHorizon.Location = new System.Drawing.Point(629, 149);
            this.buttonCalculateEventHorizon.Name = "buttonCalculateEventHorizon";
            this.buttonCalculateEventHorizon.Size = new System.Drawing.Size(91, 23);
            this.buttonCalculateEventHorizon.TabIndex = 15;
            this.buttonCalculateEventHorizon.Text = "CALCULATE";
            this.buttonCalculateEventHorizon.UseVisualStyleBackColor = false;
            this.buttonCalculateEventHorizon.Click += new System.EventHandler(this.buttonCalculateEventHorizon_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.White;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 282);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(795, 22);
            this.statusStrip.TabIndex = 17;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatus.Text = "-";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.White;
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripFile,
            this.menuStripCustomisation,
            this.menuStripLanguage});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(795, 24);
            this.mainMenuStrip.TabIndex = 19;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // menuStripFile
            // 
            this.menuStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripFileClearTextboxes,
            this.menuStripFileResetToDefault,
            this.menuStripFileExit});
            this.menuStripFile.Name = "menuStripFile";
            this.menuStripFile.Size = new System.Drawing.Size(37, 20);
            this.menuStripFile.Text = "File";
            // 
            // menuStripFileClearTextboxes
            // 
            this.menuStripFileClearTextboxes.Name = "menuStripFileClearTextboxes";
            this.menuStripFileClearTextboxes.Size = new System.Drawing.Size(157, 22);
            this.menuStripFileClearTextboxes.Text = "Clear Textboxes";
            this.menuStripFileClearTextboxes.Click += new System.EventHandler(this.menuStripFileClearTextboxes_Click);
            // 
            // menuStripFileResetToDefault
            // 
            this.menuStripFileResetToDefault.Name = "menuStripFileResetToDefault";
            this.menuStripFileResetToDefault.Size = new System.Drawing.Size(157, 22);
            this.menuStripFileResetToDefault.Text = "Reset to Default";
            this.menuStripFileResetToDefault.Click += new System.EventHandler(this.resetToDefaultToolStripMenuItem_Click);
            // 
            // menuStripFileExit
            // 
            this.menuStripFileExit.Name = "menuStripFileExit";
            this.menuStripFileExit.Size = new System.Drawing.Size(157, 22);
            this.menuStripFileExit.Text = "Exit";
            this.menuStripFileExit.Click += new System.EventHandler(this.menuStripFileExit_Click);
            // 
            // menuStripCustomisation
            // 
            this.menuStripCustomisation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripCustomisationDay,
            this.menuStripCustomisationNight,
            this.menuStripCustomisationCustom});
            this.menuStripCustomisation.Name = "menuStripCustomisation";
            this.menuStripCustomisation.Size = new System.Drawing.Size(96, 20);
            this.menuStripCustomisation.Text = "Customisation";
            // 
            // menuStripCustomisationDay
            // 
            this.menuStripCustomisationDay.Enabled = false;
            this.menuStripCustomisationDay.Name = "menuStripCustomisationDay";
            this.menuStripCustomisationDay.Size = new System.Drawing.Size(155, 22);
            this.menuStripCustomisationDay.Text = "Day Mode";
            this.menuStripCustomisationDay.Click += new System.EventHandler(this.menuStripCustomisationDay_Click);
            // 
            // menuStripCustomisationNight
            // 
            this.menuStripCustomisationNight.Name = "menuStripCustomisationNight";
            this.menuStripCustomisationNight.Size = new System.Drawing.Size(155, 22);
            this.menuStripCustomisationNight.Text = "Night Mode";
            this.menuStripCustomisationNight.Click += new System.EventHandler(this.menuStripCustomisationNight_Click);
            // 
            // menuStripCustomisationCustom
            // 
            this.menuStripCustomisationCustom.Name = "menuStripCustomisationCustom";
            this.menuStripCustomisationCustom.Size = new System.Drawing.Size(155, 22);
            this.menuStripCustomisationCustom.Text = "Custom Theme";
            this.menuStripCustomisationCustom.Click += new System.EventHandler(this.menuStripCustomisationCustom_Click);
            // 
            // menuStripLanguage
            // 
            this.menuStripLanguage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripLanguageEnglish,
            this.menuStripLanguageFrench,
            this.menuStripLanguageGerman});
            this.menuStripLanguage.Name = "menuStripLanguage";
            this.menuStripLanguage.Size = new System.Drawing.Size(71, 20);
            this.menuStripLanguage.Text = "Language";
            // 
            // menuStripLanguageEnglish
            // 
            this.menuStripLanguageEnglish.Enabled = false;
            this.menuStripLanguageEnglish.Name = "menuStripLanguageEnglish";
            this.menuStripLanguageEnglish.Size = new System.Drawing.Size(180, 22);
            this.menuStripLanguageEnglish.Text = "English";
            this.menuStripLanguageEnglish.Click += new System.EventHandler(this.menuStripLanguageEnglish_Click);
            // 
            // menuStripLanguageFrench
            // 
            this.menuStripLanguageFrench.Name = "menuStripLanguageFrench";
            this.menuStripLanguageFrench.Size = new System.Drawing.Size(116, 22);
            this.menuStripLanguageFrench.Text = "French";
            this.menuStripLanguageFrench.Click += new System.EventHandler(this.menuStripLanguageFrench_Click);
            // 
            // menuStripLanguageGerman
            // 
            this.menuStripLanguageGerman.Name = "menuStripLanguageGerman";
            this.menuStripLanguageGerman.Size = new System.Drawing.Size(116, 22);
            this.menuStripLanguageGerman.Text = "German";
            this.menuStripLanguageGerman.Click += new System.EventHandler(this.menuStripLanguageGerman_Click);
            // 
            // labelObservedWavelength
            // 
            this.labelObservedWavelength.AutoSize = true;
            this.labelObservedWavelength.Location = new System.Drawing.Point(34, 57);
            this.labelObservedWavelength.Name = "labelObservedWavelength";
            this.labelObservedWavelength.Size = new System.Drawing.Size(137, 13);
            this.labelObservedWavelength.TabIndex = 20;
            this.labelObservedWavelength.Text = "Observed Wavelength (nm)";
            this.labelObservedWavelength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRestWavelength
            // 
            this.labelRestWavelength.AutoSize = true;
            this.labelRestWavelength.Location = new System.Drawing.Point(37, 100);
            this.labelRestWavelength.Name = "labelRestWavelength";
            this.labelRestWavelength.Size = new System.Drawing.Size(137, 13);
            this.labelRestWavelength.TabIndex = 21;
            this.labelRestWavelength.Text = "    Rest Wavelength (nm)    ";
            this.labelRestWavelength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelParallaxAngle
            // 
            this.labelParallaxAngle.AutoSize = true;
            this.labelParallaxAngle.Location = new System.Drawing.Point(241, 57);
            this.labelParallaxAngle.Name = "labelParallaxAngle";
            this.labelParallaxAngle.Size = new System.Drawing.Size(115, 13);
            this.labelParallaxAngle.TabIndex = 22;
            this.labelParallaxAngle.Text = "Parallax Angle (arcsec)";
            this.labelParallaxAngle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCelsius
            // 
            this.labelCelsius.AutoSize = true;
            this.labelCelsius.Location = new System.Drawing.Point(456, 57);
            this.labelCelsius.Name = "labelCelsius";
            this.labelCelsius.Size = new System.Drawing.Size(87, 13);
            this.labelCelsius.TabIndex = 23;
            this.labelCelsius.Text = "Celsius (degrees)";
            this.labelCelsius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSchwarzschild
            // 
            this.labelSchwarzschild.AutoSize = true;
            this.labelSchwarzschild.Location = new System.Drawing.Point(610, 57);
            this.labelSchwarzschild.Name = "labelSchwarzschild";
            this.labelSchwarzschild.Size = new System.Drawing.Size(128, 13);
            this.labelSchwarzschild.TabIndex = 24;
            this.labelSchwarzschild.Text = "Schwarzschild Radius (m)";
            this.labelSchwarzschild.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxExponent
            // 
            this.textBoxExponent.Location = new System.Drawing.Point(730, 75);
            this.textBoxExponent.Name = "textBoxExponent";
            this.textBoxExponent.Size = new System.Drawing.Size(24, 20);
            this.textBoxExponent.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(700, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "x10^";
            // 
            // listViewOutput
            // 
            this.listViewOutput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnVelocity,
            this.columnDistance,
            this.columnTemperature,
            this.columnEventHorizon});
            this.listViewOutput.HideSelection = false;
            this.listViewOutput.Location = new System.Drawing.Point(28, 190);
            this.listViewOutput.Name = "listViewOutput";
            this.listViewOutput.Size = new System.Drawing.Size(742, 85);
            this.listViewOutput.TabIndex = 27;
            this.listViewOutput.UseCompatibleStateImageBehavior = false;
            this.listViewOutput.View = System.Windows.Forms.View.Details;
            // 
            // columnVelocity
            // 
            this.columnVelocity.Text = "Velocity (m/s)";
            this.columnVelocity.Width = 178;
            // 
            // columnDistance
            // 
            this.columnDistance.Text = "Distance (parsecs)";
            this.columnDistance.Width = 210;
            // 
            // columnTemperature
            // 
            this.columnTemperature.Text = "Kelvin";
            this.columnTemperature.Width = 180;
            // 
            // columnEventHorizon
            // 
            this.columnEventHorizon.Text = "Event Horizon (m)";
            this.columnEventHorizon.Width = 151;
            // 
            // AstroMathClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 304);
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
            this.Text = "Astro Math Client";
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
        private System.Windows.Forms.ToolStripMenuItem menuStripCustomisationDay;
        private System.Windows.Forms.ToolStripMenuItem menuStripCustomisationNight;
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
    }
}

