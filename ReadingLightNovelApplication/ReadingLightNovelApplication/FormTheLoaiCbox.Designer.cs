namespace ReadingLightNovelApplication
{
	partial class FormTheLoaiCbox
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
			this.guna2Panel23 = new Guna.UI2.WinForms.Guna2Panel();
			this.checkboxTheLoai = new Guna.UI2.WinForms.Guna2CheckBox();
			this.guna2Panel23.SuspendLayout();
			this.SuspendLayout();
			// 
			// guna2Panel23
			// 
			this.guna2Panel23.BackColor = System.Drawing.Color.Transparent;
			this.guna2Panel23.Controls.Add(this.checkboxTheLoai);
			this.guna2Panel23.Location = new System.Drawing.Point(0, 2);
			this.guna2Panel23.Name = "guna2Panel23";
			this.guna2Panel23.Size = new System.Drawing.Size(262, 49);
			this.guna2Panel23.TabIndex = 2;
			// 
			// checkboxTheLoai
			// 
			this.checkboxTheLoai.AutoSize = true;
			this.checkboxTheLoai.BackColor = System.Drawing.Color.Transparent;
			this.checkboxTheLoai.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.checkboxTheLoai.CheckedState.BorderRadius = 0;
			this.checkboxTheLoai.CheckedState.BorderThickness = 0;
			this.checkboxTheLoai.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.checkboxTheLoai.Location = new System.Drawing.Point(20, 15);
			this.checkboxTheLoai.Name = "checkboxTheLoai";
			this.checkboxTheLoai.Size = new System.Drawing.Size(156, 24);
			this.checkboxTheLoai.TabIndex = 0;
			this.checkboxTheLoai.Text = "adpted to manga";
			this.checkboxTheLoai.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.checkboxTheLoai.UncheckedState.BorderRadius = 0;
			this.checkboxTheLoai.UncheckedState.BorderThickness = 0;
			this.checkboxTheLoai.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.checkboxTheLoai.UseVisualStyleBackColor = false;
			this.checkboxTheLoai.CheckedChanged += new System.EventHandler(this.checkboxTheLoai_CheckedChanged);
			// 
			// FormTheLoaiCbox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(263, 63);
			this.Controls.Add(this.guna2Panel23);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormTheLoaiCbox";
			this.Text = "FormTheLoaiCbox";
			this.Load += new System.EventHandler(this.FormTheLoaiCbox_Load);
			this.guna2Panel23.ResumeLayout(false);
			this.guna2Panel23.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel guna2Panel23;
		private Guna.UI2.WinForms.Guna2CheckBox checkboxTheLoai;
	}
}