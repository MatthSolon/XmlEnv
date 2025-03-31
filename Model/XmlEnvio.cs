using XmlEnv.Services;
using XmlEnv.Utils;

namespace XmlEnv
{
    class PastaXml
    {
        public static void XmlEvio( string localPasta, string email)
        {
            string arquivoCompactado = $@"C:\Windows\Temp\{{Estabelecimento}}.zip";
            // Compactar arquivos
            CompressionUtil.CompressDirectory(localPasta, arquivoCompactado);
            
            // upload FTP
            FtpService.UploadFile(host, user, senha, arquivoCompactado, destinoRemoto);

            emailService.SendEmail(
                smtpAddress: "smtp.hostinger.com",
                port: 587,
                emailFrom: "matheus.solon@izzyway.com.br",
                password: "matheusSC12!",
                emailTo: email,
                subject: "XML Enviado",
                body: "O arquivo XML foi enviado."
            );
        }
    }
}
