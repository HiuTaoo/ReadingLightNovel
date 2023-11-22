namespace ReadingLightNovelApplication
{
    partial class FormProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfile));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUserName = new System.Windows.Forms.Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbAvt = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pbImg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnCountBL = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.btnCountFL = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCountChapter = new System.Windows.Forms.Button();
            this.btnDate = new System.Windows.Forms.Button();
            this.panelTruyenDaDang = new Guna.UI2.WinForms.Guna2Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCount = new System.Windows.Forms.Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTruyenDaDang.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnUserName);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Location = new System.Drawing.Point(50, 40);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1160, 408);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnUserName
            // 
            this.btnUserName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUserName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUserName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserName.Location = new System.Drawing.Point(0, 365);
            this.btnUserName.Name = "btnUserName";
            this.btnUserName.Size = new System.Drawing.Size(1160, 43);
            this.btnUserName.TabIndex = 1;
            this.btnUserName.Text = "HiuTao";
            this.btnUserName.UseVisualStyleBackColor = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel2.BorderRadius = 1;
            this.guna2Panel2.Controls.Add(this.panel1);
            this.guna2Panel2.Controls.Add(this.pbImg);
            this.guna2Panel2.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1154, 364);
            this.guna2Panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbAvt);
            this.panel1.Location = new System.Drawing.Point(488, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 179);
            this.panel1.TabIndex = 0;
            // 
            // pbAvt
            // 
            this.pbAvt.ImageRotate = 0F;
            this.pbAvt.Location = new System.Drawing.Point(23, 10);
            this.pbAvt.Name = "pbAvt";
            this.pbAvt.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbAvt.Size = new System.Drawing.Size(140, 125);
            this.pbAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvt.TabIndex = 0;
            this.pbAvt.TabStop = false;
            // 
            // pbImg
            // 
            this.pbImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImg.ImageRotate = 0F;
            this.pbImg.Location = new System.Drawing.Point(0, 0);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(1154, 364);
            this.pbImg.TabIndex = 1;
            this.pbImg.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "calendar.png");
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Panel3.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.panel4);
            this.guna2Panel3.Controls.Add(this.panel3);
            this.guna2Panel3.Controls.Add(this.panel2);
            this.guna2Panel3.Controls.Add(this.btnDate);
            this.guna2Panel3.Location = new System.Drawing.Point(50, 460);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1160, 208);
            this.guna2Panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.btnCountBL);
            this.panel4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(475, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 110);
            this.panel4.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(0, 47);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(233, 63);
            this.button5.TabIndex = 2;
            this.button5.Text = "Bình luận";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnCountBL
            // 
            this.btnCountBL.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCountBL.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountBL.Location = new System.Drawing.Point(0, 0);
            this.btnCountBL.Name = "btnCountBL";
            this.btnCountBL.Size = new System.Drawing.Size(233, 47);
            this.btnCountBL.TabIndex = 1;
            this.btnCountBL.Text = "10";
            this.btnCountBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCountBL.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.btnCountFL);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(884, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 110);
            this.panel3.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Location = new System.Drawing.Point(0, 47);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(233, 63);
            this.button7.TabIndex = 2;
            this.button7.Text = "Đang theo dõi";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btnCountFL
            // 
            this.btnCountFL.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCountFL.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountFL.Location = new System.Drawing.Point(0, 0);
            this.btnCountFL.Name = "btnCountFL";
            this.btnCountFL.Size = new System.Drawing.Size(233, 47);
            this.btnCountFL.TabIndex = 1;
            this.btnCountFL.Text = "50";
            this.btnCountFL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCountFL.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnCountChapter);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(40, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 110);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(0, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 63);
            this.button3.TabIndex = 1;
            this.button3.Text = "Chương đã đăng";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnCountChapter
            // 
            this.btnCountChapter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCountChapter.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountChapter.Location = new System.Drawing.Point(0, 0);
            this.btnCountChapter.Name = "btnCountChapter";
            this.btnCountChapter.Size = new System.Drawing.Size(233, 47);
            this.btnCountChapter.TabIndex = 0;
            this.btnCountChapter.Text = " 0";
            this.btnCountChapter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCountChapter.UseVisualStyleBackColor = true;
            // 
            // btnDate
            // 
            this.btnDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDate.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDate.ImageIndex = 0;
            this.btnDate.ImageList = this.imageList1;
            this.btnDate.Location = new System.Drawing.Point(0, 159);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(1160, 49);
            this.btnDate.TabIndex = 0;
            this.btnDate.Text = "Ngày tham gia: ";
            this.btnDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDate.UseVisualStyleBackColor = true;
            // 
            // panelTruyenDaDang
            // 
            this.panelTruyenDaDang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelTruyenDaDang.AutoSize = true;
            this.panelTruyenDaDang.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTruyenDaDang.BorderColor = System.Drawing.Color.Gray;
            this.panelTruyenDaDang.BorderThickness = 1;
            this.panelTruyenDaDang.Controls.Add(this.panel5);
            this.panelTruyenDaDang.Location = new System.Drawing.Point(50, 681);
            this.panelTruyenDaDang.Name = "panelTruyenDaDang";
            this.panelTruyenDaDang.Size = new System.Drawing.Size(1160, 223);
            this.panelTruyenDaDang.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.btnCount);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1160, 52);
            this.panel5.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Truyện đã đăng";
            // 
            // btnCount
            // 
            this.btnCount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCount.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCount.Location = new System.Drawing.Point(0, 0);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(56, 52);
            this.btnCount.TabIndex = 0;
            this.btnCount.Text = "0";
            this.btnCount.UseVisualStyleBackColor = false;
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1260, 1102);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelTruyenDaDang);
            this.Controls.Add(this.guna2Panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProfile";
            this.Text = "FormProfile";
            this.Load += new System.EventHandler(this.FormProfile_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelTruyenDaDang.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnUserName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnCountBL;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnCountFL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCountChapter;
        private Guna.UI2.WinForms.Guna2Panel panelTruyenDaDang;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox pbImg;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbAvt;
    }
}