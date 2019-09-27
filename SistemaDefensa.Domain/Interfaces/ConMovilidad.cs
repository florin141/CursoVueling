using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Domain
{
    public class ConMovilidad : IMovil
    {
        private double _velocidad;

        public ConMovilidad(double velocidad)
        {
            _velocidad = velocidad;
        }

        public double CapacidadDeMovimiento()
        {
            return _velocidad;
        }
    }
}
