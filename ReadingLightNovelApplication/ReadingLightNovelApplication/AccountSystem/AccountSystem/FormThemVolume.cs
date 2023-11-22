using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingLightNovelApplication.AccountSystem
{
	public partial class FormThemVolume : Form
	{
		SupportMethod sp = new SupportMethod();
		public FormThemVolume()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataTable dt = sp.DataReader("select COUNT(MaVolume)\r\nfrom Volume");
            if (txtTieude.Text == "")
			{
				MessageBox.Show("Vui lòng thêm tên");
			}
			else
			{
				sp.DataChange("INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) " +
					"VALUES (N'V" + ((int)dt.Rows[0][0] +1).ToString()+"', N'"+txtTieude.Text+"', N'DALVol1.jpg', N'"+ LayoutQuanLyTruyen.themVolume + "', 3)\r\n");
                MessageBox.Show("Bạn đã thêm thành công");
                this.Close();
            }
        }
    }
}
