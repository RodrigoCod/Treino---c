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
    public partial class FormLoginCliente : Form
    {
        public FormLoginCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormLoginCliente_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtLoginUsuarioCliente.Text == "cliente" && txtLoginSenhaCliente.Text == "1")
            {
                MessageBox.Show("Bem Vindo");
              /*  this.Hide(); */
                Form FormPgInicialCliente = new FormPgInicialCliente();
                FormPgInicialCliente.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login Invalido");
            }
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
