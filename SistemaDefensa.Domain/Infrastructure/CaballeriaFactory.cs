namespace SistemaDefensa.Domain
{
    internal class CaballeriaFactory : AbstractUnidadFactory
    {
        public override Unidad GetUnidad(SubDivision caballeria)
        {
            switch (caballeria)
            {
                case SubDivision.Caballeria_TransporteMX7899:
                    return new TransporteMX7899();
                case SubDivision.Caballeria_TanqueAtaqueSombrasVB98:
                    return new TanqueAtaqueSombrasVB98();
                case SubDivision.Caballeria_TransporteTAXIN66:
                    return new TransporteTAXIN66();
                default:
                    return null;
            }
        }
    }
}