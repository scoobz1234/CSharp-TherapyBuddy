﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TherapyBuddy
{
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }

        private void lblGreeting_Click(object sender, EventArgs e)
        {

        }

        private void FrmWelcome_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            var loginForm = new FrmLogin();
            loginForm.Show();
            Hide();
            //needs to be fixed
            /*has to be bolded and larger txt. ALso has to be the 1st screen*/
        }
    }
}
