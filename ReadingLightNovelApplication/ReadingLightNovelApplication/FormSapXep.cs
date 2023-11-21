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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ReadingLightNovelApplication
{
	public partial class FormSapXep : Form
	{
		private int cbLuaChonIndex = 0;
		private SupportMethod supportMethod = new SupportMethod();
		public FormSapXep(int cbLuaChonIndex)
		{
			InitializeComponent();
			this.Load += btnApDung;
			this.cbLuaChonIndex = cbLuaChonIndex;
		}

		public void setUpMacDinh()
		{
			cbLuaChon.SelectedIndex = cbLuaChonIndex;
			checkboxDaHoanThanh.Checked = true;
			checkboxDangTienHanh.Checked = true;
			checkboxTamNgung.Checked = true;

			checkboxTruyenDich.Checked = true;
			checkboxTruyenSangTac.Checked = false;
			checkboxConvert.Checked = false;
		}

		private void loadEventClickChuCai()
		{
			foreach(Guna2Button button in flpChuCai.Controls.OfType<Guna2Button>())
			{
				button.Click += eventClickChuCaiButton;
			}
			foreach(Guna2CircleButton button in flpChuCai.Controls.OfType<Guna2CircleButton>())
			{
				button.Click += eventClickChuCaiCircleButton;
			}

		}

		void eventClickChuCaiButton(object sender, EventArgs e)
		{
			foreach (Guna2Button btn in flpChuCai.Controls.OfType<Guna2Button>())
			{
				btn.FillColor = Color.Transparent;
			}

			foreach (Guna2CircleButton btn in flpChuCai.Controls.OfType<Guna2CircleButton>())
			{
				btn.FillColor = Color.Transparent;
			}
			Guna2Button button = sender as Guna2Button;
			flpChuCai.Tag = button.Text;
			button.FillColor = Color.Blue;
		}

		void eventClickChuCaiCircleButton(object sender, EventArgs e)
		{
			foreach (Guna2Button btn in flpChuCai.Controls.OfType<Guna2Button>())
			{
				btn.FillColor = Color.Transparent;
			}

			foreach (Guna2CircleButton btn in flpChuCai.Controls.OfType<Guna2CircleButton>())
			{
				btn.FillColor = Color.Transparent;
			}
			Guna2CircleButton button = sender as Guna2CircleButton;
			flpChuCai.Tag = button.Text;
			button.FillColor = Color.Blue;
		}

		private void FormSapXep_Load(object sender, EventArgs e)
		{
			setUpMacDinh();
			loadEventClickChuCai();
			
			string commandText = string.Empty;
			MessageBox.Show(getCommandText());

			btnChuCaiApDung.Click += btnApDung;
			btnPhanLoaiApDung.Click += btnApDung;
			btnTinhTrangApDung.Click += btnApDung;
			loadTheLoai();
			
		
		}

		private string getCommandText()
		{
			string commandText = string.Empty;
			switch (cbLuaChon.SelectedIndex)
			{
				case 0:
					commandText = "select *\r\nfrom (" +
						"\r\nSELECT ROW_NUMBER() over(order by TacPham.TenTacPham) as rownuber, TacPham.TenTacPham, TacPham.MaTacPham, Volume.TenVolume, Chapter.TenChapter, Chapter.ThoiGianDang, TacPham.TinhTrang, TacPham.LoaiTruyen" +
						"\r\n\t\t\t\t\r\n\t\t\t\tFROM TacPham\r\n\t\t\t\tINNER JOIN Volume ON TacPham.MaTacPham = Volume.MaTacPham" +
						"\r\n\t\t\t\tINNER JOIN Chapter ON Volume.MaVolume = Chapter.MaVolume\r\n\t\t\t\tWHERE Chapter.ThoiGianDang = (    SELECT MAX(c1.ThoiGianDang)" +
						"\r\n\t\t\t\t\t\tFROM Chapter c1 WHERE c1.MaVolume = Chapter.MaVolume)\r\n\t\t\t\tGROUP BY TacPham.MaTacPham, TacPham.TenTacPham, Volume.TenVolume, Chapter.TenChapter, Chapter.ThoiGianDang, TacPham.TinhTrang, TacPham.LoaiTruyen" +
						"\r\n\t\t\t\t) as sub\r\nwhere rownuber between 0 and 20";
					break;
				case 1:
					commandText = "select *\r\nfrom (" +
						"\r\nSELECT ROW_NUMBER() over(order by TacPham.TenTacPham desc) as rownuber, TacPham.TenTacPham, TacPham.MaTacPham, Volume.TenVolume, Chapter.TenChapter, Chapter.ThoiGianDang, TacPham.TinhTrang, TacPham.LoaiTruyen" +
						"\r\n\t\t\t\t\r\n\t\t\t\tFROM TacPham\r\n\t\t\t\tINNER JOIN Volume ON TacPham.MaTacPham = Volume.MaTacPham" +
						"\r\n\t\t\t\tINNER JOIN Chapter ON Volume.MaVolume = Chapter.MaVolume\r\n\t\t\t\tWHERE Chapter.ThoiGianDang = (    SELECT MAX(c1.ThoiGianDang)" +
						"\r\n\t\t\t\t\t\tFROM Chapter c1 WHERE c1.MaVolume = Chapter.MaVolume)\r\n\t\t\t\tGROUP BY TacPham.MaTacPham, TacPham.TenTacPham, Volume.TenVolume, Chapter.TenChapter, Chapter.ThoiGianDang, TacPham.TinhTrang, TacPham.LoaiTruyen" +
						"\r\n\t\t\t\t) as sub\r\nwhere rownuber between 0 and 20";
					break;
				case 2:
					commandText = "select *\r\nfrom (" +
						"\r\nSELECT ROW_NUMBER() over(order by Chapter.ThoiGianDang desc) as rownuber, TacPham.TenTacPham, TacPham.MaTacPham, Volume.TenVolume, Chapter.TenChapter, Chapter.ThoiGianDang, TacPham.TinhTrang, TacPham.LoaiTruyen" +
						"\r\n\t\t\t\t\r\n\t\t\t\tFROM TacPham\r\n\t\t\t\tINNER JOIN Volume ON TacPham.MaTacPham = Volume.MaTacPham" +
						"\r\n\t\t\t\tINNER JOIN Chapter ON Volume.MaVolume = Chapter.MaVolume\r\n\t\t\t\tWHERE Chapter.ThoiGianDang = (    SELECT MAX(c1.ThoiGianDang)" +
						"\r\n\t\t\t\t\t\tFROM Chapter c1 WHERE c1.MaVolume = Chapter.MaVolume)\r\n\t\t\t\tGROUP BY TacPham.MaTacPham, TacPham.TenTacPham, Volume.TenVolume, Chapter.TenChapter, Chapter.ThoiGianDang, TacPham.TinhTrang, TacPham.LoaiTruyen" +
						"\r\n\t\t\t\t) as sub\r\nwhere rownuber between 0 and 20";
					break;


				default:
					break;
			}

			if(checkboxTruyenDich.Checked || checkboxTruyenSangTac.Checked || checkboxConvert.Checked)
			{
				commandText += " and ( (1 = 2) ";

				if (checkboxTruyenDich.Checked)
				{
					commandText += "or sub.LoaiTruyen = N'Truyện dịch' or ";
					
				}

				if (checkboxConvert.Checked)
				{
					commandText += " sub.LoaiTruyen = N'Truyện sáng tác' or ";
					

				}
				if(checkboxTruyenDich.Checked)
					commandText += " sub.LoaiTruyen = N'Truyện Convert' or ";

				commandText += " (1 = 2) )";
				
			}

			if(checkboxDaHoanThanh.Checked || checkboxDaHoanThanh.Checked || checkboxTamNgung.Checked)
			{
				commandText += " and ( (1 = 2) ";
				if (checkboxDaHoanThanh.Checked)
				{
					commandText += " or sub.TinhTrang = N'Đã hoàn thành' or ";

				}

				if (checkboxDangTienHanh.Checked)
				{
					commandText += " sub.TinhTrang = N'Đang tiến hành' or ";					
				}

				if (checkboxTamNgung.Checked)
				{
					commandText += " sub.TinhTrang = N'Tạm ngưng' or ";
				}
				commandText += " (1 = 2) )";
			}

			if(flpChuCai.Tag != null)
			{
				commandText += " and  ";

				if (flpChuCai.Tag.ToString() != "Tất cả")
				{
					if (flpChuCai.Tag.ToString() == "#")
					{
						commandText += "left(sub.TenTacPham, 1) not in ('A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z')";
					}
					else
						commandText += " sub.TenTacPham like N'" + flpChuCai.Tag + "%'";
				}
			}

			return commandText;
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show(getCommandText());
		}

		void btnApDung(object sender, EventArgs e)
		{
			DataTable data = supportMethod.DataReader(getCommandText());
			foreach (Control control in flpKetQuaSapXep.Controls)
			{
				control.Dispose();
			}
			Stack<string> stack = new Stack<string>();
			foreach (DataRow row in data.Rows)
			{
				stack.Push(row["MaTacPham"].ToString());
			}
			foreach(string item in stack)
			{
				supportMethod.AddChildFormDockNone(new FormTruyenItem(item), flpKetQuaSapXep);
			}
		}

		public void loadTheLoai()
		{
			DataTable data = supportMethod.DataReader("select *\r\nfrom TheLoai");
			Stack<string> stack = new Stack<string>();
			Stack<string> strings = new Stack<string>();
			foreach (DataRow row in data.Rows)
			{
				stack.Push(row["TenTheLoai"].ToString());
				strings.Push(row["MaTheLoai"].ToString());
			}
			foreach (string item in stack)
			{
				Guna2Button button = new Guna2Button();
				button.Text = item;
				button.Tag = strings.Pop().ToString();
				button.Dock = DockStyle.Top;
				button.TextAlign = (HorizontalAlignment)ContentAlignment.MiddleLeft;
				button.ForeColor = Color.Black;
				button.FillColor = Color.Transparent;
				panelTheLoai.Controls.Add(button);
			}

		}

		private void cbLuaChon_SelectedValueChanged(object sender, EventArgs e)
		{
			DataTable data = supportMethod.DataReader(getCommandText());
			foreach(Control control in flpKetQuaSapXep.Controls)
			{
				control.Dispose();
			}
			Stack<string> stack = new Stack<string>();
			foreach (DataRow row in data.Rows)
			{
				stack.Push(row["MaTacPham"].ToString());
			}
			foreach (string item in stack)
			{
				supportMethod.AddChildFormDockNone(new FormTruyenItem(item), flpKetQuaSapXep);
			}
		}
	}
}
