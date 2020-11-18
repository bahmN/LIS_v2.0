using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LIS
{
    public partial class frmMenuUser : Form
    {
        public frmMenuUser()
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
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private void panelTopColor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        //---------------------------------------------------------------------------------------

        /*
         * -------------------------------Design------------------------------
         */

        // Color when mouse Enter on the button   
        private void bttnAdd_MouseEnter(object sender, EventArgs e)
        {
            bttnAdd.ForeColor = Color.White;
        }
        private void bttnAdd_MouseLeave(object sender, EventArgs e)
        {
            bttnAdd.ForeColor = DefaultForeColor;
        }

        private void bttnChange_MouseEnter(object sender, EventArgs e)
        {
            bttnChange.ForeColor = Color.White;
        }
        private void bttnChange_MouseLeave(object sender, EventArgs e)
        {
            bttnChange.ForeColor = DefaultForeColor;
        }

        private void bttnDelete_MouseEnter(object sender, EventArgs e)
        {
            bttnDelete.ForeColor = Color.White;
        }
        private void bttnDelete_MouseLeave(object sender, EventArgs e)
        {
            bttnDelete.ForeColor = DefaultForeColor;
        }

        private void bttnRefresh_MouseEnter(object sender, EventArgs e)
        {
            bttnRefresh.ForeColor = Color.White;
        }
        private void bttnRefresh_MouseLeave(object sender, EventArgs e)
        {
            bttnRefresh.ForeColor = DefaultForeColor;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x00020000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        //----------------------------------------------------------------------
        private void bttnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        /*
         * Size form
         */
        private void bttnFullS_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            labelPanelUser.Left = ( ClientSize.Width - labelPanelUser.Width ) / 2;
            bttnFullS.Visible = false;
            bttnNormalS.Visible = true;
        }
        private void bttnNormalS_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            labelPanelUser.Left = ( ClientSize.Width - labelPanelUser.Width ) / 2;
            bttnNormalS.Visible = false;
            bttnFullS.Visible = true;
        }
        private void bttnRollUp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
