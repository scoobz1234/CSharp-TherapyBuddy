namespace TherapyBuddy.Forms
{
    partial class FrmCustomerLookUp
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
            this.entCustomerLast = new System.Windows.Forms.TextBox();
            this.entCustomerFirst = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.entSoapNote = new System.Windows.Forms.TextBox();
            this.cbSelectClient = new System.Windows.Forms.ComboBox();
            this.entAppDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // entCustomerLast
            // 
            this.entCustomerLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.entCustomerLast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entCustomerLast.Font = new System.Drawing.Font("Arial", 18F);
            this.entCustomerLast.ForeColor = System.Drawing.Color.White;
            this.entCustomerLast.Location = new System.Drawing.Point(176, 32);
            this.entCustomerLast.Name = "entCustomerLast";
            this.entCustomerLast.Size = new System.Drawing.Size(161, 35);
            this.entCustomerLast.TabIndex = 1;
            this.entCustomerLast.Text = "Last Name";
            // 
            // entCustomerFirst
            // 
            this.entCustomerFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.entCustomerFirst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entCustomerFirst.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entCustomerFirst.ForeColor = System.Drawing.Color.White;
            this.entCustomerFirst.Location = new System.Drawing.Point(176, 73);
            this.entCustomerFirst.Name = "entCustomerFirst";
            this.entCustomerFirst.Size = new System.Drawing.Size(161, 35);
            this.entCustomerFirst.TabIndex = 2;
            this.entCustomerFirst.Text = "First Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TherapyBuddy.Properties.Resources.blankprofile;
            this.pictureBox1.Location = new System.Drawing.Point(360, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 155);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.Location = new System.Drawing.Point(12, 12);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(107, 34);
            this.btnGoBack.TabIndex = 4;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.BtnGoBack_Click);
            // 
            // entSoapNote
            // 
            this.entSoapNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.entSoapNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entSoapNote.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entSoapNote.ForeColor = System.Drawing.Color.White;
            this.entSoapNote.Location = new System.Drawing.Point(23, 271);
            this.entSoapNote.Multiline = true;
            this.entSoapNote.Name = "entSoapNote";
            this.entSoapNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.entSoapNote.Size = new System.Drawing.Size(492, 157);
            this.entSoapNote.TabIndex = 5;
            this.entSoapNote.Text = "SoapNotes";
            // 
            // cbSelectClient
            // 
            this.cbSelectClient.FormattingEnabled = true;
            this.cbSelectClient.Location = new System.Drawing.Point(23, 225);
            this.cbSelectClient.Name = "cbSelectClient";
            this.cbSelectClient.Size = new System.Drawing.Size(492, 24);
            this.cbSelectClient.TabIndex = 6;
            this.cbSelectClient.SelectedIndexChanged += new System.EventHandler(this.CbSelectClient_SelectedIndexChanged);
            this.cbSelectClient.Click += new System.EventHandler(this.CbSelectClient_Click);
            // 
            // entAppDate
            // 
            this.entAppDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.entAppDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entAppDate.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entAppDate.ForeColor = System.Drawing.Color.White;
            this.entAppDate.Location = new System.Drawing.Point(29, 184);
            this.entAppDate.Name = "entAppDate";
            this.entAppDate.Size = new System.Drawing.Size(308, 35);
            this.entAppDate.TabIndex = 7;
            this.entAppDate.Text = "Date of Appointment";
            // 
            // FrmCustomerLookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(542, 440);
            this.Controls.Add(this.entAppDate);
            this.Controls.Add(this.cbSelectClient);
            this.Controls.Add(this.entSoapNote);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.entCustomerFirst);
            this.Controls.Add(this.entCustomerLast);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCustomerLookUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCustomerLookUp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox entCustomerLast;
        private System.Windows.Forms.TextBox entCustomerFirst;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.TextBox entSoapNote;
        private System.Windows.Forms.ComboBox cbSelectClient;
        private System.Windows.Forms.TextBox entAppDate;
    }
}