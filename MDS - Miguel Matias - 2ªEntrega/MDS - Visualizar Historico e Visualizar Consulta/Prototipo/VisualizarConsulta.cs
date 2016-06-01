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

namespace Prototipo
{
    public partial class VisualizarConsulta : Form
    {
        private BaseDeDadosPrototipoContainer baseDados;

        public VisualizarConsulta(int idConsulta, Consultas consulta)
        {
            InitializeComponent();

            baseDados = new BaseDeDadosPrototipoContainer();

            /*(from medicacao in baseDados.MedicacaoSet
             where medicacao.ConsultasIdConsulta == idConsulta
             orderby medicacao.IdMedicacao
             select medicacao).ToList();*/

            textBoxData.Text = consulta.DataDeRealizacao.ToShortDateString();
            textBoxDoutor.Text = consulta.DoutorResponsavel;
            richTextBoxExames.AppendText(consulta.Exames);
            medicacaoBindingSource.DataSource = consulta.Medicacao;
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
