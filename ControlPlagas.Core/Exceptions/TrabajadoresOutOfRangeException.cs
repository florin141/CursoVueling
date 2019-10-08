using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Core.Exceptions
{
    public class TrabajadoresOutOfRangeException : Exception
    {
        public TrabajadoresOutOfRangeException() 
            : base("No puedes tener mas de 3 peones")
        {
            
        }
    }
}
