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

        public void setColor()
        {
            btnDangNhap.BackColor = SystemColors.Control;
            btnDangNhap.ForeColor = Color.Black;
            btnDangKi.BackColor = Color.SeaGreen;
            btnDangKi.ForeColor = Color.White;
        }

		private void FormLayoutDangNhap_Load(object sender, EventArgs e)
		{
			SupportMethod.openChildFormDockTop(this.activeForm, new FormDienDangNhap(), this.panelNoiDungDangNhap);

		}

		private void guna2Button3_Click(object sender, EventArgs e)
		{
            btnDangKi.BackColor = SystemColors.Control;
            btnDangKi.ForeColor = Color.Black;
            btnDangNhap.BackColor = Color.SeaGreen;
            btnDangNhap.ForeColor = Color.White;
            foreach (Control c in panelNoiDungDangNhap.Controls)
            {
                c.Dispose();
            }
            SupportMethod.openChildFormDockTop(this.activeForm, new FormDienDangNhap(), this.panelNoiDungDangNhap);
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
			btnDangNhap.BackColor = SystemColors.Control;
            btnDangNhap.ForeColor = Color.Black;
			btnDangKi.BackColor = Color.SeaGreen;
            btnDangKi.ForeColor = Color.White;
			foreach(Control c in panelNoiDungDangNhap.Controls)
			{
				c.Dispose();
			}
            SupportMethod.openChildFormDockTop(this.activeForm, new FormDienDangKy(), this.panelNoiDungDangNhap);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            LayoutLogged lg = SupportMethod.getFormParent(this, "LayoutLogged") as LayoutLogged;
            lg.setClick(false);
            this.Close();
        }
    }
}
