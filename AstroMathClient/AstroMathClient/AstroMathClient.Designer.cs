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
            this.textBoxObservedWavelength = new System.Windows.Forms.TextBox();
            this.textBoxRestWavelength = new System.Windows.Forms.TextBox();
            this.buttonCalculateStarVelocity = new System.Windows.Forms.Button();
            this.textBoxStarVelocity = new System.Windows.Forms.TextBox();
            this.labelStarVelocity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxObservedWavelength
            // 
            this.textBoxObservedWavelength.Location = new System.Drawing.Point(61, 93);
            this.textBoxObservedWavelength.Name = "textBoxObservedWavelength";
            this.textBoxObservedWavelength.Size = new System.Drawing.Size(100, 20);
            this.textBoxObservedWavelength.TabIndex = 0;
            // 
            // textBoxRestWavelength
            // 
            this.textBoxRestWavelength.Location = new System.Drawing.Point(167, 93);
            this.textBoxRestWavelength.Name = "textBoxRestWavelength";
            this.textBoxRestWavelength.Size = new System.Drawing.Size(100, 20);
            this.textBoxRestWavelength.TabIndex = 1;
            // 
            // buttonCalculateStarVelocity
            // 
            this.buttonCalculateStarVelocity.Location = new System.Drawing.Point(273, 91);
            this.buttonCalculateStarVelocity.Name = "buttonCalculateStarVelocity";
            this.buttonCalculateStarVelocity.Size = new System.Drawing.Size(91, 23);
            this.buttonCalculateStarVelocity.TabIndex = 2;
            this.buttonCalculateStarVelocity.Text = "CALCULATE";
            this.buttonCalculateStarVelocity.UseVisualStyleBackColor = true;
            this.buttonCalculateStarVelocity.Click += new System.EventHandler(this.buttonCalculateStarVelocity_Click);
            // 
            // textBoxStarVelocity
            // 
            this.textBoxStarVelocity.Location = new System.Drawing.Point(370, 93);
            this.textBoxStarVelocity.Name = "textBoxStarVelocity";
            this.textBoxStarVelocity.Size = new System.Drawing.Size(100, 20);
            this.textBoxStarVelocity.TabIndex = 3;
            // 
            // labelStarVelocity
            // 
            this.labelStarVelocity.AutoSize = true;
            this.labelStarVelocity.Location = new System.Drawing.Point(58, 67);
            this.labelStarVelocity.Name = "labelStarVelocity";
            this.labelStarVelocity.Size = new System.Drawing.Size(91, 13);
            this.labelStarVelocity.TabIndex = 4;
            this.labelStarVelocity.Text = "STAR VELOCITY";
            // 
            // AstroMathClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.labelStarVelocity);
            this.Controls.Add(this.textBoxStarVelocity);
            this.Controls.Add(this.buttonCalculateStarVelocity);
            this.Controls.Add(this.textBoxRestWavelength);
            this.Controls.Add(this.textBoxObservedWavelength);
            this.Name = "AstroMathClient";
            this.Text = "Astro Math Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxObservedWavelength;
        private System.Windows.Forms.TextBox textBoxRestWavelength;
        private System.Windows.Forms.Button buttonCalculateStarVelocity;
        private System.Windows.Forms.TextBox textBoxStarVelocity;
        private System.Windows.Forms.Label labelStarVelocity;
    }
}

