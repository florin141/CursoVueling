using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Core.Domain
{
    public class Trabajador : BaseEntity
    {
        public Trabajador()
        {
            Servicios = new HashSet<Servicio>();
        }

        public string NombreCompleto { get; set; }
        public Categoria Categoria { get; set; }
        public double Salario { get; set; }
        public virtual ICollection<Servicio> Servicios { get; set; }
    }
}
