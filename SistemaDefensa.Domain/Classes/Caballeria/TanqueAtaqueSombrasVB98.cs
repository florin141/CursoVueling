namespace SistemaDefensa.Domain
{
    public class TanqueAtaqueSombrasVB98 : Unidad, ICaballeria
    {
        public TanqueAtaqueSombrasVB98()
        {
            Nombre = "Tanque Ataque Sombras-VB98";
            Precio = 15600;
            SetMovilidad(new ConMovilidad(7.3));
            SetBlindaje(new ConBlindaje(4.8));
            SetDestructor(new ConFuego(9.8));
        }
    }
}