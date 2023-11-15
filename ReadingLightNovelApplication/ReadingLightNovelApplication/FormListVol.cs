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
    public partial class FormListVol : Form
    {
        SupportMethod dataload = new SupportMethod();
        string ma ;
        public FormListVol(string mavol)
        {
            InitializeComponent();
            ma = mavol;
        }

        private void FormListVol_Load(object sender, EventArgs e)
        {
            DataTable dtbase = dataload.DataReader("select * \r\nfrom Volume inner join Chapter on Chapter.MaVolume = Volume.MaVolume" +
                "\r\nwhere Volume.MaVolume = '"+ ma +"'");
            if(dtbase.Rows.Count != 0)
            {
                lblTenVol.Text = dtbase.Rows[0]["TenVolume"].ToString();
                Image image = Image.FromFile(Application.StartupPath + "\\Asset\\DataLightNovel\\"
                        + dtbase.Rows[0]["MaTacPham"].ToString() + "\\" + dtbase.Rows[0]["TenVolume"].ToString() + "\\" + dtbase.Rows[0]["Anh"].ToString());
                imgVol.Image = image;
                for (int i = 0; i < dtbase.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = dtbase.Rows[i]["TenChapter"].ToString();
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dtbase.Rows[i]["ThoiGianDang"].ToString() });
                    lvChapter.Items.Add(item);
                }
            }
            if (dtbase.Rows.Count == 0)
            {
                DataTable dt = dataload.DataReader("select Volume.Anh, Volume.TenVolume, Volume.MaTacPham, Volume.Stt " +
                    "\r\nfrom TacPham inner join Volume on Volume.MaTacPham = TacPham.MaTacPham" +
                    "\r\nwhere Volume.MaVolume = '"+ ma +"' ");
                lblTenVol.Text = dt.Rows[0]["TenVolume"].ToString();
                Image image = Image.FromFile(Application.StartupPath + "\\Asset\\DataLightNovel\\" + dt.Rows[0]["MaTacPham"].ToString() + "\\" + dt.Rows[0]["TenVolume"].ToString() + "\\" + dt.Rows[0]["Anh"].ToString());
                imgVol.Image = image;
            }
            

        }

        private void lvChapter_DoubleClick(object sender, EventArgs e)
        {
            
        }

        
    }
}
