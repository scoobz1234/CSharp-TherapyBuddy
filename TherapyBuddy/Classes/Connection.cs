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

        public MySqlConnection ConnectToDB()
        {
            MySqlConnection dbConnection = new MySqlConnection(connectionString);
            return dbConnection;
        }

        public MySqlCommand QueryCommand(MySqlConnection conn)
        {
            MySqlCommand cmdDataBase = new MySqlCommand("SELECT * from employee_data;", conn);
            return cmdDataBase;
        }
    }
}
