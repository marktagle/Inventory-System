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
    public partial class frmSearProduct : Form
    {
        CRUDTools crud = new CRUDTools();
        public frmSearProduct()
        {
            InitializeComponent();
        }

        private void frmSearProduct_Load(object sender, EventArgs e)
        {
            OleDbDataReader reader = null;
            crud.RetrieveRecords("SELECT Stocks FROM Products", ref reader);
            while(reader.Read())
            {
                String res = reader[0].ToString();
                int x = int.Parse(res);
                if(x == 15)
                {
                    MessageBox.Show("Please Check your items!\nOne of your product is on critical level","Cashier | O.M.T");
                    break;
                }
            }
            crud.FillDataGrid(@"SELECT * FROM Products",ref dgvProducts);

            cbxSearchBy.SelectedIndex = 0;
        }

        private void txtSearchBy_TextChanged(object sender, EventArgs e)
        {
            String sqlSearchby = "";
            switch (cbxSearchBy.SelectedIndex)
            {
                case 0:
                    sqlSearchby = String.Format(@"SELECT * FROM Products WHERE ProdID LIKE '%{0}%'", txtSearchBy.Text.Trim());
                    break;
                case 1:
                    sqlSearchby = String.Format(@"SELECT * FROM Products WHERE ProdName LIKE '%{0}%'", txtSearchBy.Text.Trim());
                    break;
            }
            crud.FillDataGrid(sqlSearchby, ref dgvProducts);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void btnClose_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void logoadmin_Click(object sender, EventArgs e)
        {

        }

        private void lblStaffs_Click(object sender, EventArgs e)
        {

        }

        private void cbxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
