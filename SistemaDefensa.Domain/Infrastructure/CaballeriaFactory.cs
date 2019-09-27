namespace SistemaDefensa.Domain
{
    internal class CaballeriaFactory : AbstractUnidadFactory
    {
        public override Unidad GetUnidad(string name)
        {
            if (name == "TransporteMX7899")
            {
                return new TransporteMX7899();
            }
            else if (name == "TanqueAtaqueSombrasVB98")
            {
                return new TanqueAtaqueSombrasVB98();
            }
            else if (name == "TransporteTAXIN66")
            {
                return new TransporteTAXIN66();
            }
            else
            {
                return null;
            }
        }
    }
}