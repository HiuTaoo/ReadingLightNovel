using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingLightNovelApplication
{
	public partial class FormTimKiem : Form
	{
		private SupportMethod supportMethod = new SupportMethod();
		Form activeForm = null;
		public FormTimKiem()
		{
			InitializeComponent();
		}

		private void FormTimKiem_Load(object sender, EventArgs e)
		{
			supportMethod.AddChildFormDockTop(new FormTimKiemNangCao(), panelNoiDung);
		}
	}
}
