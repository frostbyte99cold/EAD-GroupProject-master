namespace GroupProject
{
    partial class FrmColdBeverage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmColdBeverage));
            System.Windows.Forms.Label itemsLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label amount_AvailabeLabel;
            System.Windows.Forms.Label lblQuantity;
            this.label1 = new System.Windows.Forms.Label();
            this.lblLunch = new System.Windows.Forms.Label();
            this.lblBreakfast = new System.Windows.Forms.Label();
            this.lblColddBeverage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCheckout = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.databaseDataSetColdBeverage = new GroupProject.DatabaseDataSetColdBeverage();
            this.coldBeverageMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coldBeverageMenuTableAdapter = new GroupProject.DatabaseDataSetColdBeverageTableAdapters.ColdBeverageMenuTableAdapter();
            this.tableAdapterManager = new GroupProject.DatabaseDataSetColdBeverageTableAdapters.TableAdapterManager();
            this.coldBeverageMenuBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.itemsLabel1 = new System.Windows.Forms.Label();
            this.priceLabel1 = new System.Windows.Forms.Label();
            this.amount_AvailabeLabel1 = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblAddtoCart = new System.Windows.Forms.Label();
            itemsLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            amount_AvailabeLabel = new System.Windows.Forms.Label();
            lblQuantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetColdBeverage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coldBeverageMenuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coldBeverageMenuBindingNavigator)).BeginInit();
            this.coldBeverageMenuBindingNavigator.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 96;
            this.label1.Text = "Hot Beverage";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLunch
            // 
            this.lblLunch.AutoSize = true;
            this.lblLunch.BackColor = System.Drawing.Color.Transparent;
            this.lblLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLunch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLunch.Location = new System.Drawing.Point(12, 31);
            this.lblLunch.Name = "lblLunch";
            this.lblLunch.Size = new System.Drawing.Size(59, 22);
            this.lblLunch.TabIndex = 97;
            this.lblLunch.Text = "Lunch";
            this.lblLunch.Click += new System.EventHandler(this.lblLunch_Click);
            // 
            // lblBreakfast
            // 
            this.lblBreakfast.AutoSize = true;
            this.lblBreakfast.BackColor = System.Drawing.Color.Transparent;
            this.lblBreakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakfast.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBreakfast.Location = new System.Drawing.Point(12, 9);
            this.lblBreakfast.Name = "lblBreakfast";
            this.lblBreakfast.Size = new System.Drawing.Size(86, 22);
            this.lblBreakfast.TabIndex = 98;
            this.lblBreakfast.Text = "Breakfast";
            this.lblBreakfast.Click += new System.EventHandler(this.lblBreakfast_Click);
            // 
            // lblColddBeverage
            // 
            this.lblColddBeverage.AutoSize = true;
            this.lblColddBeverage.BackColor = System.Drawing.Color.Transparent;
            this.lblColddBeverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColddBeverage.ForeColor = System.Drawing.SystemColors.Control;
            this.lblColddBeverage.Location = new System.Drawing.Point(344, 61);
            this.lblColddBeverage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColddBeverage.Name = "lblColddBeverage";
            this.lblColddBeverage.Size = new System.Drawing.Size(356, 55);
            this.lblColddBeverage.TabIndex = 76;
            this.lblColddBeverage.Text = "Cold Beverage";
            this.lblColddBeverage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 334);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            // 
            // lblCheckout
            // 
            this.lblCheckout.AutoSize = true;
            this.lblCheckout.BackColor = System.Drawing.Color.Transparent;
            this.lblCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckout.ForeColor = System.Drawing.Color.White;
            this.lblCheckout.Location = new System.Drawing.Point(646, 31);
            this.lblCheckout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckout.Name = "lblCheckout";
            this.lblCheckout.Size = new System.Drawing.Size(143, 26);
            this.lblCheckout.TabIndex = 100;
            this.lblCheckout.Text = "CHECKOUT";
            this.lblCheckout.Click += new System.EventHandler(this.lblCheckout_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.BackColor = System.Drawing.Color.Transparent;
            this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.ForeColor = System.Drawing.Color.White;
            this.lblDelete.Location = new System.Drawing.Point(230, 404);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(62, 20);
            this.lblDelete.TabIndex = 103;
            this.lblDelete.Text = "Delete";
            this.lblDelete.Visible = false;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.Color.White;
            this.lblAdd.Location = new System.Drawing.Point(107, 404);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(117, 20);
            this.lblAdd.TabIndex = 104;
            this.lblAdd.Text = "Add new item";
            this.lblAdd.Visible = false;
            this.lblAdd.Click += new System.EventHandler(this.lblAdd_Click);
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.ForeColor = System.Drawing.Color.White;
            this.lblUpdate.Location = new System.Drawing.Point(33, 404);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(68, 20);
            this.lblUpdate.TabIndex = 105;
            this.lblUpdate.Text = "Update";
            this.lblUpdate.Visible = false;
            // 
            // databaseDataSetColdBeverage
            // 
            this.databaseDataSetColdBeverage.DataSetName = "DatabaseDataSetColdBeverage";
            this.databaseDataSetColdBeverage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coldBeverageMenuBindingSource
            // 
            this.coldBeverageMenuBindingSource.DataMember = "ColdBeverageMenu";
            this.coldBeverageMenuBindingSource.DataSource = this.databaseDataSetColdBeverage;
            // 
            // coldBeverageMenuTableAdapter
            // 
            this.coldBeverageMenuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ColdBeverageMenuTableAdapter = this.coldBeverageMenuTableAdapter;
            this.tableAdapterManager.UpdateOrder = GroupProject.DatabaseDataSetColdBeverageTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // coldBeverageMenuBindingNavigator
            // 
            this.coldBeverageMenuBindingNavigator.AddNewItem = null;
            this.coldBeverageMenuBindingNavigator.BindingSource = this.coldBeverageMenuBindingSource;
            this.coldBeverageMenuBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.coldBeverageMenuBindingNavigator.DeleteItem = null;
            this.coldBeverageMenuBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.coldBeverageMenuBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.coldBeverageMenuBindingNavigator.Location = new System.Drawing.Point(3, 0);
            this.coldBeverageMenuBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.coldBeverageMenuBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.coldBeverageMenuBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.coldBeverageMenuBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.coldBeverageMenuBindingNavigator.Name = "coldBeverageMenuBindingNavigator";
            this.coldBeverageMenuBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.coldBeverageMenuBindingNavigator.Size = new System.Drawing.Size(209, 25);
            this.coldBeverageMenuBindingNavigator.TabIndex = 106;
            this.coldBeverageMenuBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // itemsLabel
            // 
            itemsLabel.AutoSize = true;
            itemsLabel.BackColor = System.Drawing.Color.Transparent;
            itemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            itemsLabel.ForeColor = System.Drawing.Color.White;
            itemsLabel.Location = new System.Drawing.Point(70, 139);
            itemsLabel.Name = "itemsLabel";
            itemsLabel.Size = new System.Drawing.Size(53, 20);
            itemsLabel.TabIndex = 108;
            itemsLabel.Text = "Items:";
            // 
            // itemsLabel1
            // 
            this.itemsLabel1.BackColor = System.Drawing.Color.Transparent;
            this.itemsLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coldBeverageMenuBindingSource, "Items", true));
            this.itemsLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsLabel1.ForeColor = System.Drawing.Color.White;
            this.itemsLabel1.Location = new System.Drawing.Point(204, 139);
            this.itemsLabel1.Name = "itemsLabel1";
            this.itemsLabel1.Size = new System.Drawing.Size(100, 23);
            this.itemsLabel1.TabIndex = 109;
            this.itemsLabel1.Text = "label2";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.BackColor = System.Drawing.Color.Transparent;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priceLabel.ForeColor = System.Drawing.Color.White;
            priceLabel.Location = new System.Drawing.Point(70, 162);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(48, 20);
            priceLabel.TabIndex = 110;
            priceLabel.Text = "Price:";
            // 
            // priceLabel1
            // 
            this.priceLabel1.BackColor = System.Drawing.Color.Transparent;
            this.priceLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coldBeverageMenuBindingSource, "Price", true));
            this.priceLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel1.ForeColor = System.Drawing.Color.White;
            this.priceLabel1.Location = new System.Drawing.Point(204, 162);
            this.priceLabel1.Name = "priceLabel1";
            this.priceLabel1.Size = new System.Drawing.Size(100, 23);
            this.priceLabel1.TabIndex = 111;
            this.priceLabel1.Text = "label2";
            // 
            // amount_AvailabeLabel
            // 
            amount_AvailabeLabel.AutoSize = true;
            amount_AvailabeLabel.BackColor = System.Drawing.Color.Transparent;
            amount_AvailabeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            amount_AvailabeLabel.ForeColor = System.Drawing.Color.White;
            amount_AvailabeLabel.Location = new System.Drawing.Point(70, 185);
            amount_AvailabeLabel.Name = "amount_AvailabeLabel";
            amount_AvailabeLabel.Size = new System.Drawing.Size(133, 20);
            amount_AvailabeLabel.TabIndex = 112;
            amount_AvailabeLabel.Text = "Amount Availabe:";
            // 
            // amount_AvailabeLabel1
            // 
            this.amount_AvailabeLabel1.BackColor = System.Drawing.Color.Transparent;
            this.amount_AvailabeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coldBeverageMenuBindingSource, "Amount Availabe", true));
            this.amount_AvailabeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_AvailabeLabel1.ForeColor = System.Drawing.Color.White;
            this.amount_AvailabeLabel1.Location = new System.Drawing.Point(204, 185);
            this.amount_AvailabeLabel1.Name = "amount_AvailabeLabel1";
            this.amount_AvailabeLabel1.Size = new System.Drawing.Size(100, 23);
            this.amount_AvailabeLabel1.TabIndex = 113;
            this.amount_AvailabeLabel1.Text = "label2";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.numQuantity);
            this.toolStripContainer1.ContentPanel.Controls.Add(lblQuantity);
            this.toolStripContainer1.ContentPanel.Controls.Add(amount_AvailabeLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(itemsLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.amount_AvailabeLabel1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.itemsLabel1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.priceLabel1);
            this.toolStripContainer1.ContentPanel.Controls.Add(priceLabel);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(346, 244);
            this.toolStripContainer1.Location = new System.Drawing.Point(354, 128);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(346, 269);
            this.toolStripContainer1.TabIndex = 114;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.coldBeverageMenuBindingNavigator);
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(167, 217);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(54, 20);
            this.numQuantity.TabIndex = 115;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = System.Drawing.Color.Transparent;
            lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblQuantity.ForeColor = System.Drawing.Color.White;
            lblQuantity.Location = new System.Drawing.Point(70, 214);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new System.Drawing.Size(68, 20);
            lblQuantity.TabIndex = 114;
            lblQuantity.Text = "Quantity";
            // 
            // lblAddtoCart
            // 
            this.lblAddtoCart.AutoSize = true;
            this.lblAddtoCart.BackColor = System.Drawing.Color.Transparent;
            this.lblAddtoCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddtoCart.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddtoCart.Location = new System.Drawing.Point(452, 404);
            this.lblAddtoCart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddtoCart.Name = "lblAddtoCart";
            this.lblAddtoCart.Size = new System.Drawing.Size(105, 20);
            this.lblAddtoCart.TabIndex = 115;
            this.lblAddtoCart.Text = "Add To Cart";
            this.lblAddtoCart.Click += new System.EventHandler(this.lblAddtoCart_Click);
            // 
            // FrmColdBeverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GroupProject.Properties.Resources.Menu;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.lblAddtoCart);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.lblCheckout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLunch);
            this.Controls.Add(this.lblBreakfast);
            this.Controls.Add(this.lblColddBeverage);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmColdBeverage";
            this.Text = "Cold Bevrage";
            this.Load += new System.EventHandler(this.FrmColdBeverage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetColdBeverage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coldBeverageMenuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coldBeverageMenuBindingNavigator)).EndInit();
            this.coldBeverageMenuBindingNavigator.ResumeLayout(false);
            this.coldBeverageMenuBindingNavigator.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLunch;
        private System.Windows.Forms.Label lblBreakfast;
        private System.Windows.Forms.Label lblColddBeverage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCheckout;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblUpdate;
        private DatabaseDataSetColdBeverage databaseDataSetColdBeverage;
        private System.Windows.Forms.BindingSource coldBeverageMenuBindingSource;
        private DatabaseDataSetColdBeverageTableAdapters.ColdBeverageMenuTableAdapter coldBeverageMenuTableAdapter;
        private DatabaseDataSetColdBeverageTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator coldBeverageMenuBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label itemsLabel1;
        private System.Windows.Forms.Label priceLabel1;
        private System.Windows.Forms.Label amount_AvailabeLabel1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblAddtoCart;
    }
}