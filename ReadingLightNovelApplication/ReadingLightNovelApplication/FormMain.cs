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
			SupportMethod.openChildFormDockFill(this.activeForm, new FormMainReading(), this.panelMain);
		}

        public Form getActiveForm()
        {
            return activeForm;
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
