namespace GroupProject
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.lblSalesReview = new System.Windows.Forms.Label();
            this.lblReceipts = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblEditItems = new System.Windows.Forms.Label();
            this.btnAddAdmin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSalesReview
            // 
            this.lblSalesReview.AutoSize = true;
            this.lblSalesReview.BackColor = System.Drawing.Color.Transparent;
            this.lblSalesReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesReview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalesReview.Location = new System.Drawing.Point(234, 136);
            this.lblSalesReview.Name = "lblSalesReview";
            this.lblSalesReview.Size = new System.Drawing.Size(179, 31);
            this.lblSalesReview.TabIndex = 2;
            this.lblSalesReview.Text = "Sales Review";
            this.lblSalesReview.Click += new System.EventHandler(this.lblSalesReview_Click);
            // 
            // lblReceipts
            // 
            this.lblReceipts.AutoSize = true;
            this.lblReceipts.BackColor = System.Drawing.Color.Transparent;
            this.lblReceipts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceipts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblReceipts.Location = new System.Drawing.Point(234, 179);
            this.lblReceipts.Name = "lblReceipts";
            this.lblReceipts.Size = new System.Drawing.Size(121, 31);
            this.lblReceipts.TabIndex = 2;
            this.lblReceipts.Text = "Receipts";
            this.lblReceipts.Click += new System.EventHandler(this.lblReceipts_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMenu.Location = new System.Drawing.Point(234, 262);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(81, 31);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "Menu";
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-13, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 334);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdmin.Location = new System.Drawing.Point(280, 33);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(160, 55);
            this.lblAdmin.TabIndex = 2;
            this.lblAdmin.Text = "Admin";
            this.lblAdmin.Click += new System.EventHandler(this.lblSalesReview_Click);
            // 
            // lblEditItems
            // 
            this.lblEditItems.AutoSize = true;
            this.lblEditItems.BackColor = System.Drawing.Color.Transparent;
            this.lblEditItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditItems.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEditItems.Location = new System.Drawing.Point(234, 222);
            this.lblEditItems.Name = "lblEditItems";
            this.lblEditItems.Size = new System.Drawing.Size(135, 31);
            this.lblEditItems.TabIndex = 2;
            this.lblEditItems.Text = "Edit Items";
            this.lblEditItems.Click += new System.EventHandler(this.lblEditItems_Click);
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.AutoSize = true;
            this.btnAddAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAddAdmin.Location = new System.Drawing.Point(237, 310);
            this.btnAddAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(154, 31);
            this.btnAddAdmin.TabIndex = 101;
            this.btnAddAdmin.Text = "Add Admin";
            this.btnAddAdmin.Visible = false;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GroupProject.Properties.Resources.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddAdmin);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblEditItems);
            this.Controls.Add(this.lblReceipts);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblSalesReview);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalesReview;
        private System.Windows.Forms.Label lblReceipts;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblEditItems;
        private System.Windows.Forms.Label btnAddAdmin;
    }
}