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
            Facturas = new HashSet<Factura>();
        }

        public string NombreServicio { get; set; }
        public virtual ICollection<Trabajador> Trabajadores { get; private set; }
        public virtual ICollection<Recurso> Recursos { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
        public int Precio { get; set; }

        public void SetTrabajadores(Trabajador jefe, params Trabajador[] peones)
        {
            Trabajadores.Add(jefe);

            foreach (var peon in peones)
                Trabajadores.Add(peon);
        }
    }
}
