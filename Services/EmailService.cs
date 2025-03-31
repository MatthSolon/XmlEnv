using System;
using System.Net;
using System.Net.Mail;

namespace XmlEnv.Services
{
    public class EmailService
    {
        private readonly string _smtpAddress;
        private readonly int _port;
        private readonly string _emailFrom;
        private readonly string _password;

        public EmailService(string smtpAddress, int port, string emailFrom, string password)
        {
            _smtpAddress = smtpAddress;
            _port = port;
            _emailFrom = emailFrom;
            _password = password;
        }

        public void SendEmail(string emailTo, string subject, string body, string smtpAddress, int port, string emailFrom, string password)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(_emailFrom);
                    mail.To.Add(emailTo);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient(_smtpAddress, _port))
                    {
                        smtp.Credentials = new NetworkCredential(_emailFrom, _password);
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }
                Console.WriteLine("E-mail enviado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao enviar e-mail: {ex.Message}");
            }
        }
    }
}
