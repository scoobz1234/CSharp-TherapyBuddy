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
            this.btnCustReports = new System.Windows.Forms.Button();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnMissApt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustReports
            // 
            this.btnCustReports.Location = new System.Drawing.Point(179, 272);
            this.btnCustReports.Name = "btnCustReports";
            this.btnCustReports.Size = new System.Drawing.Size(216, 53);
            this.btnCustReports.TabIndex = 5;
            this.btnCustReports.Text = "Customer Reports ";
            this.btnCustReports.UseVisualStyleBackColor = true;
            // 
            // btnNotes
            // 
            this.btnNotes.Location = new System.Drawing.Point(179, 184);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(216, 53);
            this.btnNotes.TabIndex = 4;
            this.btnNotes.Text = "S O A P Notes";
            this.btnNotes.UseVisualStyleBackColor = true;
            // 
            // btnMissApt
            // 
            this.btnMissApt.Location = new System.Drawing.Point(179, 111);
            this.btnMissApt.Name = "btnMissApt";
            this.btnMissApt.Size = new System.Drawing.Size(216, 53);
            this.btnMissApt.TabIndex = 3;
            this.btnMissApt.Text = "Missed Appointments ";
            this.btnMissApt.UseVisualStyleBackColor = true;
            // 
            // FrmCustomerLookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.btnCustReports);
            this.Controls.Add(this.btnNotes);
            this.Controls.Add(this.btnMissApt);
            this.Name = "FrmCustomerLookUp";
            this.Text = "Customer LookUp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustReports;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Button btnMissApt;
    }
}