using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStandAM__
{
    public partial class CarroAluguer
    {
        public CarroAluguer (string numerochassis, string marca, string modelo, string combustivel, string estado, string matricula):base(numerochassis, marca, modelo, combustivel)
        {
            Estado = estado;
            Matricula = matricula;
        }
    }
}
