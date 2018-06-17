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
    public partial class frmRemovePosPRod : Form
    {
        CRUDTools crud = new CRUDTools();
        public frmRemovePosPRod()
        {
            InitializeComponent();
        }

        private void frmRemovePosPRod_Load(object sender, EventArgs e)
        {
            

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String sqlcount = String.Format(@"SELECT COUNT(Accpassword) FROM Users");
            OleDbDataReader countreader = null;
            crud.RetrieveRecords(sqlcount,ref countreader);
            countreader.Read();
            String count = "";
            count = countreader[0].ToString();
            crud.CloseConnection();
            int y = int.Parse(count);
            String sql = String.Format(@"SELECT Accpassword FROM Users WHERE AccountType = 'Admin'");
            OleDbDataReader reader = null;
            crud.RetrieveRecords(sql, ref reader);
            reader.Read();
            
            String password = reader[0].ToString();
            if (txtPass.Text.CompareTo(password) == 0)
            {
                //for (int x = 0; x < y; x++)
                //{
                    crud.CloseConnection();
                    (this.Owner as frmCashier).btnremoveitemss.PerformClick();
                    (this.Owner as frmCashier).btnENTRUE.PerformClick();
                    this.Close();

                //}
            }
            else
            {
                crud.CloseConnection();
                MessageBox.Show("Incorrect password or\nAsk the admin personel!", "O.M.T | Cashier");
            }
            crud.CloseConnection();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            (this.Owner as frmCashier).btnENTRUE.PerformClick();
            this.Close();
        }
    }
}
