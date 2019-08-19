namespace TherapyBuddy.Forms
{
    partial class FrmRegistrationPortal
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.entFirstName = new System.Windows.Forms.TextBox();
            this.entLastName = new System.Windows.Forms.TextBox();
            this.entUsername = new System.Windows.Forms.TextBox();
            this.entPassword = new System.Windows.Forms.TextBox();
            this.entPasswordConfirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(25, 374);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(286, 54);
            this.btnConfirm.TabIndex = 17;
            this.btnConfirm.Text = "Register";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.Button6_Click);
            // 
            // entFirstName
            // 
            this.entFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.entFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entFirstName.Font = new System.Drawing.Font("Arial", 18F);
            this.entFirstName.ForeColor = System.Drawing.Color.White;
            this.entFirstName.Location = new System.Drawing.Point(41, 34);
            this.entFirstName.MaxLength = 255;
            this.entFirstName.Name = "entFirstName";
            this.entFirstName.Size = new System.Drawing.Size(251, 42);
            this.entFirstName.TabIndex = 18;
            this.entFirstName.Text = "First Name";
            // 
            // entLastName
            // 
            this.entLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.entLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entLastName.Font = new System.Drawing.Font("Arial", 18F);
            this.entLastName.ForeColor = System.Drawing.Color.White;
            this.entLastName.Location = new System.Drawing.Point(41, 92);
            this.entLastName.MaxLength = 255;
            this.entLastName.Name = "entLastName";
            this.entLastName.Size = new System.Drawing.Size(251, 42);
            this.entLastName.TabIndex = 19;
            this.entLastName.Text = "Last Name";
            // 
            // entUsername
            // 
            this.entUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.entUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entUsername.Font = new System.Drawing.Font("Arial", 18F);
            this.entUsername.ForeColor = System.Drawing.Color.White;
            this.entUsername.Location = new System.Drawing.Point(41, 155);
            this.entUsername.MaxLength = 255;
            this.entUsername.Name = "entUsername";
            this.entUsername.Size = new System.Drawing.Size(251, 42);
            this.entUsername.TabIndex = 20;
            this.entUsername.Text = "Username";
            // 
            // entPassword
            // 
            this.entPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.entPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entPassword.Font = new System.Drawing.Font("Arial", 18F);
            this.entPassword.ForeColor = System.Drawing.Color.White;
            this.entPassword.Location = new System.Drawing.Point(41, 219);
            this.entPassword.MaxLength = 255;
            this.entPassword.Name = "entPassword";
            this.entPassword.Size = new System.Drawing.Size(251, 42);
            this.entPassword.TabIndex = 21;
            this.entPassword.Text = "Password";
            // 
            // entPasswordConfirm
            // 
            this.entPasswordConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.entPasswordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entPasswordConfirm.Font = new System.Drawing.Font("Arial", 18F);
            this.entPasswordConfirm.ForeColor = System.Drawing.Color.White;
            this.entPasswordConfirm.Location = new System.Drawing.Point(41, 279);
            this.entPasswordConfirm.MaxLength = 255;
            this.entPasswordConfirm.Name = "entPasswordConfirm";
            this.entPasswordConfirm.Size = new System.Drawing.Size(251, 42);
            this.entPasswordConfirm.TabIndex = 22;
            this.entPasswordConfirm.Text = "Confirm Password";
            // 
            // FrmRegistrationPortal
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(337, 440);
            this.Controls.Add(this.entPasswordConfirm);
            this.Controls.Add(this.entPassword);
            this.Controls.Add(this.entUsername);
            this.Controls.Add(this.entLastName);
            this.Controls.Add(this.entFirstName);
            this.Controls.Add(this.btnConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrationPortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistrationPortal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox entFirstName;
        private System.Windows.Forms.TextBox entLastName;
        private System.Windows.Forms.TextBox entUsername;
        private System.Windows.Forms.TextBox entPassword;
        private System.Windows.Forms.TextBox entPasswordConfirm;
    }
}