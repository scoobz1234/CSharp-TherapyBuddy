using MySql.Data.MySqlClient;
using System;

namespace TherapyBuddy.Classes
{
    public class Connection
    {
        //Connection Information //
        string serverAddress = "therapybuddydb.ck2qosmc2bpy.us-west-1.rds.amazonaws.com";
        string username = "TherapyMaster";
        string password = "TherapyMaster";
        string database = "TherapyBuddyDB";
        string connectionString = "";
        private MySqlConnection c;

        public Connection()
        {
            connectionString = "server=" + serverAddress +
                                ";user=" + username +
                                ";database=" + database +
                                ";port=3306;password=" + password;
            connectionString += ";SslMode=none";
            c = new MySqlConnection(connectionString);
        }


        public MySqlConnection GetConnection()
        {
           return c;
        }

        //open the connectio to the database

        public void OpenConnection()
        {
            if (c.State == System.Data.ConnectionState.Closed)
            {
                c.Open();
            }
        }

        //close the connection to the database...
        public void CloseConnection()
        {
            if (c.State == System.Data.ConnectionState.Open)
            {
                c.Close();
            }
        }
    }
}
