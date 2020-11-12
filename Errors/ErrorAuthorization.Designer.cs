namespace LIS.Errors
{
    partial class ErrorAuthorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorAuthorization));
            this.label1 = new System.Windows.Forms.Label();
            this.panelTopColor = new System.Windows.Forms.Panel();
            this.labelTxt = new System.Windows.Forms.Label();
            this.bttnOK = new System.Windows.Forms.Button();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(70, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ошибка авторизации";
            // 
            // panelTopColor
            // 
            this.panelTopColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.panelTopColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopColor.Location = new System.Drawing.Point(0, 0);
            this.panelTopColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTopColor.Name = "panelTopColor";
            this.panelTopColor.Size = new System.Drawing.Size(317, 16);
            this.panelTopColor.TabIndex = 9;
            // 
            // labelTxt
            // 
            this.labelTxt.AutoSize = true;
            this.labelTxt.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.labelTxt.Location = new System.Drawing.Point(67, 54);
            this.labelTxt.Name = "labelTxt";
            this.labelTxt.Size = new System.Drawing.Size(239, 17);
            this.labelTxt.TabIndex = 11;
            this.labelTxt.Text = "Введён неправильно логин или пароль!";
            // 
            // bttnOK
            // 
            this.bttnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnOK.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnOK.FlatAppearance.BorderSize = 0;
            this.bttnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bttnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.bttnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnOK.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bttnOK.Location = new System.Drawing.Point(0, 92);
            this.bttnOK.Margin = new System.Windows.Forms.Padding(1);
            this.bttnOK.Name = "bttnOK";
            this.bttnOK.Size = new System.Drawing.Size(317, 31);
            this.bttnOK.TabIndex = 12;
            this.bttnOK.Text = "OK";
            this.bttnOK.UseVisualStyleBackColor = true;
            this.bttnOK.Click += new System.EventHandler(this.bttnOK_Click);
            this.bttnOK.MouseEnter += new System.EventHandler(this.bttnOK_MouseEnter);
            this.bttnOK.MouseLeave += new System.EventHandler(this.bttnOK_MouseLeave);
            // 
            // pbIcon
            // 
            this.pbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbIcon.Image")));
            this.pbIcon.Location = new System.Drawing.Point(12, 41);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(42, 42);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 13;
            this.pbIcon.TabStop = false;
            // 
            // ErrorAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(317, 134);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTopColor);
            this.Controls.Add(this.labelTxt);
            this.Controls.Add(this.bttnOK);
            this.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ErrorAuthorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ErrorAuthorization";
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTopColor;
        private System.Windows.Forms.Label labelTxt;
        private System.Windows.Forms.Button bttnOK;
        private System.Windows.Forms.PictureBox pbIcon;
    }
}