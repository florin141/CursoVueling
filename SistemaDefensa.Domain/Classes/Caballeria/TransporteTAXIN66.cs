namespace SistemaDefensa.Domain
{
    public class TransporteTAXIN66 : Unidad, ICaballeria
    {
        public TransporteTAXIN66()
        {
            Nombre = "TransporteTAXIN66";
            Precio = 1600;
            SetMovilidad(new ConMovilidad(12));
            SetBlindaje(new SinBlindaje());
            SetDestructor(new SinFuego());
        }
    }
}
