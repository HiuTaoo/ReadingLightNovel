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
            LayoutLogged lg = SupportMethod.getFormParent(this, "LayoutLogged") as LayoutLogged;
            
            Panel panel1 = SupportMethod.getPanel(lg, "panelNoiDung");
            foreach (Control c in panel1.Controls)
            {
                c.Dispose();
            }
            foreach (Form f in panel1.Controls)
            {
                f.Close();
                f.Dispose();
            }
            SupportMethod.AddChildFormDockFill(new FormProfile(FormMain.TenDangNhap), panel1);
            lg.setVisible();

        }

		private void btnLichSu_Click(object sender, EventArgs e)
		{
            LayoutLogged lg = SupportMethod.getFormParent(this, "LayoutLogged") as LayoutLogged;
            
            Panel panel1 = SupportMethod.getPanel(lg, "panelNoiDung");
            foreach (Control c in panel1.Controls)
            {
                c.Dispose();
            }
            SupportMethod.openChildFormDockFill(lg.getActiveForm(), new FormLichSu(), panel1);
            lg.setVisible();
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
            lg.setVisible();
        }

		private void btnDangXuat_Click(object sender, EventArgs e)
		{
            FormMain.isLogin = false;           
            LayoutLogged lg = SupportMethod.getFormParent(this, "LayoutLogged") as LayoutLogged;
            lg.setVisible();
            lg.LoadPanel();
            



        }
	}
}
