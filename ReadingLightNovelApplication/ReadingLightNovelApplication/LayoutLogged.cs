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
    public partial class LayoutLogged : Form
    {
        private Form activeForm = null;
        SupportMethod SupportMethod = new SupportMethod();
        public LayoutLogged()
        {
            InitializeComponent();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LayoutLogged_Load(object sender, EventArgs e)
        {
            SupportMethod.AddChildFormDockTop(new FormHome(), this.panelNoiDung);
        }

		private void btnLogo_Click(object sender, EventArgs e)
		{
            foreach(Control control in this.panelNoiDung.Controls) 
            {
                control.Dispose();
            }
			SupportMethod.AddChildFormDockTop(new FormHome(), this.panelNoiDung);
		}

		private void btnDanhSach_Click(object sender, EventArgs e)
		{
			foreach (Control control in this.panelNoiDung.Controls)
			{
				control.Dispose();
			}
			SupportMethod.AddChildFormDockTop(new FormSapXep(), this.panelNoiDung);
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			foreach (Control control in this.panelNoiDung.Controls)
			{
				control.Dispose();
			}
			SupportMethod.AddChildFormDockTop(new FormTimKiem("s"), this.panelNoiDung);
		}

		
	}
}
