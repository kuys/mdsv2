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
    public partial class HistoricoConsultas : Form
    {
        private BaseDeDadosPrototipoContainer baseDados;

        public HistoricoConsultas(int PacienteID)
        {
            InitializeComponent();

            baseDados = new BaseDeDadosPrototipoContainer();

            (from consultas in baseDados.ConsultasSet
             where consultas.PacientesIdPaciente == PacienteID
             orderby consultas.IdConsulta
             select consultas).ToList();

            listBox1.DataSource = baseDados.ConsultasSet.Local.ToList<Consultas>();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                baseDados.ConsultasSet.Remove((Consultas)listBox1.SelectedItem);
                baseDados.SaveChanges();
            }
            else
            {
                MessageBox.Show("Nenhuma consulta selecionada");
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta funcionalidade não esta implementada");
        }

        private void buttonDetalhes_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Consultas consultaSelecionada = (Consultas)listBox1.SelectedItem;

                VisualizarConsulta formVerConsulta = new VisualizarConsulta(consultaSelecionada.IdConsulta, consultaSelecionada);
                formVerConsulta.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhuma consulta selecionada");
            }
        }
    }
}
