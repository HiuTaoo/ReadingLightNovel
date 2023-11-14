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
	public partial class FormHome : Form
	{
		Nhap nhap = new Nhap();
		public FormHome()
		{
			InitializeComponent();
		}

		private void FormHome_Load(object sender, EventArgs e)
		{
			panelRightHome.Controls.Add(nhap.GetPanel("panelTruyenVuaDoc"));
		}

		private void panelLeftHome_Paint(object sender, PaintEventArgs e)
		{

		}

		private void guna2Button14_Click(object sender, EventArgs e)
		{

		}
	}
}
