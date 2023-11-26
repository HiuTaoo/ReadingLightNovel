namespace ReadingLightNovelApplication.AccountSystem.AccountSystem
{
	partial class FormChapterContain
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
			this.btnTenChapter = new Guna.UI2.WinForms.Guna2Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btnSuaChapter = new System.Windows.Forms.ToolStripMenuItem();
			this.btnXoaChapter = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnTenChapter
			// 
			this.btnTenChapter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnTenChapter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnTenChapter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnTenChapter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnTenChapter.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnTenChapter.FillColor = System.Drawing.Color.Transparent;
			this.btnTenChapter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTenChapter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
			this.btnTenChapter.Location = new System.Drawing.Point(0, 0);
			this.btnTenChapter.Name = "btnTenChapter";
			this.btnTenChapter.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
			this.btnTenChapter.Size = new System.Drawing.Size(380, 45);
			this.btnTenChapter.TabIndex = 31;
			this.btnTenChapter.Text = "Chương 1";
			this.btnTenChapter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnTenChapter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnTenChapter_MouseUp);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSuaChapter,
            this.btnXoaChapter});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(180, 68);
			// 
			// btnSuaChapter
			// 
			this.btnSuaChapter.Name = "btnSuaChapter";
			this.btnSuaChapter.Size = new System.Drawing.Size(179, 32);
			this.btnSuaChapter.Text = "Sửa chapter";
			// 
			// btnXoaChapter
			// 
			this.btnXoaChapter.Name = "btnXoaChapter";
			this.btnXoaChapter.Size = new System.Drawing.Size(179, 32);
			this.btnXoaChapter.Text = "Xóa chapter";
			// 
			// FormChapterContain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(380, 45);
			this.Controls.Add(this.btnTenChapter);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormChapterContain";
			this.Text = "FormChapterContain";
			this.Load += new System.EventHandler(this.FormChapterContain_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Button btnTenChapter;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem btnSuaChapter;
		private System.Windows.Forms.ToolStripMenuItem btnXoaChapter;
	}
}