using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Domain
{
    public enum Division
    {
        Caballeria,
        Infanteria,
        Artilleria
    }

    public enum SubDivision
    {
        Caballeria_TransporteMX7899,
        Caballeria_TanqueAtaqueSombrasVB98,
        Caballeria_TransporteTAXIN66,

        Infanteria_InfanteriaBasica,
        Infanteria_Ametrallador,
        Infanteria_Sanitario,

        Artilleria_CanonAntiaereo,
        Artilleria_TorpederoMovil,
        Artilleria_Canon
    }
}
