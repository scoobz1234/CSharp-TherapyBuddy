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
            this.btnReg = new System.Windows.Forms.Button();
            this.txtRegPhNum = new System.Windows.Forms.RichTextBox();
            this.txtRegLn = new System.Windows.Forms.RichTextBox();
            this.txtRegEmail = new System.Windows.Forms.RichTextBox();
            this.txtRegFn = new System.Windows.Forms.RichTextBox();
            this.lblRegPhNum = new System.Windows.Forms.Label();
            this.lblRegEmail = new System.Windows.Forms.Label();
            this.lblRegLn = new System.Windows.Forms.Label();
            this.lblRegFn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(411, 364);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(286, 54);
            this.btnReg.TabIndex = 17;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = true;
            // 
            // txtRegPhNum
            // 
            this.txtRegPhNum.Location = new System.Drawing.Point(260, 250);
            this.txtRegPhNum.Name = "txtRegPhNum";
            this.txtRegPhNum.Size = new System.Drawing.Size(333, 52);
            this.txtRegPhNum.TabIndex = 16;
            this.txtRegPhNum.Text = "";
            // 
            // txtRegLn
            // 
            this.txtRegLn.Location = new System.Drawing.Point(260, 108);
            this.txtRegLn.Name = "txtRegLn";
            this.txtRegLn.Size = new System.Drawing.Size(333, 52);
            this.txtRegLn.TabIndex = 15;
            this.txtRegLn.Text = "";
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.Location = new System.Drawing.Point(260, 176);
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(333, 52);
            this.txtRegEmail.TabIndex = 14;
            this.txtRegEmail.Text = "";
            // 
            // txtRegFn
            // 
            this.txtRegFn.Location = new System.Drawing.Point(260, 33);
            this.txtRegFn.Name = "txtRegFn";
            this.txtRegFn.Size = new System.Drawing.Size(333, 52);
            this.txtRegFn.TabIndex = 13;
            this.txtRegFn.Text = "";
            // 
            // lblRegPhNum
            // 
            this.lblRegPhNum.AutoSize = true;
            this.lblRegPhNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRegPhNum.Location = new System.Drawing.Point(104, 267);
            this.lblRegPhNum.Name = "lblRegPhNum";
            this.lblRegPhNum.Size = new System.Drawing.Size(153, 25);
            this.lblRegPhNum.TabIndex = 12;
            this.lblRegPhNum.Text = "Phone Numbe : ";
            // 
            // lblRegEmail
            // 
            this.lblRegEmail.AutoSize = true;
            this.lblRegEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRegEmail.Location = new System.Drawing.Point(104, 193);
            this.lblRegEmail.Name = "lblRegEmail";
            this.lblRegEmail.Size = new System.Drawing.Size(71, 25);
            this.lblRegEmail.TabIndex = 11;
            this.lblRegEmail.Text = "Email :";
            // 
            // lblRegLn
            // 
            this.lblRegLn.AutoSize = true;
            this.lblRegLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRegLn.Location = new System.Drawing.Point(104, 118);
            this.lblRegLn.Name = "lblRegLn";
            this.lblRegLn.Size = new System.Drawing.Size(112, 25);
            this.lblRegLn.TabIndex = 10;
            this.lblRegLn.Text = "Last Name:";
            // 
            // lblRegFn
            // 
            this.lblRegFn.AutoSize = true;
            this.lblRegFn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRegFn.Location = new System.Drawing.Point(104, 44);
            this.lblRegFn.Name = "lblRegFn";
            this.lblRegFn.Size = new System.Drawing.Size(112, 25);
            this.lblRegFn.TabIndex = 9;
            this.lblRegFn.Text = "First Name:";
            // 
            // FrmRegistrationPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.txtRegPhNum);
            this.Controls.Add(this.txtRegLn);
            this.Controls.Add(this.txtRegEmail);
            this.Controls.Add(this.txtRegFn);
            this.Controls.Add(this.lblRegPhNum);
            this.Controls.Add(this.lblRegEmail);
            this.Controls.Add(this.lblRegLn);
            this.Controls.Add(this.lblRegFn);
            this.Name = "FrmRegistrationPortal";
            this.Text = "FrmRegistrationPortal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.RichTextBox txtRegPhNum;
        private System.Windows.Forms.RichTextBox txtRegLn;
        private System.Windows.Forms.RichTextBox txtRegEmail;
        private System.Windows.Forms.RichTextBox txtRegFn;
        private System.Windows.Forms.Label lblRegPhNum;
        private System.Windows.Forms.Label lblRegEmail;
        private System.Windows.Forms.Label lblRegLn;
        private System.Windows.Forms.Label lblRegFn;
    }
}