using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
			if(File.Exists(Application.StartupPath + "\\Asset\\User\\" + data.Rows[0]["AnhDaiDien"].ToString()))
				btnAvatar.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Asset\\User\\"
					 + data.Rows[0]["AnhDaiDien"].ToString());
			else btnAvatar.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Asset\\User\\noLoadUser.png"
            );

			btnTenTruyen.MouseEnter += mouseEnter;
			btnTenTruyen.MouseLeave += mouseLeave;

		}

		private void changeForeColorMouseHover(object sender, EventArgs e)
		{
			this.ForeColor = Color.Green;
		}

		private void changeForeColorMouseLeave(object sender, EventArgs e)
		{
			this.ForeColor = Color.White;
		}

        private void btnUser_Click(object sender, EventArgs e)
        {
            DataTable dt = supportMethod.DataReader("select TacPham.MaTacPham, TacPham.TenTacPham, [User].TenDangNhap, BinhLuanTacPham.ThoiGian, BinhLuanTacPham.NoiDung, [User].AnhDaiDien" +
                "\r\nfrom TacPham inner join BinhLuanTacPham on BinhLuanTacPham.MaTacPham = TacPham.MaTacPham" +
                "\r\n\tinner join [User] on [User].TenDangNhap = BinhLuanTacPham.TenDangNhap" +
                "\r\nwhere BinhLuanTacPham.MaBinhLuan = N'" + maBinhLuan + "'");
            LayoutLogged lg = supportMethod.getFormParent(this, "LayoutLogged") as LayoutLogged;

            Panel panel1 = supportMethod.getPanel(lg, "panelNoiDung");
            foreach (Control c in panel1.Controls)
            {
                c.Dispose();
            }
            
            supportMethod.AddChildFormDockFill(new FormProfile(dt.Rows[0]["TenDangNhap"].ToString()), panel1);
        }

        private void btnComment_Click(object sender, EventArgs e)
        {

        }

        private void btnTenTruyen_Click(object sender, EventArgs e)
        {
            LayoutLogged lg = supportMethod.getFormParent(this, "LayoutLogged") as LayoutLogged;
            Panel panel1 = supportMethod.getPanel(lg, "panelNoiDung");
            foreach (Control c in panel1.Controls)
            {
                c.Dispose();
            }
			DataTable dt1 = supportMethod.DataReader(" select TacPham.MaTacPham" +
				"\r\nfrom TacPham \r\ninner join Volume on Volume.MaTacPham = TacPham.MaTacPham" +
				"\r\ninner join Chapter on Chapter.MaVolume = Volume.MaVolume" +
				"\r\ninner join BinhLuan on BinhLuan.MaChapter = Chapter.MaChapter" +
				"\r\nwhere BinhLuan.MaBinhLuan = N'"+maBinhLuan+"'");
            supportMethod.AddChildFormDockFill(new FormContent(dt1.Rows[0]["MaTacPham"].ToString()), panel1);
        }

		public void mouseEnter(object sender, EventArgs e)
		{
			Guna2Button btn = sender as Guna2Button;
			btn.ForeColor = Color.Green;
		}

        public void mouseLeave(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            btn.ForeColor = Color.Black;
        }

    }
}
