using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlPlagas.Core.Data;
using ControlPlagas.Core.Domain;

namespace ControlPlagas.Services
{
    public class FacturaService : IFacturaService
    {
        private readonly IRepository<Factura> _facturaRepository;

        public FacturaService(IRepository<Factura> facturaRepository)
        {
            _facturaRepository = facturaRepository;
        }

        public Factura GetById(int facturaId)
        {
            if (facturaId == 0)
                return null;

            return _facturaRepository.GetById(facturaId);
        }

        public void Insert(Factura factura)
        {
            if (factura == null)
                throw new ArgumentNullException(nameof(factura));

            _facturaRepository.Insert(factura);
        }

        public void Delete(Factura factura)
        {
            if (factura == null)
                throw new ArgumentNullException(nameof(factura));

            _facturaRepository.Delete(factura);
        }

        public float GetTotal()
        {
            throw new NotImplementedException();
        }

        public IList<Servicio> GetServicios(Cliente cliente)
        {
            if (cliente == null)
                return null;

            var query = _facturaRepository.Table
                .Where(c => c.Cliente == cliente)
                .SelectMany(s => s.Servicios);

            return query.ToList();
        }

        public IList<Servicio> GetServicios(int clienteId)
        {
            if (clienteId == 0)
                return null;

            var query = _facturaRepository.Table
                .Where(c => c.Cliente.Id == clienteId)
                .SelectMany(s => s.Servicios);

            return query.ToList();
        }

        public IList<Cliente> GetClientes(int serviceId)
        {
            throw new NotImplementedException();
        }

        public IList<Cliente> GetClientes(Servicio servicio)
        {
            throw new NotImplementedException();
        }
    }
}
