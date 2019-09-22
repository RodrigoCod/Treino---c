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
    public partial class FormPgInicialCliente : Form
    {
        public FormPgInicialCliente()
        {
            InitializeComponent();
        }

        private void conectarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void controleDeGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormClienteRelatorioGeral = new FormClienteRelatorioGeral();
            FormClienteRelatorioGeral.ShowDialog();
        }

        private void multasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormClienteRelatorioMultas = new FormClienteRelatorioMultas();
            FormClienteRelatorioMultas.ShowDialog();
        }

        private void FormPgInicialCliente_Load(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormClienteVP = new FormClienteVP();
            FormClienteVP.ShowDialog();
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormVeiculoVL = new FormVeiculoVL();
            FormVeiculoVL.ShowDialog();
        }

        private void viagensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormClienteViagens = new FormClienteViagens();
            FormClienteViagens.ShowDialog();
        }

        private void buscarMotoristaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormClienteMotorista = new FormClienteMotorista();
            FormClienteMotorista.ShowDialog();
        }

        private void buscarAvisosAutomáticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormClienteAvisos = new FormClienteAvisos();
            FormClienteAvisos.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pneusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormClienteRelatorioPneus = new FormClienteRelatorioPneus();
            FormClienteRelatorioPneus.ShowDialog();
        }

        private void peçasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormClienteRelatrioPeças = new FormClienteRelatrioPeças();
            FormClienteRelatrioPeças.ShowDialog();
        }

        private void viagensToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form FormClienteRelatorioViagens = new FormClienteRelatorioViagens();
            FormClienteRelatorioViagens.ShowDialog();
        }
    }
}
