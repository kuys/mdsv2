namespace Prototipo
{
    partial class VisualizarPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarPacientes));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxSNS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMorada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNIF = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxContacto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSexo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxEstadoCivil = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxDataNascimento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.buttonProcurar = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonConsultas = new System.Windows.Forms.Button();
            this.buttonRegistarConsulta = new System.Windows.Forms.Button();
            this.buttonRegistarUtente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(537, 30);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(42, 13);
            this.linkLabel1.TabIndex = 29;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "LogOut";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(539, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Doutor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(9, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 44);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Albert Einstein Hospital";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(570, 186);
            this.listBox1.TabIndex = 30;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(62, 263);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.ReadOnly = true;
            this.textBoxNome.Size = new System.Drawing.Size(121, 20);
            this.textBoxNome.TabIndex = 33;
            // 
            // textBoxSNS
            // 
            this.textBoxSNS.Location = new System.Drawing.Point(222, 263);
            this.textBoxSNS.Name = "textBoxSNS";
            this.textBoxSNS.ReadOnly = true;
            this.textBoxSNS.Size = new System.Drawing.Size(138, 20);
            this.textBoxSNS.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "SNS:";
            // 
            // textBoxMorada
            // 
            this.textBoxMorada.Location = new System.Drawing.Point(418, 263);
            this.textBoxMorada.Name = "textBoxMorada";
            this.textBoxMorada.ReadOnly = true;
            this.textBoxMorada.Size = new System.Drawing.Size(161, 20);
            this.textBoxMorada.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Morada:";
            // 
            // textBoxBI
            // 
            this.textBoxBI.Location = new System.Drawing.Point(62, 289);
            this.textBoxBI.Name = "textBoxBI";
            this.textBoxBI.ReadOnly = true;
            this.textBoxBI.Size = new System.Drawing.Size(121, 20);
            this.textBoxBI.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "BI / CC:";
            // 
            // textBoxNIF
            // 
            this.textBoxNIF.Location = new System.Drawing.Point(222, 289);
            this.textBoxNIF.Name = "textBoxNIF";
            this.textBoxNIF.ReadOnly = true;
            this.textBoxNIF.Size = new System.Drawing.Size(138, 20);
            this.textBoxNIF.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "NIF:";
            // 
            // textBoxContacto
            // 
            this.textBoxContacto.Location = new System.Drawing.Point(418, 289);
            this.textBoxContacto.Name = "textBoxContacto";
            this.textBoxContacto.ReadOnly = true;
            this.textBoxContacto.Size = new System.Drawing.Size(161, 20);
            this.textBoxContacto.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(366, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Contacto:";
            // 
            // textBoxSexo
            // 
            this.textBoxSexo.Location = new System.Drawing.Point(62, 315);
            this.textBoxSexo.Name = "textBoxSexo";
            this.textBoxSexo.ReadOnly = true;
            this.textBoxSexo.Size = new System.Drawing.Size(121, 20);
            this.textBoxSexo.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Sexo";
            // 
            // textBoxEstadoCivil
            // 
            this.textBoxEstadoCivil.Location = new System.Drawing.Point(260, 315);
            this.textBoxEstadoCivil.Name = "textBoxEstadoCivil";
            this.textBoxEstadoCivil.ReadOnly = true;
            this.textBoxEstadoCivil.Size = new System.Drawing.Size(100, 20);
            this.textBoxEstadoCivil.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(189, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Estado Civil:";
            // 
            // textBoxDataNascimento
            // 
            this.textBoxDataNascimento.Location = new System.Drawing.Point(479, 315);
            this.textBoxDataNascimento.Name = "textBoxDataNascimento";
            this.textBoxDataNascimento.ReadOnly = true;
            this.textBoxDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.textBoxDataNascimento.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(366, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Data de Nascimento:";
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(487, 352);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonAtualizar.TabIndex = 50;
            this.buttonAtualizar.Text = "Atualizar";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // buttonProcurar
            // 
            this.buttonProcurar.Location = new System.Drawing.Point(406, 352);
            this.buttonProcurar.Name = "buttonProcurar";
            this.buttonProcurar.Size = new System.Drawing.Size(75, 23);
            this.buttonProcurar.TabIndex = 51;
            this.buttonProcurar.Text = "Procurar";
            this.buttonProcurar.UseVisualStyleBackColor = true;
            this.buttonProcurar.Click += new System.EventHandler(this.buttonProcurar_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(325, 352);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 24);
            this.buttonApagar.TabIndex = 52;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonConsultas
            // 
            this.buttonConsultas.Location = new System.Drawing.Point(244, 352);
            this.buttonConsultas.Name = "buttonConsultas";
            this.buttonConsultas.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultas.TabIndex = 53;
            this.buttonConsultas.Text = "Consultas";
            this.buttonConsultas.UseVisualStyleBackColor = true;
            this.buttonConsultas.Click += new System.EventHandler(this.buttonConsultas_Click);
            // 
            // buttonRegistarConsulta
            // 
            this.buttonRegistarConsulta.Location = new System.Drawing.Point(130, 352);
            this.buttonRegistarConsulta.Name = "buttonRegistarConsulta";
            this.buttonRegistarConsulta.Size = new System.Drawing.Size(108, 23);
            this.buttonRegistarConsulta.TabIndex = 54;
            this.buttonRegistarConsulta.Text = "Registar Consulta";
            this.buttonRegistarConsulta.UseVisualStyleBackColor = true;
            this.buttonRegistarConsulta.Click += new System.EventHandler(this.buttonRegistarConsulta_Click);
            // 
            // buttonRegistarUtente
            // 
            this.buttonRegistarUtente.Location = new System.Drawing.Point(30, 352);
            this.buttonRegistarUtente.Name = "buttonRegistarUtente";
            this.buttonRegistarUtente.Size = new System.Drawing.Size(94, 23);
            this.buttonRegistarUtente.TabIndex = 55;
            this.buttonRegistarUtente.Text = "Registar Utente";
            this.buttonRegistarUtente.UseVisualStyleBackColor = true;
            this.buttonRegistarUtente.Click += new System.EventHandler(this.buttonRegistarUtente_Click);
            // 
            // VisualizarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 389);
            this.Controls.Add(this.buttonRegistarUtente);
            this.Controls.Add(this.buttonRegistarConsulta);
            this.Controls.Add(this.buttonConsultas);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.buttonProcurar);
            this.Controls.Add(this.buttonAtualizar);
            this.Controls.Add(this.textBoxDataNascimento);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxEstadoCivil);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxSexo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxContacto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxNIF);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxBI);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxMorada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSNS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Name = "VisualizarPacientes";
            this.Text = "VisualizarPacientes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxSNS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMorada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNIF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxContacto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSexo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxEstadoCivil;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxDataNascimento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.Button buttonProcurar;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Button buttonConsultas;
        private System.Windows.Forms.Button buttonRegistarConsulta;
        private System.Windows.Forms.Button buttonRegistarUtente;
    }
}