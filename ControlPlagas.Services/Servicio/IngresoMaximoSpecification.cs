using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Core.Domain
{
    public sealed class IngresoMaximoSpecification : Specification<Servicio>
    {
        private readonly int _ingresoMaximo;

        public IngresoMaximoSpecification(int ingresoMaximo = 50)
        {
            this._ingresoMaximo = ingresoMaximo;
        }

        public override Expression<Func<Servicio, bool>> ToExpression()
        {
            return servicio => servicio.Precio <= _ingresoMaximo;
        }
    }
}
