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
	public partial class FormTheLoaiCheckbox : Form
	{
		private string maTheLoai;
		private SupportMethod supportMethod = new SupportMethod();
		public FormTheLoaiCheckbox(string maTheLoai)
		{
			InitializeComponent();
			this.maTheLoai = maTheLoai;
		}

		private void FormTheLoaiCheckbox_Load(object sender, EventArgs e)
		{
			DataTable data = supportMethod.DataReader("select TheLoai.MaTheLoai, TheLoai.TenTheLoai" +
				"\r\nfrom TheLoai" +
				"\r\nwhere TheLoai.MaTheLoai = N'" + maTheLoai + "'");
			labelTheLoai.Text = data.Rows[0]["TenTheLoai"].ToString();
		}

		private void checkboxTheLoai_Click(object sender, EventArgs e)
		{
			if (checkboxTheLoai.Checked)
			{
				this.Tag = maTheLoai;
			}
			else
			{
				this.Tag = null;
			}
		}
	}
}
