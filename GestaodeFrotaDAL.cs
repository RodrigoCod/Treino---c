using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaodeFrota.DTO;
using System.Data.SqlClient;
using System.Data;


namespace GestaodeFrotas.DAL
{
    public class GestaodeFrotaDAL
    {
        public static void InserirMotorista(GestaodeFrotaDTO objMotorista)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = GestaodeFrotas.DAL.Properties.Settings.Default.GestaodeFrotas;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "INSERT into tb_Cad_Motorista1(Nome, Celular, RG, CPF, CNH, DataAdmicao, ExameMedico, Endereco, MOP) VALUES (@MotoristaNome, @MotoristaTelefone, @MotoristaRG, @MotoristaCPF, @MotoristaCNH, @MotoristaDTAdmicao, @MotoristaExameMedico, @MotoristaEndereco, @MotoristaMOP)";
            Comando.Parameters.Add("@MotoristaNome", SqlDbType.VarChar).Value = objMotorista.MotoristaNome;
            Comando.Parameters.Add("@MotoristaTelefone", SqlDbType.VarChar).Value = objMotorista.MotoristaTelefone;
            Comando.Parameters.Add("@MotoristaRG", SqlDbType.VarChar).Value = objMotorista.MotoristaRG;
            Comando.Parameters.Add("@MotoristaCPF", SqlDbType.VarChar).Value = objMotorista.MotoristaCPF;
            Comando.Parameters.Add("@MotoristaCNH", SqlDbType.VarChar).Value = objMotorista.MotoristaCNH;
            Comando.Parameters.Add("@MotoristaDTAdmicao", SqlDbType.VarChar).Value = objMotorista.MotoristaDTAdmicao;
            Comando.Parameters.Add("@MotoristaExameMedico", SqlDbType.VarChar).Value = objMotorista.MotoristaExameMedico;
            Comando.Parameters.Add("@MotoristaEndereco", SqlDbType.VarChar).Value = objMotorista.MotoristaEndereco;
            Comando.Parameters.Add("@MotoristaMOP", SqlDbType.VarChar).Value = objMotorista.MotoristaMOP;

 
            

            Conexao.Open();
            Comando.ExecuteNonQuery();
        }
    }
}
