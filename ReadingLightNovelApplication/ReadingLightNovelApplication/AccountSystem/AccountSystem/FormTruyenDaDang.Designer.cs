namespace ReadingLightNovelApplication.AccountSystem
{
	partial class FormTruyenDaDang
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
			this.dvgHienThi = new System.Windows.Forms.DataGridView();
			this.btnSua = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dvgHienThi)).BeginInit();
			this.SuspendLayout();
			// 
			// dvgHienThi
			// 
			this.dvgHienThi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dvgHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dvgHienThi.Location = new System.Drawing.Point(75, 105);
			this.dvgHienThi.Name = "dvgHienThi";
			this.dvgHienThi.RowHeadersWidth = 82;
			this.dvgHienThi.RowTemplate.Height = 33;
			this.dvgHienThi.Size = new System.Drawing.Size(1192, 459);
			this.dvgHienThi.TabIndex = 0;
			this.dvgHienThi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgHienThi_CellClick);
			// 
			// btnSua
			// 
			this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSua.Location = new System.Drawing.Point(966, 606);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(243, 78);
			this.btnSua.TabIndex = 1;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// FormTruyenDaDang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1474, 864);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.dvgHienThi);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormTruyenDaDang";
			this.Text = "FormTruyenDaDang";
			this.Load += new System.EventHandler(this.FormTruyenDaDang_Load);
			((System.ComponentModel.ISupportInitialize)(this.dvgHienThi)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dvgHienThi;
		private System.Windows.Forms.Button btnSua;
	}
}