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
    public partial class frmUserArchives : Form
    {
        CRUDTools crud = new CRUDTools();
        Boolean dgv = false;
        public frmUserArchives()
        {
            InitializeComponent();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProducts.CurrentRow.Index >= 0)
            {
                dgv = true;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgv == true)
            {
                crud.ExecuteQuery(String.Format(@"UPDATE Users
                                                SET Status = 'Ok'
                                                WHERE StaffNo = '{0}'",dgvProducts.CurrentRow.Cells[6].Value.ToString()));
                MessageBox.Show("Retriving account success!", "User Archives | O.M.T");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Select user to proceed!","User Archives | O.M.T");
            }
        }

        private void frmUserArchives_Load(object sender, EventArgs e)
        {
            crud.FillDataGrid(@"SELECT * FROM Users WHERE Status = 'Not Ok'",ref dgvProducts);
            crud.CloseConnection();
        }
    }
}
