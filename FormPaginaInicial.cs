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
    public partial class FormPaginaInicial : Form
    {
        public FormPaginaInicial()
        {
            InitializeComponent();
        }

        private void FormPaginaInicial_Load(object sender, EventArgs e)
        {

        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void empregadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoginEmpregado outroForm = new FormLoginEmpregado();
            outroForm.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoginCliente outroForm  = new FormLoginCliente();
            outroForm.ShowDialog();

        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void clienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormLoginCliente outroForm = new FormLoginCliente();
            outroForm.ShowDialog();
            
        }

        private void funcionárioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            FormLoginEmpregado outroForm = new FormLoginEmpregado();
            outroForm.ShowDialog();


        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
