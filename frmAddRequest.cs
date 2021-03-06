﻿using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LIS
{
    public partial class frmAddRequest : Form
    {
        public frmAddRequest(string passport,string userID)
        {
            InitializeComponent();
            Passport = passport;
            datePickerRequest.MaxDate = DateTime.Now;
            dateTimeResult.MaxDate = DateTime.Now;
            UserID = userID;
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

        private void bttnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void bttnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void bttnOK_Click(object sender, EventArgs e)
        {
            if (bttnOK.Text == "Добавить") {
                MySqlCommand cAdd = new MySqlCommand("INSERT INTO заявка(`Название анализа`, `Номер и серия паспорта`, `Дата создания`, Результат, `Дата выполнения`, `ID пользователя`) VALUES " +
                    "('" + cbNameAnalysis.Text + "', '" + Passport + "', '" + datePickerRequest.Text + "', ' ', ' ', '" + UserID + "')", frmAuthorization.connection);
                if (cAdd.ExecuteNonQuery() == 1) {
                    DialogResult = DialogResult.OK;
                }
            }
            else if (bttnOK.Text == "Подтвердить") {
                MySqlCommand cChng = new MySqlCommand("UPDATE заявка SET `Название анализа`= '" + cbNameAnalysis.Text + "', `Дата создания`= '" + datePickerRequest.Text + "', " +
                    "Результат= '" + tbResult.Text + "', `Дата выполнения`= '" + dateTimeResult.Text + "' WHERE `№ заявки`= '" + Passport + "'", frmAuthorization.connection);
                if (cChng.ExecuteNonQuery() == 1) {
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void frmAddRequest_Load(object sender, EventArgs e)
        {
            if (bttnOK.Text == "Добавить") {
                MySqlDataAdapter daServices = new MySqlDataAdapter("SELECT `Название анализа` FROM услуги", frmAuthorization.connection);
                DataTable dtServices = new DataTable();
                daServices.Fill(dtServices);
                cbNameAnalysis.DataSource = dtServices;
                cbNameAnalysis.ValueMember = "Название анализа";
                cbNameAnalysis.SelectedIndex = -1;

                labelResult.Visible = false;
                labelDateResult.Visible = false;
                tbResult.Visible = false;
                dateTimeResult.Visible = false;
                Height = 159;
            }
            else if (bttnOK.Text == "Подтвердить") {
                MySqlDataAdapter daServices = new MySqlDataAdapter("SELECT `Название анализа` FROM услуги", frmAuthorization.connection);
                DataTable dtServices = new DataTable();
                daServices.Fill(dtServices);
                cbNameAnalysis.DataSource = dtServices;
                cbNameAnalysis.ValueMember = "Название анализа";
            }
        }
    }
}
