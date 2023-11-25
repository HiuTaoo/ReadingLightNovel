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
    public partial class FormSuggest : Form
    {
        SupportMethod dataload = new SupportMethod();
        string MaTp;
        public FormSuggest(string matacpham)
        {
            InitializeComponent();
            MaTp = matacpham;
        }

        private void FormSuggest_Load(object sender, EventArgs e)
        {
            DataTable dt = dataload.DataReader("select top 1 * \r\nfrom TacPham" +
                "\r\ninner join Volume on Volume.MaTacPham = TacPham.MaTacPham" +
                "\r\ninner join Chapter on Chapter.MaVolume = Volume.MaVolume" +
                "\r\nwhere TacPham.MaTacPham = N'"+MaTp+"'" +
                "\r\norder by Chapter.ThoiGianDang desc");
            lblName.Text = dt.Rows[0]["TenTacPham"].ToString();
            lblChapter.Text = dt.Rows[0]["TenChapter"].ToString();
            try
            {
                System.Drawing.Image image = System.Drawing.Image.FromFile(Application.StartupPath + "\\Asset\\DataLightNovel\\"
                    + dt.Rows[0]["MaTacPham"].ToString() + "\\" + dt.Rows[0]["Anh"].ToString());
                pbImg.Image = image;
            }
            catch {
                System.Drawing.Image image = System.Drawing.Image.FromFile(Application.StartupPath + "\\Asset\\DataLightNovel\\noLoadUser.png");
                pbImg.Image = image;
            }
            
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            LayoutLogged lg = dataload.getFormParent(this, "LayoutLogged") as LayoutLogged;
            Panel panel1 = dataload.getPanel(lg, "panelNoiDung");
            foreach (Control c in panel1.Controls)
            {
                c.Dispose();
            }
            
            dataload.openChildFormDockFill(lg.getActiveForm(), new FormContent(MaTp), panel1);
        }

        private void lblChapter_Click(object sender, EventArgs e)
        {
            DataTable dt2 = dataload.DataReader("select top 1 Volume.TenVolume, Chapter.TenChapter, Chapter.MaChapter, Chapter.ThoiGianDang" +
                "\r\nfrom TacPham \r\ninner join Volume on Volume.MaTacPham = TacPham.MaTacPham" +
                "\r\ninner join Chapter on Chapter.MaVolume = Volume.MaVolume" +
                "\r\nwhere TacPham.MaTacPham = '" + MaTp + "'" +
                "\r\norder by Chapter.ThoiGianDang desc");
            FormMain formMain = dataload.getFormMain(this) as FormMain;
            Panel panel1 = dataload.getPanel(formMain, "panelMain");
            foreach (Control c in panel1.Controls)
            {
                c.Dispose();
            }
            foreach (Form c in panel1.Controls)
            {
                c.Dispose();
            }
            dataload.openChildFormDockFill(formMain.getActiveForm(), new FormMainReading(dt2.Rows[0]["MaChapter"].ToString()), panel1);
        }
    }
}
