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
            SupportMethod.openChildFormDockFill(this.activeForm, new FormHome(), this.panelNoiDung);
            if(FormMain.isLogin == true)
            {
                SupportMethod.AddChildFormDockFill(new FormLogin(FormMain.TenDangNhap), this.panelLogin);
            }
            else
            {
                SupportMethod.AddChildFormDockFill(new FormLogout(), this.panelLogin);
            }

            
        }
    }
}
