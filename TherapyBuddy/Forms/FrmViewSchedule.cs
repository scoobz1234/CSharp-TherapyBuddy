using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TherapyBuddy.Classes;
using MySql.Data.MySqlClient;

namespace TherapyBuddy.Forms
{
    public partial class FrmViewSchedule : Form
    {
        public FrmViewSchedule()
        {
            InitializeComponent();
        }

        Timer t = new Timer();
        public List<Appointment> Appointments = new List<Appointment>();

        private void FrmViewSchedule_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();

            Connection db = new Connection();
            DataTable table = new DataTable();
            string id = User.ID.ToString();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand(
                "SELECT a.AppointmentID as 'AppointmentID', " +
                    "CONCAT(c.LastName, ', ', c.FirstName) as 'Client Name', " +
                    "a.StartTime as 'Appointment Start', " +
                    "a.EndTimeExpected as 'Appointment End', " +
                    "s.ServiceType as 'Service Requested', " +
                    "a.ClientID as 'ClientID' " +
                    "FROM appointment a " +
                    "JOIN clients c " +
                    "JOIN therapist t " +
                    "JOIN service s " +
                    "ON a.ClientID = c.ClientID " +
                    "AND a.TherapistID = t.TherapistID " +
                    "AND a.ServiceID = s.ServiceID " +
                    "WHERE a.TherapistID = @therapistID;", db.GetConnection());

            command.Parameters.Add("@therapistID", MySqlDbType.VarChar).Value = id;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            foreach (DataRow dr in table.Rows)
            {
                int  appID = 0;
                int clientID = 0;
                int.TryParse(dr["AppointmentID"].ToString(),out appID);
                int.TryParse(dr["ClientID"].ToString(), out clientID);
                string name = dr["Client Name"].ToString();
                string startTime = dr["Appointment Start"].ToString();
                string endTime = dr["Appointment End"].ToString();
                string service = dr["Service Requested"].ToString();

                Appointment a = new Appointment(appID,name,startTime,endTime,service,clientID);
                Appointments.Add(a);
            }

           foreach (Appointment a in Appointments)
           {
                int n = dgvSchedule.Rows.Add();
                dgvSchedule.Rows[n].Cells[0].Value = n+1;
                dgvSchedule.Rows[n].Cells[1].Value = a.Name;
                dgvSchedule.Rows[n].Cells[2].Value = a.StartTime;
                dgvSchedule.Rows[n].Cells[3].Value = a.EndTime;
                dgvSchedule.Rows[n].Cells[4].Value = a.Service;
                dgvSchedule.Rows[n].Cells[5].Value = a.ClientID;

            }
                       

            adapter.Update(table);
        }

        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            //update label
            lblTime.Text = time;

        }

        private void DgvSchedule_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            int selectedRowIndex = dgvSchedule.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvSchedule.Rows[selectedRowIndex];

            string id = Convert.ToString(selectedRow.Cells[5].Value);

            FrmCustomerLookUp clu = new FrmCustomerLookUp(id);
            clu.Show();
            clu.TopMost = true;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvSchedule.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvSchedule.Rows[selectedRowIndex];

            string id = Convert.ToString(selectedRow.Cells[5].Value);

            FrmCustomerLookUp clu = new FrmCustomerLookUp(id);
            clu.Show();
            clu.TopMost = true;
        }
    }
}
