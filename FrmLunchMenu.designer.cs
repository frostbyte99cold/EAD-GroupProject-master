namespace GroupProject
{
    partial class FrmLunchMenu
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
            System.Windows.Forms.Label itemsLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label amount_AvailabeLabel;
            System.Windows.Forms.Label lblQuantity;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLunchMenu));
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblLunch = new System.Windows.Forms.Label();
            this.lblColdBeverageSwitch = new System.Windows.Forms.Label();
            this.lblHotBeverageSwitch = new System.Windows.Forms.Label();
            this.lblBreakfastSwitch = new System.Windows.Forms.Label();
            this.lblCheckout = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.databaseDataSetLunchMenu = new GroupProject.DatabaseDataSetLunchMenu();
            this.lunchMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lunchMenuTableAdapter = new GroupProject.DatabaseDataSetLunchMenuTableAdapters.LunchMenuTableAdapter();
            this.tableAdapterManager = new GroupProject.DatabaseDataSetLunchMenuTableAdapters.TableAdapterManager();
            this.lunchMenuBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetLunchMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunchMenuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunchMenuBindingNavigator)).BeginInit();
            this.lunchMenuBindingNavigator.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // itemsLabel
            // 
            itemsLabel.AutoSize = true;
            itemsLabel.BackColor = System.Drawing.Color.Transparent;
            itemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            itemsLabel.ForeColor = System.Drawing.Color.White;
            itemsLabel.Location = new System.Drawing.Point(33, 170);
            itemsLabel.Name = "itemsLabel";
            itemsLabel.Size = new System.Drawing.Size(53, 20);
            itemsLabel.TabIndex = 105;
            itemsLabel.Text = "Items:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.BackColor = System.Drawing.Color.Transparent;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priceLabel.ForeColor = System.Drawing.Color.White;
            priceLabel.Location = new System.Drawing.Point(33, 193);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(48, 20);
            priceLabel.TabIndex = 107;
            priceLabel.Text = "Price:";
            // 
            // amount_AvailabeLabel
            // 
            amount_AvailabeLabel.AutoSize = true;
            amount_AvailabeLabel.BackColor = System.Drawing.Color.Transparent;
            amount_AvailabeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            amount_AvailabeLabel.ForeColor = System.Drawing.Color.White;
            amount_AvailabeLabel.Location = new System.Drawing.Point(33, 216);
            amount_AvailabeLabel.Name = "amount_AvailabeLabel";
            amount_AvailabeLabel.Size = new System.Drawing.Size(133, 20);
            amount_AvailabeLabel.TabIndex = 109;
            amount_AvailabeLabel.Text = "Amount Availabe:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = System.Drawing.Color.Transparent;
            lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblQuantity.ForeColor = System.Drawing.Color.White;
            lblQuantity.Location = new System.Drawing.Point(33, 242);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new System.Drawing.Size(68, 20);
            lblQuantity.TabIndex = 111;
            lblQuantity.Text = "Quantity";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLogin.Location = new System.Drawing.Point(285, 80);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(157, 55);
            this.lblLogin.TabIndex = 37;
            this.lblLogin.Text = "&Meals";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLunch
            // 
            this.lblLunch.AutoSize = true;
            this.lblLunch.BackColor = System.Drawing.Color.Transparent;
            this.lblLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLunch.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLunch.Location = new System.Drawing.Point(282, 23);
            this.lblLunch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLunch.Name = "lblLunch";
            this.lblLunch.Size = new System.Drawing.Size(161, 55);
            this.lblLunch.TabIndex = 36;
            this.lblLunch.Text = "Lunch";
            this.lblLunch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblColdBeverageSwitch
            // 
            this.lblColdBeverageSwitch.AutoSize = true;
            this.lblColdBeverageSwitch.BackColor = System.Drawing.Color.Transparent;
            this.lblColdBeverageSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColdBeverageSwitch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblColdBeverageSwitch.Location = new System.Drawing.Point(12, 53);
            this.lblColdBeverageSwitch.Name = "lblColdBeverageSwitch";
            this.lblColdBeverageSwitch.Size = new System.Drawing.Size(129, 22);
            this.lblColdBeverageSwitch.TabIndex = 79;
            this.lblColdBeverageSwitch.Text = "Cold Beverage";
            this.lblColdBeverageSwitch.Click += new System.EventHandler(this.lblColdBeverageSwitch_Click);
            // 
            // lblHotBeverageSwitch
            // 
            this.lblHotBeverageSwitch.AutoSize = true;
            this.lblHotBeverageSwitch.BackColor = System.Drawing.Color.Transparent;
            this.lblHotBeverageSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotBeverageSwitch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHotBeverageSwitch.Location = new System.Drawing.Point(12, 31);
            this.lblHotBeverageSwitch.Name = "lblHotBeverageSwitch";
            this.lblHotBeverageSwitch.Size = new System.Drawing.Size(120, 22);
            this.lblHotBeverageSwitch.TabIndex = 80;
            this.lblHotBeverageSwitch.Text = "Hot Beverage";
            this.lblHotBeverageSwitch.Click += new System.EventHandler(this.lblHotBeverageSwitch_Click);
            // 
            // lblBreakfastSwitch
            // 
            this.lblBreakfastSwitch.AutoSize = true;
            this.lblBreakfastSwitch.BackColor = System.Drawing.Color.Transparent;
            this.lblBreakfastSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakfastSwitch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBreakfastSwitch.Location = new System.Drawing.Point(12, 9);
            this.lblBreakfastSwitch.Name = "lblBreakfastSwitch";
            this.lblBreakfastSwitch.Size = new System.Drawing.Size(86, 22);
            this.lblBreakfastSwitch.TabIndex = 82;
            this.lblBreakfastSwitch.Text = "Breakfast";
            this.lblBreakfastSwitch.Click += new System.EventHandler(this.lblBreakfastSwitch_Click);
            // 
            // lblCheckout
            // 
            this.lblCheckout.AutoSize = true;
            this.lblCheckout.BackColor = System.Drawing.Color.Transparent;
            this.lblCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckout.ForeColor = System.Drawing.Color.White;
            this.lblCheckout.Location = new System.Drawing.Point(488, 31);
            this.lblCheckout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckout.Name = "lblCheckout";
            this.lblCheckout.Size = new System.Drawing.Size(143, 26);
            this.lblCheckout.TabIndex = 99;
            this.lblCheckout.Text = "CHECKOUT";
            this.lblCheckout.Click += new System.EventHandler(this.lblCheckout_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.BackColor = System.Drawing.Color.Transparent;
            this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.ForeColor = System.Drawing.Color.White;
            this.lblDelete.Location = new System.Drawing.Point(203, 477);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(62, 20);
            this.lblDelete.TabIndex = 100;
            this.lblDelete.Text = "Delete";
            this.lblDelete.Visible = false;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.Color.White;
            this.lblAdd.Location = new System.Drawing.Point(80, 477);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(117, 20);
            this.lblAdd.TabIndex = 101;
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
            this.lblUpdate.Location = new System.Drawing.Point(6, 477);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(68, 20);
            this.lblUpdate.TabIndex = 102;
            this.lblUpdate.Text = "Update";
            this.lblUpdate.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-30, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            // 
            // databaseDataSetLunchMenu
            // 
            this.databaseDataSetLunchMenu.DataSetName = "DatabaseDataSetLunchMenu";
            this.databaseDataSetLunchMenu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lunchMenuBindingSource
            // 
            this.lunchMenuBindingSource.DataMember = "LunchMenu";
            this.lunchMenuBindingSource.DataSource = this.databaseDataSetLunchMenu;
            // 
            // lunchMenuTableAdapter
            // 
            this.lunchMenuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LunchMenuTableAdapter = this.lunchMenuTableAdapter;
            this.tableAdapterManager.UpdateOrder = GroupProject.DatabaseDataSetLunchMenuTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lunchMenuBindingNavigator
            // 
            this.lunchMenuBindingNavigator.AddNewItem = null;
            this.lunchMenuBindingNavigator.BindingSource = this.lunchMenuBindingSource;
            this.lunchMenuBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lunchMenuBindingNavigator.DeleteItem = null;
            this.lunchMenuBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.lunchMenuBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.lunchMenuBindingNavigator.Location = new System.Drawing.Point(34, 0);
            this.lunchMenuBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lunchMenuBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lunchMenuBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lunchMenuBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lunchMenuBindingNavigator.Name = "lunchMenuBindingNavigator";
            this.lunchMenuBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lunchMenuBindingNavigator.Size = new System.Drawing.Size(209, 25);
            this.lunchMenuBindingNavigator.TabIndex = 103;
            this.lunchMenuBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // itemsLabel1
            // 
            this.itemsLabel1.BackColor = System.Drawing.Color.Transparent;
            this.itemsLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lunchMenuBindingSource, "Items", true));
            this.itemsLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsLabel1.ForeColor = System.Drawing.Color.White;
            this.itemsLabel1.Location = new System.Drawing.Point(172, 170);
            this.itemsLabel1.Name = "itemsLabel1";
            this.itemsLabel1.Size = new System.Drawing.Size(100, 23);
            this.itemsLabel1.TabIndex = 106;
            this.itemsLabel1.Text = "label1";
            // 
            // priceLabel1
            // 
            this.priceLabel1.BackColor = System.Drawing.Color.Transparent;
            this.priceLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lunchMenuBindingSource, "Price", true));
            this.priceLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel1.ForeColor = System.Drawing.Color.White;
            this.priceLabel1.Location = new System.Drawing.Point(172, 193);
            this.priceLabel1.Name = "priceLabel1";
            this.priceLabel1.Size = new System.Drawing.Size(100, 23);
            this.priceLabel1.TabIndex = 108;
            this.priceLabel1.Text = "label1";
            // 
            // amount_AvailabeLabel1
            // 
            this.amount_AvailabeLabel1.BackColor = System.Drawing.Color.Transparent;
            this.amount_AvailabeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lunchMenuBindingSource, "Amount Availabe", true));
            this.amount_AvailabeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_AvailabeLabel1.ForeColor = System.Drawing.Color.White;
            this.amount_AvailabeLabel1.Location = new System.Drawing.Point(172, 216);
            this.amount_AvailabeLabel1.Name = "amount_AvailabeLabel1";
            this.amount_AvailabeLabel1.Size = new System.Drawing.Size(100, 23);
            this.amount_AvailabeLabel1.TabIndex = 110;
            this.amount_AvailabeLabel1.Text = "label1";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.numQuantity);
            this.toolStripContainer1.ContentPanel.Controls.Add(lblQuantity);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lunchMenuBindingNavigator);
            this.toolStripContainer1.ContentPanel.Controls.Add(itemsLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.amount_AvailabeLabel1);
            this.toolStripContainer1.ContentPanel.Controls.Add(amount_AvailabeLabel);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.priceLabel1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.itemsLabel1);
            this.toolStripContainer1.ContentPanel.Controls.Add(priceLabel);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(320, 270);
            this.toolStripContainer1.Location = new System.Drawing.Point(357, 150);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(320, 295);
            this.toolStripContainer1.TabIndex = 111;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.Color.Transparent;
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(166, 242);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(54, 20);
            this.numQuantity.TabIndex = 112;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAddtoCart
            // 
            this.lblAddtoCart.AutoSize = true;
            this.lblAddtoCart.BackColor = System.Drawing.Color.Transparent;
            this.lblAddtoCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddtoCart.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddtoCart.Location = new System.Drawing.Point(461, 477);
            this.lblAddtoCart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddtoCart.Name = "lblAddtoCart";
            this.lblAddtoCart.Size = new System.Drawing.Size(105, 20);
            this.lblAddtoCart.TabIndex = 113;
            this.lblAddtoCart.Text = "Add To Cart";
            this.lblAddtoCart.Click += new System.EventHandler(this.lblAddtoCart_Click);
            // 
            // FrmLunchMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(689, 517);
            this.Controls.Add(this.lblAddtoCart);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.lblCheckout);
            this.Controls.Add(this.lblColdBeverageSwitch);
            this.Controls.Add(this.lblHotBeverageSwitch);
            this.Controls.Add(this.lblBreakfastSwitch);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblLunch);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmLunchMenu";
            this.Text = "FrmLunchMenu";
            this.Load += new System.EventHandler(this.FrmLunchMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetLunchMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunchMenuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunchMenuBindingNavigator)).EndInit();
            this.lunchMenuBindingNavigator.ResumeLayout(false);
            this.lunchMenuBindingNavigator.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblLunch;
        private System.Windows.Forms.Label lblColdBeverageSwitch;
        private System.Windows.Forms.Label lblHotBeverageSwitch;
        private System.Windows.Forms.Label lblBreakfastSwitch;
        private System.Windows.Forms.Label lblCheckout;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DatabaseDataSetLunchMenu databaseDataSetLunchMenu;
        private System.Windows.Forms.BindingSource lunchMenuBindingSource;
        private DatabaseDataSetLunchMenuTableAdapters.LunchMenuTableAdapter lunchMenuTableAdapter;
        private DatabaseDataSetLunchMenuTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lunchMenuBindingNavigator;
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