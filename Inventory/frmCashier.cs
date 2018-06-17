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
    public partial class frmCashier : Form
    {
        CRUDTools crud = new CRUDTools();
       
        public frmCashier()
        {
            InitializeComponent();
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            btnRemove.Enabled = true;
            btnPay.Enabled = true;
            btnQuantity.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            txtBarcode.Enabled = true;
            txtBarcode.Focus();
            Transaction();
            
        }
        private void Addprod()
        {
            String ProdID = "", ProdName = "", ProdDesc = "", Price = "";
            String sqlprod = String.Format(@"SELECT ProdID,ProdName,ProdDesc,Price FROM Products WHERE ProdID = '{0}'",txtBarcode.Text);
            OleDbDataReader Addprodreader = null;
            crud.RetrieveRecords(sqlprod,ref Addprodreader);
            if (Addprodreader.HasRows)
            {

                Addprodreader.Read();
                ProdID = Addprodreader[0].ToString();
                ProdName = Addprodreader[1].ToString();
                ProdDesc = Addprodreader[2].ToString();
                Price = Addprodreader[3].ToString();
                crud.CloseConnection();
                //MessageBox.Show(String.Format("{0}-{1}-{2}-{3}",ProdID,ProdName,ProdDesc,Price));
                listProdName.Items.Add(ProdDesc);
                listQTY.Items.Add("1");
                listPrice.Items.Add(Price);
                listTotal.Items.Add(Price);
                basket();
                listProdName.SelectedIndex = listProdName.Items.Count - 1;

                String date = "MM/dd/yyyy";
                DateTime dateTime1 = DateTime.Now;
                String textDate = dateTime1.ToString(date);
                
                //String sqlInsertprod = String.Format(@"INSERT INTO PointOfSale
                                                  //VALUES('{0}','{1}','{2}','{3}','{4}','{5}','1')", lblTransaction.Text,
                                                                                                  //ProdID, ProdName, ProdDesc, Price, textDate); 
            }
            else
            {
                 MessageBox.Show("The product code is invalid!", "O.M.T | Cashier");
                 crud.CloseConnection();
            }
            
        }
        private void basket()
        {
            int x = 0;
            Double price = 0.0;
            Double orgprice = 0.0;
            for (int y = x; y < listProdName.Items.Count; y++)
            {
                String sqlsearch = String.Format(@"SELECT * FROM Products WHERE ProdID = (SELECT DISTINCT(ProdID) FROM Products WHERE ProdDesc = '{0}'
                                                )", listProdName.Items[x].ToString());
                OleDbDataReader reader = null;
                crud.RetrieveRecords(sqlsearch , ref reader);
                reader.Read();
                String sorgprice = reader[2].ToString();
                crud.CloseConnection();
                
                price = double.Parse(listTotal.Items[x].ToString());
                orgprice += price;

                txtTotalAmount.Text = "" + orgprice;
                x = x + 1;
                txtTotalItems.Text = "" + x;
                //x = y;
            }
            //txtTotalAmount.Text = "" + aaasd;
            
        }
        private void Transaction()
        {
            int TransID = 0;
            String sqlTrans = String.Format(@"SELECT MAX(PurchaseID) FROM Transactions");
            OleDbDataReader transreader = null;
            crud.RetrieveRecords(sqlTrans ,ref transreader);
            transreader.Read();
            String id = transreader[0].ToString();
            if (id == null || id == "")
            {
                TransID = 1000100001;
                lblTransaction.Text = "" + TransID;
                crud.CloseConnection();
            }
            else
            {
                TransID = int.Parse(id);
                TransID++;
                lblTransaction.Text = "" + TransID;
                crud.CloseConnection();
            }
        }


        private void frmCashier_Load(object sender, EventArgs e)
        {
            String sql = String.Format(@"SELECT * FROM Users WHERE Username = '{0}'", this.Text);
            OleDbDataReader reader = null;
            crud.RetrieveRecords(sql, ref reader);
            reader.Read();
            lblStaffs.Text = reader[6].ToString();
            txtFname.Text = reader[3].ToString();
            txtMiddle.Text = reader[4].ToString();
            txtLast.Text = reader[5].ToString();
            crud.CloseConnection();
            numupQuantity.Maximum = 100;
            numupQuantity.Minimum = 1;
            DateTime dateTime1 = DateTime.Now;
            lblDate.Text = String.Format("{0}/{1}/{2}", dateTime1.Month.ToString(), dateTime1.Day.ToString(), dateTime1.Year.ToString());
        }
        private void loadpos()
        {
            /*String date = "MM/dd/yyyy";
            DateTime dateTime1 = DateTime.Now;
            String textDate= dateTime1.ToString(date);

            String sqlprod = String.Format(@"SELECT ProdID,ProdName,ProdDesc,Price,Quantity FROM Products WHERE ProdID = '{0}'", txtBarcode.Text);
            OleDbDataReader Addprodreader = null;
            crud.RetrieveRecords(sqlprod, ref Addprodreader);
            String sql = String.Format(@"SELECT COUNT(PurchaseID) as ID WHERE PurchaseID = '{0}' AND DOP = '{1}'",textDate,lblTransaction.Text);
            OleDbDataReader countreader = null;
            countreader = crud.RetrieveRecords(sql,ref countreader);
            countreader.Read();
            String count = countreader[0].ToString();
            crud.CloseConnection();
            while(Addprodreader.Read())
            {
                for (int x = 0; x < int.Parse(count);x++)
                {
                    listProdName.Items.Add(Addprodreader[].ToString());
                    listQTY.Items.Add();
                }
            }
            //dgvPOS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //String sqlLoad = String.Format(@"SELECT ProdName,ProdDesc,Price FROM PointOfSale WHERE DOP = '{0}' AND PurchaseID = '{1}'",textDate,lblTransaction.Text);
           // crud.FillDataGrid(sqlLoad, ref dgvPOS);
           // crud.CloseConnection();*/
        }

        private void txtHide_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
            {
                Addprod();
                e.SuppressKeyPress = true;
                e.Handled = true;
                txtBarcode.Text = "";

            }
           if(e.KeyCode == Keys.Up)
           {
               if(listProdName.Items.Count >=1 && listProdName.SelectedIndex > 0)
               {
                   e.SuppressKeyPress = true;
                   e.Handled = true;
                   listProdName.SelectedIndex = listProdName.SelectedIndex - 1;
               }
           }
           if (e.KeyCode == Keys.Down)
           {
               if (listProdName.Items.Count >= 1 && listProdName.SelectedIndex != listProdName.Items.Count - 1)
               {
                  
                  e.SuppressKeyPress = true;
                  e.Handled = true;
                  listProdName.SelectedIndex = listProdName.SelectedIndex + 1;
                   
               }
           }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            String date = "MM/dd/yyyy";
            DateTime dateTime1 = DateTime.Now;
            String textDate= dateTime1.ToString(date);
            if (txtPayment.Text == null || txtPayment.Text == "")
            {
                MessageBox.Show("Theres no payment applied!", "O.M.T | Cashier");
            }
            else
            {
                
                Double totalamount = double.Parse(txtTotalAmount.Text);
                Double pay = double.Parse(txtPayment.Text);
                if (totalamount > pay)
                {
                    MessageBox.Show("The insuficient funds!", "O.M.T | Cashier");
                }
                else
                {
                    for (int x = 0; x < listProdName.Items.Count; x++)
                    {
                        String ProdID = "", ProdName = "",Stocks = "";
                        String sqlsearch = String.Format(@"SELECT * FROM Products WHERE ProdID = (SELECT DISTINCT(ProdID) FROM Products WHERE ProdDesc = '{0}'
                                                )", listProdName.Items[x].ToString());
                        OleDbDataReader reader = null;
                        crud.RetrieveRecords(sqlsearch, ref reader);
                        reader.Read();
                        ProdID = reader[0].ToString();
                        ProdName = reader[1].ToString();
                        Stocks = reader[5].ToString();
                        crud.CloseConnection();
                        txtChange.Text = String.Format("{0:00}",pay-totalamount);
                        String sql = String.Format(@"INSERT INTO PointOfSale
                                            VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                                                    lblTransaction.Text, ProdID, ProdName, listProdName.Items[x].ToString(),
                                                    listPrice.Items[x].ToString(),lblDate.Text, listQTY.Items[x].ToString(), txtTotalAmount.Text);
                        crud.ExecuteQuery(sql);
                        crud.CloseConnection();
                        int stokcscount = int.Parse(Stocks);
                        stokcscount = stokcscount - int.Parse(listQTY.Items[x].ToString());
                        crud.ExecuteQuery(String.Format(@"UPDATE Products SET Stocks ='{0}' WHERE ProdID = '{1}'",stokcscount,ProdID));
                        crud.CloseConnection();
                        
                    }

                    
                    String ssql = String.Format(@"INSERT INTO Transactions
                                            VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", lblTransaction.Text,
                                                                                        txtTotalAmount.Text, txtTotalItems.Text,
                                                                                        txtPayment.Text, txtChange.Text,lblDate.Text);
                    crud.ExecuteQuery(ssql);

                    crud.CloseConnection();
                    MessageBox.Show("Transaction complete\nThank you and come again!", "O.M.T | Cashier");
                    listPrice.Items.Clear();
                    listProdName.Items.Clear();
                    listQTY.Items.Clear();
                    listTotal.Items.Clear();
                    txtTotalAmount.Text = "";
                    txtTotalItems.Text = "";
                    txtChange.Text = "";
                    lblTransaction.Text = "";
                }
            }
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAuthenClose_Click(object sender, EventArgs e)
        {
            
        }

        private void listProdName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int x = listProdName.SelectedIndex;
            listQTY.SelectedIndex = x;
            listPrice.SelectedIndex = x;
            listTotal.SelectedIndex = x;
        }

        private void listQTY_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int x = listQTY.SelectedIndex; ;
            listPrice.SelectedIndex = x;
            listProdName.SelectedIndex = x;
            listTotal.SelectedIndex = x;
        }

        private void listPrice_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int x = listPrice.SelectedIndex;
            listQTY.SelectedIndex = x;
            listProdName.SelectedIndex = x;
            listTotal.SelectedIndex = x;
        }

        private void listPrice_OnVerticalScroll(object sender, ScrollEventArgs e)
        {
           // listQTY.TopIndex = listPrice.TopIndex;
           // listProdName.TopIndex = listPrice.TopIndex;
            //listTotal.TopIndex = listPrice.TopIndex;
        }

        private void listQTY_OnVerticalScroll(object sender, ScrollEventArgs e)
        {
            //listPrice.TopIndex = listQTY.TopIndex;
            //listProdName.TopIndex = listQTY.TopIndex;
            //listTotal.TopIndex = listQTY.TopIndex;
        }

        private void listProdName_OnVerticalScroll(object sender, ScrollEventArgs e)
        {
            //listQTY.TopIndex = listProdName.TopIndex;
            //listPrice.TopIndex = listProdName.TopIndex;
            //listTotal.TopIndex = listProdName.TopIndex;
        }

        private void listProdName_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void listProdName_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void listProdName_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void panel9_Click(object sender, EventArgs e)
        {

        }

        private void panel9_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listProdName.Items.Count >= 1)
            {
                animator1.Show(panellogin);
                btnRemove.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please add product to proceed!", "O.M.T | Cashier");
            }
            
        }

        private void listTotal_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = listTotal.SelectedIndex;
            listPrice.SelectedIndex = x;
            listProdName.SelectedIndex = x;
            listQTY.SelectedIndex = x;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String ProdID = "", ProdName = "", ProdDesc = "", Price = "";
            String sqlprod = String.Format(@"SELECT ProdID,ProdName,ProdDesc,Price FROM Products WHERE ProdID = '{0}'", txtBarcode.Text);
            OleDbDataReader Addprodreader = null;
            crud.RetrieveRecords(sqlprod, ref Addprodreader);
            if (Addprodreader.HasRows)
            {

                Addprodreader.Read();
                ProdID = Addprodreader[0].ToString();
                ProdName = Addprodreader[1].ToString();
                ProdDesc = Addprodreader[2].ToString();
                Price = Addprodreader[3].ToString();
                crud.CloseConnection();
                //MessageBox.Show(String.Format("{0}-{1}-{2}-{3}",ProdID,ProdName,ProdDesc,Price));
                listProdName.Items.Add(ProdDesc);
                listQTY.Items.Add("1");
                listPrice.Items.Add(Price);
                listTotal.Items.Add(Price);
                listProdName.SelectedIndex = listProdName.Items.Count - 1;

                listTotal.Items.Add(Price);
                String date = "MM/dd/yyyy";
                DateTime dateTime1 = DateTime.Now;
                String textDate = dateTime1.ToString(date);
                basket();
                //String sqlInsertprod = String.Format(@"INSERT INTO PointOfSale
                //VALUES('{0}','{1}','{2}','{3}','{4}','{5}','1')", lblTransaction.Text,
                //ProdID, ProdName, ProdDesc, Price, textDate); 
            }
            else
            {
                MessageBox.Show("The product code is invalid!", "O.M.T | Cashier");
                crud.CloseConnection();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            btnRemove.Enabled = false;
            btnQuantity.Enabled = false;
            btnPay.Enabled = false;
            btnCancel.Enabled = false;
            listPrice.Items.Clear();
            listProdName.Items.Clear();
            listQTY.Items.Clear();
            listTotal.Items.Clear();
            txtTotalAmount.Text = "";
            txtTotalItems.Text = "";
            txtChange.Text = "";
            lblTransaction.Text = "";
        }

       

        private void btnthisremove_Click(object sender, EventArgs e)
        {
            if (listProdName.SelectedIndex >= 0)
            {

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
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
                int x = listProdName.SelectedIndex;
                listProdName.Items.RemoveAt(x);
                listPrice.Items.RemoveAt(x);
                listQTY.Items.RemoveAt(x);
                listTotal.Items.RemoveAt(x);

                listProdName.SelectedIndex = listProdName.Items.Count - 1;
                panellogin.Hide();
                btnRemove.Enabled = true;
            }
            else
            {
                crud.CloseConnection();
                MessageBox.Show("Incorrect password or\nAsk the admin personel!", "O.M.T | Cashier");
            }
            crud.CloseConnection();
            
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            panellogin.Hide();
        }

        private void btnSearchItem_Click(object sender, EventArgs e)
        {
            frmSearProduct log = new frmSearProduct();
            System.Windows.Forms.Form f1 = System.Windows.Forms.Application.OpenForms["frmSearProduct"];
            if (((frmSearProduct)f1) != null)
            {
                MessageBox.Show("The search product is already running!", "O.M.T | Cashier");
            }
            else
            {
                log.Show();
            }
        }

        private void btnQuantity_Click(object sender, EventArgs e)
        {
            txtBarcode2.Focus();
            txtBarcode.Enabled = false;
            animator1.Show(Panelquantity);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                String ProdID = "", ProdName = "", ProdDesc = "", Price = "";
                String sqlprod = String.Format(@"SELECT ProdID,ProdName,ProdDesc,Price FROM Products WHERE ProdID = '{0}'", txtBarcode2.Text);
                OleDbDataReader Addprodreader = null;
                crud.RetrieveRecords(sqlprod, ref Addprodreader);
                if (Addprodreader.HasRows)
                {

                    Addprodreader.Read();
                    ProdID = Addprodreader[0].ToString();
                    ProdName = Addprodreader[1].ToString();
                    ProdDesc = Addprodreader[2].ToString();
                    Price = Addprodreader[3].ToString();
                    crud.CloseConnection();
                    //MessageBox.Show(String.Format("{0}-{1}-{2}-{3}",ProdID,ProdName,ProdDesc,Price));
                    listProdName.Items.Add(ProdDesc);
                    Double quant = double.Parse(numupQuantity.Value.ToString());
                    listQTY.Items.Add(quant);
                    listPrice.Items.Add(Price);
                    Double ttprice = double.Parse(Price);
                    Double res = ttprice * quant;
                    listTotal.Items.Add(res);
                    basket();
                    listProdName.SelectedIndex = listProdName.Items.Count - 1;

                    String date = "MM/dd/yyyy";
                    DateTime dateTime1 = DateTime.Now;
                    String textDate = dateTime1.ToString(date);

                    //String sqlInsertprod = String.Format(@"INSERT INTO PointOfSale
                    //VALUES('{0}','{1}','{2}','{3}','{4}','{5}','1')", lblTransaction.Text,
                    //ProdID, ProdName, ProdDesc, Price, textDate); 
                }
                else
                {
                    MessageBox.Show("The product code is invalid!", "O.M.T | Cashier");
                    crud.CloseConnection();
                }
                txtBarcode2.Text = "";
                Panelquantity.Hide();
                txtBarcode.Enabled = true;
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Panelquantity.Hide();
            txtBarcode.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCustomLabel25_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Show();
            this.Close();
        }
    }
}
