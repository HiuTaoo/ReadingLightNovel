﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingLightNovelApplication
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new FormProperties("TP001"));
=======
<<<<<<< HEAD
            Application.Run(new FormMain());
=======
            Application.Run(new Nhap());
>>>>>>> 2ffd87406def4f9067a8f8bca78c71e8671ad6b2
>>>>>>> 87e99b617a6370727cf0ac3bd732ce570c3090e1
        }
    }
}
