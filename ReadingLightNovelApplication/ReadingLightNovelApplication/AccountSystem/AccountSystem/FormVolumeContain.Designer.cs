namespace ReadingLightNovelApplication.AccountSystem.AccountSystem
{
	partial class FormVolumeContain
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
			this.components = new System.ComponentModel.Container();
			this.panelVolumeContain = new Guna.UI2.WinForms.Guna2Panel();
			this.panelChapterContain = new Guna.UI2.WinForms.Guna2Panel();
			this.btnTenVolume = new Guna.UI2.WinForms.Guna2Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btnSuaVolume = new System.Windows.Forms.ToolStripMenuItem();
			this.btnXoaVolume = new System.Windows.Forms.ToolStripMenuItem();
			this.btnThemChapter = new System.Windows.Forms.ToolStripMenuItem();
			this.btnSapXepChapter = new System.Windows.Forms.ToolStripMenuItem();
			this.panelVolumeContain.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelVolumeContain
			// 
			this.panelVolumeContain.AutoSize = true;
			this.panelVolumeContain.Controls.Add(this.panelChapterContain);
			this.panelVolumeContain.Controls.Add(this.btnTenVolume);
			this.panelVolumeContain.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelVolumeContain.Location = new System.Drawing.Point(0, 0);
			this.panelVolumeContain.Name = "panelVolumeContain";
			this.panelVolumeContain.Size = new System.Drawing.Size(380, 45);
			this.panelVolumeContain.TabIndex = 29;
			// 
			// panelChapterContain
			// 
			this.panelChapterContain.AutoSize = true;
			this.panelChapterContain.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelChapterContain.Location = new System.Drawing.Point(0, 45);
			this.panelChapterContain.Name = "panelChapterContain";
			this.panelChapterContain.Size = new System.Drawing.Size(380, 0);
			this.panelChapterContain.TabIndex = 30;
			// 
			// btnTenVolume
			// 
			this.btnTenVolume.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnTenVolume.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnTenVolume.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnTenVolume.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnTenVolume.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnTenVolume.FillColor = System.Drawing.Color.Transparent;
			this.btnTenVolume.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTenVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
			this.btnTenVolume.Location = new System.Drawing.Point(0, 0);
			this.btnTenVolume.Name = "btnTenVolume";
			this.btnTenVolume.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
			this.btnTenVolume.Size = new System.Drawing.Size(380, 45);
			this.btnTenVolume.TabIndex = 29;
			this.btnTenVolume.Text = "Vol 1";
			this.btnTenVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnTenVolume.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnTenVolume_MouseUp);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSuaVolume,
            this.btnXoaVolume,
            this.btnThemChapter,
            this.btnSapXepChapter});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(212, 132);
			// 
			// btnSuaVolume
			// 
			this.btnSuaVolume.Name = "btnSuaVolume";
			this.btnSuaVolume.Size = new System.Drawing.Size(211, 32);
			this.btnSuaVolume.Tag = "";
			this.btnSuaVolume.Text = "Sửa volume";
			// 
			// btnXoaVolume
			// 
			this.btnXoaVolume.Name = "btnXoaVolume";
			this.btnXoaVolume.Size = new System.Drawing.Size(211, 32);
			this.btnXoaVolume.Text = "Xóa volume";
			// 
			// btnThemChapter
			// 
			this.btnThemChapter.Name = "btnThemChapter";
			this.btnThemChapter.Size = new System.Drawing.Size(211, 32);
			this.btnThemChapter.Text = "Thêm chapter";
			// 
			// btnSapXepChapter
			// 
			this.btnSapXepChapter.Name = "btnSapXepChapter";
			this.btnSapXepChapter.Size = new System.Drawing.Size(211, 32);
			this.btnSapXepChapter.Text = "Sắp xếp chapter";
			// 
			// FormVolumeContain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(380, 45);
			this.Controls.Add(this.panelVolumeContain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormVolumeContain";
			this.Text = "FormVolumeContain";
			this.Load += new System.EventHandler(this.FormVolumeContain_Load);
			this.panelVolumeContain.ResumeLayout(false);
			this.panelVolumeContain.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel panelVolumeContain;
		private Guna.UI2.WinForms.Guna2Panel panelChapterContain;
		private Guna.UI2.WinForms.Guna2Button btnTenVolume;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem btnSuaVolume;
		private System.Windows.Forms.ToolStripMenuItem btnXoaVolume;
		private System.Windows.Forms.ToolStripMenuItem btnThemChapter;
		private System.Windows.Forms.ToolStripMenuItem btnSapXepChapter;
	}
}