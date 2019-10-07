using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlPlagas.Core.Data;
using ControlPlagas.Core.Domain;

namespace ControlPlagas.Services
{
    public class ServicioService : IServicioService
    {
        private readonly IRepository<Servicio> _servicioRepository;

        public ServicioService(IRepository<Servicio> servicioRepository)
        {
            _servicioRepository = servicioRepository;
        }

        public Servicio GetById(int servicioId)
        {
            if (servicioId == 0)
                return null;

            return _servicioRepository.GetById(servicioId);
        }
    }
}
