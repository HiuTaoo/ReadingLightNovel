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
    public partial class FormContent : Form
    {
        private Form activeForm = null;
        SupportMethod SupportMethod = new SupportMethod();
        public FormContent()
        {
            InitializeComponent();
        }

        private void FormContent_Load(object sender, EventArgs e)
        {
            SupportMethod.openChildFormDockTop(this.activeForm, new FormProperties(), this.panelContent);
        }
    }
}
