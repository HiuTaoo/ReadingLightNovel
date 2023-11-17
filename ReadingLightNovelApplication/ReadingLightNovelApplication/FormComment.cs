using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingLightNovelApplication
{
    public partial class FormComment : Form
    {
        SupportMethod dataload = new SupportMethod();
        string ma = "";
        public FormComment(string macmt)
        {
            InitializeComponent();
            ma = macmt;
        }

        private void FormComment_Load(object sender, EventArgs e)
        {
            DataTable dt = dataload.DataReader("select * " +
                "\r\nfrom BinhLuan inner join [User] on [User].TenDangNhap = BinhLuan.TenDangNhap" +
                "\r\nwhere BinhLuan.MaBinhLuan = '" + ma +"'");
            lblUserName.Text = dt.Rows[0]["TenDangNhap"].ToString();
            lblComment.Text = dt.Rows[0]["NoiDung"].ToString();
            System.Drawing.Image image = System.Drawing.Image.FromFile(Application.StartupPath + "\\Asset\\User\\"
                    + dt.Rows[0]["AnhDaiDien"].ToString());
            pbAvt.Image = image;

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa bình luận này?", "Yes/No", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            dataload.DataReader("delete from BinhLuan where MaBinhLuan = '" + ma + "'");

        }
    }
}
