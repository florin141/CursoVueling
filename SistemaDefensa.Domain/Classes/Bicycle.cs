using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Domain
{
    public class Bicycle : IMovil
    {
        public double CapacidadDeMovimiento()
        {
            return 10;
        }
    }
}
