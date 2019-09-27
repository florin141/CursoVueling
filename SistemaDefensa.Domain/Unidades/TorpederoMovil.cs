namespace SistemaDefensa.Domain
{
    public class TorpederoMovil : Unidad, IArilleria
    {
        public TorpederoMovil()
        {
            Nombre = "TorpederoMovil";
            Precio = 1350;
            SetMovilidad(new ConMovilidad(3));
            SetBlindaje(new ConBlindaje(2));
            SetDestructor(new ConFuego(19));
        }
    }
}