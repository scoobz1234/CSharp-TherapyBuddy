using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TherapyBuddy.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var mainMenu = new FrmMainMenu();
            mainMenu.Show();
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void LblGreeting_Click(object sender, EventArgs e)
        {

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
    }
}
