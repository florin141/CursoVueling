using ControlPlagas.Core.Data;
using ControlPlagas.Core.Domain;
using System;

namespace ControlPlagas.Services
{
    public class RecursoService : IRecursoService
    {
        private readonly IRepository<Recurso> _recursoRepository;

        public RecursoService(IRepository<Recurso> recursoRepository)
        {
            _recursoRepository = recursoRepository;
        }

        public Recurso GetById(int recursoId)
        {
            if (recursoId == 0)
                return null;

            return _recursoRepository.GetById(recursoId);
        }

        public void Insert(Recurso recurso)
        {
            if (recurso == null)
                throw new ArgumentNullException(nameof(recurso));

            _recursoRepository.Insert(recurso);
        }

        public void Update(Recurso recurso)
        {
            if (recurso == null)
                throw new ArgumentNullException(nameof(recurso));

            _recursoRepository.Update(recurso);
        }

        public void Delete(Recurso recurso)
        {
            if (recurso == null)
                throw new ArgumentNullException(nameof(recurso));

            _recursoRepository.Delete(recurso);
        }
    }
}