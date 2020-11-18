namespace LIS.Adm
{
    partial class frmCheckPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckPassword));
            this.bttnLookPassword = new System.Windows.Forms.PictureBox();
            this.bttnEnter = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelAuthorization = new System.Windows.Forms.Label();
            this.bttnClose = new System.Windows.Forms.PictureBox();
            this.panelTopColor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bttnLookPassword)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnLookPassword
            // 
            this.bttnLookPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnLookPassword.Image = ((System.Drawing.Image)(resources.GetObject("bttnLookPassword.Image")));
            this.bttnLookPassword.Location = new System.Drawing.Point(294, 64);
            this.bttnLookPassword.Name = "bttnLookPassword";
            this.bttnLookPassword.Size = new System.Drawing.Size(20, 20);
            this.bttnLookPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bttnLookPassword.TabIndex = 20;
            this.bttnLookPassword.TabStop = false;
            this.bttnLookPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bttnLookPassword_MouseDown);
            this.bttnLookPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bttnLookPassword_MouseUp);
            // 
            // bttnEnter
            // 
            this.bttnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnEnter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnEnter.FlatAppearance.BorderSize = 0;
            this.bttnEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bttnEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.bttnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnEnter.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bttnEnter.Location = new System.Drawing.Point(-1, 91);
            this.bttnEnter.Name = "bttnEnter";
            this.bttnEnter.Size = new System.Drawing.Size(337, 24);
            this.bttnEnter.TabIndex = 19;
            this.bttnEnter.Text = "Войти";
            this.bttnEnter.UseVisualStyleBackColor = true;
            this.bttnEnter.Click += new System.EventHandler(this.bttnEnter_Click);
            this.bttnEnter.MouseEnter += new System.EventHandler(this.bttnEnter_MouseEnter);
            this.bttnEnter.MouseLeave += new System.EventHandler(this.bttnEnter_MouseLeave);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbPassword.Location = new System.Drawing.Point(101, 63);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.Size = new System.Drawing.Size(214, 22);
            this.tbPassword.TabIndex = 18;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelPass.Location = new System.Drawing.Point(24, 65);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(63, 19);
            this.labelPass.TabIndex = 17;
            this.labelPass.Text = "Пароль";
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
            this.panelTop.Size = new System.Drawing.Size(336, 44);
            this.panelTop.TabIndex = 16;
            // 
            // labelAuthorization
            // 
            this.labelAuthorization.AutoSize = true;
            this.labelAuthorization.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthorization.Location = new System.Drawing.Point(83, 18);
            this.labelAuthorization.Name = "labelAuthorization";
            this.labelAuthorization.Size = new System.Drawing.Size(170, 18);
            this.labelAuthorization.TabIndex = 1;
            this.labelAuthorization.Text = "Подтвердите пароль";
            // 
            // bttnClose
            // 
            this.bttnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnClose.Image = ((System.Drawing.Image)(resources.GetObject("bttnClose.Image")));
            this.bttnClose.Location = new System.Drawing.Point(308, 15);
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
            this.panelTopColor.Size = new System.Drawing.Size(336, 12);
            this.panelTopColor.TabIndex = 1;
            // 
            // frmCheckPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(336, 130);
            this.Controls.Add(this.bttnLookPassword);
            this.Controls.Add(this.bttnEnter);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCheckPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCheckPassword";
            ((System.ComponentModel.ISupportInitialize)(this.bttnLookPassword)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bttnLookPassword;
        private System.Windows.Forms.Button bttnEnter;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelAuthorization;
        private System.Windows.Forms.PictureBox bttnClose;
        private System.Windows.Forms.Panel panelTopColor;
    }
}