using System;
using System.Windows.Forms;

namespace LIS.Errors
{
    public partial class ErrorConnection : Form
    {
        public ErrorConnection()
        {
            InitializeComponent();
        }

        private void bttnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
