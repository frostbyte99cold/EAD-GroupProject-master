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
    public partial class FrmLunchMenu : Form
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
        public FrmLunchMenu()
        {
            InitializeComponent();
        }

        public FrmLunchMenu(Items item, double subtotal)
        {
            InitializeComponent();
            this.item = item;
            this.subtotal = subtotal;
        }
        public FrmLunchMenu(string user, string level, Items item, double subtotal, ArrayList itemName, ArrayList price, ArrayList quantity, ArrayList table)
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
        }
        public FrmLunchMenu(String user)
        {
            InitializeComponent();
            if (user == "admin")
            {
                lblAdd.Show();
                lblDelete.Show();
                lblUpdate.Show();
            }
        }

        private void FrmLunchMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSetLunchMenu.LunchMenu' table. You can move, or remove it, as needed.
            this.lunchMenuTableAdapter.Fill(this.databaseDataSetLunchMenu.LunchMenu);

        }

        private void lblBreakfastSwitch_Click(object sender, EventArgs e)
        {
            FrmBreakFastMenu breakFastMenu = new FrmBreakFastMenu(user,level, item, subtotal, itemName, price, quantity, table);
            breakFastMenu.Show();
            this.Hide();
        }
        /*
        private void lblLunchSwitch_Click(object sender, EventArgs e)
        {
            FrmLunchMenu lunchmenu = new FrmLunchMenu(item, subtotal);
            lunchmenu.Show();
            this.Hide();
        }*/

        private void lblHotBeverageSwitch_Click(object sender, EventArgs e)
        {
            frmHotBeverage hotbeverage = new frmHotBeverage(user,level, item, subtotal, itemName, price, quantity, table);
            hotbeverage.Show();
            this.Hide();
        }

        private void lblColdBeverageSwitch_Click(object sender, EventArgs e)
        {
            FrmColdBeverage coldBeverage = new FrmColdBeverage(user,level, item, subtotal, itemName, price, quantity, table);
            coldBeverage.Show();
            this.Hide();
        }

        private void lblCheckout_Click(object sender, EventArgs e)
        {
            frmCheckout checkout = new frmCheckout(user, item, subtotal, itemName, price, quantity, table);

            checkout.ShowDialog();
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            FrmEditItems editItems = new FrmEditItems();
            editItems.ShowDialog();
        }

        private void lunchMenuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lunchMenuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSetLunchMenu);

        }

        private void lblAddtoCart_Click(object sender, EventArgs e)
        {
            String itemName = itemsLabel1.Text.ToString();
            double price = double.Parse(priceLabel1.Text.ToString());

            int quantity = int.Parse(numQuantity.Value.ToString());

            double newPrice = price * quantity; //THIS IS THE PRICE OF THE ITEM AND THE AMOUNT BEING PUCHASE

            this.subtotal = this.subtotal + newPrice;


            string order = itemName + ".....X" + quantity + "__________$" + newPrice;

            if (quantity < 1)
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
                this.table.Add("LunchMenu");
                this.itemName.Add(itemName);
                this.quantity.Add(quantity);
                this.price.Add(newPrice);
            }
        }
    }
}
                                