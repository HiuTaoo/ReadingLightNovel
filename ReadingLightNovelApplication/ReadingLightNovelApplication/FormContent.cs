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
        private string MaTacPham;
        public FormContent(string MaTacPham)
        {
            InitializeComponent();
            this.MaTacPham = MaTacPham;
        }

        private void FormContent_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            SupportMethod.openChildFormDockTop(this.activeForm, new FormProperties(MaTacPham), this.panelContent);
=======
            SupportMethod.openChildFormDockFill(this.activeForm, new FormProperties(ma), this.panelContent);
>>>>>>> 91e24ede06a4b45a03a20a3c9d681c4595ebb3f4
        }
    }
}
