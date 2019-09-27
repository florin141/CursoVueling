namespace SistemaDefensa.Domain
{
    internal class InfanteriaFactory : AbstractUnidadFactory
    {
        public override Unidad GetUnidad(string name)
        {
            if (name == "InfanteriaBasica")
            {
                return new InfanteriaBasica();
            }
            else if (name == "Ametrallador")
            {
                return new Ametrallador();
            }
            else if (name == "Sanitario")
            {
                return new Sanitario();
            }
            else
            {
                return null;
            }
        }
    }
}