using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using File = System.IO.File;
using System.ComponentModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace XmlEnv
{


    class PastaXml
    {

        public static void compactXml(string localPasta, string nomearquivo, string email)
        {
            string htmlFilePath = @"C:\Users\mathe\source\repos\XmlEnv\HTMLPage1.html";
            string user = "u632943476.suporte";
            string senha = "@IzzyWay2024";
            string destinoRemoto = $"/suporte/xml/{nomearquivo}.zip";
            string arquivoCompactado = $@"C:\Windows\Temp\{nomearquivo}.zip";
            bool arquivoExiste = File.Exists(arquivoCompactado);
            string linkXml = $"http://www.izzywaystorage.com.br/suporte/database{destinoRemoto}";
            string smtpAddress = "smtp.hostinger.com";
            int portNumber = 587;
            bool enableSSL = true;
            string emailFrom = "matheus.solon@izzyway.com.br";
            string password = "matheusSC12!";
            string emailTo = email;
            string subject = "XML loja: {Estabelecimento} – {nomeDispositivo} ref.: {mês}/{ano}";
            string body = File.ReadAllText(htmlFilePath);
            string host = "ftp://izzywaystorage.com.br";
           

            if (arquivoExiste == true)
            {
                File.Delete(arquivoCompactado);
                ZipFile.CreateFromDirectory(localPasta, arquivoCompactado);
            }
            else
            {
                ZipFile.CreateFromDirectory(localPasta, arquivoCompactado);
            }
 
            try
            {
                FtpWebRequest ftpAcesso = (FtpWebRequest)WebRequest.Create(host + destinoRemoto);
                ftpAcesso.Method = WebRequestMethods.Ftp.UploadFile;
                ftpAcesso.Credentials = new NetworkCredential(user, senha);


                using (Stream stream = ftpAcesso.GetRequestStream())
                {
                    byte[] conteudoArquivo = File.ReadAllBytes(arquivoCompactado);
                    stream.Write(conteudoArquivo, 0, conteudoArquivo.Length);

                }

                FtpWebResponse response = (FtpWebResponse)ftpAcesso.GetResponse();
                Console.WriteLine($"Upload concluído. Status: {response.StatusDescription}");
                response.Close();
                File.Delete(arquivoCompactado);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao fazer upload: {ex.Message}");
            }

            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailFrom);
                    mail.To.Add(emailTo);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                    {
                        smtp.Credentials = new NetworkCredential(emailFrom, password);
                        smtp.EnableSsl = enableSSL;
                        smtp.Send(mail);
                    }
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception caught in CreateTestMessage2(): {0}",
                    ex.ToString());
            }
        }
    }
}

