namespace Inventory
{
    partial class frmOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.logoadmin = new System.Windows.Forms.PictureBox();
            this.lblStaffs = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnLogin = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOrderprod = new System.Windows.Forms.Button();
            this.lblOrderID = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAddprodtolist = new System.Windows.Forms.Button();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.listSupplier = new Inventory.SyncListBox();
            this.listQuantity = new Inventory.SyncListBox();
            this.listProdName = new Inventory.SyncListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnChooseSupplier = new System.Windows.Forms.Button();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtProdDesc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelQuantity = new System.Windows.Forms.Panel();
            this.txtEquantity = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQuantityclose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panellogin = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtPass1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAuthClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbxSearchBy = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtSearchBy = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.animator1 = new BunifuAnimatorNS.Animator(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoadmin)).BeginInit();
            this.btnLogin.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelQuantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEquantity)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panellogin.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.header.Controls.Add(this.btnClose);
            this.header.Controls.Add(this.bunifuSeparator1);
            this.header.Controls.Add(this.logoadmin);
            this.header.Controls.Add(this.lblStaffs);
            this.animator1.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(973, 43);
            this.header.TabIndex = 4;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 36);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(973, 10);
            this.bunifuSeparator1.TabIndex = 3;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // logoadmin
            // 
            this.animator1.SetDecoration(this.logoadmin, BunifuAnimatorNS.DecorationType.None);
            this.logoadmin.Image = ((System.Drawing.Image)(resources.GetObject("logoadmin.Image")));
            this.logoadmin.Location = new System.Drawing.Point(12, 6);
            this.logoadmin.Name = "logoadmin";
            this.logoadmin.Size = new System.Drawing.Size(30, 30);
            this.logoadmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoadmin.TabIndex = 1;
            this.logoadmin.TabStop = false;
            // 
            // lblStaffs
            // 
            this.lblStaffs.AutoSize = true;
            this.animator1.SetDecoration(this.lblStaffs, BunifuAnimatorNS.DecorationType.None);
            this.lblStaffs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStaffs.Location = new System.Drawing.Point(48, 12);
            this.lblStaffs.Name = "lblStaffs";
            this.lblStaffs.Size = new System.Drawing.Size(55, 21);
            this.lblStaffs.TabIndex = 0;
            this.lblStaffs.Text = "Order";
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.Controls.Add(this.lblDate);
            this.btnLogin.Controls.Add(this.button1);
            this.btnLogin.Controls.Add(this.btnOrderprod);
            this.btnLogin.Controls.Add(this.lblOrderID);
            this.btnLogin.Controls.Add(this.bunifuCustomLabel14);
            this.btnLogin.Controls.Add(this.btnAddprodtolist);
            this.btnLogin.Controls.Add(this.bunifuCustomLabel11);
            this.btnLogin.Controls.Add(this.bunifuCustomLabel10);
            this.btnLogin.Controls.Add(this.bunifuCustomLabel2);
            this.btnLogin.Controls.Add(this.listSupplier);
            this.btnLogin.Controls.Add(this.listQuantity);
            this.btnLogin.Controls.Add(this.listProdName);
            this.btnLogin.Controls.Add(this.groupBox3);
            this.btnLogin.Controls.Add(this.groupBox2);
            this.btnLogin.Controls.Add(this.groupBox1);
            this.animator1.SetDecoration(this.btnLogin, BunifuAnimatorNS.DecorationType.None);
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogin.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(27)))), ((int)(((byte)(44)))));
            this.btnLogin.GradientBottomRight = System.Drawing.SystemColors.WindowText;
            this.btnLogin.GradientTopLeft = System.Drawing.Color.DarkSalmon;
            this.btnLogin.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(27)))), ((int)(((byte)(44)))));
            this.btnLogin.Location = new System.Drawing.Point(0, 43);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Quality = 10;
            this.btnLogin.Size = new System.Drawing.Size(973, 580);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.lblDate, BunifuAnimatorNS.DecorationType.None);
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDate.Location = new System.Drawing.Point(749, 12);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(55, 21);
            this.lblDate.TabIndex = 37;
            this.lblDate.Text = "Order";
            this.lblDate.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.animator1.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(715, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 52);
            this.button1.TabIndex = 36;
            this.button1.Text = "Remove products";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOrderprod
            // 
            this.btnOrderprod.BackColor = System.Drawing.Color.SeaGreen;
            this.animator1.SetDecoration(this.btnOrderprod, BunifuAnimatorNS.DecorationType.None);
            this.btnOrderprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderprod.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderprod.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOrderprod.Location = new System.Drawing.Point(841, 527);
            this.btnOrderprod.Name = "btnOrderprod";
            this.btnOrderprod.Size = new System.Drawing.Size(120, 52);
            this.btnOrderprod.TabIndex = 35;
            this.btnOrderprod.Text = "Order products";
            this.btnOrderprod.UseVisualStyleBackColor = false;
            this.btnOrderprod.Click += new System.EventHandler(this.btnOrderprod_Click);
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.lblOrderID, BunifuAnimatorNS.DecorationType.None);
            this.lblOrderID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOrderID.Location = new System.Drawing.Point(90, 12);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(55, 21);
            this.lblOrderID.TabIndex = 34;
            this.lblOrderID.Text = "Order";
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bunifuCustomLabel14, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(12, 12);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(72, 21);
            this.bunifuCustomLabel14.TabIndex = 5;
            this.bunifuCustomLabel14.Text = "OrderID";
            // 
            // btnAddprodtolist
            // 
            this.btnAddprodtolist.BackColor = System.Drawing.Color.SeaGreen;
            this.animator1.SetDecoration(this.btnAddprodtolist, BunifuAnimatorNS.DecorationType.None);
            this.btnAddprodtolist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddprodtolist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddprodtolist.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddprodtolist.Location = new System.Drawing.Point(356, 527);
            this.btnAddprodtolist.Name = "btnAddprodtolist";
            this.btnAddprodtolist.Size = new System.Drawing.Size(145, 52);
            this.btnAddprodtolist.TabIndex = 32;
            this.btnAddprodtolist.Text = "Add Product to list";
            this.btnAddprodtolist.UseVisualStyleBackColor = false;
            this.btnAddprodtolist.Click += new System.EventHandler(this.button2_Click);
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bunifuCustomLabel11, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(838, 267);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(58, 17);
            this.bunifuCustomLabel11.TabIndex = 31;
            this.bunifuCustomLabel11.Text = "Supplier";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bunifuCustomLabel10, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(741, 267);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(63, 17);
            this.bunifuCustomLabel10.TabIndex = 30;
            this.bunifuCustomLabel10.Text = "Quantity";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(508, 267);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(103, 17);
            this.bunifuCustomLabel2.TabIndex = 18;
            this.bunifuCustomLabel2.Text = "Product Name";
            // 
            // listSupplier
            // 
            this.listSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.animator1.SetDecoration(this.listSupplier, BunifuAnimatorNS.DecorationType.None);
            this.listSupplier.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSupplier.FormattingEnabled = true;
            this.listSupplier.ItemHeight = 17;
            this.listSupplier.Location = new System.Drawing.Point(821, 287);
            this.listSupplier.Name = "listSupplier";
            this.listSupplier.Size = new System.Drawing.Size(142, 238);
            this.listSupplier.TabIndex = 29;
            this.listSupplier.SelectedIndexChanged += new System.EventHandler(this.listSupplier_SelectedIndexChanged);
            // 
            // listQuantity
            // 
            this.listQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.animator1.SetDecoration(this.listQuantity, BunifuAnimatorNS.DecorationType.None);
            this.listQuantity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listQuantity.FormattingEnabled = true;
            this.listQuantity.ItemHeight = 17;
            this.listQuantity.Location = new System.Drawing.Point(746, 287);
            this.listQuantity.Name = "listQuantity";
            this.listQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listQuantity.Size = new System.Drawing.Size(96, 238);
            this.listQuantity.TabIndex = 28;
            this.listQuantity.SelectedIndexChanged += new System.EventHandler(this.listQuantity_SelectedIndexChanged);
            // 
            // listProdName
            // 
            this.listProdName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.animator1.SetDecoration(this.listProdName, BunifuAnimatorNS.DecorationType.None);
            this.listProdName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listProdName.FormattingEnabled = true;
            this.listProdName.ItemHeight = 17;
            this.listProdName.Location = new System.Drawing.Point(511, 287);
            this.listProdName.Name = "listProdName";
            this.listProdName.Size = new System.Drawing.Size(254, 238);
            this.listProdName.TabIndex = 27;
            this.listProdName.SelectedIndexChanged += new System.EventHandler(this.listProdName_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnChooseSupplier);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel6);
            this.groupBox3.Controls.Add(this.txtContactNo);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel4);
            this.groupBox3.Controls.Add(this.txtSupplierID);
            this.groupBox3.Controls.Add(this.bunifuCustomLabel5);
            this.groupBox3.Controls.Add(this.txtSupplierName);
            this.animator1.SetDecoration(this.groupBox3, BunifuAnimatorNS.DecorationType.None);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(753, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 225);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Supplier InFormation";
            // 
            // btnChooseSupplier
            // 
            this.btnChooseSupplier.BackColor = System.Drawing.Color.SeaGreen;
            this.animator1.SetDecoration(this.btnChooseSupplier, BunifuAnimatorNS.DecorationType.None);
            this.btnChooseSupplier.ForeColor = System.Drawing.Color.White;
            this.btnChooseSupplier.Location = new System.Drawing.Point(35, 192);
            this.btnChooseSupplier.Name = "btnChooseSupplier";
            this.btnChooseSupplier.Size = new System.Drawing.Size(149, 27);
            this.btnChooseSupplier.TabIndex = 24;
            this.btnChooseSupplier.Text = "Choose Supplier";
            this.btnChooseSupplier.UseVisualStyleBackColor = false;
            this.btnChooseSupplier.Click += new System.EventHandler(this.btnChooseSupplier_Click);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.animator1.SetDecoration(this.bunifuCustomLabel6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(15, 140);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(90, 17);
            this.bunifuCustomLabel6.TabIndex = 23;
            this.bunifuCustomLabel6.Text = "Contact No.";
            // 
            // txtContactNo
            // 
            this.animator1.SetDecoration(this.txtContactNo, BunifuAnimatorNS.DecorationType.None);
            this.txtContactNo.Enabled = false;
            this.txtContactNo.Location = new System.Drawing.Point(18, 160);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(178, 27);
            this.txtContactNo.TabIndex = 22;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.animator1.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(14, 28);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(75, 17);
            this.bunifuCustomLabel4.TabIndex = 21;
            this.bunifuCustomLabel4.Text = "Supplier ID";
            // 
            // txtSupplierID
            // 
            this.animator1.SetDecoration(this.txtSupplierID, BunifuAnimatorNS.DecorationType.None);
            this.txtSupplierID.Enabled = false;
            this.txtSupplierID.Location = new System.Drawing.Point(17, 48);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(179, 27);
            this.txtSupplierID.TabIndex = 20;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.animator1.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(15, 76);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(102, 17);
            this.bunifuCustomLabel5.TabIndex = 19;
            this.bunifuCustomLabel5.Text = "Supplier Name";
            // 
            // txtSupplierName
            // 
            this.animator1.SetDecoration(this.txtSupplierName, BunifuAnimatorNS.DecorationType.None);
            this.txtSupplierName.Enabled = false;
            this.txtSupplierName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.Location = new System.Drawing.Point(18, 96);
            this.txtSupplierName.Multiline = true;
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(178, 41);
            this.txtSupplierName.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.bunifuCustomLabel3);
            this.groupBox2.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox2.Controls.Add(this.txtProdName);
            this.groupBox2.Controls.Add(this.txtProdDesc);
            this.animator1.SetDecoration(this.groupBox2, BunifuAnimatorNS.DecorationType.None);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(511, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 225);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products InFormation";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.animator1.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(9, 77);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(135, 17);
            this.bunifuCustomLabel3.TabIndex = 23;
            this.bunifuCustomLabel3.Text = "Product Description";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.animator1.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(9, 24);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(103, 17);
            this.bunifuCustomLabel1.TabIndex = 19;
            this.bunifuCustomLabel1.Text = "Product Name";
            // 
            // txtProdName
            // 
            this.animator1.SetDecoration(this.txtProdName, BunifuAnimatorNS.DecorationType.None);
            this.txtProdName.Enabled = false;
            this.txtProdName.Location = new System.Drawing.Point(12, 44);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(202, 27);
            this.txtProdName.TabIndex = 18;
            // 
            // txtProdDesc
            // 
            this.animator1.SetDecoration(this.txtProdDesc, BunifuAnimatorNS.DecorationType.None);
            this.txtProdDesc.Enabled = false;
            this.txtProdDesc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdDesc.Location = new System.Drawing.Point(12, 97);
            this.txtProdDesc.Multiline = true;
            this.txtProdDesc.Name = "txtProdDesc";
            this.txtProdDesc.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtProdDesc.Size = new System.Drawing.Size(202, 109);
            this.txtProdDesc.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.panelQuantity);
            this.groupBox1.Controls.Add(this.panellogin);
            this.groupBox1.Controls.Add(this.cbxSearchBy);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel8);
            this.groupBox1.Controls.Add(this.txtSearchBy);
            this.groupBox1.Controls.Add(this.dgvProducts);
            this.animator1.SetDecoration(this.groupBox1, BunifuAnimatorNS.DecorationType.None);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 491);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            // 
            // panelQuantity
            // 
            this.panelQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panelQuantity.Controls.Add(this.txtEquantity);
            this.panelQuantity.Controls.Add(this.button3);
            this.panelQuantity.Controls.Add(this.bunifuCustomLabel12);
            this.panelQuantity.Controls.Add(this.panel2);
            this.animator1.SetDecoration(this.panelQuantity, BunifuAnimatorNS.DecorationType.None);
            this.panelQuantity.Location = new System.Drawing.Point(191, 268);
            this.panelQuantity.Name = "panelQuantity";
            this.panelQuantity.Size = new System.Drawing.Size(291, 202);
            this.panelQuantity.TabIndex = 18;
            this.panelQuantity.Visible = false;
            // 
            // txtEquantity
            // 
            this.animator1.SetDecoration(this.txtEquantity, BunifuAnimatorNS.DecorationType.None);
            this.txtEquantity.Location = new System.Drawing.Point(21, 97);
            this.txtEquantity.Name = "txtEquantity";
            this.txtEquantity.Size = new System.Drawing.Size(240, 27);
            this.txtEquantity.TabIndex = 11;
            this.txtEquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEquantity.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SeaGreen;
            this.animator1.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(19, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(242, 39);
            this.button3.TabIndex = 10;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bunifuCustomLabel12, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(20, 70);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(71, 20);
            this.bunifuCustomLabel12.TabIndex = 9;
            this.bunifuCustomLabel12.Text = "Quantity";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnQuantityclose);
            this.panel2.Controls.Add(this.bunifuSeparator3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.bunifuCustomLabel13);
            this.animator1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 43);
            this.panel2.TabIndex = 2;
            // 
            // btnQuantityclose
            // 
            this.btnQuantityclose.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQuantityclose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuantityclose.BackColor = System.Drawing.Color.Transparent;
            this.btnQuantityclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuantityclose.BorderRadius = 30;
            this.btnQuantityclose.ButtonText = "";
            this.btnQuantityclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.btnQuantityclose, BunifuAnimatorNS.DecorationType.None);
            this.btnQuantityclose.Font = new System.Drawing.Font("Century Gothic", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuantityclose.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQuantityclose.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnQuantityclose.Iconimage")));
            this.btnQuantityclose.Iconimage_right = null;
            this.btnQuantityclose.Iconimage_right_Selected = null;
            this.btnQuantityclose.Iconimage_Selected = null;
            this.btnQuantityclose.IconZoom = 70D;
            this.btnQuantityclose.IsTab = false;
            this.btnQuantityclose.Location = new System.Drawing.Point(248, 5);
            this.btnQuantityclose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnQuantityclose.Name = "btnQuantityclose";
            this.btnQuantityclose.Normalcolor = System.Drawing.Color.Transparent;
            this.btnQuantityclose.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.btnQuantityclose.OnHoverTextColor = System.Drawing.Color.Violet;
            this.btnQuantityclose.selected = false;
            this.btnQuantityclose.Size = new System.Drawing.Size(38, 34);
            this.btnQuantityclose.TabIndex = 5;
            this.btnQuantityclose.Textcolor = System.Drawing.Color.White;
            this.btnQuantityclose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuantityclose.Click += new System.EventHandler(this.btnQuantityclose_Click);
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bunifuSeparator3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 4135;
            this.bunifuSeparator3.Location = new System.Drawing.Point(0, 38);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(290, 10);
            this.bunifuSeparator3.TabIndex = 3;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // pictureBox1
            // 
            this.animator1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.animator1.SetDecoration(this.bunifuCustomLabel13, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(48, 12);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(125, 21);
            this.bunifuCustomLabel13.TabIndex = 0;
            this.bunifuCustomLabel13.Text = "Enter Quantity";
            // 
            // panellogin
            // 
            this.panellogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(43)))), ((int)(((byte)(53)))));
            this.panellogin.Controls.Add(this.button2);
            this.panellogin.Controls.Add(this.bunifuCustomLabel7);
            this.panellogin.Controls.Add(this.txtPass);
            this.panellogin.Controls.Add(this.txtPass1);
            this.panellogin.Controls.Add(this.panel4);
            this.animator1.SetDecoration(this.panellogin, BunifuAnimatorNS.DecorationType.None);
            this.panellogin.Location = new System.Drawing.Point(189, 63);
            this.panellogin.Name = "panellogin";
            this.panellogin.Size = new System.Drawing.Size(291, 202);
            this.panellogin.TabIndex = 17;
            this.panellogin.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.animator1.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(21, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 40);
            this.button2.TabIndex = 37;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bunifuCustomLabel7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(15, 56);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(79, 20);
            this.bunifuCustomLabel7.TabIndex = 9;
            this.bunifuCustomLabel7.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.animator1.SetDecoration(this.txtPass, BunifuAnimatorNS.DecorationType.None);
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtPass.Location = new System.Drawing.Point(64, 91);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(197, 19);
            this.txtPass.TabIndex = 8;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtPass1
            // 
            this.txtPass1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.txtPass1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPass1.BackgroundImage")));
            this.txtPass1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.animator1.SetDecoration(this.txtPass1, BunifuAnimatorNS.DecorationType.None);
            this.txtPass1.Enabled = false;
            this.txtPass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass1.ForeColor = System.Drawing.Color.Snow;
            this.txtPass1.Icon = ((System.Drawing.Image)(resources.GetObject("txtPass1.Icon")));
            this.txtPass1.Location = new System.Drawing.Point(19, 79);
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.Size = new System.Drawing.Size(250, 43);
            this.txtPass1.TabIndex = 7;
            this.txtPass1.text = "";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.btnAuthClose);
            this.panel4.Controls.Add(this.bunifuSeparator2);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.bunifuCustomLabel9);
            this.animator1.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(291, 43);
            this.panel4.TabIndex = 2;
            // 
            // btnAuthClose
            // 
            this.btnAuthClose.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAuthClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAuthClose.BackColor = System.Drawing.Color.Transparent;
            this.btnAuthClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAuthClose.BorderRadius = 30;
            this.btnAuthClose.ButtonText = "";
            this.btnAuthClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.btnAuthClose, BunifuAnimatorNS.DecorationType.None);
            this.btnAuthClose.Font = new System.Drawing.Font("Century Gothic", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthClose.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAuthClose.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAuthClose.Iconimage")));
            this.btnAuthClose.Iconimage_right = null;
            this.btnAuthClose.Iconimage_right_Selected = null;
            this.btnAuthClose.Iconimage_Selected = null;
            this.btnAuthClose.IconZoom = 70D;
            this.btnAuthClose.IsTab = false;
            this.btnAuthClose.Location = new System.Drawing.Point(248, 5);
            this.btnAuthClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAuthClose.Name = "btnAuthClose";
            this.btnAuthClose.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAuthClose.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.btnAuthClose.OnHoverTextColor = System.Drawing.Color.Violet;
            this.btnAuthClose.selected = false;
            this.btnAuthClose.Size = new System.Drawing.Size(38, 34);
            this.btnAuthClose.TabIndex = 5;
            this.btnAuthClose.Textcolor = System.Drawing.Color.White;
            this.btnAuthClose.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthClose.Click += new System.EventHandler(this.btnAuthClose_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.animator1.SetDecoration(this.bunifuSeparator2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 2560;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 38);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(290, 10);
            this.bunifuSeparator2.TabIndex = 3;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // pictureBox2
            // 
            this.animator1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.animator1.SetDecoration(this.bunifuCustomLabel9, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(48, 12);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(131, 21);
            this.bunifuCustomLabel9.TabIndex = 0;
            this.bunifuCustomLabel9.Text = "Authentication";
            // 
            // cbxSearchBy
            // 
            this.cbxSearchBy.BackColor = System.Drawing.Color.SeaGreen;
            this.animator1.SetDecoration(this.cbxSearchBy, BunifuAnimatorNS.DecorationType.None);
            this.cbxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchBy.FormattingEnabled = true;
            this.cbxSearchBy.Items.AddRange(new object[] {
            "Product ID",
            "Product Name"});
            this.cbxSearchBy.Location = new System.Drawing.Point(306, 23);
            this.cbxSearchBy.Name = "cbxSearchBy";
            this.cbxSearchBy.Size = new System.Drawing.Size(176, 29);
            this.cbxSearchBy.TabIndex = 10;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.animator1.SetDecoration(this.bunifuCustomLabel8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(228, 30);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(72, 17);
            this.bunifuCustomLabel8.TabIndex = 15;
            this.bunifuCustomLabel8.Text = "Search By:";
            // 
            // txtSearchBy
            // 
            this.txtSearchBy.BorderColor = System.Drawing.Color.SeaGreen;
            this.animator1.SetDecoration(this.txtSearchBy, BunifuAnimatorNS.DecorationType.None);
            this.txtSearchBy.Location = new System.Drawing.Point(13, 24);
            this.txtSearchBy.Name = "txtSearchBy";
            this.txtSearchBy.Size = new System.Drawing.Size(211, 27);
            this.txtSearchBy.TabIndex = 15;
            this.txtSearchBy.TextChanged += new System.EventHandler(this.txtSearchBy_TextChanged);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProducts.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animator1.SetDecoration(this.dgvProducts, BunifuAnimatorNS.DecorationType.None);
            this.dgvProducts.Location = new System.Drawing.Point(13, 63);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(85)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(467, 413);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // animator1
            // 
            this.animator1.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.animator1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 20;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.animator1.DefaultAnimation = animation2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator1.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Webdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(937, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 23);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "r";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 623);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.header);
            this.animator1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrder";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoadmin)).EndInit();
            this.btnLogin.ResumeLayout(false);
            this.btnLogin.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelQuantity.ResumeLayout(false);
            this.panelQuantity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEquantity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panellogin.ResumeLayout(false);
            this.panellogin.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.PictureBox logoadmin;
        private Bunifu.Framework.UI.BunifuCustomLabel lblStaffs;
        private Bunifu.Framework.UI.BunifuGradientPanel btnLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panellogin;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.TextBox txtPass;
        private Bunifu.Framework.UI.BunifuTextbox txtPass1;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton btnAuthClose;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.ComboBox cbxSearchBy;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtSearchBy;
        public System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.TextBox txtProdDesc;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private SyncListBox listSupplier;
        private SyncListBox listQuantity;
        private SyncListBox listProdName;
        private System.Windows.Forms.Button btnChooseSupplier;
        private System.Windows.Forms.Button btnAddprodtolist;
        private System.Windows.Forms.Panel panelQuantity;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnQuantityclose;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        public System.Windows.Forms.Panel header;
        public System.Windows.Forms.TextBox txtContactNo;
        public System.Windows.Forms.TextBox txtSupplierID;
        public System.Windows.Forms.TextBox txtSupplierName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblOrderID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private System.Windows.Forms.Button btnOrderprod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown txtEquantity;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDate;
        private BunifuAnimatorNS.Animator animator1;
        private System.Windows.Forms.Button btnClose;
    }
}