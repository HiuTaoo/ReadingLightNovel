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
	public partial class FormSuaTruyen : Form
	{
		SupportMethod sp = new SupportMethod();
		public string TentacphamValue { get; set; }
		public string TenKhacValue { get; set; }
		public string TomTatValue { get; set; }
		public string MaTacPham { get; set; }

		public FormSuaTruyen()
		{
			InitializeComponent();
		}

		private void txtTieude_TextChanged(object sender, EventArgs e)
		{
			// Sử dụng giá trị TentacphamValue ở đây nếu cần
			string tentacpham = TentacphamValue;
		}
		private void cbTheLoai_Click(object sender, EventArgs e)
		{


			DataTable dt = sp.DataReader("select TheLoai.MaTheLoai, TheLoai.TenTheLoai,TheLoai.GhiChu\r\nfrom TheLoai");
			cbTheLoai.DataSource = dt;
			cbTheLoai.DisplayMember = "TenTheLoai";
			cbTheLoai.ValueMember = "MaTheLoai";
		}
		private void FormSuaTruyen_Load(object sender, EventArgs e)
		{
			// Sử dụng giá trị TentacphamValue ở đây nếu cần
			txtTieude.Text = TentacphamValue;
			txtTenKhac.Text = TenKhacValue;
			rtxtFont.Text = TomTatValue;

		}

		private void btnQuayLai_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (txtTieude.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập tên tác phẩm");
				txtTieude.Focus();
			}
			else
			{
				sp.DataChange("UPDATE [dbo].[TacPham]\r\nSET " +
					"\r\n    [TenTacPham] = N'"+txtTieude.Text+"'," +
					"\r\n    [TenKhac] = N'"+txtTenKhac.Text+"',\r\n    [TomTat] = N'"+rtxtFont.Text +"'" +
					"\r\nWHERE " +
					"\r\n    [MaTacPham] = N'"+MaTacPham.ToString()+"';" +
					"\r\n");
				MessageBox.Show("Bạn đã thêm thành công");
			}
		}
	}
}
