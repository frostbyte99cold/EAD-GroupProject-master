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
    public partial class FrmLogin : Form
    {
        string user;
        string level;

        public FrmLogin()
        {
            InitializeComponent();
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            
            User user = new User();
            UserData userdata = new UserData();


           if (txtUserName.Text == "")
            {
                txtUserName.Focus();
                MessageBox.Show("PLEASE ENTER YOUR USERNAME", "USERNAME",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            }
            else if (txtPassword.Text == "")
            {

                txtPassword.Focus();
                MessageBox.Show("PLEASE ENTER YOUR PASSWORD", "PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if(true == userdata.LoggingIn(txtUserName.Text, txtPassword.Text))
            {
                level = "customer";
                frmMenu menu = new frmMenu(txtUserName.Text,level);
                this.Hide();
                menu.Show();
            
            }
            else if (true == userdata.AdminLoggingIn(txtUserName.Text, txtPassword.Text))
            {
                level = "admin";
                FrmAdmin admin = new FrmAdmin(txtUserName.Text,level);          
                this.Hide();
                admin.Show();
            
            }
            else
            {
                
                MessageBox.Show("Incorrect Detail");
                
            }


        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            FrmSignUp signup = new FrmSignUp();
            signup.Show();
            this.Hide();


        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            user = "guest";
            level = "guest";
            MessageBox.Show("YOU ARE ABOUT TO VIEW THE MENU AS A GUEST... YOU'LL HAVE TO SIGN IN, TO BE ABLE TO MAKE PURCHASE");
            frmMenu menu = new frmMenu(user,level);
            menu.Show();
            this.Hide();
        }
    }
}
