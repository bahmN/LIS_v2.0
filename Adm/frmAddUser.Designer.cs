namespace LIS.Adm
{
    partial class frmAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUser));
            this.bttnClose = new System.Windows.Forms.PictureBox();
            this.panelTopColor = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelPanelAdm = new System.Windows.Forms.Label();
            this.labeLogin = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.bttnOK = new System.Windows.Forms.Button();
            this.tbFN = new System.Windows.Forms.TextBox();
            this.labelFN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bttnClose)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnClose
            // 
            this.bttnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnClose.Image = ((System.Drawing.Image)(resources.GetObject("bttnClose.Image")));
            this.bttnClose.Location = new System.Drawing.Point(280, 15);
            this.bttnClose.Name = "bttnClose";
            this.bttnClose.Size = new System.Drawing.Size(25, 25);
            this.bttnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bttnClose.TabIndex = 1;
            this.bttnClose.TabStop = false;
            this.bttnClose.Click += new System.EventHandler(this.bttnClose_Click);
            // 
            // panelTopColor
            // 
            this.panelTopColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.panelTopColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopColor.Location = new System.Drawing.Point(0, 0);
            this.panelTopColor.Name = "panelTopColor";
            this.panelTopColor.Size = new System.Drawing.Size(308, 12);
            this.panelTopColor.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.labelPanelAdm);
            this.panelTop.Controls.Add(this.bttnClose);
            this.panelTop.Controls.Add(this.panelTopColor);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(308, 44);
            this.panelTop.TabIndex = 3;
            // 
            // labelPanelAdm
            // 
            this.labelPanelAdm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPanelAdm.AutoSize = true;
            this.labelPanelAdm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPanelAdm.Location = new System.Drawing.Point(59, 18);
            this.labelPanelAdm.Name = "labelPanelAdm";
            this.labelPanelAdm.Size = new System.Drawing.Size(191, 18);
            this.labelPanelAdm.TabIndex = 1;
            this.labelPanelAdm.Text = "Добавить пользователя";
            // 
            // labeLogin
            // 
            this.labeLogin.AutoSize = true;
            this.labeLogin.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labeLogin.Location = new System.Drawing.Point(12, 52);
            this.labeLogin.Name = "labeLogin";
            this.labeLogin.Size = new System.Drawing.Size(49, 19);
            this.labeLogin.TabIndex = 10;
            this.labeLogin.Text = "Логин";
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbLogin.Location = new System.Drawing.Point(79, 50);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(217, 22);
            this.tbLogin.TabIndex = 9;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelPassword.Location = new System.Drawing.Point(12, 80);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(63, 19);
            this.labelPassword.TabIndex = 12;
            this.labelPassword.Text = "Пароль";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbPassword.Location = new System.Drawing.Point(79, 78);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(217, 22);
            this.tbPassword.TabIndex = 11;
            // 
            // bttnOK
            // 
            this.bttnOK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnOK.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnOK.FlatAppearance.BorderSize = 0;
            this.bttnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bttnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.bttnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnOK.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bttnOK.Location = new System.Drawing.Point(0, 137);
            this.bttnOK.Name = "bttnOK";
            this.bttnOK.Size = new System.Drawing.Size(308, 24);
            this.bttnOK.TabIndex = 13;
            this.bttnOK.Text = "Зарегистрировать";
            this.bttnOK.UseVisualStyleBackColor = true;
            this.bttnOK.Click += new System.EventHandler(this.bttnOK_Click);
            this.bttnOK.MouseEnter += new System.EventHandler(this.bttnOK_MouseEnter);
            this.bttnOK.MouseLeave += new System.EventHandler(this.bttnOK_MouseLeave);
            // 
            // tbFN
            // 
            this.tbFN.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbFN.Location = new System.Drawing.Point(79, 106);
            this.tbFN.Name = "tbFN";
            this.tbFN.Size = new System.Drawing.Size(217, 22);
            this.tbFN.TabIndex = 11;
            // 
            // labelFN
            // 
            this.labelFN.AutoSize = true;
            this.labelFN.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelFN.Location = new System.Drawing.Point(12, 108);
            this.labelFN.Name = "labelFN";
            this.labelFN.Size = new System.Drawing.Size(43, 19);
            this.labelFN.TabIndex = 12;
            this.labelFN.Text = "ФИО";
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(308, 170);
            this.Controls.Add(this.bttnOK);
            this.Controls.Add(this.labelFN);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.tbFN);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.labeLogin);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.bttnClose)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bttnClose;
        private System.Windows.Forms.Panel panelTopColor;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelPanelAdm;
        private System.Windows.Forms.Label labeLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button bttnOK;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbFN;
        private System.Windows.Forms.Label labelFN;
    }
}