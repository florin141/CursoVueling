using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlPlagas.Core.Data;
using ControlPlagas.Core.Domain;

namespace ControlPlagas.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IRepository<Cliente> _clienteRepository;

        public ClienteService(
            IRepository<Cliente> clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Cliente GetById(int clienteId)
        {
            if (clienteId == 0)
                return null;

            return _clienteRepository.GetById(clienteId);
        }

        public IList<Cliente> GetClientes()
        {
            var query = _clienteRepository.Table;

            return query.ToArray();
        }

        public void Insert(Cliente cliente)
        {
            if (cliente == null)
                throw new ArgumentNullException(nameof(cliente));

            _clienteRepository.Insert(cliente);
        }

        public void Update(Cliente cliente)
        {
            if (cliente == null)
                throw new ArgumentNullException(nameof(cliente));

            _clienteRepository.Update(cliente);
        }

        public void Delete(Cliente cliente)
        {
            if (cliente == null)
                throw new ArgumentNullException(nameof(cliente));

            _clienteRepository.Delete(cliente);
        }
    }
}
