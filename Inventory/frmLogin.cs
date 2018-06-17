using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Inventory
{
    public partial class frmLogin : Form
    {
        CRUDTools crud = new CRUDTools();
        public frmLogin()
        {
            InitializeComponent();
           
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if(chkPass.Checked==true)
            {
                txtPass.UseSystemPasswordChar = false;
                lblShowPass.Text = "Hide Password";
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                lblShowPass.Text = "Show Password";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        private void login()
        {
            String user = "", pass = "";
            user = txtLogin.Text.Trim();
            pass = txtPass.Text.Trim();
            OleDbDataReader reader = null;
            Boolean bl = false;
            String sql = "", sql2 = "", Res = "";

                        AdminMain log = new AdminMain();
                        log.Text = "" + user;
                        log.lblpass.Text = pass;
                        this.Hide();
                        SplashAnimator2.Show(log);
        }
        

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            report log = new report();
            log.Show();
        }
    }
}
