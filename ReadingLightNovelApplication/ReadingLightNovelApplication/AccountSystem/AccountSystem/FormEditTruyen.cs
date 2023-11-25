using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingLightNovelApplication.AccountSystem.AccountSystem
{
	public partial class FormEditTruyen : Form
	{
		SupportMethod supportMethod = new SupportMethod();
		private string maTacPham;
		public FormEditTruyen(string maTacPham)
		{
			InitializeComponent();
			this.maTacPham = maTacPham;
		}

		private void FormEditTruyen_Load(object sender, EventArgs e)
		{
			btnThemVolume.Click += btnThemVolume_Click;

			loadData();
		}

		private void loadData()
		{
			DataTable tenTruyen = supportMethod.DataReader("select TacPham.TenTacPham\r\nfrom TacPham\r\nwhere TacPham.MaTacPham = N'" + maTacPham + "'");
			btnTenTruyen.Text = tenTruyen.Rows[0]["TenTacPham"].ToString();
			

			DataTable listVolume = supportMethod.DataReader("select Volume.MaVolume\r\nfrom TacPham inner join Volume on Volume.MaTacPham = TacPham.MaTacPham where TacPham.MaTacPham = N'" + maTacPham + "'");
			//panelVolumeContain.Visible = false; //ẩn đi panel mẫu
			Clipboard.SetText("select Volume.MaVolume\r\nfrom TacPham inner join Volume on Volume.MaTacPham = TacPham.MaTacPham where TacPham.MaTacPham = N'" + maTacPham + "'");
			foreach(DataRow row in listVolume.Rows)
			{
				supportMethod.AddChildFormDockTop(new FormVolumeContain(row["MaVolume"].ToString()), panelVolumeContain);
			}
		}

		private void btnTenTruyen_MouseUp(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Right)
			{
				contextMenuStrip1.Show(btnTenTruyen, e.Location);
			}
			else
			{
				panelVolumeContain.Visible = !panelVolumeContain.Visible;
			}
		}

		private void btnThemVolume_Click(object sender, EventArgs e)
		{
			panelNoiDung.Controls.Clear();
			supportMethod.AddChildFormDockTop(new FormAddVolume(maTacPham, true), panelNoiDung);
		}
	}
}
