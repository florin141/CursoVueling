using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlPlagas.Core.Data;
using ControlPlagas.Core.Domain;

namespace ControlPlagas.Services
{
    public class TrabajadorService : ITrabajadorService
    {
        private readonly IRepository<Trabajador> _trabajadorRepository;

        public TrabajadorService(IRepository<Trabajador> trabajadorRepository)
        {
            _trabajadorRepository = trabajadorRepository;
        }

        public Trabajador GetById(int trabajadorId)
        {
            if (trabajadorId == 0)
                return null;

            return _trabajadorRepository.GetById(trabajadorId);
        }

        public void Insert(Trabajador trabajador)
        {
            if (trabajador == null)
                throw new ArgumentNullException(nameof(trabajador));

            _trabajadorRepository.Insert(trabajador);
        }

        public void Update(Trabajador trabajador)
        {
            if (trabajador == null)
                throw new ArgumentNullException(nameof(trabajador));

            _trabajadorRepository.Update(trabajador);
        }

        public void Delete(Trabajador trabajador)
        {
            if (trabajador == null)
                throw new ArgumentNullException(nameof(trabajador));

            _trabajadorRepository.Delete(trabajador);
        }
    }
}
