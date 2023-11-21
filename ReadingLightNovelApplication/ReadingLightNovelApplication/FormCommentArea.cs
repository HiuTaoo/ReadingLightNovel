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
    public partial class FormCommentArea : Form
    {
        SupportMethod dataload = new SupportMethod();
        string ma = "";
        public FormCommentArea(string machapter)
        {
            InitializeComponent();
            ma = machapter;
        }

        public string getMa()
        {
            return ma;
        }


        public void FormCommentArea_Load(object sender, EventArgs e)
        {
            foreach (FormComment c in panelCmt.Controls.OfType<FormComment>().ToList())
            {
                c.Close();
                c.Dispose();
            }
            panelCmt.Controls.Clear();

            DataTable dt7 = dataload.DataReader("select * \r\nfrom TacPham " +
               "\r\ninner join Volume on Volume.MaTacPham = TacPham.MaTacPham" +
               "\r\ninner join Chapter on Chapter.MaVolume = Volume.MaVolume" +
               "\r\ninner join BinhLuan on BinhLuan.MaChapter = Chapter.MaChapter" +
                   "\r\nwhere Chapter.MaChapter = '" + ma + "'" +
                   "order by BinhLuan.ThoiGian desc");
            foreach (DataRow dr in dt7.Rows)
            {
                dataload.AddChildFormDockTop(new FormComment(dr["MaBinhLuan"].ToString()), this.panelCmt);
            }
            dt7.Dispose();

        }

        private void btnDangCmt_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            if(FormMain.isLogin == true)
            {
                dataload.DataChange("INSERT [dbo].[BinhLuan] ([MaBinhLuan], [TenDangNhap], [MaChapter], [NoiDung],  [ThoiGian]) " +
                    " VALUES (N'BL"+ date.ToString()+ "', N'"+ FormMain.TenDangNhap +"', N'" + ma +"',  N'"+ tbCmt.Text + "', N'"+ date.ToString() +"')\r\n");

                //Load lại cmt
                foreach (FormComment c in panelCmt.Controls.OfType<FormComment>().ToList())
                {
                    c.Close();
                    c.Dispose();
                }
                panelCmt.Controls.Clear();

                DataTable dt7 = dataload.DataReader("select * \r\nfrom TacPham " +
                   "\r\ninner join Volume on Volume.MaTacPham = TacPham.MaTacPham" +
                   "\r\ninner join Chapter on Chapter.MaVolume = Volume.MaVolume" +
                   "\r\ninner join BinhLuan on BinhLuan.MaChapter = Chapter.MaChapter" +
                   "\r\nwhere Chapter.MaChapter = '" + ma + "'" +
                   "order by BinhLuan.ThoiGian desc");
                foreach (DataRow dr in dt7.Rows)
                {
                    dataload.AddChildFormDockTop(new FormComment(dr["MaBinhLuan"].ToString()), this.panelCmt);
                }
                dt7.Dispose();
                tbCmt.Text = "";
            }
            else
            {
                MessageBox.Show("Bạn chưa đăng nhập");
                FormMain formMain = dataload.getFormMain(this) as FormMain;
                Panel panel1 = dataload.getPanel(formMain, "panelMain");

                dataload.openChildFormDockFill(formMain.getactive(), new FormLayoutDangNhap(), panel1);
            }
        }
    }
}
