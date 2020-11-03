using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LIS
{
    public partial class frmAuthorization : Form
    {
        public frmAuthorization()
        {
            InitializeComponent();
        }

        /*
         *-------------------------------Param move form--------------------------
         */
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);
        /*
         * Func. move form
         */
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private void topColorPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        //---------------------------------------------------------------------------------------

        private void bttnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*
         * Change color labelAuthorization
         */
        private void topPanel_MouseEnter(object sender, EventArgs e)
        {
            labelAuthorization.ForeColor = ColorTranslator.FromHtml("#5c192f");
        }

        private void topPanel_MouseLeave(object sender, EventArgs e)
        {
            labelAuthorization.ForeColor = Color.Black;
        }
        //---------------------------------------------------------------------------------------

    }
}
