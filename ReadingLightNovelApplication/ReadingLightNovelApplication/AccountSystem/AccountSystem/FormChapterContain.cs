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
	public partial class FormChapterContain : Form
	{	
		SupportMethod supportMethod = new SupportMethod();
		private string maChapter;
		public FormChapterContain(string maChapter)
		{
			InitializeComponent();			
			this.maChapter = maChapter;
		}

		private void FormChapterContain_Load(object sender, EventArgs e)
		{
			DataTable tenChapter = supportMethod.DataReader("select Chapter.TenChapter\r\nfrom Chapter\r\nwhere Chapter.MaChapter = N'" + maChapter + "'");
			btnTenChapter.Text = tenChapter.Rows[0]["TenChapter"].ToString();

			btnXoaChapter.Click += xoaChapter;

		}

		private void btnTenChapter_MouseUp(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Right)
			{
				contextMenuStrip1.Show(btnTenChapter, e.Location);
			}
			else
			{


			}
		}

		private void xoaChapter(object sender, EventArgs e)
		{
			DataTable tenChapter = supportMethod.DataReader("select Chapter.TenChapter\r\nfrom Chapter\r\nwhere Chapter.MaChapter = N'" + maChapter + "'");
			DialogResult result = MessageBox.Show("Bạn có muốn xóa chapter " + tenChapter.Rows[0]["TenChapter"].ToString() +"?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


			DataTable maTacPham = supportMethod.DataReader("select TacPham.MaTacPham\r\nfrom TacPham inner join Volume on Volume.MaTacPham = TacPham.MaTacPham\r\n\tinner join Chapter on Chapter.MaVolume = Volume.MaVolume\r\nwhere Chapter.MaChapter = N'" + maChapter + "'");
			// Kiểm tra kết quả từ MessageBox
			if (result == DialogResult.Yes)
			{
				supportMethod.DataChange("delete LichSu\r\nwhere LichSu.MaChapter = N'" + maChapter + "'");
				supportMethod.DataChange("delete BinhLuan\r\nwhere BinhLuan.MaChapter = N'" + maChapter + "'");
				MessageBox.Show(tenChapter.Rows[0]["TenChapter"].ToString() + " đã được xóa");
				//MessageBox.Show(maTacPham.Rows[0]["MaTacPham"].ToString());
				LayOutSystem layOutSystem = this.ParentForm.ParentForm.ParentForm as LayOutSystem;
				Panel panel = supportMethod.getPanel(layOutSystem, "panelHienChiTiet");
				panel.Controls.Clear();
				supportMethod.AddChildFormDockTop(new FormEditTruyen(maTacPham.Rows[0]["MaTacPham"].ToString()), panel);
			}
			else
			{
				
			}
		}
	}
}
