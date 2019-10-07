using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Core.Domain
{
    public class Servicio : BaseEntity
    {
        public Servicio()
        {
            Trabajadores = new HashSet<Trabajador>();
            Recursos = new HashSet<Recurso>();
        }

        public string NombreServicio { get; set; }
        public virtual ICollection<Trabajador> Trabajadores { get; set; }
        public virtual ICollection<Recurso> Recursos { get; set; }
        public int Precio { get; set; }
        public virtual Factura Factura { get; set; }
    }
}
