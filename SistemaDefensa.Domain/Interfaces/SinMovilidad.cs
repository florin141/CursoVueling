using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Domain
{
    public class SinMovilidad : IMovil
    {
        public double CapacidadDeMovimiento()
        {
            return 1.0;
        }
    }
}
