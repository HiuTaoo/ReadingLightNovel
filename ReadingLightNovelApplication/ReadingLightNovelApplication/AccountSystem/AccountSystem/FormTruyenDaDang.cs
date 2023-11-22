using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingLightNovelApplication.AccountSystem
{
	public partial class FormTruyenDaDang : Form
	{
		SupportMethod sp = new SupportMethod();
		FormSuaTruyen sua = new FormSuaTruyen();
		public string tentacpham, tenkhac, tomtat, tinhtrang;

		private void btnSua_Click(object sender, EventArgs e)
		{
			sua.ShowDialog();
		}

		public FormTruyenDaDang()
		{
			InitializeComponent();
		}

		private void FormTruyenDaDang_Load(object sender, EventArgs e)
		{
			dvgHienThi.DataSource = sp.DataReader("Select * from TacPham" +
				"\r\nwhere TacPham.TenDangNhap = N'" + FormMain.TenDangNhap + "'");
			btnSua.Enabled = false;
		}

		private void dvgHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			btnSua.Enabled = true;
			if (e.RowIndex >= 0 && e.RowIndex < dvgHienThi.Rows.Count && e.ColumnIndex == 1)
			{
				sua.TentacphamValue = dvgHienThi.Rows[e.RowIndex].Cells[1].Value.ToString();
				sua.TenKhacValue = dvgHienThi.Rows[e.RowIndex].Cells[2].Value.ToString();
				sua.TomTatValue = dvgHienThi.Rows[e.RowIndex].Cells[3].Value.ToString();
				sua.MaTacPham = dvgHienThi.Rows[e.RowIndex].Cells[0].Value.ToString();
			}
		}
	}

}
