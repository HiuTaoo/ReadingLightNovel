using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingLightNovelApplication.AccountSystem.AccountSystem
{
	public partial class FormTruyenDaDichItem : Form
	{
		SupportMethod SupportMethod = new SupportMethod();
		string matp;
		public FormTruyenDaDichItem(string matacpham)
		{
			InitializeComponent();
			this.matp = matacpham;
		}

		private void FormTruyenDaDichItem_Load(object sender, EventArgs e)
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
			catch
			{
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
				Image image = Image.FromFile(Application.StartupPath + "\\Asset\\User\\noLoadUser.png");
				pbImg.Image = image;
			}
			btnLoaiTruyen.Text = dtbase.Rows[0]["LoaiTruyen"].ToString();

			lblTenTruyen.MouseEnter += mouseEnter;
			lblTenTruyen.MouseLeave += mouseLeave;
			
		}

		

		private void lblTenTruyen_Click(object sender, EventArgs e)
		{
			FormMain formMain = SupportMethod.getFormMain(this) as FormMain;
			Panel panel1 = SupportMethod.getPanel(formMain, "panelMain");
			LayoutLogged lg = new LayoutLogged();
			SupportMethod.openChildFormDockFill(formMain.getactive(), lg, panel1);
			Panel panel2 = SupportMethod.getPanel(lg, "panelNoiDung");

			SupportMethod.openChildFormDockFill(lg.getActiveForm(), new FormContent(matp), panel2);
		}

		private void pbImg_Click(object sender, EventArgs e)
		{
			FormMain formMain = SupportMethod.getFormMain(this) as FormMain;
			Panel panel1 = SupportMethod.getPanel(formMain, "panelMain");
			foreach (Form f in panel1.Controls)
			{
				f.Close();
				f.Dispose();
			}
			LayoutLogged lg = new LayoutLogged();
			SupportMethod.openChildFormDockFill(formMain.getactive(), lg, panel1);
			Panel panel2 = SupportMethod.getPanel(lg, "panelNoiDung");

			SupportMethod.openChildFormDockFill(lg.getActiveForm(), new FormContent(matp), panel2);
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			LayOutSystem layOutSystem = this.ParentForm.ParentForm as LayOutSystem;
			Panel panel = SupportMethod.getPanel(layOutSystem, "panelHienChiTiet");

			panel.Controls.Clear();
			SupportMethod.AddChildFormDockTop(new FormEditTruyen(matp), panel);
		}

		public void mouseEnter(object sender, EventArgs e)
		{
			Label btn = sender as Label;
			btn.ForeColor = Color.Green;
		}

		public void mouseLeave(object sender, EventArgs e)
		{
			Label btn = sender as Label;
			btn.ForeColor = Color.Black;
		}

	}
}
