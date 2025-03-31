using System.IO;
using System.IO.Compression;

namespace XmlEnv.Utils
{
    public class CompressionUtil
    {
        public static void CompressDirectory(string sourceDir, string destinoZip)
        {
            if (File.Exists(destinoZip))
                File.Delete(destinoZip);

            ZipFile.CreateFromDirectory(sourceDir, destinoZip);
        }
    }
}
