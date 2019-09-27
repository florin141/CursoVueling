using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaDefensa.Domain
{
    public abstract class AbstractUnidadFactory
    {
        public static AbstractUnidadFactory GetFactory(Division division)
        {
            switch (division)
            {
                case Division.Caballeria:
                    return new CaballeriaFactory();
                case Division.Infanteria:
                    return new InfanteriaFactory();
                case Division.Artilleria:
                    return new ArtilleriaFactory();
                default:
                    return null;
            }
        }

        abstract public Unidad GetUnidad(SubDivision subDivision);
    }
}