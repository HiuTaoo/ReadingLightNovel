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
	public partial class FormChapterContain : Form
	{	
		SupportMethod supportMethod = new SupportMethod();
		private string maChapter;
		public FormChapterContain(string maChapter)
		{
			InitializeComponent();			
			this.maChapter = maChapter;
		}

		private void FormChapterContain_Load(object sender, EventArgs e)
		{
			DataTable tenChapter = supportMethod.DataReader("select Chapter.TenChapter\r\nfrom Chapter\r\nwhere Chapter.MaChapter = N'" + maChapter + "'");
			btnTenChapter.Text = tenChapter.Rows[0]["TenChapter"].ToString();



		}

		private void btnTenChapter_MouseUp(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Right)
			{
				contextMenuStrip1.Show(btnTenChapter, e.Location);
			}
			else
			{


			}
		}
	}
}
