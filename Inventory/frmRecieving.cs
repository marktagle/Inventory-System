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
    public partial class frmRecieving : Form
    {
        CRUDTools crud = new CRUDTools();
        Boolean dgv = false;
        String sql = "";
        String IDD = "";
        String delivered = "";
        public frmRecieving()
        {
            InitializeComponent();
        }

        private void frmRecieving_Load(object sender, EventArgs e)
        {
            crud.FillDataGrid(@"SELECT * FROM OrderedProducts WHERE Status = 'NotCompleted'",ref dgvProducts);
            crud.CloseConnection();
            nudNoofOrdered.Minimum = 1;
            nudItemsdeliverd.Minimum = 1;
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProducts.CurrentRow.Index >= 0)
            {
                dgv = true;
                txtOrderID.Text = dgvProducts.CurrentRow.Cells[0].Value.ToString();
                txtProdID.Text = dgvProducts.CurrentRow.Cells[1].Value.ToString();
                txtProdName.Text = dgvProducts.CurrentRow.Cells[3].Value.ToString();
                txtSupplierID.Text = dgvProducts.CurrentRow.Cells[4].Value.ToString();
                txtSupplierName.Text = dgvProducts.CurrentRow.Cells[5].Value.ToString();
                nudNoofOrdered.Value = int.Parse( dgvProducts.CurrentRow.Cells[7].Value.ToString());
                txtDOO.Text = dgvProducts.CurrentRow.Cells[6].Value.ToString();
                nudItemsdeliverd.Maximum = int.Parse(nudNoofOrdered.Value.ToString());
                txtStatus.Text = dgvProducts.CurrentRow.Cells[9].Value.ToString();
                IDD = dgvProducts.CurrentRow.Cells[10].Value.ToString();
                delivered = dgvProducts.CurrentRow.Cells[8].Value.ToString();
                
            }
        }

        private void dgvProducts_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgv == true)
            {
                sql = String.Format(@"SELECT * FROM Products WHERE ProdID = '{0}'", dgvProducts.CurrentRow.Cells[1].Value.ToString());
                OleDbDataReader reader = null;
                crud.RetrieveRecords(sql,ref reader);
                reader.Read();
                String stocks = reader[5].ToString();
                
                crud.CloseConnection();
                
                int asds = int.Parse(delivered);
                int x = int.Parse(stocks);
                if (int.Parse(nudNoofOrdered.Value.ToString()) > int.Parse(nudItemsdeliverd.Value.ToString()))
                {
                    crud.ExecuteQuery(String.Format(@"UPDATE Products
                                                     SET Stocks = '{0}'
                                                      WHERE ProdID = '{1}'", x + int.Parse(nudItemsdeliverd.Value.ToString()), txtProdID.Text));
                    crud.CloseConnection();
                    int y = 0;
                    y = asds;
                    crud.ExecuteQuery(String.Format(@"UPDATE OrderedProducts
                                                    SET Delivered = '{0}', Status = 'NotCompleted'
                                                    WHERE OrderID = '{1}' AND ID = '{2}'",y + int.Parse(nudItemsdeliverd.Value.ToString()), txtOrderID.Text,
                                                                                         IDD));
                    MessageBox.Show("Update products success!", "O.M.T | Receiving");
                }
                else
                {
                    crud.ExecuteQuery(String.Format(@"UPDATE Products
                                                     SET Stocks = '{0}'
                                                      WHERE ProdID = '{1}'", x + int.Parse(nudItemsdeliverd.Value.ToString()), txtProdID.Text));
                    crud.CloseConnection();
                    int y = 0;
                    y = asds;
                    crud.ExecuteQuery(String.Format(@"UPDATE OrderedProducts
                                                    SET Delivered = '{0}', Status = 'Completed'
                                                    WHERE OrderID = '{1}' AND ID = '{2}'", y + int.Parse(nudItemsdeliverd.Value.ToString()),txtOrderID.Text,
                                                                                         IDD));
                    MessageBox.Show("Update products success!", "O.M.T | Receiving");
                }
                
                dgv = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("Choose items to update\nby click the items in the products!", "O.M.T | Receiving");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
