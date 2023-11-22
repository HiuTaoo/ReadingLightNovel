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
	public partial class LayoutQuanLyTruyen : Form
	{
		SupportMethod sp =new SupportMethod();
        public static string themVolume;
        public static string them;
        public static string sua;

        public LayoutQuanLyTruyen()
		{
			InitializeComponent();
			customizeDesing();
		}
		private void customizeDesing()
		{
			panelChonVolume.Visible = false;
			panelChonChapter.Visible = false;
			panelXoaChapter.Visible = false;	
		}
		private void hidePanel()
		{
			if (panelChonVolume.Visible == true)
			{
				panelChonVolume.Visible = false;
			}
			if (panelChonChapter.Visible == true)
			{
				panelChonChapter.Visible = false;
			}
			if (panelXoaChapter.Visible == true)
			{
				panelXoaChapter.Visible = false;
			}
		}
		private void showPanel(Panel panel)
		{
			if (panel.Visible == false)
			{
				hidePanel();
				panel.Visible = true;
			}
			else
				panel.Visible = false;
		}
		private void cbChonTruyen_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			cbChonVolume.Items.Clear();
			showPanel(panelChonVolume);
			DataTable dt = sp.DataReader("select TacPham.MaTacPham" +
				"\r\nfrom TacPham \r\nwhere TacPham.TenTacPham = N'"+cbChonTruyen.Text+"'");
			string maTacPham = dt.Rows[0][0].ToString();
			themVolume = dt.Rows[0][1].ToString();
			DataTable dt1 = sp.DataReader("select Volume.TenVolume from Volume where Volume.MaTacPham = N'" + maTacPham + "'");
			foreach(DataRow row in dt1.Rows)
			{
				cbChonVolume.Items.Add(row["TenVolume"].ToString());
			}
			
		}
		private void btnChonVolume_Click(object sender, EventArgs e)
		{
			showPanel(panelChonChapter);
		}
		private Form activeForm = null;
		public void openChildForm(Form childForm)
		{
			if (activeForm != null)
			{
				activeForm.Close();
			}
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Top;
			panelHienChiTiet.Controls.Add(childForm);
			panelHienChiTiet.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}
		private void btnThemVolume_Click(object sender, EventArgs e)
		{
			openChildForm(new FormThemVolume());
		}

		private void btnThemChapter_Click(object sender, EventArgs e)
		{
			openChildForm(new FormThemChapter());
		}

		private void btnChonChapter_Click(object sender, EventArgs e)
		{
			if (cbChonVolume.Text == "")
			{
				MessageBox.Show("Vui lòng chọn volume");
				cbChonVolume.Focus();
			}
			showPanel(panelXoaChapter);
		}

		private void LayoutQuanLyTruyen_Load(object sender, EventArgs e)
		{
			DataTable dt = sp.DataReader("select TacPham.MaTacPham, TacPham.TenTacPham\r\nfrom TacPham");
			foreach (DataRow row in dt.Rows)
			{
				cbChonTruyen.Items.Add(row["TenTacPham"].ToString());
			}

		}

		private void cbChonVolume_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbChonChapter.Items.Clear();
			DataTable dt = sp.DataReader("select Volume.MaVolume" +
				"\r\nfrom Volume \r\nwhere Volume.TenVolume = N'" + cbChonVolume.Text + "'");
			string maVolume = dt.Rows[0][0].ToString();
			them = dt.Rows[0][0].ToString();
			DataTable dt1 = sp.DataReader("select Chapter.TenChapter from Chapter where Chapter.MaVolume = N'" + maVolume + "'");
			foreach (DataRow row in dt1.Rows)
			{
				cbChonChapter.Items.Add(row["TenChapter"].ToString());
			}
		}

        private void btnXoaChapter_Click(object sender, EventArgs e)
        {
            if (cbChonChapter.Text == "")
            {
                MessageBox.Show("Vui lòng chọn chapter");
            }
            else
            {
                DataTable dt = sp.DataReader("select Chapter.MaChapter" +
                "\r\nfrom Chapter \r\nwhere Chapter.MaVolume = N'" + them + "'");
                string maChapter = dt.Rows[0][0].ToString();
                sp.DataChange("delete from Chapter where Chapter.MaChapter = N'" + maChapter + "'");
                MessageBox.Show("Bạn đã xóa thành công");
                cbChonChapter.Text = "";
				foreach(Control c in panelHienChiTiet.Controls)
				{
					c.Dispose();
				}
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
			openChildForm(new FormSuaChapter());
        }

        private void cbChonChapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = sp.DataReader("select Chapter.MaChapter" +
    "\r\nfrom Chapter \r\nwhere Chapter.MaVolume = N'" + them + "'");
            string maChapter = dt.Rows[0][0].ToString();
            sua = dt.Rows[0][0].ToString();
            DataTable dt1 = sp.DataReader("select Chapter.TenChapter from Chapter where Chapter.MaChapter = N'" + maChapter + "'");
            foreach (DataRow row in dt1.Rows)
            {
                cbChonChapter.Items.Add(row["TenChapter"].ToString());
            }

        }
    }
}
