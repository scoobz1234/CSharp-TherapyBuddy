namespace TherapyBuddy.Forms
{
    partial class FrmClientPortal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMgtMyApt = new System.Windows.Forms.Button();
            this.btnBookNewApt = new System.Windows.Forms.Button();
            this.btnCliMyAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMgtMyApt
            // 
            this.btnMgtMyApt.Location = new System.Drawing.Point(264, 278);
            this.btnMgtMyApt.Name = "btnMgtMyApt";
            this.btnMgtMyApt.Size = new System.Drawing.Size(273, 60);
            this.btnMgtMyApt.TabIndex = 5;
            this.btnMgtMyApt.Text = "Manage My Appointments";
            this.btnMgtMyApt.UseVisualStyleBackColor = true;
            // 
            // btnBookNewApt
            // 
            this.btnBookNewApt.Location = new System.Drawing.Point(264, 195);
            this.btnBookNewApt.Name = "btnBookNewApt";
            this.btnBookNewApt.Size = new System.Drawing.Size(273, 60);
            this.btnBookNewApt.TabIndex = 4;
            this.btnBookNewApt.Text = "Book  New Appointment";
            this.btnBookNewApt.UseVisualStyleBackColor = true;
            // 
            // btnCliMyAccount
            // 
            this.btnCliMyAccount.Location = new System.Drawing.Point(264, 112);
            this.btnCliMyAccount.Name = "btnCliMyAccount";
            this.btnCliMyAccount.Size = new System.Drawing.Size(273, 60);
            this.btnCliMyAccount.TabIndex = 3;
            this.btnCliMyAccount.Text = "My Account";
            this.btnCliMyAccount.UseVisualStyleBackColor = true;
            // 
            // FrmClientPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMgtMyApt);
            this.Controls.Add(this.btnBookNewApt);
            this.Controls.Add(this.btnCliMyAccount);
            this.Name = "FrmClientPortal";
            this.Text = "Client Portal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMgtMyApt;
        private System.Windows.Forms.Button btnBookNewApt;
        private System.Windows.Forms.Button btnCliMyAccount;
    }
}