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
    public partial class FormLichSu : Form
    {
        SupportMethod SupportMethod = new SupportMethod();
        public FormLichSu()
        {
            InitializeComponent();
        }

        private void FormLichSu_Load(object sender, EventArgs e)
        {
            if (FormMain.isLogin == true)
            {
                DataTable dt1 = SupportMethod.DataReader("select distinct TacPham.MaTacPham " +
                    "\r\nfrom TacPham\r\ninner join Volume on Volume.MaTacPham = TacPham.MaTacPham" +
                    "\r\ninner join Chapter on Chapter.MaVolume = Volume.MaVolume" +
                    "\r\ninner join LichSu on LichSu.MaChapter = Chapter.MaChapter" +
                    "\r\nwhere LichSu.TenDangNhap = N'" + FormMain.TenDangNhap + "'");
                foreach (DataRow dr in dt1.Rows)
                {
                    DataTable dt = SupportMethod.DataReader("select top 1 TacPham.MaTacPham, Volume.MaVolume, Chapter.MaChapter, LichSu.ThoiGian" +
                   "\r\nfrom TacPham \r\ninner join Volume on Volume.MaTacPham = TacPham.MaTacPham" +
                   "\r\ninner join Chapter on Chapter.MaVolume = Volume.MaVolume" +
                   "\r\ninner join LichSu on LichSu.MaChapter = Chapter.MaChapter" +
                   "\r\nwhere TacPham.MaTacPham = N'" + dr["MaTacPham"] + "'" +
                   "\r\norder by LichSu.ThoiGian desc");

                    foreach (DataRow t in dt.Rows)
                    {
                        SupportMethod.AddChildFormDockTop(new FormHistoryItem(t["MaTacPham"].ToString()), this.panelListFollow);
                    }
                    
                }
                lblUserName.Text = FormMain.TenDangNhap;


            }
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LayoutLogged lg = SupportMethod.getFormParent(this, "LayoutLogged") as LayoutLogged;
            Panel panel1 = SupportMethod.getPanel(lg, "panelNoiDung");
            foreach (Control c in panel1.Controls)
            {
                c.Dispose();
            }
            SupportMethod.openChildFormDockFill(lg.getActiveForm(), new FormFollow(), panel1);
        }
    }
}
