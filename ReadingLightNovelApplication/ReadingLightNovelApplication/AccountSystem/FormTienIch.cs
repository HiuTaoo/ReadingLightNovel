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
	public partial class FormTienIch : Form
	{
		SupportMethod sp = new SupportMethod();
		string TenTheLoai, GhiChu;
		public FormTienIch()
		{
			InitializeComponent();
		}
		public FormTienIch(string tenTheLoai, string tenGhiChu)
		{
			this.TenTheLoai = tenTheLoai;
			this.GhiChu = tenGhiChu;

		}

		private void panelTienIch_Paint(object sender, PaintEventArgs e)
		{

		}

		private void FormTienIch_Load(object sender, EventArgs e)
		{
			DataTable dt = sp.DataReader("select TheLoai.MaTheLoai, TheLoai.TenTheLoai,TheLoai.GhiChu\r\nfrom TheLoai");
			foreach (DataRow row in dt.Rows)
			{
				Button bt = new Button();
				bt.Text = row["TenTheLoai"].ToString();
				bt.Dock = DockStyle.Top;
				panelTienIch.Controls.Add(bt);
			}
		}
	}
}
