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
	public partial class FormHomeSystem : Form
	{
		SupportMethod sp = new SupportMethod();
		public FormHomeSystem()
		{
			InitializeComponent();
		}

		private void FormHomeSystem_Load(object sender, EventArgs e)
		{
			DataTable dt = sp.DataReader("select COUNT(TacPham.MaTacPham)\r\nfrom TacPham");
			lblSoTruyen.Text += dt.Rows[0][0].ToString();
			DataTable dt1 = sp.DataReader("select COUNT(Volume.MaVolume)\r\nfrom Volume");
			lblSoTap.Text += dt1.Rows[0][0].ToString();
			DataTable dt2 = sp.DataReader("select COUNT(Chapter.MaChapter)\r\nfrom Chapter");
			lblSoChuong.Text += dt2.Rows[0][0].ToString();
		}
	}
}
