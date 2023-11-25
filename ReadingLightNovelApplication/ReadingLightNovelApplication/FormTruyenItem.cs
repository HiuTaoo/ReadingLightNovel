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

namespace ReadingLightNovelApplication
{
	public partial class FormTruyenItem : Form
	{
		SupportMethod supportMethod = new SupportMethod();
		string maTacPham;
		string maChapter;
		public FormTruyenItem(string maTacPham)
		{
			InitializeComponent();
			this.maTacPham = maTacPham;
		}

		private void FormTruyenItem_Load(object sender, EventArgs e)
		{
			DataTable data = supportMethod.DataReader("SELECT top 1 TacPham.Anh, TacPham.MaTacPham, TacPham.TenTacPham, Chapter.TenChapter, Chapter.MaChapter " +
				"\r\nFROM   dbo.Chapter INNER JOIN" +
				"\r\n             dbo.Volume ON dbo.Chapter.MaVolume = dbo.Volume.MaVolume INNER JOIN" +
				"\r\n             dbo.TacPham ON dbo.Volume.MaTacPham = dbo.TacPham.MaTacPham" +
				"\r\nWHERE TacPham.MaTacPham = N'"+ maTacPham +"'");
			btnTenTruyen.Text = data.Rows[0]["TenTacPham"].ToString();
			btnTenChuong.Text = data.Rows[0]["TenChapter"].ToString();

			try
			{
                panelAnh.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Asset\\DataLightNovel\\"
                + data.Rows[0]["MaTacPham"].ToString() + "\\" + data.Rows[0]["Anh"].ToString());
            }
			catch { }

			this.maChapter = data.Rows[0]["MaChapter"].ToString();

			btnTenChuong.MouseEnter += mouseEnter;
			btnTenTruyen.MouseEnter += mouseEnter;

			btnTenChuong.MouseLeave += mouseLeave;
			btnTenTruyen.MouseLeave += mouseLeave;

		}

		public void mouseEnter(object sender, EventArgs e)
		{
			Guna2Button btn = sender as Guna2Button;
			btn.ForeColor = Color.Green;
		}

		public void mouseLeave(object sender, EventArgs e)
		{
			Guna2Button btn = sender as Guna2Button;
			btn.ForeColor = Color.White;
		}

		private void panelAnh_Click(object sender, EventArgs e)
		{
			supportMethod.openChildFormFromForm("LayoutLogged", "panelNoiDung", new FormContent(maTacPham), this);

		}

		private void btnTenTruyen_Click(object sender, EventArgs e)
		{
			supportMethod.openChildFormFromForm("LayoutLogged", "panelNoiDung", new FormContent(maTacPham), this);
		}

		private void btnTenChuong_Click(object sender, EventArgs e)
		{
            DataTable dt2 = supportMethod.DataReader("select top 1 Volume.TenVolume, Chapter.TenChapter, Chapter.MaChapter, Chapter.ThoiGianDang" +
                "\r\nfrom TacPham \r\ninner join Volume on Volume.MaTacPham = TacPham.MaTacPham" +
                "\r\ninner join Chapter on Chapter.MaVolume = Volume.MaVolume" +
                "\r\nwhere TacPham.MaTacPham = '" + maTacPham + "'" +
                "\r\norder by Chapter.ThoiGianDang desc");
            FormMain formMain = supportMethod.getFormMain(this) as FormMain;
            Panel panel1 = supportMethod.getPanel(formMain, "panelMain");
            foreach (Control c in panel1.Controls)
            {
                c.Dispose();
            }
            foreach (Form c in panel1.Controls)
            {
                c.Dispose();
            }
            supportMethod.openChildFormDockFill(formMain.getActiveForm(), new FormMainReading(dt2.Rows[0]["MaChapter"].ToString()), panel1);

        }

		
	}
}
