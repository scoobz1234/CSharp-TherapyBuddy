using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TherapyBuddy.Forms;

namespace TherapyBuddy
{
    public partial class frmTherapistPortal : Form
    {
        public frmTherapistPortal()
        {
            InitializeComponent();
        }


        private void LblClose_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Left += 10;
            if (this.Left > 1750)
            {
                timer1.Stop();
                this.TopMost = false;
                timer2.Start();
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            this.Left -= 10;
            if (this.Left <= 1367)
            {
                timer2.Stop();
            }
        }

        private void BtnCustomerLookup_Click(object sender, EventArgs e)
        {
            FrmCustomerLookUp clu = new FrmCustomerLookUp();
            clu.TopMost = true;
            clu.Show();
            Hide();
        }
    }
}
