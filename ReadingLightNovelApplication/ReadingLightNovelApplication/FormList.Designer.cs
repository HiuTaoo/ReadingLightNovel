namespace ReadingLightNovelApplication
{
    partial class FormList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormList));
            this.panelInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.panelImg = new Guna.UI2.WinForms.Guna2Panel();
            this.panelName = new Guna.UI2.WinForms.Guna2Panel();
            this.btnImg = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panelList = new Guna.UI2.WinForms.Guna2Panel();
            this.panelInfo.SuspendLayout();
            this.panelImg.SuspendLayout();
            this.panelName.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelInfo.Controls.Add(this.panelName);
            this.panelInfo.Controls.Add(this.panelImg);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(308, 120);
            this.panelInfo.TabIndex = 0;
            // 
            // panelImg
            // 
            this.panelImg.Controls.Add(this.btnImg);
            this.panelImg.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelImg.Location = new System.Drawing.Point(0, 0);
            this.panelImg.Name = "panelImg";
            this.panelImg.Size = new System.Drawing.Size(85, 120);
            this.panelImg.TabIndex = 0;
            // 
            // panelName
            // 
            this.panelName.Controls.Add(this.lblName);
            this.panelName.Controls.Add(this.lblArtist);
            this.panelName.Controls.Add(this.lblTacGia);
            this.panelName.Controls.Add(this.guna2ImageButton2);
            this.panelName.Controls.Add(this.guna2ImageButton1);
            this.panelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelName.Location = new System.Drawing.Point(85, 0);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(223, 120);
            this.panelName.TabIndex = 1;
            // 
            // btnImg
            // 
            this.btnImg.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnImg.HoverState.ImageSize = new System.Drawing.Size(64, 96);
            this.btnImg.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnImg.ImageRotate = 0F;
            this.btnImg.ImageSize = new System.Drawing.Size(64, 96);
            this.btnImg.Location = new System.Drawing.Point(10, 13);
            this.btnImg.Name = "btnImg";
            this.btnImg.PressedState.ImageSize = new System.Drawing.Size(64, 96);
            this.btnImg.Size = new System.Drawing.Size(64, 96);
            this.btnImg.TabIndex = 0;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton1.Location = new System.Drawing.Point(15, 85);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton1.Size = new System.Drawing.Size(24, 24);
            this.guna2ImageButton1.TabIndex = 0;
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton2.Location = new System.Drawing.Point(15, 58);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton2.Size = new System.Drawing.Size(24, 24);
            this.guna2ImageButton2.TabIndex = 0;
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacGia.ForeColor = System.Drawing.Color.White;
            this.lblTacGia.Location = new System.Drawing.Point(55, 63);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(92, 19);
            this.lblTacGia.TabIndex = 1;
            this.lblTacGia.Text = "じゃき ( Jaki )";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.ForeColor = System.Drawing.Color.White;
            this.lblArtist.Location = new System.Drawing.Point(55, 90);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(43, 19);
            this.lblArtist.TabIndex = 1;
            this.lblArtist.Text = "fame";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(7, 11);
            this.lblName.MaximumSize = new System.Drawing.Size(220, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(212, 50);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "I\'m The Most Evil Support Class【Talker】And I\'ll Subdue The Strongest Clan In The " +
    "World";
            // 
            // panelList
            // 
            this.panelList.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelList.Location = new System.Drawing.Point(0, 120);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(308, 621);
            this.panelList.TabIndex = 1;
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(308, 1000);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.panelInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormList";
            this.Text = "FormListButton";
            this.panelInfo.ResumeLayout(false);
            this.panelImg.ResumeLayout(false);
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelInfo;
        private Guna.UI2.WinForms.Guna2Panel panelName;
        private Guna.UI2.WinForms.Guna2Panel panelImg;
        private Guna.UI2.WinForms.Guna2ImageButton btnImg;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblTacGia;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2Panel panelList;
    }
}