namespace LIS
{
    partial class frmMenuUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bttnRollUp = new System.Windows.Forms.PictureBox();
            this.bttnClose = new System.Windows.Forms.PictureBox();
            this.bttnFullS = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelPanelUser = new System.Windows.Forms.Label();
            this.panelTopColor = new System.Windows.Forms.Panel();
            this.bttnNormalS = new System.Windows.Forms.PictureBox();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.pageRequests = new System.Windows.Forms.TabPage();
            this.dataTableRequests = new System.Windows.Forms.DataGridView();
            this.pageClients = new System.Windows.Forms.TabPage();
            this.dataTableClients = new System.Windows.Forms.DataGridView();
            this.pageServices = new System.Windows.Forms.TabPage();
            this.dataTableServices = new System.Windows.Forms.DataGridView();
            this.labelSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.bttnRefresh = new System.Windows.Forms.Button();
            this.bttnChange = new System.Windows.Forms.Button();
            this.bttnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bttnRollUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnFullS)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnNormalS)).BeginInit();
            this.panelCenter.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.pageRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableRequests)).BeginInit();
            this.pageClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableClients)).BeginInit();
            this.pageServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableServices)).BeginInit();
            this.SuspendLayout();
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
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.bttnRollUp);
            this.panelTop.Controls.Add(this.labelPanelUser);
            this.panelTop.Controls.Add(this.bttnClose);
            this.panelTop.Controls.Add(this.panelTopColor);
            this.panelTop.Controls.Add(this.bttnFullS);
            this.panelTop.Controls.Add(this.bttnNormalS);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1171, 44);
            this.panelTop.TabIndex = 2;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // labelPanelUser
            // 
            this.labelPanelUser.AutoSize = true;
            this.labelPanelUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPanelUser.Location = new System.Drawing.Point(484, 18);
            this.labelPanelUser.Name = "labelPanelUser";
            this.labelPanelUser.Size = new System.Drawing.Size(118, 18);
            this.labelPanelUser.TabIndex = 1;
            this.labelPanelUser.Text = "Главное меню";
            // 
            // panelTopColor
            // 
            this.panelTopColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.panelTopColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopColor.Location = new System.Drawing.Point(0, 0);
            this.panelTopColor.Name = "panelTopColor";
            this.panelTopColor.Size = new System.Drawing.Size(1171, 12);
            this.panelTopColor.TabIndex = 1;
            this.panelTopColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopColor_MouseDown);
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
            // panelCenter
            // 
            this.panelCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCenter.Controls.Add(this.tabMenu);
            this.panelCenter.Location = new System.Drawing.Point(0, 44);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1171, 548);
            this.panelCenter.TabIndex = 5;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.pageRequests);
            this.tabMenu.Controls.Add(this.pageClients);
            this.tabMenu.Controls.Add(this.pageServices);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Drawing.Point(10, 3);
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(1171, 548);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.SelectedIndexChanged += new System.EventHandler(this.tabMenu_SelectedIndexChanged);
            // 
            // pageRequests
            // 
            this.pageRequests.Controls.Add(this.dataTableRequests);
            this.pageRequests.Location = new System.Drawing.Point(4, 28);
            this.pageRequests.Name = "pageRequests";
            this.pageRequests.Size = new System.Drawing.Size(1163, 516);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTableRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTableRequests.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataTableRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTableRequests.Location = new System.Drawing.Point(0, 0);
            this.dataTableRequests.Name = "dataTableRequests";
            this.dataTableRequests.ReadOnly = true;
            this.dataTableRequests.Size = new System.Drawing.Size(1163, 516);
            this.dataTableRequests.TabIndex = 1;
            this.dataTableRequests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTableRequests_CellClick);
            // 
            // pageClients
            // 
            this.pageClients.Controls.Add(this.dataTableClients);
            this.pageClients.Location = new System.Drawing.Point(4, 28);
            this.pageClients.Name = "pageClients";
            this.pageClients.Size = new System.Drawing.Size(1163, 516);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataTableClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTableClients.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataTableClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTableClients.Location = new System.Drawing.Point(0, 0);
            this.dataTableClients.Name = "dataTableClients";
            this.dataTableClients.ReadOnly = true;
            this.dataTableClients.Size = new System.Drawing.Size(1163, 516);
            this.dataTableClients.TabIndex = 0;
            this.dataTableClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTableClients_CellClick);
            // 
            // pageServices
            // 
            this.pageServices.Controls.Add(this.dataTableServices);
            this.pageServices.Location = new System.Drawing.Point(4, 28);
            this.pageServices.Name = "pageServices";
            this.pageServices.Size = new System.Drawing.Size(1163, 516);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTableServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataTableServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTableServices.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataTableServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTableServices.Location = new System.Drawing.Point(0, 0);
            this.dataTableServices.Name = "dataTableServices";
            this.dataTableServices.ReadOnly = true;
            this.dataTableServices.Size = new System.Drawing.Size(1163, 516);
            this.dataTableServices.TabIndex = 2;
            this.dataTableServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTableServices_CellClick);
            // 
            // labelSearch
            // 
            this.labelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelSearch.Location = new System.Drawing.Point(857, 601);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(53, 19);
            this.labelSearch.TabIndex = 11;
            this.labelSearch.Text = "Поиск";
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearch.Location = new System.Drawing.Point(916, 600);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(243, 21);
            this.tbSearch.TabIndex = 6;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // bttnRefresh
            // 
            this.bttnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnRefresh.FlatAppearance.BorderSize = 0;
            this.bttnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bttnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.bttnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnRefresh.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bttnRefresh.Location = new System.Drawing.Point(396, 596);
            this.bttnRefresh.Margin = new System.Windows.Forms.Padding(1);
            this.bttnRefresh.Name = "bttnRefresh";
            this.bttnRefresh.Size = new System.Drawing.Size(190, 29);
            this.bttnRefresh.TabIndex = 7;
            this.bttnRefresh.Text = "Обновить БД";
            this.bttnRefresh.UseVisualStyleBackColor = true;
            this.bttnRefresh.Click += new System.EventHandler(this.bttnRefresh_Click);
            this.bttnRefresh.MouseEnter += new System.EventHandler(this.bttnRefresh_MouseEnter);
            this.bttnRefresh.MouseLeave += new System.EventHandler(this.bttnRefresh_MouseLeave);
            // 
            // bttnChange
            // 
            this.bttnChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnChange.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnChange.FlatAppearance.BorderSize = 0;
            this.bttnChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bttnChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.bttnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnChange.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bttnChange.Location = new System.Drawing.Point(203, 596);
            this.bttnChange.Margin = new System.Windows.Forms.Padding(1);
            this.bttnChange.Name = "bttnChange";
            this.bttnChange.Size = new System.Drawing.Size(190, 29);
            this.bttnChange.TabIndex = 9;
            this.bttnChange.Text = "Изменить";
            this.bttnChange.UseVisualStyleBackColor = true;
            this.bttnChange.Click += new System.EventHandler(this.bttnChange_Click);
            this.bttnChange.MouseEnter += new System.EventHandler(this.bttnChange_MouseEnter);
            this.bttnChange.MouseLeave += new System.EventHandler(this.bttnChange_MouseLeave);
            // 
            // bttnAdd
            // 
            this.bttnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bttnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnAdd.FlatAppearance.BorderSize = 0;
            this.bttnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bttnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.bttnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAdd.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bttnAdd.Location = new System.Drawing.Point(10, 596);
            this.bttnAdd.Margin = new System.Windows.Forms.Padding(1);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(190, 29);
            this.bttnAdd.TabIndex = 10;
            this.bttnAdd.Text = "Добавить";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            this.bttnAdd.MouseEnter += new System.EventHandler(this.bttnAdd_MouseEnter);
            this.bttnAdd.MouseLeave += new System.EventHandler(this.bttnAdd_MouseLeave);
            // 
            // frmMenuUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1171, 635);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.bttnRefresh);
            this.Controls.Add(this.bttnChange);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuUser";
            this.Load += new System.EventHandler(this.frmMenuUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bttnRollUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnFullS)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnNormalS)).EndInit();
            this.panelCenter.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.pageRequests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableRequests)).EndInit();
            this.pageClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableClients)).EndInit();
            this.pageServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bttnRollUp;
        private System.Windows.Forms.PictureBox bttnClose;
        private System.Windows.Forms.PictureBox bttnFullS;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelPanelUser;
        private System.Windows.Forms.Panel panelTopColor;
        private System.Windows.Forms.PictureBox bttnNormalS;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage pageRequests;
        private System.Windows.Forms.DataGridView dataTableRequests;
        private System.Windows.Forms.TabPage pageClients;
        private System.Windows.Forms.DataGridView dataTableClients;
        private System.Windows.Forms.TabPage pageServices;
        private System.Windows.Forms.DataGridView dataTableServices;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button bttnRefresh;
        private System.Windows.Forms.Button bttnChange;
        private System.Windows.Forms.Button bttnAdd;
    }
}