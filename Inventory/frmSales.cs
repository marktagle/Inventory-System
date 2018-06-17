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
    public partial class frmSales : Form
    {

        DGVPrinter printer = new DGVPrinter();
        CRUDTools crud = new CRUDTools();
        public frmSales()
        {
            InitializeComponent();
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            crud.FillDataGrid("SELECT ProdDesc, Price,DOP,Quantity,TotalAmount FROM PointOfSale", ref dgvProducts);
            crud.CloseConnection();
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crud.FillDataGrid(String.Format(@"SELECT ProdDesc, Price,DOP,Quantity,TotalAmount FROM PointOfSale
                                            WHERE DOP BETWEEN '{0}' AND '{1}'",dtFrom.Value,dtTo.Value), ref dgvProducts);
            crud.CloseConnection();
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVPrinter printer = new DGVPrinter();
            
            printer.Title = "O.M.T Hardware Store\nSales";

            printer.SubTitle = "Sales Information";

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

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            crud.FillDataGrid(String.Format(@"SELECT ProdDesc, Price,DOP,Quantity,TotalAmount FROM PointOfSale
                                            WHERE DOP BETWEEN '{0}' AND '{1}'", dtFrom.Value, dtTo.Value), ref dgvProducts);
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            crud.FillDataGrid(String.Format(@"SELECT ProdDesc, Price,DOP,Quantity,TotalAmount FROM PointOfSale
                                            WHERE DOP BETWEEN '{0}' AND '{1}'", dtFrom.Value, dtTo.Value), ref dgvProducts);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
