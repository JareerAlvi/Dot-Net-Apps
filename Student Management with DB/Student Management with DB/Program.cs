﻿using System;
using System.Windows.Forms;

namespace Student_Management_with_DB
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
            Application.Run(new SMS_Authentication());
            Environment.Exit(0);
        }
    }
}
