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
            statusProcess.Text = "compactando...";

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
            statusProcess.Visible = true;
            backgroundWorker1.RunWorkerAsync();
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 3;
            statusProcess.Text = "Processando...";




        }


        public void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            if (backgroundWorker1.CancellationPending)
            {
                e.Cancel = true;
            }
            else
            {

                PastaXml.compactXml(localXml.Text, arquivoZip.Text, emailEnvio.Text);
            }

        }



        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                progressBar1.MarqueeAnimationSpeed = 0;
                progressBar1.Style = ProgressBarStyle.Blocks;
                progressBar1.Value = 0;
                statusProcess.Text = "Aconteceu um erro durante a execução do processo!";
            }
            else if (e.Cancelled)
            {
                statusProcess.Text = "Operação Cancelada pelo Usuário!";
                progressBar1.MarqueeAnimationSpeed = 0;
                progressBar1.Style = ProgressBarStyle.Blocks;
                progressBar1.Value = 0;
            }
            else
            {
                progressBar1.MarqueeAnimationSpeed = 0;
                progressBar1.Style = ProgressBarStyle.Blocks;
                progressBar1.Value = 100;
                enviarEmail.Enabled = true;
                cancelarOp.Enabled = false;
                statusProcess.Text = progressBar1.Value.ToString() + "%";
                MessageBox.Show("Email enviado com sucesso!");
            }
        }

        private void cancelarOp_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                backgroundWorker1.CancelAsync();
                Thread.Sleep(500);
                cancelarOp.Enabled = false;
                enviarEmail.Enabled = true;
                DialogResult dialog = new DialogResult();
                statusProcess.Text = "Cancelando...";
                
                dialog = MessageBox.Show("operação cancelada, você deseja sair?", "Alert!", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    statusProcess.Text = "Cancelado";
                    Thread.Sleep(1000);
                    statusProcess.Visible = false;
                    progressBar1.MarqueeAnimationSpeed = 0;
                    progressBar1.Style = ProgressBarStyle.Blocks;
                    progressBar1.Value = 0;
                }
                
            }
        }


    }
}
