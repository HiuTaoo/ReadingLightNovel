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
	public partial class FormDienDangKy : Form
	{
        SupportMethod SupportMethod = new SupportMethod();
        public FormDienDangKy()
		{
			InitializeComponent();
		}

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            DateTime ngayHomNay = DateTime.Today;
            DataTable dt = SupportMethod.DataReader("select * \r\nfrom [User]");
            if (tbUserName.Text.Trim() == "")
                MessageBox.Show("Tên đăng nhập không thể để trống!");
            else
            {
                if (tbEmail.Text.Trim() == "")
                    MessageBox.Show("Email không thể để trống!");
                else
                {
                    if (tbPassword.Text.Trim() == "")
                        MessageBox.Show("Mật khẩu không thể để trống!");

                    else {
                        if (tbXacNhan.Text.Trim() == "")
                            MessageBox.Show("Cần xác nhận lại mật khẩu!");
                        else if (tbPassword.Text.Trim() != tbXacNhan.Text.Trim())
                        {
                            MessageBox.Show("Xác nhận mật khẩu không chính xác!");
                        }
                        SupportMethod.DataChange("INSERT [dbo].[User] ([TenDangNhap] ,[MatKhau],[TrangThai],[NgayTao], [Email]) " +
                            "VALUES (N'" + tbUserName.Text + "', N'" + tbPassword.Text + "',0,'" + ngayHomNay.ToString() + "', N'" + tbEmail.Text + "')");

                        FormMain formMain = SupportMethod.getFormMain(this) as FormMain;
                        Panel panel1 = SupportMethod.getPanel(formMain, "panelMain");
                        /*LayoutLogged lg = new LayoutLogged();
                        SupportMethod.AddChildFormDockFill(lg, "panelNoiDung");*/

                        LayoutLogged lg = new LayoutLogged();
                        SupportMethod.openChildFormDockFill(formMain.getactive(), lg, panel1);
                        Panel panel2 = SupportMethod.getPanel(lg, "panelNoiDung");

                        SupportMethod.AddChildFormDockFill(new FormLayoutDangNhap(), panel2);

                        /*FormLayoutDangNhap ldn = SupportMethod.getFormParent(this, "FormLayoutDangNhap") as FormLayoutDangNhap;
                        Panel panel1 = SupportMethod.getPanel(ldn, "panelDangKi");
                        ldn.setColor();
                        this.Dispose();
                        this.Close();
                        SupportMethod.AddChildFormDockTop(new FormDienDangNhap(), panel1);*/






                    }
                    
                    
                }
            }
            
                       
            
        }
    }
}
