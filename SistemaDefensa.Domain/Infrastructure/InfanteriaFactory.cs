namespace SistemaDefensa.Domain
{
    internal class InfanteriaFactory : AbstractUnidadFactory
    {
        public override Unidad GetUnidad(SubDivision subDivision)
        {
            switch (subDivision)
            {
                case SubDivision.Infanteria_InfanteriaBasica:
                    return new InfanteriaBasica();
                case SubDivision.Infanteria_Ametrallador:
                    return new Ametrallador();
                case SubDivision.Infanteria_Sanitario:
                    return new Sanitario();
                default:
                    return null;
            }
        }
    }
}