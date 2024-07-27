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
            backgroundWorker1.RunWorkerAsync();
            enviarEmail.Enabled = false;
            cancelarOp.Enabled = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
                     
            for (int i = 0; i <100; i++)
            {
                Task.Run(() =>
                {
                    this.Invoke(new Action(() =>
                    {
                        backgroundWorker1.ReportProgress(i);
                        Thread.Sleep(200);
                    }));
                });
                PastaXml.envioXml(localXml.Text, arquivoZip.Text, emailEnvio.Text);
            }
            
            e.Result = 0;
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
            if (backgroundWorker1.IsBusy)
            {               
                backgroundWorker1.CancelAsync();
                enviarEmail.Enabled = true;
                cancelarOp.Enabled = false;
            }
        }
    }
}
