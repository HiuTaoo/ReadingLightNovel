namespace ReadingLightNovelApplication
{
    partial class FormComment
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbAvt = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 24);
            this.panel1.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoSize = true;
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Panel1.Controls.Add(this.btnDelete);
            this.guna2Panel1.Controls.Add(this.lblComment);
            this.guna2Panel1.Controls.Add(this.lblUserName);
            this.guna2Panel1.Controls.Add(this.panel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 24);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(950, 77);
            this.guna2Panel1.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(884, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(38, 34);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.Location = new System.Drawing.Point(105, 43);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(110, 20);
            this.lblComment.TabIndex = 5;
            this.lblComment.Text = "5 lốp vào việc";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(105, 14);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(118, 20);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Wibu giấu tên";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.pbAvt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(91, 77);
            this.panel2.TabIndex = 3;
            // 
            // pbAvt
            // 
            this.pbAvt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAvt.BackColor = System.Drawing.Color.Transparent;
            this.pbAvt.BorderRadius = 30;
            this.pbAvt.FillColor = System.Drawing.Color.Transparent;
            this.pbAvt.ImageRotate = 0F;
            this.pbAvt.Location = new System.Drawing.Point(17, 9);
            this.pbAvt.Name = "pbAvt";
            this.pbAvt.Size = new System.Drawing.Size(67, 61);
            this.pbAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvt.TabIndex = 4;
            this.pbAvt.TabStop = false;
            // 
            // FormComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(950, 101);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormComment";
            this.Text = "FormComment";
            this.Load += new System.EventHandler(this.FormComment_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2PictureBox pbAvt;
        private System.Windows.Forms.Button btnDelete;
    }
}