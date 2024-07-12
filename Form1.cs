using ExportarConsultaParaTxt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XmlEnv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void localizarXml_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog localPasta = new FolderBrowserDialog();
            localPasta.SelectedPath = localXml.Text;
            DialogResult dr = localPasta.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    localXml.Text = localPasta.SelectedPath;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show("Erro.\n\n" +
                                    "Mensagem : " + ex.Message);
                }

            }
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void checkXml_Created(object sender, System.IO.FileSystemEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void enviarEmail_Click(object sender, EventArgs e)
        {
            
        }
    }
}
