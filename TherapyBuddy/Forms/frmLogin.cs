﻿using System;
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
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
            
        }

        frmTherapistPortal tp = new frmTherapistPortal();

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
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            tp.Left += 10;
            if (tp.Left > 1750)
            {
                timer1.Stop();
               // this.TopMost = false;
                tp.TopMost = true;
                timer2.Start();
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            tp.Left -= 10;
            if (tp.Left <= 1367)
            {
                timer2.Stop();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            tp.Show();
        }
    }
}
