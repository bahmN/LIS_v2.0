using LIS.Errors;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LIS
{
    public partial class frmMenuUser : Form
    {
        public frmMenuUser()
        {
            InitializeComponent();
        }
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
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private void panelTopColor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        //---------------------------------------------------------------------------------------
        private void bttnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*
         * Size form
         */
        private void bttnFullS_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            labelPanelUser.Left = ( ClientSize.Width - labelPanelUser.Width ) / 2;
            bttnFullS.Visible = false;
            bttnNormalS.Visible = true;
        }
        private void bttnNormalS_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            labelPanelUser.Left = ( ClientSize.Width - labelPanelUser.Width ) / 2;
            bttnNormalS.Visible = false;
            bttnFullS.Visible = true;
        }
        private void bttnRollUp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        /*
         * -------------------------------Design------------------------------
         */
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSearch.Text)) {
                labelSearch.ForeColor = DefaultForeColor;
            }
            else {
                labelSearch.ForeColor = ColorTranslator.FromHtml("#5c192f");
            }
            /*
             * Searching
             */
            if (tabMenu.SelectedTab == pageRequests) {
                MySqlDataAdapter daSearch = new MySqlDataAdapter("SELECT `№ заявки`,`Название анализа`, ФИО, заявка.`Номер и серия паспорта`, `Дата создания`, Результат, `Дата выполнения` FROM заявка, клиент " +
                    "WHERE (заявка.`Номер и серия паспорта` = клиент.`Номер и серия паспорта`)" +
                      "AND (`Название анализа` LIKE '%" + tbSearch.Text + "%' " +
                      "OR ФИО LIKE '%" + tbSearch.Text + "%' " +
                      "OR `Дата создания` LIKE '%" + tbSearch.Text + "%' " +
                      "OR Результат like '%" + tbSearch.Text + "%' " +
                      "OR `Дата выполнения` LIKE '%" + tbSearch.Text + "%')", frmAuthorization.connection);
                DataTable dtSearch = new DataTable();
                daSearch.Fill(dtSearch);
                dataTableRequests.DataSource = dtSearch;
            }
            else if (tabMenu.SelectedTab == pageClients) {
                MySqlDataAdapter daSearch = new MySqlDataAdapter("SELECT `Номер и серия паспорта`, ФИО, `Дата рождения`, СНИЛС, `Номер телефона`, `Адрес проживания`, `e-mail` FROM клиент " +
                    "WHERE `Номер и серия паспорта` LIKE '%" + tbSearch.Text + "%' " +
                      "OR ФИО LIKE '%" + tbSearch.Text + "%' " +
                      "OR `Дата рождения` LIKE '%" + tbSearch.Text + "%' " +
                      "OR СНИЛС LIKE '%" + tbSearch.Text + "%' " +
                      "OR `Номер телефона` LIKE '%" + tbSearch.Text + "%' " +
                      "OR `Адрес проживания` LIKE '%" + tbSearch.Text + "%' " +
                      "OR `e-mail` LIKE '%" + tbSearch.Text + "%'", frmAuthorization.connection);
                DataTable dtSearch = new DataTable();
                daSearch.Fill(dtSearch);
                dataTableClients.DataSource = dtSearch;
            }
            else if (tabMenu.SelectedTab == pageServices) {
                MySqlDataAdapter daSearch = new MySqlDataAdapter("SELECT `Название анализа`, Цена, `Срок выполнения`, Рекомендации FROM услуги " +
                    "WHERE `Название анализа` LIKE '%" + tbSearch.Text + "%' " +
                      "OR Цена LIKE '%" + tbSearch.Text + "%' " +
                      "OR `Срок выполнения` LIKE '%" + tbSearch.Text + "%' " +
                      "OR Рекомендации LIKE '%" + tbSearch.Text + "%'", frmAuthorization.connection);
                DataTable dtSearch = new DataTable();
                daSearch.Fill(dtSearch);
                dataTableServices.DataSource = dtSearch;
            }
        }
        // Color when mouse Enter on the button   
        private void bttnAdd_MouseEnter(object sender, EventArgs e)
        {
            bttnAdd.ForeColor = Color.White;
        }
        private void bttnAdd_MouseLeave(object sender, EventArgs e)
        {
            bttnAdd.ForeColor = DefaultForeColor;
        }

        private void bttnChange_MouseEnter(object sender, EventArgs e)
        {
            bttnChange.ForeColor = Color.White;
        }
        private void bttnChange_MouseLeave(object sender, EventArgs e)
        {
            bttnChange.ForeColor = DefaultForeColor;
        }
        private void bttnRefresh_MouseEnter(object sender, EventArgs e)
        {
            bttnRefresh.ForeColor = Color.White;
        }
        private void bttnRefresh_MouseLeave(object sender, EventArgs e)
        {
            bttnRefresh.ForeColor = DefaultForeColor;
        }
        //Shadows
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
        //----------------------------------------------------------------------

        private void frmMenuUser_Load(object sender, EventArgs e)
        {
            bttnRefresh_Click(sender, e);
        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            if (tabMenu.SelectedTab == pageRequests) {
                MySqlDataAdapter daRequests = new MySqlDataAdapter("SELECT `№ заявки`, `Название анализа`, ФИО, клиент.`Номер и серия паспорта`, `Дата создания`,Результат,`Дата выполнения` FROM заявка, клиент " +
                    "WHERE заявка.`Номер и серия паспорта` = клиент.`Номер и серия паспорта`", frmAuthorization.connection);
                DataTable dtRequests = new DataTable();
                daRequests.Fill(dtRequests);
                dataTableRequests.DataSource = dtRequests;
                dataTableRequests.RowHeadersVisible = false; // Hide the display of the left column
                dataTableRequests.AllowUserToAddRows = false;// Hide the display of the bottom column
                dataTableRequests.Columns[0].Visible = false;
                //Unlock buttons
                bttnAdd.Enabled = true;
                bttnChange.Enabled = true;

                bttnChange.Text = "Результат анализа готов";
            }
            else if (tabMenu.SelectedTab == pageClients) {
                MySqlDataAdapter daClients = new MySqlDataAdapter("SELECT * FROM клиент", frmAuthorization.connection);
                DataTable dtClients = new DataTable();
                daClients.Fill(dtClients);
                dataTableClients.DataSource = dtClients;
                dataTableClients.RowHeadersVisible = false; // Hide the display of the left column
                dataTableClients.AllowUserToAddRows = false; // Hide the display of the bottom column
                //Unlock buttons
                bttnAdd.Enabled = true;
                bttnChange.Enabled = true;

                bttnChange.Text = "Изменить";
            }
            else if (tabMenu.SelectedTab == pageServices) {
                MySqlDataAdapter daServices = new MySqlDataAdapter("SELECT * FROM услуги", frmAuthorization.connection);
                DataTable dtServices = new DataTable();
                daServices.Fill(dtServices);
                dataTableServices.DataSource = dtServices;
                dataTableServices.RowHeadersVisible = false; // Hide the display of the left column
                dataTableServices.AllowUserToAddRows = false; // Hide the display of the bottom column
                dataTableServices.Columns[0].Width = 300;
                dataTableServices.Columns[1].Width = 75;
                dataTableServices.Columns[2].Width = 170;
                //Block buttons
                bttnAdd.Enabled = false;
                bttnChange.Enabled = false;

                bttnChange.Text = "Изменить";
            }
            else {
                ErrorAuthorization EA = new ErrorAuthorization();
                EA.Show();
            }
        }
        private void tabMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            bttnRefresh_Click(sender, e);
        }

        /*
         * Add data
         */
        private void bttnAdd_Click(object sender, EventArgs e)
        {
            if (tabMenu.SelectedTab == pageClients) {
                try {
                    frmAddRequest FAR = new frmAddRequest(dataTableClients.SelectedRows[0].Cells[0].Value.ToString());
                    FAR.bttnOK.Text = "Добавить";
                    FAR.labelPanelReq.Text = "Добавить заявку";
                    FAR.labelPanelReq.Left = ( ClientSize.Width - FAR.labelPanelReq.Width ) / 2;
                    FAR.ShowDialog();
                    if (FAR.DialogResult == DialogResult.OK) {
                        bttnRefresh_Click(sender, e);
                    }
                }
                catch {
                    ErrorClient EC = new ErrorClient();
                    EC.Show();
                }
            }
            else if (tabMenu.SelectedTab == pageRequests) {
                frmAddClient FAC = new frmAddClient();
                FAC.ShowDialog();
                if (FAC.DialogResult == DialogResult.OK) {
                    bttnRefresh_Click(sender, e);
                }
            }
        }

        /*
         * Change data
         */
        private void bttnChange_Click(object sender, EventArgs e)
        {
            try {
                if (tabMenu.SelectedTab == pageRequests) {
                    frmAddRequest FAR = new frmAddRequest(dataTableRequests.SelectedRows[0].Cells[0].Value.ToString());
                    FAR.datePickerRequest.Text = dataTableRequests.SelectedRows[0].Cells[4].Value.ToString();
                    FAR.tbResult.Text = dataTableRequests.SelectedRows[0].Cells[5].Value.ToString();
                    FAR.bttnOK.Text = "Подтвердить";
                    FAR.labelPanelReq.Text = "Подтвердить результат анализа";
                    FAR.labelPanelReq.Left = ( ClientSize.Width - FAR.labelPanelReq.Width ) / 2;
                    FAR.ShowDialog();
                    if (FAR.DialogResult == DialogResult.OK) {
                        bttnRefresh_Click(sender, e);
                    }
                }
                else if (tabMenu.SelectedTab == pageClients) {
                    frmAddClient FAC = new frmAddClient(dataTableClients.SelectedRows[0].Cells[0].Value.ToString());
                    FAC.tbPassport.Text = dataTableClients.SelectedRows[0].Cells[0].Value.ToString();
                    FAC.tbFN.Text = dataTableClients.SelectedRows[0].Cells[1].Value.ToString();
                    FAC.datePickerBirthday.Text = dataTableClients.SelectedRows[0].Cells[2].Value.ToString();
                    FAC.tbSNILS.Text = dataTableClients.SelectedRows[0].Cells[3].Value.ToString();
                    FAC.tbNumbPhone.Text = dataTableClients.SelectedRows[0].Cells[4].Value.ToString();
                    FAC.tbAdress.Text = dataTableClients.SelectedRows[0].Cells[5].Value.ToString();
                    FAC.tbEMail.Text = dataTableClients.SelectedRows[0].Cells[6].Value.ToString();
                    FAC.ShowDialog();
                    if (FAC.DialogResult == DialogResult.OK) {
                        bttnRefresh_Click(sender, e);
                    }
                }
            }
            catch {
                ErrorChangeData errorCD = new ErrorChangeData();
                errorCD.Show();
            }
        }

        private void dataTableRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                dataTableRequests.Rows[e.RowIndex].Selected = true;
            }
            catch { }
        }

        private void dataTableClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                dataTableClients.Rows[e.RowIndex].Selected = true;
            }
            catch { }
        }

        private void dataTableServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                dataTableServices.Rows[e.RowIndex].Selected = true;
            }
            catch { }
        }
    }
}
