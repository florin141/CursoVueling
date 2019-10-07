using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlPlagas.Core.Domain;

namespace ControlPlagas.Services
{
    public interface IPlagaService
    {
        Plaga GetById(int plagaId);

        void Insert(Plaga plaga);

        void Update(Plaga plaga);

        void Delete(Plaga plaga);
    }
}
