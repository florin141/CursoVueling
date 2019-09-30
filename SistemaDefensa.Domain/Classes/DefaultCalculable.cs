using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Domain
{
    public class DefaultCalculable : ICalculable
    {
        public double CapacidadMilitar(double pf, double cm, double bl)
        {
            return ((pf * cm) / 2.0) / (100.0 - bl);
        }
    }
}
