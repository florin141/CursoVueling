using Autofac;
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
        static IContainer Container;

        static void Main(string[] args)
        {
            ConfigureContainer();

            var calc = Container.Resolve<ICalculable>();
            Ejercito ejercito = new Ejercito(calc);

            DivisionFactory caballeriaFactory = DivisionFactory.GetDivision(Division.Caballeria);
            DivisionFactory infanteriaFactory = DivisionFactory.GetDivision(Division.Infanteria);
            DivisionFactory artilleriaFactory = DivisionFactory.GetDivision(Division.Artilleria);

            ejercito.AddUnidad(caballeriaFactory.GetSubdivision(Subdivision.Caballeria_TransporteMX7899));
            ejercito.AddUnidad(caballeriaFactory.GetSubdivision(Subdivision.Caballeria_TanqueAtaqueSombrasVB98));
            ejercito.AddUnidad(caballeriaFactory.GetSubdivision(Subdivision.Caballeria_TransporteTAXIN66));
            ejercito.AddUnidad(infanteriaFactory.GetSubdivision(Subdivision.Infanteria_InfanteriaBasica));
            ejercito.AddUnidad(infanteriaFactory.GetSubdivision(Subdivision.Infanteria_Ametrallador));
            ejercito.AddUnidad(infanteriaFactory.GetSubdivision(Subdivision.Infanteria_Sanitario));
            ejercito.AddUnidad(artilleriaFactory.GetSubdivision(Subdivision.Artilleria_CanonAntiaereo));
            ejercito.AddUnidad(artilleriaFactory.GetSubdivision(Subdivision.Artilleria_TorpederoMovil));
            ejercito.AddUnidad(artilleriaFactory.GetSubdivision(Subdivision.Artilleria_Canon));

            Console.WriteLine("Numero de Unidades: " + ejercito.CounterUnidades());
            Console.WriteLine("Potencia de Fuego Total: " + ejercito.PotenciaDeFuego());
            Console.WriteLine("Blindaje Total: " + ejercito.Blindaje());
            Console.WriteLine("Capacidad de Movimiento: " + ejercito.Movimiento());
            Console.WriteLine("Precio: " + ejercito.Precio());
            Console.WriteLine("Capacidad Militar: " + ejercito.CapacidadMilitar());

        }

        static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Calculabe>().As<ICalculable>().InstancePerDependency();

            Container = builder.Build();
        }
    }
}
