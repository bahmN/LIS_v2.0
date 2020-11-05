using System;
using System.Drawing;
using System.Windows.Forms;

namespace LIS
{
    public partial class frmAddClient : Form
    {
        public frmAddClient()
        {
            InitializeComponent();
        }

        private void bttnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void bttnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        /*
         * ------------------------Design-------------------------
         */
        private void bttnOK_MouseEnter(object sender, EventArgs e)
        {
            bttnOK.ForeColor = Color.White;

        }
        private void bttnOK_MouseLeave(object sender, EventArgs e)
        {
            bttnOK.ForeColor = DefaultForeColor;
        }

        private void bttnCancel_MouseEnter(object sender, EventArgs e)
        {
            bttnOK.ForeColor = Color.White;
        }
        private void bttnCancel_MouseLeave(object sender, EventArgs e)
        {
            bttnOK.ForeColor = DefaultForeColor;
        }
        //--------------------------------------------------------
    }
}
