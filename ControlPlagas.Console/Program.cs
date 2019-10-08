using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using ControlPlagas.Core.Data;
using ControlPlagas.Core.Domain;
using ControlPlagas.Data;
using ControlPlagas.Services;

namespace ControlPlagas.Console
{
    class Program
    {
        static IContainer Container;

        static void Main(string[] args)
        {
            ConfigureContainer();

            System.Console.WriteLine("Creating the database...");

            System.Console.WriteLine("Inserting sample clients...");

            Seed.AddClients(Container.Resolve<IRepository<Cliente>>());

            System.Console.WriteLine("Inserting sample services...");

            Seed.AddServicios(Container.Resolve<IRepository<Servicio>>());

            System.Console.WriteLine("Complete!");
        }

        private static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.Register<DbContext>(ctx => new ControlPlagasObjectContext()).SingleInstance();

            builder.RegisterGeneric(typeof(ControlPlagasRepository<>)).As(typeof(IRepository<>)).SingleInstance();

            builder.RegisterType<ClienteService>().As<IClienteService>().InstancePerDependency();
            builder.RegisterType<FacturaService>().As<IFacturaService>().InstancePerDependency();
            builder.RegisterType<PlagaService>().As<IPlagaService>().InstancePerDependency();
            builder.RegisterType<TrabajadorService>().As<ITrabajadorService>().InstancePerDependency();

            builder.RegisterType<RecursoService>().As<IRecursoService>().InstancePerDependency();
            builder.RegisterType<ServicioService>().As<IServicioService>().InstancePerDependency();

            Container = builder.Build();
        }
    }
}
