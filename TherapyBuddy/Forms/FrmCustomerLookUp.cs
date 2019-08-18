using System;
using System.Data;
using System.Windows.Forms;
using TherapyBuddy.Classes;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace TherapyBuddy.Forms
{
    public partial class FrmCustomerLookUp : Form
    {
        public List<Client> Clients = new List<Client>();

        public FrmCustomerLookUp()
        {
            InitializeComponent();

            Init();
        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Init()
        {
            //Connection conn = new Connection();
            //MySqlConnection connection = conn.ConnectToDB();
            

            //try
            //{
            //    MySqlDataAdapter sda = new MySqlDataAdapter();
            //   // lets build our command(query)

            //    string command =
            //        "SELECT " +
            //        "Customers.customer_data.last_name," +
            //        "Customers.customer_data.first_name," +
            //        "Service_Log.service_log.soap_note " +
            //        "FROM " +
            //        "Customers.customer_data " +
            //        "INNER JOIN " +
            //        "Service_Log.service_log " +
            //        "ON " +
            //        "Customers.customer_data.client_id = Service_Log.service_log.client_id";


            //    DataTable dbDataset = new DataTable();
            //    BindingSource bSource = new BindingSource();
            //    sda.SelectCommand = conn.CustomQuery(connection, command);
            //    sda.Fill(dbDataset);

            //    //List<Client> Clients = new List<Client>();

            //    foreach (DataRow dr in dbDataset.Rows)
            //    {
            //        string last = dr["last_name"].ToString();
            //        string first = dr["first_name"].ToString();
            //        string SOAP = dr["soap_note"].ToString();
            //        Client c = new Client();
            //        c.LastName = last;
            //        c.FirstName = first;
            //        c.SoapNote = SOAP;
            //        Clients.Add(c);
            //    }

            //    bSource.DataSource = dbDataset;
            //    sda.Update(dbDataset);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void CbSelectClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbSelectClient.SelectedIndex;
            Client selectedClient = Clients[index];

            entCustomerFirst.Text = Clients[index].FirstName;
            entCustomerLast.Text = Clients[index].LastName;
            entSoapNote.Text = Clients[index].SoapNote;
        }

        private void CbSelectClient_Click(object sender, EventArgs e)
        {
            cbSelectClient.Items.Clear();

            foreach (Client c in Clients)
            {
                cbSelectClient.Items.Add($"{c.LastName}, {c.FirstName}");
            }

            
        }
    }
}
