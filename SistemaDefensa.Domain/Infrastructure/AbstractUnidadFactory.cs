using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaDefensa.Domain
{
    public abstract class AbstractUnidadFactory
    {
        public static AbstractUnidadFactory GetFactory(string name)
        {
            if (name == "caballeria")
            {
                return new CaballeriaFactory();
            }
            else if (name == "infanteria")
            {
                return new InfanteriaFactory();
            }
            else if (name == "artilleria")
            {
                return new ArtilleriaFactory();
            }
            else
            {
                return null;
            }
        }

        abstract public Unidad GetUnidad(string name);
    }
}