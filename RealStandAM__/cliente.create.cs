using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStandAM__
{
    public partial class Cliente
    {
        public Cliente(string nome, string morada, string contacto, string nif)
        {
            Nome = nome;
            Morada = morada;
            Contacto = contacto;
            Nif = nif;
            this.CarroOficina = new HashSet<CarroOficina>();
        }

        public override string ToString()
        {
            return Nome + "(" + Nif + ")";
        }

    }
}
