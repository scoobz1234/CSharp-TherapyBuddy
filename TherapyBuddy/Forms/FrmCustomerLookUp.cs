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

        public FrmCustomerLookUp(string id)
        {
            InitializeComponent();
            CustomInit(id);
        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CustomInit(string id)
        {
            Connection db = new Connection();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand(
                "SELECT " +
                "c.LastName, " +
                "c.FirstName, " +
                "a.SOAP " +
                "FROM " +
                "appointment a "+
                "INNER JOIN " +
                "clients c " +
                "ON " +
                "a.ClientID = c.ClientID " +
                "WHERE " +
                "a.ClientID = @clientID " +
                "AND " +
                "a.TherapistID = @therapistID;", db.GetConnection());

            command.Parameters.Add("@clientID", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@therapistID", MySqlDbType.VarChar).Value = User.ID;

            adapter.SelectCommand = command;

            adapter.Fill(table);

                //List<Client> Clients = new List<Client>();

                foreach (DataRow dr in table.Rows)
                {
                    string last = dr["LastName"].ToString();
                    string first = dr["FirstName"].ToString();
                    string SOAP = dr["SOAP"].ToString();
                    Client c = new Client();
                    c.LastName = last;
                    c.FirstName = first;
                    c.SoapNote = SOAP;
                    Clients.Add(c);
                }
            adapter.Update(table);
        }

        private void Init()
        {
            Connection db = new Connection();

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand(
                    "SELECT " +
                    "c.LastName," +
                    "c.FirstName," +
                    "a.SOAP, " +
                    "a.AppointmentDate " +
                    "FROM " +
                    "clients c " +
                    "INNER JOIN " +
                    "appointment a " +
                    "ON " +
                    "c.ClientID = a.ClientID", db.GetConnection());

                DataTable table = new DataTable();
                BindingSource bSource = new BindingSource();
                adapter.SelectCommand = command;
                adapter.Fill(table);

                foreach (DataRow dr in table.Rows)
                {
                    string last = dr["LastName"].ToString();
                    string first = dr["FirstName"].ToString();
                    string SOAP = dr["SOAP"].ToString();
                    string date = dr["AppointmentDate"].ToString();
                    Client c = new Client();
                    c.LastName = last;
                    c.FirstName = first;
                    c.SoapNote = SOAP;
                    c.AppointmentDate = date;
                    Clients.Add(c);
                }

                bSource.DataSource = table;
                adapter.Update(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CbSelectClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbSelectClient.SelectedIndex;
            Client selectedClient = Clients[index];

            entCustomerFirst.Text = Clients[index].FirstName;
            entCustomerLast.Text = Clients[index].LastName;
            if (string.IsNullOrEmpty(Clients[index].SoapNote))
            {
                MessageBox.Show("No SOAP note entered for this Appointment","Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            entSoapNote.Text = Clients[index].SoapNote;
            entAppDate.Text = Truncate(Clients[index].AppointmentDate, 10);
        }

        private string Truncate(string value, int maxLength)
        {
            if (!string.IsNullOrEmpty(value) && value.Length > maxLength)
            {
                return value.Substring(0, maxLength);
            }

            return value;
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
