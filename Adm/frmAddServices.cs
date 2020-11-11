using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LIS.Adm
{
    public partial class frmAddServices : Form
    {
        public frmAddServices(string name)
        {
            InitializeComponent();
            bttnOK.Text = "Добавить";
            Name = name;
        }
        static private new string Name;
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
        private void bttnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttnOK_Click(object sender, EventArgs e)
        {
            if (bttnOK.Text == "Добавить") {
                MySqlCommand cAdd = new MySqlCommand("INSERT INTO услуги(`Название анализа`, Цена, `Срок выполнения`, Рекомендации) VALUES " +
                    "('" + tbName.Text + "', '" + tbPrice.Text + " ₽', '" + tbTerm.Text + " дн.', '" + tbRecommendation.Text + "')", frmAuthorization.connection);
                if (cAdd.ExecuteNonQuery() == 1) {
                    DialogResult = DialogResult.OK;
                }
            }
            else if(bttnOK.Text == "Изменить") {
                MySqlCommand cChng = new MySqlCommand("UPDATE услуги SET `Название анализа`= '" + tbName.Text+ "', Цена= '" + tbPrice.Text + "', " +
                    "`Срок выполнения`= '" + tbTerm.Text + "', Рекомендации= '" + tbRecommendation.Text + "' WHERE `Название анализа`= '" + Name + "'", frmAuthorization.connection);
                if (cChng.ExecuteNonQuery() == 1) {
                    DialogResult = DialogResult.OK;
                }
            }
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
