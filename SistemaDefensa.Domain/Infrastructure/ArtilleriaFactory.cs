namespace SistemaDefensa.Domain
{
    internal class ArtilleriaFactory : AbstractUnidadFactory
    {
        public override Unidad GetUnidad(string name)
        {
            if (name == "CanonAntiaereo")
            {
                return new CanonAntiaereo();
            }
            else if (name == "TorpederoMovil")
            {
                return new TorpederoMovil();
            }
            else if (name == "Canon")
            {
                return new Canon();
            }
            else
            {
                return null;
            }
        }
    }
}