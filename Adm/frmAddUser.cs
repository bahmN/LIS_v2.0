using LIS.Errors;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LIS.Adm
{
    public partial class frmAddUser : Form
    {
        public frmAddUser(string id)
        {
            InitializeComponent();
            ID = id;
        }
        static private string ID;
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
                ErrorRegistration ER = new ErrorRegistration(LoginResult, null, null, null);
                ER.Show();
            }
            else if (string.IsNullOrWhiteSpace(tbPassword.Text)) {
                string PasswordResult = "1";
                ErrorRegistration ER = new ErrorRegistration(null, PasswordResult, null, null);
                ER.Show();
            }
            else if (string.IsNullOrWhiteSpace(tbFN.Text)) {
                string FNResult = "1";
                ErrorRegistration ER = new ErrorRegistration(null, null, null, FNResult);
                ER.Show();
            }
            else if (tbPassword.Text != tbPassword2.Text) {
                string Password2Result = "1";
                ErrorRegistration ER = new ErrorRegistration(null, null, Password2Result, null);
                ER.Show();
            }
            else {
                if (bttnOK.Text == "Зарегистрировать") {
                    string Password = Hashing.HashPassword(tbPassword.Text);
                    MySqlCommand cAdd = new MySqlCommand("INSERT INTO пользователь(Логин, Пароль, ФИО) VALUES ('" + tbLogin.Text + "', '" + Password + "', '" + tbFN.Text + "')", frmAuthorization.connection);
                    if (cAdd.ExecuteNonQuery() == 1) {
                        DialogResult = DialogResult.OK;
                    }
                }
                else if (bttnOK.Text == "Изменить") {
                    string Password = Hashing.HashPassword(tbPassword.Text);
                    MySqlCommand cAdd = new MySqlCommand("UPDATE пользователь SET Логин= '" + tbLogin.Text + "', Пароль='" + Password + "', ФИО= '" + tbFN.Text + "' WHERE ID= '" + ID + "'", frmAuthorization.connection);
                    if (cAdd.ExecuteNonQuery() == 1) {
                        DialogResult = DialogResult.OK;
                    }
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

        private void bttnLookPassword_MouseDown(object sender, MouseEventArgs e)
        {
            tbPassword.PasswordChar = (char)0;
            tbPassword2.PasswordChar = (char)0;
        }
        private void bttnLookPassword_MouseUp(object sender, MouseEventArgs e)
        {
            tbPassword.PasswordChar = '•';
            tbPassword2.PasswordChar = '•';
        }
    }
}
