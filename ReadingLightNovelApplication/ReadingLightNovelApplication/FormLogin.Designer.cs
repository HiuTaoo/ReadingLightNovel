﻿namespace ReadingLightNovelApplication
{
    partial class FormLogin
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnYeuThich = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongBao = new Guna.UI2.WinForms.Guna2Button();
            this.panelLogout = new System.Windows.Forms.Panel();
            this.btnAvt = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAvt)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnYeuThich);
            this.guna2Panel1.Controls.Add(this.btnThongBao);
            this.guna2Panel1.Controls.Add(this.panelLogout);
            this.guna2Panel1.Controls.Add(this.btnAvt);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(210, 38);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnYeuThich
            // 
            this.btnYeuThich.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnYeuThich.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnYeuThich.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnYeuThich.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYeuThich.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnYeuThich.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnYeuThich.FillColor = System.Drawing.Color.Transparent;
            this.btnYeuThich.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYeuThich.ForeColor = System.Drawing.Color.White;
            this.btnYeuThich.Location = new System.Drawing.Point(1, 0);
            this.btnYeuThich.Name = "btnYeuThich";
            this.btnYeuThich.Size = new System.Drawing.Size(74, 38);
            this.btnYeuThich.TabIndex = 11;
            this.btnYeuThich.Click += new System.EventHandler(this.btnYeuThich_Click);
            // 
            // btnThongBao
            // 
            this.btnThongBao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThongBao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongBao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongBao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongBao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongBao.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThongBao.FillColor = System.Drawing.Color.Transparent;
            this.btnThongBao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThongBao.ForeColor = System.Drawing.Color.White;
            this.btnThongBao.Location = new System.Drawing.Point(75, 0);
            this.btnThongBao.Name = "btnThongBao";
            this.btnThongBao.Size = new System.Drawing.Size(74, 38);
            this.btnThongBao.TabIndex = 10;
            // 
            // panelLogout
            // 
            this.panelLogout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLogout.Location = new System.Drawing.Point(149, 0);
            this.panelLogout.Name = "panelLogout";
            this.panelLogout.Size = new System.Drawing.Size(16, 38);
            this.panelLogout.TabIndex = 9;
            // 
            // btnAvt
            // 
            this.btnAvt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAvt.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAvt.ImageRotate = 0F;
            this.btnAvt.Location = new System.Drawing.Point(165, 0);
            this.btnAvt.Name = "btnAvt";
            this.btnAvt.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAvt.Size = new System.Drawing.Size(45, 38);
            this.btnAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAvt.TabIndex = 0;
            this.btnAvt.TabStop = false;
            this.btnAvt.Click += new System.EventHandler(this.btnAvt_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 38);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAvt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnYeuThich;
        private Guna.UI2.WinForms.Guna2Button btnThongBao;
        private System.Windows.Forms.Panel panelLogout;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnAvt;
    }
}