namespace TherapyBuddy
{
    partial class FrmWelcome
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
            this.LblGreeting = new System.Windows.Forms.Label();
            this.PicGreeting = new System.Windows.Forms.PictureBox();
            this.BtnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicGreeting)).BeginInit();
            this.SuspendLayout();
            // 
            // LblGreeting
            // 
            this.LblGreeting.AutoSize = true;
            this.LblGreeting.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblGreeting.Location = new System.Drawing.Point(151, 26);
            this.LblGreeting.Name = "LblGreeting";
            this.LblGreeting.Size = new System.Drawing.Size(269, 17);
            this.LblGreeting.TabIndex = 0;
            this.LblGreeting.Text = "We are delighted to give you VIP Service ";
            this.LblGreeting.Click += new System.EventHandler(this.lblgreeting_Click);
            // 
            // PicGreeting
            // 
            this.PicGreeting.Image = global::TherapyBuddy.Properties.Resources.sports_physical_therapy;
            this.PicGreeting.Location = new System.Drawing.Point(62, 68);
            this.PicGreeting.Name = "PicGreeting";
            this.PicGreeting.Size = new System.Drawing.Size(471, 199);
            this.PicGreeting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicGreeting.TabIndex = 1;
            this.PicGreeting.TabStop = false;
            this.PicGreeting.UseWaitCursor = true;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(139, 312);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(320, 67);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "Get Started ";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // FrmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 436);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.PicGreeting);
            this.Controls.Add(this.LblGreeting);
            this.Name = "FrmWelcome";
            this.Text = "FrmWelcome";
            this.Load += new System.EventHandler(this.FrmWelcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicGreeting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblGreeting;
        private System.Windows.Forms.PictureBox PicGreeting;
        private System.Windows.Forms.Button BtnStart;
    }
}