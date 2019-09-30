using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Domain
{
    public class Shield : IBlindado
    {
        public double ResistenciaAlAtaque()
        {
            return 100;
        }
    }
}
