namespace ReadingLightNovelApplication
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
            this.lbYeuThich = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbThongBao = new System.Windows.Forms.Label();
            this.btnYeuThich = new Guna.UI2.WinForms.Guna2Button();
            this.btnAvt = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAvt)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.lbYeuThich);
            this.guna2Panel1.Controls.Add(this.btnYeuThich);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Controls.Add(this.btnAvt);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(225, 38);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // lbYeuThich
            // 
            this.lbYeuThich.AutoSize = true;
            this.lbYeuThich.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbYeuThich.ForeColor = System.Drawing.Color.Brown;
            this.lbYeuThich.Location = new System.Drawing.Point(50, 7);
            this.lbYeuThich.Name = "lbYeuThich";
            this.lbYeuThich.Size = new System.Drawing.Size(0, 16);
            this.lbYeuThich.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbThongBao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(164, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(18, 38);
            this.panel1.TabIndex = 11;
            // 
            // lbThongBao
            // 
            this.lbThongBao.AutoSize = true;
            this.lbThongBao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbThongBao.ForeColor = System.Drawing.Color.Brown;
            this.lbThongBao.Location = new System.Drawing.Point(-14, 11);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(0, 16);
            this.lbThongBao.TabIndex = 10;
            // 
            // btnYeuThich
            // 
            this.btnYeuThich.BackColor = System.Drawing.Color.Transparent;
            this.btnYeuThich.BackgroundImage = global::ReadingLightNovelApplication.Properties.Resources.png_transparent_heart_computer_icons_shape_blackheart_love_black_share_icon;
            this.btnYeuThich.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYeuThich.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnYeuThich.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnYeuThich.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYeuThich.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnYeuThich.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnYeuThich.FillColor = System.Drawing.Color.Transparent;
            this.btnYeuThich.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYeuThich.ForeColor = System.Drawing.Color.White;
            this.btnYeuThich.Location = new System.Drawing.Point(90, 0);
            this.btnYeuThich.Name = "btnYeuThich";
            this.btnYeuThich.Size = new System.Drawing.Size(74, 38);
            this.btnYeuThich.TabIndex = 13;
            this.btnYeuThich.Click += new System.EventHandler(this.btnYeuThich_Click);
            // 
            // btnAvt
            // 
            this.btnAvt.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAvt.ImageRotate = 0F;
            this.btnAvt.Location = new System.Drawing.Point(182, 0);
            this.btnAvt.Name = "btnAvt";
            this.btnAvt.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAvt.Size = new System.Drawing.Size(43, 38);
            this.btnAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAvt.TabIndex = 0;
            this.btnAvt.TabStop = false;
            this.btnAvt.Click += new System.EventHandler(this.btnAvt_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(225, 38);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAvt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lbYeuThich;
        private Guna.UI2.WinForms.Guna2Button btnYeuThich;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbThongBao;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnAvt;
    }
}