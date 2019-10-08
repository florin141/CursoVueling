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

        public float GetTotalFacturado(int clienteId)
        {
            return GetServicios(clienteId).Sum(s => s.Precio);
        }

        public float GetTotal(IClienteService clienteService)
        {
            return clienteService.GetAll().SelectMany(f => f.Facturas).Sum(p => p.Precio);
        }

        public IEnumerable<Servicio> GetServicios(Cliente cliente)
        {
            return GetServicios(cliente.Id);
        }

        public IEnumerable<Servicio> GetServicios(int clienteId)
        {
            if (clienteId == 0)
                return null;

            var query = _facturaRepository.Table
                .Where(c => c.Cliente.Id == clienteId)
                .SelectMany(s => s.Servicios);

            return query.ToList();
        }
    }
}
