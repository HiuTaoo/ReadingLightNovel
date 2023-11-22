using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ReadingLightNovelApplication
{
    public partial class FormSapXep : Form
    {
        private int cbLuaChonIndex = 0;
        private string maTheLoai = string.Empty;
        private SupportMethod supportMethod = new SupportMethod();
        private int pageStart = 1;
        private int pageEnd = 1;
        private int pageSize = 7;
        private int pageCurrent = 1;
        private string commandTextForCount;
        public FormSapXep(int cbLuaChonIndex)
        {
            InitializeComponent();

            this.cbLuaChonIndex = cbLuaChonIndex;
        }

        public FormSapXep()
        {
            InitializeComponent();
        }

        public FormSapXep(string maTheLoai)
        {
            InitializeComponent();
            this.maTheLoai = maTheLoai;
        }

        public void setUpMacDinh()
        {
            cbLuaChon.SelectedIndex = cbLuaChonIndex;
            checkboxDaHoanThanh.Checked = true;
            checkboxDangTienHanh.Checked = true;
            checkboxTamNgung.Checked = true;

            checkboxTruyenDich.Checked = true;
            checkboxTruyenSangTac.Checked = false;
            checkboxConvert.Checked = false;

            panelGhiChu.Visible = false;
        }

        private void loadEventClickChuCai()
        {
            foreach (Guna2Button button in flpChuCai.Controls.OfType<Guna2Button>())
            {
                button.Click += eventClickChuCaiButton;
            }
            foreach (Guna2CircleButton button in flpChuCai.Controls.OfType<Guna2CircleButton>())
            {
                button.Click += eventClickChuCaiCircleButton;
            }

        }

        void eventClickChuCaiButton(object sender, EventArgs e)
        {
            foreach (Guna2Button btn in flpChuCai.Controls.OfType<Guna2Button>())
            {
                btn.FillColor = Color.Transparent;
                btn.ForeColor = Color.LightSeaGreen;

            }

            foreach (Guna2CircleButton btn in flpChuCai.Controls.OfType<Guna2CircleButton>())
            {
                btn.FillColor = Color.Transparent;
                btn.ForeColor = Color.LightSeaGreen;

            }
            Guna2Button button = sender as Guna2Button;
            flpChuCai.Tag = button.Text;
            button.FillColor = Color.LightSeaGreen;
        }

        void eventClickChuCaiCircleButton(object sender, EventArgs e)
        {
            foreach (Guna2Button btn in flpChuCai.Controls.OfType<Guna2Button>())
            {
                btn.FillColor = Color.Transparent;
                btn.ForeColor = Color.LightSeaGreen;
            }

            foreach (Guna2CircleButton btn in flpChuCai.Controls.OfType<Guna2CircleButton>())
            {
                btn.FillColor = Color.Transparent;
                btn.ForeColor = Color.LightSeaGreen;

            }
            Guna2CircleButton button = sender as Guna2CircleButton;
            flpChuCai.Tag = button.Text;
            button.FillColor = ColorTranslator.FromHtml("#36a189");
            button.ForeColor = Color.White;
        }

        public void loadGhiChu()
        {
            if (this.maTheLoai != string.Empty)
            {
                DataTable data = supportMethod.DataReader("select *\r\nfrom TheLoai\r\nwhere TheLoai.MaTheLoai = N'" + maTheLoai + "'\r\n");

                lbGhiChu.Text = data.Rows[0]["GhiChu"].ToString();
                panelGhiChu.Visible = true;
            }
        }

        private void FormSapXep_Load(object sender, EventArgs e)
        {
            setUpMacDinh();
            loadEventClickChuCai();

            string commandText = string.Empty;


            btnChuCaiApDung.Click += btnApDung;
            btnPhanLoaiApDung.Click += btnApDung;
            btnTinhTrangApDung.Click += btnApDung;
            loadTheLoai();
            btnPhanLoaiApDung.PerformClick();
            UpdatePaginationButtons();
        }

        private string getCommandText()
        {
            string commandText = string.Empty;
            switch (cbLuaChon.SelectedIndex)
            {
                case 0: // A-Z
                    commandText = "select sub.MaTacPham\r\nfrom (" +
                        "\r\nSELECT ROW_NUMBER() over(order by TacPham.TenTacPham) as rownuber, TacPham.TenTacPham, TacPham.MaTacPham, Volume.TenVolume, Chapter.TenChapter, Chapter.ThoiGianDang, TacPham.TinhTrang, TacPham.LoaiTruyen" +
                        "\r\n\t\t\t\t\r\n\t\t\t\tFROM TacPham\r\n\t\t\t\tINNER JOIN Volume ON TacPham.MaTacPham = Volume.MaTacPham" +
                        "\r\n\t\t\t\tINNER JOIN Chapter ON Volume.MaVolume = Chapter.MaVolume\r\n\t\t\t\tWHERE Chapter.ThoiGianDang = (    SELECT MAX(c1.ThoiGianDang)" +
                        "\r\n\t\t\t\t\t\tFROM Chapter c1 WHERE c1.MaVolume = Chapter.MaVolume)\r\n\t\t\t\tGROUP BY TacPham.MaTacPham, TacPham.TenTacPham, Volume.TenVolume, Chapter.TenChapter, Chapter.ThoiGianDang, TacPham.TinhTrang, TacPham.LoaiTruyen" +
                        "\r\n\t\t\t\t) as sub ";
                    if (maTheLoai != string.Empty)
                    {
                        commandText += " inner join ChiTietTheLoai on ChiTietTheLoai.MaTacPham = sub.MaTacPham ";
                    }
                    commandText += "\r\nwhere (1 = 1) ";
                    break;
                case 1: //Z - A
                    commandText = "select sub.MaTacPham\r\nfrom (" +
                        "\r\nSELECT ROW_NUMBER() over(order by TacPham.TenTacPham desc) as rownuber, TacPham.TenTacPham, TacPham.MaTacPham, Volume.TenVolume, Chapter.TenChapter, Chapter.ThoiGianDang, TacPham.TinhTrang, TacPham.LoaiTruyen" +
                        "\r\n\t\t\t\t\r\n\t\t\t\tFROM TacPham\r\n\t\t\t\tINNER JOIN Volume ON TacPham.MaTacPham = Volume.MaTacPham" +
                        "\r\n\t\t\t\tINNER JOIN Chapter ON Volume.MaVolume = Chapter.MaVolume\r\n\t\t\t\tWHERE Chapter.ThoiGianDang = (    SELECT MAX(c1.ThoiGianDang)" +
                        "\r\n\t\t\t\t\t\tFROM Chapter c1 WHERE c1.MaVolume = Chapter.MaVolume)\r\n\t\t\t\tGROUP BY TacPham.MaTacPham, TacPham.TenTacPham, Volume.TenVolume, Chapter.TenChapter, Chapter.ThoiGianDang, TacPham.TinhTrang, TacPham.LoaiTruyen" +
                        "\r\n\t\t\t\t) as sub ";
                    if (maTheLoai != string.Empty)
                    {
                        commandText += " inner join ChiTietTheLoai on ChiTietTheLoai.MaTacPham = sub.MaTacPham ";
                    }
                    commandText += "\r\nwhere (1 = 1) ";
                    break;
                case 2:     //Mới cập nhật
                    commandText = "select sub.MaTacPham\r\nfrom (" +
                        "\r\nSELECT ROW_NUMBER() over(order by Chapter.ThoiGianDang desc) as rownuber, TacPham.TenTacPham, TacPham.MaTacPham, Volume.TenVolume, Chapter.TenChapter, Chapter.ThoiGianDang, TacPham.TinhTrang, TacPham.LoaiTruyen" +
                        "\r\n\t\t\t\t\r\n\t\t\t\tFROM TacPham\r\n\t\t\t\tINNER JOIN Volume ON TacPham.MaTacPham = Volume.MaTacPham" +
                        "\r\n\t\t\t\tINNER JOIN Chapter ON Volume.MaVolume = Chapter.MaVolume\r\n\t\t\t\tWHERE Chapter.ThoiGianDang = (    SELECT MAX(c1.ThoiGianDang)" +
                        "\r\n\t\t\t\t\t\tFROM Chapter c1 WHERE c1.MaVolume = Chapter.MaVolume)\r\n\t\t\t\tGROUP BY TacPham.MaTacPham, TacPham.TenTacPham, Volume.TenVolume, Chapter.TenChapter, Chapter.ThoiGianDang, TacPham.TinhTrang, TacPham.LoaiTruyen" +
                        "\r\n\t\t\t\t) as sub ";
                    if (maTheLoai != string.Empty)
                    {
                        commandText += " inner join ChiTietTheLoai on ChiTietTheLoai.MaTacPham = sub.MaTacPham ";
                    }
                    commandText += "\r\nwhere (1 = 1) ";
                    break;
                case 3: // Truyện mới
                    commandText = "select *\r\nfrom (" +
                        "\r\nSELECT ROW_NUMBER() over(order by TacPham.ThoiGianTao desc) as rownuber, TacPham.TenTacPham, TacPham.MaTacPham, Volume.TenVolume, Chapter.TenChapter, Chapter.ThoiGianDang, TacPham.TinhTrang, TacPham.LoaiTruyen" +
                        "\r\n\t\t\t\t\r\n\t\t\t\tFROM TacPham\r\n\t\t\t\tINNER JOIN Volume ON TacPham.MaTacPham = Volume.MaTacPham" +
                        "\r\n\t\t\t\tINNER JOIN Chapter ON Volume.MaVolume = Chapter.MaVolume\r\n\t\t\t\tWHERE Chapter.ThoiGianDang = (    SELECT MAX(c1.ThoiGianDang)" +
                        "\r\n\t\t\t\t\t\tFROM Chapter c1 WHERE c1.MaVolume = Chapter.MaVolume)\r\n\t\t\t\tGROUP BY TacPham.MaTacPham, TacPham.TenTacPham, Volume.TenVolume, Chapter.TenChapter, Chapter.ThoiGianDang, TacPham.TinhTrang, TacPham.LoaiTruyen, TacPham.ThoiGianTao " +
                        "\r\n\t\t\t\t) as sub ";
                    if (maTheLoai != string.Empty)
                    {
                        commandText += " inner join ChiTietTheLoai on ChiTietTheLoai.MaTacPham = sub.MaTacPham ";
                    }
                    commandText += "\r\nwhere (1 = 1) ";
                    break;
                case 4: // Theo dõi
                    commandText = "select sub.MaTacPham\r\nfrom (" +
                        "\r\nSELECT ROW_NUMBER() over(order by Chapter.ThoiGianDang desc) as rownuber, TacPham.TenTacPham, TacPham.MaTacPham, Volume.TenVolume, Chapter.TenChapter, Chapter.ThoiGianDang, TacPham.TinhTrang, TacPham.LoaiTruyen" +
                        "\r\n\t\t\t\t\r\n\t\t\t\tFROM TacPham\r\n\t\t\t\tINNER JOIN Volume ON TacPham.MaTacPham = Volume.MaTacPham" +
                        "\r\n\t\t\t\tINNER JOIN Chapter ON Volume.MaVolume = Chapter.MaVolume\r\n\t\t\t\tWHERE Chapter.ThoiGianDang = (    SELECT MAX(c1.ThoiGianDang)" +
                        "\r\n\t\t\t\t\t\tFROM Chapter c1 WHERE c1.MaVolume = Chapter.MaVolume)\r\n\t\t\t\tGROUP BY TacPham.MaTacPham, TacPham.TenTacPham, Volume.TenVolume, Chapter.TenChapter, Chapter.ThoiGianDang, TacPham.TinhTrang, TacPham.LoaiTruyen" +
                        "\r\n\t\t\t\t) as sub ";
                    if (maTheLoai != string.Empty)
                    {
                        commandText += " inner join ChiTietTheLoai on ChiTietTheLoai.MaTacPham = sub.MaTacPham ";
                    }
                    commandText += "\r\nwhere (1 = 1) ";
                    break;
                case 5: // Top tháng
                    commandText = "select sub.MaTacPham\r\nfrom (" +
                        "\r\nSELECT ROW_NUMBER() over(order by Chapter.ThoiGianDang desc) as rownuber, TacPham.TenTacPham, TacPham.MaTacPham, Volume.TenVolume, Chapter.TenChapter, Chapter.ThoiGianDang, TacPham.TinhTrang, TacPham.LoaiTruyen" +
                        "\r\n\t\t\t\t\r\n\t\t\t\tFROM TacPham\r\n\t\t\t\tINNER JOIN Volume ON TacPham.MaTacPham = Volume.MaTacPham" +
                        "\r\n\t\t\t\tINNER JOIN Chapter ON Volume.MaVolume = Chapter.MaVolume\r\n\t\t\t\tWHERE Chapter.ThoiGianDang = (    SELECT MAX(c1.ThoiGianDang)" +
                        "\r\n\t\t\t\t\t\tFROM Chapter c1 WHERE c1.MaVolume = Chapter.MaVolume)\r\n\t\t\t\tGROUP BY TacPham.MaTacPham, TacPham.TenTacPham, Volume.TenVolume, Chapter.TenChapter, Chapter.ThoiGianDang, TacPham.TinhTrang, TacPham.LoaiTruyen" +
                        "\r\n\t\t\t\t) as sub ";
                    if (maTheLoai != string.Empty)
                    {
                        commandText += " inner join ChiTietTheLoai on ChiTietTheLoai.MaTacPham = sub.MaTacPham ";
                    }
                    commandText += "\r\nwhere (1 = 1) ";
                    break;
                case 6: // Top toàn thời gian
                    commandText = "select sub.MaTacPham\r\nfrom (" +
                        "\r\nSELECT ROW_NUMBER() over(order by Chapter.ThoiGianDang desc) as rownuber, TacPham.TenTacPham, TacPham.MaTacPham, Volume.TenVolume, Chapter.TenChapter, Chapter.ThoiGianDang, TacPham.TinhTrang, TacPham.LoaiTruyen" +
                        "\r\n\t\t\t\t\r\n\t\t\t\tFROM TacPham\r\n\t\t\t\tINNER JOIN Volume ON TacPham.MaTacPham = Volume.MaTacPham" +
                        "\r\n\t\t\t\tINNER JOIN Chapter ON Volume.MaVolume = Chapter.MaVolume\r\n\t\t\t\tWHERE Chapter.ThoiGianDang = (    SELECT MAX(c1.ThoiGianDang)" +
                        "\r\n\t\t\t\t\t\tFROM Chapter c1 WHERE c1.MaVolume = Chapter.MaVolume)\r\n\t\t\t\tGROUP BY TacPham.MaTacPham, TacPham.TenTacPham, Volume.TenVolume, Chapter.TenChapter, Chapter.ThoiGianDang, TacPham.TinhTrang, TacPham.LoaiTruyen" +
                        "\r\n\t\t\t\t) as sub ";
                    if (maTheLoai != string.Empty)
                    {
                        commandText += " inner join ChiTietTheLoai on ChiTietTheLoai.MaTacPham = sub.MaTacPham ";
                    }
                    commandText += "\r\nwhere (1 = 1) ";
                    break;
                default:
                    break;
            }

            if (checkboxTruyenDich.Checked || checkboxTruyenSangTac.Checked || checkboxConvert.Checked)
            {
                commandText += " and ( (1 = 2) ";

                if (checkboxTruyenDich.Checked)
                {
                    commandText += "or sub.LoaiTruyen = N'Truyện dịch' or ";

                }

                if (checkboxConvert.Checked)
                {
                    commandText += " sub.LoaiTruyen = N'Truyện sáng tác' or ";


                }
                if (checkboxTruyenDich.Checked)
                    commandText += " sub.LoaiTruyen = N'Truyện Convert' or ";

                commandText += " (1 = 2) )";

            }

            if (checkboxDaHoanThanh.Checked || checkboxDaHoanThanh.Checked || checkboxTamNgung.Checked)
            {
                commandText += " and ( (1 = 2) ";
                if (checkboxDaHoanThanh.Checked)
                {
                    commandText += " or sub.TinhTrang = N'Đã hoàn thành' ";

                }

                if (checkboxDangTienHanh.Checked)
                {
                    commandText += " or sub.TinhTrang = N'Đang tiến hành' ";
                }

                if (checkboxTamNgung.Checked)
                {
                    commandText += " or sub.TinhTrang = N'Tạm ngưng' ";
                }
                commandText += " or (1 = 2) )";
            }

            if (flpChuCai.Tag != null)
            {
                commandText += " and  ";

                if (flpChuCai.Tag.ToString() != "Tất cả")
                {
                    if (flpChuCai.Tag.ToString() == "#")
                    {
                        commandText += "left(sub.TenTacPham, 1) not in ('A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z')";
                    }
                    else
                        commandText += " sub.TenTacPham like N'" + flpChuCai.Tag + "%'";
                }
                else commandText += " (1 = 1) ";
            }

            if (maTheLoai != string.Empty)
            {
                commandText += " and ChiTietTheLoai.MaTheLoai = N'" + maTheLoai + "'";
            }

            commandTextForCount = commandText;

            commandText += " and  (rownuber between " + ((pageCurrent - 1) * pageSize) + " and " + (pageCurrent * pageSize) + ")  ";/*group by sub.MaTacPham*/

            return commandText;
        }

        public void getMaxPage()
        {
            DataTable data = supportMethod.DataReader(commandTextForCount);
            int itemsCount = 0;
            foreach (DataRow row in data.Rows)
            {
                itemsCount++;
            }
            pageEnd = (itemsCount / pageSize) + 1;
            btnTrenSoTrang.Text = "/" + pageEnd.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(getCommandText());
            txtSoTrang.Text = getCommandText();
        }

        void btnApDung(object sender, EventArgs e)
        {
            loadGhiChu();
            //pageCurrent = 1;
            DataTable data = supportMethod.DataReader(getCommandText());
            /*foreach (Control control in flpKetQuaSapXep.Controls)
			{
				//control.Visible = false;
				
				//control.Dispose();
			}*/
            flpKetQuaSapXep.Controls.Clear();
            Stack<string> stack = new Stack<string>();

            foreach (DataRow row in data.Rows)
            {
                //MessageBox.Show(row["MaTacPham"].ToString());
                stack.Push(row["MaTacPham"].ToString());

            }
            foreach (string item in stack)
            {
                //MessageBox.Show(item);
                supportMethod.AddChildFormDockNone(new FormTruyenItem(item), flpKetQuaSapXep);
            }
            getMaxPage();
        }

        public void loadTheLoai()
        {
            DataTable data = supportMethod.DataReader("select *\r\nfrom TheLoai");
            Stack<string> stack = new Stack<string>();
            Stack<string> strings = new Stack<string>();
            foreach (DataRow row in data.Rows)
            {
                stack.Push(row["TenTheLoai"].ToString());
                strings.Push(row["MaTheLoai"].ToString());
            }
            foreach (string item in stack)
            {
                Guna2Button button = new Guna2Button();
                button.Text = item;
                button.Tag = strings.Pop().ToString();
                button.Dock = DockStyle.Top;
                button.TextAlign = (HorizontalAlignment)ContentAlignment.MiddleLeft;
                button.ForeColor = Color.Black;
                button.FillColor = Color.Transparent;
                panelTheLoai.Controls.Add(button);
                button.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                button.Click += btnTheLoai_click;
            }

        }

        public void btnTheLoai_click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            this.maTheLoai = btn.Tag.ToString();
            pageCurrent = 1;
            setUpMacDinh();
            btnChuCaiApDung.PerformClick();

        }



        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.maTheLoai = string.Empty;
            panelGhiChu.Visible = false;
            btnPhanLoaiApDung.PerformClick();
        }

        private void UpdatePaginationButtons()
        {
            txtSoTrang.Text = pageCurrent.ToString();
            btnDau.Enabled = pageCurrent > 1;
            btnCuoi.Enabled = pageCurrent < pageEnd;
            btnGiam.Enabled = pageCurrent > 1;
            btnTang.Enabled = pageCurrent < pageEnd;
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            pageCurrent = 1;
            UpdatePaginationButtons();
            btnChuCaiApDung.PerformClick();
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            pageCurrent = 1;
            UpdatePaginationButtons();
            btnChuCaiApDung.PerformClick();
        }

        private void btnTrenSoTrang_Click(object sender, EventArgs e)
        {

        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            pageCurrent++;
            UpdatePaginationButtons();
            btnChuCaiApDung.PerformClick();
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            pageCurrent = pageEnd;
            UpdatePaginationButtons();
            btnChuCaiApDung.PerformClick();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int enteredPage;
            if (int.TryParse(txtSoTrang.Text, out enteredPage) && enteredPage >= 1 && enteredPage <= pageEnd)
            {
                pageCurrent = enteredPage;
                UpdatePaginationButtons();
                btnChuCaiApDung.PerformClick();
            }
            else
            {
                // Xử lý đầu vào số trang không hợp lệ
                MessageBox.Show("Số trang không hợp lệ.");
                txtSoTrang.Text = pageCurrent.ToString();
            }
        }

        private void cbLuaChon_SelectedValueChanged(object sender, EventArgs e)
        {
            //btnChuCaiApDung.PerformClick();
        }

        private void cbLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnChuCaiApDung.PerformClick();
        }

        private void txtSoTrang_TextChanged(object sender, EventArgs e)
        {
            /*if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự không phải số từ được nhập vào.
            }*/
        }

        private void txtSoTrang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự không phải số từ được nhập vào.
            }
        }
    }
}
