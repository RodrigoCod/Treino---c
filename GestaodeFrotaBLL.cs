using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaodeFrotas.DAL;
using GestaodeFrota.DTO;

namespace GestaodeFrota.BLL
{
   public class GestaodeFrotaBLL
    {
        public static void InserirMotorista(GestaodeFrotaDTO objMotorista)
        {
            GestaodeFrotaDAL.InserirMotorista(objMotorista);
        }
    }
}
