using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingLightNovelApplication
{
	public partial class FormTimKiem : Form
	{
		private SupportMethod supportMethod = new SupportMethod();
		Form activeForm = null;
		private string keySearch = string.Empty;
		private List<string> keys = new List<string>();
		public FormTimKiem(string keySearch)
		{
			InitializeComponent();
			this.keySearch = keySearch;
		}

		public FormTimKiem()
		{
			InitializeComponent();
		}

		public void customPanelTimKiemNangCao()
		{
			/*DataTable data = supportMethod.DataReader("select TheLoai.MaTheLoai, TheLoai.TenTheLoai" +
				"\r\nfrom TheLoai" +
				"\r\norder by TheLoai.TenTheLoai ");
			Stack<string> strings = new Stack<string>();
			foreach (DataRow row in data.Rows)
			{
				strings.Push(row["MaTheLoai"].ToString());
				
			}

			foreach(string item in strings)
			{
				supportMethod.AddChildFormDockNone(new FormTheLoaiCheckbox(item), flpTheLoai);
			}*/

			supportMethod.AddChildFormDockTop(new FormTimKiemNangCao(), panelTimKiemNangCao);
			panelTimKiemNangCao.Visible = false;
		}

		private void FormTimKiem_Load(object sender, EventArgs e)
		{
			//supportMethod.AddChildFormDockTop(new FormTimKiemNangCao(), panelNoiDung);
			customPanelTimKiemNangCao();
			panelKhongKetQua.Visible = false;

			//supportMethod.AddChildFormDockTop(new FormTimKiemKetQua(), panelKetQua);
			panelKetQua.Visible = false;
			txtTimKiem.Text = keySearch;
		}


		private void btnTimKiemNangCao_Click(object sender, EventArgs e)
		{
			if(panelTimKiemNangCao.Visible == false)
			{
				panelTimKiemNangCao.Visible = true;
			}
			else panelTimKiemNangCao.Visible = false;
		}
	
		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			panelKhongKetQua.Visible = false;
			foreach(Control control in panelKetQua.Controls)
			{
				control.Dispose();
			}
			string queryTxt = "select sub.MaTacPham" +
				"\r\nfrom (" +
				"\r\n\tSELECT ROW_NUMBER() over(order by TacPham.TenTacPham) as rownuber, TacPham.MaTacPham, TacPham.TenTacPham, Volume.TenVolume, Chapter.TenChapter, Chapter.ThoiGianDang," +
				"\r\n\t\t\t\tTacGia.TenTacGia, HoaSi.TenHoaSi, TacPham.TinhTrang\r\n\tFROM   dbo.Chapter INNER JOIN\r\n\t\t\t\t dbo.Volume ON dbo.Chapter.MaVolume = dbo.Volume.MaVolume INNER JOIN" +
				"\r\n\t\t\t\t dbo.TacGia INNER JOIN\r\n\t\t\t\t dbo.HoaSi INNER JOIN\r\n\t\t\t\t dbo.ChiTietHoaSi ON dbo.HoaSi.MaHoaSi = dbo.ChiTietHoaSi.MaHoaSi INNER JOIN" +
				"\r\n\t\t\t\t dbo.TacPham ON dbo.ChiTietHoaSi.MaTacPham = dbo.TacPham.MaTacPham INNER JOIN\r\n\t\t\t\t dbo.BinhChon ON dbo.TacPham.MaTacPham = dbo.BinhChon.MaTacPham ON dbo.TacGia.MaTacGia = dbo.TacPham.MaTacGia ON dbo.Volume.MaTacPham = dbo.TacPham.MaTacPham INNER JOIN" +
				"\r\n\t\t\t\t dbo.ChiTietTheLoai ON dbo.TacPham.MaTacPham = dbo.ChiTietTheLoai.MaTacPham INNER JOIN\r\n\t\t\t\t dbo.TheLoai ON dbo.ChiTietTheLoai.MaTheLoai = dbo.TheLoai.MaTheLoai" +
				"\r\n\t\t\t\t WHERE Chapter.ThoiGianDang = (    SELECT MAX(c1.ThoiGianDang)\r\n\t\t\t\t\t\tFROM Chapter c1 WHERE c1.MaVolume = Chapter.MaVolume)\r\n\t\t\t\tGROUP BY TacPham.MaTacPham, TacPham.TenTacPham, Volume.TenVolume, Chapter.TenChapter, Chapter.ThoiGianDang," +
				"\r\n\t\t\t\tTacGia.TenTacGia, HoaSi.TenHoaSi, TacPham.TinhTrang" +
				"\r\n\r\n) as sub inner join ChiTietTheLoai on ChiTietTheLoai.MaTacPham = sub.MaTacPham" +
				"\r\nwhere (rownuber between 0 and 20) and sub.TenTacPham like N'%" + txtTimKiem.Text + "%' ";

			FormTimKiemNangCao formTimKiemNangCao = this.panelTimKiemNangCao.Controls[0] as FormTimKiemNangCao;
			keys = formTimKiemNangCao.getLoc();
			
			if (keys[0] != string.Empty)
			{
				queryTxt += " and sub.TenTacGia like N'%" + keys[0] + "%' ";
			}
			keys.RemoveAt(0);
			
			if (keys[0] != string.Empty)
			{
				queryTxt += " and sub.TenHoaSi like N'%" + keys[0] + "%' ";
			}
			keys.RemoveAt(0);

			if (keys[0] != string.Empty)
			{
				queryTxt += " and sub.TinhTrang like N'%" + keys[0] + "%' ";
			}
			keys.RemoveAt(0);

			string str = null;

			if (keys[0] != string.Empty)
			{
				str = " AND ChiTietTheLoai.MaTheLoai IN (";
				foreach (string key in keys)
				{
					str += "N'" + key + "', ";
				}
				str += " N'')";
				
			}
			str += " group by sub.MaTacPham";
			queryTxt += str;
			txtTimKiem.Text = queryTxt;
			MessageBox.Show(queryTxt);
			DataTable data = supportMethod.DataReader(queryTxt);

			List<string> list = new List<string>();

			if(data.Rows.Count == 0)
			{
				panelKhongKetQua.Visible = true;
				return;
			}

			panelKetQua.Visible = true;
			foreach (DataRow row in data.Rows) 
			{
				MessageBox.Show(row["MaTacPham"].ToString());
				list.Add(row["MaTacPham"].ToString());
			}
			supportMethod.AddChildFormDockTop(new FormTimKiemKetQua(list), panelKetQua);
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			foreach(Control control in panelKetQua.Controls)
			{
				MessageBox.Show(control.Name);
			}
			panelKetQua.Visible = true;
		}
	}
}
