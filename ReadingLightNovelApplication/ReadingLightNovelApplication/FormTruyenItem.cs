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
		public FormTruyenItem(string maTacPham)
		{
			InitializeComponent();
			this.maTacPham = maTacPham;
		}

		private void FormTruyenItem_Load(object sender, EventArgs e)
		{
			DataTable data = supportMethod.DataReader("SELECT top 1 TacPham.Anh, TacPham.MaTacPham, TacPham.TenTacPham, Chapter.TenChapter" +
				"\r\nFROM   dbo.Chapter INNER JOIN" +
				"\r\n             dbo.Volume ON dbo.Chapter.MaVolume = dbo.Volume.MaVolume INNER JOIN" +
				"\r\n             dbo.TacPham ON dbo.Volume.MaTacPham = dbo.TacPham.MaTacPham" +
				"\r\nWHERE TacPham.MaTacPham = N'"+ maTacPham +"'");
			btnTenTruyen.Text = data.Rows[0]["TenTacPham"].ToString();
			btnTenChuong.Text = data.Rows[0]["TenChapter"].ToString();
			panelAnh.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Asset\\DataLightNovel\\"
				+ data.Rows[0]["MaTacPham"].ToString() + "\\" + data.Rows[0]["Anh"].ToString());
		}
	}
}
