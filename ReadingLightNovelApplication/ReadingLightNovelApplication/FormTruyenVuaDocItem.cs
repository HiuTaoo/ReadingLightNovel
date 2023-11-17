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
		}


	}
}
