using System;
using System.Data;
using System.Windows.Forms;
using TherapyBuddy.Classes;
using MySql.Data.MySqlClient;

namespace TherapyBuddy.Forms
{
    public partial class FrmCustomerLookUp : Form
    {
        public FrmCustomerLookUp()
        {
            InitializeComponent();

            Init();
        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {

        }

        private void Init()
        {
            Connection conn = new Connection();
            MySqlConnection connection = conn.ConnectToDB();
            

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
               // lets build our command(query)

                string command =
                    "SELECT " +
                    "Customers.customer_data.last_name," +
                    "Customers.customer_data.first_name," +
                    "Service_Log.service_log.soap_note " +
                    "FROM " +
                    "Customers.customer_data " +
                    "INNER JOIN " +
                    "Service_Log.service_log " +
                    "ON " +
                    "Customers.customer_data.client_id = Service_Log.service_log.client_id";


                DataTable dbDataset = new DataTable();
                BindingSource bSource = new BindingSource();
                sda.SelectCommand = conn.CustomQuery(connection, command);
                sda.Fill(dbDataset);

                bSource.DataSource = dbDataset;
                dgvCustomer.DataSource = bSource;
                sda.Update(dbDataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
