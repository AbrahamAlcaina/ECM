using System;
using System.Linq.Expressions;

namespace ECM.Infrastructure
{
    public class AndSpecification<TEntity> : CompositeSpecification<TEntity>
    {
        #region Constructors and Destructors

        public AndSpecification(Specification<TEntity> leftSide, Specification<TEntity> rightSide)
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
                Expression.AndAlso(RightSide.Predicate.Body, invokedExpr), LeftSide.Predicate.Parameters);
        }

        public AndSpecification<TEntity> And(Specification<TEntity> specification)
        {
            return new AndSpecification<TEntity>(new Specification<TEntity>(IsSatisfiedBy()), specification);
        }

        #endregion
    }
}