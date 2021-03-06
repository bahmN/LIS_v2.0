﻿using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LIS
{
    public partial class frmAddClient : Form
    {
        public frmAddClient(string userID, string a)
        {
            InitializeComponent();
            bttnOK.Text = "Далее";
            labelPanelAdm.Text = "Добавить клиента";
            labelPanelAdm.Left = ( ClientSize.Width - labelPanelAdm.Width ) / 2;
            datePickerBirthday.MaxDate = DateTime.Now;
            UserID = userID;
        }

        public frmAddClient(string passport)
        {
            InitializeComponent();
            Passport = passport;
            bttnOK.Text = "Изменить";
            labelPanelAdm.Text = "Изменить данные";
            labelPanelAdm.Left = ( ClientSize.Width - labelPanelAdm.Width ) / 2;
            datePickerBirthday.MaxDate = DateTime.Now;
        }
        static private string Passport;
        static private string UserID;
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
            bttnCancel.ForeColor = Color.White;
        }
        private void bttnCancel_MouseLeave(object sender, EventArgs e)
        {
            bttnCancel.ForeColor = DefaultForeColor;
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
        //--------------------------------------------------------
        private void bttnOK_Click(object sender, EventArgs e)
        {
            if (bttnOK.Text == "Далее") {
                MySqlCommand cAdd = new MySqlCommand("INSERT INTO клиент(`Номер и серия паспорта`, ФИО, `Дата рождения`, СНИЛС, `Номер телефона`, `Адрес проживания`, `e-mail`) VALUES " +
                    "('" + tbPassport.Text + "', '" + tbFN.Text + "', '" + datePickerBirthday.Text + "', '" + tbSNILS.Text + "', '" + tbNumbPhone.Text + "', '" + tbAdress.Text + "', '" + tbEMail.Text + "')", frmAuthorization.connection);
                if (cAdd.ExecuteNonQuery() == 1) {
                    DialogResult = DialogResult.OK;
                    string passport = tbPassport.Text;
                    frmAddRequest FAR = new frmAddRequest(passport, UserID);
                    FAR.bttnOK.Text = "Добавить";
                    FAR.labelPanelReq.Text = "Добавить заявку";
                    FAR.labelPanelReq.Left = ( ClientSize.Width - FAR.labelPanelReq.Width ) / 2;
                    FAR.ShowDialog();
                }
            }
            else if (bttnOK.Text == "Изменить") {
                MySqlCommand cChng = new MySqlCommand("UPDATE клиент SET `Номер и серия паспорта`= '" + tbPassport.Text + "', ФИО= '" + tbFN.Text + "', `Дата рождения`= '" + datePickerBirthday.Text + "', " +
                    "СНИЛС= '" + tbSNILS.Text + "', `Номер телефона`= '" + tbNumbPhone.Text + "', `Адрес проживания`= '" + tbAdress.Text + "', `e-mail`= '" + tbEMail.Text + "' WHERE `Номер и серия паспорта`= '" + Passport + "'", frmAuthorization.connection);
                MySqlCommand cChng2 = new MySqlCommand("UPDATE заявка SET `Номер и серия паспорта`= '" + tbPassport.Text + "' WHERE `Номер и серия паспорта`= '" + Passport + "'", frmAuthorization.connection);
                if (cChng.ExecuteNonQuery() == 1) {
                    cChng2.ExecuteNonQuery();
                    DialogResult = DialogResult.OK;
                }
            }
        }
        static public string idUser { get; set; } //Variable for id user
        private void bttnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void bttnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
