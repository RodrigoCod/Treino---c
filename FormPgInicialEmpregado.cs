using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DestaoDeFrotaEntrada.PL
{
    public partial class FormPgInicialEmpregado : Form
    {
        public FormPgInicialEmpregado()
        {
            InitializeComponent();
        }

        private void uscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salvarCttlSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroDeMotoristaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormFuncionarioCadMotorista = new FormFuncionarioCadMotorista();
            FormFuncionarioCadMotorista.ShowDialog();
        }

        private void FormPgInicialEmpregado_Load(object sender, EventArgs e)
        {
            
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
