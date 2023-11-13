namespace ReadingLightNovelApplication
{
    partial class FormContent
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
            this.panelContent = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelContent.AutoSize = true;
            this.panelContent.Location = new System.Drawing.Point(145, -89);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(952, 628);
            this.panelContent.TabIndex = 1;
            // 
            // FormContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1242, 628);
            this.Controls.Add(this.panelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormContent";
            this.Text = "FormContent";
            this.Load += new System.EventHandler(this.FormContent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelContent;
    }
}