using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Core.Domain
{
    public class Veneno : Recurso
    {
        public virtual Plaga Plaga { get; set; }
        public string Unidad { get; set; }
    }
}
