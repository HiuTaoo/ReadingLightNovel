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
    public partial class FormLogin : Form
    {
        SupportMethod SupportMethod = new SupportMethod();
        string tendn;
        public FormLogin(string tendangnhap)
        {
            InitializeComponent();
            tendn = tendangnhap;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            DataTable dt = SupportMethod.DataReader("select * " +
                "\r\nfrom [User]\r\nwhere [TenDangNhap] = '" + tendn +"'");
            try
            {
                Image image = Image.FromFile(Application.StartupPath + "\\Asset\\User\\"
                    + dt.Rows[0]["AnhDaiDien"].ToString());
                btnAvt.Image = image;
            }
            catch {
                Image image = Image.FromFile(Application.StartupPath + "\\Asset\\User\\noLoadUser.png");
                btnAvt.Image = image;
            }
                
            
            
        }

        private void btnYeuThich_Click(object sender, EventArgs e)
        {

            LayoutLogged  lg = SupportMethod.getFormParent(this, "LayoutLogged") as LayoutLogged;
            Panel panel1 =  SupportMethod.getPanel(lg, "panelNoiDung");
            foreach(Control c in panel1.Controls)
            {
                c.Dispose();    
            }
            SupportMethod.openChildFormDockFill(lg.getActiveForm(), new FormFollow(), panel1);
        }

        private void btnAvt_Click(object sender, EventArgs e)
        {
            FormMain formMain = SupportMethod.getFormMain(this) as FormMain;
            Panel panel1 = SupportMethod.getPanel(formMain, "panelMain");
            SupportMethod.openChildFormDockFill(formMain.getactive(), new FormProfile(tendn), panel1);
            /*LayoutLogged lg = SupportMethod.getFormParent(this,"LayoutLogged") as LayoutLogged;
            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                button.Name = "button" + (i + 1); // Đặt tên cho button
                button.Dock = DockStyle.Top;
                lg.getPanelMorong().Controls.Add(button);
            }*/
        }
    }
}
