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
    public partial class FrmAdmin : Form
    {
        string user;
        string level;
        public FrmAdmin()
        {
            InitializeComponent();
        }
        public FrmAdmin(String user,string level)
        {
            InitializeComponent();

            if(level == "Manager")
            {
                btnAddAdmin.Show();
            }

            this.user = user;
            this.level = level;


        }
        private void lblSalesReview_Click(object sender, EventArgs e)
        {
            FrmSalesReview Salesreview = new FrmSalesReview();
            Salesreview.ShowDialog();
        }

        private void lblReceipts_Click(object sender, EventArgs e)
        {
            FrmReceipt receipt = new FrmReceipt();
            receipt.ShowDialog();
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {
            
            frmMenu menu = new frmMenu(user,level);
            menu.Show();
            this.Hide();
        }

        private void lblEditItems_Click(object sender, EventArgs e)
        {
            FrmEditItems editItems = new FrmEditItems();
            editItems.ShowDialog();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            FrmSignUp signUp = new FrmSignUp(user,level);
            signUp.ShowDialog();
        }
    }
}
