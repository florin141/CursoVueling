using ControlPlagas.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Services
{
    public interface ITrabajadorService
    {
        Trabajador GetById(int trabajadorId);

        void Insert(Trabajador trabajador);

        void Update(Trabajador trabajador);

        void Delete(Trabajador trabajador);
    }
}
