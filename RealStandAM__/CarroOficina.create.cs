using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStandAM__
{
    public partial class CarroOficina 
    {
      public CarroOficina  (string numerochassis, string marca, string modelo, string combustivel, string matricula, string kms):base(numerochassis, marca, modelo, combustivel)
        {
            Matricula = matricula;
            Kms = kms;
        }
    }
}
