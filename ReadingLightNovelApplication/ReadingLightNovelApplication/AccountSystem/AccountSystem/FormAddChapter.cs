using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingLightNovelApplication.AccountSystem.AccountSystem
{
	public partial class FormAddChapter : Form
	{

		SupportMethod supportMethod = new SupportMethod();
		string maVolume;
		int indexTrong = 1;
		bool isAdd;
		public FormAddChapter(string maVolume, bool isAdd)
		{
			InitializeComponent();
			this.maVolume = maVolume;
			this.isAdd = isAdd;
		}

		private void FormAddChapter_Load(object sender, EventArgs e)
		{
			if(this.isAdd)
			{
				panelSua.Visible = false;
			}
			else
			{
				panelThem.Visible = false;
			}


		}

		private void btnThemChapter_Click(object sender, EventArgs e)
		{
			themChapter();
		}

		private void themChapter()
		{
			if(txtTenChapter.Text == string.Empty)
			{

				errorProvider1.SetError(txtTenChapter, "Tên chapter cần được nhập");
				return;
			}

			if(rtbNoiDung.Text == string.Empty)
			{
				errorProvider1.SetError(rtbNoiDung, "Nội dung cần được nhập");
				return;
			}

			DataTable listChapter = supportMethod.DataReader("\r\nselect *\r\nfrom Chapter inner join Volume on Volume.MaVolume = Chapter.MaVolume\r\nwhere Volume.MaVolume = N'" + maVolume + "'");
			for(int i = 1; i <= listChapter.Rows.Count + 1; i++) 
			{
				string machap = maVolume + "CH" + i.ToString();
				DataTable timKiemIndex = supportMethod.DataReader("select *\r\nfrom Chapter\r\nwhere Chapter.MaChapter = N'" + machap + "'");
				if(timKiemIndex.Rows.Count == 0) 
				{
					indexTrong = i;
					break;
				}

				
			}

			DataTable getMaTacPham = supportMethod.DataReader("select * \r\nfrom Volume inner join TacPham on TacPham.MaTacPham = Volume.MaTacPham\r\nwhere Volume.MaVolume = N'" + maVolume + "'");

			string filePath = Application.StartupPath + "\\Asset\\DataLightNovel\\" + getMaTacPham.Rows[0]["MaTacPham"].ToString() + "\\" + getMaTacPham.Rows[0]["TenVolume"].ToString() + "\\" + txtTenChapter.Text + ".txt";

			try
			{
				// Sử dụng File.WriteAllText để ghi nội dung của RichTextBox vào tệp tin txt
				File.WriteAllText(filePath, rtbNoiDung.Text);

				MessageBox.Show("Lưu tệp tin txt thành công!");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi: {ex.Message}");
			}
			
			string maChapter = maVolume + "CH" + indexTrong.ToString();
			int sttMax;
			DataTable getsttmax = supportMethod.DataReader("select MAX(Chapter.Stt) as stt\r\nfrom Chapter inner join Volume on Volume.MaVolume = Chapter.MaVolume\r\nwhere Volume.MaVolume = N'" + maVolume + "'");
			Clipboard.SetText("select MAX(Chapter.Stt) as stt\r\nfrom Chapter inner join Volume on Volume.MaVolume = Chapter.MaVolume\r\nwhere Volume.MaVolume = N'" + maVolume + "'");
			/*if (int.Parse(getsttmax.Rows[0]["stt"].ToString()) >= 0)
			{
				MessageBox.Show(getsttmax.Rows[0]["stt"].ToString());
				sttMax = int.Parse(getsttmax.Rows[0]["stt"].ToString());
				
			}
			else
				sttMax = 1;*/
			supportMethod.DataChange("INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) VALUES (N'" + maChapter + "', N'" + txtTenChapter.Text + "', GETDATE() , N'" + txtTenChapter.Text + ".txt', N'" + maVolume + "', 1 )\r\n");
		}
	}
}
