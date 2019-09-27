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

            AbstractUnidadFactory caballeriaFactory = AbstractUnidadFactory.GetFactory("caballeria");
            AbstractUnidadFactory infanteriaFactory = AbstractUnidadFactory.GetFactory("infanteria");
            AbstractUnidadFactory artilleriaFactory = AbstractUnidadFactory.GetFactory("artilleria");

            ejercito.AddUnidad(caballeriaFactory.GetUnidad("TransporteMX7899"));
            ejercito.AddUnidad(caballeriaFactory.GetUnidad("TanqueAtaqueSombrasVB98"));
            ejercito.AddUnidad(caballeriaFactory.GetUnidad("TransporteTAXIN66"));

            ejercito.AddUnidad(infanteriaFactory.GetUnidad("InfanteriaBasica"));
            ejercito.AddUnidad(infanteriaFactory.GetUnidad("Ametrallador"));
            ejercito.AddUnidad(infanteriaFactory.GetUnidad("Sanitario"));

            ejercito.AddUnidad(artilleriaFactory.GetUnidad("CanonAntiaereo"));
            ejercito.AddUnidad(artilleriaFactory.GetUnidad("TorpederoMovil"));
            ejercito.AddUnidad(artilleriaFactory.GetUnidad("Canon"));

            Console.WriteLine("Numero de Unidades: " + ejercito.CounterUnidades());
            Console.WriteLine("Potencia de Fuego Total: " + ejercito.PotenciaDeFuego());
            Console.WriteLine("Blindaje Total: " + ejercito.Blindaje());
            Console.WriteLine("Capacidad de Movimiento: " + ejercito.Movimiento());
            Console.WriteLine("Precio: " + ejercito.Precio());
            Console.WriteLine("Capacidad Militar: " + ejercito.CapacidadMilitar());

        }
    }
}
