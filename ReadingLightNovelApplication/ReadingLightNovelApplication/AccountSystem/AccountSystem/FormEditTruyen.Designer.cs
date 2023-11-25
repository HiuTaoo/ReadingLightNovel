namespace ReadingLightNovelApplication.AccountSystem.AccountSystem
{
	partial class FormEditTruyen
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
			this.panelBar = new Guna.UI2.WinForms.Guna2Panel();
			this.panelVolumeContain = new Guna.UI2.WinForms.Guna2Panel();
			this.btnTenTruyen = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
			this.panelNoiDung = new Guna.UI2.WinForms.Guna2Panel();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btnSuaTruyen = new System.Windows.Forms.ToolStripMenuItem();
			this.btnSapXepVolume = new System.Windows.Forms.ToolStripMenuItem();
			this.btnThemVolume = new System.Windows.Forms.ToolStripMenuItem();
			this.panelBar.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelBar
			// 
			this.panelBar.Controls.Add(this.panelVolumeContain);
			this.panelBar.Controls.Add(this.btnTenTruyen);
			this.panelBar.Controls.Add(this.guna2Panel8);
			this.panelBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelBar.Location = new System.Drawing.Point(0, 0);
			this.panelBar.Name = "panelBar";
			this.panelBar.Size = new System.Drawing.Size(380, 772);
			this.panelBar.TabIndex = 0;
			// 
			// panelVolumeContain
			// 
			this.panelVolumeContain.AutoSize = true;
			this.panelVolumeContain.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelVolumeContain.Location = new System.Drawing.Point(0, 130);
			this.panelVolumeContain.Name = "panelVolumeContain";
			this.panelVolumeContain.Size = new System.Drawing.Size(380, 0);
			this.panelVolumeContain.TabIndex = 28;
			// 
			// btnTenTruyen
			// 
			this.btnTenTruyen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnTenTruyen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnTenTruyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnTenTruyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnTenTruyen.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnTenTruyen.FillColor = System.Drawing.Color.Transparent;
			this.btnTenTruyen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTenTruyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
			this.btnTenTruyen.Location = new System.Drawing.Point(0, 85);
			this.btnTenTruyen.Name = "btnTenTruyen";
			this.btnTenTruyen.Size = new System.Drawing.Size(380, 45);
			this.btnTenTruyen.TabIndex = 27;
			this.btnTenTruyen.Text = "Yuki to sumi";
			this.btnTenTruyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnTenTruyen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnTenTruyen_MouseUp);
			// 
			// guna2Panel8
			// 
			this.guna2Panel8.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2Panel8.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel8.Name = "guna2Panel8";
			this.guna2Panel8.Size = new System.Drawing.Size(380, 85);
			this.guna2Panel8.TabIndex = 26;
			// 
			// guna2Panel2
			// 
			this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.guna2Panel2.Location = new System.Drawing.Point(380, 0);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new System.Drawing.Size(89, 772);
			this.guna2Panel2.TabIndex = 1;
			// 
			// guna2Panel3
			// 
			this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Right;
			this.guna2Panel3.Location = new System.Drawing.Point(1385, 0);
			this.guna2Panel3.Name = "guna2Panel3";
			this.guna2Panel3.Size = new System.Drawing.Size(33, 772);
			this.guna2Panel3.TabIndex = 2;
			// 
			// panelNoiDung
			// 
			this.panelNoiDung.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelNoiDung.Location = new System.Drawing.Point(469, 0);
			this.panelNoiDung.Name = "panelNoiDung";
			this.panelNoiDung.Size = new System.Drawing.Size(916, 769);
			this.panelNoiDung.TabIndex = 3;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSuaTruyen,
            this.btnSapXepVolume,
            this.btnThemVolume});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(212, 100);
			// 
			// btnSuaTruyen
			// 
			this.btnSuaTruyen.Name = "btnSuaTruyen";
			this.btnSuaTruyen.Size = new System.Drawing.Size(211, 32);
			this.btnSuaTruyen.Text = "Sửa truyện";
			// 
			// btnSapXepVolume
			// 
			this.btnSapXepVolume.Name = "btnSapXepVolume";
			this.btnSapXepVolume.Size = new System.Drawing.Size(211, 32);
			this.btnSapXepVolume.Text = "Sắp xếp volume";
			// 
			// btnThemVolume
			// 
			this.btnThemVolume.Name = "btnThemVolume";
			this.btnThemVolume.Size = new System.Drawing.Size(211, 32);
			this.btnThemVolume.Text = "Thêm volume";
			// 
			// FormEditTruyen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1418, 772);
			this.Controls.Add(this.panelNoiDung);
			this.Controls.Add(this.guna2Panel3);
			this.Controls.Add(this.guna2Panel2);
			this.Controls.Add(this.panelBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormEditTruyen";
			this.Text = "FormEditTruyen";
			this.Load += new System.EventHandler(this.FormEditTruyen_Load);
			this.panelBar.ResumeLayout(false);
			this.panelBar.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel panelBar;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
		private Guna.UI2.WinForms.Guna2Panel panelNoiDung;
		private Guna.UI2.WinForms.Guna2Button btnTenTruyen;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
		private Guna.UI2.WinForms.Guna2Panel panelVolumeContain;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem btnSuaTruyen;
		private System.Windows.Forms.ToolStripMenuItem btnSapXepVolume;
		private System.Windows.Forms.ToolStripMenuItem btnThemVolume;
	}
}