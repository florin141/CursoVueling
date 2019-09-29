namespace SistemaDefensa.Domain
{
    public class Sanitario : Unidad, IInfanteria
    {
        public Sanitario()
        {
            Nombre = "Sanitario";
            Precio = 500;
            SetMovilidad(new ConMovilidad(7));
            SetBlindaje(new ConBlindaje(5));
            SetDestructor(new SinFuego());
        }
    }
}