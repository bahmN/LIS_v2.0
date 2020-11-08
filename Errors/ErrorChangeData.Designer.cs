namespace LIS.Errors
{
    partial class ErrorChangeData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorChangeData));
            this.panelTopColor = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelPanelAdm = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelTxt = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.bttnOK = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopColor
            // 
            this.panelTopColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.panelTopColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopColor.Location = new System.Drawing.Point(0, 0);
            this.panelTopColor.Name = "panelTopColor";
            this.panelTopColor.Size = new System.Drawing.Size(294, 12);
            this.panelTopColor.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.labelPanelAdm);
            this.panelTop.Controls.Add(this.labelHeader);
            this.panelTop.Controls.Add(this.panelTopColor);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(294, 44);
            this.panelTop.TabIndex = 2;
            // 
            // labelPanelAdm
            // 
            this.labelPanelAdm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPanelAdm.AutoSize = true;
            this.labelPanelAdm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPanelAdm.Location = new System.Drawing.Point(-393, 18);
            this.labelPanelAdm.Name = "labelPanelAdm";
            this.labelPanelAdm.Size = new System.Drawing.Size(202, 18);
            this.labelPanelAdm.TabIndex = 1;
            this.labelPanelAdm.Text = "Панель администратора";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.labelHeader.Location = new System.Drawing.Point(80, 18);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(134, 18);
            this.labelHeader.TabIndex = 3;
            this.labelHeader.Text = "Ошибка данных";
            // 
            // labelTxt
            // 
            this.labelTxt.AutoSize = true;
            this.labelTxt.Location = new System.Drawing.Point(67, 56);
            this.labelTxt.Name = "labelTxt";
            this.labelTxt.Size = new System.Drawing.Size(206, 51);
            this.labelTxt.TabIndex = 3;
            this.labelTxt.Text = "Пожалуйста, убедитесь, что вы\r\nвыбрали информацию, которую\r\nтребуется изменить.";
            // 
            // pbIcon
            // 
            this.pbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbIcon.Image")));
            this.pbIcon.Location = new System.Drawing.Point(12, 56);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(49, 50);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 4;
            this.pbIcon.TabStop = false;
            // 
            // bttnOK
            // 
            this.bttnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bttnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnOK.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnOK.FlatAppearance.BorderSize = 0;
            this.bttnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bttnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.bttnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnOK.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bttnOK.Location = new System.Drawing.Point(0, 112);
            this.bttnOK.Margin = new System.Windows.Forms.Padding(1);
            this.bttnOK.Name = "bttnOK";
            this.bttnOK.Size = new System.Drawing.Size(294, 29);
            this.bttnOK.TabIndex = 5;
            this.bttnOK.Text = "OK";
            this.bttnOK.UseVisualStyleBackColor = true;
            this.bttnOK.Click += new System.EventHandler(this.bttnOK_Click);
            this.bttnOK.MouseEnter += new System.EventHandler(this.bttnOK_MouseEnter);
            this.bttnOK.MouseLeave += new System.EventHandler(this.bttnOK_MouseLeave);
            // 
            // ErrorChangeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(294, 151);
            this.Controls.Add(this.bttnOK);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.labelTxt);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ErrorChangeData";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ErrorConnection";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTopColor;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelPanelAdm;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelTxt;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Button bttnOK;
    }
}