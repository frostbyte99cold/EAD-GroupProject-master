using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{

    public partial class FrmSignUp : Form
    {
        string user;
        string level;
        public FrmSignUp()
        {
            InitializeComponent();
        }

        public FrmSignUp(string user,string level)
        {
            InitializeComponent();

            /*
             
            if changing this if statement try to make method that returns the user positon
            and call the funtion and compair it to the user inputted
             
             */
            this.level = level;
            this.user = user;
        }

        private void FrmSignUp_Load(object sender, EventArgs e)
        {
           // txtConfirmPassword.Focus();
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtUserName_Validated(object sender, EventArgs e)
        {
            

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            UserData userdata = new UserData();
            User newUser = new User();


            if (txtFirstName.Text == "")
            {
                txtFirstName.Focus();
                MessageBox.Show("PLEASE ENTER YOUR FIRST NAME", "FIRST NAME", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtLastName.Text == "")
            {
                txtLastName.Focus();
                MessageBox.Show("PLEASE ENTER YOUR LAST NAME", "LAST NAME", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtUserName.Text == "")
            {
                txtUserName.Focus();

                MessageBox.Show("PLEASE ENTER YOUR USERNAME", "USERNAME", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (txtUserName.Text.Length < 5)
            {
                txtUserName.Focus();
                MessageBox.Show("USERNAME TOO SHORT ", "USERNAME", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (userdata.CheckingExistingUsername(txtUserName.Text) == false)
            {
                txtEmail.Focus();
                MessageBox.Show("Username ALREADY USED", "EMAIL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (!maskPhoneNumber.MaskFull)
            {
                maskPhoneNumber.Focus();
                MessageBox.Show("PLEASE ENTER YOUR PHONE NUMBER", "PHONE NUMBER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtEmail.Text == "")
            {

                txtEmail.Focus();
                MessageBox.Show("PLEASE ENTER YOUR EMAIL", "EMAIL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else if (userdata.IsValidEmail(txtEmail.Text) == false)
            {
                txtEmail.Focus();
                MessageBox.Show("PLEASE ENTER A VALID EMAIL", "EMAIL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (userdata.CheckingExistingEmail(txtEmail.Text) == false)
            {
                txtEmail.Focus();
                MessageBox.Show("EMAIL ALREADY USED", "EMAIL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (txtPassword.Text == "")
            {

                txtPassword.Focus();
                MessageBox.Show("PLEASE ENTER YOUR PASSWORD", "PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (!(txtPassword.Text.Length >= 8))
            {
                txtConfirmPassword.Clear();
                txtConfirmPassword.Focus();
                MessageBox.Show("PASSWORD MUST BE ATLEAST 8 CHARACTERS LONG", "PASSWORD ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtConfirmPassword.Text == "")
            {
                txtConfirmPassword.Focus();
                MessageBox.Show("PLEASE CONFIRM YOUR PASSWORD", "CONFIRM PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!(txtConfirmPassword.Text == txtPassword.Text))
            {
                MessageBox.Show("PASSWORD MUST BE THE SAME ", "PASSWORD ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Clear();
                txtConfirmPassword.Focus();
            }
            else
            {


                newUser.Username = txtUserName.Text;
                newUser.Firstname = txtFirstName.Text;
                newUser.Lastname = txtLastName.Text;
                newUser.Email = txtEmail.Text;
                newUser.Phonenumber = maskPhoneNumber.Text;

                //REMEMBER TO HASH
                newUser.Password = txtPassword.Text;
                if (level == "Manager")
                {
                    userdata.InsertNewAdmin(newUser);
                    MessageBox.Show("NEW ADMIN ADDED");
                    
                    this.Close();
                }
                else { 
                userdata.InsertNewUser(newUser);
                    MessageBox.Show("SIGN UP SUCESSFULLY...");
                    frmMenu menu = new frmMenu(user,level);
                    menu.Show();
                    this.Hide();
                }
                
                
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        private void btntest_Click(object sender, EventArgs e)
        {
            Console.WriteLine("{0}", maskPhoneNumber.Text);
        }
    }
}
