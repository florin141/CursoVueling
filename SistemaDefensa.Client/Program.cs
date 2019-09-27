using SistemaDefensa.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDefensa.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercito ejercito = new Ejercito();

            AbstractUnidadFactory caballeriaFactory = AbstractUnidadFactory.GetFactory(Division.Caballeria);
            AbstractUnidadFactory infanteriaFactory = AbstractUnidadFactory.GetFactory(Division.Infanteria);
            AbstractUnidadFactory artilleriaFactory = AbstractUnidadFactory.GetFactory(Division.Artilleria);

            ejercito.AddUnidad(caballeriaFactory.GetUnidad(SubDivision.Caballeria_TransporteMX7899));
            ejercito.AddUnidad(caballeriaFactory.GetUnidad(SubDivision.Caballeria_TanqueAtaqueSombrasVB98));
            ejercito.AddUnidad(caballeriaFactory.GetUnidad(SubDivision.Caballeria_TransporteTAXIN66));
            ejercito.AddUnidad(infanteriaFactory.GetUnidad(SubDivision.Infanteria_InfanteriaBasica));
            ejercito.AddUnidad(infanteriaFactory.GetUnidad(SubDivision.Infanteria_Ametrallador));
            ejercito.AddUnidad(infanteriaFactory.GetUnidad(SubDivision.Infanteria_Sanitario));
            ejercito.AddUnidad(artilleriaFactory.GetUnidad(SubDivision.Artilleria_CanonAntiaereo));
            ejercito.AddUnidad(artilleriaFactory.GetUnidad(SubDivision.Artilleria_TorpederoMovil));
            ejercito.AddUnidad(artilleriaFactory.GetUnidad(SubDivision.Artilleria_Canon));

            Console.WriteLine("Numero de Unidades: " + ejercito.CounterUnidades());
            Console.WriteLine("Potencia de Fuego Total: " + ejercito.PotenciaDeFuego());
            Console.WriteLine("Blindaje Total: " + ejercito.Blindaje());
            Console.WriteLine("Capacidad de Movimiento: " + ejercito.Movimiento());
            Console.WriteLine("Precio: " + ejercito.Precio());
            Console.WriteLine("Capacidad Militar: " + ejercito.CapacidadMilitar());

        }
    }
}
