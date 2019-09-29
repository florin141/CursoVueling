namespace SistemaDefensa.Domain
{
    public class InfanteriaBasica : Unidad, IInfanteria
    {
        public InfanteriaBasica()
        {
            Nombre = "InfanteriaBasica";
            Precio = 250;
            SetMovilidad(new ConMovilidad(6));
            SetBlindaje(new SinBlindaje());
            SetDestructor(new ConFuego(7));
        }
    }
}