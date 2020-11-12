namespace LIS
{
    partial class frmMenuAdm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuAdm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTopColor = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.bttnRollUp = new System.Windows.Forms.PictureBox();
            this.labelPanelAdm = new System.Windows.Forms.Label();
            this.bttnClose = new System.Windows.Forms.PictureBox();
            this.bttnFullS = new System.Windows.Forms.PictureBox();
            this.bttnNormalS = new System.Windows.Forms.PictureBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.bttnChngUser = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.bttnImportDB = new System.Windows.Forms.Button();
            this.bttnExportDB = new System.Windows.Forms.Button();
            this.bttnAddUser = new System.Windows.Forms.Button();
            this.bttnRefresh = new System.Windows.Forms.Button();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.bttnChange = new System.Windows.Forms.Button();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.pageRequests = new System.Windows.Forms.TabPage();
            this.dataTableRequests = new System.Windows.Forms.DataGridView();
            this.pageClients = new System.Windows.Forms.TabPage();
            this.dataTableClients = new System.Windows.Forms.DataGridView();
            this.pageServices = new System.Windows.Forms.TabPage();
            this.dataTableServices = new System.Windows.Forms.DataGridView();
            this.pageUsers = new System.Windows.Forms.TabPage();
            this.labelAdm = new System.Windows.Forms.Label();
            this.labelUsers = new System.Windows.Forms.Label();
            this.dataTableAdm = new System.Windows.Forms.DataGridView();
            this.dataTableUsers = new System.Windows.Forms.DataGridView();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.bttnDeleteUser = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnRollUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnFullS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnNormalS)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelCenter.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.pageRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableRequests)).BeginInit();
            this.pageClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableClients)).BeginInit();
            this.pageServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableServices)).BeginInit();
            this.pageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableAdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopColor
            // 
            this.panelTopColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.panelTopColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopColor.Location = new System.Drawing.Point(0, 0);
            this.panelTopColor.Name = "panelTopColor";
            this.panelTopColor.Size = new System.Drawing.Size(1171, 12);
            this.panelTopColor.TabIndex = 1;
            this.panelTopColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topColorPanel_MouseDown);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.bttnRollUp);
            this.panelTop.Controls.Add(this.labelPanelAdm);
            this.panelTop.Controls.Add(this.bttnClose);
            this.panelTop.Controls.Add(this.panelTopColor);
            this.panelTop.Controls.Add(this.bttnFullS);
            this.panelTop.Controls.Add(this.bttnNormalS);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1171, 44);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // bttnRollUp
            // 
            this.bttnRollUp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttnRollUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnRollUp.Image = ((System.Drawing.Image)(resources.GetObject("bttnRollUp.Image")));
            this.bttnRollUp.Location = new System.Drawing.Point(1081, 15);
            this.bttnRollUp.Name = "bttnRollUp";
            this.bttnRollUp.Size = new System.Drawing.Size(25, 25);
            this.bttnRollUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bttnRollUp.TabIndex = 2;
            this.bttnRollUp.TabStop = false;
            this.bttnRollUp.Click += new System.EventHandler(this.bttnRollUp_Click);
            // 
            // labelPanelAdm
            // 
            this.labelPanelAdm.AutoSize = true;
            this.labelPanelAdm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPanelAdm.Location = new System.Drawing.Point(484, 18);
            this.labelPanelAdm.Name = "labelPanelAdm";
            this.labelPanelAdm.Size = new System.Drawing.Size(202, 18);
            this.labelPanelAdm.TabIndex = 1;
            this.labelPanelAdm.Text = "Панель администратора";
            // 
            // bttnClose
            // 
            this.bttnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnClose.Image = ((System.Drawing.Image)(resources.GetObject("bttnClose.Image")));
            this.bttnClose.Location = new System.Drawing.Point(1143, 15);
            this.bttnClose.Name = "bttnClose";
            this.bttnClose.Size = new System.Drawing.Size(25, 25);
            this.bttnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bttnClose.TabIndex = 1;
            this.bttnClose.TabStop = false;
            this.bttnClose.Click += new System.EventHandler(this.bttnClose_Click);
            // 
            // bttnFullS
            // 
            this.bttnFullS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttnFullS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnFullS.Image = ((System.Drawing.Image)(resources.GetObject("bttnFullS.Image")));
            this.bttnFullS.Location = new System.Drawing.Point(1112, 15);
            this.bttnFullS.Name = "bttnFullS";
            this.bttnFullS.Size = new System.Drawing.Size(25, 25);
            this.bttnFullS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bttnFullS.TabIndex = 2;
            this.bttnFullS.TabStop = false;
            this.bttnFullS.Click += new System.EventHandler(this.bttnFullS_Click);
            // 
            // bttnNormalS
            // 
            this.bttnNormalS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttnNormalS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnNormalS.Image = ((System.Drawing.Image)(resources.GetObject("bttnNormalS.Image")));
            this.bttnNormalS.Location = new System.Drawing.Point(1112, 15);
            this.bttnNormalS.Name = "bttnNormalS";
            this.bttnNormalS.Size = new System.Drawing.Size(25, 25);
            this.bttnNormalS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bttnNormalS.TabIndex = 2;
            this.bttnNormalS.TabStop = false;
            this.bttnNormalS.Click += new System.EventHandler(this.bttnNormalS_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.bttnDeleteUser);
            this.panelLeft.Controls.Add(this.bttnChngUser);
            this.panelLeft.Controls.Add(this.labelSearch);
            this.panelLeft.Controls.Add(this.tbSearch);
            this.panelLeft.Controls.Add(this.bttnImportDB);
            this.panelLeft.Controls.Add(this.bttnExportDB);
            this.panelLeft.Controls.Add(this.bttnAddUser);
            this.panelLeft.Controls.Add(this.bttnRefresh);
            this.panelLeft.Controls.Add(this.bttnDelete);
            this.panelLeft.Controls.Add(this.bttnChange);
            this.panelLeft.Controls.Add(this.bttnAdd);
            this.panelLeft.Controls.Add(this.pbLogo);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 44);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(190, 591);
            this.panelLeft.TabIndex = 3;
            // 
            // bttnChngUser
            // 
            this.bttnChngUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnChngUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnChngUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnChngUser.FlatAppearance.BorderSize = 0;
            this.bttnChngUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bttnChngUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.bttnChngUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnChngUser.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bttnChngUser.Location = new System.Drawing.Point(0, 385);
            this.bttnChngUser.Margin = new System.Windows.Forms.Padding(1);
            this.bttnChngUser.Name = "bttnChngUser";
            this.bttnChngUser.Size = new System.Drawing.Size(190, 53);
            this.bttnChngUser.TabIndex = 6;
            this.bttnChngUser.Text = "Изменить данные пользователя";
            this.bttnChngUser.UseVisualStyleBackColor = true;
            this.bttnChngUser.Click += new System.EventHandler(this.bttnChngUser_Click);
            this.bttnChngUser.MouseEnter += new System.EventHandler(this.bttnChngUser_MouseEnter);
            this.bttnChngUser.MouseLeave += new System.EventHandler(this.bttnChngUser_MouseLeave);
            // 
            // labelSearch
            // 
            this.labelSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelSearch.Location = new System.Drawing.Point(6, 559);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(53, 19);
            this.labelSearch.TabIndex = 5;
            this.labelSearch.Text = "Поиск";
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbSearch.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearch.Location = new System.Drawing.Point(65, 558);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(120, 21);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // bttnImportDB
            // 
            this.bttnImportDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnImportDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnImportDB.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnImportDB.FlatAppearance.BorderSize = 0;
            this.bttnImportDB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bttnImportDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.bttnImportDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnImportDB.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bttnImportDB.Location = new System.Drawing.Point(0, 502);
            this.bttnImportDB.Margin = new System.Windows.Forms.Padding(1);
            this.bttnImportDB.Name = "bttnImportDB";
            this.bttnImportDB.Size = new System.Drawing.Size(190, 29);
            this.bttnImportDB.TabIndex = 4;
            this.bttnImportDB.Text = "Импорт БД";
            this.bttnImportDB.UseVisualStyleBackColor = true;
            this.bttnImportDB.Click += new System.EventHandler(this.bttnImportDB_Click);
            this.bttnImportDB.MouseEnter += new System.EventHandler(this.bttnImportDB_MouseEnter);
            this.bttnImportDB.MouseLeave += new System.EventHandler(this.bttnImportDB_MouseLeave);
            // 
            // bttnExportDB
            // 
            this.bttnExportDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnExportDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnExportDB.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnExportDB.FlatAppearance.BorderSize = 0;
            this.bttnExportDB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bttnExportDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.bttnExportDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnExportDB.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bttnExportDB.Location = new System.Drawing.Point(0, 471);
            this.bttnExportDB.Margin = new System.Windows.Forms.Padding(1);
            this.bttnExportDB.Name = "bttnExportDB";
            this.bttnExportDB.Size = new System.Drawing.Size(190, 29);
            this.bttnExportDB.TabIndex = 4;
            this.bttnExportDB.Text = "Экспорт БД";
            this.bttnExportDB.UseVisualStyleBackColor = true;
            this.bttnExportDB.Click += new System.EventHandler(this.bttnExportDB_Click);
            this.bttnExportDB.MouseEnter += new System.EventHandler(this.bttnExportDB_MouseEnter);
            this.bttnExportDB.MouseLeave += new System.EventHandler(this.bttnExportDB_MouseLeave);
            // 
            // bttnAddUser
            // 
            this.bttnAddUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnAddUser.FlatAppearance.BorderSize = 0;
            this.bttnAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bttnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.bttnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAddUser.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bttnAddUser.Location = new System.Drawing.Point(0, 354);
            this.bttnAddUser.Margin = new System.Windows.Forms.Padding(1);
            this.bttnAddUser.Name = "bttnAddUser";
            this.bttnAddUser.Size = new System.Drawing.Size(190, 29);
            this.bttnAddUser.TabIndex = 4;
            this.bttnAddUser.Text = "Добавить пользователя";
            this.bttnAddUser.UseVisualStyleBackColor = true;
            this.bttnAddUser.Click += new System.EventHandler(this.bttnAddUser_Click);
            this.bttnAddUser.MouseEnter += new System.EventHandler(this.bttnAddUser_MouseEnter);
            this.bttnAddUser.MouseLeave += new System.EventHandler(this.bttnAddUser_MouseLeave);
            // 
            // bttnRefresh
            // 
            this.bttnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnRefresh.FlatAppearance.BorderSize = 0;
            this.bttnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bttnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.bttnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnRefresh.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bttnRefresh.Location = new System.Drawing.Point(0, 297);
            this.bttnRefresh.Margin = new System.Windows.Forms.Padding(1);
            this.bttnRefresh.Name = "bttnRefresh";
            this.bttnRefresh.Size = new System.Drawing.Size(190, 29);
            this.bttnRefresh.TabIndex = 4;
            this.bttnRefresh.Text = "Обновить БД";
            this.bttnRefresh.UseVisualStyleBackColor = true;
            this.bttnRefresh.Click += new System.EventHandler(this.bttnRefresh_Click);
            this.bttnRefresh.MouseEnter += new System.EventHandler(this.bttnRefresh_MouseEnter);
            this.bttnRefresh.MouseLeave += new System.EventHandler(this.bttnRefresh_MouseLeave);
            // 
            // bttnDelete
            // 
            this.bttnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnDelete.FlatAppearance.BorderSize = 0;
            this.bttnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bttnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.bttnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnDelete.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bttnDelete.Location = new System.Drawing.Point(0, 266);
            this.bttnDelete.Margin = new System.Windows.Forms.Padding(1);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(190, 29);
            this.bttnDelete.TabIndex = 4;
            this.bttnDelete.Text = "Удалить";
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            this.bttnDelete.MouseEnter += new System.EventHandler(this.bttnDelete_MouseEnter);
            this.bttnDelete.MouseLeave += new System.EventHandler(this.bttnDelete_MouseLeave);
            // 
            // bttnChange
            // 
            this.bttnChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnChange.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnChange.FlatAppearance.BorderSize = 0;
            this.bttnChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bttnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.bttnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnChange.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bttnChange.Location = new System.Drawing.Point(0, 235);
            this.bttnChange.Margin = new System.Windows.Forms.Padding(1);
            this.bttnChange.Name = "bttnChange";
            this.bttnChange.Size = new System.Drawing.Size(190, 29);
            this.bttnChange.TabIndex = 4;
            this.bttnChange.Text = "Изменить";
            this.bttnChange.UseVisualStyleBackColor = true;
            this.bttnChange.Click += new System.EventHandler(this.bttnChange_Click);
            this.bttnChange.MouseEnter += new System.EventHandler(this.bttnChange_MouseEnter);
            this.bttnChange.MouseLeave += new System.EventHandler(this.bttnChange_MouseLeave);
            // 
            // bttnAdd
            // 
            this.bttnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnAdd.FlatAppearance.BorderSize = 0;
            this.bttnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bttnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.bttnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAdd.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bttnAdd.Location = new System.Drawing.Point(0, 204);
            this.bttnAdd.Margin = new System.Windows.Forms.Padding(1);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(190, 29);
            this.bttnAdd.TabIndex = 4;
            this.bttnAdd.Text = "Добавить";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            this.bttnAdd.MouseEnter += new System.EventHandler(this.bttnAdd_MouseEnter);
            this.bttnAdd.MouseLeave += new System.EventHandler(this.bttnAdd_MouseLeave);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(22, 6);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(147, 50);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.tabMenu);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(190, 44);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(981, 591);
            this.panelCenter.TabIndex = 4;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.pageRequests);
            this.tabMenu.Controls.Add(this.pageClients);
            this.tabMenu.Controls.Add(this.pageServices);
            this.tabMenu.Controls.Add(this.pageUsers);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Drawing.Point(10, 3);
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(981, 591);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.SelectedIndexChanged += new System.EventHandler(this.tabMenu_SelectedIndexChanged);
            // 
            // pageRequests
            // 
            this.pageRequests.Controls.Add(this.dataTableRequests);
            this.pageRequests.Location = new System.Drawing.Point(4, 28);
            this.pageRequests.Name = "pageRequests";
            this.pageRequests.Size = new System.Drawing.Size(973, 559);
            this.pageRequests.TabIndex = 1;
            this.pageRequests.Text = "Заявки";
            this.pageRequests.UseVisualStyleBackColor = true;
            // 
            // dataTableRequests
            // 
            this.dataTableRequests.AllowUserToResizeRows = false;
            this.dataTableRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTableRequests.BackgroundColor = System.Drawing.Color.White;
            this.dataTableRequests.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataTableRequests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dataTableRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTableRequests.DefaultCellStyle = dataGridViewCellStyle32;
            this.dataTableRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTableRequests.Location = new System.Drawing.Point(0, 0);
            this.dataTableRequests.Name = "dataTableRequests";
            this.dataTableRequests.ReadOnly = true;
            this.dataTableRequests.Size = new System.Drawing.Size(973, 559);
            this.dataTableRequests.TabIndex = 1;
            this.dataTableRequests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTableRequests_CellClick);
            // 
            // pageClients
            // 
            this.pageClients.Controls.Add(this.dataTableClients);
            this.pageClients.Location = new System.Drawing.Point(4, 28);
            this.pageClients.Name = "pageClients";
            this.pageClients.Size = new System.Drawing.Size(973, 559);
            this.pageClients.TabIndex = 0;
            this.pageClients.Text = "Клиенты";
            this.pageClients.UseVisualStyleBackColor = true;
            // 
            // dataTableClients
            // 
            this.dataTableClients.AllowUserToResizeRows = false;
            this.dataTableClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTableClients.BackgroundColor = System.Drawing.Color.White;
            this.dataTableClients.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataTableClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dataTableClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTableClients.DefaultCellStyle = dataGridViewCellStyle34;
            this.dataTableClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTableClients.Location = new System.Drawing.Point(0, 0);
            this.dataTableClients.Name = "dataTableClients";
            this.dataTableClients.ReadOnly = true;
            this.dataTableClients.Size = new System.Drawing.Size(973, 559);
            this.dataTableClients.TabIndex = 0;
            this.dataTableClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTableClients_CellClick);
            // 
            // pageServices
            // 
            this.pageServices.Controls.Add(this.dataTableServices);
            this.pageServices.Location = new System.Drawing.Point(4, 28);
            this.pageServices.Name = "pageServices";
            this.pageServices.Size = new System.Drawing.Size(973, 559);
            this.pageServices.TabIndex = 2;
            this.pageServices.Text = "Услуги";
            this.pageServices.UseVisualStyleBackColor = true;
            // 
            // dataTableServices
            // 
            this.dataTableServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTableServices.BackgroundColor = System.Drawing.Color.White;
            this.dataTableServices.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataTableServices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.dataTableServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTableServices.DefaultCellStyle = dataGridViewCellStyle36;
            this.dataTableServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTableServices.Location = new System.Drawing.Point(0, 0);
            this.dataTableServices.Name = "dataTableServices";
            this.dataTableServices.ReadOnly = true;
            this.dataTableServices.Size = new System.Drawing.Size(973, 559);
            this.dataTableServices.TabIndex = 2;
            this.dataTableServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTableServices_CellClick);
            // 
            // pageUsers
            // 
            this.pageUsers.Controls.Add(this.labelAdm);
            this.pageUsers.Controls.Add(this.labelUsers);
            this.pageUsers.Controls.Add(this.dataTableAdm);
            this.pageUsers.Controls.Add(this.dataTableUsers);
            this.pageUsers.Location = new System.Drawing.Point(4, 28);
            this.pageUsers.Name = "pageUsers";
            this.pageUsers.Size = new System.Drawing.Size(973, 559);
            this.pageUsers.TabIndex = 3;
            this.pageUsers.Text = "Пользователи";
            this.pageUsers.UseVisualStyleBackColor = true;
            // 
            // labelAdm
            // 
            this.labelAdm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAdm.AutoSize = true;
            this.labelAdm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdm.Location = new System.Drawing.Point(413, 385);
            this.labelAdm.Name = "labelAdm";
            this.labelAdm.Size = new System.Drawing.Size(146, 18);
            this.labelAdm.TabIndex = 6;
            this.labelAdm.Text = "Администраторы";
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsers.Location = new System.Drawing.Point(429, 4);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(114, 18);
            this.labelUsers.TabIndex = 5;
            this.labelUsers.Text = "Пользователи";
            // 
            // dataTableAdm
            // 
            this.dataTableAdm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTableAdm.BackgroundColor = System.Drawing.Color.White;
            this.dataTableAdm.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataTableAdm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableAdm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dataTableAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTableAdm.DefaultCellStyle = dataGridViewCellStyle38;
            this.dataTableAdm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataTableAdm.Location = new System.Drawing.Point(0, 406);
            this.dataTableAdm.Name = "dataTableAdm";
            this.dataTableAdm.ReadOnly = true;
            this.dataTableAdm.Size = new System.Drawing.Size(973, 153);
            this.dataTableAdm.TabIndex = 4;
            this.dataTableAdm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTableAdm_CellClick);
            // 
            // dataTableUsers
            // 
            this.dataTableUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTableUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTableUsers.BackgroundColor = System.Drawing.Color.White;
            this.dataTableUsers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataTableUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.dataTableUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTableUsers.DefaultCellStyle = dataGridViewCellStyle40;
            this.dataTableUsers.Location = new System.Drawing.Point(0, 25);
            this.dataTableUsers.Name = "dataTableUsers";
            this.dataTableUsers.ReadOnly = true;
            this.dataTableUsers.Size = new System.Drawing.Size(973, 357);
            this.dataTableUsers.TabIndex = 3;
            this.dataTableUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTableUsers_CellClick);
            // 
            // bttnDeleteUser
            // 
            this.bttnDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnDeleteUser.FlatAppearance.BorderSize = 0;
            this.bttnDeleteUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bttnDeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.bttnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnDeleteUser.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bttnDeleteUser.Location = new System.Drawing.Point(0, 440);
            this.bttnDeleteUser.Margin = new System.Windows.Forms.Padding(1);
            this.bttnDeleteUser.Name = "bttnDeleteUser";
            this.bttnDeleteUser.Size = new System.Drawing.Size(190, 29);
            this.bttnDeleteUser.TabIndex = 7;
            this.bttnDeleteUser.Text = "Удалить пользователя";
            this.bttnDeleteUser.UseVisualStyleBackColor = true;
            this.bttnDeleteUser.Click += new System.EventHandler(this.bttnDeleteUser_Click);
            this.bttnDeleteUser.MouseEnter += new System.EventHandler(this.bttnDeleteUser_MouseEnter);
            this.bttnDeleteUser.MouseLeave += new System.EventHandler(this.bttnDeleteUser_MouseLeave);
            // 
            // frmMenuAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1171, 635);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель администратора";
            this.Load += new System.EventHandler(this.frmMenuAdm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnRollUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnFullS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnNormalS)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelCenter.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.pageRequests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableRequests)).EndInit();
            this.pageClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableClients)).EndInit();
            this.pageServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableServices)).EndInit();
            this.pageUsers.ResumeLayout(false);
            this.pageUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableAdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopColor;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelPanelAdm;
        private System.Windows.Forms.PictureBox bttnClose;
        private System.Windows.Forms.PictureBox bttnFullS;
        private System.Windows.Forms.PictureBox bttnNormalS;
        private System.Windows.Forms.PictureBox bttnRollUp;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage pageClients;
        private System.Windows.Forms.TabPage pageRequests;
        private System.Windows.Forms.TabPage pageServices;
        private System.Windows.Forms.Button bttnImportDB;
        private System.Windows.Forms.Button bttnExportDB;
        private System.Windows.Forms.Button bttnAddUser;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Button bttnChange;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.DataGridView dataTableClients;
        private System.Windows.Forms.DataGridView dataTableRequests;
        private System.Windows.Forms.Button bttnRefresh;
        private System.Windows.Forms.DataGridView dataTableServices;
        private System.Windows.Forms.TabPage pageUsers;
        private System.Windows.Forms.DataGridView dataTableUsers;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.DataGridView dataTableAdm;
        private System.Windows.Forms.Label labelAdm;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.Button bttnChngUser;
        private System.Windows.Forms.Button bttnDeleteUser;
    }
}