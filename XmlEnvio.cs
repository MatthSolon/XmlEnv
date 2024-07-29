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
            string arquivoCompactado = $@"C:\Windows\Temp\{nomearquivo}.zip";
            bool arquivoExiste = File.Exists(arquivoCompactado);
            if (arquivoExiste == true)
            {
                File.Delete(arquivoCompactado);
                ZipFile.CreateFromDirectory(localPasta, arquivoCompactado);
            }
            else
            {
                ZipFile.CreateFromDirectory(localPasta, arquivoCompactado);
            }



            //public static void envioFtp(string nomearquivo)

            string host = "ftp://izzywaystorage.com.br";
            string user = "u632943476.suporte";
            string senha = "@IzzyWay2024";
          //  string arquivoCompactado = $@"C:\Windows\Temp\{nomearquivo}.zip";
           // bool arquivoExiste = File.Exists(arquivoCompactado);
            string destinoRemoto = $"/suporte/xml/{nomearquivo}.zip";

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


            // public static void envioEmail(string nomearquivo, string email)

           // string destinoRemoto = $"/suporte/xml/{nomearquivo}.zip";
            string linkXml = $"http://www.izzywaystorage.com.br/suporte/database{destinoRemoto}";
            string smtpAddress = "smtp.hostinger.com";
            int portNumber = 587;
            bool enableSSL = true;
            string emailFrom = "";
            string password = "";
            string emailTo = email;
            string subject = "Envio de XML";
            string body = $@"<!DOCTYPE html>
<html lang=""pt-BR"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Meu E-mail</title>
    <style>
        body {{
            font-family: Arial, sans-serif;
            background-color: #f5f5f5;
            margin: 0;
            padding: 0;
        }}
        .container {{
            max-width: 600px;
            margin: 0 auto;
            padding: 20px;
            background-color: #ffffff;
            border-radius: 10px;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
        }}             
    </style>
</head>
<body>
    

    <div class=""container"">
        <h1>Envio de XML!</h1>
        <p>Esta é uma mensagem automatica, não Responder</p>
        <p>olá, segue o arquivo com os XML's solicitados basta clicar no botão para fazer o download</p>
        <a href=""{linkXml}"" download>
            <button style=""background-color: #345C72; color: white; border: none; padding: 10px 20px; border-radius: 5px;"">
                Baixar Arquivo
            </button>
        </a>
    </div>
    <div class=""container"">
        <img src=""data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAlgAAABkCAIAAADVI9l0AAAACXBIWXMAAA7EAAAOxAGVKw4bAAAEiGlUWHRYTUw6Y29tLmFkb2JlLnhtcAAAAAAAPD94cGFja2V0IGJlZ2luPSfvu78nIGlkPSdXNU0wTXBDZWhpSHpyZVN6TlRjemtjOWQnPz4KPHg6eG1wbWV0YSB4bWxuczp4PSdhZG9iZTpuczptZXRhLyc+CjxyZGY6UkRGIHhtbG5zOnJkZj0naHR0cDovL3d3dy53My5vcmcvMTk5OS8wMi8yMi1yZGYtc3ludGF4LW5zIyc+CgogPHJkZjpEZXNjcmlwdGlvbiByZGY6YWJvdXQ9JycKICB4bWxuczpBdHRyaWI9J2h0dHA6Ly9ucy5hdHRyaWJ1dGlvbi5jb20vYWRzLzEuMC8nPgogIDxBdHRyaWI6QWRzPgogICA8cmRmOlNlcT4KICAgIDxyZGY6bGkgcmRmOnBhcnNlVHlwZT0nUmVzb3VyY2UnPgogICAgIDxBdHRyaWI6Q3JlYXRlZD4yMDI0LTA3LTE1PC9BdHRyaWI6Q3JlYXRlZD4KICAgICA8QXR0cmliOkV4dElkPmE5YjVhZDkxLTE3NWItNDBmYy1hMzlmLTAyYmRjZWJiMjAyNjwvQXR0cmliOkV4dElkPgogICAgIDxBdHRyaWI6RmJJZD41MjUyNjU5MTQxNzk1ODA8L0F0dHJpYjpGYklkPgogICAgIDxBdHRyaWI6VG91Y2hUeXBlPjI8L0F0dHJpYjpUb3VjaFR5cGU+CiAgICA8L3JkZjpsaT4KICAgPC9yZGY6U2VxPgogIDwvQXR0cmliOkFkcz4KIDwvcmRmOkRlc2NyaXB0aW9uPgoKIDxyZGY6RGVzY3JpcHRpb24gcmRmOmFib3V0PScnCiAgeG1sbnM6ZGM9J2h0dHA6Ly9wdXJsLm9yZy9kYy9lbGVtZW50cy8xLjEvJz4KICA8ZGM6dGl0bGU+CiAgIDxyZGY6QWx0PgogICAgPHJkZjpsaSB4bWw6bGFuZz0neC1kZWZhdWx0Jz5Bc3NpbmF0dXJhIGRlIGVtYWlsICg2MDAgeCAxMDAgcHgpIC0gMTwvcmRmOmxpPgogICA8L3JkZjpBbHQ+CiAgPC9kYzp0aXRsZT4KIDwvcmRmOkRlc2NyaXB0aW9u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"" alt=""Izzyway back"">
    </div>
</body>
</html>

                            
             ";

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

                MessageBox.Show("Email enviado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception caught in CreateTestMessage2(): {0}",
                    ex.ToString());
            }


        }
    }
}

