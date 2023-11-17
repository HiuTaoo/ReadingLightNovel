namespace ReadingLightNovelApplication
{
	partial class FormTruyenItemNoiBat
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
			this.guna2Panel48 = new Guna.UI2.WinForms.Guna2Panel();
			this.panelAnh = new Guna.UI2.WinForms.Guna2Panel();
			this.btnTenTruyen = new Guna.UI2.WinForms.Guna2GradientButton();
			this.guna2Panel49 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2Panel48.SuspendLayout();
			this.panelAnh.SuspendLayout();
			this.SuspendLayout();
			// 
			// guna2Panel48
			// 
			this.guna2Panel48.Controls.Add(this.panelAnh);
			this.guna2Panel48.Controls.Add(this.guna2Panel49);
			this.guna2Panel48.Location = new System.Drawing.Point(8, 8);
			this.guna2Panel48.Name = "guna2Panel48";
			this.guna2Panel48.Size = new System.Drawing.Size(260, 337);
			this.guna2Panel48.TabIndex = 5;
			// 
			// panelAnh
			// 
			this.panelAnh.Controls.Add(this.btnTenTruyen);
			this.panelAnh.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelAnh.Location = new System.Drawing.Point(23, 0);
			this.panelAnh.Name = "panelAnh";
			this.panelAnh.Size = new System.Drawing.Size(237, 337);
			this.panelAnh.TabIndex = 1;
			// 
			// btnTenTruyen
			// 
			this.btnTenTruyen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnTenTruyen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnTenTruyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnTenTruyen.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnTenTruyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnTenTruyen.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnTenTruyen.FillColor = System.Drawing.Color.Silver;
			this.btnTenTruyen.FillColor2 = System.Drawing.Color.Transparent;
			this.btnTenTruyen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTenTruyen.ForeColor = System.Drawing.Color.White;
			this.btnTenTruyen.Location = new System.Drawing.Point(0, 267);
			this.btnTenTruyen.Name = "btnTenTruyen";
			this.btnTenTruyen.Size = new System.Drawing.Size(237, 70);
			this.btnTenTruyen.TabIndex = 2;
			this.btnTenTruyen.Text = "guna2GradientButton1";
			this.btnTenTruyen.MouseLeave += new System.EventHandler(this.btnTenTruyen_MouseLeave);
			this.btnTenTruyen.MouseHover += new System.EventHandler(this.btnTenTruyen_MouseHover);
			// 
			// guna2Panel49
			// 
			this.guna2Panel49.Dock = System.Windows.Forms.DockStyle.Left;
			this.guna2Panel49.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel49.Name = "guna2Panel49";
			this.guna2Panel49.Size = new System.Drawing.Size(23, 337);
			this.guna2Panel49.TabIndex = 0;
			// 
			// FormTruyenItemNoiBat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(271, 337);
			this.Controls.Add(this.guna2Panel48);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormTruyenItemNoiBat";
			this.Text = "FormTruyenItemNoiBat";
			this.Load += new System.EventHandler(this.FormTruyenItemNoiBat_Load);
			this.guna2Panel48.ResumeLayout(false);
			this.panelAnh.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel guna2Panel48;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel49;
		private Guna.UI2.WinForms.Guna2Panel panelAnh;
		private Guna.UI2.WinForms.Guna2GradientButton btnTenTruyen;
	}
}