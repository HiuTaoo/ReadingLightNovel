namespace ReadingLightNovelApplication
{
    partial class FormListVol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListVol));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.lvChapter = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelImg = new System.Windows.Forms.Panel();
            this.imgVol = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTenVol = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panelDetail.SuspendLayout();
            this.panelImg.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 14);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.panelDetail);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(2, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 300);
            this.panel2.TabIndex = 1;
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.lvChapter);
            this.panelDetail.Controls.Add(this.panelImg);
            this.panelDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetail.Location = new System.Drawing.Point(0, 42);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(949, 236);
            this.panelDetail.TabIndex = 1;
            // 
            // lvChapter
            // 
            this.lvChapter.BackColor = System.Drawing.SystemColors.Control;
            this.lvChapter.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvChapter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvChapter.FullRowSelect = true;
            this.lvChapter.GridLines = true;
            this.lvChapter.HideSelection = false;
            this.lvChapter.Location = new System.Drawing.Point(170, 0);
            this.lvChapter.Name = "lvChapter";
            this.lvChapter.Size = new System.Drawing.Size(779, 236);
            this.lvChapter.TabIndex = 1;
            this.lvChapter.UseCompatibleStateImageBehavior = false;
            this.lvChapter.View = System.Windows.Forms.View.Details;
            this.lvChapter.DoubleClick += new System.EventHandler(this.lvChapter_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Danh sách chương";
            this.columnHeader1.Width = 249;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày đăng";
            this.columnHeader2.Width = 94;
            // 
            // panelImg
            // 
            this.panelImg.Controls.Add(this.imgVol);
            this.panelImg.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelImg.Location = new System.Drawing.Point(0, 0);
            this.panelImg.Name = "panelImg";
            this.panelImg.Size = new System.Drawing.Size(170, 236);
            this.panelImg.TabIndex = 0;
            // 
            // imgVol
            // 
            this.imgVol.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgVol.HoverState.ImageSize = new System.Drawing.Size(144, 196);
            this.imgVol.Image = ((System.Drawing.Image)(resources.GetObject("imgVol.Image")));
            this.imgVol.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgVol.ImageRotate = 0F;
            this.imgVol.ImageSize = new System.Drawing.Size(144, 196);
            this.imgVol.Location = new System.Drawing.Point(10, 16);
            this.imgVol.Name = "imgVol";
            this.imgVol.PressedState.ImageSize = new System.Drawing.Size(144, 196);
            this.imgVol.Size = new System.Drawing.Size(144, 196);
            this.imgVol.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTenVol);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(949, 42);
            this.panel3.TabIndex = 0;
            // 
            // lblTenVol
            // 
            this.lblTenVol.AutoSize = true;
            this.lblTenVol.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenVol.Location = new System.Drawing.Point(20, 12);
            this.lblTenVol.Name = "lblTenVol";
            this.lblTenVol.Size = new System.Drawing.Size(190, 20);
            this.lblTenVol.TabIndex = 0;
            this.lblTenVol.Text = "Act1: Hắc hiệp sĩ bí ẩn ";
            // 
            // FormListVol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 300);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListVol";
            this.Text = "FormListVol";
            this.Load += new System.EventHandler(this.FormListVol_Load);
            this.panel2.ResumeLayout(false);
            this.panelDetail.ResumeLayout(false);
            this.panelImg.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTenVol;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.ListView lvChapter;
        private System.Windows.Forms.Panel panelImg;
        private Guna.UI2.WinForms.Guna2ImageButton imgVol;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}