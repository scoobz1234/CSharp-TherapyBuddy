using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TherapyBuddy.Classes
{
    public static class User
    {

        private static string username;
        private static string password;
        private static int accessType;
        private static int windowLeft;


        public static string Username
        {
            get{ return username; }
            set{ username = value; }
        }

        public static string Password 
        {
            get { return password; }
            set { password = value; }
        }

        public static int AccessType 
        {
            get { return accessType; }
            set { accessType = value; }
        }

        public static int WindowLeft
        {
            get { return windowLeft; }
            set { windowLeft = value; }
        }
    }
}
