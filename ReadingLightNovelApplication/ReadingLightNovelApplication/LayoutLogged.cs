using Guna.UI2.WinForms;
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
    public partial class LayoutLogged : Form
    {
        private Form activeForm = null;
        SupportMethod SupportMethod = new SupportMethod();
        public Boolean isclick = false;
        public LayoutLogged()
        {
            InitializeComponent();
        }
        public void setClick(Boolean a)
        {
            isclick = a;
        }

        public Form getActiveForm() { return activeForm; }


        private void LayoutLogged_Load(object sender, EventArgs e)
        {

            SupportMethod.openChildFormDockFill(this.activeForm, new FormHome(), this.panelNoiDung);
            if(FormMain.isLogin == true)
            {
                SupportMethod.AddChildFormDockFill(new FormLogin(FormMain.TenDangNhap), this.panelLogin);
            }
            else
            {
                SupportMethod.AddChildFormDockFill(new FormLogout(), this.panelLogin);
            }

            SupportMethod.AddChildFormDockTop(new FormUserButton(FormMain.TenDangNhap), panelUserButton);
            panelUserButton.Visible = false;
        }

        public void LoadPanel()
        {
            if (FormMain.isLogin == true)
            {
                foreach(Control c in panelLogin.Controls)
                {
                    c.Dispose();
                }
                SupportMethod.AddChildFormDockFill(new FormLogin(FormMain.TenDangNhap), this.panelLogin);
            }
            else
            {
                foreach (Control c in panelLogin.Controls)
                {
                    c.Dispose();
                }
                SupportMethod.AddChildFormDockFill(new FormLogout(), this.panelLogin);
            }
        }

		private void btnLogo_Click(object sender, EventArgs e)
		{
            foreach(Control control in this.panelNoiDung.Controls) 
            {
                control.Dispose();
            }          
            
            SupportMethod.AddChildFormDockFill(new FormHome(), this.panelNoiDung);
		}

		private void btnDanhSach_Click(object sender, EventArgs e)
		{
            
			foreach (Control control in this.panelNoiDung.Controls)
			{
				control.Dispose();
			}
            SupportMethod.AddChildFormDockFill(new FormSapXep(0), this.panelNoiDung);
        }

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			foreach (Control control in this.panelNoiDung.Controls)
			{
				control.Visible = false;
			}
			SupportMethod.AddChildFormDockFill(new FormTimKiem(txtTimKiem.Text), this.panelNoiDung);
		}

		private void btnTimKiem_Click_1(object sender, EventArgs e)
		{
			foreach (Control control in this.panelNoiDung.Controls)
			{
				control.Visible = false;
			}
			SupportMethod.AddChildFormDockFill(new FormTimKiem(txtTimKiem.Text), this.panelNoiDung);
		}

        public void showUserButton()
        {
            if(panelUserButton.Visible == false)
            {
				panelUserButton.Visible = true;
				panelUserButton.BringToFront();
			}
            else { panelUserButton.Visible = false; }
        }
	}
}
