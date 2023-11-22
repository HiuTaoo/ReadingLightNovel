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
	public partial class FormThemChapter : Form
	{
		SupportMethod sp = new SupportMethod();
		string lyrics;
		public FormThemChapter()
		{
			InitializeComponent();
		}
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
			string []lyric = lbTapTin.Text.Split('.');
            for (int i = 0; i < lyric.Length - 1; i++)
            {
                lyrics += lyric[i];
            }
            int startIndex = cbOdia.Text.Length + cbThuMuc.Text.Length + 1;
            lyrics = lyrics.Substring(startIndex);
            lyrics += ".txt";
            FileStream fs = new FileStream(lyrics, FileMode.Open);
			StreamReader rd = new StreamReader(fs, Encoding.UTF8);
			String giaitri = rd.ReadToEnd();
			rtxtNoiDung.Text = giaitri;

		}

		private void FormThemChapter_Load(object sender, EventArgs e)
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo d in drives)
			{
				cbOdia.Items.Add(d.Name);
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			DataTable checkname = sp.DataReader("select Chapter.TenChapter from Chapter where Chapter.MaVolume = N'"+LayoutQuanLyTruyen.them+"'");
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
				sp.DataChange("INSERT [dbo].[Chapter] ([MaChapter], [TenChapter], [ThoiGianDang], [Nguon], [MaVolume], [Stt]) " +
					"VALUES (N'Chapter"+((int)dt.Rows[0][0] + 1).ToString() + "', N'"+rtxtTieuDe.Text+"',N'"+now.ToString()+"', N'"+lyrics+"', N'"+ LayoutQuanLyTruyen.them + "', 2)\r\n");
				MessageBox.Show("Bạn đã thêm thành công");
				this.Close();
			}
			
		}

        private void btnHuy_Click(object sender, EventArgs e)
        {
			this.Close();
        }
    }
}
