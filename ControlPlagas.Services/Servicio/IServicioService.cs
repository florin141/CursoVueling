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

        void Insert(Servicio servicio);

        void Update(Servicio servicio);

        void Delete(Servicio servicio);
    }
}
