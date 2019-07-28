using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace TherapyBuddy.Classes
{
    public class Connection
    {
        //Connection Information //
        string serverAddress = "therapybuddydb.ck2qosmc2bpy.us-west-1.rds.amazonaws.com";
        string username = "TherapyMaster";
        string password = "TherapyMaster";
        string database = "Employees";
        string connectionString = "";

        public Connection()
        {
            connectionString =  "server=" + serverAddress + 
                                ";user=" + username + 
                                ";database=" + database + 
                                ";port=3306;password=" + password;
            connectionString += ";SslMode=none";
        }

        public void ConnectToDB()
        {
            MySqlConnection dbConnection = new MySqlConnection(connectionString);
            try
            {
                Console.WriteLine("Connection to MySql...");
                // open the connection...
                dbConnection.Open();

                // Query the Database
                string query = "SELECT * From therapist_data";
                MySqlCommand cmd = new MySqlCommand(query, dbConnection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write(reader.GetValue(i) + "   ");
                    }
                    Console.WriteLine("");
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            //Close the connection
            dbConnection.Close();

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }
    }
}
