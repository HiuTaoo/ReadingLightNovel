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
		public LayoutQuanLyTruyen()
		{
			InitializeComponent();
			customizeDesing();
		}
		private void customizeDesing()
		{
			panelChonVolume.Visible = false;
			panelChonChapter.Visible = false;
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
			showPanel(panelChonVolume);
			
			
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
				MessageBox.Show("ngu");
			}
		}
	}
}
