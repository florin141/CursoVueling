using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Core.Domain
{
    public class Cliente : BaseEntity
    {
        public Cliente()
        {
            Facturas = new HashSet<Factura>();
        }

        public string NombreCompleto { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string Direccion { get; set; }
        public string CodicoPostal { get; set; }

        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
