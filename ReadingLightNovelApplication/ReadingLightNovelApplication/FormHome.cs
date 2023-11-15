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
		}

		private void loadNoiBat()
		{
			DataTable data = SupportMethod.DataReader("SELECT top 6 TacPham.MaTacPham, TacPham.TenTacPham, TacPham.Anh ,COUNT(LichSu.ThoiGian)\r\nFROM   dbo.Chapter INNER JOIN\r\n             dbo.LichSu ON dbo.Chapter.MaChapter = dbo.LichSu.MaChapter INNER JOIN\r\n             dbo.Volume ON dbo.Chapter.MaVolume = dbo.Volume.MaVolume INNER JOIN\r\n             dbo.TacPham ON dbo.Volume.MaTacPham = dbo.TacPham.MaTacPham\r\ngroup by TacPham.MaTacPham, TacPham.TenTacPham, TacPham.Anh");
			
			foreach(DataRow row in data.Rows)
			{
				Guna2Panel panelItem = new Guna2Panel();
				panelItem.Size = new Size(177, 215);
				panelItem.Dock = DockStyle.None;
				panelItem.AutoSize = false;
				Guna2Panel panelMargin = new Guna2Panel();
				panelMargin.Dock = DockStyle.Left;
				panelMargin.Size = new Size(15, 215);
				panelMargin.BackColor = Color.Transparent;
				panelItem.Controls.Add(panelMargin);
				Guna2Panel panelAnh = new Guna2Panel();
				panelAnh.Dock = DockStyle.Fill;
				panelAnh.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Asset\\DataLightNovel\\" +
					row[0].ToString() + "\\" + row[2].ToString());
				panelAnh.BackColor = Color.Black;
				panelItem.Controls.Add(panelAnh);
				Guna2Button link = new Guna2Button();
				link.Dock = DockStyle.Bottom;
				link.Height = 29;
				link.Text = row[1].ToString();
				link.ForeColor = Color.Green;
				link.BackColor = Color.Transparent;
				link.FillColor = Color.Transparent;
				panelAnh.Controls.Add(link);
											
				flpTopTruyen.Controls.Add(panelItem);
				//MessageBox.Show(guna2Button17.Size.ToString());
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
				Guna2Panel panelItem = new Guna2Panel();
				panelItem.Size = new Size(181, 79);
				panelItem.Dock = DockStyle.Top;
				panelItem.AutoSize = false;


				Guna2Panel panelMargin = new Guna2Panel();
				panelMargin.Dock = DockStyle.Top;
				panelMargin.Size = new Size(181,18);
				panelMargin.BackColor = Color.Transparent;
				panelItem.Controls.Add(panelMargin);

				

				Guna2Button tenTruyen = new Guna2Button();
				tenTruyen.Dock = DockStyle.Top;
				tenTruyen.Height = 29;
				tenTruyen.Text = row["TenTacPham"].ToString();
				tenTruyen.ForeColor = Color.Green;
				tenTruyen.BackColor = Color.Transparent;
				tenTruyen.FillColor = Color.Transparent;
				
			}
		}

		private void loadChuongMoi()
		{

		}
	}
}
