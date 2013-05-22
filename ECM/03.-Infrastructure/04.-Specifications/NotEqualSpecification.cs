using System;
using System.Linq.Expressions;

namespace ECM.Infrastructure
{
    public class NotEqualSpecification<TEntity> : CompositeSpecification<TEntity>
    {
        #region Constructors and Destructors

        public NotEqualSpecification(Specification<TEntity> leftSide, Specification<TEntity> rightSide)
            : base(leftSide, rightSide)
        {
        }

        #endregion

        #region Public Methods and Operators

        public override Expression<Func<TEntity, bool>> IsSatisfiedBy()
        {
            var invokedExpr = Expression.Invoke(
                RightSide.Predicate, LeftSide.Predicate.Parameters);
            return
                Expression.Lambda<Func<TEntity, bool>>(
                    Expression.NotEqual(RightSide.Predicate.Body, invokedExpr), LeftSide.Predicate.Parameters);
        }

        #endregion
    }
}