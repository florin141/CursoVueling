using ControlPlagas.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Services
{
    public interface IRecursoService
    {
        Recurso GetById(int recursoId);

        void Insert(Recurso recurso);

        void Update(Recurso recurso);

        void Delete(Recurso recurso);
    }
}
