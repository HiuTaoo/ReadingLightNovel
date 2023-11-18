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
                            "VALUES (N'"+tbUserName.Text+"', N'"+tbPassword.Text+"',0,'"+ ngayHomNay.ToString() +"', N'"+tbEmail.Text+"')");

                    }
                    
                    
                }
            }
            
                       
            
        }
    }
}
