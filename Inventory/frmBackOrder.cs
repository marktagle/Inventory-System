using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;
namespace Inventory
{
    public partial class frmBackOrder : Form
    {
        CRUDTools crud = new CRUDTools();
        DGVPrinter printer = new DGVPrinter();
        public frmBackOrder()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
          
           // dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "O.M.T Hardware Store\nBackOrder";

            printer.SubTitle = "BackOrder List";

            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |

                                          StringFormatFlags.NoClip;

            printer.PageNumbers = true;

            printer.PageNumberInHeader = false;

            printer.PorportionalColumns = false;

            printer.HeaderCellAlignment = StringAlignment.Near;

            printer.Footer = "O.M.T Hardware";

            printer.FooterSpacing = 15;

            printer.PrintDataGridView(dgvProducts);
        }

        private void frmBackOrder_Load(object sender, EventArgs e)
        {
            crud.FillDataGrid(@"SELECT OrderID,ProdDesc,SupplierName,Quantity,Delivered FROM OrderedProducts WHERE Status = 'NotCompleted'",ref dgvProducts);
            crud.CloseConnection();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
