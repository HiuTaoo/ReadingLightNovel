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
        int a = 0;
        Boolean isClick = false;

        public FormMainReading(string machapter)
        {
            InitializeComponent();
            ma = machapter;
        }

        public void setClick(Boolean a)
        {
            isClick = a;
        }

        public Label getlbContent()
        {
            return lbContent;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FormMain formMain = dataload.getFormMain(this) as FormMain;
            Panel panel1 = dataload.getPanel(formMain, "panelMain");
            foreach (Control c in panel1.Controls)
            {
                c.Dispose();
            }
            foreach (Form f in panel1.Controls)
            {
                f.Close();
                f.Dispose();
            }

            LayoutLogged lg = new LayoutLogged();
            dataload.openChildFormDockFill(formMain.getactive(), lg, panel1);
            Panel panel2 = dataload.getPanel(lg, "panelNoiDung");
            
            foreach (Control c in panel2.Controls)
            {
                c.Dispose();
            }
            foreach (Form f in panel2.Controls)
            {
                f.Close();
                f.Dispose();
            }

            DataTable dt = dataload.DataReader("select TacPham.MaTacPham" +
                "\r\nfrom TacPham \r\ninner join Volume on Volume.MaTacPham = TacPham.MaTacPham" +
                "\r\ninner join Chapter on Chapter.MaVolume = Volume.MaVolume" +
                "\r\nwhere Chapter.MaChapter = '" + ma + "'");
            dataload.openChildFormDockFill(lg.getActiveForm(), new FormContent(dt.Rows[0][0].ToString()), panel2);
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            DataTable dt3 = dataload.DataReader("select TacPham.MaTacPham" +
                "\r\nfrom TacPham\r\ninner join Volume on Volume.MaTacPham = TacPham.MaTacPham" +
                "\r\ninner join Chapter on Chapter.MaVolume = Volume.MaVolume" +
                "\r\nwhere Chapter.MaChapter = '" + ma + "'");
            DataTable dt4 = dataload.DataReader("select *" +
                "\r\nfrom TacPham \r\ninner join Volume on Volume.MaTacPham = TacPham.MaTacPham" +
                "\r\ninner join Chapter on Chapter.MaVolume = Volume.MaVolume" +
                "\r\nwhere TacPham.MaTacPham = '" + dt3.Rows[0][0] + "' ");

            FormMain formMain = dataload.getFormMain(this) as FormMain;
            Panel panel1 = dataload.getPanel(formMain, "panelMain");
            foreach (Control c in panel1.Controls)
            {
                c.Dispose();
            }
            foreach(Form f in panel1.Controls)
            {
                f.Close();
                f.Dispose();
            }
            dataload.openChildFormDockFill(formMain.getactive(), new FormMainReading(dt4.Rows[a - 1]["MaChapter"].ToString()), panel1);
            dt3.Dispose();
            dt4.Dispose();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DataTable dt3 = dataload.DataReader("select TacPham.MaTacPham" +
                "\r\nfrom TacPham\r\ninner join Volume on Volume.MaTacPham = TacPham.MaTacPham" +
                "\r\ninner join Chapter on Chapter.MaVolume = Volume.MaVolume" +
                "\r\nwhere Chapter.MaChapter = '" + ma + "'");
            DataTable dt4 = dataload.DataReader("select *" +
                "\r\nfrom TacPham \r\ninner join Volume on Volume.MaTacPham = TacPham.MaTacPham" +
                "\r\ninner join Chapter on Chapter.MaVolume = Volume.MaVolume" +
                "\r\nwhere TacPham.MaTacPham = '" + dt3.Rows[0][0] + "' ");

            if (a < dt4.Rows.Count)
            {
                FormMain formMain = dataload.getFormMain(this) as FormMain;
                Panel panel1 = dataload.getPanel(formMain, "panelMain");
                foreach (Control c in panel1.Controls)
                {
                    c.Dispose();
                }
                foreach (Form f in panel1.Controls)
                {
                    f.Close();
                    f.Dispose();
                }
                dataload.openChildFormDockFill(formMain.getactive(), new FormMainReading(dt4.Rows[a + 1]["MaChapter"].ToString()), panel1);
            }
            else
            {
                btnNext.Enabled = false;
                MessageBox.Show("Không còn chương tiếp theo!");
            }
            
            dt3.Dispose();
            dt4.Dispose();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            /*FormMain formMain = dataload.getFormMain(this) as FormMain;
            Panel panel1 = dataload.getPanel(formMain, "panelMain");*/
            if(isClick == false)
            {
                dataload.AddChildFormDockTop(new FormChangeFont(BackColor), this.panelChange);
                setClick(true);
            }
            
        }

        public void setBackColorButton(Color color)
        {
            btnVolName.FillColor = color;
            btnChapterName.FillColor = color;
            btnDetail.FillColor = color;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            FormMain formMain = dataload.getFormMain(this) as FormMain;
            Panel panel1 = dataload.getPanel(formMain, "panelMain");
            if (isClick == false)
            {
                dataload.AddChildFormDockLeft(new FormList(ma), panel1);
                setClick(true);
            }
                
        }

        private void FormMainReading_Load(object sender, EventArgs e)
        {
            DataTable dt = dataload.DataReader("select *" +
                " \r\nfrom Chapter inner join Volume on Volume.MaVolume = Chapter.MaVolume" +
                "\r\ninner join TacPham on TacPham.MaTacPham = Volume.MaTacPham" +
                "\r\nwhere Chapter.MaChapter = '" + ma + "'");
            btnVolName.Text = dt.Rows[0]["TenVolume"].ToString();
            btnChapterName.Text = dt.Rows[0]["TenChapter"].ToString();

            DataTable dt1 = dataload.DataReader("select count(BinhLuan.MaBinhLuan) " +
                "\r\nfrom Chapter inner join Volume on Volume.MaVolume = Chapter.MaVolume" +
                "\r\ninner join BinhLuan on BinhLuan.MaChapter = Chapter.MaChapter" +
                "\r\nwhere Chapter.MaChapter = '" + ma + "'");

            DataTable dt2 = dataload.DataReader("DECLARE @StartDate DATE = '" + dt.Rows[0]["ThoiGianDang"].ToString() + "'" +
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

            dataload.AddChildFormDockTop(new FormCommentArea(ma), this.panelCmt);

            DataTable dt3 = dataload.DataReader("select TacPham.MaTacPham" +
                "\r\nfrom TacPham\r\ninner join Volume on Volume.MaTacPham = TacPham.MaTacPham" +
                "\r\ninner join Chapter on Chapter.MaVolume = Volume.MaVolume" +
                "\r\nwhere Chapter.MaChapter = '" + ma + "'");
            DataTable dt4 = dataload.DataReader("select *" +
                "\r\nfrom TacPham \r\ninner join Volume on Volume.MaTacPham = TacPham.MaTacPham" +
                "\r\ninner join Chapter on Chapter.MaVolume = Volume.MaVolume" +
                "\r\nwhere TacPham.MaTacPham = '" + dt3.Rows[0][0] + "' ");
            
            for (int i = 0; i < dt4.Rows.Count; i++)
            {
                if (dt4.Rows[i]["MaChapter"].ToString() == ma)
                {
                    a = i;
                    break;
                }
            }

            if (a - 1 < 0)
            {
                btnPre.Enabled = false;
            }
            if ((a+1) < dt4.Rows.Count)
            {
                btnNext.Enabled = true;
            }
            else
            {
                btnNext.Enabled=false;
            }
            dt3.Dispose();
            dt4.Dispose();

            if (FormMain.isLogin == true)
            {
                DateTime now = DateTime.Now;
                DataTable dt7 = dataload.DataReader("select count(MaLichSu)\r\nfrom LichSu");
                dataload.DataChange("INSERT [dbo].[LichSu] ([MaLichSu], [TenDangNhap], [MaChapter], [ThoiGian]) " +
                    "\r\nVALUES (N'LS" + ((int)dt7.Rows[0][0]+2).ToString() + "', N'" + FormMain.TenDangNhap + "', N'" + ma + "', N'" + now.ToString() + "')");
            }
        }

        


        

        

        
    }
}
