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
	public partial class FormDatLaiMatKhauB1 : Form
	{
        SupportMethod SupportMethod = new SupportMethod();
        public FormDatLaiMatKhauB1()
		{
			InitializeComponent();
		}

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FormMain formMain = SupportMethod.getFormMain(this) as FormMain;
            Panel panel1 = SupportMethod.getPanel(formMain, "panelMain");
            SupportMethod.openChildFormDockFill(formMain.getactive(), new FormMain(), panel1);
        }
    }
}
