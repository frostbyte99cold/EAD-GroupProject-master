namespace GroupProject
{
    partial class frmOrderList
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
            System.Windows.Forms.Label orderIdLabel;
            System.Windows.Forms.Label customerUserNameLabel;
            System.Windows.Forms.Label orderItemLabel;
            System.Windows.Forms.Label totalPriceLabel;
            System.Windows.Forms.Label dateandTimeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderList));
            this.label1 = new System.Windows.Forms.Label();
            this.orderTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.orderIdLabel1 = new System.Windows.Forms.Label();
            this.customerUserNameLabel1 = new System.Windows.Forms.Label();
            this.orderItemLabel1 = new System.Windows.Forms.Label();
            this.totalPriceLabel1 = new System.Windows.Forms.Label();
            this.dateandTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.orderTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSetOrderTable = new GroupProject.DatabaseDataSetOrderTable();
            this.orderTableTableAdapter = new GroupProject.DatabaseDataSetOrderTableTableAdapters.OrderTableTableAdapter();
            this.tableAdapterManager = new GroupProject.DatabaseDataSetOrderTableTableAdapters.TableAdapterManager();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.orderTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.lblReady = new System.Windows.Forms.Label();
            orderIdLabel = new System.Windows.Forms.Label();
            customerUserNameLabel = new System.Windows.Forms.Label();
            orderItemLabel = new System.Windows.Forms.Label();
            totalPriceLabel = new System.Windows.Forms.Label();
            dateandTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderTableBindingNavigator)).BeginInit();
            this.orderTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetOrderTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(337, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ORDERS";
            // 
            // orderTableBindingNavigator
            // 
            this.orderTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.orderTableBindingNavigator.BindingSource = this.orderTableBindingSource;
            this.orderTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.orderTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.orderTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.orderTableBindingNavigatorSaveItem});
            this.orderTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.orderTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.orderTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.orderTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.orderTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.orderTableBindingNavigator.Name = "orderTableBindingNavigator";
            this.orderTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.orderTableBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.orderTableBindingNavigator.TabIndex = 1;
            this.orderTableBindingNavigator.Text = "bindingNavigator1";
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
            // orderIdLabel
            // 
            orderIdLabel.AutoSize = true;
            orderIdLabel.Location = new System.Drawing.Point(66, 135);
            orderIdLabel.Name = "orderIdLabel";
            orderIdLabel.Size = new System.Drawing.Size(48, 13);
            orderIdLabel.TabIndex = 2;
            orderIdLabel.Text = "Order Id:";
            // 
            // orderIdLabel1
            // 
            this.orderIdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderTableBindingSource, "OrderId", true));
            this.orderIdLabel1.Location = new System.Drawing.Point(141, 135);
            this.orderIdLabel1.Name = "orderIdLabel1";
            this.orderIdLabel1.Size = new System.Drawing.Size(200, 23);
            this.orderIdLabel1.TabIndex = 3;
            this.orderIdLabel1.Text = "label2";
            // 
            // customerUserNameLabel
            // 
            customerUserNameLabel.AutoSize = true;
            customerUserNameLabel.Location = new System.Drawing.Point(364, 135);
            customerUserNameLabel.Name = "customerUserNameLabel";
            customerUserNameLabel.Size = new System.Drawing.Size(110, 13);
            customerUserNameLabel.TabIndex = 4;
            customerUserNameLabel.Text = "Customer User Name:";
            // 
            // customerUserNameLabel1
            // 
            this.customerUserNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderTableBindingSource, "CustomerUserName", true));
            this.customerUserNameLabel1.Location = new System.Drawing.Point(480, 135);
            this.customerUserNameLabel1.Name = "customerUserNameLabel1";
            this.customerUserNameLabel1.Size = new System.Drawing.Size(221, 23);
            this.customerUserNameLabel1.TabIndex = 5;
            this.customerUserNameLabel1.Text = "label2";
            // 
            // orderItemLabel
            // 
            orderItemLabel.AutoSize = true;
            orderItemLabel.Location = new System.Drawing.Point(155, 169);
            orderItemLabel.Name = "orderItemLabel";
            orderItemLabel.Size = new System.Drawing.Size(59, 13);
            orderItemLabel.TabIndex = 6;
            orderItemLabel.Text = "Order Item:";
            // 
            // orderItemLabel1
            // 
            this.orderItemLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderTableBindingSource, "OrderItem", true));
            this.orderItemLabel1.Location = new System.Drawing.Point(66, 191);
            this.orderItemLabel1.Name = "orderItemLabel1";
            this.orderItemLabel1.Size = new System.Drawing.Size(275, 216);
            this.orderItemLabel1.TabIndex = 7;
            this.orderItemLabel1.Text = "label2";
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Location = new System.Drawing.Point(364, 191);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new System.Drawing.Size(61, 13);
            totalPriceLabel.TabIndex = 8;
            totalPriceLabel.Text = "Total Price:";
            // 
            // totalPriceLabel1
            // 
            this.totalPriceLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderTableBindingSource, "TotalPrice", true));
            this.totalPriceLabel1.Location = new System.Drawing.Point(480, 191);
            this.totalPriceLabel1.Name = "totalPriceLabel1";
            this.totalPriceLabel1.Size = new System.Drawing.Size(221, 23);
            this.totalPriceLabel1.TabIndex = 9;
            this.totalPriceLabel1.Text = "label2";
            // 
            // dateandTimeLabel
            // 
            dateandTimeLabel.AutoSize = true;
            dateandTimeLabel.Location = new System.Drawing.Point(364, 221);
            dateandTimeLabel.Name = "dateandTimeLabel";
            dateandTimeLabel.Size = new System.Drawing.Size(77, 13);
            dateandTimeLabel.TabIndex = 10;
            dateandTimeLabel.Text = "Dateand Time:";
            // 
            // dateandTimeDateTimePicker
            // 
            this.dateandTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderTableBindingSource, "DateandTime", true));
            this.dateandTimeDateTimePicker.Location = new System.Drawing.Point(480, 217);
            this.dateandTimeDateTimePicker.Name = "dateandTimeDateTimePicker";
            this.dateandTimeDateTimePicker.Size = new System.Drawing.Size(221, 20);
            this.dateandTimeDateTimePicker.TabIndex = 11;
            this.dateandTimeDateTimePicker.Value = new System.DateTime(2020, 4, 15, 12, 58, 26, 0);
            // 
            // orderTableBindingSource
            // 
            this.orderTableBindingSource.DataMember = "OrderTable";
            this.orderTableBindingSource.DataSource = this.databaseDataSetOrderTable;
            // 
            // databaseDataSetOrderTable
            // 
            this.databaseDataSetOrderTable.DataSetName = "DatabaseDataSetOrderTable";
            this.databaseDataSetOrderTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderTableTableAdapter
            // 
            this.orderTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrderTableTableAdapter = this.orderTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = GroupProject.DatabaseDataSetOrderTableTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // orderTableBindingNavigatorSaveItem
            // 
            this.orderTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orderTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("orderTableBindingNavigatorSaveItem.Image")));
            this.orderTableBindingNavigatorSaveItem.Name = "orderTableBindingNavigatorSaveItem";
            this.orderTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.orderTableBindingNavigatorSaveItem.Text = "Save Data";
            this.orderTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.orderTableBindingNavigatorSaveItem_Click_1);
            // 
            // lblReady
            // 
            this.lblReady.AutoSize = true;
            this.lblReady.BackColor = System.Drawing.Color.Transparent;
            this.lblReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReady.ForeColor = System.Drawing.Color.White;
            this.lblReady.Location = new System.Drawing.Point(423, 342);
            this.lblReady.Name = "lblReady";
            this.lblReady.Size = new System.Drawing.Size(157, 24);
            this.lblReady.TabIndex = 14;
            this.lblReady.Text = "ORDER READY";
            this.lblReady.Click += new System.EventHandler(this.lblReady_Click);
            // 
            // frmOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GroupProject.Properties.Resources.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblReady);
            this.Controls.Add(orderIdLabel);
            this.Controls.Add(this.orderIdLabel1);
            this.Controls.Add(customerUserNameLabel);
            this.Controls.Add(this.customerUserNameLabel1);
            this.Controls.Add(orderItemLabel);
            this.Controls.Add(this.orderItemLabel1);
            this.Controls.Add(totalPriceLabel);
            this.Controls.Add(this.totalPriceLabel1);
            this.Controls.Add(dateandTimeLabel);
            this.Controls.Add(this.dateandTimeDateTimePicker);
            this.Controls.Add(this.orderTableBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "frmOrderList";
            this.Text = "frmOrder";
            this.Load += new System.EventHandler(this.frmOrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderTableBindingNavigator)).EndInit();
            this.orderTableBindingNavigator.ResumeLayout(false);
            this.orderTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetOrderTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DatabaseDataSetOrderTable databaseDataSetOrderTable;
        private System.Windows.Forms.BindingSource orderTableBindingSource;
        private DatabaseDataSetOrderTableTableAdapters.OrderTableTableAdapter orderTableTableAdapter;
        private DatabaseDataSetOrderTableTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator orderTableBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label orderIdLabel1;
        private System.Windows.Forms.Label customerUserNameLabel1;
        private System.Windows.Forms.Label orderItemLabel1;
        private System.Windows.Forms.Label totalPriceLabel1;
        private System.Windows.Forms.DateTimePicker dateandTimeDateTimePicker;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton orderTableBindingNavigatorSaveItem;
        private System.Windows.Forms.Label lblReady;
    }
}