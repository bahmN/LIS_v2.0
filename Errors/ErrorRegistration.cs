using System.Drawing;
using System.Windows.Forms;

namespace LIS.Errors
{
    public partial class ErrorRegistration : Form
    {
        public ErrorRegistration(string login, string password, string password2, string fn)
        {
            InitializeComponent();
            Login = login;
            Password = password;
            Password2 = password2;
            FullName = fn;
        }
        static private string Login;
        static private string Password;
        static private string Password2;
        static private string FullName;
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


        private void bttnOK_MouseEnter(object sender, System.EventArgs e)
        {
            bttnOK.ForeColor = Color.White;
        }
        private void bttnOK_MouseLeave(object sender, System.EventArgs e)
        {
            bttnOK.ForeColor = DefaultForeColor;
        }
        private void bttnOK_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void ErrorRegistration_Load(object sender, System.EventArgs e)
        {
            if(Login == "1") {
                labelTxt.Text = "Строка \"Логин\" не может\n быть пустой";
            }
            else if (Password == "1") {
                labelTxt.Text = "Строка \"Пароль\" не может\n быть пустой";
            }
            else if (Password2 == "1") {
                labelTxt.Text = "Пароли не совпадают!";
                labelTxt.ForeColor = Color.Red;
            }
            else if (FullName == "1") {
                labelTxt.Text = "Строка \"ФИО\" не может\n быть пустой";
            }            
        }
    }
}
