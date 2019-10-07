using ControlPlagas.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlPlagas.Core.Data;

namespace ControlPlagas.Services
{
    public class PlagaService : IPlagaService
    {
        private readonly IRepository<Plaga> _plagaRepository;

        public PlagaService(IRepository<Plaga> plagaRepository)
        {
            _plagaRepository = plagaRepository;
        }

        public Plaga GetById(int plagaId)
        {
            if (plagaId == 0)
                return null;

            return _plagaRepository.GetById(plagaId);
        }

        public void Insert(Plaga plaga)
        {
            if (plaga == null)
                throw new ArgumentNullException(nameof(plaga));

            _plagaRepository.Insert(plaga);
        }

        public void Update(Plaga plaga)
        {
            if (plaga == null)
                throw new ArgumentNullException(nameof(plaga));

            _plagaRepository.Update(plaga);
        }

        public void Delete(Plaga plaga)
        {
            if (plaga == null)
                throw new ArgumentNullException(nameof(plaga));

            _plagaRepository.Delete(plaga);
        }
    }
}
