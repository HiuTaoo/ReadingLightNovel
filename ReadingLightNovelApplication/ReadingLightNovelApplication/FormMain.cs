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
        public Form getactive()
        {
            return activeForm;
        }
        SupportMethod SupportMethod = new SupportMethod();
        public static bool isDarkMode = false;
        public static string TenDangNhap = string.Empty;
        public static bool isRemember;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
			SupportMethod.openChildFormDockFill(this.activeForm, new LayoutLogged(), this.panelMain);
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
