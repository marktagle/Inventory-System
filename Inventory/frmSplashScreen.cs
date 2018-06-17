using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
namespace Inventory
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }
        private void refresh()
        {
            try
            {
                base.Hide();
                Bitmap bitmap = new Bitmap(base.Width, base.Height, PixelFormat.Format32bppArgb);
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.CopyFromScreen(base.Location.X, base.Location.Y, 0, 0, base.Size, CopyPixelOperation.SourceCopy);
                bitmap.Save("spls.bin", ImageFormat.Png);
                this.BackgroundImage = bitmap;
                base.Show();
            }
            catch (Exception)
            {

            }
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            refresh();
            SplashTimer.Start();
        }
        int progress = 0;
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            progress += 10;
            lblLoading.Text = String.Format("Loading {0}%...",progress);
            Logo2.Visible = false;
            SplashAnimator3.Show(Logo2);
            if (progress >= 110)
            {
                
                SplashTimer.Stop();
                frmLogin log = new frmLogin();
                this.Hide();
                SplashAnimator2.Show(log);
            }
        }

    }
}
