namespace SistemaDefensa.Domain
{
    internal class ArtilleriaFactory : AbstractUnidadFactory
    {
        public override Unidad GetUnidad(SubDivision subDivision)
        {
            switch (subDivision)
            {
                case SubDivision.Artilleria_CanonAntiaereo:
                    return new CanonAntiaereo();
                case SubDivision.Artilleria_TorpederoMovil:
                    return new TorpederoMovil();
                case SubDivision.Artilleria_Canon:
                    return new Canon();
                default:
                    return null;
            }
        }
    }
}