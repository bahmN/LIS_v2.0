using System;
using System.Drawing;
using System.Windows.Forms;

namespace LIS.Errors
{
    public partial class ErrorClient : Form
    {
        public ErrorClient()
        {
            InitializeComponent();
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

        private void bttnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnOK_MouseEnter(object sender, EventArgs e)
        {
            bttnOK.ForeColor = Color.White;
        }
        private void bttnOK_MouseLeave(object sender, EventArgs e)
        {
            bttnOK.ForeColor = DefaultForeColor;
        }
    }
}
