namespace ReadingLightNovelApplication
{
	partial class FormHomeSystem
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
			this.gbThongke = new Guna.UI2.WinForms.Guna2GroupBox();
			this.lblSoChuong = new System.Windows.Forms.Label();
			this.lblSoTap = new System.Windows.Forms.Label();
			this.lblSoTruyen = new System.Windows.Forms.Label();
			this.lblThongKe = new System.Windows.Forms.Label();
			this.guna2Panel1.SuspendLayout();
			this.gbThongke.SuspendLayout();
			this.SuspendLayout();
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Controls.Add(this.gbThongke);
			this.guna2Panel1.Location = new System.Drawing.Point(-4, 3);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(1012, 295);
			this.guna2Panel1.TabIndex = 0;
			// 
			// gbThongke
			// 
			this.gbThongke.Controls.Add(this.lblSoChuong);
			this.gbThongke.Controls.Add(this.lblSoTap);
			this.gbThongke.Controls.Add(this.lblSoTruyen);
			this.gbThongke.Controls.Add(this.lblThongKe);
			this.gbThongke.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.gbThongke.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.gbThongke.Location = new System.Drawing.Point(3, 3);
			this.gbThongke.Name = "gbThongke";
			this.gbThongke.Size = new System.Drawing.Size(1005, 290);
			this.gbThongke.TabIndex = 2;
			this.gbThongke.Text = "Home";
			// 
			// lblSoChuong
			// 
			this.lblSoChuong.AutoSize = true;
			this.lblSoChuong.BackColor = System.Drawing.Color.White;
			this.lblSoChuong.ForeColor = System.Drawing.Color.Black;
			this.lblSoChuong.Location = new System.Drawing.Point(50, 243);
			this.lblSoChuong.Name = "lblSoChuong";
			this.lblSoChuong.Size = new System.Drawing.Size(134, 32);
			this.lblSoChuong.TabIndex = 3;
			this.lblSoChuong.Text = "Số chương:";
			// 
			// lblSoTap
			// 
			this.lblSoTap.AutoSize = true;
			this.lblSoTap.BackColor = System.Drawing.Color.White;
			this.lblSoTap.ForeColor = System.Drawing.Color.Black;
			this.lblSoTap.Location = new System.Drawing.Point(50, 193);
			this.lblSoTap.Name = "lblSoTap";
			this.lblSoTap.Size = new System.Drawing.Size(94, 32);
			this.lblSoTap.TabIndex = 2;
			this.lblSoTap.Text = "Số tập: ";
			// 
			// lblSoTruyen
			// 
			this.lblSoTruyen.AutoSize = true;
			this.lblSoTruyen.BackColor = System.Drawing.Color.White;
			this.lblSoTruyen.ForeColor = System.Drawing.Color.Black;
			this.lblSoTruyen.Location = new System.Drawing.Point(50, 138);
			this.lblSoTruyen.Name = "lblSoTruyen";
			this.lblSoTruyen.Size = new System.Drawing.Size(129, 32);
			this.lblSoTruyen.TabIndex = 1;
			this.lblSoTruyen.Text = "Số truyện: ";
			// 
			// lblThongKe
			// 
			this.lblThongKe.AutoSize = true;
			this.lblThongKe.BackColor = System.Drawing.Color.White;
			this.lblThongKe.Font = new System.Drawing.Font("Times New Roman", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lblThongKe.ForeColor = System.Drawing.Color.Black;
			this.lblThongKe.Location = new System.Drawing.Point(50, 82);
			this.lblThongKe.Name = "lblThongKe";
			this.lblThongKe.Size = new System.Drawing.Size(128, 32);
			this.lblThongKe.TabIndex = 0;
			this.lblThongKe.Text = "Thống kê";
			// 
			// FormHomeSystem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1008, 299);
			this.Controls.Add(this.guna2Panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormHomeSystem";
			this.Text = "FormHomeSystem";
			this.Load += new System.EventHandler(this.FormHomeSystem_Load);
			this.guna2Panel1.ResumeLayout(false);
			this.gbThongke.ResumeLayout(false);
			this.gbThongke.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2GroupBox gbThongke;
		private System.Windows.Forms.Label lblSoChuong;
		private System.Windows.Forms.Label lblSoTap;
		private System.Windows.Forms.Label lblSoTruyen;
		private System.Windows.Forms.Label lblThongKe;
	}
}