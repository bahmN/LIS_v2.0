namespace LIS
{
    partial class frmAddClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddClient));
            this.bttnClose = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelPanelAdm = new System.Windows.Forms.Label();
            this.panelTopColor = new System.Windows.Forms.Panel();
            this.labelFN = new System.Windows.Forms.Label();
            this.tbFN = new System.Windows.Forms.TextBox();
            this.bttnOK = new System.Windows.Forms.Button();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.tbPassport = new System.Windows.Forms.MaskedTextBox();
            this.datePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.labelPassport = new System.Windows.Forms.Label();
            this.labelSNILS = new System.Windows.Forms.Label();
            this.tbSNILS = new System.Windows.Forms.MaskedTextBox();
            this.labelNumbPhone = new System.Windows.Forms.Label();
            this.tbNumbPhone = new System.Windows.Forms.MaskedTextBox();
            this.labelAdress = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.tbEMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bttnClose)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnClose
            // 
            this.bttnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bttnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnClose.Image = ((System.Drawing.Image)(resources.GetObject("bttnClose.Image")));
            this.bttnClose.Location = new System.Drawing.Point(418, 15);
            this.bttnClose.Name = "bttnClose";
            this.bttnClose.Size = new System.Drawing.Size(25, 25);
            this.bttnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bttnClose.TabIndex = 1;
            this.bttnClose.TabStop = false;
            this.bttnClose.Click += new System.EventHandler(this.bttnClose_Click);
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
            this.panelTop.Size = new System.Drawing.Size(446, 44);
            this.panelTop.TabIndex = 2;
            // 
            // labelPanelAdm
            // 
            this.labelPanelAdm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPanelAdm.AutoSize = true;
            this.labelPanelAdm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPanelAdm.Location = new System.Drawing.Point(149, 18);
            this.labelPanelAdm.Name = "labelPanelAdm";
            this.labelPanelAdm.Size = new System.Drawing.Size(149, 18);
            this.labelPanelAdm.TabIndex = 1;
            this.labelPanelAdm.Text = "Добавить клиента";
            // 
            // panelTopColor
            // 
            this.panelTopColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.panelTopColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopColor.Location = new System.Drawing.Point(0, 0);
            this.panelTopColor.Name = "panelTopColor";
            this.panelTopColor.Size = new System.Drawing.Size(446, 12);
            this.panelTopColor.TabIndex = 1;
            // 
            // labelFN
            // 
            this.labelFN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFN.AutoSize = true;
            this.labelFN.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelFN.Location = new System.Drawing.Point(12, 59);
            this.labelFN.Name = "labelFN";
            this.labelFN.Size = new System.Drawing.Size(103, 19);
            this.labelFN.TabIndex = 8;
            this.labelFN.Text = "ФИО клиента";
            // 
            // tbFN
            // 
            this.tbFN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbFN.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbFN.Location = new System.Drawing.Point(210, 58);
            this.tbFN.Name = "tbFN";
            this.tbFN.Size = new System.Drawing.Size(224, 22);
            this.tbFN.TabIndex = 6;
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
            this.bttnOK.Location = new System.Drawing.Point(16, 264);
            this.bttnOK.Margin = new System.Windows.Forms.Padding(1);
            this.bttnOK.Name = "bttnOK";
            this.bttnOK.Size = new System.Drawing.Size(200, 29);
            this.bttnOK.TabIndex = 7;
            this.bttnOK.Text = "Добавить";
            this.bttnOK.UseVisualStyleBackColor = true;
            this.bttnOK.MouseEnter += new System.EventHandler(this.bttnOK_MouseEnter);
            this.bttnOK.MouseLeave += new System.EventHandler(this.bttnOK_MouseLeave);
            // 
            // labelBirthday
            // 
            this.labelBirthday.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelBirthday.Location = new System.Drawing.Point(12, 86);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(118, 19);
            this.labelBirthday.TabIndex = 8;
            this.labelBirthday.Text = "Дата рождения";
            // 
            // tbPassport
            // 
            this.tbPassport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbPassport.Location = new System.Drawing.Point(210, 114);
            this.tbPassport.Mask = "0000 000000";
            this.tbPassport.Name = "tbPassport";
            this.tbPassport.Size = new System.Drawing.Size(224, 22);
            this.tbPassport.TabIndex = 9;
            this.tbPassport.ValidatingType = typeof(System.DateTime);
            // 
            // datePickerBirthday
            // 
            this.datePickerBirthday.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datePickerBirthday.Location = new System.Drawing.Point(210, 86);
            this.datePickerBirthday.Name = "datePickerBirthday";
            this.datePickerBirthday.Size = new System.Drawing.Size(224, 22);
            this.datePickerBirthday.TabIndex = 10;
            // 
            // labelPassport
            // 
            this.labelPassport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPassport.AutoSize = true;
            this.labelPassport.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelPassport.Location = new System.Drawing.Point(12, 116);
            this.labelPassport.Name = "labelPassport";
            this.labelPassport.Size = new System.Drawing.Size(192, 19);
            this.labelPassport.TabIndex = 8;
            this.labelPassport.Text = "Номер и серия паспорта";
            // 
            // labelSNILS
            // 
            this.labelSNILS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSNILS.AutoSize = true;
            this.labelSNILS.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelSNILS.Location = new System.Drawing.Point(12, 144);
            this.labelSNILS.Name = "labelSNILS";
            this.labelSNILS.Size = new System.Drawing.Size(114, 19);
            this.labelSNILS.TabIndex = 8;
            this.labelSNILS.Text = "Номер СНИЛС";
            // 
            // tbSNILS
            // 
            this.tbSNILS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSNILS.Location = new System.Drawing.Point(210, 142);
            this.tbSNILS.Mask = "000-000-000-00";
            this.tbSNILS.Name = "tbSNILS";
            this.tbSNILS.Size = new System.Drawing.Size(224, 22);
            this.tbSNILS.TabIndex = 9;
            this.tbSNILS.ValidatingType = typeof(System.DateTime);
            // 
            // labelNumbPhone
            // 
            this.labelNumbPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNumbPhone.AutoSize = true;
            this.labelNumbPhone.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelNumbPhone.Location = new System.Drawing.Point(12, 172);
            this.labelNumbPhone.Name = "labelNumbPhone";
            this.labelNumbPhone.Size = new System.Drawing.Size(136, 19);
            this.labelNumbPhone.TabIndex = 8;
            this.labelNumbPhone.Text = "Номер телефона";
            // 
            // tbNumbPhone
            // 
            this.tbNumbPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNumbPhone.Location = new System.Drawing.Point(210, 170);
            this.tbNumbPhone.Mask = "8(000)000-00-00";
            this.tbNumbPhone.Name = "tbNumbPhone";
            this.tbNumbPhone.Size = new System.Drawing.Size(224, 22);
            this.tbNumbPhone.TabIndex = 9;
            this.tbNumbPhone.ValidatingType = typeof(System.DateTime);
            // 
            // labelAdress
            // 
            this.labelAdress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAdress.AutoSize = true;
            this.labelAdress.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelAdress.Location = new System.Drawing.Point(12, 202);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(145, 19);
            this.labelAdress.TabIndex = 8;
            this.labelAdress.Text = "Адрес проживания";
            // 
            // tbAdress
            // 
            this.tbAdress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAdress.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbAdress.Location = new System.Drawing.Point(210, 200);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(224, 22);
            this.tbAdress.TabIndex = 6;
            // 
            // tbEMail
            // 
            this.tbEMail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbEMail.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbEMail.Location = new System.Drawing.Point(210, 228);
            this.tbEMail.Name = "tbEMail";
            this.tbEMail.Size = new System.Drawing.Size(224, 22);
            this.tbEMail.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(12, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "E-Mail";
            // 
            // bttnCancel
            // 
            this.bttnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnCancel.FlatAppearance.BorderSize = 0;
            this.bttnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bttnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCancel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bttnCancel.Location = new System.Drawing.Point(234, 264);
            this.bttnCancel.Margin = new System.Windows.Forms.Padding(1);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(200, 29);
            this.bttnCancel.TabIndex = 7;
            this.bttnCancel.Text = "Отмена";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            this.bttnCancel.MouseEnter += new System.EventHandler(this.bttnCancel_MouseEnter);
            this.bttnCancel.MouseLeave += new System.EventHandler(this.bttnCancel_MouseLeave);
            // 
            // frmAddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 303);
            this.Controls.Add(this.datePickerBirthday);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.tbNumbPhone);
            this.Controls.Add(this.labelNumbPhone);
            this.Controls.Add(this.tbSNILS);
            this.Controls.Add(this.labelSNILS);
            this.Controls.Add(this.tbPassport);
            this.Controls.Add(this.labelPassport);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelFN);
            this.Controls.Add(this.tbEMail);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.tbFN);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnOK);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddClient";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmAddClient";
            ((System.ComponentModel.ISupportInitialize)(this.bttnClose)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bttnClose;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelPanelAdm;
        private System.Windows.Forms.Panel panelTopColor;
        private System.Windows.Forms.Label labelFN;
        private System.Windows.Forms.TextBox tbFN;
        private System.Windows.Forms.Button bttnOK;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.MaskedTextBox tbPassport;
        private System.Windows.Forms.DateTimePicker datePickerBirthday;
        private System.Windows.Forms.Label labelPassport;
        private System.Windows.Forms.Label labelSNILS;
        private System.Windows.Forms.MaskedTextBox tbSNILS;
        private System.Windows.Forms.Label labelNumbPhone;
        private System.Windows.Forms.MaskedTextBox tbNumbPhone;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.TextBox tbEMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnCancel;
    }
}