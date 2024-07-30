namespace XmlEnv
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.localizarXml = new System.Windows.Forms.Button();
            this.localXml = new System.Windows.Forms.TextBox();
            this.arquivoZip = new System.Windows.Forms.TextBox();
            this.emailEnvio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.DatabaseForm = new System.Windows.Forms.Button();
            this.enviarEmail = new System.Windows.Forms.Button();
            this.cancelarOp = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusProcess = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // localizarXml
            // 
            this.localizarXml.Location = new System.Drawing.Point(421, 74);
            this.localizarXml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.localizarXml.Name = "localizarXml";
            this.localizarXml.Size = new System.Drawing.Size(83, 25);
            this.localizarXml.TabIndex = 1;
            this.localizarXml.Text = "Procurar";
            this.localizarXml.UseVisualStyleBackColor = true;
            this.localizarXml.Click += new System.EventHandler(this.localizarXml_Click);
            // 
            // localXml
            // 
            this.localXml.Location = new System.Drawing.Point(16, 74);
            this.localXml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.localXml.Name = "localXml";
            this.localXml.ReadOnly = true;
            this.localXml.Size = new System.Drawing.Size(396, 22);
            this.localXml.TabIndex = 0;
            this.localXml.Text = "C:\\IZZYWAY\\Clientes\\ServicosDFE\\Vendas\\";
            // 
            // arquivoZip
            // 
            this.arquivoZip.Location = new System.Drawing.Point(16, 162);
            this.arquivoZip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.arquivoZip.Name = "arquivoZip";
            this.arquivoZip.Size = new System.Drawing.Size(396, 22);
            this.arquivoZip.TabIndex = 2;
            // 
            // emailEnvio
            // 
            this.emailEnvio.Location = new System.Drawing.Point(16, 210);
            this.emailEnvio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailEnvio.Name = "emailEnvio";
            this.emailEnvio.Size = new System.Drawing.Size(396, 22);
            this.emailEnvio.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Local do Arquivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome do Arquivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Enabled = false;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(517, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 49);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // DatabaseForm
            // 
            this.DatabaseForm.Enabled = false;
            this.DatabaseForm.Image = ((System.Drawing.Image)(resources.GetObject("DatabaseForm.Image")));
            this.DatabaseForm.Location = new System.Drawing.Point(577, 15);
            this.DatabaseForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DatabaseForm.Name = "DatabaseForm";
            this.DatabaseForm.Size = new System.Drawing.Size(60, 49);
            this.DatabaseForm.TabIndex = 9;
            this.DatabaseForm.UseVisualStyleBackColor = true;
            // 
            // enviarEmail
            // 
            this.enviarEmail.BackColor = System.Drawing.Color.Transparent;
            this.enviarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enviarEmail.Location = new System.Drawing.Point(463, 143);
            this.enviarEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enviarEmail.Name = "enviarEmail";
            this.enviarEmail.Size = new System.Drawing.Size(173, 42);
            this.enviarEmail.TabIndex = 10;
            this.enviarEmail.Text = "Enviar";
            this.enviarEmail.UseVisualStyleBackColor = false;
            this.enviarEmail.Click += new System.EventHandler(this.enviarEmail_Click);
            // 
            // cancelarOp
            // 
            this.cancelarOp.Enabled = false;
            this.cancelarOp.Location = new System.Drawing.Point(463, 210);
            this.cancelarOp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelarOp.Name = "cancelarOp";
            this.cancelarOp.Size = new System.Drawing.Size(173, 46);
            this.cancelarOp.TabIndex = 11;
            this.cancelarOp.Text = "cancelar";
            this.cancelarOp.UseVisualStyleBackColor = true;
            this.cancelarOp.Click += new System.EventHandler(this.cancelarOp_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // statusProcess
            // 
            this.statusProcess.AutoSize = true;
            this.statusProcess.Location = new System.Drawing.Point(16, 255);
            this.statusProcess.Name = "statusProcess";
            this.statusProcess.Size = new System.Drawing.Size(97, 16);
            this.statusProcess.TabIndex = 12;
            this.statusProcess.Text = "Processando...";
            this.statusProcess.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 285);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(620, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(649, 320);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.statusProcess);
            this.Controls.Add(this.cancelarOp);
            this.Controls.Add(this.enviarEmail);
            this.Controls.Add(this.DatabaseForm);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailEnvio);
            this.Controls.Add(this.arquivoZip);
            this.Controls.Add(this.localXml);
            this.Controls.Add(this.localizarXml);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button localizarXml;
        private System.Windows.Forms.Button DatabaseForm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailEnvio;
        private System.Windows.Forms.TextBox arquivoZip;
        private System.Windows.Forms.TextBox localXml;
        private System.Windows.Forms.Button enviarEmail;
        private System.Windows.Forms.Button cancelarOp;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label statusProcess;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

