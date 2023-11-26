using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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
			btnXoaTruyen.Click += xoaTruyen;
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

		private void xoaTruyen(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			// Kiểm tra kết quả từ MessageBox
			if (result == DialogResult.Yes)
			{
				DataTable volumelist = supportMethod.DataReader("select Volume.MaVolume\r\nfrom TacPham inner join Volume on Volume.MaTacPham = TacPham.MaTacPham\r\nwhere TacPham.MaTacPham = N'" + maTacPham + "'");
				foreach(DataRow volume in volumelist.Rows)
				{
					DataTable chapterList = supportMethod.DataReader("select Chapter.MaChapter\r\nfrom Volume inner join Chapter on Chapter.MaVolume = Volume.MaVolume\r\nwhere Volume.MaVolume = N'"+ volume["MaVolume"].ToString() +"'");
					foreach(DataRow chapter in chapterList.Rows)
					{
						supportMethod.DataChange("delete LichSu\r\nwhere LichSu.MaChapter = N'" + chapter["MaChapter"] + "'");
						supportMethod.DataChange("delete BinhLuan\r\nwhere BinhLuan.MaChapter = N'" + chapter["MaChapter"] + "'");
					}

					supportMethod.DataChange("\r\ndelete Volume\r\nwhere Volume.MaVolume = N'" + volume["MaVolume"].ToString() + "'");
				}

				supportMethod.DataChange("delete ChiTietHoaSi\r\nwhere ChiTietHoaSi.MaTacPham = N'" + maTacPham + "'");
				supportMethod.DataChange("delete ChiTietTheLoai\r\nwhere ChiTietTheLoai.MaTacPham = N'" + maTacPham + "'");
				supportMethod.DataChange("delete YeuThich\r\nwhere YeuThich.MaTacPham = N'" + maTacPham + "'");
				supportMethod.DataChange("delete BinhChon\r\nwhere BinhChon.MaTacPham = N'" + maTacPham + "'");
				supportMethod.DataChange("delete BinhLuanTacPham\r\nwhere BinhLuanTacPham.MaTacPham = N'" + maTacPham + "'");
				MessageBox.Show("Đã xóa thành công");
				LayOutSystem layOutSystem = this.ParentForm as LayOutSystem;
				Panel panel = supportMethod.getPanel(layOutSystem, "panelHienChiTiet");
				panel.Controls.Clear();
				supportMethod.AddChildFormDockTop(new FormTruyenDaDich(), panel);
			}
			else
			{
				// Người dùng chọn "No"
				//MessageBox.Show("Bạn đã chọn No!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
