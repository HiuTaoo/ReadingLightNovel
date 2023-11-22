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
	public partial class FormTruyenVuaDocItem : Form
	{
		private SupportMethod  supportMethod = new SupportMethod();
		private string maChapter;
		private string maTacPham;
		public FormTruyenVuaDocItem(string maChapter)
		{
			InitializeComponent();
			this.maChapter = maChapter;
		}

		private void FormTruyenVuaDocItem_Load(object sender, EventArgs e)
		{
			DataTable data = supportMethod.DataReader("select TacPham.TenTacPham, TacPham.MaTacPham, Chapter.TenChapter, Volume.TenVolume, TacPham.Anh" +
				"\r\nfrom Chapter inner join Volume on Volume.MaVolume = Chapter.MaVolume" +
				"\r\n\tinner join TacPham on TacPham.MaTacPham = Volume.MaTacPham" +
				"\r\nwhere Chapter.MaChapter = N'" + maChapter + "'");

			//Kiểm tra xem có ảnh không
			if(File.Exists(Application.StartupPath + "\\Asset\\DataLightNovel\\"
				+ data.Rows[0]["MaTacPham"].ToString() + "\\" + data.Rows[0]["Anh"].ToString()))
			{
				panelAnh.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Asset\\DataLightNovel\\"
				+ data.Rows[0]["MaTacPham"].ToString() + "\\" + data.Rows[0]["Anh"].ToString());
			}
			else
			{
				panelAnh.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Asset\\DataLightNovel\\"
				+ data.Rows[0]["MaTacPham"].ToString() + "\\NoUser.jpg");
			}
			btnTenChuong.Text = data.Rows[0]["TenChapter"].ToString();
			btnTenTruyen.Text = data.Rows[0]["TenTacPham"].ToString();
			btnTenVolume.Text = data.Rows[0]["TenVolume"].ToString();

			this.maTacPham = data.Rows[0]["MaTacPham"].ToString();

			// load event
			btnTenChuong.MouseEnter += mouseEnter;
			btnTenTruyen.MouseEnter += mouseEnter;
			btnTenVolume.MouseEnter += mouseEnter;

			btnTenVolume.MouseLeave += mouseLeave;
			btnTenTruyen.MouseLeave += mouseLeave;
			btnTenChuong.MouseLeave += mouseLeave;
		}

		public void mouseEnter(object sender, EventArgs e)
		{
			Guna2Button btn = sender as Guna2Button;
			btn.ForeColor = Color.Green;
		}

		public void mouseLeave(object sender, EventArgs e)
		{
			Guna2Button btn = sender as Guna2Button;
			btn.ForeColor = Color.Black;
		}

		private void panelAnh_MouseClick(object sender, MouseEventArgs e)
		{
			supportMethod.openChildFormFromForm("LayoutLogged", "panelNoiDung", new FormContent(maTacPham), this);
		}

		private void btnTenTruyen_Click(object sender, EventArgs e)
		{
			supportMethod.openChildFormFromForm("LayoutLogged", "panelNoiDung", new FormContent(maTacPham), this);

		}

		private void btnTenVolume_Click(object sender, EventArgs e)
		{
			supportMethod.openChildFormFromForm("LayoutLogged", "panelNoiDung", new FormContent(maTacPham), this);

		}

		private void btnTenChuong_Click(object sender, EventArgs e)
		{
			supportMethod.openChildFormFromForm("FormMain", "panelMain", new FormMainReading(maChapter), this);

		}
	}

}
