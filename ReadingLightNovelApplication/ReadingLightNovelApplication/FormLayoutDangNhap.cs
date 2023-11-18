using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingLightNovelApplication
{
	public partial class FormLayoutDangNhap : Form
	{
		private Form activeForm = null;
		SupportMethod SupportMethod = new SupportMethod();
		FormMain FormMain = null;

        public Form getactive()
        {
            return activeForm;
        }

        public FormLayoutDangNhap()
		{
			InitializeComponent();

		}

		private void FormLayoutDangNhap_Load(object sender, EventArgs e)
		{
			SupportMethod.openChildFormDockTop(this.activeForm, new FormDienDangNhap(), this.panelNoiDungDangNhap);

		}

		private void guna2Button3_Click(object sender, EventArgs e)
		{
            btnDangKi.BackColor = SystemColors.Control;
            btnDangNhap.BackColor = Color.SeaGreen;
            foreach (Control c in panelNoiDungDangNhap.Controls)
            {
                c.Dispose();
            }
            SupportMethod.openChildFormDockTop(this.activeForm, new FormDienDangNhap(), this.panelNoiDungDangNhap);
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
			btnDangNhap.BackColor = SystemColors.Control;
			btnDangKi.BackColor = Color.SeaGreen;
			foreach(Control c in panelNoiDungDangNhap.Controls)
			{
				c.Dispose();
			}
            SupportMethod.openChildFormDockTop(this.activeForm, new FormDienDangKy(), this.panelNoiDungDangNhap);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FormMain formMain = SupportMethod.getFormMain(this) as FormMain;
            Panel panel1 = SupportMethod.getPanel(formMain, "panelMain");
            SupportMethod.openChildFormDockFill(formMain.getactive(), new FormMain(), panel1);
        }
    }
}
