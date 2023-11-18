using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ReadingLightNovelApplication
{
    public partial class FormMainReading : Form
    {
        SupportMethod dataload = new SupportMethod();
        string ma, ngay;
        public FormMainReading(string matacpham, string ngaydang)
        {
            InitializeComponent();
            ma = matacpham;
            ngay = ngaydang;
        }

       

        private void FormMainReading_Load(object sender, EventArgs e)
        {
            DataTable dt = dataload.DataReader("select *" +
                " \r\nfrom Chapter inner join Volume on Volume.MaVolume = Chapter.MaVolume" +
                "\r\ninner join TacPham on TacPham.MaTacPham = Volume.MaTacPham" +
                "\r\nwhere Chapter.TenChapter = N'" + ma +"' " +
                "and Chapter.ThoiGianDang = '" + ngay +"'");
            btnVolName.Text = dt.Rows[0]["TenVolume"].ToString();
            btnChapterName.Text = dt.Rows[0]["TenChapter"].ToString();

            DataTable dt1 = dataload.DataReader("select count(BinhLuan.MaBinhLuan) " +
                "\r\nfrom Chapter inner join Volume on Volume.MaVolume = Chapter.MaVolume" +
                "\r\ninner join BinhLuan on BinhLuan.MaChapter = Chapter.MaChapter" +
                "\r\nwhere Chapter.TenChapter = N'" + ma +"' " +
                "and Chapter.ThoiGianDang = '" + ngay + "'");

            DataTable dt2 = dataload.DataReader("DECLARE @StartDate DATE = '" + ngay + "'" +
                "\r\nDECLARE @EndDate DATE = GETDATE();  -- Ngày hiện tại" +
                "\r\n\r\nDECLARE @DateDiff INT = DATEDIFF(DAY, @StartDate, @EndDate);" +
                "\r\n\r\nSELECT\r\n    CASE\r\n        " +
                "WHEN @DateDiff < 30 THEN  CAST(@DateDiff AS NVARCHAR(10)) +  N' Ngày' \r\n        " +
                "WHEN @DateDiff < 365 THEN + CAST(@DateDiff / 30 AS NVARCHAR(10)) +  N' Tháng' \r\n        " +
                "ELSE CAST(@DateDiff / 365 AS NVARCHAR(10)) +  N' Năm' \r\n    END AS Result;");

            int t = dataload.CountWordsFromFile(Application.StartupPath + "\\Asset\\DataLightNovel\\"
                        + dt.Rows[0]["MaTacPham"].ToString() + "\\" + dt.Rows[0]["TenVolume"].ToString() + "\\" + dt.Rows[0]["Nguon"].ToString());

            btnDetail.Text = dt1.Rows[0][0].ToString() + " Bình luận - " + t.ToString() + " Từ - " + dt2.Rows[0][0].ToString();
            dt2.Dispose();
            dt1.Dispose();
            string urlContent = Application.StartupPath + "\\Asset\\DataLightNovel\\"
                        + dt.Rows[0]["MaTacPham"].ToString() + "\\" + dt.Rows[0]["TenVolume"].ToString() + "\\" + dt.Rows[0]["Nguon"].ToString();
            lbContent.Text = dataload.loadContent(urlContent);

            DataTable dt3 = dataload.DataReader("select TacPham.MaTacPham " +
                "\r\nfrom Chapter inner join Volume on Volume.MaVolume = Chapter.MaVolume" +
                "\r\ninner join TacPham on TacPham.MaTacPham = Volume.MaTacPham" +
               "\r\nwhere Chapter.TenChapter = N'" + ma + "' " +
                "and Chapter.ThoiGianDang = '" + ngay + "'");

            dataload.AddChildFormDockTop(new FormCommentArea(dt3.Rows[0]["MaTacPham"].ToString()), this.panelCmt);

        }

        

        
    }
}
