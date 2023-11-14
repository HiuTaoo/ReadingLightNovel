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
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.pbAvt = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbAvt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(91, 69);
            this.panel1.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(115, 10);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(118, 20);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Wibu giấu tên";
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.Location = new System.Drawing.Point(117, 37);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(110, 20);
            this.lblComment.TabIndex = 2;
            this.lblComment.Text = "5 lốp vào việc";
            // 
            // pbAvt
            // 
            this.pbAvt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAvt.BackColor = System.Drawing.Color.Transparent;
            this.pbAvt.BorderRadius = 30;
            this.pbAvt.FillColor = System.Drawing.Color.Transparent;
            this.pbAvt.Image = global::ReadingLightNovelApplication.Properties.Resources._274033549_1108566083289066_6781424345818665545_n;
            this.pbAvt.ImageRotate = 0F;
            this.pbAvt.InitialImage = global::ReadingLightNovelApplication.Properties.Resources._274033549_1108566083289066_6781424345818665545_n;
            this.pbAvt.Location = new System.Drawing.Point(17, 9);
            this.pbAvt.Name = "pbAvt";
            this.pbAvt.Size = new System.Drawing.Size(67, 53);
            this.pbAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvt.TabIndex = 4;
            this.pbAvt.TabStop = false;
            // 
            // FormComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(950, 69);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormComment";
            this.Text = "FormComment";
            this.Load += new System.EventHandler(this.FormComment_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblComment;
        private Guna.UI2.WinForms.Guna2PictureBox pbAvt;
    }
}