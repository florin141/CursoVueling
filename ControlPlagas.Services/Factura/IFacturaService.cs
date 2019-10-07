using ControlPlagas.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Services
{
    public interface IFacturaService
    {
        Factura GetById(int facturaId);

        void Insert(Factura factura);

        void Delete(Factura factura);

        float GetTotal();
    }
}
