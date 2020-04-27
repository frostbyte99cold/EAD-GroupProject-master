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
    public partial class frmCheckout : Form
    {

        UserData data = new UserData();

        Items item;
        double subtotal;

        double total;

        ArrayList price = new ArrayList();

        double tax = 0.165;

        double taxTemp;

        ArrayList itemName;
        
        ArrayList quantity;
        ArrayList table;
        string user;
        public frmCheckout()
        {
            InitializeComponent();
        }

        public frmCheckout(Items item,double subtotal)
        {
            InitializeComponent();
            this.item = item;
            this.subtotal = subtotal;
        }

        public frmCheckout(Items item, double subtotal, ArrayList price)
        {
            InitializeComponent();
            this.item = item;
            this.subtotal = subtotal;
            
            this.price = price;
           
        }


        public frmCheckout(Items item, double subtotal, ArrayList itemName, ArrayList price, ArrayList quantity, ArrayList table)
        {
            InitializeComponent();
            this.item = item;
            this.subtotal = subtotal;
            this.itemName = itemName;
            this.price = price;
            this.quantity = quantity;
            this.table = table;
            
        }

        public frmCheckout(string user,Items item, double subtotal, ArrayList itemName, ArrayList price, ArrayList quantity, ArrayList table)
        {
            InitializeComponent();
            this.item = item;
            this.subtotal = subtotal;
            this.itemName = itemName;
            this.price = price;
            this.quantity = quantity;
            this.table = table;
            this.user = user;
        }



        private void frmCheckout_Load(object sender, EventArgs e)
        {
            

           
            foreach (var item in item.items)
            {
                listCheckoutList.Items.Add(item.ToString());
            }

            lblSubtotal.Text = subtotal.ToString();

            this.taxTemp = this.subtotal * this.tax;

            this.total = this.taxTemp + this.subtotal;
            
            //Console.WriteLine("{0}", tax);
            //this.total = this.total + totalTemp;

            lblTotal.Text = this.total.ToString(); 

        }

        private void lblPurchase_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to make this purchase", "Purchase", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {

                dialog = MessageBox.Show("Do you want to pay for this purchase online", "Purchase", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    frmOnlinePayment online = new frmOnlinePayment();
                    online.ShowDialog();
                }
                else if (dialog == DialogResult.No)
                {
                    MessageBox.Show("YOUR ORDER IS GETTING READY");
                    
                    foreach (var tableName in table) 
                    { 

                        foreach (var itemname in itemName)
                        {
                            foreach (var quan in quantity)
                            {
                                data.editDatabase(tableName.ToString(), itemname.ToString(), int.Parse(quan.ToString()));
                            }
                        }
                    }
                    

                    DateTime date = new DateTime();
                    date= DateTime.Now;

                    
                    string order= "";
                    foreach (var item in item.items)
                    {
                         order = order + item + "\n";

                      
                    }

                    //Console.WriteLine("{0}", order);

                    
                    data.newOrder(user,order,total,date);


                    FrmReceipt receipt = new FrmReceipt();
                    this.Close();
                    receipt.Show();
                    
                }
            }
            else if (dialog == DialogResult.No)
            {
                MessageBox.Show("world");
            }


        }

        private void lblRemove_Click(object sender, EventArgs e)
        {

            if (listCheckoutList.SelectedIndex < 0)
            {

            }
            else
            {

                string removedItem = listCheckoutList.SelectedItem.ToString();

                this.item.items.Remove(removedItem);

                int r = listCheckoutList.SelectedIndex;

                double removedPrice = (double)price[r];

                double t = this.subtotal;

                this.subtotal = t - removedPrice;

                lblSubtotal.Text = this.subtotal.ToString();

                this.taxTemp = this.subtotal * this.tax;

                this.total = this.taxTemp + this.subtotal;


                lblTotal.Text = this.total.ToString();


                price.RemoveAt(listCheckoutList.SelectedIndex);

                this.itemName.RemoveAt(listCheckoutList.SelectedIndex);
                this.quantity.RemoveAt(listCheckoutList.SelectedIndex);
                this.table.RemoveAt(listCheckoutList.SelectedIndex);

                listCheckoutList.Items.Clear();

                foreach (var item in item.items)
                {
                    listCheckoutList.Items.Add(item.ToString());
                }

            }


        }

        private void label2_Click(object sender, EventArgs e)
        {}

        private void lblClear_Click(object sender, EventArgs e)
        {
            listCheckoutList.Items.Clear();
            lblSubtotal.Text = "0";
            lblTotal.Text = "0";
        }
    }
}
