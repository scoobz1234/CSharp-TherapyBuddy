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
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(179, 272);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(216, 53);
            this.button10.TabIndex = 5;
            this.button10.Text = "Customer Reports ";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(179, 184);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(216, 53);
            this.button9.TabIndex = 4;
            this.button9.Text = "S O A P Notes";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(179, 111);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(216, 53);
            this.button8.TabIndex = 3;
            this.button8.Text = "Missed Appointments ";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // FrmCustomerLookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Name = "FrmCustomerLookUp";
            this.Text = "FrmCustomerLookUp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
    }
}