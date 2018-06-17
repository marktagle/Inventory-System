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
    public partial class frmSfaffs : Form
    {
        CRUDTools crud = new CRUDTools();
        Boolean dgv = false;
        String cbxStaffsssss = "";
        public frmSfaffs()
        {
            InitializeComponent();
        }

        private void panelStafs_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void frmSfaffs_Load(object sender, EventArgs e)
        {
            String sql = String.Format(@"SELECT Username,Accpassword,AccountType,FirstName,MiddleInitial,LastName,StaffNo,Status FROM Users
                                        WHERE AccountType = 'Cashier' AND Status = 'Ok'");
            crud.FillDataGrid(sql, ref dgvStaffs);

            cbxSearchBy.SelectedIndex = 0;
        }

        private void dgvStaffs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv = true;
            if (dgvStaffs.CurrentRow.Index >= 0)
            {
                txtUsernames.Text = dgvStaffs.CurrentRow.Cells[0].Value.ToString();
                txtPasswords.Text = dgvStaffs.CurrentRow.Cells[1].Value.ToString();
                cbxAccountType.SelectedItem = dgvStaffs.CurrentRow.Cells[2].Value.ToString();
                txtFirstNames.Text = dgvStaffs.CurrentRow.Cells[3].Value.ToString();
                txtMiddles.Text = dgvStaffs.CurrentRow.Cells[4].Value.ToString();
                txtLastNames.Text = dgvStaffs.CurrentRow.Cells[5].Value.ToString();
                txtStaffNo.Text = dgvStaffs.CurrentRow.Cells[6].Value.ToString();
                
            }
        }

        private void txtSearchBy_TextChanged(object sender, EventArgs e)
        {
            String sql = "";
                //sql = String.Format(@"SELECT * FROM Users WHERE {0} LIKE = '%{1}%' AND AccountType = 'Cashier'",cbxSearchBy.Text.ToString(),txtSearchBy.Text.Trim());
            switch(cbxSearchBy.SelectedIndex)
            {
                case 0:
                    sql = "SELECT * FROM Users WHERE FirstName LIKE '%" + txtSearchBy.Text + "%' AND AccountType = 'Cashier'";
                    break;
                case 1:
                    sql = "SELECT * FROM Users WHERE MiddleInitial LIKE '%" + txtSearchBy.Text + "%'  AND AccountType = 'Cashier'";
                    break;
                case 2:
                    sql = "SELECT * FROM Users WHERE LastName LIKE '%" + txtSearchBy.Text + "%'  AND AccountType = 'Cashier'";
                    break;
            }
            crud.FillDataGrid(sql,ref dgvStaffs);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            //clear();
            
            if (btnAdd.ButtonText == "Save")
            {
                if ((txtFirstNames.Text == "" || txtFirstNames.Text == null) || (txtLastNames.Text== "" || txtLastNames.Text== null) || (txtUsernames.Text == "" || txtUsernames.Text ==null ) || (txtPasswords.Text == "" || txtPasswords.Text == null))
                {
                    MessageBox.Show("Fill the blank Fields!", "O.M.T | Staffs");
                }
                else
                {
                    String sqlsearch = String.Format(@"SELECT * FROM Users WHERE Username = '{0}'", txtUsernames.Text.ToString().Trim());
                     OleDbDataReader reader = null;
                    reader = crud.RetrieveRecords(sqlsearch, ref reader);
                    if(reader.HasRows)
                    {
                        
                        MessageBox.Show("The Username was already used!", "O.M.T | Staffs");
                        crud.CloseConnection();
                    }
                    else
                    {
                        crud.CloseConnection();
                        String sql = String.Format(@"INSERT INTO Users
                                                 Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','Ok')", txtUsernames.Text.ToString().Trim(), txtPasswords.Text.ToString().Trim()
                                                                                                  ,cbxStaffsssss.Trim(), txtFirstNames.Text.ToString().Trim()
                                                                                                  , txtMiddles.Text.ToString().Trim(), txtLastNames.Text.ToString().Trim(), txtStaffNo.Text.ToString().Trim());
                        crud.ExecuteQuery(sql);
                        MessageBox.Show("Adding new account was succesful !", "O.M.T | Staffs");
                        clear();
                        dgvStaffs.Enabled = true;
                        txtFirstNames.Enabled = false;
                        txtMiddles.Enabled = false;
                        txtLastNames.Enabled = false;
                        txtUsernames.Enabled = false;
                        txtPasswords.Enabled = false;
                        cbxAccountType.Enabled = false;
                        btnAdd.ButtonText = "Add New";
                        btnUpdate.Show();
                        btnRemove.Show();

                        String sqlrefill = String.Format(@"SELECT * FROM Users
                                        WHERE AccountType = 'Cashier' AND Status = 'Ok'");
                        crud.FillDataGrid(sqlrefill, ref dgvStaffs);
                    }
                   /* String sql = String.Format(@"INSERT INTO Users
                                                 Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','Ok')",txtUsername.Text,txtPassword.Text
                                                                                                  ,cbxAccountType.Text,txtFirstName.Text
                                                                                                  ,txtMiddle.Text,txtLastName.Text,txtStaffNo.Text);*/
                }
            }
            else
            {

                clear();
                btnClear.ButtonText = "Cancel";
                cbxAccountType.SelectedIndex = 0;
                dgvStaffs.Enabled = false;
                txtFirstNames.Enabled = true;
                txtMiddles.Enabled = true;
                txtLastNames.Enabled = true;
                txtUsernames.Enabled = true;
                txtPasswords.Enabled = true;
                cbxAccountType.Enabled = true;
                btnAdd.ButtonText = "Save";
                btnUpdate.Hide();
                btnRemove.Hide();
                String sqlStaff = String.Format(@"SELECT max(StaffNo) FROM Users");
                OleDbDataReader Staffreader = null;
                Staffreader = crud.RetrieveRecords(sqlStaff, ref Staffreader);
                Staffreader.Read();
                String Staffno = Staffreader[0].ToString();
                crud.CloseConnection();
                String[] res = Staffno.Split('-');
                int id = int.Parse(res[1]);
                id++;
                txtStaffNo.Text = String.Format("{0}-{1}", res[0].ToString(), id);
            }
        }
        private void clear()
        {
            txtFirstNames.Text = "";
            txtMiddles.Text = "";
            txtLastNames.Text = "";
            txtUsernames.Text = "";
            txtPasswords.Text = "";
            cbxAccountType.Items.Clear();
            cbxAccountType.Items.Add("Admin");
            cbxAccountType.Items.Add("Cashier");

            dgv = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (btnClear.ButtonText == "Clear")
            {
                clear();
            }
            else
            {
                dgvStaffs.Enabled = true;
                txtFirstNames.Enabled = false;
                txtMiddles.Enabled = false;
                txtLastNames.Enabled = false;
                txtUsernames.Enabled = false;
                txtPasswords.Enabled = false;
                cbxAccountType.Enabled = false;
                clear();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgv == true)
            {
                
                    if (MessageBox.Show("Are ypur sure you want to remove this account ?", "O.M.T | Staffs", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        String sql = String.Format(@"UPDATE Users
                                                    SET Status = 'Not Ok'
                                                    WHERE StaffNo = '{0}'",txtStaffNo.Text.ToString());
                        crud.ExecuteQuery(sql);
                        crud.CloseConnection();

                        String sqlUpdate = String.Format(@"SELECT * FROM Users
                                        WHERE AccountType = 'Cashier' AND Status = 'Ok'");
                        crud.FillDataGrid(sqlUpdate, ref dgvStaffs);

                        dgv = false;
                    }
                
            }
            else
            {
                MessageBox.Show("Please Select a staff to remove!", "O.M.T | Staffs");
            }
        }

        private void cbxAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbxAccountType.SelectedIndex)
            {
                case 0:
                    cbxStaffsssss = String.Format("Admin");
                    break;
                case 1:
                    cbxStaffsssss = "Cashier";
                    break;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.ButtonText == "Update")
            {
                txtFirstNames.Enabled = true;
                txtMiddles.Enabled = true;
                txtLastNames.Enabled = true;
                btnAdd.Hide();
                btnRemove.Hide();
                btnUpdate.ButtonText = "Save";

            }
            else
            {
                if (dgv == true)
                {



                    if ((txtFirstNames.Text == "" || txtFirstNames.Text == null) || (txtLastNames.Text == "" || txtLastNames.Text == null) || (txtUsernames.Text == "" || txtUsernames.Text == null) || (txtPasswords.Text == "" || txtPasswords.Text == null))
                    {
                        MessageBox.Show("Fill the blank Fields!", "O.M.T | Staffs");
                    }
                    else
                    {
                        if (MessageBox.Show("Are ypur sure you want to update this account ?", "O.M.T | Staffs", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            txtFirstNames.Enabled = false;
                            txtMiddles.Enabled = false;
                            txtLastNames.Enabled = false;
                            dgv = false;

                            String sql = String.Format(@"UPDATE Users
                                                    SET FirstName = '{0}',MiddleInitial = '{1}',LastName = '{2}'
                                                    WHERE StaffNo = '{3}'",
                                                        txtFirstNames.Text.Trim(), txtMiddles.Text.Trim(), txtLastNames.Text.Trim(),
                                                        txtStaffNo.Text
                                                        );
                            clear();
                            btnAdd.Show();
                            btnRemove.Show();
                            btnUpdate.ButtonText = "Update";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Select a staff to update!", "O.M.T | Staffs");
                }
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var form = frmSfaffs.ActiveForm as AdminMain;
            form.button1.PerformClick();
        }
    }
}
