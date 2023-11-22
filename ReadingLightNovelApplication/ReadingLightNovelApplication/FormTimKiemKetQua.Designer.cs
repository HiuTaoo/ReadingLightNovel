namespace ReadingLightNovelApplication
{
	partial class FormTimKiemKetQua
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
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.flpKetQua = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(33, 254);
			this.guna2Panel1.TabIndex = 0;
			// 
			// guna2Panel2
			// 
			this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.guna2Panel2.Location = new System.Drawing.Point(1515, 0);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new System.Drawing.Size(33, 254);
			this.guna2Panel2.TabIndex = 1;
			// 
			// flpKetQua
			// 
			this.flpKetQua.AutoSize = true;
			this.flpKetQua.Dock = System.Windows.Forms.DockStyle.Top;
			this.flpKetQua.Location = new System.Drawing.Point(33, 0);
			this.flpKetQua.Name = "flpKetQua";
			this.flpKetQua.Size = new System.Drawing.Size(1482, 0);
			this.flpKetQua.TabIndex = 2;
			this.flpKetQua.AutoSizeChanged += new System.EventHandler(this.flpKetQua_AutoSizeChanged);
			// 
			// FormTimKiemKetQua
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1548, 254);
			this.Controls.Add(this.flpKetQua);
			this.Controls.Add(this.guna2Panel2);
			this.Controls.Add(this.guna2Panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormTimKiemKetQua";
			this.Text = "FormTimKiemKetQua";
			this.Load += new System.EventHandler(this.FormTimKiemKetQua_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
		private System.Windows.Forms.FlowLayoutPanel flpKetQua;
	}
}