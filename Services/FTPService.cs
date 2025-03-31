using System;
using System.IO;
using System.Net;

namespace XmlEnv.Services
{
    public class FtpService
    {
        public static void UploadFile(string host, string user, string password, string localFile, string remotePath)
        {

            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create($"{host}{remotePath}");
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(user, password);

                using (Stream ftpStream = request.GetRequestStream())
                {
                    byte[] fileContents = File.ReadAllBytes(localFile);
                    ftpStream.Write(fileContents, 0, fileContents.Length);
                }

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Console.WriteLine($"Upload completo. Status: {response.StatusDescription}");
                response.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao fazer upload: {ex.Message}");
            }
        }
    }
}
