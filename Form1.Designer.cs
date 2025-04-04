﻿namespace XmlEnv
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
            this.emailEnvio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.enviarEmail = new System.Windows.Forms.Button();
            this.cancelarOp = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusProcess = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // localizarXml
            // 
            this.localizarXml.Location = new System.Drawing.Point(316, 60);
            this.localizarXml.Name = "localizarXml";
            this.localizarXml.Size = new System.Drawing.Size(62, 20);
            this.localizarXml.TabIndex = 1;
            this.localizarXml.Text = "Procurar";
            this.localizarXml.UseVisualStyleBackColor = true;
            this.localizarXml.Click += new System.EventHandler(this.localizarXml_Click);
            // 
            // localXml
            // 
            this.localXml.Location = new System.Drawing.Point(12, 60);
            this.localXml.Name = "localXml";
            this.localXml.ReadOnly = true;
            this.localXml.Size = new System.Drawing.Size(298, 20);
            this.localXml.TabIndex = 0;
            this.localXml.Text = "C:\\IZZYWAY\\Clientes\\ServicosDFE\\Vendas\\";
            // 
            // emailEnvio
            // 
            this.emailEnvio.Location = new System.Drawing.Point(12, 116);
            this.emailEnvio.Name = "emailEnvio";
            this.emailEnvio.Size = new System.Drawing.Size(298, 20);
            this.emailEnvio.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Local do Arquivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Enabled = false;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(339, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 40);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // enviarEmail
            // 
            this.enviarEmail.BackColor = System.Drawing.Color.Transparent;
            this.enviarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enviarEmail.Location = new System.Drawing.Point(12, 161);
            this.enviarEmail.Name = "enviarEmail";
            this.enviarEmail.Size = new System.Drawing.Size(130, 34);
            this.enviarEmail.TabIndex = 10;
            this.enviarEmail.Text = "Enviar";
            this.enviarEmail.UseVisualStyleBackColor = false;
            this.enviarEmail.Click += new System.EventHandler(this.enviarEmail_Click);
            // 
            // cancelarOp
            // 
            this.cancelarOp.Enabled = false;
            this.cancelarOp.Location = new System.Drawing.Point(180, 158);
            this.cancelarOp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelarOp.Name = "cancelarOp";
            this.cancelarOp.Size = new System.Drawing.Size(130, 37);
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
            this.statusProcess.Location = new System.Drawing.Point(12, 207);
            this.statusProcess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusProcess.Name = "statusProcess";
            this.statusProcess.Size = new System.Drawing.Size(78, 13);
            this.statusProcess.TabIndex = 12;
            this.statusProcess.Text = "Processando...";
            this.statusProcess.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 232);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(366, 19);
            this.progressBar1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(399, 260);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.statusProcess);
            this.Controls.Add(this.cancelarOp);
            this.Controls.Add(this.enviarEmail);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailEnvio);
            this.Controls.Add(this.localXml);
            this.Controls.Add(this.localizarXml);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button localizarXml;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailEnvio;
        private System.Windows.Forms.TextBox localXml;
        private System.Windows.Forms.Button enviarEmail;
        private System.Windows.Forms.Button cancelarOp;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label statusProcess;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

