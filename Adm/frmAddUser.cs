using LIS.Errors;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LIS.Adm
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
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
            if (string.IsNullOrWhiteSpace(tbLogin.Text)) {
                string LoginResult = "1";
                string PasswordResult = null;
                string FNResult = null;
                ErrorRegistration ER = new ErrorRegistration(LoginResult, PasswordResult, FNResult);
                ER.Show();
            }
            else if (string.IsNullOrWhiteSpace(tbPassword.Text)) {
                string LoginResult = null;
                string PasswordResult = "1";
                string FNResult = null;
                ErrorRegistration ER = new ErrorRegistration(LoginResult, PasswordResult, FNResult);
                ER.Show();
            }
            else if (string.IsNullOrWhiteSpace(tbFN.Text)) {
                string LoginResult = null;
                string PasswordResult = null;
                string FNResult = "1";
                ErrorRegistration ER = new ErrorRegistration(LoginResult, PasswordResult, FNResult);
                ER.Show();
            }
            else {
                //TODO: добавить шифрование
                MySqlCommand cAdd = new MySqlCommand("INSERT INTO пользователь(Логин, Пароль, ФИО) VALUES ('" + tbLogin.Text + "', '" + tbPassword.Text + "', '" + tbFN.Text + "')", frmAuthorizaton.connection);
                if (cAdd.ExecuteNonQuery() == 1) {
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void bttnClose_Click(object sender, EventArgs e)
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
