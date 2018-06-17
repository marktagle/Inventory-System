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
using System.Data.OleDb;
namespace Inventory
{
    public partial class frmReORder : Form
    {
        CRUDTools crud = new CRUDTools();
        public frmReORder()
        {
            InitializeComponent();
        }

        private void frmReORder_Load(object sender, EventArgs e)
        {
            crud.FillDataGrid(@"SELECT OrderID,ProdDesc,SupplierName,Quantity,Delivered FROM OrderedProducts", ref dgvProducts);
            crud.CloseConnection();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "O.M.T Hardware Store\nReORder";

            printer.SubTitle = "ReOrder List";

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
    }
}
