using System;
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
    public partial class MainMenuForm : Form
    {
        private Button button1;
        private Button button3;
        private Button button2;

        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(98, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 64);
            this.button2.TabIndex = 4;
            this.button2.Text = "Therapist ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(98, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 64);
            this.button1.TabIndex = 5;
            this.button1.Text = "Client";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(98, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(238, 64);
            this.button3.TabIndex = 6;
            this.button3.Text = "Employee";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainMenuForm
            // 
            this.ClientSize = new System.Drawing.Size(438, 440);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "MainMenuForm";
            this.Text = "Main Menu ";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);

        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
