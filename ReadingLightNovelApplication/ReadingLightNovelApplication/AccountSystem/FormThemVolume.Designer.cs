namespace ReadingLightNovelApplication.AccountSystem
{
	partial class FormThemVolume
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
			this.btnThem = new Guna.UI2.WinForms.Guna2Button();
			this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
			this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
			this.SuspendLayout();
			// 
			// btnThem
			// 
			this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnThem.BorderRadius = 20;
			this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnThem.ForeColor = System.Drawing.Color.White;
			this.btnThem.Location = new System.Drawing.Point(775, 479);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(189, 69);
			this.btnThem.TabIndex = 2;
			this.btnThem.Text = "Thêm";
			// 
			// btnHuy
			// 
			this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnHuy.BorderRadius = 20;
			this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnHuy.ForeColor = System.Drawing.Color.White;
			this.btnHuy.Location = new System.Drawing.Point(970, 479);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(189, 69);
			this.btnHuy.TabIndex = 3;
			this.btnHuy.Text = "Hủy";
			// 
			// guna2TextBox1
			// 
			this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.guna2TextBox1.DefaultText = "";
			this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.guna2TextBox1.Location = new System.Drawing.Point(261, 253);
			this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.guna2TextBox1.Name = "guna2TextBox1";
			this.guna2TextBox1.PasswordChar = '\0';
			this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Black;
			this.guna2TextBox1.PlaceholderText = "Nhập tên volume";
			this.guna2TextBox1.SelectedText = "";
			this.guna2TextBox1.Size = new System.Drawing.Size(752, 53);
			this.guna2TextBox1.TabIndex = 4;
			// 
			// FormThemVolume
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1253, 688);
			this.Controls.Add(this.guna2TextBox1);
			this.Controls.Add(this.btnHuy);
			this.Controls.Add(this.btnThem);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormThemVolume";
			this.Text = "FormThemVolume";
			this.ResumeLayout(false);

		}

		#endregion
		private Guna.UI2.WinForms.Guna2Button btnThem;
		private Guna.UI2.WinForms.Guna2Button btnHuy;
		private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
	}
}