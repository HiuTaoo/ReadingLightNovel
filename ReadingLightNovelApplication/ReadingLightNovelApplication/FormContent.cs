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
        string ma = "TP001";
        public FormContent()
        {
            InitializeComponent();
        }

        private void FormContent_Load(object sender, EventArgs e)
        {
            SupportMethod.openChildFormDockFill(this.activeForm, new FormProperties(ma), this.panelContent);
        }
    }
}
