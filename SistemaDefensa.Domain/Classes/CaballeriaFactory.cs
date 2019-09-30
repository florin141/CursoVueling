namespace SistemaDefensa.Domain
{
    public class CaballeriaFactory : DivisionFactory
    {
        public override Unidad GetSubdivision(Subdivision caballeria)
        {
            switch (caballeria)
            {
                case Subdivision.Caballeria_TransporteMX7899:
                    return new TransporteMX7899();
                case Subdivision.Caballeria_TanqueAtaqueSombrasVB98:
                    return new TanqueAtaqueSombrasVB98();
                case Subdivision.Caballeria_TransporteTAXIN66:
                    return new TransporteTAXIN66();
                default:
                    return Unidad.Null;
            }
        }
    }
}