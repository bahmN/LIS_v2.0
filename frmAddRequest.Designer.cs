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
            this.label1 = new System.Windows.Forms.Label();
            this.cbNameAnalysis = new System.Windows.Forms.ComboBox();
            this.datePickerRequest = new System.Windows.Forms.DateTimePicker();
            this.cbResult = new System.Windows.Forms.ComboBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeResult = new System.Windows.Forms.DateTimePicker();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.bttnOK = new System.Windows.Forms.Button();
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
            this.panelTop.Size = new System.Drawing.Size(421, 44);
            this.panelTop.TabIndex = 3;
            // 
            // labelPanelReq
            // 
            this.labelPanelReq.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPanelReq.AutoSize = true;
            this.labelPanelReq.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPanelReq.Location = new System.Drawing.Point(157, 18);
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
            this.bttnClose.Location = new System.Drawing.Point(393, 15);
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
            this.panelTopColor.Size = new System.Drawing.Size(421, 12);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Дата заявки";
            // 
            // cbNameAnalysis
            // 
            this.cbNameAnalysis.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cbNameAnalysis.FormattingEnabled = true;
            this.cbNameAnalysis.Location = new System.Drawing.Point(219, 56);
            this.cbNameAnalysis.Name = "cbNameAnalysis";
            this.cbNameAnalysis.Size = new System.Drawing.Size(185, 25);
            this.cbNameAnalysis.TabIndex = 16;
            // 
            // datePickerRequest
            // 
            this.datePickerRequest.Enabled = false;
            this.datePickerRequest.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.datePickerRequest.Location = new System.Drawing.Point(218, 87);
            this.datePickerRequest.Name = "datePickerRequest";
            this.datePickerRequest.Size = new System.Drawing.Size(185, 22);
            this.datePickerRequest.TabIndex = 17;
            this.datePickerRequest.Value = new System.DateTime(2020, 11, 1, 0, 0, 0, 0);
            // 
            // cbResult
            // 
            this.cbResult.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cbResult.FormattingEnabled = true;
            this.cbResult.Items.AddRange(new object[] {
            "Положительный",
            "Отрицательный"});
            this.cbResult.Location = new System.Drawing.Point(218, 115);
            this.cbResult.Name = "cbResult";
            this.cbResult.Size = new System.Drawing.Size(185, 25);
            this.cbResult.TabIndex = 16;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Дата результата";
            // 
            // dateTimeResult
            // 
            this.dateTimeResult.Enabled = false;
            this.dateTimeResult.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.dateTimeResult.Location = new System.Drawing.Point(218, 146);
            this.dateTimeResult.Name = "dateTimeResult";
            this.dateTimeResult.Size = new System.Drawing.Size(185, 22);
            this.dateTimeResult.TabIndex = 17;
            // 
            // bttnCancel
            // 
            this.bttnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttnCancel.FlatAppearance.BorderSize = 0;
            this.bttnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bttnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(25)))), ((int)(((byte)(47)))));
            this.bttnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnCancel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bttnCancel.Location = new System.Drawing.Point(219, 184);
            this.bttnCancel.Margin = new System.Windows.Forms.Padding(1);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(202, 29);
            this.bttnCancel.TabIndex = 18;
            this.bttnCancel.Text = "Отмена";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            this.bttnCancel.MouseEnter += new System.EventHandler(this.bttnCancel_MouseEnter);
            this.bttnCancel.MouseLeave += new System.EventHandler(this.bttnCancel_MouseLeave);
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
            this.bttnOK.Location = new System.Drawing.Point(0, 184);
            this.bttnOK.Margin = new System.Windows.Forms.Padding(1);
            this.bttnOK.Name = "bttnOK";
            this.bttnOK.Size = new System.Drawing.Size(204, 29);
            this.bttnOK.TabIndex = 19;
            this.bttnOK.Text = "bttn";
            this.bttnOK.UseVisualStyleBackColor = true;
            this.bttnOK.Click += new System.EventHandler(this.bttnOK_Click);
            this.bttnOK.MouseEnter += new System.EventHandler(this.bttnOK_MouseEnter);
            this.bttnOK.MouseLeave += new System.EventHandler(this.bttnOK_MouseLeave);
            // 
            // frmAddRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(421, 227);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnOK);
            this.Controls.Add(this.dateTimeResult);
            this.Controls.Add(this.datePickerRequest);
            this.Controls.Add(this.cbResult);
            this.Controls.Add(this.cbNameAnalysis);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBirthday);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddRequest";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddRequest";
            this.Load += new System.EventHandler(this.frmAddRequest_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelPanelReq;
        private System.Windows.Forms.PictureBox bttnClose;
        private System.Windows.Forms.Panel panelTopColor;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNameAnalysis;
        private System.Windows.Forms.DateTimePicker datePickerRequest;
        private System.Windows.Forms.ComboBox cbResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeResult;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Button bttnOK;
    }
}