﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLNC_N08
{
    public static class Account
    {
        public static string username;
        public static string password;
        public static string id;
        public static string connectString;
    }
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new DonHang());
            Application.Run(new Guest());
        }
    }
}
