using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Core.Domain
{
    public class Recurso : BaseEntity
    {
        public Recurso()
        {
            Servicios = new HashSet<Servicio>();
        }

        public string NombreRecurso { get; set; }
        public float Coste { get; set; }
        public ICollection<Servicio> Servicios { get; set; }
    }
}
