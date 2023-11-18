namespace ReadingLightNovelApplication
{
	partial class FormTheLoaiCheckbox
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
			this.guna2Panel13 = new Guna.UI2.WinForms.Guna2Panel();
			this.labelTheLoai = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.checkboxTheLoai = new Guna.UI2.WinForms.Guna2CustomCheckBox();
			this.guna2Panel16 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2Panel15 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2Panel14 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2Panel13.SuspendLayout();
			this.SuspendLayout();
			// 
			// guna2Panel13
			// 
			this.guna2Panel13.Controls.Add(this.labelTheLoai);
			this.guna2Panel13.Controls.Add(this.checkboxTheLoai);
			this.guna2Panel13.Controls.Add(this.guna2Panel16);
			this.guna2Panel13.Controls.Add(this.guna2Panel15);
			this.guna2Panel13.Controls.Add(this.guna2Panel14);
			this.guna2Panel13.Location = new System.Drawing.Point(8, 8);
			this.guna2Panel13.Name = "guna2Panel13";
			this.guna2Panel13.Size = new System.Drawing.Size(200, 71);
			this.guna2Panel13.TabIndex = 5;
			// 
			// labelTheLoai
			// 
			this.labelTheLoai.BackColor = System.Drawing.Color.Transparent;
			this.labelTheLoai.Location = new System.Drawing.Point(43, 26);
			this.labelTheLoai.Name = "labelTheLoai";
			this.labelTheLoai.Size = new System.Drawing.Size(129, 22);
			this.labelTheLoai.TabIndex = 4;
			this.labelTheLoai.Text = "Adapted to anime";
			// 
			// checkboxTheLoai
			// 
			this.checkboxTheLoai.BackColor = System.Drawing.Color.Transparent;
			this.checkboxTheLoai.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.checkboxTheLoai.CheckedState.BorderRadius = 2;
			this.checkboxTheLoai.CheckedState.BorderThickness = 0;
			this.checkboxTheLoai.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.checkboxTheLoai.Location = new System.Drawing.Point(17, 26);
			this.checkboxTheLoai.Name = "checkboxTheLoai";
			this.checkboxTheLoai.Size = new System.Drawing.Size(20, 20);
			this.checkboxTheLoai.TabIndex = 3;
			this.checkboxTheLoai.Text = "Tất cả";
			this.checkboxTheLoai.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.checkboxTheLoai.UncheckedState.BorderRadius = 2;
			this.checkboxTheLoai.UncheckedState.BorderThickness = 0;
			this.checkboxTheLoai.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.checkboxTheLoai.UseTransparentBackground = true;
			this.checkboxTheLoai.Click += new System.EventHandler(this.checkboxTheLoai_Click);
			// 
			// guna2Panel16
			// 
			this.guna2Panel16.Dock = System.Windows.Forms.DockStyle.Left;
			this.guna2Panel16.Location = new System.Drawing.Point(0, 22);
			this.guna2Panel16.Name = "guna2Panel16";
			this.guna2Panel16.Size = new System.Drawing.Size(18, 27);
			this.guna2Panel16.TabIndex = 2;
			// 
			// guna2Panel15
			// 
			this.guna2Panel15.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.guna2Panel15.Location = new System.Drawing.Point(0, 49);
			this.guna2Panel15.Name = "guna2Panel15";
			this.guna2Panel15.Size = new System.Drawing.Size(200, 22);
			this.guna2Panel15.TabIndex = 1;
			// 
			// guna2Panel14
			// 
			this.guna2Panel14.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2Panel14.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel14.Name = "guna2Panel14";
			this.guna2Panel14.Size = new System.Drawing.Size(200, 22);
			this.guna2Panel14.TabIndex = 0;
			// 
			// FormTheLoaiCheckbox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(200, 71);
			this.Controls.Add(this.guna2Panel13);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormTheLoaiCheckbox";
			this.Text = "FormTheLoaiCheckbox";
			this.Load += new System.EventHandler(this.FormTheLoaiCheckbox_Load);
			this.guna2Panel13.ResumeLayout(false);
			this.guna2Panel13.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel guna2Panel13;
		private Guna.UI2.WinForms.Guna2HtmlLabel labelTheLoai;
		private Guna.UI2.WinForms.Guna2CustomCheckBox checkboxTheLoai;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel16;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel15;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel14;
	}
}