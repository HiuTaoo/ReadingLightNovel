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
    public partial class FormNhomDich : Form
    {
        SupportMethod dataload = new SupportMethod();
        string MaTp;
        public FormNhomDich(string matacpham)
        {
            InitializeComponent();
            MaTp = matacpham;
        }

        private void FormNhomDich_Load(object sender, EventArgs e)
        {
            DataTable dt =  dataload.DataReader(" select *\r\n from TacPham inner join [User] on [User].TenDangNhap = TacPham.TenDangNhap" +
                "\r\n inner join NhomDich on NhomDich.MaNhom = TacPham.MaNhom " +
                "where TacPham.MaTacPham = '"+ MaTp +"'");
            try
            {
                System.Drawing.Image image = System.Drawing.Image.FromFile(Application.StartupPath
                + "\\Asset\\User\\"
                     + dt.Rows[0]["AnhDaiDien"].ToString());
                pbImg.Image = image;
                lblTenNhom.Text = dt.Rows[0]["TenNhom"].ToString();
                btnUser.Text = dt.Rows[0]["TenDangNhap"].ToString();
            }
            catch {
                DataTable dt1 = dataload.DataReader(" select *\r\n from TacPham " +
                "where TacPham.MaTacPham = '" + MaTp + "'");
                Image image = Image.FromFile(Application.StartupPath + "\\Asset\\User\\noLoadUser.png");
                pbImg.Image = image;
                lblTenNhom.Text = "Unknown";
                btnUser.Text = dt1.Rows[0]["TenDangNhap"].ToString();
            }
        }

        
    }
}
