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
	public partial class FormTheLoaiCbox : Form
	{
		SupportMethod SupportMethod = new SupportMethod();
		private string maTheLoai;
		public FormTheLoaiCbox(string maTheLoai)
		{
			InitializeComponent();
			this.maTheLoai = maTheLoai;
		}

		private void checkboxTheLoai_CheckedChanged(object sender, EventArgs e)
		{
			if(checkboxTheLoai.Checked)
			{
				this.Tag = maTheLoai.ToString();
			}
            else
            {
				this.Tag = null;
            }
        }

		private void FormTheLoaiCbox_Load(object sender, EventArgs e)
		{
			DataTable data = SupportMethod.DataReader("select TenTheLoai\r\nfrom TheLoai\r\nwhere TheLoai.MaTheLoai = N'" + maTheLoai + "'");
			checkboxTheLoai.Text = data.Rows[0]["TenTheLoai"].ToString();


		}
	}
}
