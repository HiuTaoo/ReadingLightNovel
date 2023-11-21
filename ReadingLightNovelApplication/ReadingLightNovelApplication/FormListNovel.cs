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
    public partial class FormListNovel : Form
    {
        SupportMethod SupportMethod = new SupportMethod();
        string matp;
        public FormListNovel(string matacpham)
        {
            InitializeComponent();
            matp = matacpham;
        }

        private void FormListNovel_Load(object sender, EventArgs e)
        {
            DataTable dtbase = SupportMethod.DataReader("select * \r\nfrom TacPham inner join TacGia on TacGia.MaTacGia =TacPham.MaTacGia" +
                "\r\nwhere TacPham.MaTacPham = N'" + matp + "'");

            DataTable dt1 = SupportMethod.DataReader("DECLARE @StartDate DATE = (select ThoiGianTao \r\nfrom TacPham inner join TacGia on TacGia.MaTacGia =TacPham.MaTacGia\r\nwhere TacPham.MaTacPham = '" + matp + "');\r\nDECLARE @EndDate DATE = GETDATE();  -- Ngày hiện tại\r\n\r\nDECLARE @DateDiff INT = DATEDIFF(DAY, @StartDate, @EndDate);\r\n\r\nSELECT\r\n    CASE\r\n        WHEN @DateDiff < 30 THEN  CAST(@DateDiff AS NVARCHAR(10)) +  N' Ngày' \r\n        WHEN @DateDiff < 365 THEN + CAST(@DateDiff / 30 AS NVARCHAR(10)) +  N' Tháng' \r\n        ELSE CAST(@DateDiff / 365 AS NVARCHAR(10)) +  N' Năm' \r\n    END AS Result;");
            lblLastUpdate.Text = dt1.Rows[0][0].ToString();

            lblStatus.Text = dtbase.Rows[0]["TinhTrang"].ToString();
            lblTenTruyen.Text = dtbase.Rows[0]["TenTacPham"].ToString();
            try
            {
                btnLoaiTruyen.Text = dtbase.Rows[0]["LoaiTruyen"].ToString();
            }
            catch {
                btnLoaiTruyen.Text = "Truyện Dịch";
            }

            try
            {
                Image image = Image.FromFile(Application.StartupPath + "\\Asset\\DataLightNovel\\"
                        + dtbase.Rows[0]["MaTacPham"].ToString() + "\\" + dtbase.Rows[0]["Anh"].ToString());
                pbImg.Image = image;
            }
            catch
            {
                Image image = Image.FromFile(Application.StartupPath + "\\Asset\\DataLightNovel\\"
                        + dtbase.Rows[0]["MaTacPham"].ToString() + "\\" + dtbase.Rows[0]["Anh"].ToString());
                pbImg.Image = image;
            }
            btnLoaiTruyen.Text = dtbase.Rows[0]["LoaiTruyen"].ToString();


        }

        private void lblTenTruyen_Click(object sender, EventArgs e)
        {
            FormMain formMain = SupportMethod.getFormMain(this) as FormMain;
            Panel panel1 = SupportMethod.getPanel(formMain, "panelMain");
            LayoutLogged lg = new LayoutLogged();
            SupportMethod.openChildFormDockFill(formMain.getactive(), lg, panel1);
            Panel panel2 = SupportMethod.getPanel(lg, "panelNoiDung");
            foreach (Control c in panel2.Controls)
            {
                c.Dispose();
            }
            SupportMethod.openChildFormDockFill(lg.getActiveForm(), new FormContent(matp), panel2);
        }
    }
}
