using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using TherapyBuddy.Classes;

namespace TherapyBuddy.Forms
{
    public partial class FrmDataBaseQuery : Form
    {
        public FrmDataBaseQuery()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //creates a new connection object that will store our connection...
            Connection conn = new Connection();
            //connect to the database and store it in the conn object..
            MySqlConnection connection = conn.ConnectToDB();

            try
            {
                //creates a data adapter
                MySqlDataAdapter sda = new MySqlDataAdapter();
                //call the query command which returns a mysql command which is a typical SQL Query
                sda.SelectCommand = conn.QueryCommand(connection);
                //Create a data table object...
                DataTable dbDataset = new DataTable();
                //take the query command and publish its information into the data adapter
                sda.Fill(dbDataset);
                //create a binding source that we will use to put data into the data grid view
                BindingSource bSource = new BindingSource();

                //set the binding sources data source to the Data table we created above...
                bSource.DataSource = dbDataset;
                //set the Data Grid View's data source to the binding source we created above...
                dgvDatabase.DataSource = bSource;
                //update the data adapter with our DataTable's information/data...
                sda.Update(dbDataset);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
