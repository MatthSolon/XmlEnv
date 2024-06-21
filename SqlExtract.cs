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
using Microsoft.Win32;

namespace ExportarConsultaParaTxt
{
    class SqlExtract
    {

        public static List<XML> SqlExtrair(List<string> args = null)
        {
            //string connectionString = "Server=SUPORTE-06\\SQL2022;Database=PDV1;User ID=Sa;Password=IzzyWay1234";
            string connectionString = "Server=DESKTOP-B1VUQ49;Database=PDV;User ID=Sa;Password=matheusSC12";
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
                XML XmlLista = new XML();
                XmlLista.Conteudo = (string)reader["XMLDocumentoAutorizado"] ?? "";
                XmlLista.Chave = (string)reader["Chave"] ?? "";

                XmlCont.Add(XmlLista);
            }
            return XmlCont;
        }
        public static void ArquivoCriar(List<XML> XmlLista)
        {
            foreach (XML xmlCont in XmlLista)
            {
                var conteudoArquivo = xmlCont.Conteudo;
                var chaveArquivo = xmlCont.Chave;
                foreach (var registro in XmlLista)
                {
                    string nomeArquivo = $@"C:\BACKUP\TESTE\{chaveArquivo}.txt";
                    using (StreamWriter writer = new StreamWriter(nomeArquivo, true))
                    {
                        for (int i = 0; i < conteudoArquivo.Length; i++)
                        {
                            writer.WriteLine($"{conteudoArquivo[i]}");
                        }
                    }

                }
            }

        }
    }
}
