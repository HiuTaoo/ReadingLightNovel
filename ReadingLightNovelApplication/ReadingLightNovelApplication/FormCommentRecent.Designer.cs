namespace ReadingLightNovelApplication
{
	partial class FormCommentRecent
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
            this.panelBinhLuan = new Guna.UI2.WinForms.Guna2Panel();
            this.btnComment = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel133 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnTenTruyen = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelBinhLuan.SuspendLayout();
            this.guna2Panel133.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(241, 12);
            this.guna2Panel1.TabIndex = 0;
            // 
            // panelBinhLuan
            // 
            this.panelBinhLuan.BackColor = System.Drawing.Color.Transparent;
            this.panelBinhLuan.Controls.Add(this.btnComment);
            this.panelBinhLuan.Controls.Add(this.guna2Panel133);
            this.panelBinhLuan.Controls.Add(this.btnTenTruyen);
            this.panelBinhLuan.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBinhLuan.Location = new System.Drawing.Point(0, 12);
            this.panelBinhLuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBinhLuan.Name = "panelBinhLuan";
            this.panelBinhLuan.Size = new System.Drawing.Size(241, 114);
            this.panelBinhLuan.TabIndex = 2;
            // 
            // btnComment
            // 
            this.btnComment.BackColor = System.Drawing.Color.Transparent;
            this.btnComment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnComment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnComment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnComment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnComment.FillColor = System.Drawing.Color.Transparent;
            this.btnComment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnComment.ForeColor = System.Drawing.Color.Black;
            this.btnComment.Location = new System.Drawing.Point(0, 21);
            this.btnComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(241, 64);
            this.btnComment.TabIndex = 4;
            this.btnComment.Text = "guna2Button17";
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            this.btnComment.MouseHover += new System.EventHandler(this.changeForeColorMouseHover);
            // 
            // guna2Panel133
            // 
            this.guna2Panel133.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel133.Controls.Add(this.btnUser);
            this.guna2Panel133.Controls.Add(this.btnAvatar);
            this.guna2Panel133.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel133.Location = new System.Drawing.Point(0, 85);
            this.guna2Panel133.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel133.Name = "guna2Panel133";
            this.guna2Panel133.Size = new System.Drawing.Size(241, 29);
            this.guna2Panel133.TabIndex = 3;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUser.FillColor = System.Drawing.Color.Transparent;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUser.ForeColor = System.Drawing.Color.Black;
            this.btnUser.Location = new System.Drawing.Point(33, 0);
            this.btnUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(100, 29);
            this.btnUser.TabIndex = 2;
            this.btnUser.Text = "guna2Button21";
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnAvatar
            // 
            this.btnAvatar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAvatar.FillColor = System.Drawing.Color.Transparent;
            this.btnAvatar.ImageRotate = 0F;
            this.btnAvatar.Location = new System.Drawing.Point(0, 0);
            this.btnAvatar.Name = "btnAvatar";
            this.btnAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAvatar.Size = new System.Drawing.Size(33, 29);
            this.btnAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAvatar.TabIndex = 0;
            this.btnAvatar.TabStop = false;
            // 
            // btnTenTruyen
            // 
            this.btnTenTruyen.BackColor = System.Drawing.Color.Transparent;
            this.btnTenTruyen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTenTruyen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTenTruyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTenTruyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTenTruyen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTenTruyen.FillColor = System.Drawing.Color.Transparent;
            this.btnTenTruyen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTenTruyen.ForeColor = System.Drawing.Color.Black;
            this.btnTenTruyen.Location = new System.Drawing.Point(0, 0);
            this.btnTenTruyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTenTruyen.Name = "btnTenTruyen";
            this.btnTenTruyen.Size = new System.Drawing.Size(241, 21);
            this.btnTenTruyen.TabIndex = 1;
            this.btnTenTruyen.Text = "Tên truyện";
            this.btnTenTruyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTenTruyen.Click += new System.EventHandler(this.btnTenTruyen_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 126);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(241, 1);
            this.guna2Panel2.TabIndex = 3;
            // 
            // FormCommentRecent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(241, 130);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.panelBinhLuan);
            this.Controls.Add(this.guna2Panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCommentRecent";
            this.Text = "FormCommentRecent";
            this.Load += new System.EventHandler(this.FormCommentRecent_Load);
            this.panelBinhLuan.ResumeLayout(false);
            this.guna2Panel133.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAvatar)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2Panel panelBinhLuan;
		private Guna.UI2.WinForms.Guna2Button btnComment;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel133;
		private Guna.UI2.WinForms.Guna2Button btnTenTruyen;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnUser;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnAvatar;
    }
}