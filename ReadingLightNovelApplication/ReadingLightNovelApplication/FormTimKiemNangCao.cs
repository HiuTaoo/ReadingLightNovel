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
	public partial class FormTimKiemNangCao : Form
	{
		SupportMethod supportMethod = new SupportMethod();
		public FormTimKiemNangCao()
		{
			InitializeComponent();
		}

		private void FormTimKiemNangCao_Load(object sender, EventArgs e)
		{
			DataTable data = supportMethod.DataReader("select TheLoai.MaTheLoai, TheLoai.TenTheLoai" +
				"\r\nfrom TheLoai" +
				"\r\norder by TheLoai.TenTheLoai ");

			Stack<string> stack = new Stack<string>();
			foreach (DataRow row in data.Rows)
			{
				stack.Push(row["MaTheLoai"].ToString());
			}
			foreach(string item in stack)
			{
				supportMethod.AddChildFormDockNone(new FormTheLoaiCheckbox(item), flpTheLoai);

			}

		}

		public List<string> getLoc()
		{
			List<string> list = new List<string>();
			list.Add(txtTacGia.Text);
			list.Add(txtHoaSi.Text);
			if (cbTinhTrang.Text != "Tất cả")
			{
				list.Add(cbTinhTrang.Text);
			}
			else list.Add(null);

			bool ischecked = false;

			foreach (Control control in flpTheLoai.Controls)
			{				
				if(control.Tag != null)
				{
					list.Add(control.Tag.ToString());
					ischecked = true;
				}
			}
			if(!ischecked) 
			{
				list.Add(string.Empty);
			}
			return list;
		}
	}
}
