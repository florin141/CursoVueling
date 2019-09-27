namespace SistemaDefensa.Domain
{
    public class CanonAntiaereo : Unidad, IArilleria
    {
        public CanonAntiaereo()
        {
            Nombre = "CanonAntiaereo";
            Precio = 1100;
            SetMovilidad(new ConMovilidad(1));
            SetBlindaje(new SinBlindaje());
            SetDestructor(new ConFuego(22));
        }
    }
}