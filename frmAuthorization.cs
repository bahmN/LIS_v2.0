using LIS.Adm;
using LIS.Errors;
using MySql.Data.MySqlClient;
using System;
using System.Data;
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
        static public MySqlConnection connection;

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

        private void bttnEnter_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection("server = 127.0.0.1; port = 3306; user = root; password = Vfhnvfhn23@; database = lis; sslmode = none;");
            connection.Open();

            string Password = Hashing.HashPassword(tbPassword.Text);

            if (chckBoxAdm.Checked == true) {
                MySqlCommand cSelect = new MySqlCommand("SELECT Логин, Пароль FROM администратор WHERE Логин= '" + tbLogin.Text + "' AND Пароль= '" + Password + "'", connection);
                MySqlDataAdapter daSelect = new MySqlDataAdapter(cSelect);
                DataTable dtSelect = new DataTable();
                daSelect.Fill(dtSelect);
                if (dtSelect.Rows.Count > 0) {
                    frmMenuAdm FMA = new frmMenuAdm();
                    FMA.ShowDialog();
                }
                else {
                    ErrorAuthorization EA = new ErrorAuthorization();
                    EA.Show();
                }
            }
            else {
                MySqlCommand cSelect = new MySqlCommand("SELECT Логин, Пароль FROM пользователь WHERE Логин= '" + tbLogin.Text + "' AND Пароль= '" + Password + "'", connection);
                MySqlDataAdapter daSelect = new MySqlDataAdapter(cSelect);
                DataTable dtSelect = new DataTable();
                daSelect.Fill(dtSelect);
                if (dtSelect.Rows.Count > 0) {
                    //Active user
                    MySqlCommand cUserName = new MySqlCommand("SELECT ФИО FROM пользователь WHERE Логин = '" + tbLogin.Text + "'", connection);
                    object userNameObj = cUserName.ExecuteScalar();
                    string userName = userNameObj.ToString();

                    frmMenuUser FMU = new frmMenuUser(userName);
                    FMU.ShowDialog();
                }
                else {
                    ErrorAuthorization EA = new ErrorAuthorization();
                    EA.Show();
                }
            }
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
        private void bttnEnter_MouseMove(object sender, MouseEventArgs e)
        {
            bttnEnter.ForeColor = Color.White;
        }
        private void bttnEnter_MouseLeave(object sender, EventArgs e)
        {
            bttnEnter.ForeColor = DefaultForeColor;
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
