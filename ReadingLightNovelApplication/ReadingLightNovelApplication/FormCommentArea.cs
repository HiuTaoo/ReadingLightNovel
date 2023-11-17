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
        public FormCommentArea(string matp)
        {
            InitializeComponent();
            ma = matp;
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
               "\r\nwhere TacPham.MaTacPham = '" + ma + "'");
            foreach (DataRow dr in dt7.Rows)
            {
                dataload.AddChildFormDockTop(new FormComment(dr["MaBinhLuan"].ToString()), this.panelCmt);
            }
            dt7.Dispose();

        }

        
    }
}
