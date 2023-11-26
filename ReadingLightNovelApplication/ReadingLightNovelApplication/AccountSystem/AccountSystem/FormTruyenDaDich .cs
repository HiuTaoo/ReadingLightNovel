using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingLightNovelApplication.AccountSystem.AccountSystem
{
	public partial class FormTruyenDaDich : Form
	{
		SupportMethod supportMethod = new SupportMethod();

		public FormTruyenDaDich()
		{
			InitializeComponent();
		}

		private void FormTruyenDaDich_Load(object sender, EventArgs e)
		{
			lblTieuDe.Text = "Series truyện đăng bởi " + FormMain.TenDangNhap;

			DataTable data = supportMethod.DataReader("select *\r\nfrom TacPham\r\nwhere TacPham.TenDangNhap = N'" + FormMain.TenDangNhap + "'");
			foreach (DataRow dr in data.Rows)
			{
				supportMethod.AddChildFormDockTop(new FormTruyenDaDichItem(dr["MaTacPham"].ToString()), panelNoiDung);
			}
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			panelNoiDung.Controls.Clear();

			DataTable data = supportMethod.DataReader("select *\r\nfrom TacPham\r\nwhere TacPham.TenDangNhap = N'" + FormMain.TenDangNhap + "' and (TacPham.TenTacPham like N'%" + txtTimKiem.Text.Trim() + "%' or TacPham.TenKhac like N'%" + txtTimKiem.Text.Trim() + "%' )");
			foreach (DataRow dr in data.Rows)
			{
				supportMethod.AddChildFormDockTop(new FormTruyenDaDichItem(dr["MaTacPham"].ToString()), panelNoiDung);
			}
		}
	}
}
