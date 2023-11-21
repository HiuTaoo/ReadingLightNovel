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
	public partial class FormTimKiemKetQua : Form
	{
		private SupportMethod supportMethod = new SupportMethod();
		private List<string> list = new List<string>();
		public FormTimKiemKetQua(List<string> list)
		{
			InitializeComponent();
			this.list = list;
		}

		private void FormTimKiemKetQua_Load(object sender, EventArgs e)
		{
			Stack<string> strings = new Stack<string>();
			foreach(string s in list)
			{
				strings.Push(s);
			}
			foreach(string s in strings)
			{
				supportMethod.AddChildFormDockNone(new FormTruyenItem(s), flpKetQua);
			}
		}

		private void flpKetQua_AutoSizeChanged(object sender, EventArgs e)
		{
			this.Height = flpKetQua.Height;
		}
	}
}
