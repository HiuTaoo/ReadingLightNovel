using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ReadingLightNovelApplication
{
	public partial class FormThemTruyen : Form
	{
		SupportMethod sp = new SupportMethod();
		public FormThemTruyen()
		{
			InitializeComponent();
			rtxtFont.SelectionChanged += rtxtFont_SelectionChanged;
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
			if (rtxtFont.SelectionLength > 0)
			{
				Font currentFont = rtxtFont.SelectionFont;
				FontStyle newStyle = currentFont.Style ^ style;
				rtxtFont.SelectionFont = new Font(currentFont, newStyle);
			}
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
			DataTable dt1 = sp.DataReader("select TheLoai.MaTheLoai, TheLoai.TenTheLoai,TheLoai.GhiChu" +
				"\r\nfrom TheLoai" +
				"\r\nwhere MaTheLoai = '" + cbTheLoai.SelectedValue + "'");
		/*	Button bt = new Button();
			bt.Text = dt1.Rows[0]["TenTheLoai"].ToString();
			panelTheLoai.Controls.Add(bt);*/

		}

		private void FormThemTruyen_Load(object sender, EventArgs e)
		{
			DataTable dt = sp.DataReader("select TheLoai.MaTheLoai, TheLoai.TenTheLoai,TheLoai.GhiChu\r\nfrom TheLoai");
			foreach (DataRow row in dt.Rows)
			{
				cbTheLoai.Items.Add(row["TenTheLoai"].ToString());

				
			}
		}

		private void lblDangTruyenTaiday_Click(object sender, EventArgs e)
		{

		}

		private void cbTheLoai_Click(object sender, EventArgs e)
		{
			

			DataTable dt = sp.DataReader("select TheLoai.MaTheLoai, TheLoai.TenTheLoai,TheLoai.GhiChu\r\nfrom TheLoai");
			cbTheLoai.DataSource = dt;
			cbTheLoai.DisplayMember = "TenTheLoai";
			cbTheLoai.ValueMember = "MaTheLoai";
		}

		private void btnThem_Click_1(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;
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
			}
			

		}

		private void btnQuayLai_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
