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
    public partial class FormProperties : Form
    {
        SupportMethod dataload = new SupportMethod();
        DataTable dtAll = new DataTable();

        public FormProperties()
        {
            InitializeComponent();

        }
        public FormProperties(string matruyen)
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

        }

        private void FormProperties_Load(object sender, EventArgs e)
        {

        }

        public void loadData()
        {
            dtAll = dataload.DataReader("");
        }
    }
}
