using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStandAM__
{
    public partial class Aluguer
    {
        public Aluguer (string datainicio, string datafim, string valor, string kms)
        {
            DataInicio = datainicio;
            DataFim = datafim;
            Valor = valor;
            Kms = kms;
        }
    }
}
