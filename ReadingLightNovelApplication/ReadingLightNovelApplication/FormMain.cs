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
    public partial class FormMain : Form
    {
        private Form activeForm = null;
        SupportMethod SupportMethod = new SupportMethod();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
			//SupportMethod.openChildForm(this.activeForm, new LayoutLogged(), this.panelMain);
			SupportMethod.openChildFormDockTop(this.activeForm, new FormLayoutDangNhap(), this.panelMain);
		}

        public Form getActiveForm()
        {
            return activeForm;
        }

        

	}
}
