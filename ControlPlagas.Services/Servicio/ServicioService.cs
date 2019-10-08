using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlPlagas.Core.Data;
using ControlPlagas.Core.Domain;
using ControlPlagas.Core.Exceptions;
using ControlPlagas.Core.Specifications;

namespace ControlPlagas.Services
{
    public class ServicioService : IServicioService
    {
        private ICollection<Trabajador> trabajadores;
        private readonly IRepository<Servicio> _servicioRepository;

        public ServicioService(IRepository<Servicio> servicioRepository)
        {
            trabajadores = new List<Trabajador>();
            _servicioRepository = servicioRepository;
        }

        public Servicio GetById(int servicioId)
        {
            if (servicioId == 0)
                return null;

            return _servicioRepository.GetById(servicioId);
        }

        public void Insert(Servicio servicio)
        {
            if (servicio == null)
                throw new ArgumentNullException(nameof(servicio));

            var peonesSpec = new PeonesMaximoSpecification();

            if (!peonesSpec.IsSatisfiedBy(servicio))
                throw new TrabajadoresOutOfRangeException();

            _servicioRepository.Insert(servicio);
        }

        public void Update(Servicio servicio)
        {
            if (servicio == null)
                throw new ArgumentNullException(nameof(servicio));

            _servicioRepository.Update(servicio);
        }

        public void Delete(Servicio servicio)
        {
            if (servicio == null)
                throw new ArgumentNullException(nameof(servicio));

            _servicioRepository.Delete(servicio);
        }
    }
}
