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
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(285, 290);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(231, 66);
            this.button8.TabIndex = 5;
            this.button8.Text = "Reports";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(285, 191);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(231, 66);
            this.button7.TabIndex = 4;
            this.button7.Text = "Customer Look up ";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(285, 95);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(231, 66);
            this.button6.TabIndex = 3;
            this.button6.Text = "My Account";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // FrmTherapistPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Name = "FrmTherapistPortal";
            this.Text = "Therapist Portal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
    }
}