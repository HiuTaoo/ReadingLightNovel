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

			foreach (DataRow row in data.Rows)
			{
				supportMethod.AddChildFormDockNone(new FormTheLoaiCheckbox(row["MaTheLoai"].ToString()), flpTheLoai);
			}
			
		}
	}
}
