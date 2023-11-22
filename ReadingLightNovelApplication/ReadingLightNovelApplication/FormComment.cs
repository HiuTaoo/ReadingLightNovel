using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.NetworkInformation;
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
            
            try {
                System.Drawing.Image image = System.Drawing.Image.FromFile(Application.StartupPath + "\\Asset\\User\\"
                    + dt.Rows[0]["AnhDaiDien"].ToString());
                pbAvt.Image = image;
            }
            catch {
                Image image = Image.FromFile(Application.StartupPath + "\\Asset\\DataLightNovel\\noLoadUser.png"
                           );
                pbAvt.Image = image;
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa bình luận này?", "Yes/No", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.Yes)
            {
                dataload.DataReader("delete from BinhLuan where MaBinhLuan = '" + ma + "'");

                FormCommentArea lg = dataload.getFormParent(this, "FormCommentArea") as FormCommentArea;
                Panel panel1 = dataload.getPanel(lg, "panelCmt");
                foreach (FormComment c in panel1.Controls.OfType<FormComment>().ToList())
                {
                    c.Close();
                    c.Dispose();
                }
                panel1.Controls.Clear();

                DataTable dt7 = dataload.DataReader("select * \r\nfrom TacPham " +
                   "\r\ninner join Volume on Volume.MaTacPham = TacPham.MaTacPham" +
                   "\r\ninner join Chapter on Chapter.MaVolume = Volume.MaVolume" +
                   "\r\ninner join BinhLuan on BinhLuan.MaChapter = Chapter.MaChapter" +
                   "\r\nwhere Chapter.MaChapter = '" + lg.getMa() + "'" +
                   "order by BinhLuan.ThoiGian desc");
                foreach (DataRow dr in dt7.Rows)
                {
                    dataload.AddChildFormDockTop(new FormComment(dr["MaBinhLuan"].ToString()), panel1);
                }
                dt7.Dispose();
            }

        }
    }
}
