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
            }
        }

        private void tabMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            bttnRefresh_Click(sender, e);
        }        
    }
}
