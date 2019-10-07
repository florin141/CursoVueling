using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ControlPlagas.Core.Domain
{
    internal sealed class IdentitySpecification<TEntity> : Specification<TEntity> where TEntity : BaseEntity
    {
        public override Expression<Func<TEntity, bool>> ToExpression()
        {
            return x => true;
        }
    }

    public abstract class Specification<TEntity> where TEntity : BaseEntity
    {
        public static readonly Specification<TEntity> All = new IdentitySpecification<TEntity>();

        public bool IsSatisfiedBy(TEntity entity)
        {
            Func<TEntity, bool> predicate = ToExpression().Compile();
            return predicate(entity);
        }

        public abstract Expression<Func<TEntity, bool>> ToExpression();

        public Specification<TEntity> And(Specification<TEntity> specification)
        {
            if (this == All)
            {
                return specification;
            }
            if (specification == All)
            {
                return this;
            }

            return new AndSpecification<TEntity>(this, specification);
        }

        public Specification<TEntity> Or(Specification<TEntity> specification)
        {
            if (this == All || specification == All)
                return All;

            return new OrSpecification<TEntity>(this, specification);
        }

        public Specification<TEntity> Not()
        {
            return new NotSpecification<TEntity>(this);
        }
    }

    internal sealed class AndSpecification<TEntity> : Specification<TEntity> where TEntity : BaseEntity
    {
        private readonly Specification<TEntity> _left;
        private readonly Specification<TEntity> _right;

        public AndSpecification(Specification<TEntity> left, Specification<TEntity> right)
        {
            _left = left;
            _right = right;
        }

        public override Expression<Func<TEntity, bool>> ToExpression()
        {
            var leftExpression = _left.ToExpression();
            var rightExpression = _right.ToExpression();

            var andExpression = Expression.AndAlso(leftExpression.Body, rightExpression.Body);

            return Expression.Lambda<Func<TEntity, bool>>(andExpression, leftExpression.Parameters.Single());
        }
    }

    internal sealed class OrSpecification<TEntity> : Specification<TEntity> where TEntity : BaseEntity
    {
        private readonly Specification<TEntity> _left;
        private readonly Specification<TEntity> _right;

        public OrSpecification(Specification<TEntity> left, Specification<TEntity> right)
        {
            _left = left;
            _right = right;
        }

        public override Expression<Func<TEntity, bool>> ToExpression()
        {
            var leftExpression = _left.ToExpression();
            var rightExpression = _right.ToExpression();

            var orExpression = Expression.OrElse(leftExpression.Body, rightExpression.Body);

            return Expression.Lambda<Func<TEntity, bool>>(orExpression, leftExpression.Parameters.Single());
        }
    }

    internal sealed class NotSpecification<TEntity> : Specification<TEntity> where TEntity : BaseEntity
    {
        private readonly Specification<TEntity> _specification;

        public NotSpecification(Specification<TEntity> specification)
        {
            _specification = specification;
        }

        public override Expression<Func<TEntity, bool>> ToExpression()
        {
            var expression = _specification.ToExpression();

            var notExpression = Expression.Not(expression.Body);

            return Expression.Lambda<Func<TEntity, bool>>(notExpression, expression.Parameters.Single());
        }
    }
}
