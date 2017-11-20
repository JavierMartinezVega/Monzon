
namespace Monzon.BL.Repository
{
    using System.Collections.Generic;
    using System.Transactions;
    using System.Linq;
    using Model;
    using System.Net.Mail;

    public class LoginRepository: BaseRepository<LOGIN>
    {

        /// <summary>
        /// unique instance 
        /// </summary>
        private static readonly LoginRepository ServiceInstance = new LoginRepository();

        /// <summary>
        /// Gets the unique instance
        /// </summary>
        public static LoginRepository Instance
        {
            get
            {
                return ServiceInstance;
            }
        }

        public LOGIN CheckUser(LOGIN login)
        {
            using (var db = new MonzonEntities())
            {
                return db.LOGIN.FirstOrDefault(l => l.LOGIN1 == login.LOGIN1 && l.PASSWORD == login.PASSWORD);
            }
        }

        public bool PasswordRecovery(LOGIN login, string random)
        {
            using (var ts = new TransactionScope())
            {
                using (var db = new MonzonEntities())
                {
                    login.PASSWORD = random;
                    db.LOGIN.Attach(login);
                    db.SaveChanges();
                }

                MailMessage mail = new MailMessage("you@yourcompany.com", login.EMAIL);
                SmtpClient client = new SmtpClient {Port = 25, DeliveryMethod = SmtpDeliveryMethod.Network, UseDefaultCredentials = false, Host = "smtp.google.com"};
                mail.Subject = "this is a test email.";
                mail.Body = "this is my test email body";
                client.Send(mail);

                ts.Complete();

                return true;
            }
        }

        public List<LOGIN> GetMembers()
        {
            using (var db = new MonzonEntities())
            {
                return db.LOGIN.Where(l => l.PROFILE.BIZ_ID != "PUB").ToList();
            }
        }
    }
}
