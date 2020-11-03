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
            this.topPanel = new System.Windows.Forms.Panel();
            this.bttnClose = new System.Windows.Forms.PictureBox();
            this.topColorPanel = new System.Windows.Forms.Panel();
            this.labelAuthorization = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.labelAuthorization);
            this.topPanel.Controls.Add(this.bttnClose);
            this.topPanel.Controls.Add(this.topColorPanel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(315, 44);
            this.topPanel.TabIndex = 0;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseEnter += new System.EventHandler(this.topPanel_MouseEnter);
            this.topPanel.MouseLeave += new System.EventHandler(this.topPanel_MouseLeave);
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
            // topColorPanel
            // 
            this.topColorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.topColorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topColorPanel.Location = new System.Drawing.Point(0, 0);
            this.topColorPanel.Name = "topColorPanel";
            this.topColorPanel.Size = new System.Drawing.Size(315, 12);
            this.topColorPanel.TabIndex = 1;
            this.topColorPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topColorPanel_MouseDown);
            // 
            // labelAuthorization
            // 
            this.labelAuthorization.AutoSize = true;
            this.labelAuthorization.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelAuthorization.Location = new System.Drawing.Point(86, 19);
            this.labelAuthorization.Name = "labelAuthorization";
            this.labelAuthorization.Size = new System.Drawing.Size(142, 18);
            this.labelAuthorization.TabIndex = 1;
            this.labelAuthorization.Text = "А в т о р и з а ц и я";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelLogin.Location = new System.Drawing.Point(12, 68);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(52, 18);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Логин";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Roboto", 11F);
            this.labelPass.Location = new System.Drawing.Point(12, 105);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(61, 18);
            this.labelPass.TabIndex = 1;
            this.labelPass.Text = "Пароль";
            // 
            // frmAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(315, 429);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Roboto", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAuthorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel topColorPanel;
        private System.Windows.Forms.PictureBox bttnClose;
        private System.Windows.Forms.Label labelAuthorization;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPass;
    }
}

