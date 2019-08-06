﻿using System;
using System.Windows.Forms;
using TherapyBuddy.Forms;
using TherapyBuddy.Classes;

namespace TherapyBuddy
{
    static class Program
    {
        /// <summary>
        /// Therapy Buddy is a program created by UAT students to aid Therapists in the process
        /// of ensuring proper documentation is performed.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());

        }
    }
}