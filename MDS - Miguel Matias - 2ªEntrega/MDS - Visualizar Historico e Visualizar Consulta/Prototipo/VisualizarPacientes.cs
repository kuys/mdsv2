using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo
{
    public partial class VisualizarPacientes : Form
    {
        private BaseDeDadosPrototipoContainer baseDados;

        public VisualizarPacientes()
        {
            InitializeComponent();
            
            baseDados = new BaseDeDadosPrototipoContainer();

            listBox1.DataSource = baseDados.PacientesSet.ToList<Pacientes>();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pacientes pacienteSelecionado = (Pacientes)listBox1.SelectedItem;

            textBoxNome.Text = pacienteSelecionado.Nome;
            textBoxBI.Text = pacienteSelecionado.BI_CC.ToString();
            textBoxSexo.Text = pacienteSelecionado.Sexo;
            textBoxSNS.Text = pacienteSelecionado.NºSNS.ToString();
            textBoxNIF.Text = pacienteSelecionado.NIF.ToString();
            textBoxEstadoCivil.Text = pacienteSelecionado.EstadoCivil;
            textBoxMorada.Text = pacienteSelecionado.Morada;
            textBoxContacto.Text = pacienteSelecionado.Contacto;
            textBoxDataNascimento.Text = pacienteSelecionado.DataNascimento.ToShortDateString();
        }

        private void buttonRegistarUtente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidade não esta implementada");
        }

        private void buttonRegistarConsulta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidade não esta implementada");
        }

        private void buttonConsultas_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Pacientes pacienteSelecionado = (Pacientes)listBox1.SelectedItem;

                HistoricoConsultas formHistorico = new HistoricoConsultas(pacienteSelecionado.IdPaciente);
                formHistorico.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não existe nenhum paciente selecionado");
            }
            
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidade não esta implementada");
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidade não esta implementada");
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidade não esta implementada");
        }
    }
}
