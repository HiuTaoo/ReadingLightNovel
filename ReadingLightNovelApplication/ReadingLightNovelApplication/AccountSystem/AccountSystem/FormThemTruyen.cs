
using ReadingLightNovelApplication.AccountSystem.AccountSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace ReadingLightNovelApplication
{
	public partial class FormThemTruyen : Form
	{
		SupportMethod supportMethod = new SupportMethod();
		bool isPick = false;
		OpenFileDialog openFileDialog1 = new OpenFileDialog();
		string TenDangNhap;
		string maTacPham = string.Empty;
		string namePicture = null;
		int indexTrong;
		string filePath;
		public FormThemTruyen(string tenDangNhap)
		{
			InitializeComponent();
			TenDangNhap = tenDangNhap;
			//rtxtFont.SelectionChanged += rtxtFont_SelectionChanged;
		}

		private void btnB_Click(object sender, EventArgs e)
		{
			ToggleFontStyle(FontStyle.Bold);
		}

		private void btnI_Click(object sender, EventArgs e)
		{
			ToggleFontStyle(FontStyle.Italic);
		}

		private void btnU_Click(object sender, EventArgs e)
		{
			ToggleFontStyle(FontStyle.Underline);
		}

		private void ToggleFontStyle(FontStyle style)
		{
			/*if (rtxtFont.SelectionLength > 0)
			{
				Font currentFont = rtxtFont.SelectionFont;
				FontStyle newStyle = currentFont.Style ^ style;
				rtxtFont.SelectionFont = new Font(currentFont, newStyle);
			}*/
		}

		private void rtxtFont_SelectionChanged(object sender, EventArgs e)
		{
			
		}

		private void btnThem_Click(object sender, EventArgs e)
		{

		}

		private void btnQuayLai_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
		{
			/*DataTable dt1 = sp.DataReader("select TheLoai.MaTheLoai, TheLoai.TenTheLoai,TheLoai.GhiChu" +
				"\r\nfrom TheLoai" +
				"\r\nwhere MaTheLoai = '" + cbTheLoai.SelectedValue + "'");*/
		/*	Button bt = new Button();
			bt.Text = dt1.Rows[0]["TenTheLoai"].ToString();
			panelTheLoai.Controls.Add(bt);*/

		}

		private void FormThemTruyen_Load(object sender, EventArgs e)
		{
			DataTable dt = supportMethod.DataReader("select TheLoai.MaTheLoai, TheLoai.TenTheLoai,TheLoai.GhiChu\r\nfrom TheLoai");
			Stack<string> list = new Stack<string>();

			foreach (DataRow row in dt.Rows)
			{
				//cbTheLoai.Items.Add(row["TenTheLoai"].ToString());

				list.Push(row["MaTheLoai"].ToString());
			}

			foreach(string item in list)
			{
				supportMethod.AddChildFormDockNone(new FormTheLoaiCbox(item), flpTheLoai);
			}
			//panelTheLoai.Size = flpTheLoai.Size;
			cbLoaiTruyen.SelectedIndex = 0;
			cbTinhTrang.SelectedIndex = 0;

		}

		public List<string> getListTheLoai()
		{
			List<string> list = new List<string>();						
			isPick = false;
			foreach (Control control in flpTheLoai.Controls)
			{
				if (control.Tag != null)
				{
					list.Add(control.Tag.ToString());
					isPick = true;
				}
			}
			if (!isPick)
			{
				list.Add(string.Empty);
			}
			return list;
		}

		private void lblDangTruyenTaiday_Click(object sender, EventArgs e)
		{

		}

		private void cbTheLoai_Click(object sender, EventArgs e)
		{
			

			/*DataTable dt = sp.DataReader("select TheLoai.MaTheLoai, TheLoai.TenTheLoai,TheLoai.GhiChu\r\nfrom TheLoai");
			cbTheLoai.DataSource = dt;
			cbTheLoai.DisplayMember = "TenTheLoai";
			cbTheLoai.ValueMember = "MaTheLoai";*/
		}

		private void btnThem_Click_1(object sender, EventArgs e)
		{
			/*DateTime now = DateTime.Now;
			DataTable dt = sp.DataReader("select COUNT(matacpham)\r\nfrom TacPham");
			DataTable dt1 = sp.DataReader("select *\r\nfrom TacGia\r\nwhere TenTacGia = N'" + txtTacGia.Text + "'");
			if(dt1.Rows.Count == 0)
			{
				DataTable dt3=sp.DataReader("select COUNT(MaTacGia)\r\nfrom TacGia	");
				sp.DataChange("INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia]) VALUES (N'TG" + ((int)dt3.Rows[0][0]+1).ToString() +"', N'"+txtTacGia.Text+"')\r\n");
			}
			DataTable dt2 = sp.DataReader("select MaTacGia\r\nfrom TacGia\r\nwhere TenTacGia = N'" + txtTacGia.Text + "'");
			if(txtTieude.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập tên tác phẩm");
				txtTieude.Focus();
			}
			else
			{
				sp.DataChange("INSERT [dbo].[TacPham] ([MaTacPham], [TenTacPham], [TenKhac], [TomTat], [Anh], [MaTacGia]," +
				" [TenDangNhap], [ThoiGianTao], [TinhTrang], [LoaiTruyen], [MaNhom], [MaHoaSi]) " +
				"VALUES (N'TP" + ((int)dt.Rows[0][0] + 1).ToString() + "', N'" + txtTieude.Text + "', N'" + txtTenKhac.Text + "'," +
				" N'" + rtxtFont.Text + "', NULL, N'" + dt2.Rows[0][0].ToString() + "', N'" + FormMain.TenDangNhap + "', " +
				"N'" + now.ToString() + "', N'" + cbTinhTrang.Text + "', NULL, NULL, NULL)\r\n");
				MessageBox.Show("Bạn đã thêm thành công");
			}*/
			

		}

		private void btnQuayLai_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			Panel panel = new Panel();
			panel.BackColor = Color.Black;
			panel.Size = new Size(200, 200);
			//panel.Location = guna2CheckBox1.Location;
			panelTheLoai.Controls.Add(panel);
		}

		private void btnThemAnh_Click(object sender, EventArgs e)
		{
			openFileDialog1.Filter = "Ảnh Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|Tất cả Files (*.*)|*.*";
			openFileDialog1.Title = "Chọn ảnh";

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				// Lấy đường dẫn tệp tin đã chọn
				filePath = openFileDialog1.FileName;

				// Hiển thị ảnh trong PictureBox
				picAnh.ImageLocation = filePath;
								
				namePicture = Path.GetFileName(filePath);
				picAnh.SizeMode = PictureBoxSizeMode.Zoom;
			}
		}

		private void btnThemTruyen_Click(object sender, EventArgs e)
		{
			if (kiemTra())
			{
				themTruyen();
				//Thêm thư mục mới
				if(filePath != null)
				{
					string rootDirectory = Application.StartupPath + "\\Asset\\DataLightNovel";
					string newDirectoryName = "TP" + FormatNumber(indexTrong, 3);
					string newDirectoryPath = Path.Combine(rootDirectory, newDirectoryName);
					if (!Directory.Exists(newDirectoryPath))
					{
						Directory.CreateDirectory(newDirectoryPath);
					}
					string newFilePath = Path.Combine(newDirectoryPath, Path.GetFileName(filePath));

					// Lưu ảnh vào thư mục chỉ định
					File.Copy(filePath, newFilePath, true);
				}


				//LayOutSystem layOutSystem = supportMethod.getFormParent(this, "LayOutSystem") as LayOutSystem;
				Panel panel = supportMethod.getPanel(this.ParentForm, "panelHienChiTiet");
				panel.Controls.Clear();
				supportMethod.AddChildFormDockTop(new FormEditTruyen("TP" + FormatNumber(indexTrong, 3)), panel);

				
			}


		}

		private bool kiemTra()
		{
			if(txtTieude.Text == string.Empty)
			{
				err.SetError(txtTieude, "Tên truyện không được bỏ trống");
				return false;
			}

			if (txtTacGia.Text == string.Empty)
			{
				err.SetError(txtTacGia, "Tên tác giả không được bỏ trống");
				return false;
			}
			List<string> list = this.getListTheLoai();
			if (!isPick)
			{
				err.SetError(panelTheLoai, "Cần chọn ít nhất 1 thể loại");
				return false;
			}

			return true;

		}

		private void themTruyen() 
		{
			supportMethod.DataChange(getCommandAddTacPham());
			insertHoaSi();
			insertTheLoai();
			
					
		}

		private string getCommandAddTacPham()
		{

			//insert  tác phẩm
			
			DataTable data1 = supportMethod.DataReader("select TacPham.MaTacPham\r\nfrom TacPham");
			int index = 0;
			foreach (DataRow row in data1.Rows)
			{
				index++;
				DataTable data2 = supportMethod.DataReader("select TacPham.MaTacPham\r\nfrom TacPham where TacPham.MaTacPham = N'TP" + FormatNumber(index, 3) + "' ");
				if (data2.Rows.Count == 0)
				{
					MessageBox.Show("N'TP" + FormatNumber(index, 3) + "'");
					indexTrong = index;
					maTacPham = "N'TP" + FormatNumber(index, 3) + "'";

					break;
				}
			}

			string maTacGia = string.Empty;
			DataTable dataTacGia = supportMethod.DataReader("select TacGia.MaTacGia\r\nfrom TacGia");
			int indexTacGia = 0;
			int indexNew = 0;
			foreach (DataRow row in dataTacGia.Rows)
			{
				indexTacGia++;
				DataTable data2 = supportMethod.DataReader("select TacGia.MaTacGia\r\nfrom TacGia where TacGia.MaTacGia = N'TG" + FormatNumber(indexTacGia, 2) + "'");
				if (data2.Rows.Count == 0)
				{
					indexNew = indexTacGia;
					break;
					
				}
			}

			DataTable dataTimKiem = supportMethod.DataReader("select TacGia.MaTacGia\r\nfrom TacGia where TacGia.TenTacGia = N'" + txtTacGia.Text.Trim() + "'");
			if(dataTimKiem.Rows.Count == 0)
			{
				maTacGia = "N'TG" + FormatNumber(indexNew, 2) + "'";
					//Thêm tác giả mới
				supportMethod.DataChange("INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia]) VALUES (" +  maTacGia + ", N'"+ txtTacGia.Text.Trim() +"')\r\n");
			}
			else 
				maTacGia = "N'" + dataTimKiem.Rows[0]["MaTacGia"].ToString() + "'";

			string commandTextAddTruyen;
			if (namePicture == null)
			{
				commandTextAddTruyen = "INSERT [dbo].[TacPham] ([MaTacPham], [TenTacPham], [TenKhac], [TomTat], [Anh], [MaTacGia], [TenDangNhap], [ThoiGianTao], [TinhTrang], [LoaiTruyen], [MaNhom], [MaHoaSi], [Email], [LuotXem])" +
				" VALUES (" + maTacPham + " , N'" + txtTieude.Text.Trim() + "', N'" + txtTenKhac.Text.Trim() + "', N'', NULL , " + maTacGia + ", N'" + TenDangNhap + "', GETDATE(), N'" + cbTinhTrang.Text + "', N'" + cbLoaiTruyen.Text + "', NULL, NULL, NULL, 0)\r\n";
			}
			commandTextAddTruyen = "INSERT [dbo].[TacPham] ([MaTacPham], [TenTacPham], [TenKhac], [TomTat], [Anh], [MaTacGia], [TenDangNhap], [ThoiGianTao], [TinhTrang], [LoaiTruyen], [MaNhom], [MaHoaSi], [Email], [LuotXem])" +
				" VALUES (" + maTacPham + " , N'" + txtTieude.Text.Trim() + "', N'" + txtTenKhac.Text.Trim() + "', N'', N'" + namePicture + "', " + maTacGia + ", N'" + TenDangNhap + "', GETDATE(), N'" + cbTinhTrang.Text + "', N'" + cbLoaiTruyen.Text + "', NULL, NULL, NULL, 0)\r\n";

			return commandTextAddTruyen;
		}

		private void insertHoaSi()
		{
			//insert họa si
			DataTable dataHoaSi = supportMethod.DataReader("select HoaSi.MaHoaSi\r\nfrom HoaSi");
			if (txtHoaSi.Text != string.Empty)
			{
				
				foreach(string text in txtHoaSi.Text.Split(new char[] { ';' }).ToList())
				{
					MessageBox.Show(text);
					int index = 0;
					string TenHoaSi = text.Trim();
					string maHoaSiNew = string.Empty;
					foreach (DataRow row in dataHoaSi.Rows)
					{
						index++;
						DataTable dataTimKiem = supportMethod.DataReader("select HoaSi.MaHoaSi, HoaSi.TenHoaSi\r\nfrom HoaSi\r\nwhere HoaSi.MaHoaSi = N'HS" + FormatNumber(index, 3) + "' ");
						Clipboard.SetText("select HoaSi.MaHoaSi, HoaSi.TenHoaSi\r\nfrom HoaSi\r\nwhere HoaSi.MaHoaSi = N'HS" + FormatNumber(index, 3) + "' ");
						MessageBox.Show("select HoaSi.MaHoaSi, HoaSi.TenHoaSi\r\nfrom HoaSi\r\nwhere HoaSi.MaHoaSi = N'HS" + FormatNumber(index, 3) + "' ");
						if (dataTimKiem.Rows.Count == 0)
						{
							MessageBox.Show("N'HS" + FormatNumber(index, 3) + "'");

							maHoaSiNew = "N'HS" + FormatNumber(index, 3) + "'";

							break;
						}					
					}

					DataTable dataDoiChieu = supportMethod.DataReader("select HoaSi.MaHoaSi, HoaSi.TenHoaSi\r\nfrom HoaSi\r\nwhere HoaSi.TenHoaSi = N'" + text.Trim() + "' ");
					if(dataDoiChieu.Rows.Count == 0)
					{
						
						supportMethod.DataChange("INSERT [dbo].[HoaSi] ([MaHoaSi], [TenHoaSi]) VALUES (" + maHoaSiNew + ", N'" + TenHoaSi + "')\r\n");
						supportMethod.DataChange("INSERT [dbo].[ChiTietHoaSi] ([MaHoaSi], [MaTacPham]) VALUES (" + maHoaSiNew + ", " + maTacPham + ")\r\n");
					}
					else
					{
						maHoaSiNew = dataDoiChieu.Rows[0]["MaHoaSi"].ToString();
						supportMethod.DataChange("INSERT [dbo].[ChiTietHoaSi] ([MaHoaSi], [MaTacPham]) VALUES (N'" + dataDoiChieu.Rows[0]["MaHoaSi"].ToString() + "', " + maTacPham + ")\r\n");
					}
						

					
				}
			}

		}

		private void insertTheLoai()
		{
			List<string> list = this.getListTheLoai();
			foreach(string theloai in list)
			{
				//MessageBox.Show(theloai);
				supportMethod.DataChange("INSERT [dbo].[ChiTietTheLoai] ([MaTacPham], [MaTheLoai]) VALUES (" + maTacPham + ", N'" + theloai + "')");
			}
			
		}

		public string FormatNumber(int num, int sokitu)
		{
			// Sử dụng phương thức ToString để chuyển số nguyên thành chuỗi
			string numStr = num.ToString();

			// Sử dụng PadLeft để thêm các ký tự '0' vào đầu chuỗi
			numStr = numStr.PadLeft(sokitu, '0');

			return numStr;
		}

	}
}
