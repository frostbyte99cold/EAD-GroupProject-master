namespace GroupProject
{
    partial class FrmBreakfastBeverage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBreakfastBeverage));
            this.lblBeverage = new System.Windows.Forms.Label();
            this.lblBreakFast = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MyItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBeverage
            // 
            this.lblBeverage.AutoSize = true;
            this.lblBeverage.BackColor = System.Drawing.Color.Transparent;
            this.lblBeverage.Font = new System.Drawing.Font("Film Cryptic Oblique", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeverage.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBeverage.Location = new System.Drawing.Point(314, 112);
            this.lblBeverage.Name = "lblBeverage";
            this.lblBeverage.Size = new System.Drawing.Size(251, 61);
            this.lblBeverage.TabIndex = 23;
            this.lblBeverage.Text = "&Beverage";
            this.lblBeverage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBreakFast
            // 
            this.lblBreakFast.AutoSize = true;
            this.lblBreakFast.BackColor = System.Drawing.Color.Transparent;
            this.lblBreakFast.Font = new System.Drawing.Font("Film Cryptic Oblique", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakFast.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBreakFast.Location = new System.Drawing.Point(314, 32);
            this.lblBreakFast.Name = "lblBreakFast";
            this.lblBreakFast.Size = new System.Drawing.Size(268, 61);
            this.lblBreakFast.TabIndex = 24;
            this.lblBreakFast.Text = "Breakfast";
            this.lblBreakFast.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(41, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(790, 150);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            this.Item.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MyItem,
            this.MyPrice});
            this.dataGridView2.Location = new System.Drawing.Point(50, 404);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(781, 150);
            this.dataGridView2.TabIndex = 26;
            // 
            // MyItem
            // 
            this.MyItem.HeaderText = "My Item";
            this.MyItem.MinimumWidth = 6;
            this.MyItem.Name = "MyItem";
            this.MyItem.Width = 125;
            // 
            // MyPrice
            // 
            this.MyPrice.HeaderText = "Price";
            this.MyPrice.MinimumWidth = 6;
            this.MyPrice.Name = "MyPrice";
            this.MyPrice.Width = 125;
            // 
            // FrmBreakfastBeverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(939, 802);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblBreakFast);
            this.Controls.Add(this.lblBeverage);
            this.Font = new System.Drawing.Font("Film Cryptic Oblique", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmBreakfastBeverage";
            this.Text = "Breakfast Beverage";
            this.Load += new System.EventHandler(this.FrmBreakfastBeverage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBeverage;
        private System.Windows.Forms.Label lblBreakFast;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MyPrice;
    }
}