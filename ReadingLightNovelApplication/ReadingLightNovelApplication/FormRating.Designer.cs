namespace ReadingLightNovelApplication
{
    partial class FormRating
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
            this.cbRating = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnRating = new Guna.UI2.WinForms.Guna2Button();
            this.tbRating = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbRating
            // 
            this.cbRating.BackColor = System.Drawing.Color.Transparent;
            this.cbRating.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRating.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRating.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRating.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbRating.ItemHeight = 30;
            this.cbRating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbRating.Location = new System.Drawing.Point(12, 0);
            this.cbRating.Name = "cbRating";
            this.cbRating.Size = new System.Drawing.Size(180, 36);
            this.cbRating.TabIndex = 0;
            // 
            // btnRating
            // 
            this.btnRating.BorderRadius = 10;
            this.btnRating.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRating.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRating.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRating.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRating.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(161)))), ((int)(((byte)(137)))));
            this.btnRating.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRating.ForeColor = System.Drawing.Color.White;
            this.btnRating.Location = new System.Drawing.Point(24, 42);
            this.btnRating.Name = "btnRating";
            this.btnRating.Size = new System.Drawing.Size(156, 34);
            this.btnRating.TabIndex = 2;
            this.btnRating.Text = "Đánh giá";
            this.btnRating.Click += new System.EventHandler(this.btnRating_Click);
            // 
            // tbRating
            // 
            this.tbRating.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbRating.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRating.Location = new System.Drawing.Point(221, 0);
            this.tbRating.Multiline = true;
            this.tbRating.Name = "tbRating";
            this.tbRating.Size = new System.Drawing.Size(479, 100);
            this.tbRating.TabIndex = 3;
            // 
            // FormRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 100);
            this.Controls.Add(this.tbRating);
            this.Controls.Add(this.btnRating);
            this.Controls.Add(this.cbRating);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRating";
            this.Text = "FormRating";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbRating;
        private Guna.UI2.WinForms.Guna2Button btnRating;
        private System.Windows.Forms.TextBox tbRating;
    }
}