using ControlPlagas.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Services
{
    public interface IClienteService
    {
        Cliente GetById(int clienteId);

        void Insert(Cliente cliente);

        void Update(Cliente cliente);

        void Delete(Cliente cliente);

        IEnumerable<Cliente> GetAll();
    }
}
