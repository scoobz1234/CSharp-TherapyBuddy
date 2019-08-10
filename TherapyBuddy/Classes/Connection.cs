using MySql.Data.MySqlClient;
using System;

namespace TherapyBuddy.Classes
{
    class Connection
    {
        //Connection Information //
        string serverAddress = "therapybuddydb.ck2qosmc2bpy.us-west-1.rds.amazonaws.com";
        string username = "TherapyMaster";
        string password = "TherapyMaster";
        string database = "Employees";
        string connectionString = "";

        public enum Commands
        {
            SELECT,
            INSERT,
            DELETE,
            REPLACE,
            UPDATE
        }

        public Connection()
        {
            connectionString = "server=" + serverAddress +
                                ";user=" + username +
                                ";database=" + database +
                                ";port=3306;password=" + password;
            connectionString += ";SslMode=none";
            MySqlConnection conn = new MySqlConnection(connectionString);
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

        public MySqlCommand CustomQuery(MySqlConnection c, string command)
        {
            MySqlCommand cmdDataBase = new MySqlCommand($"{command};", c);
            return cmdDataBase;
        }

        //public MySqlConnection con;

        //public Connection()
        //{
        //    string serverAddress = "therapybuddydb.ck2qosmc2bpy.us-west-1.rds.amazonaws.com";
        //    string username = "TherapyMaster";
        //    string password = "TherapyMaster";
        //    string database = "Employees";

        //    string connectionString = "server=" + serverAddress +
        //                            ";user=" + username +
        //                            ";database=" + database +
        //                            ";port=3306;password=" + password;
        //    connectionString += ";SslMode=none";

        //    con = new MySqlConnection(connectionString);
        //}

    }

    //class Data_Insert : Connection
    //{
    //    public void InsertIntoClient(string lastName, string firstName, string email, string password, string phoneNumber)
    //    {
    //        using (MySqlCommand cmd = new MySqlCommand())
    //        {
    //            con.Open();
    //            cmd.CommandText = "INSERT INTO 'Customers'.'customer_data'('last_name','first_name','email','password','phone_number'') VALUES(@lastName,@firstName,@email,@password,@phoneNumber)";
    //            cmd.CommandType = System.Data.CommandType.Text;
    //            cmd.Connection = con;

    //            cmd.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = lastName;
    //            cmd.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = firstName;
    //            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
    //            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
    //            cmd.Parameters.Add("@phoneNumber", MySqlDbType.VarChar).Value = phoneNumber;

    //            try
    //            {
    //                cmd.ExecuteNonQuery();

    //            }
    //            catch (FormatException)
    //            {

    //            }
    //            con.Close();

    //        }
    //    }
    //}
}
