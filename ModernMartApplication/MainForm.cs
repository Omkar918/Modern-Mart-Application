using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernMartApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (LoginForm.loginname!= null) 
            {
                toolStripStatusLabel2.Text = LoginForm.loginname;
            }
            if(LoginForm.logintype!=null && LoginForm.logintype=="Seller")
            {
                masterToolStripMenuItem.Enabled = false;
                masterToolStripMenuItem.ForeColor = Color.Red;
                productToolStripMenuItem.Enabled = false;
                productToolStripMenuItem.ForeColor = Color.Red;
                addUserToolStripMenuItem.Enabled = false;
                addUserToolStripMenuItem.ForeColor = Color.Red;
            }

        }
        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategory fcat = new FormCategory();
            fcat.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox abt = new AboutBox();
            abt.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close this Application ?", "CLOSE", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }

        private void addSellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddNewSeller fseller = new FormAddNewSeller();
            fseller.ShowDialog();
        }

        private void addAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddAdmin aaf = new FormAddAdmin();
            aaf.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddProduct ap = new FormAddProduct();
            ap.ShowDialog();
        }

        private void sellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellingForm sf = new SellingForm();
            sf.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you really want to close this Application ?", "CLOSE", MessageBoxButtons.YesNo, MessageBoxIcon.Stop))
            {
                Application.Exit();
            }
        }
    }
}
