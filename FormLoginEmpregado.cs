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
    public partial class FormLoginEmpregado : Form
    {
        public FormLoginEmpregado()
        {
            InitializeComponent();
        }

        private void lblLoginFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void FormLoginFuncinario_Load(object sender, EventArgs e)
        {

        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            if (txtLoginUsuarioFuncionario.Text == "guest" && txtLoginSenhaFuncionario.Text == "1")
            {
                MessageBox.Show("Bem Vindo");
                Form FormPgInicialEmpregado = new FormPgInicialEmpregado();
                FormPgInicialEmpregado.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login Invalido");
            }
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
