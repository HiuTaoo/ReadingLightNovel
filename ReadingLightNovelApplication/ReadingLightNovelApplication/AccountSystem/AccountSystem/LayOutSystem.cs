using ReadingLightNovelApplication.AccountSystem;
using ReadingLightNovelApplication.AccountSystem.AccountSystem;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ReadingLightNovelApplication
{
	public partial class LayOutSystem : Form
	{
		private FormHomeSystem anotherForm;
		SupportMethod supportMethod = new SupportMethod();
		
		public LayOutSystem()
		{
			InitializeComponent();
			customizeDesing();
		}
		private void customizeDesing()
		{
			panelTruyendich.Visible = false;
		}
		private void hidePanel()
		{
			if(panelTruyendich.Visible == true)
			{
				panelTruyendich.Visible = false;
			}
		}
		private void showPanel(Panel panel)
		{
			if(panel.Visible == false)
			{
				hidePanel();
				panel.Visible = true;
			}
			else
				panel.Visible = false;
		}
		public void LayOutSystem_Load(object sender, EventArgs e)
		{
			openChildForm(new FormHomeSystem());
		}

		private void btnTruyenDich_Click(object sender, EventArgs e)
		{
			//showPanel(panelTruyendich);
			panelHienChiTiet.Controls.Clear();
			supportMethod.AddChildFormDockFill(new FormTruyenDaDich(), panelHienChiTiet);

		}
		public Form activeForm = null;
		public void openChildForm(Form childForm)
		{
			 if(activeForm != null)
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

		private void btnThemTruyen_Click(object sender, EventArgs e)
		{
			panelHienChiTiet.Controls.Clear();
			supportMethod.AddChildFormDockFill(new FormThemTruyen("HiuTao"), panelHienChiTiet);
		}

		private void btnHome_Click(object sender, EventArgs e)
		{

            FormMain formMain = supportMethod.getFormMain(this) as FormMain;
            Panel panel1 = supportMethod.getPanel(formMain, "panelMain");
            foreach (Control c in panel1.Controls)
            {
                c.Dispose();
            }


            LayoutLogged lg = new LayoutLogged();
            supportMethod.openChildFormDockFill(formMain.getactive(), lg, panel1);

        }


		private void btnBangDieuKhien_Click(object sender, EventArgs e)
		{
			openChildForm(new FormHomeSystem());
		}

		private void btnProfile_Click(object sender, EventArgs e)
		{
            LayoutLogged lg = supportMethod.getFormParent(this, "LayoutLogged") as LayoutLogged;

            Panel panel1 = supportMethod.getPanel(lg, "panelNoiDung");

            supportMethod.AddChildFormDockFill(new FormProfile(FormMain.TenDangNhap), panel1);
            lg.setVisible();
        }

		private void btnTruyendadang_Click(object sender, EventArgs e)
		{
			openChildForm(new FormTruyenDaDang());
			
		}

		private void btnTienIch_Click(object sender, EventArgs e)
		{
			openChildForm(new FormTienIch());

		}

		private void btnBinhLuan_Click(object sender, EventArgs e)
		{
			/*openChildForm(new FormComment());*/
		}

		private void btnThemNoiDung_Click(object sender, EventArgs e)
		{
			LayoutQuanLyTruyen ql = new LayoutQuanLyTruyen();
			ql.Show();
		}
	}
}
