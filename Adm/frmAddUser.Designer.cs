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
            this.tbPassword2 = new System.Windows.Forms.TextBox();
            this.labelPassword2 = new System.Windows.Forms.Label();
            this.bttnLookPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bttnClose)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnLookPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnClose
            // 
            this.bttnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnClose.Image = ((System.Drawing.Image)(resources.GetObject("bttnClose.Image")));
            this.bttnClose.Location = new System.Drawing.Point(365, 15);
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
            this.panelTopColor.Size = new System.Drawing.Size(393, 12);
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
            this.panelTop.Size = new System.Drawing.Size(393, 44);
            this.panelTop.TabIndex = 3;
            // 
            // labelPanelAdm
            // 
            this.labelPanelAdm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPanelAdm.AutoSize = true;
            this.labelPanelAdm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPanelAdm.Location = new System.Drawing.Point(101, 18);
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
            this.tbLogin.Location = new System.Drawing.Point(164, 52);
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
            this.tbPassword.Location = new System.Drawing.Point(164, 80);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
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
            this.bttnOK.Location = new System.Drawing.Point(0, 168);
            this.bttnOK.Name = "bttnOK";
            this.bttnOK.Size = new System.Drawing.Size(393, 26);
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
            this.tbFN.Location = new System.Drawing.Point(164, 140);
            this.tbFN.Name = "tbFN";
            this.tbFN.Size = new System.Drawing.Size(217, 22);
            this.tbFN.TabIndex = 11;
            // 
            // labelFN
            // 
            this.labelFN.AutoSize = true;
            this.labelFN.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelFN.Location = new System.Drawing.Point(12, 140);
            this.labelFN.Name = "labelFN";
            this.labelFN.Size = new System.Drawing.Size(139, 19);
            this.labelFN.TabIndex = 12;
            this.labelFN.Text = "ФИО пользователя";
            // 
            // tbPassword2
            // 
            this.tbPassword2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbPassword2.Location = new System.Drawing.Point(164, 108);
            this.tbPassword2.Name = "tbPassword2";
            this.tbPassword2.PasswordChar = '•';
            this.tbPassword2.Size = new System.Drawing.Size(217, 22);
            this.tbPassword2.TabIndex = 11;
            // 
            // labelPassword2
            // 
            this.labelPassword2.AutoSize = true;
            this.labelPassword2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelPassword2.Location = new System.Drawing.Point(12, 108);
            this.labelPassword2.Name = "labelPassword2";
            this.labelPassword2.Size = new System.Drawing.Size(138, 19);
            this.labelPassword2.TabIndex = 12;
            this.labelPassword2.Text = "Повторите пароль";
            // 
            // bttnLookPassword
            // 
            this.bttnLookPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnLookPassword.Image = ((System.Drawing.Image)(resources.GetObject("bttnLookPassword.Image")));
            this.bttnLookPassword.Location = new System.Drawing.Point(360, 81);
            this.bttnLookPassword.Name = "bttnLookPassword";
            this.bttnLookPassword.Size = new System.Drawing.Size(20, 20);
            this.bttnLookPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bttnLookPassword.TabIndex = 14;
            this.bttnLookPassword.TabStop = false;
            this.bttnLookPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bttnLookPassword_MouseDown);
            this.bttnLookPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bttnLookPassword_MouseUp);
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(393, 206);
            this.Controls.Add(this.bttnLookPassword);
            this.Controls.Add(this.bttnOK);
            this.Controls.Add(this.labelFN);
            this.Controls.Add(this.labelPassword2);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.tbFN);
            this.Controls.Add(this.tbPassword2);
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
            ((System.ComponentModel.ISupportInitialize)(this.bttnLookPassword)).EndInit();
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
        private System.Windows.Forms.TextBox tbPassword2;
        private System.Windows.Forms.Label labelPassword2;
        private System.Windows.Forms.PictureBox bttnLookPassword;
    }
}