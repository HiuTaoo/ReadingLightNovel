namespace ReadingLightNovelApplication
{
    partial class FormListItem
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
            this.btnTenVol = new Guna.UI2.WinForms.Guna2Button();
            this.panelChapter = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(308, 16);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnTenVol
            // 
            this.btnTenVol.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTenVol.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTenVol.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTenVol.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTenVol.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTenVol.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(161)))), ((int)(((byte)(137)))));
            this.btnTenVol.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTenVol.ForeColor = System.Drawing.Color.White;
            this.btnTenVol.Location = new System.Drawing.Point(0, 16);
            this.btnTenVol.Name = "btnTenVol";
            this.btnTenVol.Size = new System.Drawing.Size(308, 54);
            this.btnTenVol.TabIndex = 1;
            this.btnTenVol.Text = " ";
            this.btnTenVol.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panelChapter
            // 
            this.panelChapter.AutoSize = true;
            this.panelChapter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChapter.Location = new System.Drawing.Point(0, 70);
            this.panelChapter.Name = "panelChapter";
            this.panelChapter.Size = new System.Drawing.Size(308, 7);
            this.panelChapter.TabIndex = 2;
            // 
            // FormListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(308, 77);
            this.Controls.Add(this.panelChapter);
            this.Controls.Add(this.btnTenVol);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListItem";
            this.Text = "FormListItem";
            this.Load += new System.EventHandler(this.FormListItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnTenVol;
        private Guna.UI2.WinForms.Guna2Panel panelChapter;
    }
}