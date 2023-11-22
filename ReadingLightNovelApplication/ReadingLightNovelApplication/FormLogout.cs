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
                LayoutLogged lg = SupportMethod.getFormParent(this, "LayoutLogged") as LayoutLogged;
                Panel panel1 = SupportMethod.getPanel(lg, "panelNoiDung");
                if(lg.isclick == false)
                {
                    SupportMethod.AddChildFormDockFill(new FormLayoutDangNhap(), panel1);
                lg.setClick(true);
                }
                
        }
    }
}
