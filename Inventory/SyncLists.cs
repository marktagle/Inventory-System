using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Runtime.InteropServices;
namespace Inventory
{
    class SyncListBox : System.Windows.Forms.ListBox
    {
        [Category("Action")]
        private const int WM_HSCROLL = 0x114;
        private const int WM_VSCROLL = 0x115;
        public event ScrollEventHandler OnHorizontalScroll;
        public event ScrollEventHandler OnVerticalScroll;

        private const int SB_LINEUP = 0;
        private const int SB_LINELEFT = 0;
        private const int SB_LINEDOWN = 1;
        private const int SB_LINERIGHT = 1;
        private const int SB_PAGEUP = 2;
        private const int SB_PAGELEFT = 2;
        private const int SB_PAGEDOWN = 3;
        private const int SB_PAGERIGHT = 3;
        private const int SB_THUMBPOSITION = 4;
        private const int SB_THUMBTRACK = 5;
        private const int SB_PAGETOP = 6;
        private const int SB_LEFT = 6;
        private const int SB_PAGEBOTTOM = 7;
        private const int SB_RIGHT = 7;
        private const int SB_ENDSCROLL = 8;
        private const int SIF_TRACKPOS = 0x10;
        private const int SIF_RANGE = 0x1;
        private const int SIF_POS = 0x4;
        private const int SIF_PAGE = 0x2;
        private const int SIF_ALL = SIF_RANGE | SIF_PAGE | SIF_POS | SIF_TRACKPOS;
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetScrollInfo(
        IntPtr hWnd, int n, ref ScrollInfoStruct lpScrollInfo);

        private struct ScrollInfoStruct
        {
            public int cbSize;
            public int fMask;
            public int nMin;
            public int nMax;
            public int nPage;
            public int nPos;
            public int nTrackPos;
        }
        protected override void WndProc(ref System.Windows.Forms.Message msg)
        {
            if (msg.Msg == WM_HSCROLL)
            {
                if (OnHorizontalScroll != null)
                {
                    ScrollInfoStruct si = new ScrollInfoStruct();
                    si.fMask = SIF_ALL;
                    si.cbSize = Marshal.SizeOf(si);
                    GetScrollInfo(msg.HWnd, 0, ref si);
                    if (msg.WParam.ToInt32() == SB_ENDSCROLL)
                    {
                        ScrollEventArgs sargs = new ScrollEventArgs(
                        ScrollEventType.EndScroll,
                        si.nPos);
                        OnHorizontalScroll(this, sargs);
                    }
                }
            }
            if (msg.Msg == WM_VSCROLL)
            {
                if (OnVerticalScroll != null)
                {
                    ScrollInfoStruct si = new ScrollInfoStruct();
                    si.fMask = SIF_ALL;
                    si.cbSize = Marshal.SizeOf(si);
                    GetScrollInfo(msg.HWnd, 0, ref si);
                    if (msg.WParam.ToInt32() == SB_ENDSCROLL)
                    {
                        ScrollEventArgs sargs = new ScrollEventArgs(
                        ScrollEventType.EndScroll,
                        si.nPos);
                        OnVerticalScroll(this, sargs);
                    }
                }
            }
            base.WndProc(ref msg);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // scrolled
            // 
            this.Size = new System.Drawing.Size(120, 95);
            this.ResumeLayout(false);
        }
    }
}
