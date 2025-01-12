using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
namespace XmlEnv
{
   
    class GoogleDriveEnv
    {
        static string[] Scopes = { DriveService.Scope.DriveFile }; // Permissão para manipular arquivos
        static string ApplicationName = "Drive API C# App";

        static void Main(string[] args)
        {
            // Caminho para as credenciais do Google (JSON do Google Cloud)
            string credentialPath = "path/to/credentials.json";

            UserCredential credential;
            using (var stream = new FileStream(credentialPath, FileMode.Open, FileAccess.Read))
            {
                string credPath = "token.json"; // Salva token de autenticação
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Autorizado!");
            }

            // Cria o serviço do Google Drive
            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Caminho do arquivo que será enviado
            string filePath = "path/to/your/file.zip";

            // Metadados do arquivo
            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                Name = "file.zip" // Nome do arquivo no Google Drive
            };

            // Upload do arquivo
            FilesResource.CreateMediaUpload request;
            using (var stream = new FileStream(filePath, FileMode.Open))
            {
                request = service.Files.Create(
                    fileMetadata,
                    stream,
                    "application/zip");
                request.Fields = "id";
                request.Upload();
            }

            // Obtém o ID do arquivo
            var file = request.ResponseBody;
            Console.WriteLine($"Arquivo enviado! ID: {file.Id}");

            // (Opcional) Gerar link compartilhável
            CreateShareableLink(service, file.Id);
        }

        static void CreateShareableLink(DriveService service, string fileId)
        {
            var permission = new Google.Apis.Drive.v3.Data.Permission()
            {
                Type = "anyone",
                Role = "reader"
            };
            service.Permissions.Create(permission, fileId).Execute();

            Console.WriteLine($"Link Compartilhável: https://drive.google.com/file/d/{fileId}/view?usp=sharing");
        }
    }

}
