using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ControlPlagas.Core.Domain;

namespace ControlPlagas.Core.Specifications
{
    public sealed class PeonesMaximoSpecification : Specification<Servicio>
    {
        private readonly int _numeroPeones;

        public PeonesMaximoSpecification(int numeroPeones = 3)
        {
            _numeroPeones = numeroPeones;
        }

        public override Expression<Func<Servicio, bool>> ToExpression()
        {
            return servicio => servicio.Trabajadores.Count <= _numeroPeones;
        }
    }
}
