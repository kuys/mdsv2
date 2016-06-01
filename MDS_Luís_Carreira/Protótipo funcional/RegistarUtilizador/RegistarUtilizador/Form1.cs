using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace RegistarUtilizador
{
    public partial class Form1 : Form
    {
        private Model1Container baseDados;

        public Form1()
        {
            InitializeComponent();

            baseDados = new Model1Container();

            (from UtilizadorA in baseDados.UtilizadorASet
             orderby UtilizadorA.Id
             select UtilizadorA).Load();

            utilizadorABindingSource.DataSource = baseDados.UtilizadorASet.Local.ToBindingList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text.Length == 0 || textBoxApelido.Text.Length == 0 || textBoxCC.Text.Length == 0
                 || textBoxCodP.Text.Length == 0 || textBoxLocalidade.Text.Length == 0 || textBoxMorada.Text.Length == 0 || textBoxPassword.Text.Length == 0
                 || textBoxRepPassword.Text.Length == 0 || textBoxTelefone.Text.Length == 0 || textBoxUsername.Text.Length == 0)
            {
                MessageBox.Show("Os campos vazios são de preenchimento obrigatório!");
                return;
            }
            else if (textBoxPassword.Text != textBoxRepPassword.Text)
            {
                MessageBox.Show("As palavras-passes não coincidem!");
                return;
            }
            else
            {
                String valorPerfil = "";
                if (radioButton1.Checked == true)
                    valorPerfil = radioButton1.Text;
                else if (radioButton2.Checked == true)
                    valorPerfil = radioButton2.Text;
                else if (radioButton3.Checked == true)
                    valorPerfil = radioButton3.Text;
                else if (radioButton4.Checked == true)
                    valorPerfil = radioButton4.Text;

                UtilizadorA tempRegisto = new UtilizadorA();

                tempRegisto.Nome = textBoxNome.Text;
                tempRegisto.Apelido = textBoxApelido.Text;
                tempRegisto.Sexo = comboBoxSexo.Text;
                tempRegisto.Morada = textBoxMorada.Text;
                tempRegisto.CodP = textBoxCodP.Text;
                tempRegisto.Localidade = textBoxLocalidade.Text;
                tempRegisto.Telefone = textBoxTelefone.Text;
                tempRegisto.DataNasc = dateTimePicker1.Text;
                tempRegisto.CC = textBoxCC.Text;
                tempRegisto.EstadoC = comboBoxEstadoC.Text;
                tempRegisto.Username = textBoxUsername.Text;
                tempRegisto.Password = textBoxPassword.Text;
                tempRegisto.Perfil = valorPerfil;

                baseDados.UtilizadorASet.Add(tempRegisto);
                baseDados.SaveChanges();
                utilizadorABindingSource.DataSource = baseDados.UtilizadorASet.Local.ToBindingList();

                MessageBox.Show("O utilizador foi registado com sucesso!");

                textBoxNome.Text = "";
                textBoxApelido.Text = "";
                textBoxMorada.Text = "";
                textBoxCodP.Text = "";
                textBoxLocalidade.Text = "";
                textBoxTelefone.Text = "";
                textBoxCC.Text = "";
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
                textBoxRepPassword.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
