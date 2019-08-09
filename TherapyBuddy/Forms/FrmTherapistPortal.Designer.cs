namespace TherapyBuddy.Forms
{
    partial class FrmTherapistPortal
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
            this.btnThReports = new System.Windows.Forms.Button();
            this.btnCustLookup = new System.Windows.Forms.Button();
            this.btnThMyAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThReports
            // 
            this.btnThReports.Location = new System.Drawing.Point(285, 290);
            this.btnThReports.Name = "btnThReports";
            this.btnThReports.Size = new System.Drawing.Size(231, 66);
            this.btnThReports.TabIndex = 5;
            this.btnThReports.Text = "Reports";
            this.btnThReports.UseVisualStyleBackColor = true;
            // 
            // btnCustLookup
            // 
            this.btnCustLookup.Location = new System.Drawing.Point(285, 191);
            this.btnCustLookup.Name = "btnCustLookup";
            this.btnCustLookup.Size = new System.Drawing.Size(231, 66);
            this.btnCustLookup.TabIndex = 4;
            this.btnCustLookup.Text = "Customer Look up ";
            this.btnCustLookup.UseVisualStyleBackColor = true;
            // 
            // btnThMyAccount
            // 
            this.btnThMyAccount.Location = new System.Drawing.Point(285, 95);
            this.btnThMyAccount.Name = "btnThMyAccount";
            this.btnThMyAccount.Size = new System.Drawing.Size(231, 66);
            this.btnThMyAccount.TabIndex = 3;
            this.btnThMyAccount.Text = "My Account";
            this.btnThMyAccount.UseVisualStyleBackColor = true;
            // 
            // FrmTherapistPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThReports);
            this.Controls.Add(this.btnCustLookup);
            this.Controls.Add(this.btnThMyAccount);
            this.Name = "FrmTherapistPortal";
            this.Text = "Therapist Portal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThReports;
        private System.Windows.Forms.Button btnCustLookup;
        private System.Windows.Forms.Button btnThMyAccount;
    }
}