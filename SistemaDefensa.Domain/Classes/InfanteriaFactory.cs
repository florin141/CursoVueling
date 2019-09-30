namespace SistemaDefensa.Domain
{
    public class InfanteriaFactory : DivisionFactory
    {
        public override Unidad GetSubdivision(Subdivision subDivision)
        {
            switch (subDivision)
            {
                case Subdivision.Infanteria_InfanteriaBasica:
                    return new InfanteriaBasica();
                case Subdivision.Infanteria_Ametrallador:
                    return new Ametrallador();
                case Subdivision.Infanteria_Sanitario:
                    return new Sanitario();
                default:
                    return Unidad.Null;
            }
        }
    }
}