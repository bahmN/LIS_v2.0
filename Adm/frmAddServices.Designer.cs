namespace LIS.Adm
{
    partial class frmAddServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddServices));
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelPanelAdm = new System.Windows.Forms.Label();
            this.bttnClose = new System.Windows.Forms.PictureBox();
            this.panelTopColor = new System.Windows.Forms.Panel();
            this.labeName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.tbTerm = new System.Windows.Forms.TextBox();
            this.labelTerm = new System.Windows.Forms.Label();
            this.tbRecommendation = new System.Windows.Forms.TextBox();
            this.labelRecommendation = new System.Windows.Forms.Label();
            this.bttnOK = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnClose)).BeginInit();
            this.SuspendLayout();
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
            this.labelPanelAdm.Location = new System.Drawing.Point(127, 18);
            this.labelPanelAdm.Name = "labelPanelAdm";
            this.labelPanelAdm.Size = new System.Drawing.Size(138, 18);
            this.labelPanelAdm.TabIndex = 1;
            this.labelPanelAdm.Text = "Добавить услуги";
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
            // labeName
            // 
            this.labeName.AutoSize = true;
            this.labeName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labeName.Location = new System.Drawing.Point(12, 52);
            this.labeName.Name = "labeName";
            this.labeName.Size = new System.Drawing.Size(129, 19);
            this.labeName.TabIndex = 12;
            this.labeName.Text = "Название услуги";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbName.Location = new System.Drawing.Point(147, 50);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(234, 22);
            this.tbName.TabIndex = 11;
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbPrice.Location = new System.Drawing.Point(147, 78);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(234, 22);
            this.tbPrice.TabIndex = 11;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelPrice.Location = new System.Drawing.Point(12, 80);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(46, 19);
            this.labelPrice.TabIndex = 12;
            this.labelPrice.Text = "Цена";
            // 
            // tbTerm
            // 
            this.tbTerm.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbTerm.Location = new System.Drawing.Point(147, 106);
            this.tbTerm.Name = "tbTerm";
            this.tbTerm.Size = new System.Drawing.Size(234, 22);
            this.tbTerm.TabIndex = 11;
            // 
            // labelTerm
            // 
            this.labelTerm.AutoSize = true;
            this.labelTerm.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelTerm.Location = new System.Drawing.Point(12, 108);
            this.labelTerm.Name = "labelTerm";
            this.labelTerm.Size = new System.Drawing.Size(131, 19);
            this.labelTerm.TabIndex = 12;
            this.labelTerm.Text = "Срок выполнения";
            // 
            // tbRecommendation
            // 
            this.tbRecommendation.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbRecommendation.Location = new System.Drawing.Point(147, 134);
            this.tbRecommendation.Name = "tbRecommendation";
            this.tbRecommendation.Size = new System.Drawing.Size(234, 22);
            this.tbRecommendation.TabIndex = 11;
            // 
            // labelRecommendation
            // 
            this.labelRecommendation.AutoSize = true;
            this.labelRecommendation.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.labelRecommendation.Location = new System.Drawing.Point(12, 136);
            this.labelRecommendation.Name = "labelRecommendation";
            this.labelRecommendation.Size = new System.Drawing.Size(116, 19);
            this.labelRecommendation.TabIndex = 12;
            this.labelRecommendation.Text = "Рекомендации";
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
            this.bttnOK.Location = new System.Drawing.Point(0, 162);
            this.bttnOK.Name = "bttnOK";
            this.bttnOK.Size = new System.Drawing.Size(393, 26);
            this.bttnOK.TabIndex = 14;
            this.bttnOK.Text = "bttn";
            this.bttnOK.UseVisualStyleBackColor = true;
            this.bttnOK.Click += new System.EventHandler(this.bttnOK_Click);
            this.bttnOK.MouseEnter += new System.EventHandler(this.bttnOK_MouseEnter);
            this.bttnOK.MouseLeave += new System.EventHandler(this.bttnOK_MouseLeave);
            // 
            // frmAddServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(393, 202);
            this.Controls.Add(this.bttnOK);
            this.Controls.Add(this.labelRecommendation);
            this.Controls.Add(this.labelTerm);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labeName);
            this.Controls.Add(this.tbRecommendation);
            this.Controls.Add(this.tbTerm);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить услуги";
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
        private System.Windows.Forms.Label labeName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelTerm;
        private System.Windows.Forms.Label labelRecommendation;
        public System.Windows.Forms.TextBox tbPrice;
        public System.Windows.Forms.TextBox tbTerm;
        public System.Windows.Forms.TextBox tbRecommendation;
        public System.Windows.Forms.TextBox tbName;
        public System.Windows.Forms.Button bttnOK;
        public System.Windows.Forms.Label labelPanelAdm;
    }
}