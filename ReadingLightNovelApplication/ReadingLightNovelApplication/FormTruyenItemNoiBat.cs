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
	public partial class FormTruyenItemNoiBat : Form
	{
		private string maTacPham;
		SupportMethod supportMethod = new SupportMethod();
		public FormTruyenItemNoiBat(string maTacPham)
		{
			InitializeComponent();
			this.maTacPham = maTacPham;
		}

		private void FormTruyenItemNoiBat_Load(object sender, EventArgs e)
		{
			DataTable data = supportMethod.DataReader("select TacPham.MaTacPham, TacPham.TenTacPham, TacPham.Anh" +
				"\r\nfrom TacPham\r\nwhere TacPham.MaTacPham = '" + maTacPham + "'");
			try
			{
                panelAnh.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Asset\\DataLightNovel\\"
                + data.Rows[0]["MaTacPham"].ToString() + "\\" + data.Rows[0]["Anh"].ToString());
            }
			catch { }
			btnTenTruyen.Text = data.Rows[0]["TenTacPham"].ToString();
		}

		private void btnTenTruyen_MouseHover(object sender, EventArgs e)
		{
			btnTenTruyen.ForeColor = Color.Green;
		}

		private void btnTenTruyen_MouseLeave(object sender, EventArgs e)
		{
			btnTenTruyen.ForeColor = Color.White;
		}

		private void btnTenTruyen_Click(object sender, EventArgs e)
		{
			supportMethod.openChildFormFromForm("LayoutLogged", "panelNoiDung", new FormContent(maTacPham), this);
		}
	}
}
