using Guna.UI2.WinForms;
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
    public partial class FormList : Form
    {
        SupportMethod dataload = new SupportMethod();
        string matp;
        public FormList(string machapter)
        {
            InitializeComponent();
            DataTable dt = dataload.DataReader("select TacPham.MaTacPham\r\nfrom TacPham " +
                "\r\ninner join Volume on Volume.MaTacPham = TacPham.MaTacPham" +
                "\r\ninner join Chapter on Chapter.MaVolume = Volume.MaVolume" +
                "\r\nwhere Chapter.MaChapter = N'"+ machapter +"'");
            matp = dt.Rows[0][0].ToString();
            dt.Dispose();
        }

        

        private void FormList_Load(object sender, EventArgs e)
        {
            DataTable dt = dataload.DataReader("select *\r\nfrom TacPham " +
                "\r\ninner join Volume on Volume.MaTacPham = TacPham.MaTacPham " +
                "inner join TacGia on TacGia.MaTacGia = TacPham.MaTacGia" +
                "\r\ninner join Chapter on Chapter.MaVolume = Volume.MaVolume" +
                "\r\nwhere TacPham.MaTacPham = N'" + matp + "'");
            lblName.Text = dt.Rows[0]["TenTacPham"].ToString();
            lblTacGia.Text = dt.Rows[0]["TenTacGia"].ToString();
            
            try
            {
                Image image = Image.FromFile(Application.StartupPath + "\\Asset\\DataLightNovel\\"
                        + dt.Rows[0]["MaTacPham"].ToString() + "\\" + dt.Rows[0]["Anh"].ToString());
                pbImg.Image = image;
            }
            catch {
                System.Drawing.Image image = System.Drawing.Image.FromFile(Application.StartupPath + "\\Asset\\DataLightNovel\\noLoadUser.png");
                pbImg.Image = image;
            }
            dt.Dispose ();

            DataTable dt1 = dataload.DataReader("select  Volume.MaVolume, Volume.TenVolume" +
                "\r\nfrom TacPham \r\ninner join Volume on Volume.MaTacPham = TacPham.MaTacPham" +
                "\r\ninner join TacGia on TacGia.MaTacGia = TacPham.MaTacGia" +
                "\r\nwhere TacPham.MaTacPham = N'" + matp + "'");
            foreach (DataRow row in dt1.Rows)
            {
                dataload.AddChildFormDockTop(new FormListItem(row["MaVolume"].ToString()), this.panelItem);
                
            }
        }

        
    }
}
