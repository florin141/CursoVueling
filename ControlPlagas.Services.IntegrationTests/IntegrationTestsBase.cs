using Autofac;
using ControlPlagas.Core.Data;
using ControlPlagas.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Services.IntegrationTests
{
    public class IntegrationTestsBase
    {
        private IContainer _container;

        protected IContainer AutofacContainer
        {
            get
            {
                if (_container == null)
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

                    _container = builder.Build();
                }

                return _container;
            }
        }

        protected IClienteService ClienteService
        {
            get
            {
                return AutofacContainer.Resolve<IClienteService>();
            }
        }

        protected IFacturaService FacturaService
        {
            get
            {
                return AutofacContainer.Resolve<IFacturaService>();
            }
        }
    }
}
