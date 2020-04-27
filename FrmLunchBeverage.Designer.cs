namespace GroupProject
{
    partial class FrmLunchBeverage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLunchBeverage));
            this.lblBeverage = new System.Windows.Forms.Label();
            this.lblLunch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBeverage
            // 
            this.lblBeverage.AutoSize = true;
            this.lblBeverage.BackColor = System.Drawing.Color.Transparent;
            this.lblBeverage.Font = new System.Drawing.Font("Film Cryptic Oblique", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeverage.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBeverage.Location = new System.Drawing.Point(313, 97);
            this.lblBeverage.Name = "lblBeverage";
            this.lblBeverage.Size = new System.Drawing.Size(251, 61);
            this.lblBeverage.TabIndex = 22;
            this.lblBeverage.Text = "&Beverage";
            this.lblBeverage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLunch
            // 
            this.lblLunch.AutoSize = true;
            this.lblLunch.BackColor = System.Drawing.Color.Transparent;
            this.lblLunch.Font = new System.Drawing.Font("Film Cryptic Oblique", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLunch.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLunch.Location = new System.Drawing.Point(357, 24);
            this.lblLunch.Name = "lblLunch";
            this.lblLunch.Size = new System.Drawing.Size(164, 61);
            this.lblLunch.TabIndex = 38;
            this.lblLunch.Text = "Lunch";
            this.lblLunch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmLunchBeverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(979, 801);
            this.Controls.Add(this.lblLunch);
            this.Controls.Add(this.lblBeverage);
            this.Font = new System.Drawing.Font("Film Cryptic Oblique", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLunchBeverage";
            this.Text = "Lunch Beverage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBeverage;
        private System.Windows.Forms.Label lblLunch;
    }
}