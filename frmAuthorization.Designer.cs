namespace LIS
{
    partial class frmAuthorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuthorization));
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelAuthorization = new System.Windows.Forms.Label();
            this.bttnClose = new System.Windows.Forms.PictureBox();
            this.panelTopColor = new System.Windows.Forms.Panel();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.bttnEnter = new System.Windows.Forms.Button();
            this.chckBoxAdm = new System.Windows.Forms.CheckBox();
            this.bttnLookPassword = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnLookPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.labelAuthorization);
            this.panelTop.Controls.Add(this.bttnClose);
            this.panelTop.Controls.Add(this.panelTopColor);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(315, 44);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.panelTop.MouseEnter += new System.EventHandler(this.topPanel_MouseEnter);
            this.panelTop.MouseLeave += new System.EventHandler(this.topPanel_MouseLeave);
            // 
            // labelAuthorization
            // 
            this.labelAuthorization.AutoSize = true;
            this.labelAuthorization.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthorization.Location = new System.Drawing.Point(103, 19);
            this.labelAuthorization.Name = "labelAuthorization";
            this.labelAuthorization.Size = new System.Drawing.Size(108, 18);
            this.labelAuthorization.TabIndex = 1;
            this.labelAuthorization.Text = "Авторизация";
            // 
            // bttnClose
            // 
            this.bttnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnClose.Image = ((System.Drawing.Image)(resources.GetObject("bttnClose.Image")));
            this.bttnClose.Location = new System.Drawing.Point(287, 15);
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
            this.panelTopColor.Size = new System.Drawing.Size(315, 12);
            this.panelTopColor.TabIndex = 1;
            this.panelTopColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topColorPanel_MouseDown);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelLogin.Location = new System.Drawing.Point(12, 67);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(49, 19);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Логин";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelPass.Location = new System.Drawing.Point(12, 104);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(63, 19);
            this.labelPass.TabIndex = 1;
            this.labelPass.Text = "Пароль";
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbLogin.Location = new System.Drawing.Point(89, 65);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(214, 22);
            this.tbLogin.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbPassword.Location = new System.Drawing.Point(89, 102);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.Size = new System.Drawing.Size(214, 22);
            this.tbPassword.TabIndex = 2;
            // 
            // bttnEnter
            // 
            this.bttnEnter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bttnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnEnter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnEnter.FlatAppearance.BorderSize = 0;
            this.bttnEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bttnEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.bttnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnEnter.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bttnEnter.Location = new System.Drawing.Point(0, 158);
            this.bttnEnter.Name = "bttnEnter";
            this.bttnEnter.Size = new System.Drawing.Size(315, 24);
            this.bttnEnter.TabIndex = 3;
            this.bttnEnter.Text = "Войти";
            this.bttnEnter.UseVisualStyleBackColor = true;
            this.bttnEnter.Click += new System.EventHandler(this.bttnEnter_Click);
            this.bttnEnter.MouseLeave += new System.EventHandler(this.bttnEnter_MouseLeave);
            this.bttnEnter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bttnEnter_MouseMove);
            // 
            // chckBoxAdm
            // 
            this.chckBoxAdm.AutoSize = true;
            this.chckBoxAdm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chckBoxAdm.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.chckBoxAdm.Location = new System.Drawing.Point(162, 131);
            this.chckBoxAdm.Name = "chckBoxAdm";
            this.chckBoxAdm.Size = new System.Drawing.Size(141, 23);
            this.chckBoxAdm.TabIndex = 5;
            this.chckBoxAdm.Text = "Администратор";
            this.chckBoxAdm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chckBoxAdm.UseVisualStyleBackColor = true;
            // 
            // bttnLookPassword
            // 
            this.bttnLookPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnLookPassword.Image = ((System.Drawing.Image)(resources.GetObject("bttnLookPassword.Image")));
            this.bttnLookPassword.Location = new System.Drawing.Point(282, 103);
            this.bttnLookPassword.Name = "bttnLookPassword";
            this.bttnLookPassword.Size = new System.Drawing.Size(20, 20);
            this.bttnLookPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bttnLookPassword.TabIndex = 15;
            this.bttnLookPassword.TabStop = false;
            this.bttnLookPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bttnLookPassword_MouseDown);
            this.bttnLookPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bttnLookPassword_MouseUp);
            // 
            // frmAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(315, 196);
            this.Controls.Add(this.bttnLookPassword);
            this.Controls.Add(this.chckBoxAdm);
            this.Controls.Add(this.bttnEnter);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Roboto", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAuthorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnLookPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelTopColor;
        private System.Windows.Forms.PictureBox bttnClose;
        private System.Windows.Forms.Label labelAuthorization;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button bttnEnter;
        private System.Windows.Forms.CheckBox chckBoxAdm;
        private System.Windows.Forms.PictureBox bttnLookPassword;
    }
}

