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

			//cần edit lại UI
			loadNoiBat();	// done
			loadChuongMoi(); //done
			loadCommentRecent(); //done
			loadLichSu(); // cần sửa lại truy vấn
			loadTruyenMoi(); //done
			loadToptheoDoi(); //
			loadTruyenHoanThanh(); 
		}

		private void loadNoiBat()
		{
			Stack<string> list = new Stack<string>();

			DataTable data = SupportMethod.DataReader("SELECT top 6 TacPham.MaTacPham, TacPham.TenTacPham, TacPham.Anh ,COUNT(LichSu.ThoiGian)\r\nFROM   dbo.Chapter INNER JOIN\r\n             dbo.LichSu ON dbo.Chapter.MaChapter = dbo.LichSu.MaChapter INNER JOIN\r\n             dbo.Volume ON dbo.Chapter.MaVolume = dbo.Volume.MaVolume INNER JOIN\r\n             dbo.TacPham ON dbo.Volume.MaTacPham = dbo.TacPham.MaTacPham\r\ngroup by TacPham.MaTacPham, TacPham.TenTacPham, TacPham.Anh");
			

			foreach(DataRow row in data.Rows)
			{
				list.Push(row["MaTacPham"].ToString());

				//SupportMethod.AddChildFormDockNone(new FormTruyenItemNoiBat(row["MaTacPham"].ToString()), flpTopTruyen);
			}

			foreach (string item in list)
			{
				SupportMethod.AddChildFormDockTop(new FormTruyenItemNoiBat(item), flpTopTruyen);
			}
		}

		private void loadLichSu() 
		{
			DataTable data = SupportMethod.DataReader("SELECT top 6 TacPham.TenTacPham, Volume.TenVolume, Chapter.MaChapter, LichSu.ThoiGian" +
				"\r\nFROM   dbo.Chapter INNER JOIN" +
				"\r\n             dbo.LichSu ON dbo.Chapter.MaChapter = dbo.LichSu.MaChapter INNER JOIN" +
				"\r\n             dbo.Volume ON dbo.Chapter.MaVolume = dbo.Volume.MaVolume INNER JOIN" +
				"\r\n             dbo.TacPham ON dbo.Volume.MaTacPham = dbo.TacPham.MaTacPham" +
				"\r\nwhere LichSu.ThoiGian = (select MAX(l1.ThoiGian)" +
				"\r\n\t\t\t\t\t\t\tfrom LichSu l1 inner join Chapter c1 on c1.MaChapter = l1.MaChapter" +
				"\r\n\t\t\t\t\t\t\twhere c1.MaVolume = Volume.MaVolume)" +
				"\r\n\t\tand LichSu.TenDangNhap = N'"+FormMain.TenDangNhap+"'\t\t\t\t\t" +
				"\r\ngroup by TacPham.TenTacPham, Volume.TenVolume, Chapter.MaChapter, LichSu.ThoiGian" +
				"\r\norder by LichSu.ThoiGian desc");
			Stack<string> list = new Stack<string>();
			foreach (DataRow row in data.Rows)
			{
				list.Push(row["MaChapter"].ToString());

				
			}

			foreach (string item in list)
			{
				SupportMethod.AddChildFormDockTop(new FormTruyenVuaDocItem(item), panelTruyenVuaDoc);
			}
		}

		private void loadCommentRecent()
		{
			Stack<string> list = new Stack<string>();
			DataTable data = SupportMethod.DataReader("select BinhLuanTacPham.MaBinhLuan, TacPham.MaTacPham, TacPham.TenTacPham, [User].TenDangNhap, BinhLuanTacPham.ThoiGian" +
				"\r\nfrom TacPham inner join BinhLuanTacPham on BinhLuanTacPham.MaTacPham = TacPham.MaTacPham" +
				"\r\n\tinner join [User] on [User].TenDangNhap = BinhLuanTacPham.TenDangNhap" +
				"\r\nwhere BinhLuanTacPham.ThoiGian = (select MAX(c1.ThoiGian)" +
				"\r\n\t\t\t\t\t\t\t\t\tfrom BinhLuanTacPham c1\r\n\t\t\t\t\t\t\t\t\twhere c1.MaTacPham = BinhLuanTacPham.MaTacPham)" +
				"\r\ngroup by BinhLuanTacPham.MaBinhLuan ,TacPham.MaTacPham, TacPham.TenTacPham, [User].TenDangNhap, BinhLuanTacPham.ThoiGian" +
				"\r\norder by BinhLuanTacPham.ThoiGian desc");
			foreach (DataRow row in data.Rows)
			{
				list.Push(row["MaBinhLuan"].ToString());
				
				
			}

			foreach(string item in list)
			{
				SupportMethod.AddChildFormDockTop(new FormCommentRecent(item), panelCommentRecent);
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
			Stack<string> list = new Stack<string>();

			foreach (DataRow row in data.Rows)
			{
				list.Push(row["MaTacPham"].ToString());
			}

			foreach (string item in list)
			{
				SupportMethod.AddChildFormDockNone(new FormTruyenItem(item), this.flpTruyenMoi);
			}
		}

		private void loadTruyenMoi()
		{
			DataTable data = SupportMethod.DataReader("select top 10 TacPham.MaTacPham" +
				"\r\nfrom TacPham" +
				"\r\norder by TacPham.ThoiGianTao desc");

			Stack<string> list = new Stack<string>();

			foreach(DataRow row in data.Rows)
			{
				list.Push(row["MaTacPham"].ToString());
			}

			foreach(string item in list)
			{
				SupportMethod.AddChildFormDockNone(new FormTruyenMoiItem(item), flpTruyenMoiDang);

			}
		}

		private void loadToptheoDoi()
		{
			DataTable data = SupportMethod.DataReader("select top 10 TacPham.MaTacPham, COUNT(*) as luotThich" +
				"\r\nfrom YeuThich inner join TacPham on TacPham.MaTacPham = YeuThich.MaTacPham" +
				"\r\ngroup by TacPham.MaTacPham" +
				"\r\norder by luotThich desc");
			int index = 0;
			Stack<string> list = new Stack<string>();
			foreach (DataRow row in data.Rows)
			{
				list.Push(row["MaTacPham"].ToString());
			}

			foreach(string item in list)
			{
				SupportMethod.AddChildFormDockTop(new FormTheoDoiNhieuItem(item, index++), panelTopTheoDoi);
			}
		}

		private void loadTruyenHoanThanh()
		{
			DataTable data = SupportMethod.DataReader("SELECT TacPham.MaTacPham, Volume.TenVolume, Chapter.TenChapter, Chapter.ThoiGianDang" +
				"\r\n\t\t\t\t\r\n\t\t\t\tFROM TacPham" +
				"\r\n\t\t\t\tINNER JOIN Volume ON TacPham.MaTacPham = Volume.MaTacPham" +
				"\r\n\t\t\t\tINNER JOIN Chapter ON Volume.MaVolume = Chapter.MaVolume" +
				"\r\n\t\t\t\tWHERE Chapter.ThoiGianDang = (    SELECT MAX(c1.ThoiGianDang)" +
				"\r\n\t\t\t\t\t\tFROM Chapter c1 WHERE c1.MaVolume = Chapter.MaVolume)" +
				"\r\n\t\t\t\t\t\tand TacPham.TinhTrang = N'Đã Hoàn thành'" +
				"\r\n\t\t\t\tGROUP BY TacPham.MaTacPham, Volume.TenVolume, Chapter.TenChapter, Chapter.ThoiGianDang" +
				"\r\n\t\t\t\tORDER BY Chapter.ThoiGianDang desc");

			Stack<string> list = new Stack<string>();
			foreach (DataRow row in data.Rows)
			{
				list.Push(row["MaTacPham"].ToString());
			}
			foreach (string item in list)
			{
				SupportMethod.AddChildFormDockNone(new FormTruyenItem(item), flpTruyenHoanThanh);
			}
		}

		private void btnTopThang_Click(object sender, EventArgs e)
		{
			SupportMethod.openChildFormFromForm("LayoutLogged", "panelNoiDung", new FormSapXep(5), this);	// thay thành form sắp xếp theo tháng		
		}

		private void panelTopThoiGian_Click(object sender, EventArgs e)
		{
			SupportMethod.openChildFormFromForm("LayoutLogged", "panelNoiDung", new FormSapXep(6), this);//Thay thế thành form sắp xêp theo top full
		}

		private void btnChuongMoiNhat_Click(object sender, EventArgs e)
		{
			SupportMethod.openChildFormFromForm("LayoutLogged", "panelNoiDung", new FormSapXep(3), this);//Thay thế thành form sắp xếp theo chương mới nhất
		}

		private void btnTruyenMoiNhat_Click(object sender, EventArgs e)
		{
			SupportMethod.openChildFormFromForm("LayoutLogged", "panelNoiDung", new FormSapXep(2), this);//Thay thế thành form sắp xếp theo truyện mới
		}

		private void btnDaHoanThanh_Click(object sender, EventArgs e)
		{
			SupportMethod.openChildFormFromForm("LayoutLogged", "panelNoiDung", new FormHome(), this);//Thay thế thành form sắp xếp theo đã hoàn thành
		}
	}
}
