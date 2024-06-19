using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.IO.Compression;
using System.Text;

namespace ExportarConsultaParaTxt
{
    class sqlExtract
    {
        static void sqlExtrair(string[] args)
        {
            string connectionString = "";
            string xmlconteudo = "SELECT XMLDocumentoAutorizado FROM Fiscal.Documento WHERE Inclusao BETWEEN '20240101' AND '20240131'";
            string xmlchave = "SELECT Chave FROM Fiscal.Documento WHERE Inclusao BETWEEN '20240101' AND '20240131'";
            //fazer uma lista e fazer um for each para percorrer a lista e enviar !
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(xmlconteudo, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Caminho para o arquivo de saída
                            string caminhoArquivo = $@"C:\IzzyWay\{xmlchave}.txt";

                            using (StreamWriter writer = new StreamWriter(caminhoArquivo))
                            {
                                while (reader.Read())
                                {
                                    // Escreva os resultados no arquivo
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        writer.Write(reader[i].ToString() + "\t"); 
                                    }
                                    writer.WriteLine(); 
                                }
                            }

                            Console.WriteLine("Consulta exportada com sucesso para " + caminhoArquivo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
        string startPath = @".\start";
        string zipPath = @".\result.zip";
        string extractPath = @".\extract";

        ZipFile.CreateFromDirectory(startPath, zipPath);

        ZipFile.ExtractToDirectory(zipPath, extractPath);

    }
}