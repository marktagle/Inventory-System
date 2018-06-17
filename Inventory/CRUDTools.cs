using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace Inventory
{
    class CRUDTools
    {
        //declare variables and objects
        string cnString = "";
        OleDbConnection cn;
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter adptr = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        public CRUDTools()
        {
            //provider for MS Access
            cnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventoryDB.accdb";
            cn = new OleDbConnection(cnString);
        }

        public void FillDataGrid(string sql, ref DataGridView dg)
        {
            try
            {
                cn.Open(); //opening connection to db
                //instantiate command and adapter with query
                cmd = new OleDbCommand(sql, cn);
                adptr = new OleDbDataAdapter(cmd);

                ds = new DataSet();             //remove previous data
                adptr.Fill(ds);                 // load result to data
                dg.DataSource = "";             //clear contents of datagrid
                dg.DataSource = ds.Tables[0];   //load records to datagrid
                dg.AutoResizeColumns();          //autofit content
                //dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e.Message);
            }
            cn.Close();
        }

        public void ExecuteQuery(string sql)
        {
            try
            {
                cn.Open();
                cmd = new OleDbCommand(sql, cn);
                cmd.ExecuteNonQuery(); //implement sql command

            }
            catch (Exception e)
            {
                MessageBox.Show("" + e.Message);
            }
            cn.Close();
        }

        public OleDbDataReader RetrieveRecords(string sql, ref OleDbDataReader reader)
        {
            try
            {
                cn.Open();
                cmd = new OleDbCommand(sql, cn);
                reader = cmd.ExecuteReader();
                return reader;
                //cn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e.Message);
                return null;
            }
        }
        public void CloseConnection()
        {
            cn.Close();
        }
    }
}
