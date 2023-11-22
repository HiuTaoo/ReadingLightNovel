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
    public partial class FormProfile : Form
    {
        SupportMethod SupportMethod = new SupportMethod();
        string tendn;
        public FormProfile(string tendangnhap)
        {
            InitializeComponent();
            tendn = tendangnhap;
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            btnUserName.Text = tendn;
            DataTable dt = SupportMethod.DataReader("select * " +
               "\r\nfrom [User]\r\nwhere [TenDangNhap] = '" + tendn + "'");
            try
            {
                Image image = Image.FromFile(Application.StartupPath + "\\Asset\\User\\"
                    + dt.Rows[0]["AnhDaiDien"].ToString());
                pbAvt.Image = image;
            }
            catch
            {
                Image image = Image.FromFile(Application.StartupPath + "\\Asset\\User\\noLoadUser.png");
                pbAvt.Image = image;
            }

            DataTable dt6 = SupportMethod.DataReader("select CONVERT(date,NgayTao) as Ngay " +
                "\r\nfrom [User]\r\nwhere TenDangNhap = '" + tendn + "'");
            btnDate.Text = "Ngày tham gia: " + dt6.Rows[0]["Ngay"].ToString();
            dt6.Dispose();

            DataTable dt1 = SupportMethod.DataReader("select Count(BinhLuan.MaBinhLuan)" +
                "\r\nfrom TacPham \r\ninner join Volume on Volume.MaTacPham = TacPham.MaTacPham" +
                "\r\ninner join Chapter on Chapter.MaVolume = Volume.MaVolume" +
                "\r\ninner join BinhLuan on BinhLuan.MaChapter = Chapter.MaChapter" +
                "\r\nwhere BinhLuan.TenDangNhap = N'" + tendn + "'");
            btnCountBL.Text = dt1.Rows[0][0].ToString();
            dt1.Dispose();

            DataTable dt2 = SupportMethod.DataReader("\r\nselect Count(MaYeuThich) \r\nfrom YeuThich" +
                "\r\nwhere YeuThich.TenDangNhap = N'" + tendn + "'");
            btnCountFL.Text = dt2.Rows[0][0].ToString();
            dt2.Dispose();

            DataTable dt3 = SupportMethod.DataReader("select *\r\nfrom TacPham" +
                "\r\nwhere TenDangNhap = N'" + tendn + "'");
            foreach (DataRow row in dt3.Rows)
            {
                SupportMethod.AddChildFormDockTop( new FormListNovel(row["MaTacPham"].ToString()), this.panelTruyenDaDang);
            }
            dt3.Dispose();
            DataTable dt4 = SupportMethod.DataReader("select count(MaTacPham) \r\nfrom TacPham" +
                "\r\nwhere TenDangNhap = N'" + tendn + "'");
            btnCount.Text = dt4.Rows[0][0].ToString();
            dt4.Dispose();

            DataTable dt5 = SupportMethod.DataReader("select count(Chapter.MaChapter)" +
                "\r\nfrom TacPham\r\ninner join Volume on Volume.MaTacPham = TacPham.MaTacPham" +
                "\r\ninner join Chapter on Chapter.MaVolume = Volume.MaVolume" +
                "\r\nwhere TacPham.TenDangNhap = N'" + tendn + "'");
            btnCountChapter.Text = dt5.Rows[0][0].ToString();
            dt5.Dispose();
        }

        private void pbAvt_Click(object sender, EventArgs e)
        {

        }
    }
}
