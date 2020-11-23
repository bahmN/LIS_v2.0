using LIS.Adm;
using LIS.Errors;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LIS
{
    public partial class frmMenuAdm : Form
    {
        public frmMenuAdm()
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
            frmAuthorization.connection.Close();
            Close();
        }

        /*
         * Size form
         */
        private void bttnFullS_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            labelPanelAdm.Left = ( ClientSize.Width - labelPanelAdm.Width ) / 2;
            labelAdm.Left = ( ClientSize.Width - labelPanelAdm.Width ) / 2;
            labelUsers.Left = ( ClientSize.Width - labelPanelAdm.Width ) / 2;
            bttnFullS.Visible = false;
            bttnNormalS.Visible = true;
        }

        private void bttnNormalS_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            labelPanelAdm.Left = ( ClientSize.Width - labelPanelAdm.Width ) / 2;
            labelAdm.Left = ( ClientSize.Width - labelPanelAdm.Width ) / 2;
            labelUsers.Left = ( ClientSize.Width - labelPanelAdm.Width ) / 2;
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
            if (tabMenu.SelectedTab == pageClients) {
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
            else if (tabMenu.SelectedTab == pageRequests) {
                MySqlDataAdapter daSearch = new MySqlDataAdapter("SELECT `№ заявки`, `Название анализа`, ФИО, заявка.`Номер и серия паспорта`, `Дата создания`, Результат, `Дата выполнения` FROM заявка, клиент " +
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
            else if (tabMenu.SelectedTab == pageUsers) {
                MySqlDataAdapter daSearch = new MySqlDataAdapter("SELECT ID, Логин, ФИО FROM пользователь " +
                    "WHERE Логин LIKE '%" + tbSearch.Text + "%' " +
                      "OR ФИО LIKE '%" + tbSearch.Text + "%'", frmAuthorization.connection);
                DataTable dtSearch = new DataTable();
                daSearch.Fill(dtSearch);
                dataTableUsers.DataSource = dtSearch;

                MySqlDataAdapter daSearch2 = new MySqlDataAdapter("SELECT `ID администратора`, Логин, ФИО FROM администратор " +
                    "WHERE Логин LIKE '%" + tbSearch.Text + "%' " +
                      "OR ФИО LIKE '%" + tbSearch.Text + "%'", frmAuthorization.connection);
                DataTable dtSearch2 = new DataTable();
                daSearch2.Fill(dtSearch2);
                dataTableAdm.DataSource = dtSearch2;
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
        private void bttnDelete_MouseEnter(object sender, EventArgs e)
        {
            bttnDelete.ForeColor = Color.White;
        }
        private void bttnDelete_MouseLeave(object sender, EventArgs e)
        {
            bttnDelete.ForeColor = DefaultForeColor;
        }
        private void bttnRefresh_MouseEnter(object sender, EventArgs e)
        {
            bttnRefresh.ForeColor = Color.White;
        }
        private void bttnRefresh_MouseLeave(object sender, EventArgs e)
        {
            bttnRefresh.ForeColor = DefaultForeColor;
        }
        private void bttnAddUser_MouseEnter(object sender, EventArgs e)
        {
            bttnAddUser.ForeColor = Color.White;
        }
        private void bttnAddUser_MouseLeave(object sender, EventArgs e)
        {
            bttnAddUser.ForeColor = DefaultForeColor;
        }
        private void bttnExportDB_MouseEnter(object sender, EventArgs e)
        {
            bttnExportDB.ForeColor = Color.White;
        }
        private void bttnExportDB_MouseLeave(object sender, EventArgs e)
        {
            bttnExportDB.ForeColor = DefaultForeColor;
        }
        private void bttnImportDB_MouseEnter(object sender, EventArgs e)
        {
            bttnImportDB.ForeColor = Color.White;
        }
        private void bttnImportDB_MouseLeave(object sender, EventArgs e)
        {
            bttnImportDB.ForeColor = DefaultForeColor;
        }
        private void bttnChngUser_MouseEnter(object sender, EventArgs e)
        {
            bttnChngUser.ForeColor = Color.White;
        }
        private void bttnChngUser_MouseLeave(object sender, EventArgs e)
        {
            bttnChngUser.ForeColor = DefaultForeColor;
        }
        private void bttnDeleteUser_MouseEnter(object sender, EventArgs e)
        {
            bttnDeleteUser.ForeColor = Color.White;
        }
        private void bttnDeleteUser_MouseLeave(object sender, EventArgs e)
        {
            bttnDeleteUser.ForeColor = DefaultForeColor;
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
        private void frmMenuAdm_Load(object sender, EventArgs e)
        {

            bttnRefresh_Click(sender, e);
        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            if (tabMenu.SelectedTab == pageClients) {
                MySqlDataAdapter daClients = new MySqlDataAdapter("SELECT * FROM клиент", frmAuthorization.connection);
                DataTable dtClients = new DataTable();
                daClients.Fill(dtClients);
                dataTableClients.DataSource = dtClients;
                dataTableClients.RowHeadersVisible = false; // Hide the display of the left column
                dataTableClients.AllowUserToAddRows = false; // Hide the display of the bottom column
                bttnAdd.Enabled = true;
                bttnChange.Enabled = true;
                bttnDelete.Enabled = true;
                bttnAddUser.Enabled = false;
                bttnChngUser.Enabled = false;
                bttnDeleteUser.Enabled = false;
                //Clear dataTableUsers&Adm
                DataTable dt = (DataTable)dataTableUsers.DataSource;
                DataTable dt2 = (DataTable)dataTableAdm.DataSource;
                if (dt != null && dt2 != null) {
                    dt.Clear();
                    dt2.Clear();
                }
            }
            else if (tabMenu.SelectedTab == pageRequests) {
                MySqlDataAdapter daRequests = new MySqlDataAdapter("SELECT `№ заявки`, `Название анализа`, ФИО, клиент.`Номер и серия паспорта`, `Дата создания`,Результат,`Дата выполнения` FROM заявка, клиент " +
                    "WHERE заявка.`Номер и серия паспорта` = клиент.`Номер и серия паспорта`", frmAuthorization.connection);
                DataTable dtRequests = new DataTable();
                daRequests.Fill(dtRequests);
                dataTableRequests.DataSource = dtRequests;
                dataTableRequests.RowHeadersVisible = false; // Hide the display of the left column
                dataTableRequests.AllowUserToAddRows = false;// Hide the display of the bottom column
                dataTableRequests.Columns[0].Width = 60;
                bttnAdd.Enabled = true;
                bttnChange.Enabled = true;
                bttnDelete.Enabled = true;
                bttnAddUser.Enabled = false;
                bttnChngUser.Enabled = false;
                bttnDeleteUser.Enabled = false;
                //Clear dataTableUsers&Adm
                DataTable dt = (DataTable)dataTableUsers.DataSource;
                DataTable dt2 = (DataTable)dataTableAdm.DataSource;
                if (dt != null && dt2 != null) {
                    dt.Clear();
                    dt2.Clear();
                }
            }
            else if (tabMenu.SelectedTab == pageServices) {
                MySqlDataAdapter daServices = new MySqlDataAdapter("SELECT * FROM услуги", frmAuthorization.connection);
                DataTable dtServices = new DataTable();
                daServices.Fill(dtServices);
                dataTableServices.DataSource = dtServices;
                dataTableServices.RowHeadersVisible = false; // Hide the display of the left column
                dataTableServices.AllowUserToAddRows = false; // Hide the display of the bottom column
                dataTableServices.Columns[0].Width = 300;
                dataTableServices.Columns[1].Width = 90;
                dataTableServices.Columns[2].Width = 170;
                bttnAdd.Enabled = true;
                bttnChange.Enabled = true;
                bttnDelete.Enabled = true;
                bttnAddUser.Enabled = false;
                bttnChngUser.Enabled = false;
                bttnDeleteUser.Enabled = false;
                //Clear dataTableUsers&Adm
                DataTable dt = (DataTable)dataTableUsers.DataSource;
                DataTable dt2 = (DataTable)dataTableAdm.DataSource;
                if (dt != null && dt2 != null) {
                    dt.Clear();
                    dt2.Clear();
                }
            }
            else if (tabMenu.SelectedTab == pageUsers) {
                frmCheckPassword FCP = new frmCheckPassword();
                FCP.ShowDialog();
                if (FCP.DialogResult == DialogResult.OK) {
                    //Users
                    MySqlDataAdapter daUsers = new MySqlDataAdapter("SELECT `ID пользователя`, Логин, ФИО FROM пользователь WHERE Роль= 'Пользователь'", frmAuthorization.connection);
                    DataTable dtUsers = new DataTable();
                    daUsers.Fill(dtUsers);
                    dataTableUsers.DataSource = dtUsers;
                    dataTableUsers.RowHeadersVisible = false; // Hide the display of the left column
                    dataTableUsers.AllowUserToAddRows = false; // Hide the display of the bottom column
                    dataTableUsers.Columns[0].Width = 35;

                    //Administrations
                    MySqlDataAdapter daAdm = new MySqlDataAdapter("SELECT `ID пользователя`, Логин, ФИО FROM пользователь WHERE Роль= 'Администратор'", frmAuthorization.connection);
                    DataTable dtAdm = new DataTable();
                    daAdm.Fill(dtAdm);
                    dataTableAdm.DataSource = dtAdm;
                    dataTableAdm.RowHeadersVisible = false; // Hide the display of the left column
                    dataTableAdm.AllowUserToAddRows = false; // Hide the display of the bottom column
                    dataTableAdm.Columns[0].Width = 185;
                    dataTableAdm.Columns[2].Width = 480;

                    bttnAdd.Enabled = false;
                    bttnChange.Enabled = false;
                    bttnDelete.Enabled = false;
                    bttnAddUser.Enabled = true;
                    bttnChngUser.Enabled = true;
                    bttnDeleteUser.Enabled = true;
                }
                else {
                    ErrorAuthorization EA = new ErrorAuthorization();
                    EA.Show();
                }
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
            else if (tabMenu.SelectedTab == pageServices) {
                frmAddServices FAS = new frmAddServices(null);
                FAS.ShowDialog();
                if (FAS.DialogResult == DialogResult.OK) {
                    bttnRefresh_Click(sender, e);
                }
            }
        }

        /*
         * Add user
         */
        private void bttnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUser FAU = new frmAddUser(null);
            FAU.ShowDialog();
            if (FAU.DialogResult == DialogResult.OK) {
                bttnRefresh_Click(sender, e);
            }
        }

        /*
         * Change data
         */
        private void bttnChange_Click(object sender, EventArgs e)
        {
            try {
                if (tabMenu.SelectedTab == pageClients) {
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
                else if (tabMenu.SelectedTab == pageRequests) {
                    frmAddRequest FAR = new frmAddRequest(dataTableRequests.SelectedRows[0].Cells[0].Value.ToString());
                    FAR.cbNameAnalysis.Text = dataTableRequests.SelectedRows[0].Cells[1].Value.ToString();
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
                else if (tabMenu.SelectedTab == pageServices) {
                    frmAddServices FAS = new frmAddServices(dataTableServices.SelectedRows[0].Cells[0].Value.ToString());
                    FAS.tbName.Text = dataTableServices.SelectedRows[0].Cells[0].Value.ToString();
                    FAS.tbPrice.Text = dataTableServices.SelectedRows[0].Cells[1].Value.ToString();
                    FAS.tbTerm.Text = dataTableServices.SelectedRows[0].Cells[2].Value.ToString();
                    FAS.tbRecommendation.Text = dataTableServices.SelectedRows[0].Cells[3].Value.ToString();
                    FAS.bttnOK.Text = "Изменить";
                    FAS.labelPanelAdm.Text = "Изменить данные услуги";
                    FAS.labelPanelAdm.Left = ( ClientSize.Width - FAS.labelPanelAdm.Width ) / 2;
                    FAS.ShowDialog();
                    if (FAS.DialogResult == DialogResult.OK) {
                        bttnRefresh_Click(sender, e);
                    }
                }
            }
            catch {
                ErrorChangeData errorCD = new ErrorChangeData();
                errorCD.Show();
            }
        }
        /*
         * Change data user
         */
        private void bttnChngUser_Click(object sender, EventArgs e)
        {
            try {
                if (AdmUsr == "User") {
                    frmAddUser FAU = new frmAddUser(dataTableUsers.SelectedRows[0].Cells[0].Value.ToString());
                    FAU.tbLogin.Text = dataTableUsers.SelectedRows[0].Cells[1].Value.ToString();
                    FAU.tbFN.Text = dataTableUsers.SelectedRows[0].Cells[2].Value.ToString();
                    FAU.chckBoxAdm.Visible = false;
                    FAU.bttnOK.Text = "Изменить";
                    FAU.labelPanelAdm.Text = "Изменить данные пользователя";
                    FAU.labelPanelAdm.Left = ( ClientSize.Width - FAU.labelPanelAdm.Width ) / 2;
                    FAU.ShowDialog();
                    if (FAU.DialogResult == DialogResult.OK) {
                        bttnRefresh_Click(sender, e);
                    }
                }
                else if (AdmUsr == "Admin") {
                    frmAddUser FAU = new frmAddUser(dataTableAdm.SelectedRows[0].Cells[0].Value.ToString());
                    FAU.tbLogin.Text = dataTableAdm.SelectedRows[0].Cells[1].Value.ToString();
                    FAU.tbFN.Text = dataTableAdm.SelectedRows[0].Cells[2].Value.ToString();
                    FAU.bttnOK.Text = "Изменить";
                    FAU.labelPanelAdm.Text = "Изменить данные пользователя";
                    FAU.labelPanelAdm.Left = ( ClientSize.Width - FAU.labelPanelAdm.Width ) / 2;
                    FAU.ShowDialog();
                    if (FAU.DialogResult == DialogResult.OK) {
                        bttnRefresh_Click(sender, e);
                    }
                }
            }
            catch {
                ErrorChangeData errorCD = new ErrorChangeData();
                errorCD.Show();
            }
        }

        static private string AdmUsr;
        private void dataTableClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                dataTableClients.Rows[e.RowIndex].Selected = true;
            }
            catch { }
        }
        private void dataTableRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                dataTableRequests.Rows[e.RowIndex].Selected = true;
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
        private void dataTableUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                dataTableUsers.Rows[e.RowIndex].Selected = true;
                dataTableAdm.Rows[e.RowIndex].Selected = false;
                AdmUsr = "User";
            }
            catch { }
        }
        private void dataTableAdm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                dataTableAdm.Rows[e.RowIndex].Selected = true;
                dataTableUsers.Rows[e.RowIndex].Selected = false;
                AdmUsr = "Admin";
            }
            catch { }
        }

        /*
         * Delete
         */
        private void bttnDelete_Click(object sender, EventArgs e)
        {
            if (tabMenu.SelectedTab == pageClients) {
                for (var i = 0; i < dataTableClients.SelectedRows.Count; i++) {
                    MySqlCommand commandD = new MySqlCommand("DELETE FROM клиент WHERE `" + dataTableClients.Columns[0].HeaderText + "` = '" + dataTableClients.SelectedRows[i].Cells[0].Value.ToString() + "'", frmAuthorization.connection);
                    commandD.ExecuteNonQuery();
                    MySqlCommand commandD2 = new MySqlCommand("DELETE FROM заявка WHERE `Номер и серия паспорта`= '" + dataTableClients.SelectedRows[i].Cells[0].Value.ToString() + "'", frmAuthorization.connection);
                    commandD2.ExecuteNonQuery();
                }
                bttnRefresh_Click(sender, e);
            }
            else if (tabMenu.SelectedTab == pageRequests) {
                for (var i = 0; i < dataTableRequests.SelectedRows.Count; i++) {
                    MySqlCommand commandD = new MySqlCommand("DELETE FROM заявка WHERE `" + dataTableRequests.Columns[0].HeaderText + "` = '" + dataTableRequests.SelectedRows[i].Cells[0].Value.ToString() + "'", frmAuthorization.connection);
                    commandD.ExecuteNonQuery();
                }
                bttnRefresh_Click(sender, e);
            }
            else if (tabMenu.SelectedTab == pageServices) {
                for (var i = 0; i < dataTableServices.SelectedRows.Count; i++) {
                    MySqlCommand commandD = new MySqlCommand("DELETE FROM услуги WHERE `" + dataTableServices.Columns[0].HeaderText + "` = '" + dataTableServices.SelectedRows[i].Cells[0].Value.ToString() + "'", frmAuthorization.connection);
                    commandD.ExecuteNonQuery();
                }
                bttnRefresh_Click(sender, e);
            }
        }
        /*
         * Delete data user
         */
        private void bttnDeleteUser_Click(object sender, EventArgs e)
        {
            if (AdmUsr == "User") {
                for (var i = 0; i < dataTableUsers.SelectedRows.Count; i++) {
                    MySqlCommand commandD = new MySqlCommand("DELETE FROM пользователь WHERE `" + dataTableUsers.Columns[0].HeaderText + "` = '" + dataTableUsers.SelectedRows[i].Cells[0].Value.ToString() + "'", frmAuthorization.connection);
                    commandD.ExecuteNonQuery();
                }
                bttnRefresh_Click(sender, e);
            }
            else if (AdmUsr == "Admin") {
                for (var i = 0; i < dataTableAdm.SelectedRows.Count; i++) {
                    MySqlCommand commandD = new MySqlCommand("DELETE FROM администраторы WHERE `" + dataTableAdm.Columns[0].HeaderText + "` = '" + dataTableAdm.SelectedRows[i].Cells[0].Value.ToString() + "'", frmAuthorization.connection);
                    commandD.ExecuteNonQuery();
                }
                bttnRefresh_Click(sender, e);
            }
        }

        /*
         * Export backup DB
         */
        private void bttnExportDB_Click(object sender, EventArgs e)
        {
            Process PR = new Process();
            ProcessStartInfo SI = new ProcessStartInfo();
            SI.FileName = "cmd.exe";
            saveFile.Filter = "MySQL Text File|*.sql";
            saveFile.FileName = "Backup LIS";

            if (saveFile.ShowDialog() == DialogResult.OK) {
                SI.Arguments = "/c \"\"C:\\Program Files\\MySQL\\MySQL Server 8.0\\bin\\MySQLdump.exe\" -uroot -h127.0.0.1 -P3306 -pVfhnvfhn23@ lis > \"" + saveFile.FileName + "\"\"";
                PR.StartInfo = SI;
                PR.Start();
            }
        }
        /*
         * Import backup DB
         */
        private void bttnImportDB_Click(object sender, EventArgs e)
        {
            Process PR = new Process();
            ProcessStartInfo SI = new ProcessStartInfo();
            SI.FileName = "cmd.exe";

            if (openFile.ShowDialog() == DialogResult.OK) {
                SI.Arguments = "/c \"\"C:\\Program Files\\MySQL\\MySQL Server 8.0\\bin\\MySQL.exe\" -uroot -h127.0.0.1 -P3306 -pVfhnvfhn23@ lis < \"" + openFile.FileName + "\"\"";
                PR.StartInfo = SI;
                PR.Start();
            }
        }
    }
}
