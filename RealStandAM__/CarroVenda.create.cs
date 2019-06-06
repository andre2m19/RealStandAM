using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealStandAM__
{
    public partial class CarroVenda
    {
        public CarroVenda(string numerochassis, string marca, string modelo, string combustivel, string extras) : base(numerochassis, marca, modelo, combustivel)
        {
            Extras = extras;
        }
    }
}
