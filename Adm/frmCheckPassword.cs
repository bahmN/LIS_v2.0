using LIS.Errors;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LIS.Adm
{
    public partial class frmCheckPassword : Form
    {
        public frmCheckPassword()
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
        private void bttnEnter_Click(object sender, EventArgs e)
        {
            string Password = Hashing.HashPassword(tbPassword.Text);

            MySqlCommand cSelect = new MySqlCommand("SELECT * FROM администратор WHERE Пароль= '" + Password + "'", frmAuthorization.connection);
            MySqlDataAdapter daSelect = new MySqlDataAdapter(cSelect);
            DataTable dtSelect = new DataTable();
            daSelect.Fill(dtSelect);
            if (dtSelect.Rows.Count > 0) {
                DialogResult = DialogResult.OK;
            }
            else {
                this.Close();
            }
        }

        private void bttnEnter_MouseEnter(object sender, EventArgs e)
        {
            bttnEnter.ForeColor = Color.White;
        }
        private void bttnEnter_MouseLeave(object sender, EventArgs e)
        {
            bttnEnter.ForeColor = DefaultForeColor;
        }

        private void bttnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnLookPassword_MouseDown(object sender, MouseEventArgs e)
        {
            tbPassword.PasswordChar = (char)0;
        }
        private void bttnLookPassword_MouseUp(object sender, MouseEventArgs e)
        {
            tbPassword.PasswordChar = '•';
        }
    }
}
