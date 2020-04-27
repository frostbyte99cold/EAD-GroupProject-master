using System;
using System.Collections;
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
    public partial class frmMenuOption : Form
    {
        Items item;
        double subtotal;
        string user;
        string level;
        ArrayList price ;
        ArrayList itemName ;
        ArrayList quantity;
        ArrayList table;


        public frmMenuOption()
        {
            InitializeComponent();
        }

        public frmMenuOption(string user,string level)
        {
            InitializeComponent();
            
            this.user = user;
            this.level = level;

            if (level == "admin")
            {
                lblOrder.Show(); 
            }
            else if(level == "guest")
            {
                lblCheckout.Hide();
            }
        }


        private void picboxBreakfast_Click(object sender, EventArgs e)
        {

           
                FrmBreakFastMenu breakfast = new FrmBreakFastMenu(user,level,item, subtotal, itemName, price, quantity,table);

                breakfast.ShowDialog();

        }

        private void frmMenuOption_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
            this.item = new Items();
            double subtotal = 0 ;
            this.subtotal = subtotal;
            this.quantity = new ArrayList();
            this.itemName = new ArrayList();
            this.price =    new ArrayList();
            this.table = new ArrayList();

           
        }

        private void picboxLunch_Click(object sender, EventArgs e)
        {

            if (this.user == "admin")
            {

                FrmLunchMenu lunch = new FrmLunchMenu(user);

                lunch.ShowDialog();

            }
            else
            {
                FrmLunchMenu lunch = new FrmLunchMenu(user,level, item, subtotal, itemName, price, quantity, table);

                lunch.ShowDialog();
            }

        }

        private void picboxHotBeverage_Click(object sender, EventArgs e)
        {
            if (this.user == "admin")
            {
                frmHotBeverage HotBeverage = new frmHotBeverage(user);

                HotBeverage.ShowDialog();
            }
            else { 

            frmHotBeverage HotBeverage = new frmHotBeverage(user,level, item, subtotal, itemName, price, quantity, table);

            HotBeverage.ShowDialog();

        }
     }

        private void picboxColdBeverage_Click(object sender, EventArgs e)
        {
            if (this.user == "admin")
            {
                FrmColdBeverage coldBeverage = new FrmColdBeverage(user);
                coldBeverage.Show();
            }
            else {
                FrmColdBeverage coldBeverage = new FrmColdBeverage(user,level, item, subtotal, itemName, price, quantity, table);
                coldBeverage.Show();
            }
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

            frmCheckout checkout = new frmCheckout(user, item, subtotal, itemName, price, quantity, table);

            checkout.ShowDialog();


        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            FrmLogin login = new FrmLogin();
            login.Show();

            menu.Close();

        }


        private void lblOrder_Click(object sender, EventArgs e)
        {
            frmOrderList orderList = new frmOrderList();
            orderList.ShowDialog();
        }
    }
}
