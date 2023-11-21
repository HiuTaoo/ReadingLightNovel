using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingLightNovelApplication
{
     class SupportMethod
    {
		string strConnect = "Data Source=DESKTOP-51MISFU\\HIUTAO;" +
			"Initial Catalog=ReadingLightNovel;Integrated Security=True";
        SqlConnection sqlConnect = null;
        //Phương thức mở kết nối
        void OpenConnect()
        {
            sqlConnect = new SqlConnection(strConnect);
            if (sqlConnect.State != ConnectionState.Open)
                sqlConnect.Open();
        }
        //Phương thức đóng kết nối
        void CloseConnect()
        {
            if (sqlConnect.State != ConnectionState.Closed)
            {
                sqlConnect.Close();
                sqlConnect.Dispose();
            }
        }
        //Phương thức thực thi câu lệnh Select trả về một DataTable
        public DataTable DataReader(string sqlSelct)
        {
            DataTable tblData = new DataTable();
            OpenConnect();
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlSelct, sqlConnect);
            sqlData.Fill(tblData);
            CloseConnect();
            return tblData;
        }


        //Phương thức thực hiện câu lệnh dạng insert,update,delete
        public void DataChange(string sql)
        {
            OpenConnect();
            SqlCommand sqlcomma = new SqlCommand();
            sqlcomma.Connection = sqlConnect;
            sqlcomma.CommandText = sql;
            sqlcomma.ExecuteNonQuery();
            CloseConnect();
        }

        public List<object> GetValueOfOneField(string selectCommandText)
		{
			List<object> list = new List<object>();
			DataTable dataTable = DataReader(selectCommandText);
			foreach(DataRow row in dataTable.Rows)
			{

				list.Add(row[0]);
			}
			return list;
		}

		

		//func Load form into panel
		public void openChildFormDockTop(Form activeForm, Form formName, Panel panelName)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = formName;
            formName.TopLevel = false;
            formName.FormBorderStyle = FormBorderStyle.None;
            formName.Dock = DockStyle.Top;
            panelName.Controls.Add(formName);
            panelName.Tag = formName;
            formName.BringToFront();
            formName.Show();
        }

        public void AddChildFormDockTop( Form formName, Panel panelName)
        {
            
            formName.TopLevel = false;
            formName.FormBorderStyle = FormBorderStyle.None;
            formName.Dock = DockStyle.Top;
            panelName.Controls.Add(formName);
            panelName.Tag = formName;
            formName.BringToFront();
            formName.Show();
        }


        public void AddChildFormDockFill(Form formName, Panel panelName)
        {

            formName.TopLevel = false;
            formName.FormBorderStyle = FormBorderStyle.None;
            formName.Dock = DockStyle.Fill;
            panelName.Controls.Add(formName);
            panelName.Tag = formName;
            formName.BringToFront();
            formName.Show();
        }

        public void AddChildFormDockNone(Form formName, Panel panelName)
        {

            formName.TopLevel = false;
            formName.FormBorderStyle = FormBorderStyle.None;
            formName.Dock = DockStyle.None;
            panelName.Controls.Add(formName);
            panelName.Tag = formName;
            formName.BringToFront();
            formName.Show();
        }

        public void AddChildFormDockLeft(Form formName, Panel panelName)
        {

            formName.TopLevel = false;
            formName.FormBorderStyle = FormBorderStyle.None;
            formName.Dock = DockStyle.Left;
            panelName.Controls.Add(formName);
            panelName.Tag = formName;
            formName.BringToFront();
            formName.Show();
        }

        public void openChildFormDockFill(Form activeForm, Form formName, Panel panelName)
		{
			if (activeForm != null)
				activeForm.Close();
			activeForm = formName;
			formName.TopLevel = false;
			formName.FormBorderStyle = FormBorderStyle.None;
			formName.Dock = DockStyle.Fill;
			panelName.Controls.Add(formName);
			panelName.Tag = formName;
			formName.BringToFront();
			formName.Show();
		}


		//func get form main
		public Form getFormMain(Form container)
		{
			Form containerControl = container;
			while (containerControl.ParentForm != null)
			{
				return getFormMain(containerControl.ParentForm);
			}
			return containerControl;
		}

        //Trả về form cha theo tên (trừ form main)
        public Form getFormParent(Form container, string nameForm) 
        {
			Form containerControl = container;
			while (/*containerControl.ParentForm != null || */containerControl.Name != nameForm)
			{
				return getFormParent(containerControl.ParentForm, nameForm);
			}
            if(containerControl.ParentForm == null)
            {
                return null;
            }
			else return containerControl;
		}


        public Panel getPanel(Form formName ,string namepanel)
		{
			foreach (Panel c in formName.Controls.OfType<Panel>())
			{
				if (c.Name == namepanel)
					return c;
			}
			return null;
		}

        public void openChildFormFromForm(string nameFormRoot, string namePanelContainer, Form formContent, Form formLeaf)
        {
            Form formRoot = getFormParent(formLeaf as Form, nameFormRoot); // ???Làm sao để có thể ép dúng kiểu.
            Panel panelContainer = getPanel(formRoot, namePanelContainer);
            foreach(Control control in panelContainer.Controls)
            {
                control.Dispose();
            }
            AddChildFormDockFill(formContent, panelContainer);
        }

        /*public void loadNewChildForm(dynamic formContainer, dynamic formName, Panel panelName)
		{
			Form form = formContainer.activeForm;
			panelName.Controls.Clear();
			SupportMethod.openChildFormDockTop(form, formName, panelName);
		}*/

        

        public int CountWordsFromFile(string filePath)
        {
            try
            {
                int wordCount = 0;

                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        // Sử dụng Regex.Split để tách từ theo các ký tự không phải là chữ cái
                        string[] words = Regex.Split(line, @"\W+");

                        // Đếm số từ trong mỗi dòng
                        wordCount += words.Length;
                    }
                }

                return wordCount;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return -1;
            }
        }

        public string loadContent(string filePath)
        {
            try
            {
                // Tạo một ứng dụng Word và một tài liệu Word
                var wordApp = new Microsoft.Office.Interop.Word.Application();
                var doc = wordApp.Documents.Open(filePath);

                // Lấy nội dung của tài liệu và đóng ứng dụng Word
                string content = doc.Content.Text;
                wordApp.Quit();

                return content;
            }
            catch (Exception ex)
            {
                return 0.ToString();
            }
        }





    }
}
