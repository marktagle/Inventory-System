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
    public partial class frmchoosesupplier : Form
    {
        CRUDTools crud = new CRUDTools();
        Boolean dgv = false;
        public frmchoosesupplier()
        {
            InitializeComponent();
        }

        private void frmchoosesupplier_Load(object sender, EventArgs e)
        {
            crud.FillDataGrid(@"SELECT * FROM Suppliers",ref dgvSuppliers);
            crud.CloseConnection();
        }

        private void btnChoosesup_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSuppliers.CurrentRow.Index >= 0)
            {
                dgv = true;
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (dgv == true)
            {
                frmOrder f1 = (frmOrder)Application.OpenForms["frmOrder"];
                f1.txtSupplierID.Text = dgvSuppliers.CurrentRow.Cells[0].Value.ToString();
                f1.txtSupplierName.Text = dgvSuppliers.CurrentRow.Cells[1].Value.ToString();
                f1.txtContactNo.Text = dgvSuppliers.CurrentRow.Cells[3].Value.ToString();
                f1.Refresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please choose supplier!", "O.M.T | Cashier");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
