
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
	public partial class FormDienDangNhap : Form
	{
        SupportMethod SupportMethod = new SupportMethod();
        public FormDienDangNhap()
		{
			InitializeComponent();
		}

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {

            FormMain formMain = SupportMethod.getFormMain(this) as FormMain;
            Panel panel1 = SupportMethod.getPanel(formMain, "panelMain");
            SupportMethod.openChildFormDockFill(formMain.getactive(), new FormDatLaiMatKhauB1(), panel1);
        }

        

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '*';
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
                tbPassword.PasswordChar = '\0';
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DataTable dt = SupportMethod.DataReader("select * \r\nfrom [User]");
            if (tbUserName.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập!");
            }
            else
            {
                if (tbPassword.Text.Trim() == "")
                    MessageBox.Show("Bạn chưa nhập mật khẩu!");
                else
                {
                    DataTable dt1 = SupportMethod.DataReader("select * " +
                        "\r\nfrom [User]" +
                        "\r\nwhere [TenDangNhap] = '" + tbUserName.Text + "' and [MatKhau] = '" + tbPassword.Text + "' ");
                    if (dt1.Rows.Count == 0)
                        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                    else
                    {
                        FormMain.TenDangNhap = tbUserName.Text;
                        FormMain.isLogin = true;                      
                        FormLayoutDangNhap fl = SupportMethod.getFormParent(this, "FormLayoutDangNhap") as FormLayoutDangNhap;

                        LayoutLogged lg = SupportMethod.getFormParent(this, "LayoutLogged") as LayoutLogged;
                        lg.LoadPanel();
                        lg.setClick(false);
                        fl.Close();
                    }
                }
            }
            
            

        }
    }
}
