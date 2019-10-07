using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Core.Domain
{
    public class Factura : BaseEntity
    {
        public Factura()
        {
            Servicios = new HashSet<Servicio>();
        }

        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<Servicio> Servicios { get; set; }
    }
}
