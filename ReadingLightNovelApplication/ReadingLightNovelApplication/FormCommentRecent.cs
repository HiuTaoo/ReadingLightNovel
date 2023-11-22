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
	public partial class FormCommentRecent : Form
	{
		SupportMethod supportMethod = new SupportMethod();
		string maBinhLuan;
		public FormCommentRecent(string maBinhLuan)
		{
			InitializeComponent();
			this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			this.BackColor = Color.Transparent;
			this.maBinhLuan = maBinhLuan;
		}

		private void FormCommentRecent_Load(object sender, EventArgs e)
		{
			DataTable data = supportMethod.DataReader("select TacPham.MaTacPham, TacPham.TenTacPham, [User].TenDangNhap, BinhLuanTacPham.ThoiGian, BinhLuanTacPham.NoiDung, [User].AnhDaiDien" +
				"\r\nfrom TacPham inner join BinhLuanTacPham on BinhLuanTacPham.MaTacPham = TacPham.MaTacPham" +
				"\r\n\tinner join [User] on [User].TenDangNhap = BinhLuanTacPham.TenDangNhap" +
				"\r\nwhere BinhLuanTacPham.MaBinhLuan = N'" + maBinhLuan +"'");
			btnTenTruyen.Text = data.Rows[0]["TenTacPham"].ToString();
			btnComment.Text = data.Rows[0]["NoiDung"].ToString();
			btnUser.Text = data.Rows[0]["TenDangNhap"].ToString();
			btnUser.AutoSize = true;
			if(File.Exists(Application.StartupPath + "\\Asset\\User\\" + data.Rows[0]["TenDangNhap"].ToString() + "\\" + data.Rows[0]["AnhDaiDien"].ToString()))
				btnAvatar.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Asset\\User\\"
					+ data.Rows[0]["TenDangNhap"].ToString() + "\\" + data.Rows[0]["AnhDaiDien"].ToString());
			else btnAvatar.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Asset\\noLoadUser.png"
			);

		}

		private void changeForeColorMouseHover(object sender, EventArgs e)
		{
			this.ForeColor = Color.Green;
		}

		private void changeForeColorMouseLeave(object sender, EventArgs e)
		{
			this.ForeColor = Color.White;
		}
	}
}
