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
    public partial class FormFollow : Form
    {
        SupportMethod SupportMethod = new SupportMethod();
        public FormFollow()
        {
            InitializeComponent();
        }

        private void FormFollow_Load(object sender, EventArgs e)
        {
            if(FormMain.isLogin == true)
            {
                DataTable dt = SupportMethod.DataReader("select * " +
                    "\r\nfrom TacPham inner join TacGia on TacGia.MaTacGia =TacPham.MaTacGia" +
                    "\r\ninner join YeuThich on YeuThich.MaTacPham = TacPham.MaTacPham" +
                    "\r\ninner join [User] on [User].TenDangNhap = YeuThich.TenDangNhap" +
                    "\r\nwhere [User].TenDangNhap = '" +FormMain.TenDangNhap+ "'");
                foreach(DataRow t in dt.Rows)
                {
                    SupportMethod.AddChildFormDockTop(new FormFollowItem(t["MaTacPham"].ToString()),this.panelListFollow);
                }
                lblUserName.Text = FormMain.TenDangNhap;
            }
            
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            LayoutLogged lg = SupportMethod.getFormParent(this, "LayoutLogged") as LayoutLogged;
            Panel panel1 = SupportMethod.getPanel(lg, "panelNoiDung");
            foreach (Control c in panel1.Controls)
            {
                c.Dispose();
            }
            SupportMethod.openChildFormDockFill(lg.getActiveForm(), new FormLichSu(), panel1);
        }
    }
}
