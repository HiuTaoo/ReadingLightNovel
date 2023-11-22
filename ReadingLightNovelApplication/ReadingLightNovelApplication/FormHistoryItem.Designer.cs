namespace ReadingLightNovelApplication
{
    partial class FormHistoryItem
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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.lblTenTruyen = new System.Windows.Forms.Label();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblVol = new System.Windows.Forms.Label();
            this.lblChapter = new System.Windows.Forms.Label();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 17);
            this.panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Panel2.Controls.Add(this.pbImg);
            this.guna2Panel2.Controls.Add(this.lblLoai);
            this.guna2Panel2.Controls.Add(this.lblTenTruyen);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 17);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(974, 69);
            this.guna2Panel2.TabIndex = 5;
            // 
            // pbImg
            // 
            this.pbImg.Location = new System.Drawing.Point(12, 3);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(58, 61);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg.TabIndex = 3;
            this.pbImg.TabStop = false;
            this.pbImg.Click += new System.EventHandler(this.pbImg_Click);
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoai.Location = new System.Drawing.Point(90, 41);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(38, 15);
            this.lblLoai.TabIndex = 2;
            this.lblLoai.Text = "label2";
            // 
            // lblTenTruyen
            // 
            this.lblTenTruyen.AutoSize = true;
            this.lblTenTruyen.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTruyen.Location = new System.Drawing.Point(89, 12);
            this.lblTenTruyen.Name = "lblTenTruyen";
            this.lblTenTruyen.Size = new System.Drawing.Size(51, 20);
            this.lblTenTruyen.TabIndex = 1;
            this.lblTenTruyen.Text = "label1";
            this.lblTenTruyen.Click += new System.EventHandler(this.lblTenTruyen_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(161)))), ((int)(((byte)(137)))));
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(911, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(63, 69);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "X";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Panel4.Controls.Add(this.lblVol);
            this.guna2Panel4.Controls.Add(this.lblChapter);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel4.Location = new System.Drawing.Point(521, 17);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(390, 69);
            this.guna2Panel4.TabIndex = 8;
            // 
            // lblVol
            // 
            this.lblVol.AutoSize = true;
            this.lblVol.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVol.Location = new System.Drawing.Point(27, 41);
            this.lblVol.Name = "lblVol";
            this.lblVol.Size = new System.Drawing.Size(38, 15);
            this.lblVol.TabIndex = 1;
            this.lblVol.Text = "label4";
            // 
            // lblChapter
            // 
            this.lblChapter.AutoSize = true;
            this.lblChapter.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChapter.Location = new System.Drawing.Point(26, 12);
            this.lblChapter.Name = "lblChapter";
            this.lblChapter.Size = new System.Drawing.Size(51, 20);
            this.lblChapter.TabIndex = 0;
            this.lblChapter.Text = "label3";
            // 
            // FormHistoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 86);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHistoryItem";
            this.Text = "FormHistoryItem";
            this.Load += new System.EventHandler(this.FormHistoryItem_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.Label lblTenTruyen;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Label lblVol;
        private System.Windows.Forms.Label lblChapter;
    }
}