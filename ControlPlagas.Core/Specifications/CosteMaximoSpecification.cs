using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ControlPlagas.Core.Domain;

namespace ControlPlagas.Core.Specifications
{
    public sealed class CosteMaximoSpecification : Specification<Veneno>
    {
        private readonly float _costeMaximo;

        public CosteMaximoSpecification(float costeMaximo)
        {
            this._costeMaximo = costeMaximo;
        }

        public override Expression<Func<Veneno, bool>> ToExpression()
        {
            return veneo => veneo.Coste <= _costeMaximo;
        }
    }
}
