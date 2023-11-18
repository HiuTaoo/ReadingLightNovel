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
			this.flpDanhSach = new System.Windows.Forms.FlowLayoutPanel();
			this.flpDanhSachKetQua = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// flpDanhSach
			// 
			this.flpDanhSach.AutoSize = true;
			this.flpDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
			this.flpDanhSach.Location = new System.Drawing.Point(0, 0);
			this.flpDanhSach.Name = "flpDanhSach";
			this.flpDanhSach.Size = new System.Drawing.Size(1548, 0);
			this.flpDanhSach.TabIndex = 0;
			// 
			// flpDanhSachKetQua
			// 
			this.flpDanhSachKetQua.AutoSize = true;
			this.flpDanhSachKetQua.Dock = System.Windows.Forms.DockStyle.Top;
			this.flpDanhSachKetQua.Location = new System.Drawing.Point(0, 0);
			this.flpDanhSachKetQua.Name = "flpDanhSachKetQua";
			this.flpDanhSachKetQua.Size = new System.Drawing.Size(1548, 0);
			this.flpDanhSachKetQua.TabIndex = 1;
			// 
			// FormTimKiemKetQua
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1548, 471);
			this.Controls.Add(this.flpDanhSachKetQua);
			this.Controls.Add(this.flpDanhSach);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormTimKiemKetQua";
			this.Text = "FormTimKiemKetQua";
			this.Load += new System.EventHandler(this.FormTimKiemKetQua_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flpDanhSach;
		private System.Windows.Forms.FlowLayoutPanel flpDanhSachKetQua;
	}
}