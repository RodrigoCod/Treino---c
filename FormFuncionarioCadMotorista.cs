using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaodeFrota.BLL;
using GestaodeFrota.DTO;

namespace DestaoDeFrotaEntrada.PL
{
    public partial class FormFuncionarioCadMotorista : Form
    {
        public FormFuncionarioCadMotorista()
        {
            InitializeComponent();
        }

        private void btFuncCadMot_Click(object sender, EventArgs e)
        {
            GestaodeFrotaDTO objMotorista = new GestaodeFrotaDTO();
            objMotorista.MotoristaNome = txtFuncCadMotNome.Text;
            objMotorista.MotoristaTelefone = txtFuncCadMotCel.Text;
            objMotorista.MotoristaRG = txtFuncCadMotRG.Text;
            objMotorista.MotoristaCPF = txtFuncCadMotCPF.Text;
            objMotorista.MotoristaEndereco = txtFuncCadMotEnd.Text;
            objMotorista.MotoristaExameMedico = txtFuncCadMotExa.Text;
            objMotorista.MotoristaMOP = txtFuncCadMotMop.Text;
            objMotorista.MotoristaDTAdmicao = txtFuncCadMotDTA.Text;
            objMotorista.MotoristaCNH = txtFuncCadMotCNH.Text;

            GestaodeFrotaBLL.InserirMotorista(objMotorista);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFuncCadMotDTA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
