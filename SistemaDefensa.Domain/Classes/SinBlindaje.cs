using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Domain
{
    public class SinBlindaje : IBlindado
    {
        public double ResistenciaAlAtaque()
        {
            return 0.0;
        }
    }
}
