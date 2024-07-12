using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace XmlEnv
{
    class PastaXml
    {


        public static void compact(string[] args)
        {
            string pastaOrigem = @"C:\BACKUP\TESTE";
            string arquivoCompactado = @"C:\BACKUP\TESTE\arquivo.zip";

            ZipFile.CreateFromDirectory(pastaOrigem, arquivoCompactado);

            Console.WriteLine($"Pasta compactada em: {arquivoCompactado}");
        }
    }

    public static void DirectoryXml()

    {

        System.IO.FileSystemWatcher checkXml = new FileSystemWatcher("C:\\BACKUP\\TESTE");

        checkXml.IncludeSubdirectories = false;
        checkXml.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite;
        checkXml.Filter = "*.xml";
        checkXml.Changed += new FileSystemEventHandler(checkXml_Changed);
        checkXml.Created += new FileSystemEventHandler(checkXml_Created);
        checkXml.Renamed += new RenamedEventHandler(checkXml_Renamed);
        checkXml.Error += new ErrorEventHandler(checkXml_Error);
        checkXml.EnableRaisingEvents = true;
    }
}
