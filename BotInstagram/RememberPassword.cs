using BotInstagram.Model;

using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace BotInstagram
{
    public partial class RememberPassword : Form
    {
        const string EMAIL = "Insta.Bot.Software@gmail.com", PASS = "tklcsohixkhqbblm";
        const string LINK = "https://bsite.net/hadyPir/home/ResetPassword";

        hadypir_instaEntities db = new hadypir_instaEntities();

        public RememberPassword()
        {
            InitializeComponent();
        }

        private void CheckEmailBtn_Click(object sender, EventArgs e)
        {
            EmailVerify body = new EmailVerify(LINK + "?email=" + emailTextbox.Text + "&code=" + db.Users.FirstOrDefault(o => o.Email == emailTextbox.Text).VerifyCode);
            SendEmail(EMAIL, body.html);

            this.Close();
        }

        bool SendEmail(string email, string htmlString)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress(EMAIL);
                message.To.Add(new MailAddress(email));
                message.Subject = "ایمیل ریست کردن پسورد انستاباتر";
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = htmlString;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(EMAIL, PASS);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                MessageBox.Show("we Send pass changer link please check your email", "alert");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("Cant send Email !!!");
                return false;
            }
        }
    }
}
