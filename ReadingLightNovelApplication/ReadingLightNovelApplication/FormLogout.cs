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
    public partial class FormLogout : Form
    {
        SupportMethod SupportMethod = new SupportMethod();
        public FormLogout()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormMain formMain = SupportMethod.getFormMain(this) as FormMain;
            Panel panel1 = SupportMethod.getPanel(formMain, "panelMain");
            SupportMethod.openChildFormDockFill(formMain.getactive(), new FormLayoutDangNhap(), panel1);

        }
    }
}
