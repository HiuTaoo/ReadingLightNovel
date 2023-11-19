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
            SupportMethod.openChildFormDockFill(this.activeForm, new FormProperties(MaTacPham), this.panelContent);
=======
            SupportMethod.openChildFormDockTop(this.activeForm, new FormProperties(MaTacPham), this.panelContent);
>>>>>>> 7cc47d813d933803cb54d10c4e0bdd8eecbcb74a
        }
    }
}
