using System;
using System.Linq.Expressions;

namespace ECM.Infrastructure
{
    public class OrSpecification<TEntity> : CompositeSpecification<TEntity>
    {
        #region Constructors and Destructors

        public OrSpecification(Specification<TEntity> leftSide, Specification<TEntity> rightSide)
            : base(leftSide, rightSide)
        {
        }

        #endregion

        #region Public Methods and Operators

        public override Expression<Func<TEntity, bool>> IsSatisfiedBy()
        {
            var invokedExpr = Expression.Invoke(
                RightSide.Predicate, LeftSide.Predicate.Parameters);
            return Expression.Lambda<Func<TEntity, bool>>(
                Expression.OrElse(RightSide.Predicate.Body, invokedExpr), LeftSide.Predicate.Parameters);
        }

        public OrSpecification<TEntity> Or(Specification<TEntity> specification)
        {
            return new OrSpecification<TEntity>(new Specification<TEntity>(IsSatisfiedBy()), specification);
        }

        #endregion
    }
}