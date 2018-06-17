using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BunifuAnimatorNS;
using Bunifu.Framework;
namespace Inventory
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            //panelDashboard1.AutoScroll = false;
           // panelDashboard1.HorizontalScroll.Enabled = false;
            //panelDashboard1.HorizontalScroll.Visible = true;
            //panelDashboard1.HorizontalScroll.Maximum = 0;
            //panelDashboard1.AutoScroll = true;
            panelDashboard.AutoScroll = false;
            panelDashboard.HorizontalScroll.Enabled = false;
            panelDashboard.HorizontalScroll.Visible = false;
            panelDashboard.HorizontalScroll.Maximum = 0;
            panelDashboard.AutoScroll = true;
        }

        private void switchFilemain_OnValueChange_1(object sender, EventArgs e)
        {
            if (filePanel.Height == 5)
            {
                filePanel.Height = 135;
            }
            else
            {
                filePanel.Height = 5;
            }
        }

        private void switchFilemain_OnValueChange(object sender, EventArgs e)
        {
            if(filePanel.Height ==5)
            {
                filePanel.Height = 125;
                logoadmin.Visible = false;
                logoadmin.Hide();
                
                LogoAnimator.Show(logoadmin);
            }
            else
            {
                filePanel.Height = 5;
            }
        }

        private void lbl2nd_Click(object sender, EventArgs e)
        {
            if (switchFilemain.Value == false)
            {
                switchFilemain.Value = true;
            }
            else
            {
                switchFilemain.Value = false;
            }
        }

        private void btnStaffs_Click(object sender, EventArgs e)
        {
            Staffclick();
        }
        public void Staffclick()
        {
            frmSfaffs log = new frmSfaffs();
            if (this.IsMdiContainer == false)
            {
                //og.Text = lblUser.Text;
                this.IsMdiContainer = true;
                log.TopMost = true;
                log.MdiParent = this;
                PanelAnimator.Show(log);
            }
            else
            {
                this.IsMdiContainer = false;
                logoadmin.Visible = false;
                logoadmin.Hide();

                LogoAnimator.Show(logoadmin);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Products log = new Products();
            if (this.IsMdiContainer == false)
            {
                //og.Text = lblUser.Text;
                this.IsMdiContainer = true;
                log.TopMost = true;
                log.MdiParent = this;
                PanelAnimator.Show(log);
            }
            else
            {
                this.IsMdiContainer = false;
                logoadmin.Visible = false;
                logoadmin.Hide();

                LogoAnimator.Show(logoadmin);
            }
        }

        private void switch2nd_OnValueChange(object sender, EventArgs e)
        {
            if (reportsPanel.Height == 5)
            {
                reportsPanel.Height = 260;
                logoadmin.Visible = false;
                logoadmin.Hide();

                LogoAnimator.Show(logoadmin);
            }
            else
            {
                reportsPanel.Height = 5;
            }
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The product you want to add is already in your inventory. \nClick Update Button if you want to edit this product", "O.M.T | Products");
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {
            Staffclick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staffclick();
        }

        private void switchOrderrec_OnValueChange(object sender, EventArgs e)
        {
            if (panelOrderec.Height == 5)
            {
                panelOrderec.Height = 120;
                logoadmin.Visible = false;
                logoadmin.Hide();

                LogoAnimator.Show(logoadmin);
            }
            else
            {
                panelOrderec.Height = 5;
            }
        }

        private void archivesSwitch_OnValueChange(object sender, EventArgs e)
        {
            if (panelArchives.Height == 5)
            {
                panelArchives.Height = 100;
                logoadmin.Visible = false;
                logoadmin.Hide();

                LogoAnimator.Show(logoadmin);
            }
            else
            {
                panelArchives.Height = 5;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmOrder log = new frmOrder();
            if (this.IsMdiContainer == false)
            {
                //og.Text = lblUser.Text;
                this.IsMdiContainer = true;
                log.TopMost = true;
                log.MdiParent = this;
                PanelAnimator.Show(log);
            }
            else
            {
                this.IsMdiContainer = false;
                logoadmin.Visible = false;
                logoadmin.Hide();

                LogoAnimator.Show(logoadmin);
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            frmRecieving log = new frmRecieving();
            if (this.IsMdiContainer == false)
            {
                //og.Text = lblUser.Text;
                this.IsMdiContainer = true;
                log.TopMost = true;
                log.MdiParent = this;
                PanelAnimator.Show(log);
            }
            else
            {
                this.IsMdiContainer = false;
                logoadmin.Visible = false;
                logoadmin.Hide();

                LogoAnimator.Show(logoadmin);
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            frmSales log = new frmSales();
            if (this.IsMdiContainer == false)
            {
                //og.Text = lblUser.Text;
                this.IsMdiContainer = true;
                log.TopMost = true;
                log.MdiParent = this;
                PanelAnimator.Show(log);
            }
            else
            {
                this.IsMdiContainer = false;
                logoadmin.Visible = false;
                logoadmin.Hide();

                LogoAnimator.Show(logoadmin);
            }
        }

        private void btnBackOrder_Click(object sender, EventArgs e)
        {
            frmBackOrder log = new frmBackOrder();
            if (this.IsMdiContainer == false)
            {
                //og.Text = lblUser.Text;
                this.IsMdiContainer = true;
                log.TopMost = true;
                log.MdiParent = this;
                PanelAnimator.Show(log);
            }
            else
            {
                this.IsMdiContainer = false;
                logoadmin.Visible = false;
                logoadmin.Hide();

                LogoAnimator.Show(logoadmin);
            }
        }

        private void btnReorder_Click(object sender, EventArgs e)
        {
            frmReORder log = new frmReORder();
            if (this.IsMdiContainer == false)
            {
                //og.Text = lblUser.Text;
                this.IsMdiContainer = true;
                log.TopMost = true;
                log.MdiParent = this;
                PanelAnimator.Show(log);
            }
            else
            {
                this.IsMdiContainer = false;
                logoadmin.Visible = false;
                logoadmin.Hide();

                LogoAnimator.Show(logoadmin);
            }
        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Show();
            this.Close();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            frmUserArchives log = new frmUserArchives();
            if (this.IsMdiContainer == false)
            {
                //og.Text = lblUser.Text;
                this.IsMdiContainer = true;
                log.TopMost = true;
                log.MdiParent = this;
                PanelAnimator.Show(log);
            }
            else
            {
                this.IsMdiContainer = false;
                logoadmin.Visible = false;
                logoadmin.Hide();

                LogoAnimator.Show(logoadmin);
            }
        }
    }
}
