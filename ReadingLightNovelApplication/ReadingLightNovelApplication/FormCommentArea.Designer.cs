namespace ReadingLightNovelApplication
{
    partial class FormCommentArea
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTextArea = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDangCmt = new Guna.UI2.WinForms.Guna2Button();
            this.tbCmt = new System.Windows.Forms.RichTextBox();
            this.panelCmt = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1.SuspendLayout();
            this.panelTextArea.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 42);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng bình luận";
            // 
            // panelTextArea
            // 
            this.panelTextArea.AutoSize = true;
            this.panelTextArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTextArea.Controls.Add(this.panel4);
            this.panelTextArea.Controls.Add(this.tbCmt);
            this.panelTextArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTextArea.Location = new System.Drawing.Point(0, 42);
            this.panelTextArea.Name = "panelTextArea";
            this.panelTextArea.Size = new System.Drawing.Size(950, 167);
            this.panelTextArea.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightCyan;
            this.panel4.Controls.Add(this.btnDangCmt);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 118);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(948, 47);
            this.panel4.TabIndex = 7;
            // 
            // btnDangCmt
            // 
            this.btnDangCmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangCmt.BackColor = System.Drawing.SystemColors.Control;
            this.btnDangCmt.BorderRadius = 10;
            this.btnDangCmt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangCmt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangCmt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangCmt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangCmt.FillColor = System.Drawing.Color.MediumAquamarine;
            this.btnDangCmt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnDangCmt.ForeColor = System.Drawing.Color.Black;
            this.btnDangCmt.Location = new System.Drawing.Point(670, 5);
            this.btnDangCmt.Name = "btnDangCmt";
            this.btnDangCmt.Size = new System.Drawing.Size(173, 36);
            this.btnDangCmt.TabIndex = 0;
            this.btnDangCmt.Text = "Đăng bình luận";
            this.btnDangCmt.Click += new System.EventHandler(this.btnDangCmt_Click);
            // 
            // tbCmt
            // 
            this.tbCmt.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbCmt.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCmt.Location = new System.Drawing.Point(0, 0);
            this.tbCmt.Name = "tbCmt";
            this.tbCmt.Size = new System.Drawing.Size(948, 118);
            this.tbCmt.TabIndex = 5;
            this.tbCmt.Text = "";
            // 
            // panelCmt
            // 
            this.panelCmt.AutoSize = true;
            this.panelCmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(228)))), ((int)(((byte)(211)))));
            this.panelCmt.BorderColor = System.Drawing.Color.Silver;
            this.panelCmt.BorderThickness = 1;
            this.panelCmt.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCmt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(228)))), ((int)(((byte)(211)))));
            this.panelCmt.Location = new System.Drawing.Point(0, 209);
            this.panelCmt.Name = "panelCmt";
            this.panelCmt.Size = new System.Drawing.Size(950, 0);
            this.panelCmt.TabIndex = 2;
            // 
            // FormCommentArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(950, 209);
            this.Controls.Add(this.panelCmt);
            this.Controls.Add(this.panelTextArea);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCommentArea";
            this.Text = "FormCommentArea";
            this.Load += new System.EventHandler(this.FormCommentArea_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTextArea.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTextArea;
        private Guna.UI2.WinForms.Guna2Panel panelCmt;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btnDangCmt;
        private System.Windows.Forms.RichTextBox tbCmt;
    }
}