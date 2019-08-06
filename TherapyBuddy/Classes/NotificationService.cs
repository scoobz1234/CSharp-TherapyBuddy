using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace TherapyBuddy.Classes
{
    public class EmailNotify
    {
        public void SendEmail()
        {
            try
            {
                // Creates and stores the email message information such as from, to, subject and body.
                MailMessage emailNotify = new MailMessage();
                // Establishes connection to the gmail SMTP server so email can be sent.
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                emailNotify.From = new MailAddress("TherapyBuddyApp@gmail.com");
                emailNotify.To.Add("TherapyBuddyApp@gmail.com");
                emailNotify.Subject = "Your service report.";
                emailNotify.Body = "This is a test email to ensure the notification system is working.";

                smtpServer.Port = 587;
                smtpServer.Credentials = new System.Net.NetworkCredential("TherapyBuddyApp@gmail.com", "therapybuddy!");
                smtpServer.EnableSsl = true;

                smtpServer.Send(emailNotify);
                MessageBox.Show("Email sent!");
            }
            catch (Exception gen)
            {
                MessageBox.Show(gen.ToString());
            }
        }
    }
}