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
	public partial class FormVolumeContain : Form
	{
		SupportMethod supportMethod = new SupportMethod();
		private string maVolume;
		public FormVolumeContain(string maVolume)
		{
			InitializeComponent();
			this.maVolume = maVolume;
		}

		private void FormVolumeContain_Load(object sender, EventArgs e)
		{
			btnThemChapter.Click += btnThemChapter_Click;

			//load tên volume
			DataTable tenVolume = supportMethod.DataReader("select Volume.TenVolume\r\nfrom Volume\r\nwhere Volume.MaVolume = N'" + maVolume + "'");
			btnTenVolume.Text = tenVolume.Rows[0]["TenVolume"].ToString();
			panelChapterContain.Visible = false;
			

			DataTable listChapter = supportMethod.DataReader("select * \r\nfrom Volume inner join Chapter on Chapter.MaVolume = Volume.MaVolume\r\nwhere Volume.MaVolume = N'" + maVolume + "'");
			foreach(DataRow row in listChapter.Rows)
			{
				supportMethod.AddChildFormDockTop(new FormChapterContain(row["MaChapter"].ToString()), panelChapterContain);
			}

			btnXoaVolume.Click += xoaVolume;
		}

		private void btnTenChapter_Click(object sender, EventArgs e)
		{

		}

		

		private void btnTenVolume_MouseUp(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Right)
			{
				contextMenuStrip1.Tag = maVolume;
				contextMenuStrip1.Show(btnTenVolume, e.Location);
			}
			else
			{
				//MessageBox.Show(panelVolumeContain.Size.ToString(), this.Size.ToString());
				panelChapterContain.Visible = !panelChapterContain.Visible;
				if(!panelChapterContain.Visible)
				{
					this.Size = btnTenVolume.Size;
				}
				
			}
		}

		private void btnSuaVolume_Click(object sender, EventArgs e)
		{


		}

		

		private void btnThemChapter_Click(Object sender, EventArgs e)
		{
			//MessageBox.Show(this.ParentForm.Name);
			FormEditTruyen formEditTruyen = this.ParentForm as FormEditTruyen;
			Panel panel = supportMethod.getPanel(formEditTruyen, "panelNoiDung");
			panel.Controls.Clear();
			supportMethod.AddChildFormDockTop(new FormAddChapter(maVolume, true), panel);

		}

		private void btnSapXepChapter_Click(Object sender, EventArgs e)
		{


		}

		private void xoaVolume(Object sender, EventArgs e)
		{
			DataTable tenVol = supportMethod.DataReader("select Volume.TenVolume\r\nfrom Volume\r\nwhere Volume.MaVolume = N'" + maVolume + "'");
			DialogResult result = MessageBox.Show("Bạn có muốn xóa chapter " + tenVol.Rows[0]["TenVolume"].ToString() + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			// Kiểm tra kết quả từ MessageBox
			DataTable tenTP = supportMethod.DataReader("select TacPham.MaTacPham\r\nfrom Volume inner join TacPham on TacPham.MaTacPham = Volume.MaTacPham\r\nwhere Volume.MaVolume = N'" + maVolume + "'");
			if (result == DialogResult.Yes)
			{

				DataTable chapterlist = supportMethod.DataReader("select Chapter.MaChapter\r\nfrom Volume inner join Chapter on Chapter.MaVolume = Volume.MaVolume\r\nwhere Volume.MaVolume = N'" + maVolume + "'");
				foreach(DataRow row in chapterlist.Rows) 
				{
					supportMethod.DataChange("delete LichSu\r\nwhere LichSu.MaChapter = N'" + row["MaChapter"] + "'");
					supportMethod.DataChange("delete BinhLuan\r\nwhere BinhLuan.MaChapter = N'" + row["MaChapter"] + "'");
				}

				supportMethod.DataChange("\r\ndelete Volume\r\nwhere Volume.MaVolume = N'" + maVolume + "'");
				MessageBox.Show("Đã xóa thành công");
				LayOutSystem layOutSystem = this.ParentForm.ParentForm as LayOutSystem;
				Panel panel = supportMethod.getPanel(layOutSystem, "panelHienChiTiet");
				panel.Controls.Clear();
				supportMethod.AddChildFormDockTop(new FormEditTruyen(tenTP.Rows[0]["MaTacPham"].ToString()), panel);
			}
			else
			{

			}
		}
	}
}
