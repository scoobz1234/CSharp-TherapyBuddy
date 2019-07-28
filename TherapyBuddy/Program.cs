using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using TherapyBuddy.Classes;

namespace TherapyBuddy
{
    static class Program
    {
        /// <summary>
        /// Therapy Buddy is a program created by UAT students to aid Therapists in the process
        /// of ensuring propor documentation is performed.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Connection c = new Connection();

            c.ConnectToDB();
            
        }
    }
}
