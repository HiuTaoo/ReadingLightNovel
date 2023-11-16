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
	public partial class FormHome : Form
	{

		private Form activeForm = null;
		SupportMethod SupportMethod = new SupportMethod();
		public FormHome()
		{
			InitializeComponent();
		}

		private void FormHome_Load(object sender, EventArgs e)
		{


			loadNoiBat();	
			loadChuongMoi();
		}

		private void loadNoiBat()
		{
			DataTable data = SupportMethod.DataReader("SELECT top 6 TacPham.MaTacPham, TacPham.TenTacPham, TacPham.Anh ,COUNT(LichSu.ThoiGian)\r\nFROM   dbo.Chapter INNER JOIN\r\n             dbo.LichSu ON dbo.Chapter.MaChapter = dbo.LichSu.MaChapter INNER JOIN\r\n             dbo.Volume ON dbo.Chapter.MaVolume = dbo.Volume.MaVolume INNER JOIN\r\n             dbo.TacPham ON dbo.Volume.MaTacPham = dbo.TacPham.MaTacPham\r\ngroup by TacPham.MaTacPham, TacPham.TenTacPham, TacPham.Anh");
			
			foreach(DataRow row in data.Rows)
			{
				SupportMethod.AddChildFormDockNone(new FormTruyenItemNoiBat(row["MaTacPham"].ToString()), flpTopTruyen);
			}





		}

		private void loadCommentRecent()
		{
			DataTable data = SupportMethod.DataReader("SELECT TacPham.MaTacPham, TacPham.TenTacPham, BinhLuan.MaBinhLuan, BinhLuan.NoiDung, BinhLuan.Anh, BinhLuan.ThoiGian, [User].TenDangNhap, [User].AnhDaiDien" +
				"\r\nFROM   dbo.BinhLuan INNER JOIN\r\n             dbo.Chapter ON dbo.BinhLuan.MaChapter = dbo.Chapter.MaChapter INNER JOIN" +
				"\r\n             dbo.[User] ON dbo.BinhLuan.TenDangNhap = dbo.[User].TenDangNhap INNER JOIN" +
				"\r\n             dbo.Volume ON dbo.Chapter.MaVolume = dbo.Volume.MaVolume INNER JOIN" +
				"\r\n             dbo.TacPham ON dbo.Volume.MaTacPham = dbo.TacPham.MaTacPham" +
				"\r\nORDER BY BinhLuan.ThoiGian desc");
			foreach (DataRow row in data.Rows)
			{
				//SupportMethod.openChildFormDockTop(activeForm, flpTruyenMoi, new FormTruyenItem()
				
			}
		}

		private void loadChuongMoi()
		{
			DataTable data = SupportMethod.DataReader("SELECT TacPham.MaTacPham, Volume.TenVolume, Chapter.TenChapter, Chapter.ThoiGianDang" +
				"\r\n" +
				"FROM TacPham" +
				"\r\nINNER JOIN Volume ON TacPham.MaTacPham = Volume.MaTacPham" +
				"\r\nINNER JOIN Chapter ON Volume.MaVolume = Chapter.MaVolume" +
				"\r\nWHERE Chapter.ThoiGianDang = (\r\n    SELECT MAX(c1.ThoiGianDang)" +
				"\r\n    FROM Chapter c1\r\n    WHERE c1.MaVolume = Chapter.MaVolume\r\n)" +
				"\r\nGROUP BY TacPham.MaTacPham, Volume.TenVolume, Chapter.TenChapter, Chapter.ThoiGianDang" +
				"\r\nORDER BY Chapter.ThoiGianDang\r\n");
			foreach (DataRow row in data.Rows)
			{
				SupportMethod.AddChildFormDockNone(new FormTruyenItem(row["MaTacPham"].ToString()), this.flpTruyenMoi);
			}
		}
	}
}
