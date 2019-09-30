using SistemaDefensa.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Tests
{
    public class FakeUnidades
    {
        private static DivisionFactory _caballeriaFactory = DivisionFactory.GetDivision(Division.Caballeria);
        private static DivisionFactory _infanteriaFactory = DivisionFactory.GetDivision(Division.Infanteria);
        private static DivisionFactory _artilleriaFactory = DivisionFactory.GetDivision(Division.Artilleria);

        ICalculable defaultCalc = new DefaultCalculable();

        public static Unidad GetTransporterMX7899()
        {
            return _caballeriaFactory.GetSubdivision(Subdivision.Caballeria_TransporteMX7899);
        }

        public static Unidad GetTanqueAtaqueSombrasVB98()
        {
            return _caballeriaFactory.GetSubdivision(Subdivision.Caballeria_TanqueAtaqueSombrasVB98);
        }

        public static Unidad GetTransporteTAXIN66()
        {
            return _caballeriaFactory.GetSubdivision(Subdivision.Caballeria_TransporteTAXIN66);
        }

        public static Unidad GetInfanteriaBasica()
        {
            return _infanteriaFactory.GetSubdivision(Subdivision.Infanteria_InfanteriaBasica);
        }

        public static Unidad GetAmetrallador()
        {
            return _infanteriaFactory.GetSubdivision(Subdivision.Infanteria_Ametrallador);
        }

        public static Unidad GetSanitario()
        {
            return _infanteriaFactory.GetSubdivision(Subdivision.Infanteria_Sanitario);
        }

        public static Unidad GetCanonAntiaereo()
        {
            return _artilleriaFactory.GetSubdivision(Subdivision.Artilleria_CanonAntiaereo);
        }

        public static Unidad GetTorpederoMovil()
        {
            return _artilleriaFactory.GetSubdivision(Subdivision.Artilleria_TorpederoMovil);
        }

        public static Unidad GetCanon()
        {
            return _artilleriaFactory.GetSubdivision(Subdivision.Artilleria_Canon);
        }
    }
}
