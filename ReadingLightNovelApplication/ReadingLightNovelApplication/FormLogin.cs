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
            Image image = Image.FromFile(Application.StartupPath + "\\Asset\\User\\"
                    + dt.Rows[0]["AnhDaiDien"].ToString());
            btnAvt.Image = image;
        }
    }
}
