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
    public partial class Products : Form
    {
        CRUDTools crud = new CRUDTools();
        Boolean dgv = false;
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            prodFill();
            cbxProdLine.SelectedIndex = 0;
            filldata();
            cbxSearchBy.SelectedIndex = 0;
            
        }
        private void prodFill()
        {
            cbxProdLine.Items.Clear();
            String sqlProdline = String.Format(@"SELECT DISTINCT ProdLine FROM Products");
            OleDbDataReader reader = null;
            crud.RetrieveRecords(sqlProdline,ref reader);
            while(reader.Read())
            {
                cbxProdLine.Items.Add(reader[0].ToString());
            }
            crud.CloseConnection();
        }
        private void filldata()
        {
            String sqldgv = String.Format(@"SELECT * FROM Products");
            crud.FillDataGrid(sqldgv,ref dgvProducts);
            crud.CloseConnection();
        }

        private void txtSearchBy_TextChanged(object sender, EventArgs e)
        {
            String sqlSearchby = "";
            switch(cbxSearchBy.SelectedIndex)
            {
                case 0:
                    sqlSearchby = String.Format(@"SELECT * FROM Products WHERE ProdID LIKE '%{0}%'",txtSearchBy.Text.Trim());
                    break;
                case 1:
                    sqlSearchby = String.Format(@"SELECT * FROM Products WHERE ProdName LIKE '%{0}%'", txtSearchBy.Text.Trim());
                    break;
            }
            crud.FillDataGrid(sqlSearchby,ref dgvProducts);
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv = true;
            if (dgvProducts.CurrentRow.Index >= 0)
            {
                txtProdID.Text = dgvProducts.CurrentRow.Cells[0].Value.ToString();
                txtProdDesc.Text = dgvProducts.CurrentRow.Cells[1].Value.ToString();
                txtProdName.Text = dgvProducts.CurrentRow.Cells[3].Value.ToString();
                txtProdProce.Text = dgvProducts.CurrentRow.Cells[2].Value.ToString();
                cbxProdLine.SelectedItem = dgvProducts.CurrentRow.Cells[4].Value.ToString();
                txtProdStocks.Text = dgvProducts.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(btnAdd.ButtonText == "Save")
            {
                if ((txtProdName.Text.Trim() == null || txtProdName.Text.Trim() == "") || (txtProdProce.Text.Trim() == null || txtProdProce.Text.Trim() == "")
                || (txtProdDesc.Text.Trim() == null || txtProdDesc.Text.Trim() == "") || (txtProdStocks.Text.Trim() == null || txtProdStocks.Text.Trim() == "")
                || (cbxProdLine.Text.Trim() == null || cbxProdLine.Text.Trim() == ""))
                {
                    MessageBox.Show("Fill the blank Fields!", "O.M.T | Products");
                }
                else
                {
                    String sqlprodname = String.Format(@"SELECT * FROM Products WHERE ProdName = '{0}'",txtProdName.Text.Trim());
                    OleDbDataReader prodnamereader = null;
                    crud.RetrieveRecords(sqlprodname , ref prodnamereader);
                    if (prodnamereader.HasRows)
                    {
                        MessageBox.Show("The you want to add is already in your inventory \nClick Update Button if you want to edit this product", "O.M.T | Products");
                        crud.CloseConnection();
                    }
                    else
                    {
                        crud.CloseConnection();
                        String sqlAddProd = String.Format(@"INSERT INTO Products
                                                           VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",
                                                           txtProdID.Text,txtProdName.Text.Trim(),txtProdDesc.Text.Trim(),
                                                           txtProdProce.Text.Trim(),cbxProdLine.Text.Trim(),txtProdStocks.Text.Trim());
                        crud.ExecuteQuery(sqlAddProd);
                        clearText();
                        dgvProducts.Enabled = true;
                        txtProdName.Enabled = false;
                        txtProdProce.Enabled = false;
                        txtProdDesc.Enabled = false;
                        txtProdProce.Enabled = false;
                        cbxProdLine.Enabled = false;
                        txtProdStocks.Enabled = false;
                        btnAdd.ButtonText = "Add New";
                        dgv = false;
                        btnUpdate.Show();
                        btnRemove.Show();
                        filldata();
                    }

                }
            }
            else
            {
                clearText();
                prodid();
                dgvProducts.Enabled = false;
                txtProdName.Enabled = true;
                txtProdProce.Enabled = true;
                txtProdDesc.Enabled = true;
                txtProdProce.Enabled = true;
                cbxProdLine.Enabled = true;
                txtProdStocks.Enabled = true;
                btnRemove.Hide();
                btnUpdate.Hide();
                btnAdd.ButtonText = "Save";
            }
        }
        private void prodid()
        {
            String sqlProd = String.Format(@"SELECT max(ProdID) FROM Products");
            OleDbDataReader Prodreader = null;
            Prodreader = crud.RetrieveRecords(sqlProd, ref Prodreader);
            Prodreader.Read();
            String Prodno = Prodreader[0].ToString();
            String res = Prodno;
            crud.CloseConnection();
            
            int id = int.Parse(res);
            id++;
            txtProdID.Text = String.Format("{0}", id);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(btnUpdate.ButtonText == "Save")
            {
                if(dgv == true)
                {
                   if ((txtProdName.Text.Trim() == null || txtProdName.Text.Trim() == "") || (txtProdProce.Text.Trim() == null || txtProdProce.Text.Trim() == "")
                        || (txtProdDesc.Text.Trim() == null || txtProdDesc.Text.Trim() == "") || (txtProdStocks.Text.Trim() == null || txtProdStocks.Text.Trim() == "")
                        || (cbxProdLine.Text.Trim() == null || cbxProdLine.Text.Trim() == ""))
                   {
                       MessageBox.Show("Fill the blank Fields!", "O.M.T | Products");
                   }
                   else
                   {
                       if (MessageBox.Show("Are ypur sure you want to update this product ?", "O.M.T | Products", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                       {
                           String sqlupdateprod = String.Format(@"UPDATE Products
                                                             SET ProdName = '{0}',ProdDesc = '{1}',Price = '{2}',ProdLine = '{3}',Stocks = '{4}'
                                                             WHERE ProdID = '{5}'",
                                                             txtProdName.Text.Trim(), txtProdDesc.Text.Trim(), txtProdProce.Text.Trim(), cbxProdLine.Text.Trim(),
                                                             txtProdStocks.Text.Trim(),txtProdID.Text);
                           crud.ExecuteQuery(sqlupdateprod);
                           crud.CloseConnection();
                           filldata();
                           dgv = false;

                           btnAdd.Show();
                           btnRemove.Show();
                           txtProdName.Enabled = false;
                           txtProdProce.Enabled = false;
                           txtProdDesc.Enabled = false;
                           txtProdProce.Enabled = false;
                           cbxProdLine.Enabled = false;
                           txtProdStocks.Enabled = false;
                           dgvProducts.Enabled = true;
                           btnUpdate.ButtonText = "Update";
                       }
                   }
                }
                else
                {
                    MessageBox.Show("Please select a product to update!", "O.M.T | Products");
                }
            }
            else
            {
                btnAdd.Hide();
                btnRemove.Hide();
                txtProdName.Enabled = true;
                txtProdProce.Enabled = true;
                txtProdDesc.Enabled = true;
                txtProdProce.Enabled = true;
                cbxProdLine.Enabled = true;
                txtProdStocks.Enabled = true;
                dgvProducts.Enabled = false;
                btnUpdate.ButtonText = "Save";
            }
        }
        private void clearText()
        {
            txtProdDesc.Clear();
            txtProdID.Clear();
            txtProdName.Clear();
            txtProdProce.Clear();
            txtProdStocks.Clear();
            cbxProdLine.Items.Clear();
            prodFill();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var form = AdminMain.ActiveForm as AdminMain;
            form.button1.PerformClick();
            
        }

        private void cbxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtProdStocks_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
