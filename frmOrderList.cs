using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class frmOrderList : Form
    {
        public frmOrderList()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
          this.Close();
        }

        private void orderTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSetOrderTable);

        }

        private void orderTableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.orderTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSetOrderTable);

        }

        private void frmOrderList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSetOrderTable.OrderTable' table. You can move, or remove it, as needed.
            this.orderTableTableAdapter.Fill(this.databaseDataSetOrderTable.OrderTable);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.orderTableTableAdapter.FillBy(this.databaseDataSetOrderTable.OrderTable);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.orderTableTableAdapter.FillBy(this.databaseDataSetOrderTable.OrderTable);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        UserData data = new UserData();

        private void lblReady_Click(object sender, EventArgs e)
        {
                data.orderReady(int.Parse(orderIdLabel1.Text.ToString()));
            
                this.Validate();
                this.orderTableBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.databaseDataSetOrderTable);
            
        }
    }
}
