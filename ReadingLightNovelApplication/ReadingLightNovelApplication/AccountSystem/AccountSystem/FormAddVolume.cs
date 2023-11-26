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
	public partial class FormAddVolume : Form
	{
		SupportMethod supportMethod = new SupportMethod();
		private string maTacPham;
		OpenFileDialog openFileDialog1 = new OpenFileDialog();
		string namePicture = null;
		string filePath;
		bool isAdd;
		int indexTrong = 0;
		string mavolume = string.Empty;

		public FormAddVolume(string maTacPham, bool isAdd)
		{
			InitializeComponent();
			this.maTacPham = maTacPham;
			this.isAdd = isAdd;
		}

		private void btnThemVolume_Click(object sender, EventArgs e)
		{
			ThemVolume();
			string rootDirectory = Application.StartupPath + "\\Asset\\DataLightNovel\\" + maTacPham;
			string newDirectoryName = txtTenVolume.Text;
			string newDirectoryPath = Path.Combine(rootDirectory, newDirectoryName);
			if (!Directory.Exists(newDirectoryPath))
			{
				Directory.CreateDirectory(newDirectoryPath);
			}
			if (filePath != null)
			{
				
				string newFilePath = Path.Combine(newDirectoryPath, Path.GetFileName(filePath));

				// Lưu ảnh vào thư mục chỉ định
				File.Copy(filePath, newFilePath, true);
			}

			txtTenVolume.Text = string.Empty;
			picAnh.Image = null;
			//MessageBox.Show("ok");
		}

		private void btnThemAnh_Click(object sender, EventArgs e)
		{
			openFileDialog1.Filter = "Ảnh Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|Tất cả Files (*.*)|*.*";
			openFileDialog1.Title = "Chọn ảnh";

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				// Lấy đường dẫn tệp tin đã chọn
				filePath = openFileDialog1.FileName;

				// Hiển thị ảnh trong PictureBox
				picAnh.ImageLocation = filePath;
				namePicture = Path.GetFileName(filePath);


				picAnh.SizeMode = PictureBoxSizeMode.Zoom;
			}
		}

		private void FormAddVolume_Load(object sender, EventArgs e)
		{
			if(isAdd)
			{
				panelSua.Visible = false;
			}
			else
			{
				panelThem.Visible = false;
			}
			

		}

		private void ThemVolume()
		{
			//kiểm tra 
			if(txtTenVolume.Text == string.Empty)
			{
				errorProvider1.SetError(txtTenVolume, "Tên volume cần đc nhập");
				return;
			}

			DataTable listVolume = supportMethod.DataReader("select *\r\nfrom Volume inner join TacPham on TacPham.MaTacPham = Volume.MaTacPham\r\nwhere TacPham.MaTacPham = N'" + maTacPham + "'");
			for(int i = 0; i <= listVolume.Rows.Count; i++)
			{
				mavolume = maTacPham + "V" + i.ToString();
				DataTable timkiemIndex = supportMethod.DataReader("select *\r\nfrom Volume inner join TacPham on TacPham.MaTacPham = Volume.MaTacPham" +
					"\r\nwhere TacPham.MaTacPham = N'" + maTacPham + "' and Volume.MaVolume = N'" + mavolume + "'");
				if(timkiemIndex.Rows.Count == 0 )
				{
					indexTrong = i;
					break;
				}
			}

			DataTable sttMax = supportMethod.DataReader("select MAX(Volume.Stt) as stt\r\nfrom Volume inner join TacPham on TacPham.MaTacPham = Volume.MaTacPham\r\nwhere TacPham.MaTacPham = N'" + maTacPham +"' ");

			if(namePicture == string.Empty)
			{
				supportMethod.DataChange("INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'" + mavolume + "', N'" + txtTenVolume.Text.Trim() + "', NULL, N'" + maTacPham + "', " + sttMax.Rows[0]["stt"].ToString() + ")\r\n");
			}
			else
				supportMethod.DataChange("INSERT [dbo].[Volume] ([MaVolume], [TenVolume], [Anh], [MaTacPham], [Stt]) VALUES (N'" + mavolume + "', N'" + txtTenVolume.Text.Trim() + "', N'" + namePicture + "', N'" + maTacPham + "', " + sttMax.Rows[0]["stt"].ToString() + ")\r\n");

			
			
		}

		public string FormatNumber(int num, int sokitu)
		{
			// Sử dụng phương thức ToString để chuyển số nguyên thành chuỗi
			string numStr = num.ToString();

			// Sử dụng PadLeft để thêm các ký tự '0' vào đầu chuỗi
			numStr = numStr.PadLeft(sokitu, '0');

			return numStr;
		}

		private void btnXoaAnh_Click(object sender, EventArgs e)
		{
			picAnh.Image = null;
			filePath = null;
			namePicture = string.Empty;
		}

		
	}
}
