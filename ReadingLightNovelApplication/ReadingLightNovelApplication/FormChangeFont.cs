using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ReadingLightNovelApplication
{
    public partial class FormChangeFont : Form
    {
        SupportMethod dataload = new SupportMethod();
        Color bg;
        public FormChangeFont(Color c)
        {
            InitializeComponent();
            bg = c;
        }

        private void btncolor1_Click(object sender, EventArgs e)
        {
            FormMainReading fm = dataload.getFormParent(this, "FormMainReading") as FormMainReading;
            fm.setClick(false);
            this.BackColor = Color.White;
            fm.BackColor = Color.White;
            fm.setBackColorButton(Color.White);
            fm.ForeColor = Color.Black;
            this.Close();
        }

        private void btncolor2_Click(object sender, EventArgs e)
        {
            FormMainReading fm = dataload.getFormParent(this, "FormMainReading") as FormMainReading;
            fm.setClick(false);
            this.BackColor = Color.FromArgb(230, 240, 230);
            fm.BackColor = Color.FromArgb(230, 240, 230);
            fm.setBackColorButton(Color.FromArgb(230, 240, 230));
            fm.ForeColor = Color.Black;
            this.Close();
        }

        private void btncolor3_Click(object sender, EventArgs e)
        {
            FormMainReading fm = dataload.getFormParent(this, "FormMainReading") as FormMainReading;
            fm.setClick(false);
            this.BackColor = Color.FromArgb(227, 245, 250);
            fm.BackColor = Color.FromArgb(227, 245, 250);
            fm.setBackColorButton(Color.FromArgb(227, 245, 250));
            fm.ForeColor = Color.Black;
            this.Close();
        }

        private void btncolor4_Click(object sender, EventArgs e)
        {
            FormMainReading fm = dataload.getFormParent(this, "FormMainReading") as FormMainReading;
            fm.setClick(false);
            this.BackColor = Color.FromArgb(246, 244, 236);
            fm.BackColor = Color.FromArgb(246, 244, 236);
            fm.setBackColorButton(Color.FromArgb(246, 244, 236));
            fm.ForeColor = Color.Black;
            this.Close();
        }

        private void btncolor5_Click(object sender, EventArgs e)
        {
             FormMainReading fm = dataload.getFormParent(this, "FormMainReading") as FormMainReading;
            fm.setClick(false);
            this.BackColor = Color.FromArgb(234, 228, 211);
            fm.BackColor = Color.FromArgb(234, 228, 211);
            fm.setBackColorButton(Color.FromArgb(234, 228, 211));
            fm.ForeColor = Color.Black;
            this.Close();
        }

        private void btncolor6_Click(object sender, EventArgs e)
        {
            FormMainReading fm = dataload.getFormParent(this, "FormMainReading") as FormMainReading;
            fm.setClick(false);
            this.BackColor = Color.Gray;
            fm.BackColor = Color.Gray;
            fm.setBackColorButton(Color.Gray);
            fm.ForeColor = Color.White;
            this.Close();
        }

        private void FormChangeFont_Load(object sender, EventArgs e)
        {
            BackColor = bg;
        }

        

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            FormMainReading fm = dataload.getFormParent(this, "FormMainReading") as FormMainReading;
            try
            {
                fm.getlbContent().Font = new Font(cbFont.Text, cbFontSize.SelectedIndex, FontStyle.Regular);
            }
            catch {
                fm.getlbContent().Font = new Font("Time New Roman", 11, FontStyle.Regular);
            }
            fm.setClick(false);
            this.Close();
        }

        
    }
}
