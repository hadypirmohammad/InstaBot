using BotInstagram.Model;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Windows.Forms;


namespace BotInstagram
{
    public partial class CheckInForm : Form
    {
        public static CheckInForm instance;
        const string EMAIL = "Insta.Bot.Software@gmail.com", PASS = "tklcsohixkhqbblm";
        const string LINK = "https://bsite.net/hadyPir/home/EmailVerify";

        //InstabotDBEntities1 db = new InstabotDBEntities1();
        hadypir_instaEntities db = new hadypir_instaEntities();
        public CheckInForm()
        {
            InitializeComponent();
        }

        bool CheckFreeTrail(User user)
        {
            return user.LoginDate.Value.AddHours(24) > DateTime.Now;
        }

        public bool setSetting(string pstrKey, string pstrValue)
        {
            Configuration objConfigFile =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            bool blnKeyExists = false;

            foreach (string strKey in objConfigFile.AppSettings.Settings.AllKeys)
            {
                if (strKey == pstrKey)
                {
                    blnKeyExists = true;
                    objConfigFile.AppSettings.Settings[pstrKey].Value = pstrValue;
                    break;
                }
            }
            if (!blnKeyExists)
            {
                objConfigFile.AppSettings.Settings.Add(pstrKey, pstrValue);
            }
            objConfigFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            return true;
        }

        private void CheckInForm_Shown(object sender, EventArgs e)
        {
            instance = this;
            if (ConfigurationManager.AppSettings.HasKeys())
            {
                UserTxtbox.Text = ConfigurationManager.AppSettings["username"];
                Passowordtxtbx.Text = ConfigurationManager.AppSettings["password"];
                LoginBtn.PerformClick();
            }
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");

            foreach (ManagementObject queryObj in searcher.Get())
            {

                if (CheckConnection())
                {
                    var user = db.Users.FirstOrDefault(o => o.Username == UserTxtbox.Text || o.Email == UserTxtbox.Text);

                    if (user != null)
                    {
                        if (!user.IsVerify.Value)
                        {
                            MessageBox.Show("please watch your email account and verify your account");
                            return;
                        }

                        if (user.DeviceID != queryObj["ProcessorId"].ToString())
                        {
                            MessageBox.Show("We detected your device not in user of this account");
                            return;
                        }

                        if (user.Password == Passowordtxtbx.Text.EncodePasswordMD5())
                        {
                            if (!user.IsBuy.Value && !CheckFreeTrail(user))
                            {
                                new CustomMessagebox(user.ID).Show();

                                return;
                            }
                            if (CheckFreeTrail(user))
                            {
                                var time = user.LoginDate.Value.AddHours(24) - DateTime.Now;
                                MessageBox.Show("you using trail time for free it will finished after " + Environment.NewLine
                                    + time.Hours + " hour & " + time.Minutes + " minute & " + time.Seconds + " second");
                            }


                            if (!ConfigurationManager.AppSettings.HasKeys() && setSetting("username", UserTxtbox.Text) && setSetting("password", Passowordtxtbx.Text))
                            {
                                MessageBox.Show("Enjoy Program 😉");
                            }


                            var mainForm = new MainForm();
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("your password incorrect");
                        }
                    }
                }
                else
                    MessageBox.Show("your connection down.");
            }

        }
        bool CheckConnection()
        {
            try
            {
                db.Database.Connection.Open();
                db.Database.Connection.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private void Lgnbtn_Click(object sender, EventArgs e)
        {
            SignUppnl.Visible = false;
            LoginPnl.Visible = true;
        }

        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            SignUppnl.Visible = true;
            LoginPnl.Visible = false;
        }

        private void SignUpaslBtn_Click(object sender, EventArgs e)
        {

            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");

            foreach (ManagementObject queryObj in searcher.Get())
            {

                if (CheckConnection())
                {
                    var user = db.Users.FirstOrDefault(o => o.Username == UsertxbxSignup.Text || o.Email == EmailTxbxSignup.Text);
                    
                    if (user == null && UsertxbxSignup.Text != null && passwordTxbxsignup.Text != null && confirmtxbx != null
                        && confirmtxbx.Text == passwordTxbxsignup.Text && UsertxbxSignup.Text != null)
                    {
                        var rndmStr = GetRandomAlphanumericString(8);
                        EmailVerify body = new EmailVerify(LINK + "?user=" + UsertxbxSignup.Text + "&code=" + rndmStr);

                        if (SendEmail(EmailTxbxSignup.Text, body.html))
                        {
                            User User = new User()
                            {
                                DeviceID = queryObj["ProcessorId"].ToString(),
                                Email = EmailTxbxSignup.Text,
                                Password = passwordTxbxsignup.Text.EncodePasswordMD5(),
                                Username = UsertxbxSignup.Text,
                                IsBuy = false,
                                IsVerify = false,
                                VerifyCode = rndmStr,
                                LoginDate = DateTime.Now
                            };
                            db.Users.Add(User);
                            db.SaveChanges();
                        }




                        SignUppnl.Visible = false;
                        LoginPnl.Visible = true;
                    }
                    else
                    {
                        if (user != null)
                            MessageBox.Show("user name or email availible change it please");
                        else if (confirmtxbx.Text != passwordTxbxsignup.Text)
                            MessageBox.Show("Your confirm pass error");
                        else
                            MessageBox.Show("some field is null fill it");
                    }


                }
            }
        }
        bool SendEmail(string email, string htmlString)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress(EMAIL);
                message.To.Add(new MailAddress(email));
                message.Subject = "ایمیل تاییدیه برنامه اینستاباتر";
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = htmlString;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(EMAIL, PASS);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                MessageBox.Show("we Send Email verification Accept it Please", "alert");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("Cant send Email !!!");
                return false;
            }
        }

        public static string GetRandomAlphanumericString(int length)
        {
            const string alphanumericCharacters =
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "abcdefghijklmnopqrstuvwxyz" +
                "0123456789";
            return GetRandomString(length, alphanumericCharacters);
        }

        private void CheckInForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            RememberPassword ps = new RememberPassword();
            ps.Show();
        }

        public static string GetRandomString(int length, IEnumerable<char> characterSet)
        {
            if (length < 0)
                throw new ArgumentException("length must not be negative", "length");
            if (length > int.MaxValue / 8) // 250 million chars ought to be enough for anybody
                throw new ArgumentException("length is too big", "length");
            if (characterSet == null)
                throw new ArgumentNullException("characterSet");
            var characterArray = characterSet.Distinct().ToArray();
            if (characterArray.Length == 0)
                throw new ArgumentException("characterSet must not be empty", "characterSet");

            var bytes = new byte[length * 8];
            var result = new char[length];
            using (var cryptoProvider = new RNGCryptoServiceProvider())
            {
                cryptoProvider.GetBytes(bytes);
            }
            for (int i = 0; i < length; i++)
            {
                ulong value = BitConverter.ToUInt64(bytes, i * 8);
                result[i] = characterArray[value % (uint)characterArray.Length];
            }
            return new string(result);
        }

    }
}
