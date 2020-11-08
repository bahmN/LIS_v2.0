using LIS.Errors;
using MySql.Data.MySqlClient;
using System;
using System.Data;
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
         * Size form
         */
        private void bttnFullS_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            labelPanelAdm.Left = ( ClientSize.Width - labelPanelAdm.Width ) / 2;
            bttnFullS.Visible = false;
            bttnNormalS.Visible = true;
        }

        private void bttnNormalS_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            labelPanelAdm.Left = ( ClientSize.Width - labelPanelAdm.Width ) / 2;
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
                      "OR `e-mail` LIKE '%" + tbSearch.Text + "%'", connection);
                DataTable dtSearch = new DataTable();
                daSearch.Fill(dtSearch);
                dataTableClients.DataSource = dtSearch;
            }
            else if (tabMenu.SelectedTab == pageRequests) {
            }
            else if (tabMenu.SelectedTab == pageServices) {
            }

        }

        // Color when mouse move on the button         
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
        //----------------------------------------------------------------------
        private void frmMenuAdm_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection("server = 127.0.0.1; port = 3306; user = root; password = Vfhnvfhn23@; database = lis; sslmode = none;");
            connection.Open();
            bttnRefresh_Click(sender, e);
        }

        private void bttnRefresh_Click(object sender, EventArgs e)
        {
            if (tabMenu.SelectedTab == pageClients) {
                MySqlDataAdapter daClients = new MySqlDataAdapter("SELECT * FROM клиент", connection);
                DataTable dtClients = new DataTable();
                daClients.Fill(dtClients);
                dataTableClients.DataSource = dtClients;
                dataTableClients.RowHeadersVisible = false; // Убрать отображение самой левой колонки
            }
            else if (tabMenu.SelectedTab == pageRequests) {
                MySqlDataAdapter daRequests = new MySqlDataAdapter("SELECT * FROM заявка", connection);
                DataTable dtRequests = new DataTable();
                daRequests.Fill(dtRequests);
                dataTableRequests.DataSource = dtRequests;
                dataTableRequests.RowHeadersVisible = false; // Убрать отображение самой левой колонки
                dataTableRequests.Columns[0].FillWeight = 60;
            }
            else if (tabMenu.SelectedTab == pageServices) {
                MySqlDataAdapter daServices = new MySqlDataAdapter("SELECT * FROM `вид услуг`", connection);
                DataTable dtServices = new DataTable();
                daServices.Fill(dtServices);
                dataTableServices.DataSource = dtServices;
                dataTableServices.RowHeadersVisible = false; // Убрать отображение самой левой колонки
                dataTableServices.AllowUserToAddRows = false;
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
            }
            catch {
                ErrorChangeData errorCD = new ErrorChangeData();
                errorCD.Show();
            }
        }

        private void dataTableClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                dataTableClients.Rows[e.RowIndex].Selected = true;
            }
            catch { }
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            if (tabMenu.SelectedTab == pageClients) {
                for (var i = 0; i < dataTableClients.SelectedRows.Count; i++) {
                    MySqlCommand commandDP = new MySqlCommand("DELETE FROM клиент WHERE `" + dataTableClients.Columns[0].HeaderText + "` = '" + dataTableClients.SelectedRows[i].Cells[0].Value.ToString() + "'", connection);
                    commandDP.ExecuteNonQuery();
                }
                bttnRefresh_Click(sender, e);
            }
            else if (tabMenu.SelectedTab == pageRequests) {
            }
            else if (tabMenu.SelectedTab == pageServices) {
            }
        }
    }
}
