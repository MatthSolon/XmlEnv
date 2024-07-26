using ExportarConsultaParaTxt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XmlEnv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
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

        private void enviarEmail_Click(object sender, EventArgs e)
        {

            enviarEmail.Enabled = false;
            cancelarOp.Enabled = true;
            backgroundWorker1.RunWorkerAsync();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            
            PastaXml.compactXml(localXml.Text, arquivoZip.Text);
            
            
            PastaXml.envioFtp(arquivoZip.Text);
            
            
            PastaXml.envioEmail(arquivoZip.Text, emailEnvio.Text);
           
            for (int i = 1; i <= 100; i++)
            {
               
                Thread.Sleep(100);
               
                backgroundWorker1.ReportProgress(i);
            }


        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("erro no Processo");
            }
            else if (e.Cancelled)
            {
               
                MessageBox.Show("Processo Cancelado");
            }
            else
            {
                
                Console.WriteLine("concluido!");
            }
        }

        private void cancelarOp_Click(object sender, EventArgs e)
        {

            backgroundWorker1.CancelAsync();

            Thread.Sleep(1000);
            cancelarOp.Enabled = false;
            enviarEmail.Enabled = true;

        }
    }
}
