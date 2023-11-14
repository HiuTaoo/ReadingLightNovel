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
	public partial class Nhap : Form
	{
		public Nhap()
		{
			InitializeComponent();
		}

		private void Nhap_Load(object sender, EventArgs e)
		{

		}

		public Panel GetPanel(string name) 
		{
			foreach(Panel p in this.Controls.OfType<Panel>())
			{
				if (p.Name == name)
				{
					return p;
				}
			}
			return null;
		}

		private void guna2Button17_Click(object sender, EventArgs e)
		{

		}

		private void guna2Panel48_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
