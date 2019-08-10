namespace TherapyBuddy.Forms {
    partial class FrmLogin {
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
        // this is a comment...

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.pbUsername = new System.Windows.Forms.PictureBox();
            this.entUsername = new System.Windows.Forms.TextBox();
            this.entPassword = new System.Windows.Forms.TextBox();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.lblClose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // pbIcon
            // 
            this.pbIcon.BackgroundImage = global::TherapyBuddy.Properties.Resources.icon;
            this.pbIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbIcon.InitialImage")));
            this.pbIcon.Location = new System.Drawing.Point(135, 47);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(64, 64);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            this.pbIcon.WaitOnLoad = true;
            // 
            // pbUsername
            // 
            this.pbUsername.BackgroundImage = global::TherapyBuddy.Properties.Resources.user__4_;
            this.pbUsername.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbUsername.InitialImage")));
            this.pbUsername.Location = new System.Drawing.Point(45, 151);
            this.pbUsername.Name = "pbUsername";
            this.pbUsername.Size = new System.Drawing.Size(24, 24);
            this.pbUsername.TabIndex = 1;
            this.pbUsername.TabStop = false;
            this.pbUsername.WaitOnLoad = true;
            // 
            // entUsername
            // 
            this.entUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.entUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entUsername.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entUsername.ForeColor = System.Drawing.Color.White;
            this.entUsername.Location = new System.Drawing.Point(88, 155);
            this.entUsername.Name = "entUsername";
            this.entUsername.Size = new System.Drawing.Size(185, 20);
            this.entUsername.TabIndex = 3;
            this.entUsername.Text = "Username";
            this.entUsername.Click += new System.EventHandler(this.EntUsername_Click);
            // 
            // entPassword
            // 
            this.entPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.entPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entPassword.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entPassword.ForeColor = System.Drawing.Color.White;
            this.entPassword.Location = new System.Drawing.Point(88, 216);
            this.entPassword.Name = "entPassword";
            this.entPassword.Size = new System.Drawing.Size(185, 20);
            this.entPassword.TabIndex = 5;
            this.entPassword.Text = "Password";
            this.entPassword.Click += new System.EventHandler(this.EntPassword_Click);
            // 
            // pbPassword
            // 
            this.pbPassword.BackgroundImage = global::TherapyBuddy.Properties.Resources.user__4_;
            this.pbPassword.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbPassword.InitialImage")));
            this.pbPassword.Location = new System.Drawing.Point(45, 212);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(24, 24);
            this.pbPassword.TabIndex = 4;
            this.pbPassword.TabStop = false;
            this.pbPassword.WaitOnLoad = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(45, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sign In";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackColor = System.Drawing.Color.White;
            this.pnlUsername.Location = new System.Drawing.Point(45, 181);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(250, 1);
            this.pnlUsername.TabIndex = 7;
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.White;
            this.pnlPassword.Location = new System.Drawing.Point(45, 242);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(250, 1);
            this.pnlPassword.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(45, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 48);
            this.button2.TabIndex = 10;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(315, 3);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(17, 17);
            this.lblClose.TabIndex = 11;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.LblClose_Click);
            // 
            // FrmLogin
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(337, 440);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.pnlUsername);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.entPassword);
            this.Controls.Add(this.pbPassword);
            this.Controls.Add(this.entUsername);
            this.Controls.Add(this.pbUsername);
            this.Controls.Add(this.pbIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.PictureBox pbUsername;
        private System.Windows.Forms.TextBox entUsername;
        private System.Windows.Forms.TextBox entPassword;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblClose;
    }
}

