using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.IO.Compression;
using System.Text;
using System.Collections.Generic;
using XmlEnv;
using System.Linq;

namespace ExportarConsultaParaTxt
{
    class SqlExtract
    {

        public static List<XML> SqlExtrair(List<string> args = null)
        {
            string connectionString = "Server=SUPORTE-06\\SQL2022;Database=PDV1;User ID=Sa;Password=IzzyWay1234";
            string xmlconsulta = "SELECT XMLDocumentoAutorizado, Chave FROM Fiscal.Documento WHERE Inclusao BETWEEN '20240101' AND '20240131'";

            List<XML> XmlCont = new List<XML>();
            XML XmlConteudo = new XML();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlDataReader reader;

            SqlCommand cmd = new SqlCommand(xmlconsulta, connection);
            cmd.CommandType = System.Data.CommandType.Text;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                XML Xml = new XML();
                Xml.Conteudo = (string)reader["XMLDocumentoAutorizado"] ?? "";
                Xml.Chave = (string)reader["Chave"] ?? "";

                XmlCont.Add(Xml);
            }
            return XmlCont;
        }
        public static void ArquivoCriar(List<XML> xml)
        {
            foreach (XML xmlCont in xml)
            {
                var chaveArquivo = xml.ToList();

                string nomeArquivo = $@"C:\IZZYWAY\teste\{chaveArquivo} .txt";

                using (StreamWriter writer = new StreamWriter(nomeArquivo, true))
                {
                    foreach (var registro in xml)
                        writer.WriteLine($"{registro.Conteudo}");
                }

            }
        }


    }
}