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
using System.Xml.Linq;

namespace ReadingLightNovelApplication
{
    public partial class FormProperties : Form
    {
        SupportMethod dataload = new SupportMethod();
        string MaTacPham;
        private Form activeForm = null;

        public FormProperties(string MaTacPham)
        {
            InitializeComponent();
            this.MaTacPham = MaTacPham;
            loadData(MaTacPham);
        }
        public void loadData(string ma)
        {
            DataTable dtTruyen = dataload.DataReader("select * \r\nfrom TacPham inner join TacGia on TacGia.MaTacGia =TacPham.MaTacGia" +
                "\r\nwhere TacPham.MaTacPham = N'" + ma + "'");

            if (dtTruyen.Rows.Count > 0)
            {
                lblTenTruyen.Text = dtTruyen.Rows[0]["TenTacPham"].ToString();
                Image image = Image.FromFile(Application.StartupPath + "\\Asset\\DataLightNovel\\" 
                    + dtTruyen.Rows[0]["MaTacPham"].ToString() + "\\" + dtTruyen.Rows[0]["Anh"].ToString());
                btnAnh.Image = image;
                lblAnotherName.Text = dtTruyen.Rows[0]["TenKhac"].ToString();
                lblTomTat.Text = dtTruyen.Rows[0]["TomTat"].ToString();
                lblTacGia.Text = dtTruyen.Rows[0]["TenTacGia"].ToString();
                lblStatus.Text = dtTruyen.Rows[0]["TinhTrang"].ToString();

                DataTable dt1 = dataload.DataReader("DECLARE @StartDate DATE = (select ThoiGianTao \r\nfrom TacPham inner join TacGia on TacGia.MaTacGia =TacPham.MaTacGia\r\nwhere TacPham.MaTacPham = '"+ ma + "');\r\nDECLARE @EndDate DATE = GETDATE();  -- Ngày hiện tại\r\n\r\nDECLARE @DateDiff INT = DATEDIFF(DAY, @StartDate, @EndDate);\r\n\r\nSELECT\r\n    CASE\r\n        WHEN @DateDiff < 30 THEN  CAST(@DateDiff AS NVARCHAR(10)) +  N' Ngày' \r\n        WHEN @DateDiff < 365 THEN + CAST(@DateDiff / 30 AS NVARCHAR(10)) +  N' Tháng' \r\n        ELSE CAST(@DateDiff / 365 AS NVARCHAR(10)) +  N' Năm' \r\n    END AS Result;");
                lblLastUpdate.Text = dt1.Rows[0][0].ToString();

                //lblSoTu.Text = dataload.CountWordsInDocx("Application.StartupPath + \"\\\\Asset\\\\DataLightNovel\\\\\" \r\n                    + dtTruyen.Rows[0][\"MaTacPham\"].ToString() + \"\\\\\" + dtTruyen.Rows[0][\"Anh\"].ToString()").ToString();

                DataTable dt2 = dataload.DataReader("select Volume.MaVolume " +
                    "\r\nfrom TacPham inner join Volume on Volume.MaTacPham = TacPham.MaTacPham" +
                    "\r\nwhere TacPham.MaTacPham = '" + ma +"'");
                for(int i = 0; i < dt2.Rows.Count ; i++ )
                {
                    dataload.AddChildFormDockTop( new FormListVol(dt2.Rows[i]["MaVolume"].ToString()), this.panelListVol);
                }

            }
            
            DataTable dt3 = dataload.DataReader("select sum(BinhChon.Diem)/count(BinhChon.MaBinhChon)" +
                "\r\nfrom TacPham inner join TacGia on TacGia.MaTacGia =TacPham.MaTacGia" +
                "\r\ninner join BinhChon on TacPham.MaTacPham = BinhChon.MaTacPham" +
                "\r\nwhere TacPham.MaTacPham = '" + ma +"'");
            lvlRating.Text = dt3.Rows[0][0].ToString() + "/5";

            DataTable dt4 = dataload.DataReader("select sum(Chapter.LuotXem)" +
                "\r\nfrom Volume full outer join Chapter on Chapter.MaVolume = Volume.MaVolume" +
                "\r\nfull outer join TacPham on TacPham.MaTacPham = Volume.MaTacPham" +
                "\r\nwhere TacPham.MaTacPham = '"+ ma +"' ");
            lblView.Text = dt4.Rows[0][0].ToString();

            DataTable dt5 = dataload.DataReader("select * \r\nfrom TacPham inner join TacGia on TacGia.MaTacGia =TacPham.MaTacGia" +
                "\r\ninner join ChiTietTheLoai on ChiTietTheLoai.MaTacPham = TacPham.MaTacPham" +
                "\r\ninner join TheLoai on ChiTietTheLoai.MaTheLoai = TheLoai.MaTheLoai" +
                "\r\nwhere TacPham.MaTacPham = '" + ma +"'");
            for (int i = 0; i < dt5.Rows.Count; i++)
            {
                 Guna2Button btn = new Guna2Button();
                btn.Name = "TL" + i.ToString();
                btn.Text = dt5.Rows[i]["TenTheLoai"].ToString();
                btn.BorderRadius = 10;
                btn.AutoSize = true;
                btn.FillColor = Color.WhiteSmoke;
                btn.ForeColor = Color.Black;
                btn.Font = new Font("Time New Roman", btn.Font.Size, btn.Font.Style );
                btn.BorderColor = Color.Gray;
                btn.BorderThickness = 1;
                panelTheLoai.Controls.Add(btn);
            }
        }

        

        private void btnRead_Click(object sender, EventArgs e)
        {

        }

        private void FormProperties_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
