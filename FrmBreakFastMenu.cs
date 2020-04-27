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
    public partial class FrmBreakFastMenu : Form
    {
        ArrayList list = new ArrayList();

        Items item = new Items();
        
        ArrayList itemName;
        ArrayList price;
        ArrayList quantity;
        ArrayList table;
        double subtotal;
        string user;
        string level;


        public FrmBreakFastMenu()
        {
            InitializeComponent();
        }

        public FrmBreakFastMenu(Items item, double subtotal)
        {
            InitializeComponent();
            this.item = item;
            this.subtotal = subtotal;
        }
        
        public FrmBreakFastMenu(string user,string level,Items item, double subtotal, ArrayList itemName, ArrayList price, ArrayList quantity, ArrayList table)
        {
            InitializeComponent();

            this.item = item;
            this.subtotal = subtotal;
            this.itemName = itemName;
            this.price = price;
            this.quantity = quantity;
            this.table = table;
            this.user = user;
            this.level = level;

            if(level == "admin")
            {
                toolStripContainer1.Visible = false;
                lblAddtoCart.Visible = false;
            }else if(level == "guest")
            {
                lblAddtoCart.Visible = false;
                lblCheckout.Visible = false;
            }
        }

        public FrmBreakFastMenu(Items item, double subtotal,ArrayList itemName,ArrayList price,ArrayList quantity,ArrayList table )
        {
            InitializeComponent();
          
            this.item = item;
            this.subtotal = subtotal;
            this.itemName = itemName;
            this.price = price;
            this.quantity = quantity;
            this.table = table;
        }

        public FrmBreakFastMenu(String user)
        {
            InitializeComponent();

        }

        private void lblLunchSwitch_Click(object sender, EventArgs e)
        {
            FrmLunchMenu lunch = new FrmLunchMenu(user,level, item, subtotal, itemName, price, quantity, table);
            lunch.Show();
            this.Hide();
        }

        private void lblHotBeverageSwitch_Click(object sender, EventArgs e)
        {
            frmHotBeverage hotBeverage = new frmHotBeverage(user,level, item, subtotal, itemName, price, quantity, table);
            hotBeverage.Show();
            this.Close();
        }

        private void lblColdBeverageSwitch_Click(object sender, EventArgs e)
        {
            FrmColdBeverage coldBeverage = new FrmColdBeverage(user,level,item, subtotal, itemName, price, quantity, table);
            coldBeverage.Show();
            this.Close();
        }

        private void lblCheckout_Click(object sender, EventArgs e)
        {
            frmCheckout checkout = new frmCheckout(user,item,subtotal,itemName,price,quantity,table);
            checkout.Show();
            this.Close();
            
        }

        private void lblBreakFast_Click(object sender, EventArgs e)
        {
            
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            FrmEditItems editItems = new FrmEditItems();
            editItems.ShowDialog();
        }

        private void FrmBreakFastMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet1.BreakfaastMenu' table. You can move, or remove it, as needed.
            //this.databaseDataSet1.Reset();

           
            this.breakfaastMenuTableAdapter.Fill(this.databaseDataSet1.BreakfaastMenu);
            
            /*
            this.Validate();
            this.breakfaastMenuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet1);
            */

        }


        private void breakfaastMenuBindingNavigatorSaveItem_Click_4(object sender, EventArgs e)
        {
            this.Validate();
            this.breakfaastMenuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet1);

        }
        
        private void lblAddtoCart_Click(object sender, EventArgs e)
        {
            
            String itemName = itemsLabel1.Text.ToString();
            double price = double.Parse(priceLabel1.Text.ToString());

            int quantity = int.Parse(numQuantity.Value.ToString());

            double newPrice = price * quantity; //THIS IS THE PRICE OF THE ITEM AND THE AMOUNT BEING PUCHASE

            this.subtotal = subtotal + newPrice;

            
            string order = itemName + ".....X" + quantity+ "__________$" + newPrice;

            if(quantity <1)
            {
                MessageBox.Show("Item must have atleast one(1) to be added to cart");
            }
            else if (item.items.Contains(order))
            {
                MessageBox.Show("Already added");
            }
            else
            {
                item.items.Add(order);
                MessageBox.Show("Item Added to Cart");
                this.table.Add("BreakfaastMenu");
                this.itemName.Add(itemName);
                this.quantity.Add(quantity);
                this.price.Add(newPrice);
            }

            

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.breakfaastMenuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet1);
        }
    }
} 