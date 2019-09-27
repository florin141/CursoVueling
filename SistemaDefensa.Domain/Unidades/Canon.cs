using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Domain
{
    public class Canon : Unidad, IArilleria
    {
        public Canon()
        {
            Nombre = "Canon";
            Precio = 1100;
            SetMovilidad(new SinMovilidad());
            SetBlindaje(new SinBlindaje());
            SetDestructor(new ConFuego(14));
        }
    }
}
