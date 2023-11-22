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

namespace ReadingLightNovelApplication.AccountSystem
{
	public partial class FormSuaChapter : Form
	{
		public FormSuaChapter()
		{
			InitializeComponent();
		}
		SupportMethod sp = new SupportMethod();
		string lyrics;
		public string MaVolume { get; set; }

		private void cbOdia_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbThuMuc.Items.Clear();
			cbThuMuc.Text = "";
			lbTapTin.Items.Clear();
			string root = cbOdia.Text;
			root += "\\";
			DirectoryInfo Directory = new DirectoryInfo(root);
			DirectoryInfo[] Directories = Directory.GetDirectories("*.*");
			FileInfo[] Files = Directory.GetFiles();
			foreach (DirectoryInfo d in Directories)
			{
				cbThuMuc.Items.Add(d.Name);
			}
		}

		private void cbThuMuc_SelectedIndexChanged(object sender, EventArgs e)
		{
			lbTapTin.Items.Clear();
			rtxtNoiDung.Text = "";
			string[] files = Directory.GetFiles(cbOdia.Text + cbThuMuc.Text);
			foreach (string d in files)
			{
				lbTapTin.Items.Add(d);
			}
		}

		private void lbTapTin_SelectedIndexChanged(object sender, EventArgs e)
		{
			string[] lyric = lbTapTin.Text.Split('.');
			lyrics = string.Empty;
			for (int i = 0; i < lyric.Length - 1; i++)
			{
				lyrics += lyric[i];
			}
			lyrics += ".txt";
			int startIndex = cbOdia.Text.Length + cbThuMuc.Text.Length + 1;
			lyrics = lyrics.Substring(startIndex);
			FileStream fs1 = new FileStream(lyrics, FileMode.Open);
			StreamReader rd1 = new StreamReader(fs1, Encoding.UTF8);
			String giaitri = rd1.ReadToEnd();
			rtxtNoiDung.Text = giaitri;

		}

		private void FormSuaChapter_Load(object sender, EventArgs e)
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo d in drives)
			{
				cbOdia.Items.Add(d.Name);
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			DataTable checkname = sp.DataReader("select Chapter.TenChapter from Chapter where Chapter.MaVolume = N'" + LayoutQuanLyTruyen.them + "'");
			if (rtxtTieuDe.Text == "")
			{
				MessageBox.Show("Vui lòng nhập tên chapter");
			}
			/*else if(rtxtTieuDe.Text.ToLower() == checkname.Rows[0][0].ToString().ToLower())
			{
				MessageBox.Show("Vui lòng nhập tên chapter");
			}*/
			else
			{
				DateTime now = DateTime.Now;
				DataTable dt = sp.DataReader("select COUNT(MaChapter)\r\nfrom Chapter");
				sp.DataChange("UPDATE [dbo].[Chapter]\r\nSET " +
					"\r\n    [MaChapter] = N'"+ ((int)dt.Rows[0][0] + 1).ToString() + "'," +
					"\r\n    [TenChapter] = N'"+rtxtTieuDe.Text+"',\r\n    [ThoiGianDang] = N'"+now.ToString()+"'," +
					"[Nguon] = N'"+ lyrics + "', [MaVolume] = N'"+LayoutQuanLyTruyen.them+"', [Stt] = 1" +
					"\r\nWHERE " +
					"\r\n    [MaChapter] = N'"+LayoutQuanLyTruyen.sua+"';" +
					"\r\n");
				MessageBox.Show("Bạn đã sửa thành công");
				this.Close();
			}

		}

        private void btnHuy_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
