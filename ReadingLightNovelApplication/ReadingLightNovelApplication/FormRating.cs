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
    public partial class FormRating : Form
    {
        string matp;
        SupportMethod dataload = new SupportMethod();
        public FormRating(string Matacpham)
        {
            InitializeComponent();
            matp = Matacpham;
        }

        private void btnRating_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DataTable dt = dataload.DataReader(" select count(BinhChon.MaBinhChon)" +
                "\r\n from TacPham inner join BinhChon on BinhChon.MaTacPham = TacPham.MaTacPham" +
                "\r\n where TacPham.MaTacPham = '"+ matp +"'");
            dataload.DataChange(" INSERT [dbo].[BinhChon] ([MaBinhChon], [TenDangNhap], [MaTacPham], [Diem], [NoiDung]) " +
                "\r\n VALUES (N'BC" + now.ToString() +"', N'"+ FormMain.TenDangNhap +"', N'"+ matp +"', "+ cbRating.Text.ToString()+", N'"+ tbRating.Text +"')");

            FormProperties pf = dataload.getFormParent(this, "FormProperties") as FormProperties;
            DataTable dt3 = dataload.DataReader("SELECT ROUND(SUM(BinhChon.Diem) / COUNT(BinhChon.MaBinhChon), 2) AS DiemTrungBinh " +
            "FROM TacPham INNER JOIN TacGia ON TacGia.MaTacGia = TacPham.MaTacGia " +
            "INNER JOIN BinhChon ON TacPham.MaTacPham = BinhChon.MaTacPham " +
            "WHERE TacPham.MaTacPham = '" + matp + "'");
            pf.GetlvlRating().Text = dt3.Rows[0][0].ToString() + "/5";
            MessageBox.Show("Bạn đã đánh giá thành công truyện này!");
            this.Close();
            this.Dispose();

        }
    }
}
