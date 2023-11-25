namespace ReadingLightNovelApplication.AccountSystem.AccountSystem
{
	partial class FormTheLoaiItem
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
			this.guna2Panel22 = new Guna.UI2.WinForms.Guna2Panel();
			this.checkboxTheLoai = new Guna.UI2.WinForms.Guna2CheckBox();
			this.guna2Panel22.SuspendLayout();
			this.SuspendLayout();
			// 
			// guna2Panel22
			// 
			this.guna2Panel22.Controls.Add(this.checkboxTheLoai);
			this.guna2Panel22.Location = new System.Drawing.Point(1, 3);
			this.guna2Panel22.Name = "guna2Panel22";
			this.guna2Panel22.Size = new System.Drawing.Size(259, 56);
			this.guna2Panel22.TabIndex = 1;
			// 
			// checkboxTheLoai
			// 
			this.checkboxTheLoai.AutoSize = true;
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
			// 
			// FormTheLoaiItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(262, 60);
			this.Controls.Add(this.guna2Panel22);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormTheLoaiItem";
			this.Text = "FormTheLoaiItem";
			this.guna2Panel22.ResumeLayout(false);
			this.guna2Panel22.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel guna2Panel22;
		private Guna.UI2.WinForms.Guna2CheckBox checkboxTheLoai;
	}
}