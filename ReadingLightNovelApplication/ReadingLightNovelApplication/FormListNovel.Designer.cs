namespace ReadingLightNovelApplication
{
    partial class FormListNovel
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
            if (disposing && (components != null))
            {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenTruyen = new System.Windows.Forms.Label();
            this.btnLoaiTruyen = new Guna.UI2.WinForms.Guna2Button();
            this.panelImg = new Guna.UI2.WinForms.Guna2Panel();
            this.pbImg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 22);
            this.panel1.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.panelInfo);
            this.guna2Panel1.Controls.Add(this.panelImg);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 22);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1160, 131);
            this.guna2Panel1.TabIndex = 1;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.lblLastUpdate);
            this.panelInfo.Controls.Add(this.lblStatus);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Controls.Add(this.lblTenTruyen);
            this.panelInfo.Controls.Add(this.btnLoaiTruyen);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(130, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1030, 131);
            this.panelInfo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lần cuối:";
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.AutoSize = true;
            this.lblLastUpdate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastUpdate.Location = new System.Drawing.Point(115, 102);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(61, 20);
            this.lblLastUpdate.TabIndex = 2;
            this.lblLastUpdate.Text = "0 Ngày";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(115, 78);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(81, 20);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Tiến hành";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tình trạng:";
            // 
            // lblTenTruyen
            // 
            this.lblTenTruyen.AutoSize = true;
            this.lblTenTruyen.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTruyen.Location = new System.Drawing.Point(13, 46);
            this.lblTenTruyen.MaximumSize = new System.Drawing.Size(1000, 25);
            this.lblTenTruyen.Name = "lblTenTruyen";
            this.lblTenTruyen.Size = new System.Drawing.Size(1000, 25);
            this.lblTenTruyen.TabIndex = 1;
            this.lblTenTruyen.Text = "Netoge no Yome ga Ninki Idol datta ken ~Cool-kei no kanojo wa genjitsu demo yome " +
    "no tsumori de iru~";
            this.lblTenTruyen.Click += new System.EventHandler(this.lblTenTruyen_Click);
            // 
            // btnLoaiTruyen
            // 
            this.btnLoaiTruyen.BorderRadius = 5;
            this.btnLoaiTruyen.DefaultAutoSize = true;
            this.btnLoaiTruyen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoaiTruyen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoaiTruyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoaiTruyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoaiTruyen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(161)))), ((int)(((byte)(137)))));
            this.btnLoaiTruyen.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiTruyen.ForeColor = System.Drawing.Color.White;
            this.btnLoaiTruyen.Location = new System.Drawing.Point(6, 6);
            this.btnLoaiTruyen.Name = "btnLoaiTruyen";
            this.btnLoaiTruyen.Size = new System.Drawing.Size(75, 28);
            this.btnLoaiTruyen.TabIndex = 0;
            this.btnLoaiTruyen.Text = "Truyện";
            // 
            // panelImg
            // 
            this.panelImg.Controls.Add(this.pbImg);
            this.panelImg.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelImg.Location = new System.Drawing.Point(0, 0);
            this.panelImg.Name = "panelImg";
            this.panelImg.Size = new System.Drawing.Size(130, 131);
            this.panelImg.TabIndex = 2;
            // 
            // pbImg
            // 
            this.pbImg.ImageRotate = 0F;
            this.pbImg.Location = new System.Drawing.Point(9, 5);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(111, 122);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg.TabIndex = 0;
            this.pbImg.TabStop = false;
            this.pbImg.Click += new System.EventHandler(this.pbImg_Click);
            // 
            // FormListNovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 153);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListNovel";
            this.Text = "FormListNovel";
            this.Load += new System.EventHandler(this.FormListNovel_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panelInfo;
        private Guna.UI2.WinForms.Guna2Button btnLoaiTruyen;
        private Guna.UI2.WinForms.Guna2Panel panelImg;
        private Guna.UI2.WinForms.Guna2PictureBox pbImg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLastUpdate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenTruyen;
    }
}