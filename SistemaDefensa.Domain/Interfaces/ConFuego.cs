using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Domain
{
    public class ConFuego : IDestructor
    {
        private double _fuego;

        public ConFuego(double fuego)
        {
            _fuego = fuego;
        }

        public double CapacidadDeDestruccion()
        {
            return _fuego;
        }
    }
}
