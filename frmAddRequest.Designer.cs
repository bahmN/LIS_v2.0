namespace LIS
{
    partial class frmAddRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddRequest));
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelPanelReq = new System.Windows.Forms.Label();
            this.bttnClose = new System.Windows.Forms.PictureBox();
            this.panelTopColor = new System.Windows.Forms.Panel();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelDateRequest = new System.Windows.Forms.Label();
            this.cbNameAnalysis = new System.Windows.Forms.ComboBox();
            this.datePickerRequest = new System.Windows.Forms.DateTimePicker();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelDateResult = new System.Windows.Forms.Label();
            this.dateTimeResult = new System.Windows.Forms.DateTimePicker();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnOK = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.labelPanelReq);
            this.panelTop.Controls.Add(this.bttnClose);
            this.panelTop.Controls.Add(this.panelTopColor);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(446, 44);
            this.panelTop.TabIndex = 3;
            // 
            // labelPanelReq
            // 
            this.labelPanelReq.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPanelReq.AutoSize = true;
            this.labelPanelReq.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPanelReq.Location = new System.Drawing.Point(200, 18);
            this.labelPanelReq.Name = "labelPanelReq";
            this.labelPanelReq.Size = new System.Drawing.Size(46, 18);
            this.labelPanelReq.TabIndex = 1;
            this.labelPanelReq.Text = "label";
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
            // panelTopColor
            // 
            this.panelTopColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.panelTopColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopColor.Location = new System.Drawing.Point(0, 0);
            this.panelTopColor.Name = "panelTopColor";
            this.panelTopColor.Size = new System.Drawing.Size(446, 12);
            this.panelTopColor.TabIndex = 1;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelBirthday.Location = new System.Drawing.Point(12, 59);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(143, 19);
            this.labelBirthday.TabIndex = 15;
            this.labelBirthday.Text = "Название анализа";
            // 
            // labelDateRequest
            // 
            this.labelDateRequest.AutoSize = true;
            this.labelDateRequest.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelDateRequest.Location = new System.Drawing.Point(12, 89);
            this.labelDateRequest.Name = "labelDateRequest";
            this.labelDateRequest.Size = new System.Drawing.Size(93, 19);
            this.labelDateRequest.TabIndex = 15;
            this.labelDateRequest.Text = "Дата заявки";
            // 
            // cbNameAnalysis
            // 
            this.cbNameAnalysis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNameAnalysis.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cbNameAnalysis.ForeColor = System.Drawing.Color.Black;
            this.cbNameAnalysis.FormattingEnabled = true;
            this.cbNameAnalysis.IntegralHeight = false;
            this.cbNameAnalysis.Location = new System.Drawing.Point(218, 56);
            this.cbNameAnalysis.Name = "cbNameAnalysis";
            this.cbNameAnalysis.Size = new System.Drawing.Size(216, 25);
            this.cbNameAnalysis.TabIndex = 16;
            // 
            // datePickerRequest
            // 
            this.datePickerRequest.Enabled = false;
            this.datePickerRequest.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.datePickerRequest.Location = new System.Drawing.Point(218, 87);
            this.datePickerRequest.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.datePickerRequest.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.datePickerRequest.Name = "datePickerRequest";
            this.datePickerRequest.Size = new System.Drawing.Size(215, 22);
            this.datePickerRequest.TabIndex = 17;
            this.datePickerRequest.Value = new System.DateTime(2020, 11, 1, 0, 0, 0, 0);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelResult.Location = new System.Drawing.Point(12, 118);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(75, 19);
            this.labelResult.TabIndex = 15;
            this.labelResult.Text = "Результат";
            // 
            // labelDateResult
            // 
            this.labelDateResult.AutoSize = true;
            this.labelDateResult.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelDateResult.Location = new System.Drawing.Point(12, 148);
            this.labelDateResult.Name = "labelDateResult";
            this.labelDateResult.Size = new System.Drawing.Size(126, 19);
            this.labelDateResult.TabIndex = 15;
            this.labelDateResult.Text = "Дата результата";
            // 
            // dateTimeResult
            // 
            this.dateTimeResult.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.dateTimeResult.Location = new System.Drawing.Point(218, 146);
            this.dateTimeResult.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dateTimeResult.Name = "dateTimeResult";
            this.dateTimeResult.Size = new System.Drawing.Size(215, 22);
            this.dateTimeResult.TabIndex = 17;
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
            this.bttnCancel.Location = new System.Drawing.Point(232, 184);
            this.bttnCancel.Margin = new System.Windows.Forms.Padding(1);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(214, 29);
            this.bttnCancel.TabIndex = 18;
            this.bttnCancel.Text = "Отмена";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            this.bttnCancel.MouseEnter += new System.EventHandler(this.bttnCancel_MouseEnter);
            this.bttnCancel.MouseLeave += new System.EventHandler(this.bttnCancel_MouseLeave);
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
            this.bttnOK.Location = new System.Drawing.Point(0, 184);
            this.bttnOK.Margin = new System.Windows.Forms.Padding(1);
            this.bttnOK.Name = "bttnOK";
            this.bttnOK.Size = new System.Drawing.Size(217, 29);
            this.bttnOK.TabIndex = 19;
            this.bttnOK.Text = "bttn";
            this.bttnOK.UseVisualStyleBackColor = true;
            this.bttnOK.Click += new System.EventHandler(this.bttnOK_Click);
            this.bttnOK.MouseEnter += new System.EventHandler(this.bttnOK_MouseEnter);
            this.bttnOK.MouseLeave += new System.EventHandler(this.bttnOK_MouseLeave);
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbResult.Location = new System.Drawing.Point(218, 116);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(216, 22);
            this.tbResult.TabIndex = 20;
            // 
            // frmAddRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 227);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnOK);
            this.Controls.Add(this.dateTimeResult);
            this.Controls.Add(this.datePickerRequest);
            this.Controls.Add(this.cbNameAnalysis);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.labelDateResult);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelDateRequest);
            this.Controls.Add(this.labelBirthday);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddRequest";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить заявку";
            this.Load += new System.EventHandler(this.frmAddRequest_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox bttnClose;
        private System.Windows.Forms.Panel panelTopColor;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelDateRequest;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelDateResult;
        private System.Windows.Forms.Button bttnCancel;
        public System.Windows.Forms.Button bttnOK;
        public System.Windows.Forms.Label labelPanelReq;
        public System.Windows.Forms.DateTimePicker datePickerRequest;
        public System.Windows.Forms.ComboBox cbNameAnalysis;
        public System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.DateTimePicker dateTimeResult;
    }
}