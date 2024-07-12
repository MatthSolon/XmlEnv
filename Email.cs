using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace XmlEnv
{
    public class Email
    {

        public string provedor { get; private set; }
        public string email { get; private set; }
        public string password { get; private set; }

        public Email(string provedor, string email, string password)
        {
            this.provedor = provedor ?? throw new ArgumentNullException(nameof(provedor));
            this.email = email ?? throw new ArgumentNullException(nameof(email));
            this.password = password ?? throw new ArgumentNullException(nameof(password));
        }

        /* public void SendEmail(List<string> emailsTo, string assunto, string corpoEmail, List<string> anexos)
         {
             var mensagem = PrepareteMessage(emailsTo, assunto, corpoEmail, anexos);
             SendEmailBySmtp(mensagem);
         }*/

        private MailMessage PrepareteMessage(List<string> emailsTo, string assunto, string corpoEmail, List<string> anexos)
        {
            var mail = new MailMessage();
            mail.From = new MailAddress(email);
            foreach (var email in emailsTo)
            {
                if (ValidarEmail(email))
                {
                    mail.To.Add(email);
                }
            }
            mail.Subject = assunto;
            mail.Body = corpoEmail;
            mail.IsBodyHtml = true;

            foreach (var file in anexos)
            {
                var data = new Attachment(file, MediaTypeNames.Application.Octet);
                ContentDisposition disposition = data.ContentDisposition;
                disposition.CreationDate = System.IO.File.GetCreationTime(file);
                disposition.ModificationDate = System.IO.File.GetLastWriteTime(file);
                disposition.ReadDate = System.IO.File.GetLastAccessTime(file);

                mail.Attachments.Add(data);
            }

            return mail;
        }
        private bool ValidarEmail(string email)
        {
            Regex expression = new Regex(@"\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}");
            if (expression.IsMatch(email))

                return true;

            return false;
        }
        private void SendEmailBySmtp(MailMessage mensagem, string email  )
        {
            SmtpClient smtp = new SmtpClient();
            smtp.Host = provedor;
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Timeout = 50000;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(email, password);
            smtp.Send(mensagem);
            smtp.Dispose();
        }
    }
}
