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

            var clientRepo = Container.Resolve<IRepository<Cliente>>();

            clientRepo.Insert(new List<Cliente>
            {
                //new Cliente
                //{
                //    NombreCompleto = "Florin Ciobanu", CorreoElectronico = "cflorin@hiberus.com",
                //    Telefono = "643447860", Direccion = "Zaragoza, Spain", CodicoPostal = "50009"
                //},
                new Cliente
                {
                    NombreCompleto = "Duis Dorado", CorreoElectronico = "dluis@hiberus.com",
                    Telefono = "643447860", Direccion = "Zaragoza, Spain", CodicoPostal = "50010"
                },
                new Cliente
                {
                    NombreCompleto = "Ana Marin", CorreoElectronico = "mana@hiberus.com",
                    Telefono = "643447860", Direccion = "Zaragoza, Spain", CodicoPostal = "50010"
                }
            });
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
