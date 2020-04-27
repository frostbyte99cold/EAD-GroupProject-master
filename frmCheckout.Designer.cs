namespace GroupProject
{
    partial class frmCheckout
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPurchase = new System.Windows.Forms.Label();
            this.listCheckoutList = new System.Windows.Forms.ListBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubtotalLable = new System.Windows.Forms.Label();
            this.lblTotallabel = new System.Windows.Forms.Label();
            this.lblRemove = new System.Windows.Forms.Label();
            this.lblClear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(230, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHECKOUT";
            // 
            // lblPurchase
            // 
            this.lblPurchase.AutoSize = true;
            this.lblPurchase.BackColor = System.Drawing.Color.Transparent;
            this.lblPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchase.ForeColor = System.Drawing.Color.White;
            this.lblPurchase.Location = new System.Drawing.Point(476, 310);
            this.lblPurchase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPurchase.Name = "lblPurchase";
            this.lblPurchase.Size = new System.Drawing.Size(76, 20);
            this.lblPurchase.TabIndex = 3;
            this.lblPurchase.Text = "Purchase";
            this.lblPurchase.Click += new System.EventHandler(this.lblPurchase_Click);
            // 
            // listCheckoutList
            // 
            this.listCheckoutList.FormattingEnabled = true;
            this.listCheckoutList.Location = new System.Drawing.Point(80, 97);
            this.listCheckoutList.Name = "listCheckoutList";
            this.listCheckoutList.Size = new System.Drawing.Size(254, 147);
            this.listCheckoutList.TabIndex = 4;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.White;
            this.lblSubtotal.Location = new System.Drawing.Point(427, 138);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(51, 20);
            this.lblSubtotal.TabIndex = 5;
            this.lblSubtotal.Text = "label2";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(427, 180);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 20);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "label3";
            // 
            // lblSubtotalLable
            // 
            this.lblSubtotalLable.AutoSize = true;
            this.lblSubtotalLable.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotalLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalLable.ForeColor = System.Drawing.Color.White;
            this.lblSubtotalLable.Location = new System.Drawing.Point(352, 138);
            this.lblSubtotalLable.Name = "lblSubtotalLable";
            this.lblSubtotalLable.Size = new System.Drawing.Size(69, 20);
            this.lblSubtotalLable.TabIndex = 7;
            this.lblSubtotalLable.Text = "Subtotal";
            // 
            // lblTotallabel
            // 
            this.lblTotallabel.AutoSize = true;
            this.lblTotallabel.BackColor = System.Drawing.Color.Transparent;
            this.lblTotallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotallabel.ForeColor = System.Drawing.Color.White;
            this.lblTotallabel.Location = new System.Drawing.Point(367, 180);
            this.lblTotallabel.Name = "lblTotallabel";
            this.lblTotallabel.Size = new System.Drawing.Size(44, 20);
            this.lblTotallabel.TabIndex = 7;
            this.lblTotallabel.Text = "Total";
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.BackColor = System.Drawing.Color.Transparent;
            this.lblRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemove.ForeColor = System.Drawing.Color.White;
            this.lblRemove.Location = new System.Drawing.Point(80, 280);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(68, 20);
            this.lblRemove.TabIndex = 8;
            this.lblRemove.Text = "Remove";
            this.lblRemove.Click += new System.EventHandler(this.lblRemove_Click);
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.BackColor = System.Drawing.Color.Transparent;
            this.lblClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClear.ForeColor = System.Drawing.Color.White;
            this.lblClear.Location = new System.Drawing.Point(154, 280);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(46, 20);
            this.lblClear.TabIndex = 8;
            this.lblClear.Text = "Clear";
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // frmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GroupProject.Properties.Resources.Menu;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.lblTotallabel);
            this.Controls.Add(this.lblSubtotalLable);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.listCheckoutList);
            this.Controls.Add(this.lblPurchase);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCheckout";
            this.Text = "frmCheckout";
            this.Load += new System.EventHandler(this.frmCheckout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPurchase;
        private System.Windows.Forms.ListBox listCheckoutList;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubtotalLable;
        private System.Windows.Forms.Label lblTotallabel;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.Label lblClear;
    }
}