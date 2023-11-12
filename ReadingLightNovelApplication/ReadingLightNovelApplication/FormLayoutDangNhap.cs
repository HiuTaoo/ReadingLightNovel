using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ReadingLightNovelApplication
{
	public partial class FormLayoutDangNhap : Form
	{
		private Form activeForm = null;
		SupportMethod SupportMethod = new SupportMethod();
		FormMain FormMain = null;

		public FormLayoutDangNhap()
		{
			InitializeComponent();
			FormMain FormMain = (FormMain)SupportMethod.getFormMain(this);

		}

		private void FormLayoutDangNhap_Load(object sender, EventArgs e)
		{
			SupportMethod.openChildFormDockTop(this.activeForm, new FormDienDangNhap(), this.panelNoiDungDangNhap);

		}

		
	}
}
