using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaDefensa.Domain
{
    public class Ametrallador : Unidad, IInfanteria
    {
        public Ametrallador()
        {
            Nombre = "Ametrallador";
            Precio = 400;
            SetMovilidad(new ConMovilidad(4));
            SetBlindaje(new SinBlindaje());
            SetDestructor(new ConFuego(10));
        }
    }
}