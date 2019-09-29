using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Domain
{
    public class ConBlindaje : IBlindado
    {
        private double _blindaje;

        public ConBlindaje(double blindaje)
        {
            _blindaje = blindaje;
        }

        public double ResistenciaAlAtaque()
        {
            return _blindaje;
        }
    }
}
