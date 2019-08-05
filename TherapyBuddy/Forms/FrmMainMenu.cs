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
    public partial class FrmMainMenu : Form
    {
        private Button btnClient;
        private Button btnEmployee;
        private Button btnLogout;
        private Button btnTherapist;

        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnTherapist = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTherapist
            // 
            this.btnTherapist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTherapist.Location = new System.Drawing.Point(98, 63);
            this.btnTherapist.Name = "btnTherapist";
            this.btnTherapist.Size = new System.Drawing.Size(238, 64);
            this.btnTherapist.TabIndex = 4;
            this.btnTherapist.Text = "Therapist";
            this.btnTherapist.UseVisualStyleBackColor = true;
            this.btnTherapist.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClient
            // 
            this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClient.Location = new System.Drawing.Point(98, 255);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(238, 64);
            this.btnClient.TabIndex = 5;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = true;
            // 
            // btnEmployee
            // 
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEmployee.Location = new System.Drawing.Point(98, 159);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(238, 64);
            this.btnEmployee.TabIndex = 6;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            this.btnLogout.Location = new System.Drawing.Point(340, 379);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(86, 49);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FrmMainMenu
            // 
            this.ClientSize = new System.Drawing.Size(438, 440);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnTherapist);
            this.Name = "FrmMainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);

        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var login = new FrmLogin();
            login.Show();
            Hide();
        }
    }
}
