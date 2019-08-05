using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using TherapyBuddy.Classes;
using TherapyBuddy.Forms;

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
            Connection c = new Connection();
            c.ConnectToDB();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());


        }
    }
}
