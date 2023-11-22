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
	public partial class FormUserButton : Form
	{
		SupportMethod SupportMethod = new SupportMethod();
		string tendn;
		public FormUserButton(string tendangnhap)
		{
			InitializeComponent();
			tendn = tendangnhap;
		}

		private void btnTaiKhoan_Click(object sender, EventArgs e)
		{
			FormMain formMain = SupportMethod.getFormMain(this) as FormMain;
			Panel panel1 = SupportMethod.getPanel(formMain, "panelMain");
			SupportMethod.openChildFormDockFill(formMain.getactive(), new FormProfile(tendn), panel1);
		}

		private void btnLichSu_Click(object sender, EventArgs e)
		{

		}

		private void btnKeSach_Click(object sender, EventArgs e)
		{
			LayoutLogged lg = SupportMethod.getFormParent(this, "LayoutLogged") as LayoutLogged;
			Panel panel1 = SupportMethod.getPanel(lg, "panelNoiDung");
			foreach (Control c in panel1.Controls)
			{
				c.Dispose();
			}
			SupportMethod.openChildFormDockFill(lg.getActiveForm(), new FormFollow(), panel1);
		}

		private void btnDangXuat_Click(object sender, EventArgs e)
		{

		}
	}
}
