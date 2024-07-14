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
            this.localXml.Size = new System.Drawing.Size(298, 20);
            this.localXml.TabIndex = 0;
            this.localXml.Text = "C:\\IZZYWAY\\Clientes\\ServicosDFE\\Vendas";
            this.localXml.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // arquivoZip
            // 
            this.arquivoZip.Location = new System.Drawing.Point(12, 132);
            this.arquivoZip.Name = "arquivoZip";
            this.arquivoZip.Size = new System.Drawing.Size(298, 20);
            this.arquivoZip.TabIndex = 2;
            // 
            // emailEnvio
            // 
            this.emailEnvio.Location = new System.Drawing.Point(12, 171);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome do Arquivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(388, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 40);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // DatabaseForm
            // 
            this.DatabaseForm.Image = ((System.Drawing.Image)(resources.GetObject("DatabaseForm.Image")));
            this.DatabaseForm.Location = new System.Drawing.Point(433, 12);
            this.DatabaseForm.Name = "DatabaseForm";
            this.DatabaseForm.Size = new System.Drawing.Size(45, 40);
            this.DatabaseForm.TabIndex = 9;
            this.DatabaseForm.UseVisualStyleBackColor = true;
            // 
            // enviarEmail
            // 
            this.enviarEmail.BackColor = System.Drawing.Color.Transparent;
            this.enviarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enviarEmail.Location = new System.Drawing.Point(50, 214);
            this.enviarEmail.Name = "enviarEmail";
            this.enviarEmail.Size = new System.Drawing.Size(211, 34);
            this.enviarEmail.TabIndex = 10;
            this.enviarEmail.Text = "Enviar";
            this.enviarEmail.UseVisualStyleBackColor = false;
            this.enviarEmail.Click += new System.EventHandler(this.enviarEmail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(487, 260);
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
            this.Name = "Form1";
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
    }
}

