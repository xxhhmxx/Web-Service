using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MailService" in both code and config file together.
    public class MailService : IMailService
    {
        public void SendMail(string toEmail, string subject, string content)
        {
            var fromEmailAddrr = ConfigurationManager.AppSettings["FromEmailAddress"].ToString();
            var fromEmailDisplay = ConfigurationManager.AppSettings["FromEmailDisplayName"].ToString();
            var fromEmailPass = ConfigurationManager.AppSettings["FromEmailPassword"].ToString();
            var smtpHost = ConfigurationManager.AppSettings["SMTPHost"].ToString();
            var smtpPort = ConfigurationManager.AppSettings["SMTPPort"].ToString();

            bool enableSsl = bool.Parse(ConfigurationManager.AppSettings["EnableSSL"].ToString());

            string body = content;
            MailMessage message = new MailMessage(new MailAddress(fromEmailAddrr, fromEmailDisplay), new MailAddress(toEmail));
            message.Subject = subject;
            message.IsBodyHtml = true;
            message.Body = body;

            var client = new SmtpClient();
            client.Credentials = new NetworkCredential(fromEmailAddrr, fromEmailPass);
            client.Host = smtpHost;
            client.EnableSsl = enableSsl;
            client.Port = !string.IsNullOrEmpty(smtpPort) ? Convert.ToInt32(smtpPort) : 0;
            client.Send(message);
        }
    }
}
