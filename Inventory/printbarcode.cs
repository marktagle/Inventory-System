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
using CrystalDecisions.CrystalReports.Engine;
namespace Inventory
{
    public partial class printbarcode : Form
    {
        CRUDTools crud = new CRUDTools();
        string cnString = "";
        OleDbConnection cn;
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter adptr = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        public printbarcode()
        {
            InitializeComponent();
        }
        ReportDocument report = new ReportDocument();
        private void printbarcode_Load(object sender, EventArgs e)
        {
            report.Load(@"C:\Users\Lerry16\Desktop\FIles\Inventory\Inventory\Barcode.rpt");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            cnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryDB.accdb";
            cn = new OleDbConnection(cnString);
            String sql = String.Format("SELECT ProdID FROM Products WHERE ProdID = '{0}'",txtBarcode.Text.Trim());
            cmd = new OleDbCommand(sql, cn);
            adptr = new OleDbDataAdapter(cmd);
            adptr.Fill(ds);
            report.SetDataSource(ds);
            crystalReportViewer1.ReportSource = report;
            cn.Close();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {

        }
    }
}
