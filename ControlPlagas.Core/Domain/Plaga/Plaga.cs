using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Core.Domain
{
    public class Plaga : BaseEntity
    {
        public string NombreComun { get; set; }
        public string Descripcion { get; set; }
    }
}
