using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pacienteSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacienteSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet1.PacienteSet' table. You can move, or remove it, as needed.
            this.pacienteSetTableAdapter.Fill(this.hospitalDataSet1.PacienteSet);
            // TODO: This line of code loads data into the 'hospitalDataSet.PacienteSet' table. You can move, or remove it, as needed.
            this.pacienteSetTableAdapter.Fill(this.hospitalDataSet1.PacienteSet);

        }

        private void pacienteSetBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pacienteSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet1);

        }
    }
}
