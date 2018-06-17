namespace Inventory
{
    partial class frmSplashScreen
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.ElipseSplash = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLoading = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.SplashAnimator2 = new BunifuAnimatorNS.Animator(this.components);
            this.Logo2 = new System.Windows.Forms.PictureBox();
            this.SplashAnimator3 = new BunifuAnimatorNS.Animator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo2)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipseSplash
            // 
            this.ElipseSplash.ElipseRadius = 10;
            this.ElipseSplash.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.SplashAnimator2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.SplashAnimator3.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 594);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblLoading
            // 
            this.lblLoading.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SplashAnimator2.SetDecoration(this.lblLoading, BunifuAnimatorNS.DecorationType.None);
            this.SplashAnimator3.SetDecoration(this.lblLoading, BunifuAnimatorNS.DecorationType.None);
            this.lblLoading.ForeColor = System.Drawing.Color.Maroon;
            this.lblLoading.Location = new System.Drawing.Point(374, 331);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(104, 17);
            this.lblLoading.TabIndex = 1;
            this.lblLoading.Text = "Loading...";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashTimer
            // 
            this.SplashTimer.Interval = 200;
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // SplashAnimator2
            // 
            this.SplashAnimator2.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.SplashAnimator2.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0.5F;
            animation3.RotateLimit = 0.2F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.SplashAnimator2.DefaultAnimation = animation3;
            // 
            // Logo2
            // 
            this.Logo2.BackColor = System.Drawing.Color.White;
            this.SplashAnimator2.SetDecoration(this.Logo2, BunifuAnimatorNS.DecorationType.None);
            this.SplashAnimator3.SetDecoration(this.Logo2, BunifuAnimatorNS.DecorationType.None);
            this.Logo2.Image = ((System.Drawing.Image)(resources.GetObject("Logo2.Image")));
            this.Logo2.Location = new System.Drawing.Point(221, 201);
            this.Logo2.Name = "Logo2";
            this.Logo2.Size = new System.Drawing.Size(96, 88);
            this.Logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo2.TabIndex = 2;
            this.Logo2.TabStop = false;
            // 
            // SplashAnimator3
            // 
            this.SplashAnimator3.AnimationType = BunifuAnimatorNS.AnimationType.Rotate;
            this.SplashAnimator3.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(50);
            animation4.RotateCoeff = 1F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 1F;
            this.SplashAnimator3.DefaultAnimation = animation4;
            this.SplashAnimator3.Interval = 15;
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(710, 594);
            this.Controls.Add(this.Logo2);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.pictureBox1);
            this.SplashAnimator2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.SplashAnimator3.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplashScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashTrue";
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipseSplash;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer SplashTimer;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLoading;
        private BunifuAnimatorNS.Animator SplashAnimator2;
        private System.Windows.Forms.PictureBox Logo2;
        private BunifuAnimatorNS.Animator SplashAnimator3;
    }
}