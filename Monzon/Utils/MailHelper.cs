using System;

namespace Monzon.Utils
{
    using System.Configuration;
    using System.Net.Mail;
    using System.Text.RegularExpressions;

    public class MailHelper
    {
        public Boolean ValidEmail(String email)
        {
            const string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool SendContactEmail(string name, string email, string message)
        {
            SmtpClient smtpServer = new SmtpClient
            {
                Credentials = new System.Net.NetworkCredential(ConfigurationManager.AppSettings.Get("adminSender"), ConfigurationManager.AppSettings.Get("adminSenderPassword")),
                Port = int.Parse(ConfigurationManager.AppSettings.Get("portSender")),
                Host = ConfigurationManager.AppSettings.Get("hostSender"),
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network
                //UseDefaultCredentials = false
            };
            var mail = new MailMessage();
           
            try
            {
                mail.From = new MailAddress(ConfigurationManager.AppSettings.Get("adminSender"),
                "RsVp Web Contact System", System.Text.Encoding.UTF8);
                mail.To.Add(ConfigurationManager.AppSettings.Get("adminReceiver"));
                mail.Subject = "Web Contact";
                mail.IsBodyHtml = true;
                mail.Body = "Someone sent a message through the Website system </br></br> Name: " + name + "</br> Email: " + email + "</br> Message: " + message;
                //mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                //mail.ReplyTo = new MailAddress(TextBox1.Text);
                //smtpServer.Send(mail);

                smtpServer.Send(ConfigurationManager.AppSettings.Get("adminReceiver"), ConfigurationManager.AppSettings.Get("adminSender"), "Web Contact", "Someone sent a message through the Website system </br></br> Name: " + name + "</br> Email: " + email + "</br> Message: " + message);
                
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}