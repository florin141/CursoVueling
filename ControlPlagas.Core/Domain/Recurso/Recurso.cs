using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Core.Domain
{
    public class Recurso : BaseEntity
    {
        public string NombreRecurso { get; set; }
        public float Coste { get; set; }
    }
}
