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
    public partial class FormListItem : Form
    {
        SupportMethod dataload = new SupportMethod();
        string mavol;
        public FormListItem(string mavolume)
        {
            InitializeComponent();
            mavol = mavolume;
        }

        private void FormListItem_Load(object sender, EventArgs e)
        {
            DataTable dt1 = dataload.DataReader("select Volume.TenVolume\r\nfrom Volume " +
                "\r\nwhere Volume.MaVolume = N'" + mavol + "'");
            btnTenVol.Text = dt1.Rows[0]["TenVolume"].ToString();
            dt1.Dispose();
            DataTable dt = dataload.DataReader("select *\r\nfrom Volume " +
                "\r\ninner join Chapter on Chapter.MaVolume = Volume.MaVolume" +
                "\r\nwhere Volume.MaVolume = N'" + mavol + "' " +
                "order by Chapter.MaChapter desc");           
            if(dt.Rows.Count > 0)
            {
                
                foreach (DataRow dr in dt.Rows)
                {
                    Guna2Button btn = new Guna2Button();
                    btn.Text = dr["TenChapter"].ToString();
                    btn.Name = dr["MaChapter"].ToString();
                    btn.TextAlign = HorizontalAlignment.Right;
                    btn.Dock = DockStyle.Top;
                    btn.FillColor = Color.White;
                    btn.ForeColor = Color.Black;
                    panelChapter.Controls.Add(btn);
                }
            }
        }
    }
}
