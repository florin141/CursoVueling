using ControlPlagas.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Services
{
    // ToDo Rename interface name
    public interface IServicioService
    {
        Servicio GetById(int servicioId);

        //float GetGastoEquipo();

        //float GetGastoEmpresa();

        //float GetIngreso();

        //IList<Cliente> GetClientes(int serviceId);

        //IList<Cliente> GetClientes(Servicio servicio);
    }
}
