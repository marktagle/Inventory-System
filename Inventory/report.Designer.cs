namespace Inventory
{
    partial class report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            //Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            //this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.InventoryDBDataSet = new Inventory.InventoryDBDataSet();
            this.PointOfSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PointOfSaleTableAdapter = new Inventory.InventoryDBDataSetTableAdapters.PointOfSaleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointOfSaleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            //this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            //reportDataSource1.Name = "DataSet1";
            //reportDataSource1.Value = this.PointOfSaleBindingSource;
            //this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            //this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory.Report1.rdlc";
            //this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            //this.reportViewer1.Name = "reportViewer1";
            //this.reportViewer1.Size = new System.Drawing.Size(1364, 486);
            //this.reportViewer1.TabIndex = 0;
            // 
            // InventoryDBDataSet
            // 
            this.InventoryDBDataSet.DataSetName = "InventoryDBDataSet";
            this.InventoryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PointOfSaleBindingSource
            // 
            this.PointOfSaleBindingSource.DataMember = "PointOfSale";
            this.PointOfSaleBindingSource.DataSource = this.InventoryDBDataSet;
            // 
            // PointOfSaleTableAdapter
            // 
            this.PointOfSaleTableAdapter.ClearBeforeFill = true;
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 486);
            //this.Controls.Add(this.reportViewer1);
            this.Name = "report";
            this.Text = "report";
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointOfSaleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PointOfSaleBindingSource;
        private InventoryDBDataSet InventoryDBDataSet;
        private InventoryDBDataSetTableAdapters.PointOfSaleTableAdapter PointOfSaleTableAdapter;
    }
}