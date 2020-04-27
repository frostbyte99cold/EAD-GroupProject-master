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
    public partial class frmMenu : Form
    {
        String user;
        string level;
        public frmMenu()
        {
            InitializeComponent();
        }
        
        public frmMenu(String user,string level)
        {
            InitializeComponent();
            this.user = user;
            this.level = level;

            if (level == "guest")
            {
                signInToolStripMenuItem1.Visible = true;
                accountToolStripMenuItem.Visible = false;
            }
                
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

       
        private void frmMenu_Load(object sender, EventArgs e)
        {
            frmMenuOption menuoption = new frmMenuOption(user,level);
            menuoption.MdiParent=this;
            menuoption.Show();
        
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin login = new FrmLogin();
            login.Show();
        }

        private void signInToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin login = new FrmLogin();
            login.Show();
        }
    }
}
