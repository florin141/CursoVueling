using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaDefensa.Domain
{
    public abstract class DivisionFactory
    {
        public static DivisionFactory GetDivision(Division division)
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

        abstract public Unidad GetSubdivision(Subdivision subdivision);
    }
}