namespace SistemaDefensa.Domain
{
    public class ArtilleriaFactory : DivisionFactory
    {
        public override Unidad GetSubdivision(Subdivision subDivision)
        {
            switch (subDivision)
            {
                case Subdivision.Artilleria_CanonAntiaereo:
                    return new CanonAntiaereo();
                case Subdivision.Artilleria_TorpederoMovil:
                    return new TorpederoMovil();
                case Subdivision.Artilleria_Canon:
                    return new Canon();
                default:
                    return null;
            }
        }
    }
}