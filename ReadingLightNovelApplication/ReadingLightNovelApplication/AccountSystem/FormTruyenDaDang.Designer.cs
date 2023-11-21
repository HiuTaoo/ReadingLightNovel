namespace ReadingLightNovelApplication.AccountSystem
{
	partial class FormTruyenDaDang
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
			this.panelSeries = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.lblTenTruyen = new System.Windows.Forms.Label();
			this.lblNguoiDang = new System.Windows.Forms.Label();
			this.lblNhomDich = new System.Windows.Forms.Label();
			this.lblQuanly = new System.Windows.Forms.Label();
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
			this.panelSeries.SuspendLayout();
			this.guna2GroupBox1.SuspendLayout();
			this.guna2Panel1.SuspendLayout();
			this.guna2Panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelSeries
			// 
			this.panelSeries.BackColor = System.Drawing.Color.White;
			this.panelSeries.Controls.Add(this.guna2GroupBox1);
			this.panelSeries.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelSeries.Location = new System.Drawing.Point(0, 0);
			this.panelSeries.Name = "panelSeries";
			this.panelSeries.Size = new System.Drawing.Size(1540, 726);
			this.panelSeries.TabIndex = 0;
			// 
			// guna2GroupBox1
			// 
			this.guna2GroupBox1.Controls.Add(this.guna2Panel1);
			this.guna2GroupBox1.Controls.Add(this.guna2Panel2);
			this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 60, 0, 0);
			this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2GroupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
			this.guna2GroupBox1.Name = "guna2GroupBox1";
			this.guna2GroupBox1.Size = new System.Drawing.Size(1540, 619);
			this.guna2GroupBox1.TabIndex = 0;
			this.guna2GroupBox1.Text = "Series đã đăng";
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Controls.Add(this.lblTenTruyen);
			this.guna2Panel1.Controls.Add(this.lblNguoiDang);
			this.guna2Panel1.Controls.Add(this.lblNhomDich);
			this.guna2Panel1.Controls.Add(this.lblQuanly);
			this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2Panel1.Location = new System.Drawing.Point(0, 124);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(1540, 123);
			this.guna2Panel1.TabIndex = 1;
			// 
			// lblTenTruyen
			// 
			this.lblTenTruyen.Dock = System.Windows.Forms.DockStyle.Right;
			this.lblTenTruyen.ForeColor = System.Drawing.Color.Black;
			this.lblTenTruyen.Location = new System.Drawing.Point(51, 0);
			this.lblTenTruyen.Name = "lblTenTruyen";
			this.lblTenTruyen.Size = new System.Drawing.Size(635, 123);
			this.lblTenTruyen.TabIndex = 3;
			this.lblTenTruyen.Text = "Tên truyện";
			this.lblTenTruyen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblNguoiDang
			// 
			this.lblNguoiDang.Dock = System.Windows.Forms.DockStyle.Right;
			this.lblNguoiDang.ForeColor = System.Drawing.Color.Black;
			this.lblNguoiDang.Location = new System.Drawing.Point(686, 0);
			this.lblNguoiDang.Name = "lblNguoiDang";
			this.lblNguoiDang.Size = new System.Drawing.Size(292, 123);
			this.lblNguoiDang.TabIndex = 2;
			this.lblNguoiDang.Text = "Người đăng";
			this.lblNguoiDang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNhomDich
			// 
			this.lblNhomDich.Dock = System.Windows.Forms.DockStyle.Right;
			this.lblNhomDich.ForeColor = System.Drawing.Color.Black;
			this.lblNhomDich.Location = new System.Drawing.Point(978, 0);
			this.lblNhomDich.Name = "lblNhomDich";
			this.lblNhomDich.Size = new System.Drawing.Size(324, 123);
			this.lblNhomDich.TabIndex = 1;
			this.lblNhomDich.Text = "Nhóm dịch";
			this.lblNhomDich.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblQuanly
			// 
			this.lblQuanly.BackColor = System.Drawing.Color.Transparent;
			this.lblQuanly.Dock = System.Windows.Forms.DockStyle.Right;
			this.lblQuanly.ForeColor = System.Drawing.Color.Black;
			this.lblQuanly.Location = new System.Drawing.Point(1302, 0);
			this.lblQuanly.Name = "lblQuanly";
			this.lblQuanly.Size = new System.Drawing.Size(238, 123);
			this.lblQuanly.TabIndex = 0;
			this.lblQuanly.Text = "Quản lý";
			this.lblQuanly.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// guna2Panel2
			// 
			this.guna2Panel2.BackColor = System.Drawing.Color.White;
			this.guna2Panel2.Controls.Add(this.txtTimKiem);
			this.guna2Panel2.Controls.Add(this.btnTimKiem);
			this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2Panel2.ForeColor = System.Drawing.Color.White;
			this.guna2Panel2.Location = new System.Drawing.Point(0, 60);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new System.Drawing.Size(1540, 64);
			this.guna2Panel2.TabIndex = 0;
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.BackColor = System.Drawing.Color.White;
			this.txtTimKiem.BorderColor = System.Drawing.Color.Black;
			this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTimKiem.DefaultText = "";
			this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Right;
			this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTimKiem.Location = new System.Drawing.Point(778, 0);
			this.txtTimKiem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.PasswordChar = '\0';
			this.txtTimKiem.PlaceholderText = "Nhập tên cần tìm";
			this.txtTimKiem.SelectedText = "";
			this.txtTimKiem.Size = new System.Drawing.Size(468, 64);
			this.txtTimKiem.TabIndex = 1;
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnTimKiem.FillColor = System.Drawing.Color.Silver;
			this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnTimKiem.ForeColor = System.Drawing.Color.White;
			this.btnTimKiem.Location = new System.Drawing.Point(1246, 0);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(294, 64);
			this.btnTimKiem.TabIndex = 0;
			this.btnTimKiem.Text = "Tìm kiếm";
			// 
			// FormTruyenDaDang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1540, 888);
			this.Controls.Add(this.panelSeries);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormTruyenDaDang";
			this.Text = "FormTruyenDaDang";
			this.panelSeries.ResumeLayout(false);
			this.guna2GroupBox1.ResumeLayout(false);
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel panelSeries;
		private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
		private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
		private Guna.UI2.WinForms.Guna2Button btnTimKiem;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private System.Windows.Forms.Label lblTenTruyen;
		private System.Windows.Forms.Label lblNguoiDang;
		private System.Windows.Forms.Label lblNhomDich;
		private System.Windows.Forms.Label lblQuanly;
	}
}