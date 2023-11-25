using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ReadingLightNovelApplication
{

    public partial class FormProperties : Form
    {
        SupportMethod dataload = new SupportMethod();
        string MaTp;
        private Form activeForm = null;

        public FormProperties(string MaTacPham)
        {
            InitializeComponent();
            MaTp = MaTacPham;
        }

        public Label GetlvlRating()
        {
            return lvlRating;
        }

        private void FormProperties_Load(object sender, EventArgs e)
        {
            DataTable dtTruyen = dataload.DataReader("select * \r\nfrom TacPham inner join TacGia on TacGia.MaTacGia =TacPham.MaTacGia" +
                "\r\nwhere TacPham.MaTacPham = N'" + MaTp + "'");

            if (dtTruyen.Rows.Count > 0)
            {
                lblTenTruyen.Text = dtTruyen.Rows[0]["TenTacPham"].ToString();
                try
                {
                    System.Drawing.Image image = System.Drawing.Image.FromFile(Application.StartupPath + "\\Asset\\DataLightNovel\\"
                    + dtTruyen.Rows[0]["MaTacPham"].ToString() + "\\" + dtTruyen.Rows[0]["Anh"].ToString());
                    btnAnh.Image = image;
                }
                catch {
                    System.Drawing.Image image = System.Drawing.Image.FromFile(Application.StartupPath + "\\Asset\\DataLightNovel\\noLoadUser.png");
                    btnAnh.Image = image;
                }
                lblAnotherName.Text = dtTruyen.Rows[0]["TenKhac"].ToString();
                lblTomTat.Text = dtTruyen.Rows[0]["TomTat"].ToString();
                lblTacGia.Text = dtTruyen.Rows[0]["TenTacGia"].ToString();
                lblStatus.Text = dtTruyen.Rows[0]["TinhTrang"].ToString();
                lblView.Text = dtTruyen.Rows[0]["LuotXem"].ToString();

                DataTable dt1 = dataload.DataReader("DECLARE @StartDate DATE = (select top 1 ThoiGianDang" +
                    "\r\nfrom TacPham \r\ninner join Volume on Volume.MaTacPham = TacPham.MaTacPham" +
                    "\r\ninner join Chapter on Chapter.MaVolume = Volume.MaVolume" +
                    "\r\nwhere TacPham.MaTacPham = '"+MaTp+"'" +
                    "\r\norder by Chapter.MaChapter desc);" +
                    "\r\nDECLARE @EndDate DATE = GETDATE();  -- Ngày hiện tại\r\n\r\nDECLARE @DateDiff INT = DATEDIFF(DAY, @StartDate, @EndDate);" +
                    "\r\n\r\nSELECT\r\n    CASE\r\n        WHEN @DateDiff < 30 THEN  CAST(@DateDiff AS NVARCHAR(10)) +  N' Ngày' \r\n        " +
                    "WHEN @DateDiff < 365 THEN + CAST(@DateDiff / 30 AS NVARCHAR(10)) +  N' Tháng' \r\n        ELSE CAST(@DateDiff / 365 AS NVARCHAR(10)) +  N' Năm' \r\n    END AS Result;");
                lblLastUpdate.Text = dt1.Rows[0][0].ToString();

                lblSoTu.Text = dataload.CountWordsFromFile("Application.StartupPath + \"\\\\Asset\\\\DataLightNovel\\\\\" \r\n" +
                    "+ dtTruyen.Rows[0][\"MaTacPham\"].ToString() + \"\\\\\" + dtTruyen.Rows[0][\"Anh\"].ToString()").ToString();

                DataTable dt2 = dataload.DataReader("select Volume.MaVolume " +
                    "\r\nfrom TacPham inner join Volume on Volume.MaTacPham = TacPham.MaTacPham" +
                    "\r\nwhere TacPham.MaTacPham = '" + MaTp + "'");
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    dataload.AddChildFormDockTop(new FormListVol(dt2.Rows[i]["MaVolume"].ToString()), this.panelListVol);
                }
                dt2.Dispose();

            }


            DataTable dt5 = dataload.DataReader("select * \r\nfrom TacPham inner join TacGia on TacGia.MaTacGia =TacPham.MaTacGia" +
                "\r\ninner join ChiTietTheLoai on ChiTietTheLoai.MaTacPham = TacPham.MaTacPham" +
                "\r\ninner join TheLoai on ChiTietTheLoai.MaTheLoai = TheLoai.MaTheLoai" +
                "\r\nwhere TacPham.MaTacPham = '" + MaTp + "'");
            for (int i = 0; i < dt5.Rows.Count; i++)
            {
                Guna2Button btn = new Guna2Button();
                btn.Name = "TL" + i.ToString();
                btn.Text = dt5.Rows[i]["TenTheLoai"].ToString();
                btn.BorderRadius = 10;
                btn.AutoSize = true;
                btn.FillColor = Color.WhiteSmoke;
                btn.ForeColor = Color.Black;
                btn.Font = new Font("Time New Roman", btn.Font.Size, btn.Font.Style);
                btn.BorderColor = Color.Gray;
                btn.BorderThickness = 1;
                panelTheLoai.Controls.Add(btn);
            }
            dt5.Dispose();
            

            DataTable dt6 = dataload.DataReader("select * \r\nfrom TacPham " +
                "\r\ninner join Volume on Volume.MaTacPham = TacPham.MaTacPham" +
                "\r\ninner join Chapter on Chapter.MaVolume = Volume.MaVolume" +
                "\r\nwhere TacPham.MaTacPham = '" + MaTp + "'");
            if (dt6.Rows.Count > 0)
            {
                int sotu = 0;
                foreach (DataRow dr in dt6.Rows)
                {
                    sotu += dataload.CountWordsFromFile(Application.StartupPath + "\\Asset\\DataLightNovel\\"
                        + dr["MaTacPham"].ToString() + "\\" + dr["TenVolume"].ToString() + "\\" + dr["Nguon"].ToString());
                }
                lblSoTu.Text = sotu.ToString();
            }
            dt6.Dispose();         
            dataload.AddChildFormDockTop(new FormNhomDich(MaTp), panelNhomDich);

            DataTable dt7 = dataload.DataReader("select distinct top 3 TacPham.MaTacPham" +
                "\r\nfrom TacPham inner join TacGia on TacGia.MaTacGia =TacPham.MaTacGia" +
                "\r\ninner join ChiTietTheLoai on ChiTietTheLoai.MaTacPham = TacPham.MaTacPham" +
                "\r\nwhere ChiTietTheLoai.MaTheLoai in (select ChiTietTheLoai.MaTheLoai" +
                "\r\n\t\t\t\t\t\t\t\t\tfrom TacPham \r\n\t\t\t\t\t\t\t\t\t" +
                "inner join ChiTietTheLoai on ChiTietTheLoai.MaTacPham = TacPham.MaTacPham" +
                "\r\n\t\t\t\t\t\t\t\t\tinner join TheLoai on ChiTietTheLoai.MaTheLoai = TheLoai.MaTheLoai" +
                "\r\n\t\t\t\t\t\t\t\t\twhere TacPham.MaTacPham = '"+MaTp+"') " +
                "and TacPham.MaTacPham NOT IN ('"+MaTp+"')");
            foreach(DataRow c in dt7.Rows)
            {
                dataload.AddChildFormDockTop(new FormSuggest(c["MaTacPham"].ToString()), panelSuggest);
            }
        }

        private void btnYeuThich_Click(object sender, EventArgs e)
        {
            if (FormMain.isLogin == true)
            {
                DataTable dt = dataload.DataReader("select * \r\nfrom YeuThich " +
                    "\r\nwhere TenDangNhap = '" + FormMain.TenDangNhap + "' and MaTacPham = '" + MaTp + "'");
                DataTable dt1 = dataload.DataReader("select count(MaYeuThich)\r\nfrom YeuThich ");
                if (dt.Rows.Count != 1)
                {
                    MessageBox.Show("Truyện đã được thêm vào danh sách yêu thích!");
                    dataload.DataChange("INSERT [dbo].[YeuThich] ([MaYeuThich], [TenDangNhap], [MaTacPham]) " +
                        "\r\nVALUES (N'YT" + ((int)dt1.Rows[0][0]+1).ToString() + "', N'" + FormMain.TenDangNhap + "', N'" + MaTp + "')");
                }
                else
                {
                    MessageBox.Show("Truyện đã có trong danh sách yêu thích!");
                }
                
            }
            else
            {
                if (MessageBox.Show("Bạn cần đăng nhập để theo dõi truyện này ? Bạn có muốn đăng nhập", "Yêu cầu đăng nhập", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Bạn cần đăng nhập để theo dõi truyện này!");
                    LayoutLogged lg = dataload.getFormParent(this, "LayoutLogged") as LayoutLogged;
                    Panel panel1 = dataload.getPanel(lg, "panelNoiDung");
                    if (lg.isclick == false)
                    {
                        dataload.AddChildFormDockFill(new FormLayoutDangNhap(), panel1);
                        lg.setClick(true);
                    }
                }
                    
            }
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            if (FormMain.isLogin == true)
            {
                DataTable dt = dataload.DataReader(" select count(BinhChon.MaBinhChon)" +
                    "\r\n from TacPham inner join BinhChon on BinhChon.MaTacPham = TacPham.MaTacPham" +
                    "\r\n where TacPham.MaTacPham = '" + MaTp + "' and BinhChon.TenDangNhap = N'" + FormMain.TenDangNhap + "'");
                if ((int)dt.Rows[0][0] == 0)
                    dataload.AddChildFormDockTop(new FormRating(MaTp), this.panelRating);
                else
                    MessageBox.Show("Bạn đã đánh giá truyện này");


            }
            else
            {              
                if (MessageBox.Show("Bạn cần đăng nhập để đánh giá truyện này ? Bạn có muốn đăng nhập", "Yêu cầu đăng nhập", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Bạn cần đăng nhập để theo dõi truyện này!");
                    LayoutLogged lg = dataload.getFormParent(this, "LayoutLogged") as LayoutLogged;
                    Panel panel1 = dataload.getPanel(lg, "panelNoiDung");
                    if (lg.isclick == false)
                    {
                        dataload.AddChildFormDockFill(new FormLayoutDangNhap(), panel1);
                        lg.setClick(true);
                    }
                }
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if(FormMain.isLogin == true)
            {
                DataTable dt = dataload.DataReader("select top 1 chapter.MaChapter " +
                "\r\nfrom TacPham \r\ninner join Volume on Volume.MaTacPham = TacPham.MaTacPham" +
                "\r\ninner join Chapter on Chapter.MaVolume = Volume.MaVolume" +
                "\r\ninner join LichSu on LichSu.MaChapter = Chapter.MaChapter" +
                "\r\nwhere TacPham.MaTacPham = '" + MaTp + "' and LichSu.TenDangNhap = N'" + FormMain.TenDangNhap  +
                "'" +
                "\r\norder by LichSu.ThoiGian desc");

                if(dt.Rows.Count > 0)
                {
                    btnRead.Enabled = true;
                    FormMain formMain = dataload.getFormMain(this) as FormMain;
                    Panel panel1 = dataload.getPanel(formMain, "panelMain");                
                    dataload.openChildFormDockFill(formMain.getactive(), new FormMainReading(dt.Rows[0][0].ToString()), panel1);
                }

                else
                {
                    MessageBox.Show("Bạn chưa từng đọc truyện này nên không thể đọc tiếp!");
                    btnRead.Enabled = false;
                }
                dt.Dispose();
            }
            else
            {
                if (MessageBox.Show("Bạn cần đăng nhập để đọc tiếp truyện này ? Bạn có muốn đăng nhập", "Yêu cầu đăng nhập", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    LayoutLogged lg = dataload.getFormParent(this, "LayoutLogged") as LayoutLogged;
                    Panel panel1 = dataload.getPanel(lg, "panelNoiDung");
                    if (lg.isclick == false)
                    {
                        dataload.AddChildFormDockFill(new FormLayoutDangNhap(), panel1);
                        lg.setClick(true);
                    }
                }
            }
        }

       /* private void btnYeuThich_DoubleClick(object sender, EventArgs e)
        {
            dataload.DataChange("delete from YeuThich where TenDangNhap = N'"+FormMain.TenDangNhap+"'");
            MessageBox.Show("Đã xóa truyện này khỏi danh sách yêu thích!");
        }*/
    }
}

