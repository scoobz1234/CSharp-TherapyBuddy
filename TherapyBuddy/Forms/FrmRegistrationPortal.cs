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
    public partial class FrmRegistrationPortal : Form
    {
        public FrmRegistrationPortal()
        {
            InitializeComponent();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(entFirstName.Text))
            {
                if (!string.IsNullOrWhiteSpace(entLastName.Text))
                {
                    if (!string.IsNullOrWhiteSpace(entUsername.Text))
                    {
                        if (!string.IsNullOrWhiteSpace(entPassword.Text))
                        {
                            if (entPassword.Text == entPasswordConfirm.Text)
                            {
                                string first = entFirstName.Text;
                                string last = entLastName.Text;
                                string user = entUsername.Text;
                                string pass = entPasswordConfirm.Text;

                                Connection db = new Connection();
                                MySqlCommand command = new MySqlCommand(
                                    "INSERT IGNORE INTO clients (FirstName, LastName, Username, Password) " +
                                    "VALUES (@firstName, @lastName, @username, @password);", db.GetConnection());

                                command.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = first;
                                command.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = last;
                                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = user;
                                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = pass;

                                MySqlDataReader rdr;
                                db.OpenConnection();
                                rdr = command.ExecuteReader();
                                while (rdr.Read())
                                {
                                    //just stays open...
                                }
                                db.CloseConnection();
                                entFirstName.Clear();
                                entLastName.Clear();
                                entUsername.Clear();
                                entPassword.Clear();
                                entPasswordConfirm.Clear();
                                MessageBox.Show("User added Successfully!");
                            }
                            else
                            {
                                MessageBox.Show("Passwords do not match!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password can not be left empty!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username can not be left empty!");
                    }
                }
                else
                {
                    MessageBox.Show("Last name can not be left empty!");
                }
            }
            else
            {
                MessageBox.Show("First name can not be left empty!");
            }
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            TopMost = false;
        }

        private void ClickToClear(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.Clear();
        }
    }
}
