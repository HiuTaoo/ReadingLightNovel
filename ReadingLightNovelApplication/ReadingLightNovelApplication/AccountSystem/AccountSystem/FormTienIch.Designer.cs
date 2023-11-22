namespace ReadingLightNovelApplication
{
	partial class FormTienIch
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
			this.panelTienIch = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2Panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Controls.Add(this.panelTienIch);
			this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(824, 822);
			this.guna2Panel1.TabIndex = 0;
			// 
			// panelTienIch
			// 
			this.panelTienIch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelTienIch.Location = new System.Drawing.Point(0, 0);
			this.panelTienIch.Name = "panelTienIch";
			this.panelTienIch.Size = new System.Drawing.Size(824, 822);
			this.panelTienIch.TabIndex = 0;
			this.panelTienIch.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTienIch_Paint);
			// 
			// FormTienIch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(824, 822);
			this.ControlBox = false;
			this.Controls.Add(this.guna2Panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormTienIch";
			this.Text = "FormTienIch";
			this.Load += new System.EventHandler(this.FormTienIch_Load);
			this.guna2Panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2Panel panelTienIch;
	}
}