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
    public partial class frmOrder : Form
    {
        CRUDTools crud = new CRUDTools();
        Boolean dgv = false;
        public frmOrder()
        {
            InitializeComponent();
            
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            orderIDasd();
            String sqldgv = String.Format(@"SELECT * FROM Products");
            crud.FillDataGrid(sqldgv,ref dgvProducts);
            crud.CloseConnection();
            
            txtEquantity.Maximum = 100;
            txtEquantity.Minimum = 1;
            DateTime dateTime1 = DateTime.Now;
            lblDate.Text = String.Format("{0}/{1}/{2}",dateTime1.Month.ToString(),dateTime1.Day.ToString(),dateTime1.Year.ToString());
            cbxSearchBy.SelectedIndex = 0;

        }
        private void orderIDasd()
        {
            OleDbDataReader reader = null;
            crud.RetrieveRecords(@"SELECT MAX(OrderID) FROM OrderTransaction",ref reader);
            reader.Read();
            String Maxss = reader[0].ToString();
            
            if (Maxss == null || Maxss == "")
            {
                lblOrderID.Text = "100100";
                    crud.CloseConnection();
            }
            else
            {
                int max2 = int.Parse(Maxss);
                max2++;
                lblOrderID.Text = "" + max2;
                crud.CloseConnection();
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvProducts.CurrentRow.Index >= 0)
            {
                dgv = true;
                txtProdDesc.Text = dgvProducts.CurrentRow.Cells[1].Value.ToString();
                txtProdName.Text = dgvProducts.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv == true)
            {
                if (txtSupplierName.Text == "" || txtSupplierName.Text == null)
                {
                    MessageBox.Show("Please choose a supplier!", "O.M.T | Ordering");
                }
                else
                {
                    animator1.Show(panelQuantity);
                    dgvProducts.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Click on the items first to proceed!", "O.M.T | Ordering");
            }
        }

        private void btnQuantityclose_Click(object sender, EventArgs e)
        {
            panelQuantity.Hide();
            dgv = false;
            dgvProducts.Enabled = true;
        }

        private void btnquanaddproducts_Click(object sender, EventArgs e)
        {
           
        }

        private void btnChooseSupplier_Click(object sender, EventArgs e)
        {
            frmchoosesupplier log = new frmchoosesupplier();
            System.Windows.Forms.Form f1 = System.Windows.Forms.Application.OpenForms["frmchoosesupplier"];
            if (((frmchoosesupplier)f1) != null)
            {
                MessageBox.Show("The Supplier from is already running!", "O.M.T | Cashier");
            }
            else
            {
                log.Show();
            }
        }

        private void listProdName_SelectedIndexChanged(object sender, EventArgs e)
        {
            listSupplier.SelectedIndex = listProdName.SelectedIndex;
            listQuantity.SelectedIndex = listProdName.SelectedIndex;
        }

        private void listQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            listProdName.SelectedIndex = listQuantity.SelectedIndex;
            listSupplier.SelectedIndex = listQuantity.SelectedIndex;
        }

        private void listSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            listQuantity.SelectedIndex = listSupplier.SelectedIndex;
            listProdName.SelectedIndex = listSupplier.SelectedIndex;
        }

        private void btnOrderprod_Click(object sender, EventArgs e)
        {
            if (listProdName.Items.Count >= 1)
            {
                animator1.Show(panellogin);
            }
            else
            {
                MessageBox.Show("Add products first to proceed!", "O.M.T | Cashier");
            }
          
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAuthClose_Click(object sender, EventArgs e)
        {
            panellogin.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            String sqlcount = String.Format(@"SELECT COUNT(Accpassword) FROM Users");
            OleDbDataReader countreader = null;
            crud.RetrieveRecords(sqlcount, ref countreader);
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
                crud.CloseConnection();
                int x = 0;
                int rescount = 0;
                for (int asd = x; x < listProdName.Items.Count; x++)
                {
                    String date = "MM/dd/yyyy";
                    DateTime dateTime1 = DateTime.Now;
                    String textDate = dateTime1.ToString(date);
                    OleDbDataReader reader33 = null, reader2 = null;
                    crud.RetrieveRecords(String.Format(@"SELECT * FROM Products WHERE ProdDesc = '{0}'", listProdName.Items[asd].ToString()), ref reader33);
                    reader33.Read();
                    String prodIDs = "", prodName = "";
                    prodIDs = reader33[0].ToString();
                    prodName = reader33[1].ToString();
                    crud.CloseConnection();
                    crud.RetrieveRecords(String.Format(@"SELECT * FROM Suppliers WHERE SupplierName = '{0}'", listSupplier.Items[asd].ToString()), ref reader2);
                    reader2.Read();
                    String supplierIDs = "", supplierName = "";
                    supplierIDs = reader2[0].ToString();
                    supplierName = reader2[1].ToString();
                    crud.CloseConnection();
                    int asds = 1;
                    crud.ExecuteQuery(String.Format(@"INSERT INTO OrderedProducts
                                    VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','0','NotCompleted','{8}')",
                                        lblOrderID.Text, prodIDs, prodName, listProdName.Items[asd].ToString(),
                                        supplierIDs, supplierName,lblDate.Text, listQuantity.Items[asd].ToString(),asds + int.Parse(lblOrderID.Text)));
                    crud.CloseConnection();

                    int count2 = int.Parse(listQuantity.Items[asd].ToString());
                    rescount = rescount + count2;
                }
                String date2 = "MM/dd/yyyy";
                DateTime dateTime12 = DateTime.Now;
                String textDate2 = dateTime12.ToString(date2);

                crud.ExecuteQuery(String.Format(@"INSERT INTO OrderTransaction
                                            VALUES('{0}','{1}','{2}')",
                                                lblOrderID.Text, rescount, lblDate.Text));
                crud.CloseConnection();
                MessageBox.Show("Ordering procces was complete\nPLeasecheck on the oreder list!", "O.M.T | Ordering");
                panellogin.Hide();
                this.Close();
            }
            else
            {
                crud.CloseConnection();
                MessageBox.Show("Incorrect password or\nAsk the admin personel!", "O.M.T | Ordering");
            }
            crud.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listProdName.SelectedIndex >= 0)
            {
                listQuantity.Items.RemoveAt(listProdName.SelectedIndex);
                listSupplier.Items.RemoveAt(listProdName.SelectedIndex);
                listProdName.Items.RemoveAt(listProdName.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Choose products to remove!", "O.M.T | Ordering");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listProdName.Items.Add(txtProdDesc.Text);
            listQuantity.Items.Add(txtEquantity.Text);
            listSupplier.Items.Add(txtSupplierName.Text);
            txtSupplierID.Clear();
            txtSupplierName.Clear();
            txtContactNo.Clear();
            txtProdDesc.Clear();
            txtProdName.Clear();
            panelQuantity.Hide();
            dgvProducts.Enabled = true;
            dgv = false;
            
        }

        private void txtEquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            string acceptableKeys = "0123456789";
            if (acceptableKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
