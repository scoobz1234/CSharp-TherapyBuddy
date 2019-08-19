using System;
using System.Drawing;
using System.Windows.Forms;
using TherapyBuddy.Classes;
using MySql.Data.MySqlClient;
using System.Data;

namespace TherapyBuddy.Forms
{

    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }

        frmTherapistPortal therapist = new frmTherapistPortal();
        FrmClientPortal client = new FrmClientPortal();
        FrmRegistrarPortal registrar = new FrmRegistrarPortal();
        FrmRegistrationPortal registration = new FrmRegistrationPortal();

        Form pageToBringToFront;

        bool isMasked = true;
        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var mainMenu = new FrmMainMenu();
            mainMenu.Show();
            Hide();
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EntUsername_Click(object sender, EventArgs e)
        {
            //Set the clicked entry box to a different color
            entUsername.Clear();
            pbUsername.BackgroundImage = Properties.Resources.user__3_;
            pnlUsername.ForeColor = Color.FromArgb(78, 184, 206);
            entUsername.ForeColor = Color.FromArgb(78, 184, 206);

            //reset the unclicked entry to default.
            pbPassword.BackgroundImage = Properties.Resources.lock__3_;
            pnlPassword.ForeColor = Color.White;
            entPassword.ForeColor = Color.White;
        }

        private void EntPassword_Click(object sender, EventArgs e)
        {
            //Set the clicked entry box to a different color
            entPassword.Clear();
            entPassword.PasswordChar = '*';
            pbPassword.BackgroundImage = Properties.Resources.lock__2_;
            pnlPassword.ForeColor = Color.FromArgb(78, 184, 206);
            entPassword.ForeColor = Color.FromArgb(78, 184, 206);

            //reset the unclicked entry to default.
            pbUsername.BackgroundImage = Properties.Resources.user__4_;
            pnlUsername.ForeColor = Color.White;
            entUsername.ForeColor = Color.White;
        }

        private void BtnSignin_Click(object sender, EventArgs e)
        {
            Connection db = new Connection();

            string userName = entUsername.Text;
            string password = entPassword.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand(
                "SELECT * FROM therapist t " +
                "WHERE t.UserName = @userName AND t.Password = @password " +
                "UNION SELECT * FROM clients c " +
                "WHERE c.UserName = @userName AND c.Password = @password " +
                "UNION SELECT * FROM registrar r " +
                "WHERE r.UserName = @userName AND r.Password = @password ;",db.GetConnection());

            command.Parameters.Add("@userName", MySqlDbType.VarChar).Value = userName;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                foreach (DataRow dr in table.Rows)
                {
                    string user = dr["UserName"].ToString();
                    string pass = dr["Password"].ToString();
                    string accessType = dr["AccessTypeID"].ToString();                   
                    int access = 0;
                    int.TryParse(accessType, out access);

                    User.Username = user;
                    User.Password = pass;
                    User.AccessType = access;

                    int id = 0;
                    string userID = dr["TherapistID"].ToString();
                    int.TryParse(userID, out id);

                    User.ID = id;
                }
                switch (User.AccessType)
                {
                    case 1:
                        pageToBringToFront = client;
                        timer1.Start();
                        entUsername.Clear();
                        entPassword.Clear();
                        break;
                    case 2:
                        pageToBringToFront = therapist;
                        timer1.Start();
                        entUsername.Clear();
                        entPassword.Clear();
                        break;
                    case 3:
                        pageToBringToFront = registrar;
                        timer1.Start();
                        entUsername.Clear();
                        entPassword.Clear();
                        break;
                    default:
                        MessageBox.Show("Something Went wrong, Try again?");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Username or Password INCORRECT, Try again!");
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            pageToBringToFront.Left += 30;
            if (pageToBringToFront.Left > (User.WindowLeft + 337))
            {
                timer1.Stop();
                pageToBringToFront.TopMost = true;
                timer2.Start();
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            pageToBringToFront.Left -= 30;
            if (pageToBringToFront.Left <= User.WindowLeft)
            {
                timer2.Stop();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            therapist.Show();
            client.Show();
            registrar.Show();
            registration.Show();
            User.WindowLeft = this.Left;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            pageToBringToFront = registration;
            timer1.Start();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (isMasked)
            {
                entPassword.PasswordChar = '\0';
                pbEye.Image = Properties.Resources.eyeHovered;
            }
            else
            {
                entPassword.PasswordChar = '*';
                pbEye.Image = Properties.Resources.eye;
            }
            isMasked = !isMasked;
        }
    }
}
