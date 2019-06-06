using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStandAM__
{
    public partial class Servico
    {
        public Servico(object p)
        {
        }

        public Servico(string dataentrada, string datasaida, string tipo)
        {
            DataEntrada = dataentrada;
            DataSaida = datasaida;
            Tipo = tipo;
        }

        public override string ToString()
        {
            return Tipo;
        }
    }
}
