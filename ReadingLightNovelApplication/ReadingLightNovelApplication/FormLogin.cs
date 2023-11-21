﻿using System;
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
    public partial class FormLogin : Form
    {
        SupportMethod SupportMethod = new SupportMethod();
        string tendn;
        public FormLogin(string tendangnhap)
        {
            InitializeComponent();
            tendn = tendangnhap;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            DataTable dt = SupportMethod.DataReader("select * " +
                "\r\nfrom [User]\r\nwhere [TenDangNhap] = '" + tendn +"'");
            try
            {
                Image image = Image.FromFile(Application.StartupPath + "\\Asset\\User\\"
                    + dt.Rows[0]["AnhDaiDien"].ToString());
                btnAvt.Image = image;
            }
            catch {
                Image image = Image.FromFile(Application.StartupPath + "\\Asset\\User\\noLoadUser.png");
                btnAvt.Image = image;
            }
            
                
            
            
        }

        private void btnYeuThich_Click(object sender, EventArgs e)
        {

            LayoutLogged  lg = SupportMethod.getFormParent(this, "LayoutLogged") as LayoutLogged;
            Panel panel1 =  SupportMethod.getPanel(lg, "panelNoiDung");
            foreach(Control c in panel1.Controls)
            {
                c.Dispose();    
            }
            SupportMethod.openChildFormDockFill(lg.getActiveForm(), new FormFollow(), panel1);
        }

        private void btnAvt_Click(object sender, EventArgs e)
        {
            FormMain formMain = SupportMethod.getFormMain(this) as FormMain;
            Panel panel1 = SupportMethod.getPanel(formMain, "panelMain");
            foreach (Control c in panel1.Controls)
            {
                c.Dispose();
            }
            foreach (Form f in panel1.Controls)
            {
                f.Close();
                f.Dispose();
            }

            LayoutLogged lg = new LayoutLogged();
            SupportMethod.openChildFormDockFill(formMain.getactive(), lg, panel1);
            Panel panel2 = SupportMethod.getPanel(lg, "panelNoiDung");

            SupportMethod.AddChildFormDockFill(new FormProfile(tendn), panel2);
            panelLogout.Visible = false;
        }

        
    }
}
