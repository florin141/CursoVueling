using System;

namespace SistemaDefensa.Domain
{
    public class TransporteMX7899 : Unidad, ICaballeria
    {
        public TransporteMX7899()
        {
            Nombre = "Transporte MX7 899";
            Precio = 4200;
            SetMovilidad(new ConMovilidad(4.5));
            SetBlindaje(new ConBlindaje(1.4));
            SetDestructor(new SinFuego());
        }
    }
}